#pragma checksum "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\ListProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45f4a050efa9d840350302a4c19902670bd3da57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DigitalBanking_ListProduct), @"mvc.1.0.view", @"/Views/DigitalBanking/ListProduct.cshtml")]
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
#line 1 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\ListProduct.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45f4a050efa9d840350302a4c19902670bd3da57", @"/Views/DigitalBanking/ListProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226e66e476153809e3942cb65fb4710596043976", @"/Views/_ViewImports.cshtml")]
    public class Views_DigitalBanking_ListProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VietbankWebsite.Entities.CategoryProduct>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/page/digital-banking-list-product.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 5 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\ListProduct.cshtml"
  
    Layout = "~/Views/Shared/_LayoutDigitalBanking.cshtml";

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
            BeginWriteAttribute("href", " href=\"", 458, "\"", 492, 1);
#nullable restore
#line 15 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\ListProduct.cshtml"
WriteAttributeValue("", 465, Localizer["NganHangSoUrl"], 465, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\ListProduct.cshtml"
                                                             Write(Localizer["NganHangSo"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 559, "\"", 592, 1);
#nullable restore
#line 16 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\ListProduct.cshtml"
WriteAttributeValue("", 566, Localizer["DichVuNHSUrl"], 566, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\ListProduct.cshtml"
                                                            Write(Localizer["DichVuNHS"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li class=\"active\"><span style=\"color: #999;\">");
#nullable restore
#line 17 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\ListProduct.cshtml"
                                                                 Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                    </ol>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <section class=\"banner-page imageBanner\">\r\n        <div");
            BeginWriteAttribute("style", " style=\"", 886, "\"", 934, 3);
            WriteAttributeValue("", 894, "background-image:url(\'", 894, 22, true);
#nullable restore
#line 24 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\ListProduct.cshtml"
WriteAttributeValue("", 916, Model.Thumbnail, 916, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 932, "\')", 932, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"imgBg\"></div>\r\n        <div class=\"desc\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-xs-12 col-sm-5 col-lg-5 col-xl-5\">\r\n                        <h1 class=\"title\">");
#nullable restore
#line 29 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\ListProduct.cshtml"
                                     Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <div class=\"content\">");
#nullable restore
#line 30 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\ListProduct.cshtml"
                                        Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</section>
<main>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12 col-lg-3"">
                <div class=""relative"">
                    <a href=""javascript:;"" class=""toggle-click""><i class=""fa fa-bars""></i>Danh mục</a>
                    <div class=""nav-toogle"">
                        <nav class=""left-menu"">
");
#nullable restore
#line 45 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\ListProduct.cshtml"
                             foreach (var item in Model.ListCategoryProduct)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 1870, "\"", 1906, 1);
#nullable restore
#line 47 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\ListProduct.cshtml"
WriteAttributeValue("", 1877, item.CategoryDetailShort.Url, 1877, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 47 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\ListProduct.cshtml"
                                                                   Write(item.CategoryDetailShort.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 48 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\ListProduct.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </nav>\r\n                    </div>\r\n                </div>\r\n");
            WriteLiteral(@"            </div>
            <div class=""col-xs-12 col-lg-9"">
                <section class=""sanpham-ds2"">
                    <div class=""row flex flex-wrap"" id=""list-product""></div>
                </section>
                <div class=""pages newspaper"">
                    <ul class=""pagination"" id=""pagination"">
                    </ul>
                </div>
            </div>
        </div>
    </div>
</main>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45f4a050efa9d840350302a4c19902670bd3da5710371", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VietbankWebsite.Entities.CategoryProduct> Html { get; private set; }
    }
}
#pragma warning restore 1591
