#pragma checksum "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNewsDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1ce36b417e2e81f9669f9b7bda283a4e6702b32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_VietbankNewsDetail), @"mvc.1.0.view", @"/Views/About/VietbankNewsDetail.cshtml")]
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
#line 1 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNewsDetail.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1ce36b417e2e81f9669f9b7bda283a4e6702b32", @"/Views/About/VietbankNewsDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226e66e476153809e3942cb65fb4710596043976", @"/Views/_ViewImports.cshtml")]
    public class Views_About_VietbankNewsDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VietbankWebsite.ModelMap.NewsDetail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/page/vietbank-news-detail.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNewsDetail.cshtml"
  
    Layout = "~/Views/Shared/_LayoutAbout.cshtml";

#line default
#line hidden
            WriteLiteral(@"
<section class=""banner-wrap"">
    <section class=""breadcrumb-wrap brown"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <ol class=""breadcrumb mrt-10"">
                        <li><a");
            BeginWriteAttribute("href", " href=\"", 448, "\"", 477, 1);
#line 14 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNewsDetail.cshtml"
WriteAttributeValue("", 455, Localizer["AboutUrl"], 455, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">");
#line 14 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNewsDetail.cshtml"
                                                        Write(Localizer["AboutName"]);

#line default
#line hidden
            WriteLiteral("</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 543, "\"", 571, 1);
#line 15 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNewsDetail.cshtml"
WriteAttributeValue("", 550, Localizer["NewsUrl"], 550, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">");
#line 15 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNewsDetail.cshtml"
                                                       Write(Localizer["NewsName"]);

#line default
#line hidden
            WriteLiteral("</a></li>\r\n                        <li class=\"active\"><span>");
#line 16 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNewsDetail.cshtml"
                                            Write(Localizer["VietbankNewsName"]);

#line default
#line hidden
            WriteLiteral(@"</span></li>
                    </ol>
                </div>
            </div>
        </div>
    </section>
    <section class=""vietbank-bg"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <h1 class=""blue"">");
#line 26 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNewsDetail.cshtml"
                                Write(Localizer["VietbankNewsName"]);

#line default
#line hidden
            WriteLiteral(@"</h1>
                </div>
            </div>
        </div>
    </section>
</section>
<main>
    <section class=""news-detail"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <ul class=""nav nav-bld"">
                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1328, "\"", 1364, 1);
#line 38 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNewsDetail.cshtml"
WriteAttributeValue("", 1335, Localizer["VietbankNewsUrl"], 1335, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" class=\"active\">");
#line 38 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNewsDetail.cshtml"
                                                                              Write(Localizer["VietbankNewsName"]);

#line default
#line hidden
            WriteLiteral("</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1452, "\"", 1489, 1);
#line 39 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNewsDetail.cshtml"
WriteAttributeValue("", 1459, Localizer["PromotionNewsUrl"], 1459, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">");
#line 39 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNewsDetail.cshtml"
                                                                Write(Localizer["PromotionNewsName"]);

#line default
#line hidden
            WriteLiteral("</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1563, "\"", 1598, 1);
#line 40 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNewsDetail.cshtml"
WriteAttributeValue("", 1570, Localizer["VietbannkTvUrl"], 1570, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">");
#line 40 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNewsDetail.cshtml"
                                                              Write(Localizer["VietbannkTvName"]);

#line default
#line hidden
            WriteLiteral("</a></li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-xs-12 col-md-8 col-lg-9\">\r\n                    <div class=\"news-content\">\r\n                        <h1>");
#line 47 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNewsDetail.cshtml"
                       Write(Model.Title);

#line default
#line hidden
            WriteLiteral("</h1>\r\n                        <div class=\"time-wrap clearfix\">\r\n                            <time>");
#line 49 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNewsDetail.cshtml"
                             Write(Model.PublishedDate);

#line default
#line hidden
            WriteLiteral("</time>\r\n                            <div class=\"social\"><img src=\"/img/social_icon.png\" alt=\"Social\"></div>\r\n                        </div>\r\n                        <div class=\"fullContent\">\r\n                            ");
#line 53 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\VietbankNewsDetail.cshtml"
                       Write(Html.Raw(Model.Content));

#line default
#line hidden
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""col-xs-12 col-md-4 col-lg-3"">
                    <div class=""other-news"">
                        <h2 id=""lst-random-news"">Tin khác</h2>
                        
                    </div>
                    <div class=""news-tags"">
                        <h3>Tags</h3>
                        <nav class=""nav""><a href=""#"">Vietbank</a><a href=""#"">Khuyến mãi</a><a href=""#"">Ngân hàng</a><a href=""#"">điện tử</a><a href=""#"">Vay vốn</a><a href=""#"">Gửi tiết kiệm</a><a href=""#"">Thanh toán</a></nav>
                    </div>
                </div>
            </div>
        </div>
    </section>
</main>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1ce36b417e2e81f9669f9b7bda283a4e6702b3210885", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VietbankWebsite.ModelMap.NewsDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591