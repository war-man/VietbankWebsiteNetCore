#pragma checksum "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5df14600b9439b430c16d26e8c24f89021863a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DigitalBanking_Product), @"mvc.1.0.view", @"/Views/DigitalBanking/Product.cshtml")]
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
#line 1 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5df14600b9439b430c16d26e8c24f89021863a6", @"/Views/DigitalBanking/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226e66e476153809e3942cb65fb4710596043976", @"/Views/_ViewImports.cshtml")]
    public class Views_DigitalBanking_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VietbankWebsite.Entities.CategoryProduct>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
  
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
            BeginWriteAttribute("href", " href=\"", 456, "\"", 490, 1);
#nullable restore
#line 14 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
WriteAttributeValue("", 463, Localizer["NganHangSoUrl"], 463, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 14 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
                                                             Write(Localizer["NganHangSo"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li class=\"active\"><span style=\"color: #999;\">");
#nullable restore
#line 15 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
                                                                 Write(Localizer["DichVuNHS"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                    </ol>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <section class=\"banner-page imageBanner\">\r\n        <div");
            BeginWriteAttribute("style", " style=\"", 796, "\"", 844, 3);
            WriteAttributeValue("", 804, "background-image:url(\'", 804, 22, true);
#nullable restore
#line 22 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
WriteAttributeValue("", 826, Model.Thumbnail, 826, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 842, "\')", 842, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"imgBg\"></div>\r\n        <div class=\"desc\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-xs-12 col-sm-5 col-lg-5 col-xl-5\">\r\n                        <h1 class=\"title\">");
#nullable restore
#line 27 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
                                     Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <div class=\"content\">");
#nullable restore
#line 28 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
                                        Write(Html.Raw(Model.Description));

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
    <section class=""sanpham-ds1"">
        <div class=""container"">
            <div class=""sanpham-wrap"">
                <div class=""row flex flex-wrap"">
");
#nullable restore
#line 40 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
                     foreach (var item in Model.ListCategoryProduct)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-xs-12 col-md-4 col-lg-4\">\r\n                            <div class=\"item-sp\">\r\n                                <figure>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1755, "\"", 1791, 1);
#nullable restore
#line 45 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
WriteAttributeValue("", 1762, item.CategoryDetailShort.Url, 1762, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img class=\"lazyload\" data-src=\"");
#nullable restore
#line 45 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
                                                                                                       Write(item.CategoryDetailShort.Thumbnail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("src", " src=\"", 1861, "\"", 1902, 1);
#nullable restore
#line 45 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
WriteAttributeValue("", 1867, item.CategoryDetailShort.Thumbnail, 1867, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1903, "\"", 1940, 1);
#nullable restore
#line 45 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
WriteAttributeValue("", 1909, item.CategoryDetailShort.Title, 1909, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                                    <figcaption>\r\n                                        <h3> <a");
            BeginWriteAttribute("href", " href=\"", 2045, "\"", 2081, 1);
#nullable restore
#line 47 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
WriteAttributeValue("", 2052, item.CategoryDetailShort.Url, 2052, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 47 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
                                                                                Write(item.CategoryDetailShort.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                        <ul>\r\n");
#nullable restore
#line 49 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
                                             foreach (var subItem in item.CategoryProductShorts)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2370, "\"", 2389, 1);
#nullable restore
#line 51 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
WriteAttributeValue("", 2377, subItem.Url, 2377, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 51 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
                                                                      Write(subItem.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 52 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </ul><a");
            BeginWriteAttribute("href", " href=\"", 2510, "\"", 2546, 1);
#nullable restore
#line 53 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
WriteAttributeValue("", 2517, item.CategoryDetailShort.Url, 2517, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"readMore\"><span>");
#nullable restore
#line 53 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
                                                                                                       Write(Localizer["ViewAllName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span><i class=\"fa fa-angle-right\"></i></a>\r\n                                    </figcaption>\r\n                                </figure>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 58 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>\r\n\r\n");
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
