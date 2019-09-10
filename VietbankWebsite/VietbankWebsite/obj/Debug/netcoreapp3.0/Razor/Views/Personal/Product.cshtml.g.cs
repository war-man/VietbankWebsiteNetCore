#pragma checksum "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "011b4d861e85e16610acf3ae050d121075c23085"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personal_Product), @"mvc.1.0.view", @"/Views/Personal/Product.cshtml")]
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
#line 1 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Product.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"011b4d861e85e16610acf3ae050d121075c23085", @"/Views/Personal/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226e66e476153809e3942cb65fb4710596043976", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VietbankWebsite.Entities.CategoryProduct>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Product.cshtml"
  
    Layout = "~/Views/Shared/_LayoutPersonal.cshtml";

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
            BeginWriteAttribute("href", " href=\"", 450, "\"", 482, 1);
#nullable restore
#line 14 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Product.cshtml"
WriteAttributeValue("", 457, Localizer["PersonalUrl"], 457, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 14 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Product.cshtml"
                                                           Write(Localizer["PersonalName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li class=\"active\"><span style=\"color: #999;\">");
#nullable restore
#line 15 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Product.cshtml"
                                                                 Write(Localizer["ProductName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                    </ol>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <section class=\"banner-page imageBanner\">\r\n        <div");
            BeginWriteAttribute("style", " style=\"", 792, "\"", 840, 3);
            WriteAttributeValue("", 800, "background-image:url(\'", 800, 22, true);
#nullable restore
#line 22 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Product.cshtml"
WriteAttributeValue("", 822, Model.Thumbnail, 822, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 838, "\')", 838, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"imgBg\"></div>\r\n        <div class=\"desc\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-xs-12 col-sm-5 col-lg-5 col-xl-5\">\r\n                        <h1 class=\"title\">");
#nullable restore
#line 27 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Product.cshtml"
                                     Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <div class=\"content\">");
#nullable restore
#line 28 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Product.cshtml"
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
#line 40 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Product.cshtml"
                     foreach (var item in Model.ListCategoryProduct)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-xs-12 col-md-4 col-lg-4\">\r\n                            <div class=\"item-sp\">\r\n                                <figure>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1751, "\"", 1787, 1);
#nullable restore
#line 45 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Product.cshtml"
WriteAttributeValue("", 1758, item.CategoryDetailShort.Url, 1758, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 1793, "\"", 1834, 1);
#nullable restore
#line 45 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Product.cshtml"
WriteAttributeValue("", 1799, item.CategoryDetailShort.Thumbnail, 1799, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1835, "\"", 1872, 1);
#nullable restore
#line 45 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Product.cshtml"
WriteAttributeValue("", 1841, item.CategoryDetailShort.Title, 1841, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                                    <figcaption>\r\n                                        <h3> <a");
            BeginWriteAttribute("href", " href=\"", 1977, "\"", 2013, 1);
#nullable restore
#line 47 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Product.cshtml"
WriteAttributeValue("", 1984, item.CategoryDetailShort.Url, 1984, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 47 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Product.cshtml"
                                                                                Write(item.CategoryDetailShort.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                        <ul>\r\n");
#nullable restore
#line 49 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Product.cshtml"
                                             foreach (var subItem in item.CategoryProductShorts)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2302, "\"", 2321, 1);
#nullable restore
#line 51 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Product.cshtml"
WriteAttributeValue("", 2309, subItem.Url, 2309, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 51 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Product.cshtml"
                                                                      Write(subItem.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 52 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Product.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </ul><a");
            BeginWriteAttribute("href", " href=\"", 2442, "\"", 2478, 1);
#nullable restore
#line 53 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Product.cshtml"
WriteAttributeValue("", 2449, item.CategoryDetailShort.Url, 2449, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"readMore\"><span>");
#nullable restore
#line 53 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Product.cshtml"
                                                                                                       Write(Localizer["ViewAllName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span><i class=\"fa fa-angle-right\"></i></a>\r\n                                    </figcaption>\r\n                                </figure>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 58 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Product.cshtml"
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
