#pragma checksum "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26458b12d6d29bd95d163e37f3d655fd5efbd917"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partial__MainHeaderCard), @"mvc.1.0.view", @"/Views/Partial/_MainHeaderCard.cshtml")]
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
#line 1 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderCard.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26458b12d6d29bd95d163e37f3d655fd5efbd917", @"/Views/Partial/_MainHeaderCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226e66e476153809e3942cb65fb4710596043976", @"/Views/_ViewImports.cshtml")]
    public class Views_Partial__MainHeaderCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""header-main"">
    <div class=""container"">
        <div class=""header-wrap"">
            <div class=""btn-showmenu""><i class=""material-icons"">menu</i></div>
            <div class=""overlay""></div>
            <div class=""sitelogo""><a href=""/""><img class=""lazyload"" data-src=""/img/logo.png"" src=""/img/logo.png""");
            BeginWriteAttribute("alt", " alt=\"", 404, "\"", 410, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a></div>
            <div class=""search d-block d-lg-none"">
                <div class=""search-toggle""><i class=""material-icons"">search</i></div>
                <div class=""search-wrap"">
                    <div class=""searchbox"">
                        <input type=""text"">
                        <button class=""searchbutton""><i class=""fa fa-search"" aria-hidden=""true""></i></button>
                    </div>
                </div>
            </div>
            <div class=""menu"">
                <div class=""btn-closemenu""><i class=""material-icons"">close</i></div>
                <div class=""menu-logo"">
                    <div class=""sitelogo""><a href=""/""><img class=""lazyload"" data-src=""/img/logo.png"" src=""/img/logo.png""");
            BeginWriteAttribute("alt", " alt=\"", 1158, "\"", 1164, 0);
            EndWriteAttribute();
            WriteLiteral("></a></div>\r\n                </div>\r\n                <div class=\"menu-wrap\">\r\n                    <ul class=\"menu-link\">\r\n                        <li class=\"has-sub\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1363, "\"", 1392, 1);
#nullable restore
#line 26 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderCard.cshtml"
WriteAttributeValue("", 1370, Localizer["OfferUrl"], 1370, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderCard.cshtml"
                                                        Write(Localizer["OfferName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <div class=\"btn-showsub\"></div>\r\n                            <div class=\"sub\">\r\n                                <ul>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1611, "\"", 1644, 1);
#nullable restore
#line 30 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderCard.cshtml"
WriteAttributeValue("", 1618, Localizer["PromotionUrl"], 1618, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1645, "\"", 1653, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 30 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderCard.cshtml"
                                                                                 Write(Localizer["PromotionName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1735, "\"", 1769, 1);
#nullable restore
#line 31 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderCard.cshtml"
WriteAttributeValue("", 1742, Localizer["MasterCardUrl"], 1742, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1770, "\"", 1778, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderCard.cshtml"
                                                                                  Write(Localizer["MasterCardName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                </ul>\r\n                            </div>\r\n                        </li>\r\n                        <li class=\"has-sub active\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2008, "\"", 2039, 1);
#nullable restore
#line 36 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderCard.cshtml"
WriteAttributeValue("", 2015, Localizer["ProductUrl"], 2015, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 36 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderCard.cshtml"
                                                          Write(Localizer["ProductName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <div class=\"btn-showsub\"></div>\r\n                            <div class=\"sub\">\r\n                                <ul>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2260, "\"", 2307, 1);
#nullable restore
#line 40 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderCard.cshtml"
WriteAttributeValue("", 2267, Localizer["VietbankLuxuryPlataniumUrl"], 2267, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 40 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderCard.cshtml"
                                                                                      Write(Localizer["VietbankLuxuryPlataniumName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2403, "\"", 2444, 1);
#nullable restore
#line 41 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderCard.cshtml"
WriteAttributeValue("", 2410, Localizer["VietbankPlataniumUrl"], 2410, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 41 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderCard.cshtml"
                                                                                Write(Localizer["VietbankPlataniumName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2534, "\"", 2574, 1);
#nullable restore
#line 42 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderCard.cshtml"
WriteAttributeValue("", 2541, Localizer["VietabankMyStyleUrl"], 2541, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 42 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderCard.cshtml"
                                                                               Write(Localizer["VietabankMyStyleName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2663, "\"", 2700, 1);
#nullable restore
#line 43 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderCard.cshtml"
WriteAttributeValue("", 2670, Localizer["VietbankDebitUrl"], 2670, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 43 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderCard.cshtml"
                                                                            Write(Localizer["VietbankDebitName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                </ul>\r\n                            </div>\r\n                        </li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2880, "\"", 2911, 1);
#nullable restore
#line 47 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderCard.cshtml"
WriteAttributeValue("", 2887, Localizer["SupportUrl"], 2887, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 47 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderCard.cshtml"
                                                          Write(Localizer["SupportName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                    </ul>\r\n                </div>\r\n                <div class=\"ebanking\"><a");
            BeginWriteAttribute("href", " href=\"", 3040, "\"", 3081, 1);
#nullable restore
#line 50 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderCard.cshtml"
WriteAttributeValue("", 3047, Localizer["NganHangTrucTuyenUrl"], 3047, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-unlock-alt\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 50 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Partial\_MainHeaderCard.cshtml"
                                                                                                                                  Write(Localizer["NganHangTrucTuyen"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></div>
                <div class=""branch d-block d-md-none""><a href=""#!""><i class=""fa fa-map-marker"" aria-hidden=""true""></i>ATMs & Chi nhánh</a></div>
                <div class=""hotline d-block d-md-none""><a href=""tel:1800 1122""><i class=""fa fa-phone"" aria-hidden=""true""></i>Hotline: 1800 1122</a></div>
            </div>
        </div>
    </div>
</div>");
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
