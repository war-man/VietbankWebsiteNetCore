#pragma checksum "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20064c87d80e223115e27800a13019eb72e570dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Card_Product), @"mvc.1.0.view", @"/Views/Card/Product.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20064c87d80e223115e27800a13019eb72e570dc", @"/Views/Card/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226e66e476153809e3942cb65fb4710596043976", @"/Views/_ViewImports.cshtml")]
    public class Views_Card_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VietbankWebsite.ModelMap.CardProductHomeDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Product.cshtml"
  
    Layout = "~/Views/Shared/_LayoutCard.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"breadcrumb-wrap\">\r\n    <div class=\"breadcrumb-content\">\r\n        <div class=\"container\">\r\n            ");
#nullable restore
#line 9 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Product.cshtml"
       Write(Html.Raw(Model.SiteMap));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"page-banner\">\r\n        <div class=\"banner-img\"><img");
            BeginWriteAttribute("src", " src=\"", 351, "\"", 368, 1);
#nullable restore
#line 13 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Product.cshtml"
WriteAttributeValue("", 357, Model.Path, 357, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 369, "\"", 375, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n        <div class=\"container\">\r\n            <div class=\"banner-caption\">\r\n                <div class=\"big\">");
#nullable restore
#line 16 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Product.cshtml"
                            Write(Model.TitleBoxOne);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"des\">");
#nullable restore
#line 17 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Product.cshtml"
                            Write(Model.DescriptionBoxOne);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<section class=\"product-section\">\r\n    <div class=\"container\">\r\n        <h1 class=\"home-title text-center\">");
#nullable restore
#line 24 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Product.cshtml"
                                      Write(Model.TitleBoxTwo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <div class=\"home-content text-center\" style=\"max-width:680px\">\r\n            <div class=\"content\">");
#nullable restore
#line 26 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Product.cshtml"
                            Write(Model.DescriptionBoxTwo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n        <div class=\"product-list\">\r\n            ");
#nullable restore
#line 29 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Product.cshtml"
       Write(Html.Raw(Model.ContentBoxTwo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VietbankWebsite.ModelMap.CardProductHomeDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
