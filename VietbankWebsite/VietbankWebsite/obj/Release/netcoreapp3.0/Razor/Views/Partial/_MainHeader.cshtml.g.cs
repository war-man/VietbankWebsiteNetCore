#pragma checksum "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeader.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "518c6ec39fedb8571631877989c3a898aa608074"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partial__MainHeader), @"mvc.1.0.view", @"/Views/Partial/_MainHeader.cshtml")]
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
#line 1 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeader.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"518c6ec39fedb8571631877989c3a898aa608074", @"/Views/Partial/_MainHeader.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226e66e476153809e3942cb65fb4710596043976", @"/Views/_ViewImports.cshtml")]
    public class Views_Partial__MainHeader : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Partial/_MenuMobile.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<section class=\"main-header\">\r\n    <div class=\"container\">\r\n        <div class=\"logo\"><a href=\"/\"><img src=\"/img/logo.png\"");
            BeginWriteAttribute("alt", " alt=\"", 202, "\"", 208, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a></div>
        <div class=""btn-showmenu""> <i class=""fa fa-bars""></i></div>
        <div class=""overlay""></div>
        <div class=""main-menu"">
            <div class=""btn-closemenu"">X</div>
            <div class=""menu-content"">
                <ul>
                    <li><a");
            BeginWriteAttribute("href", " href=\"", 497, "\"", 527, 1);
#line 12 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeader.cshtml"
WriteAttributeValue("", 504, Localizer["CaNhanUrl"], 504, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">");
#line 12 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeader.cshtml"
                                                     Write(Localizer["CaNhan"]);

#line default
#line hidden
            WriteLiteral("</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 586, "\"", 621, 1);
#line 13 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeader.cshtml"
WriteAttributeValue("", 593, Localizer["DoanhNghiepUrl"], 593, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">");
#line 13 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeader.cshtml"
                                                          Write(Localizer["DoanhNghiep"]);

#line default
#line hidden
            WriteLiteral("</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 685, "\"", 712, 1);
#line 14 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeader.cshtml"
WriteAttributeValue("", 692, Localizer["TheUrl"], 692, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">");
#line 14 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeader.cshtml"
                                                  Write(Localizer["The"]);

#line default
#line hidden
            WriteLiteral("</a></li>\r\n                </ul>\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "518c6ec39fedb8571631877989c3a898aa6080746124", async() => {
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
            WriteLiteral("\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 866, "\"", 907, 1);
#line 18 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeader.cshtml"
WriteAttributeValue("", 873, Localizer["NganHangTrucTuyenUrl"], 873, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-ibanking\"><i class=\"fa fa-unlock-alt\"></i><span>");
#line 18 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeader.cshtml"
                                                                                                               Write(Localizer["NganHangTrucTuyen"]);

#line default
#line hidden
            WriteLiteral("</span></a>\r\n            <div class=\"top-contact\">\r\n                <div class=\"location\">\r\n                    <i class=\"fa fa-map-marker\"> </i>\r\n                    <p><a");
            BeginWriteAttribute("href", " href=\"", 1171, "\"", 1178, 0);
            EndWriteAttribute();
            WriteLiteral(@">ATM &amp; Chi nhánh</a></p>
                </div>
                <div class=""phone"">
                    <i class=""fa fa-phone""></i>
                    <p>Hotline: <strong> <a data-tel=""+8419001122"">1800 1122</a></strong></p>
                </div>
            </div>
            <nav class=""tool-link clearfix"">
                <ul>
                    <li> <i class=""fa fa-usd""></i><a href=""tygia.html"" title=""title"">Tỷ giá</a></li>
                    <li> <i class=""fa fa-map-marker""></i><a href=""mangluoi.html"" title=""title"">Mạng lưới</a></li>
                    <li> <i class=""fa fa-file-text-o""></i><a href=""bieumau-bieuphi.html"" title=""title"">Biểu mẫu</a></li>
                    <li> <i class=""fa fa-gift""></i><a href=""#"" title=""title"">Khuyến mãi</a></li>
                    <li> <i class=""fa fa-comments-o""></i><a href=""hoidap.html"" title=""title"">Hỗ trợ</a></li>
                    <li> <i class=""fa fa-phone""></i><a href=""lienhe.html"" title=""title"">Liên hệ</a></li>
                </ul>
 ");
            WriteLiteral("           </nav>\r\n        </div>\r\n    </div>\r\n</section>");
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
