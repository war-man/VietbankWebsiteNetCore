#pragma checksum "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Enterprise\ListProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9889ee97853c9561db65f05b46c85dff67c28ef5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Enterprise_ListProduct), @"mvc.1.0.view", @"/Views/Enterprise/ListProduct.cshtml")]
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
#line 1 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Enterprise\ListProduct.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9889ee97853c9561db65f05b46c85dff67c28ef5", @"/Views/Enterprise/ListProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226e66e476153809e3942cb65fb4710596043976", @"/Views/_ViewImports.cshtml")]
    public class Views_Enterprise_ListProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VietbankWebsite.Entities.CategoryProduct>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/page/enterprise-list-product.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Enterprise\ListProduct.cshtml"
  
    Layout = "~/Views/Shared/_LayoutEnterprise.cshtml";

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
            BeginWriteAttribute("href", " href=\"", 452, "\"", 486, 1);
#nullable restore
#line 14 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Enterprise\ListProduct.cshtml"
WriteAttributeValue("", 459, Localizer["EnterpriseUrl"], 459, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 14 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Enterprise\ListProduct.cshtml"
                                                             Write(Localizer["EnterpriseName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 557, "\"", 588, 1);
#nullable restore
#line 15 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Enterprise\ListProduct.cshtml"
WriteAttributeValue("", 564, Localizer["ProductUrl"], 564, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Enterprise\ListProduct.cshtml"
                                                          Write(Localizer["ProductName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li class=\"active\"><span style=\"color: #999;\">");
#nullable restore
#line 16 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Enterprise\ListProduct.cshtml"
                                                                 Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                    </ol>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <section class=\"banner-page imageBanner\">\r\n        <div");
            BeginWriteAttribute("style", " style=\"", 884, "\"", 932, 3);
            WriteAttributeValue("", 892, "background-image:url(\'", 892, 22, true);
#nullable restore
#line 23 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Enterprise\ListProduct.cshtml"
WriteAttributeValue("", 914, Model.Thumbnail, 914, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 930, "\')", 930, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"imgBg\"></div>\r\n        <div class=\"desc\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-xs-12 col-sm-5 col-lg-5 col-xl-5\">\r\n                        <h1 class=\"title\">");
#nullable restore
#line 28 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Enterprise\ListProduct.cshtml"
                                     Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <div class=\"content\">");
#nullable restore
#line 29 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Enterprise\ListProduct.cshtml"
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
#line 44 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Enterprise\ListProduct.cshtml"
                             foreach (var item in Model.ListCategoryProduct)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 1868, "\"", 1904, 1);
#nullable restore
#line 46 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Enterprise\ListProduct.cshtml"
WriteAttributeValue("", 1875, item.CategoryDetailShort.Url, 1875, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 46 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Enterprise\ListProduct.cshtml"
                                                                   Write(item.CategoryDetailShort.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 47 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Enterprise\ListProduct.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </nav>
                    </div>
                </div>
                <div class=""banner-ads""><a href=""#""><img class=""lazyload"" data-src=""/img/sanpham-ds2/ads_banner1.png"" src=""/img/sanpham-ds2/ads_banner1.png"" alt=""Ads""></a></div>
            </div>
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9889ee97853c9561db65f05b46c85dff67c28ef510407", async() => {
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
