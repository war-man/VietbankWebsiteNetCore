using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using reCAPTCHA.AspNetCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using System.Threading.Tasks;
using Vietbank.Core;
using VietbankWebsite.Context;
using VietbankWebsite.Extensions;
using VietbankWebsite.HostedService;
using VietbankWebsite.Middleware;
using VietbankWebsite.Models;
using VietbankWebsite.Repository;
using VietbankWebsite.Service;
using VietbankWebsite.Uow;

namespace VietbankWebsite
{
    public class Startup
    {
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment _hostingEnvironment;
        private readonly IList<ModuleInfo> _modules = new List<ModuleInfo>();

        [System.Obsolete]
        public Startup(IConfiguration configuration, Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            LoadInstalledModules();
            services.AddMemoryCache();
            services.AddTransient<IHomeRepository, HomeRepository>();
            services.AddTransient<IHomeService, HomeService>();

            services.AddTransient<IShareholderService, ShareholderService>();
            services.AddTransient<IShareholderRepository, ShareholderRepository>();

            services.AddTransient<IAboutVietbankService, AboutVietbankService>();
            services.AddTransient<IAboutVietbankRepository, AboutVietbankRepository>();

            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IProductRepository, ProductRepository>();

            services.AddTransient<ICardService, CardService>();
            services.AddTransient<ICardRepository, CardRepository>();

            services.AddTransient<ICareersService, CareersService>();
            services.AddTransient<ICareersRepository, CareersRepository>();

            services.AddTransient<IBranchService, BranchService>();
            services.AddTransient<IBranchRepository, BranchRepository>();

            services.AddTransient<ISupportService, SupportService>();
            services.AddTransient<ISupportRepository, SupportRepository>();

            services.AddTransient<IEmailSenderRepository, EmailSenderRepository>();
            services.AddTransient<IRazorViewToStringRenderer, RazorViewToStringRenderer>();

            services.AddTransient<IVbPostSeoRepository, VbPostSeoRepository>();
            services.AddTransient<IVbPostSeoService, VbPostSeoService>();

            services.AddTransient<IRequestLogRepository, RequestLogRepository>();
            services.AddTransient<IRequestLogService, RequestLogService>();

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddLocalization(options => options.ResourcesPath = "Resources");
            var supportedCultures = new[]
            {
                new CultureInfo("vi"),
                new CultureInfo("en"),
            };

            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new RequestCulture("vi");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });
            services.AddDbContext<VietbankContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            //services.AddDefaultIdentity<IdentityUser>()
            //    .AddRoles<IdentityRole>()
            //    .AddEntityFrameworkStores<ApplicationDbContext>();

            services.Configure<RazorViewEngineOptions>(options =>
            {
                options.ViewLocationExpanders.Add(new ModuleViewLocationExpander());
            });
            
            var mvcBuilder = services.AddMvc(options => {
                options.Filters.Add(new ResponseCacheAttribute() { NoStore = true, Location = ResponseCacheLocation.None });
            })
            .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
            .AddDataAnnotationsLocalization();

            foreach (var module in _modules)
            {
                mvcBuilder.AddApplicationPart(module.Assembly);

                var moduleInitializerType = module.Assembly.GetTypes().Where(x => typeof(IModuleInitializer).IsAssignableFrom(x)).FirstOrDefault();
                if (moduleInitializerType != null && moduleInitializerType != typeof(IModuleInitializer))
                {
                    var moduleInitializer = (IModuleInitializer)Activator.CreateInstance(moduleInitializerType);
                    moduleInitializer.Init(services);
                }
            }
            var recaptcha = Configuration.GetSection("RecaptchaSettings");
            if (!recaptcha.Exists())
                throw new ArgumentException("Missing RecaptchaSettings in configuration.");

            services.Configure<RecaptchaSettings>(recaptcha);
            services.AddTransient<IRecaptchaService, RecaptchaService>();
            services.Configure<EmailSender>(Configuration.GetSection("EmailSender"));
            services.Configure<RemoteService>(Configuration.GetSection("RemoteService"));
            services.Configure<MessageQueueConfig>(Configuration.GetSection("MessageQueueConfig"));

            services.AddDetection();
            //services.AddHostedService<GenerateSiteMapHostedService>();
            //services.AddHostedService<QueueCentralHostedService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseStatusCodePagesWithReExecute("/Home/NotFoundPage");
                app.UseExceptionHandler("/Home/NotFoundPage");
                app.UseHsts();
            }
            //app.UseMiddleware<RequestComputeMiddleware>();
            app.UseMiddleware<FixDetectionMiddleware>();
            app.UseMiddleware<CultureMiddleware>();
            app.UseRequestLocalization();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            // Serving static file for modules
            foreach (var module in _modules)
            {
                var wwwrootDir = new DirectoryInfo(Path.Combine(module.Path, "wwwroot"));
                if (!wwwrootDir.Exists)
                {
                    continue;
                }

                app.UseStaticFiles(new StaticFileOptions()
                {
                    FileProvider = new PhysicalFileProvider(wwwrootDir.FullName),
                    RequestPath = new PathString("/" + module.ShortName)
                });
            }
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }

        private void LoadInstalledModules()
        {
            var moduleRootFolder = new DirectoryInfo(Path.Combine(_hostingEnvironment.ContentRootPath, "Modules"));
            var moduleFolders = moduleRootFolder.GetDirectories();

            foreach (var moduleFolder in moduleFolders)
            {
                var binFolder = new DirectoryInfo(Path.Combine(moduleFolder.FullName, "bin"));
                if (!binFolder.Exists)
                {
                    continue;
                }

                foreach (var file in binFolder.GetFileSystemInfos("*.dll", SearchOption.AllDirectories))
                {
                    Assembly assembly;
                    try
                    {
                        assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(file.FullName);
                    }
                    catch (FileLoadException ex)
                    {
                        if (ex.Message == "Assembly with same name is already loaded")
                        {
                            // Get loaded assembly
                            assembly = Assembly.Load(new AssemblyName(Path.GetFileNameWithoutExtension(file.Name)));
                        }
                        else
                        {
                            throw;
                        }
                    }

                    if (assembly.FullName.Contains(moduleFolder.Name))
                    {
                        _modules.Add(new ModuleInfo { Name = moduleFolder.Name, Assembly = assembly, Path = moduleFolder.FullName });
                    }
                }
            }

            GlobalConfigurationCore.Modules = _modules;
        }
    }
}
