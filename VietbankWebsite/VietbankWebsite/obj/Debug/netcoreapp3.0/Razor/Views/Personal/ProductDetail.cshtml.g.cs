#pragma checksum "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3728428f71804510bfc6e2ae7e939135b6c65d3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personal_ProductDetail), @"mvc.1.0.view", @"/Views/Personal/ProductDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3728428f71804510bfc6e2ae7e939135b6c65d3a", @"/Views/Personal/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226e66e476153809e3942cb65fb4710596043976", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VietbankWebsite.Entities.ProductDetail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""banner-wrap"">
    <section class=""breadcrumb-wrap"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <ol class=""breadcrumb mrt-10"">
                        <li><a");
            BeginWriteAttribute("href", " href=\"", 358, "\"", 385, 1);
#nullable restore
#line 11 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
WriteAttributeValue("", 365, ViewBag.PersonalUrl, 365, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 11 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
                                                      Write(ViewBag.PersonalName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 449, "\"", 475, 1);
#nullable restore
#line 12 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
WriteAttributeValue("", 456, ViewBag.ProductUrl, 456, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
                                                     Write(ViewBag.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 538, "\"", 563, 1);
#nullable restore
#line 13 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
WriteAttributeValue("", 545, Model.CategoryUrl, 545, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 13 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
                                                    Write(Model.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li class=\"active\"><span style=\"color:#999;\">");
#nullable restore
#line 14 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
                                                                Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                    </ol>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <section class=\"banner-page imageBanner\">\r\n        <div");
            BeginWriteAttribute("style", " style=\"", 852, "\"", 900, 3);
            WriteAttributeValue("", 860, "background-image:url(\'", 860, 22, true);
#nullable restore
#line 21 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
WriteAttributeValue("", 882, Model.Thumbnail, 882, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 898, "\')", 898, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"imgBg\"></div>\r\n        <div class=\"desc\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-xs-12 col-sm-5 col-lg-5 col-xl-5\">\r\n                        <h1 class=\"title\">");
#nullable restore
#line 26 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
                                     Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <div class=\"content\">");
#nullable restore
#line 27 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
                                        Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</section>\r\n<main>\r\n    ");
#nullable restore
#line 35 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
Write(Html.Raw(Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <section class=\"pagination-prd\">\r\n        <div class=\"container\">\r\n            <div class=\"row flex flex-wrap\">\r\n                <div class=\"col-xs-12 col-md-4\">\r\n");
#nullable restore
#line 40 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
                     if (@Model.PrevNextProduct.ElementAt(0) != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"prev-link\"><a");
            BeginWriteAttribute("href", " href=\"", 1702, "\"", 1748, 1);
#nullable restore
#line 42 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
WriteAttributeValue("", 1709, Model.PrevNextProduct.ElementAt(0).Url, 1709, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-chevron-left\" aria-hidden=\"true\"></i><span>");
#nullable restore
#line 42 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
                                                                                                                                                       Write(Model.PrevNextProduct.ElementAt(0).Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a></div>\r\n");
#nullable restore
#line 43 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-xs-12 col-md-4\">\r\n                    <div class=\"prd-list\"><a");
            BeginWriteAttribute("href", " href=\"", 2012, "\"", 2037, 1);
#nullable restore
#line 47 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
WriteAttributeValue("", 2019, Model.CategoryUrl, 2019, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-bars\" aria-hidden=\"true\"></i><span>");
#nullable restore
#line 47 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
                                                                                                                     Write(Model.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a></div>\r\n                </div>\r\n                <div class=\"col-xs-12 col-md-4\">\r\n");
#nullable restore
#line 50 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
                     if (Model.PrevNextProduct.Count() > 1)
                    {
                        if (Model.PrevNextProduct.ElementAt(1) != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"next-link\"><a");
            BeginWriteAttribute("href", " href=\"", 2439, "\"", 2485, 1);
#nullable restore
#line 54 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
WriteAttributeValue("", 2446, Model.PrevNextProduct.ElementAt(1).Url, 2446, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span>");
#nullable restore
#line 54 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
                                                                                                      Write(Model.PrevNextProduct.ElementAt(1).Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><i class=\"fa fa-chevron-right\" aria-hidden=\"true\"></i></a></div>\r\n");
#nullable restore
#line 55 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VietbankWebsite.Entities.ProductDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
