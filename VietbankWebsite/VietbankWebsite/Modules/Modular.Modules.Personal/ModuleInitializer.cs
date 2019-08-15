using System;
using Microsoft.Extensions.DependencyInjection;
using Modular.Modules.Personal.Repository;
using Modular.Modules.Personal.Service;
using Vietbank.Core;

namespace Modular.Modules.Personal
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void Init(IServiceCollection services)
        {
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<IStudentService, StudentService>();
        }
    }
}
