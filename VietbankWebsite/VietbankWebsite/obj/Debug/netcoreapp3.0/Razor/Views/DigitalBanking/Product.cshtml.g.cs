#pragma checksum "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10be8b642896830ec08cf97c79981e45f5e590a8"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10be8b642896830ec08cf97c79981e45f5e590a8", @"/Views/DigitalBanking/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226e66e476153809e3942cb65fb4710596043976", @"/Views/_ViewImports.cshtml")]
    public class Views_DigitalBanking_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
  
    ViewData["Title"] = Localizer["DichVuNHS"].Value;
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
            BeginWriteAttribute("href", " href=\"", 515, "\"", 549, 1);
#nullable restore
#line 15 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
WriteAttributeValue("", 522, Localizer["NganHangSoUrl"], 522, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
                                                             Write(Localizer["NganHangSo"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li class=\"active\"><span style=\"color: #999;\">");
#nullable restore
#line 16 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
                                                                 Write(Localizer["DichVuNHS"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></li>
                    </ol>
                </div>
            </div>
        </div>
    </section>
    <section class=""banner-page imageBanner"">
        <div style=""background-image:url('/img/banner_page/vietbank-bg.jpg')"" class=""imgBg""></div>
        <div class=""desc"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xs-12 col-sm-5 col-lg-5 col-xl-5"">
                        <h1 class=""title"">");
#nullable restore
#line 28 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
                                     Write(Localizer["DichVuNHS"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            WriteLiteral(@"                    </div>
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
            WriteLiteral("\r\n                    <div class=\"col-xs-12 col-md-4 col-lg-4\">\r\n                        <div class=\"item-sp\">\r\n                            <figure>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2890, "\"", 2927, 1);
#nullable restore
#line 64 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
WriteAttributeValue("", 2897, Localizer["MobileBankingUrl"], 2897, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img class=\"lazyload\" data-src=\"https://static.vietbank.com.vn/web/SPCN/NganHangTrucTuyen/Mobilebanking/mobile-banking.jpg\" src=\"https://static.vietbank.com.vn/web/SPCN/NganHangTrucTuyen/Mobilebanking/mobile-banking.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 3149, "\"", 3186, 1);
#nullable restore
#line 64 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
WriteAttributeValue("", 3155, Localizer["MobileBankingName"], 3155, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                                <figcaption>\r\n                                    <h3> <a");
            BeginWriteAttribute("href", " href=\"", 3283, "\"", 3320, 1);
#nullable restore
#line 66 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
WriteAttributeValue("", 3290, Localizer["MobileBankingUrl"], 3290, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 66 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
                                                                             Write(Localizer["MobileBankingName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></h3>
                                </figcaption>
                            </figure>
                        </div>
                    </div>
                    <div class=""col-xs-12 col-md-4 col-lg-4"">
                        <div class=""item-sp"">
                            <figure>
                                <a");
            BeginWriteAttribute("href", " href=\"", 3692, "\"", 3735, 1);
#nullable restore
#line 74 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
WriteAttributeValue("", 3699, Localizer["InternetBankingNameUrl"], 3699, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img class=\"lazyload\" data-src=\"https://static.vietbank.com.vn/web/SPCN/NganHangTrucTuyen/Mobilebanking/internet-banking_1.jpg\" src=\"https://static.vietbank.com.vn/web/SPCN/NganHangTrucTuyen/Mobilebanking/internet-banking_1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 3965, "\"", 4004, 1);
#nullable restore
#line 74 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
WriteAttributeValue("", 3971, Localizer["InternetBankingName"], 3971, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                                <figcaption>\r\n                                    <h3> <a");
            BeginWriteAttribute("href", " href=\"", 4101, "\"", 4144, 1);
#nullable restore
#line 76 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
WriteAttributeValue("", 4108, Localizer["InternetBankingNameUrl"], 4108, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 76 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
                                                                                   Write(Localizer["InternetBankingName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></h3>
                                </figcaption>
                            </figure>
                        </div>
                    </div>
                    <div class=""col-xs-12 col-md-4 col-lg-4"">
                        <div class=""item-sp"">
                            <figure>
                                <a");
            BeginWriteAttribute("href", " href=\"", 4518, "\"", 4552, 1);
#nullable restore
#line 84 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
WriteAttributeValue("", 4525, Localizer["SmsBankingUrl"], 4525, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img class=\"lazyload\" data-src=\"https://static.vietbank.com.vn/web/SAN%20PHAM%20DN/ngan-hang-truc-tuyen/3.3-sms-bao-thay-doi-so-du.jpg\" src=\"https://static.vietbank.com.vn/web/SAN%20PHAM%20DN/ngan-hang-truc-tuyen/3.3-sms-bao-thay-doi-so-du.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 4798, "\"", 4832, 1);
#nullable restore
#line 84 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
WriteAttributeValue("", 4804, Localizer["SmsBankingName"], 4804, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                                <figcaption>\r\n                                    <h3> <a");
            BeginWriteAttribute("href", " href=\"", 4929, "\"", 4963, 1);
#nullable restore
#line 86 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
WriteAttributeValue("", 4936, Localizer["SmsBankingUrl"], 4936, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 86 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\Product.cshtml"
                                                                          Write(Localizer["SmsBankingName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                </figcaption>\r\n                            </figure>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>\r\n\r\n");
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