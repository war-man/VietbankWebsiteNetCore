#pragma checksum "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\PromotionNews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "209b260cbd7635ee48c860758ac3f0f8c06c2128"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DigitalBanking_PromotionNews), @"mvc.1.0.view", @"/Views/DigitalBanking/PromotionNews.cshtml")]
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
#line 2 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\PromotionNews.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"209b260cbd7635ee48c860758ac3f0f8c06c2128", @"/Views/DigitalBanking/PromotionNews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226e66e476153809e3942cb65fb4710596043976", @"/Views/_ViewImports.cshtml")]
    public class Views_DigitalBanking_PromotionNews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VietbankWebsite.ModelMap.TopThreeNewsToCate>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/page/personal-promotion-news.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\PromotionNews.cshtml"
  
    Layout = "~/Views/Shared/_LayoutDigitalBanking.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""banner-wrap"">
    <section class=""breadcrumb-wrap brown"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <ol class=""breadcrumb mrt-10"">
                        <li><a");
            BeginWriteAttribute("href", " href=\"", 478, "\"", 512, 1);
#nullable restore
#line 14 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\PromotionNews.cshtml"
WriteAttributeValue("", 485, Localizer["NganHangSoUrl"], 485, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 14 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\PromotionNews.cshtml"
                                                             Write(Localizer["NganHangSo"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li style=\"color: #999;\" class=\"active\"><strong>");
#nullable restore
#line 15 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\PromotionNews.cshtml"
                                                                   Write(Localizer["CTKhuyenMai"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></li>
                    </ol>
                </div>
            </div>
        </div>
    </section>
    <section class=""VietBank-bg"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <h1 class=""blue"">");
#nullable restore
#line 25 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\PromotionNews.cshtml"
                                Write(Localizer["CTKhuyenMai"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                                                                                                                                            </h1>
                </div>
            </div>
        </div>
    </section>
</section>
<section class=""news-special"">
    <div class=""container"">
        <div class=""slider"">
            <div class=""owl-carousel"">
");
#nullable restore
#line 35 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\PromotionNews.cshtml"
                 foreach (var news in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"item-newspecial\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-xs-12 col-md-8\">\r\n                                <div class=\"thumb\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1693, "\"", 1709, 1);
#nullable restore
#line 41 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\PromotionNews.cshtml"
WriteAttributeValue("", 1700, news.Url, 1700, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <img class=\"lazyload\" data-src=\"");
#nullable restore
#line 42 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\PromotionNews.cshtml"
                                                                   Write(news.Thumbnail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("src", " src=\"", 1801, "\"", 1822, 1);
#nullable restore
#line 42 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\PromotionNews.cshtml"
WriteAttributeValue("", 1807, news.Thumbnail, 1807, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1823, "\"", 1840, 1);
#nullable restore
#line 42 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\PromotionNews.cshtml"
WriteAttributeValue("", 1829, news.Title, 1829, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    </a>
                                </div>
                            </div>
                            <div class=""col-xs-12 col-md-4"">
                                <div class=""title-news"">
                                    <h4>Tin mới nhất</h4>
                                    <time>");
#nullable restore
#line 49 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\PromotionNews.cshtml"
                                     Write(news.PublishDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</time>\r\n                                </div>\r\n                                <h1 class=\"title\"><a");
            BeginWriteAttribute("href", " href=\"", 2324, "\"", 2340, 1);
#nullable restore
#line 51 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\PromotionNews.cshtml"
WriteAttributeValue("", 2331, news.Url, 2331, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 51 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\PromotionNews.cshtml"
                                                                 Write(news.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h1>\r\n                                <div class=\"brief\">");
#nullable restore
#line 52 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\PromotionNews.cshtml"
                                              Write(Html.Raw(news.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 56 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\DigitalBanking\PromotionNews.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</section>
<main>
    <section class=""news-list"">
        <div class=""container"">
            <div id=""lst-news"" class=""row flex flex-wrap""></div>
            <div class=""pages newspaper"">
                <ul id=""pagination"" class=""pagination"">
                </ul>
            </div>
        </div>
    </section>
</main>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "209b260cbd7635ee48c860758ac3f0f8c06c212811274", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VietbankWebsite.ModelMap.TopThreeNewsToCate>> Html { get; private set; }
    }
}
#pragma warning restore 1591