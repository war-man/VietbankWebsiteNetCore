#pragma checksum "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af76520ce696486e3d5c0ca97abbb75d6fbaab0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partial__MainHeaderAbout), @"mvc.1.0.view", @"/Views/Partial/_MainHeaderAbout.cshtml")]
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
#line 1 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af76520ce696486e3d5c0ca97abbb75d6fbaab0a", @"/Views/Partial/_MainHeaderAbout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226e66e476153809e3942cb65fb4710596043976", @"/Views/_ViewImports.cshtml")]
    public class Views_Partial__MainHeaderAbout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Partial/_MenuMobile.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Partial/_ToolLinkMobile.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section class=\"main-header\">\r\n    <div class=\"container\">\r\n        <div class=\"logo\"><a href=\"/\"><img class=\"lazyload\" data-src=\"/img/logo.png\" src=\"/img/logo.png\"");
            BeginWriteAttribute("alt", " alt=\"", 244, "\"", 250, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a></div>
        <div class=""btn-showmenu""> <i class=""fa fa-bars""></i></div>
        <div class=""overlay""></div>
        <div class=""main-menu"">
            <div class=""btn-closemenu"">X</div>
            <div class=""menu-content"">
                <ul>
                    <li class=""dropdown"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 582, "\"", 615, 1);
#nullable restore
#line 13 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
WriteAttributeValue("", 589, Localizer["GioiThieuUrl"], 589, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"dropdown\" class=\"dropdown-toggle\">");
#nullable restore
#line 13 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
                                                                                                       Write(Localizer["GioiThieuName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"caret\"><i class=\"fa fa-caret-down\"></i></span></a>\r\n                        <ul class=\"dropdown-menu\">\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 842, "\"", 883, 1);
#nullable restore
#line 15 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
WriteAttributeValue("", 849, Localizer["QuaTrinhPhatTrienUrl"], 849, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
                                                                        Write(Localizer["QuaTrinhPhatTrienName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 965, "\"", 1002, 1);
#nullable restore
#line 16 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
WriteAttributeValue("", 972, Localizer["TamNhinSuMenhUrl"], 972, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
                                                                    Write(Localizer["TamNhinSuMenhName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1080, "\"", 1110, 1);
#nullable restore
#line 17 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
WriteAttributeValue("", 1087, Localizer["ThuNgoUrl"], 1087, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
                                                             Write(Localizer["ThuNgoName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1181, "\"", 1214, 1);
#nullable restore
#line 18 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
WriteAttributeValue("", 1188, Localizer["ChatLuongUrl"], 1188, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
                                                                Write(Localizer["ChatLuongName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1288, "\"", 1319, 1);
#nullable restore
#line 19 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
WriteAttributeValue("", 1295, Localizer["TuanThuUrl"], 1295, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
                                                              Write(Localizer["TuanThuName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1391, "\"", 1428, 1);
#nullable restore
#line 20 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
WriteAttributeValue("", 1398, Localizer["NganHangDaiLyUrl"], 1398, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
                                                                    Write(Localizer["NganHangDaiLyName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        </ul>\r\n                    </li>\r\n                    <li class=\"dropdown\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1599, "\"", 1633, 1);
#nullable restore
#line 24 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
WriteAttributeValue("", 1606, Localizer["BanLanhDaoUrl"], 1606, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"dropdown\" class=\"dropdown-toggle\">");
#nullable restore
#line 24 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
                                                                                                        Write(Localizer["BanLanhDaoName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"caret\"><i class=\"fa fa-caret-down\"></i></span></a>\r\n                        <ul class=\"dropdown-menu\">\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1861, "\"", 1899, 1);
#nullable restore
#line 26 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
WriteAttributeValue("", 1868, Localizer["HoiDongQuanTriUrl"], 1868, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
                                                                     Write(Localizer["HoiDongQuanTriName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1978, "\"", 2013, 1);
#nullable restore
#line 27 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
WriteAttributeValue("", 1985, Localizer["BanKiemSoatUrl"], 1985, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
                                                                  Write(Localizer["BanKiemSoatName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2089, "\"", 2124, 1);
#nullable restore
#line 28 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
WriteAttributeValue("", 2096, Localizer["BanDieuHanhUrl"], 2096, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
                                                                  Write(Localizer["BanDieuHanhName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        </ul>\r\n                    </li>\r\n                    <li class=\"dropdown\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2293, "\"", 2323, 1);
#nullable restore
#line 32 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
WriteAttributeValue("", 2300, Localizer["TinTucUrl"], 2300, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"dropdown\" class=\"dropdown-toggle\">");
#nullable restore
#line 32 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
                                                                                                    Write(Localizer["TinTucName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"caret\"><i class=\"fa fa-caret-down\"></i></span></a>\r\n                        <ul class=\"dropdown-menu\">\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2547, "\"", 2582, 1);
#nullable restore
#line 34 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
WriteAttributeValue("", 2554, Localizer["TinVietbankUrl"], 2554, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 34 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
                                                                  Write(Localizer["TinVietbankName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2658, "\"", 2694, 1);
#nullable restore
#line 35 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
WriteAttributeValue("", 2665, Localizer["TinKhuyenMaiUrl"], 2665, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 35 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
                                                                   Write(Localizer["TinKhuyenMaiName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2771, "\"", 2805, 1);
#nullable restore
#line 36 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
WriteAttributeValue("", 2778, Localizer["VietbankTvUrl"], 2778, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 36 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
                                                                 Write(Localizer["VietbankTvName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2880, "\"", 2920, 1);
#nullable restore
#line 37 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
WriteAttributeValue("", 2887, Localizer["VietbankHandbookUrl"], 2887, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 37 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
                                                                       Write(Localizer["VietbankHandbookName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        </ul>\r\n                    </li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 3051, "\"", 3081, 1);
#nullable restore
#line 40 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
WriteAttributeValue("", 3058, Localizer["LienHeUrl"], 3058, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 40 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderAbout.cshtml"
                                                     Write(Localizer["LienHeName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                </ul>\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "af76520ce696486e3d5c0ca97abbb75d6fbaab0a18644", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "af76520ce696486e3d5c0ca97abbb75d6fbaab0a19773", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
