#pragma checksum "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1bfd16a1cfc7d7fb261c69b8649aa70d8036267"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_VietbankNews), @"mvc.1.0.view", @"/Views/About/VietbankNews.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\_ViewImports.cshtml"
using VietbankWebsite;

#line default
#line hidden
#line 2 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\_ViewImports.cshtml"
using VietbankWebsite.Models;

#line default
#line hidden
#line 2 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNews.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1bfd16a1cfc7d7fb261c69b8649aa70d8036267", @"/Views/About/VietbankNews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226e66e476153809e3942cb65fb4710596043976", @"/Views/_ViewImports.cshtml")]
    public class Views_About_VietbankNews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VietbankWebsite.ModelMap.TopThreeNewsToCate>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/page/vietbank-news.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNews.cshtml"
  
    Layout = "~/Views/Shared/_LayoutAbout.cshtml";

#line default
#line hidden
            WriteLiteral(@"<section class=""banner-wrap"">
    <section class=""breadcrumb-wrap brown"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <ol class=""breadcrumb mrt-10"">
                        <li><a");
            BeginWriteAttribute("href", " href=\"", 467, "\"", 496, 1);
#line 13 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNews.cshtml"
WriteAttributeValue("", 474, Localizer["AboutUrl"], 474, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">");
#line 13 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNews.cshtml"
                                                        Write(Localizer["AboutName"]);

#line default
#line hidden
            WriteLiteral("</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 562, "\"", 590, 1);
#line 14 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNews.cshtml"
WriteAttributeValue("", 569, Localizer["NewsUrl"], 569, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">");
#line 14 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNews.cshtml"
                                                       Write(Localizer["NewsName"]);

#line default
#line hidden
            WriteLiteral("</a></li>\r\n                        <li style=\"color: #999;\" class=\"active\"><strong>");
#line 15 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNews.cshtml"
                                                                   Write(Localizer["VietbankNewsName"]);

#line default
#line hidden
            WriteLiteral(@"</strong></li>
                    </ol>
                </div>
            </div>
        </div>
    </section>
    <section class=""VietBank-bg"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <h1 class=""blue"">");
#line 25 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNews.cshtml"
                                Write(Localizer["VietbankNewsName"]);

#line default
#line hidden
            WriteLiteral(@"                                                                                                                                                                                            </h1>
                </div>
            </div>
        </div>
    </section>
</section>
<section class=""news-special"">
    <div class=""container"">
        <div class=""slider"">
            <div class=""owl-carousel"">
");
#line 35 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNews.cshtml"
                 foreach (var news in Model)
                {

#line default
#line hidden
            WriteLiteral("                    <div class=\"item-newspecial\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-xs-12 col-md-8\">\r\n                                <div class=\"thumb\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1779, "\"", 1795, 1);
#line 41 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNews.cshtml"
WriteAttributeValue("", 1786, news.Url, 1786, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 1843, "\"", 1864, 1);
#line 42 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNews.cshtml"
WriteAttributeValue("", 1849, news.Thumbnail, 1849, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1865, "\"", 1882, 1);
#line 42 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNews.cshtml"
WriteAttributeValue("", 1871, news.Title, 1871, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(@">
                                    </a>
                                </div>
                            </div>
                            <div class=""col-xs-12 col-md-4"">
                                <div class=""title-news"">
                                    <h4>Tin mới nhất</h4>
                                    <time>");
#line 49 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNews.cshtml"
                                     Write(news.PublishDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
            WriteLiteral("</time>\r\n                                </div>\r\n                                <h1 class=\"title\"><a");
            BeginWriteAttribute("href", " href=\"", 2366, "\"", 2382, 1);
#line 51 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNews.cshtml"
WriteAttributeValue("", 2373, news.Url, 2373, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">");
#line 51 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNews.cshtml"
                                                                 Write(news.Title);

#line default
#line hidden
            WriteLiteral("</a></h1>\r\n                                <div class=\"brief\">");
#line 52 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNews.cshtml"
                                              Write(Html.Raw(news.Description));

#line default
#line hidden
            WriteLiteral("</div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#line 56 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNews.cshtml"
                }

#line default
#line hidden
            WriteLiteral(@"            </div>
        </div>
    </div>
</section>
<main>
    <section class=""news-list"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <ul class=""nav nav-bld"">
                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2889, "\"", 2917, 1);
#line 67 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNews.cshtml"
WriteAttributeValue("", 2896, Localizer["NewsUrl"], 2896, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">");
#line 67 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNews.cshtml"
                                                       Write(Localizer["AllNewsName"]);

#line default
#line hidden
            WriteLiteral("</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2985, "\"", 3021, 1);
#line 68 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNews.cshtml"
WriteAttributeValue("", 2992, Localizer["VietbankNewsUrl"], 2992, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" class=\"active\">");
#line 68 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNews.cshtml"
                                                                              Write(Localizer["VietbankNewsName"]);

#line default
#line hidden
            WriteLiteral("</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 3109, "\"", 3146, 1);
#line 69 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNews.cshtml"
WriteAttributeValue("", 3116, Localizer["PromotionNewsUrl"], 3116, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">");
#line 69 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNews.cshtml"
                                                                Write(Localizer["PromotionNewsName"]);

#line default
#line hidden
            WriteLiteral("</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 3220, "\"", 3255, 1);
#line 70 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNews.cshtml"
WriteAttributeValue("", 3227, Localizer["VietbannkTvUrl"], 3227, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">");
#line 70 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNews.cshtml"
                                                              Write(Localizer["VietbannkTvName"]);

#line default
#line hidden
            WriteLiteral(@"</a></li>
                    </ul>
                </div>
            </div>
            <div id=""lst-news"" class=""row flex flex-wrap""></div>
            <div class=""pages newspaper"">
                <ul class=""pagination"">
                    <li class=""active""><span>1</span></li>
                    <li><a href=""#"">2</a></li>
                    <li><a href=""#"">3</a></li>
                </ul>
            </div>
        </div>
    </section>
</main>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1bfd16a1cfc7d7fb261c69b8649aa70d803626713764", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VietbankWebsite.ModelMap.TopThreeNewsToCate>> Html { get; private set; }
    }
}
#pragma warning restore 1591
