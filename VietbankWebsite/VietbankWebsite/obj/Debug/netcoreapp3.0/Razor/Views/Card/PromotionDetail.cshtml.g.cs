#pragma checksum "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\PromotionDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12d6f7ef7aba75b4b52f01cdc9473fe01ef83300"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Card_PromotionDetail), @"mvc.1.0.view", @"/Views/Card/PromotionDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12d6f7ef7aba75b4b52f01cdc9473fe01ef83300", @"/Views/Card/PromotionDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226e66e476153809e3942cb65fb4710596043976", @"/Views/_ViewImports.cshtml")]
    public class Views_Card_PromotionDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VietbankWebsite.ModelMap.IncentivesPostTwoDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\PromotionDetail.cshtml"
  
    Layout = "~/Views/Shared/_LayoutCard.cshtml";

#line default
#line hidden
            WriteLiteral("<section class=\"breadcrumb-wrap\">\r\n    <div class=\"breadcrumb-content\">\r\n        <div class=\"container\">\r\n            ");
#line 8 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\PromotionDetail.cshtml"
       Write(Html.Raw(Model.SiteMap));

#line default
#line hidden
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n<!--<section class=\"banner-section\">\r\n    <div class=\"banner owl-carousel\" style=\"background: #005baa\">\r\n        <div class=\"item\"><a class=\"banner-img\" href=\"#!\"><img src=\"");
#line 14 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\PromotionDetail.cshtml"
                                                               Write(Model.PathBanner);

#line default
#line hidden
            WriteLiteral("\" alt=\"\"></a></div>\r\n    </div>\r\n</section>-->\r\n");
#line 17 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\PromotionDetail.cshtml"
Write(Html.Raw(Model.Content));

#line default
#line hidden
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VietbankWebsite.ModelMap.IncentivesPostTwoDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
