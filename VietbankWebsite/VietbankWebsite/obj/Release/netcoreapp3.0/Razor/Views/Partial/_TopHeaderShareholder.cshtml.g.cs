#pragma checksum "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_TopHeaderShareholder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b3a56b4a5de0c3c516c7396ee6eb93b1c8c65ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partial__TopHeaderShareholder), @"mvc.1.0.view", @"/Views/Partial/_TopHeaderShareholder.cshtml")]
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
#line 1 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_TopHeaderShareholder.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b3a56b4a5de0c3c516c7396ee6eb93b1c8c65ca", @"/Views/Partial/_TopHeaderShareholder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226e66e476153809e3942cb65fb4710596043976", @"/Views/_ViewImports.cshtml")]
    public class Views_Partial__TopHeaderShareholder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Partial/_SearchInfor.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Partial/_SelectLanguagePartial.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<section class=\"top\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-xs-12 col-sm-12 col-md-12 col-lg-5 col-xl-6\">\r\n                <section class=\"top-menu\">\r\n                    <ul>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 334, "\"", 365, 1);
#line 9 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_TopHeaderShareholder.cshtml"
WriteAttributeValue("", 341, Localizer["SanPhamUrl"], 341, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 366, "\"", 395, 1);
#line 9 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_TopHeaderShareholder.cshtml"
WriteAttributeValue("", 374, Localizer["SanPham"], 374, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">");
#line 9 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_TopHeaderShareholder.cshtml"
                                                                                        Write(Localizer["SanPham"]);

#line default
#line hidden
            WriteLiteral("</a></li>\r\n                        <li class=\"active\"> <a");
            BeginWriteAttribute("href", " href=\"", 475, "\"", 511, 1);
#line 10 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_TopHeaderShareholder.cshtml"
WriteAttributeValue("", 482, Localizer["QuanHeCoDongUrl"], 482, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 512, "\"", 546, 1);
#line 10 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_TopHeaderShareholder.cshtml"
WriteAttributeValue("", 520, Localizer["QuanHeCoDong"], 520, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">");
#line 10 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_TopHeaderShareholder.cshtml"
                                                                                                                  Write(Localizer["QuanHeCoDong"]);

#line default
#line hidden
            WriteLiteral("</a></li>\r\n                        <li> <a");
            BeginWriteAttribute("href", " href=\"", 616, "\"", 649, 1);
#line 11 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_TopHeaderShareholder.cshtml"
WriteAttributeValue("", 623, Localizer["TuyenDungUrl"], 623, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 650, "\"", 681, 1);
#line 11 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_TopHeaderShareholder.cshtml"
WriteAttributeValue("", 658, Localizer["TuyenDung"], 658, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">");
#line 11 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_TopHeaderShareholder.cshtml"
                                                                                             Write(Localizer["TuyenDung"]);

#line default
#line hidden
            WriteLiteral("</a></li>\r\n                        <li> <a");
            BeginWriteAttribute("href", " href=\"", 748, "\"", 782, 1);
#line 12 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_TopHeaderShareholder.cshtml"
WriteAttributeValue("", 755, Localizer["VeVietBankUrl"], 755, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 783, "\"", 815, 1);
#line 12 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_TopHeaderShareholder.cshtml"
WriteAttributeValue("", 791, Localizer["VeVietBank"], 791, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">");
#line 12 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_TopHeaderShareholder.cshtml"
                                                                                               Write(Localizer["VeVietBank"]);

#line default
#line hidden
            WriteLiteral(@"</a></li>
                    </ul>
                </section>
            </div>
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-7 col-xl-6"">
                <section class=""top-misc"">
                    <div class=""top-contact"">
                        <div class=""location"">
                            <i class=""fa fa-map-marker""> </i>
                            <p><a");
            BeginWriteAttribute("href", " href=\"", 1237, "\"", 1269, 1);
#line 21 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_TopHeaderShareholder.cshtml"
WriteAttributeValue("", 1244, Localizer["ChiNhanhUrl"], 1244, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">ATM &amp; ");
#line 21 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_TopHeaderShareholder.cshtml"
                                                                        Write(Localizer["ChiNhanh"]);

#line default
#line hidden
            WriteLiteral(@"</a></p>
                        </div>
                        <div class=""phone"">
                            <i class=""fa fa-phone""></i>
                            <p>Hotline: <strong> <a data-tel=""+8419001122"">1800 1122</a></strong></p>
                        </div>
                    </div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1b3a56b4a5de0c3c516c7396ee6eb93b1c8c65ca9832", async() => {
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
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1b3a56b4a5de0c3c516c7396ee6eb93b1c8c65ca10968", async() => {
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
            WriteLiteral("\r\n                </section>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
