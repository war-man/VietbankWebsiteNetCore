#pragma checksum "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\YouNeed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "baa6529c68b979e466b1a3f8b342a552e981a9a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personal_YouNeed), @"mvc.1.0.view", @"/Views/Personal/YouNeed.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baa6529c68b979e466b1a3f8b342a552e981a9a9", @"/Views/Personal/YouNeed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226e66e476153809e3942cb65fb4710596043976", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_YouNeed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "-1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\YouNeed.cshtml"
  
    ViewData["Title"] = "YouNeed";
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
                        <li><a href=""index.html"">Cá nhân</a></li>
                        <li class=""active""><span>Bạn cần</span></li>
                    </ol>
                </div>
            </div>
        </div>
    </section>
    <section class=""banner-page imageBanner"">
        <div style=""background-image:url('/img/banner_page/banner_bancan.png')"" class=""imgBg""></div>
        <div class=""desc"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xs-12 col-sm-5 col-lg-5 col-xl-5"">
                        <h1 class=""title"">Bạn cần</h1>
                        <div class=""content"">Vietbank thấu hiểu mọi nhu cầu của bạn</div>
                    </div>
                </div>
            </div>
        </div>
 ");
            WriteLiteral("   </section>\r\n    <section class=\"choose-need\">\r\n        <div class=\"container\">\r\n            <select name=\"gender\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baa6529c68b979e466b1a3f8b342a552e981a9a95540", async() => {
                WriteLiteral("Chọn các nhu cầu bạn cần tìm...");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baa6529c68b979e466b1a3f8b342a552e981a9a96740", async() => {
                WriteLiteral("Nhu cầu vay mua nhà");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baa6529c68b979e466b1a3f8b342a552e981a9a97928", async() => {
                WriteLiteral("Nhu cầu vậy mua ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </select>
        </div>
    </section>
</section>
<main>
    <section class=""bancan-ds"">
        <div class=""container"">
            <div class=""row flex flex-wrap"">
                <div class=""col-xs-12 col-md-6 col-lg-3 item-bcWrap"">
                    <div class=""item-bc op-1"">
                        <div class=""thumb""><a href=""bancan-ct.html""><img class=""lazyload"" data-src=""/img/bancan/bancan_img1.png"" src=""/img/bancan/bancan_img1.png""");
            BeginWriteAttribute("alt", " alt=\"", 1905, "\"", 1911, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a></div>
                        <div class=""caption"">
                            <h4><a href=""bancan-ct.html"">Chiếc xe hoàn hảo</a></h4>
                            <div class=""desc"">Lái ngay về nhà chiếc xe hoàn hảo mà bạn muốn chỉ với thủ tục đơn giản vỏn vẹn trong vòng 8h tại Vietbank.</div>
                        </div>
                    </div>
                </div>
                <div class=""col-xs-12 col-md-6 col-lg-3 item-bcWrap"">
                    <div class=""item-bc op-2"">
                        <div class=""caption"">
                            <h4><a href=""bancan-ct.html"">Ngôi nhà trong mơ</a></h4>
                            <div class=""desc"">Vietbank mang giấc mơ “An cư –Lạc nghiệp” đến gần hơn với mọi gia đình Việt.</div>
                        </div>
                        <div class=""thumb""><a href=""bancan-ct.html""><img class=""lazyload"" data-src=""/img/bancan/bancan_img2.png"" src=""/img/bancan/bancan_img2.png""");
            BeginWriteAttribute("alt", " alt=\"", 2876, "\"", 2882, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a></div>
                    </div>
                </div>
                <div class=""col-xs-12 col-md-6 col-lg-3 item-bcWrap"">
                    <div class=""item-bc op-3"">
                        <div class=""thumb""><a href=""bancan-ct.html""><img class=""lazyload"" data-src=""/img/bancan/bancan_img3.png"" src=""/img/bancan/bancan_img3.png""");
            BeginWriteAttribute("alt", " alt=\"", 3229, "\"", 3235, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a></div>
                        <div class=""caption"">
                            <h4><a href=""bancan-ct.html"">Ước mơ du học</a></h4>
                            <div class=""desc"">Thấu hiểu những lo lắng của bạn, hãy để chúng tôi chia sẻ và đồng hành cùng bạn qua sản phẩm Cho vay du học với nhiều tiện ích hấp dẫn.</div>
                        </div>
                    </div>
                </div>
                <div class=""col-xs-12 col-md-6 col-lg-3 item-bcWrap"">
                    <div class=""item-bc op-4"">
                        <div class=""caption"">
                            <h4><a href=""bancan-ct.html"">Phát triển kinh doanh</a></h4>
                            <div class=""desc"">Luôn sát cánh tạo điều kiện tài chính thuận lợi để bạn có thể nắm bắt cơ hội thực hiện ước mơ gầy dựng một doanh nghiệp thành công.</div>
                        </div>
                        <div class=""thumb""><a href=""bancan-ct.html""><img class=""lazyload"" data-src=""/img/bancan/bancan_img4.png"" src=""/img");
            WriteLiteral("/bancan/bancan_img4.png\"");
            BeginWriteAttribute("alt", " alt=\"", 4284, "\"", 4290, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a></div>
                    </div>
                </div>
            </div>
            <div class=""row flex flex-wrap"">
                <div class=""col-xs-12 col-md-6 col-lg-3 item-bcWrap"">
                    <div class=""item-bc op-5"">
                        <div class=""thumb""><a href=""bancan-ct.html""><img class=""lazyload"" data-src=""/img/bancan/bancan_img5.png"" src=""/img/bancan/bancan_img5.png""");
            BeginWriteAttribute("alt", " alt=\"", 4703, "\"", 4709, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a></div>
                        <div class=""caption"">
                            <h4><a href=""bancan-ct.html"">Kinh doanh chứng khoán</a></h4>
                            <div class=""desc"">Tự tin thử sức mình qua việc kinh doanh chứng khoán khi không còn bất kỳ băn khoăn về vốn.</div>
                        </div>
                    </div>
                </div>
                <div class=""col-xs-12 col-md-6 col-lg-3 item-bcWrap"">
                    <div class=""item-bc op-6"">
                        <div class=""caption"">
                            <h4><a href=""bancan-ct.html"">Tiêu dùng thông minh </a></h4>
                            <div class=""desc"">Chúng tôi sẽ giúp bạn chủ động nguồn tài chính chi trả cho các nhu cầu cuộc sống như: cưới hỏi, du lịch, mua xe, đóng học phí, các chi phí phát sinh đột xuất</div>
                        </div>
                        <div class=""thumb""><a href=""bancan-ct.html""><img class=""lazyload"" data-src=""/img/bancan/bancan_img6.png"" src=""/img/bancan/ba");
            WriteLiteral("ncan_img6.png\"");
            BeginWriteAttribute("alt", " alt=\"", 5748, "\"", 5754, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a></div>
                    </div>
                </div>
                <div class=""col-xs-12 col-md-6 col-lg-3 item-bcWrap"">
                    <div class=""item-bc op-7"">
                        <div class=""thumb""><a href=""bancan-ct.html""><img class=""lazyload"" data-src=""/img/bancan/bancan_img7.png"" src=""/img/bancan/bancan_img7.png""");
            BeginWriteAttribute("alt", " alt=\"", 6101, "\"", 6107, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a></div>
                        <div class=""caption"">
                            <h4><a href=""bancan-ct.html"">Tích lũy hưu trí</a></h4>
                            <div class=""desc"">Chủ động tích lũy ngay hôm nay để an hưởng tuổi già trọn vẹn.</div>
                        </div>
                    </div>
                </div>
                <div class=""col-xs-12 col-md-6 col-lg-3 item-bcWrap"">
                    <div class=""item-bc op-8"">
                        <div class=""caption"">
                            <h4><a href=""bancan-ct.html"">Tích lũy tương lai</a></h4>
                            <div class=""desc"">Bạn sẽ không phải  lo lắng vì số tiền mình đang có còn khiêm tốnvà  mong muốn tối đa hóa lợi nhuận đối với số tiền tiết kiệm của mình sẽ vô cùng đơn giản.</div>
                        </div>
                        <div class=""thumb""><a href=""bancan-ct.html""><img class=""lazyload"" data-src=""/img/bancan/bancan_img8.png"" src=""/img/bancan/bancan_img8.png""");
            BeginWriteAttribute("alt", " alt=\"", 7105, "\"", 7111, 0);
            EndWriteAttribute();
            WriteLiteral("></a></div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
