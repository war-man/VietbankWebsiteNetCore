#pragma checksum "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "095fed45786a0ea1658f1605f3ff5ceb5e1e49b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Careers), @"mvc.1.0.view", @"/Views/Home/Careers.cshtml")]
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
#nullable restore
#line 1 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\_ViewImports.cshtml"
using VietbankWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\_ViewImports.cshtml"
using VietbankWebsite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"095fed45786a0ea1658f1605f3ff5ceb5e1e49b3", @"/Views/Home/Careers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226e66e476153809e3942cb65fb4710596043976", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Careers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VietbankWebsite.ModelMap.Careers>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/page/career-search.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
  
    Layout = "~/Views/Shared/_LayoutCareers.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""banner-wrap"">
    <section class=""breadcrumb-wrap"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <ol class=""breadcrumb mrt-10"">
                        <li><a");
            BeginWriteAttribute("href", " href=\"", 441, "\"", 474, 1);
#nullable restore
#line 14 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
WriteAttributeValue("", 448, Localizer["TuyenDungUrl"], 448, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 14 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
                                                            Write(Localizer["TuyenDungName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 544, "\"", 583, 1);
#nullable restore
#line 15 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
WriteAttributeValue("", 551, Localizer["CoHoiNgheNghiepUrl"], 551, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
                                                                  Write(Localizer["CoHoiNgheNghiepName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li class=\"active\"><span style=\"color:#999;\">");
#nullable restore
#line 16 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
                                                                Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                    </ol>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <section class=\"banner-page imageBanner\">\r\n        <div");
            BeginWriteAttribute("style", " style=\"", 886, "\"", 930, 3);
            WriteAttributeValue("", 894, "background-image:url(\'", 894, 22, true);
#nullable restore
#line 23 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
WriteAttributeValue("", 916, Model.Image, 916, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 928, "\')", 928, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"imgBg\"></div>\r\n        <div class=\"desc\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-xs-12 col-sm-5 col-lg-5 col-xl-5\">\r\n                        <h1 class=\"title\">");
#nullable restore
#line 28 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
                                     Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                    </div>
                </div>
            </div>
        </div>
    </section>
</section>
<main>
    <section class=""tuyendung-wrap"">
        <br />
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""search-job"">
                        <input");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1546, "\"", 1580, 1);
#nullable restore
#line 42 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
WriteAttributeValue("", 1560, Localizer["TuKhoa"], 1560, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"keyword\" class=\"field\">\r\n                        <select name=\"career\" class=\"career\">\r\n");
#nullable restore
#line 44 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
                             foreach (var item in Model.VbCareerList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "095fed45786a0ea1658f1605f3ff5ceb5e1e49b38625", async() => {
#nullable restore
#line 46 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
                                                    Write(item.CareerName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 47 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                        <select name=\"address\" class=\"address\">\r\n");
#nullable restore
#line 50 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
                             foreach (var item in Model.VbCareerCity)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "095fed45786a0ea1658f1605f3ff5ceb5e1e49b311143", async() => {
#nullable restore
#line 52 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
                                                    Write(item.CityName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 53 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                        <button id=\"search-career\" class=\"btn-filter\">");
#nullable restore
#line 55 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
                                                                 Write(Localizer["TimKiem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                    </div>\r\n                    <div class=\"table-responsive\">\r\n                        <div class=\"search-items\">\r\n                            <div class=\"jobs-title\">\r\n                                <div class=\"position\">");
#nullable restore
#line 60 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
                                                 Write(Localizer["ViTriTuyenDung"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <div class=\"employment\">");
#nullable restore
#line 61 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
                                                   Write(Localizer["NoiLamViec"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <div class=\"date-posted\">");
#nullable restore
#line 62 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
                                                    Write(Localizer["NgayDang"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n                            <div id=\"list-career\">\r\n");
#nullable restore
#line 65 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
                                 foreach (var item in Model.CareerJobList)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"jobs-item\">\r\n                                        <div class=\"job_head\">\r\n                                            <div class=\"job-title\"><a");
            BeginWriteAttribute("href", " href=\"", 3189, "\"", 3205, 1);
#nullable restore
#line 69 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
WriteAttributeValue("", 3196, item.Url, 3196, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 69 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
                                                                                  Write(item.JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n                                            <div class=\"job-place\">");
#nullable restore
#line 70 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
                                                              Write(item.JobCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                            <div class=\"job-date\">\r\n                                                ");
#nullable restore
#line 72 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
                                           Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 73 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
                                                 if (item.IsHot)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"status hot\">Hot</span>\r\n");
#nullable restore
#line 76 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"status new\">New</span>\r\n");
#nullable restore
#line 80 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 85 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Home\Careers.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "095fed45786a0ea1658f1605f3ff5ceb5e1e49b318779", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VietbankWebsite.ModelMap.Careers> Html { get; private set; }
    }
}
#pragma warning restore 1591
