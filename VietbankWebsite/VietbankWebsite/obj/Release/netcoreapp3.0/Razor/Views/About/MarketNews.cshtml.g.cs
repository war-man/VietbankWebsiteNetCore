#pragma checksum "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\MarketNews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f7799fa38a69f9db65c381c1840699d331ffebd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_MarketNews), @"mvc.1.0.view", @"/Views/About/MarketNews.cshtml")]
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
#line 2 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\MarketNews.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f7799fa38a69f9db65c381c1840699d331ffebd", @"/Views/About/MarketNews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226e66e476153809e3942cb65fb4710596043976", @"/Views/_ViewImports.cshtml")]
    public class Views_About_MarketNews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VietbankWebsite.ModelMap.TopThreeNewsToCate>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\MarketNews.cshtml"
  
    Layout = "~/Views/Shared/_LayoutAbout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""banner-wrap"">
    <section class=""breadcrumb-wrap brown"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <ol class=""breadcrumb mrt-10"">
                        <li><a href=""/ve-vietbank"">Về Vietbank</a></li>
                        <li><a href=""/ve-vietbank/tin-tuc"">Tin tức</a></li>
                        <li style=""color: #999;"" class="" active""><strong>Tin Vietbank</strong></li>
                    </ol>
                </div>
            </div>
        </div>
    </section>
    <section class=""VietBank-bg"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <h1 class=""blue"">Tin Vietbank                                                                                                                                                                                            </h1>
                </div>
            </div>
        <");
            WriteLiteral("/div>\r\n    </section>\r\n</section>\r\n<section class=\"news-special\">\r\n    <div class=\"container\">\r\n        <div class=\"slider\">\r\n            <div class=\"owl-carousel\">\r\n");
#nullable restore
#line 35 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\MarketNews.cshtml"
                 foreach (var news in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"item-newspecial\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-xs-12 col-md-8\">\r\n                                <div class=\"thumb\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1706, "\"", 1722, 1);
#nullable restore
#line 41 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\MarketNews.cshtml"
WriteAttributeValue("", 1713, news.Url, 1713, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 1770, "\"", 1791, 1);
#nullable restore
#line 42 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\MarketNews.cshtml"
WriteAttributeValue("", 1776, news.Thumbnail, 1776, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1792, "\"", 1809, 1);
#nullable restore
#line 42 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\MarketNews.cshtml"
WriteAttributeValue("", 1798, news.Title, 1798, 11, false);

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
#line 49 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\MarketNews.cshtml"
                                     Write(news.PublishDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</time>\r\n                                </div>\r\n                                <h1 class=\"title\"><a");
            BeginWriteAttribute("href", " href=\"", 2293, "\"", 2309, 1);
#nullable restore
#line 51 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\MarketNews.cshtml"
WriteAttributeValue("", 2300, news.Url, 2300, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 51 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\MarketNews.cshtml"
                                                                 Write(news.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h1>\r\n                                <div class=\"brief\">");
#nullable restore
#line 52 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\MarketNews.cshtml"
                                              Write(news.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 56 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\MarketNews.cshtml"
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
            <div class=""row"">
                <div class=""col-xs-12"">
                    <ul class=""nav nav-bld"">
                        <li><a href=""tintuc.html"" class=""active"">TẤT CẢ</a></li>
                        <li><a href=""#"">TIN Vietbank</a></li>
                        <li><a href=""#"">TIN THỊ TRƯỜNG</a></li>
                        <li><a href=""#"">TIN KHUYẾN MÃI</a></li>
                    </ul>
                </div>
            </div>
            <div class=""row flex flex-wrap"">
                <div class=""col-xs-12 col-md-6 col-lg-4 item-newsWrap"">
                    <div class=""item-news"">
                        <figure>
                            <a href=""#""><img src=""/img/tintuc/chuongtrinhkm.png"" alt=""Tin tuc""></a>
                            <figcaption>
                                <div class=""title-news clearfix"">
                  ");
            WriteLiteral(@"                  <h4>Tin Vietbank</h4>
                                    <time>2016-04-13</time>
                                </div>
                                <h3><a href=""#"">Chương trình KM “Triệu phú trong tầm tay, vận may đến nước Mỹ”</a></h3>
                                <div class=""brief"">Nhằm tri ân khách đã luôn đồng hành và ủng hộ trong suốt thời gian qua, Vietbank triển khai CTKM ""Triệu phú trong tầm tay - Vận may đến nước Mỹ""</div>
                            </figcaption>
                        </figure>
                    </div>
                </div>
                <div class=""col-xs-12 col-md-6 col-lg-4 item-newsWrap"">
                    <div class=""item-news"">
                        <figure>
                            <a href=""#""><img src=""/img/tintuc/phancongnhansu.png"" alt=""Tin tuc""></a>
                            <figcaption>
                                <div class=""title-news clearfix"">
                                    <h4>Tin Vietbank</h4>
      ");
            WriteLiteral(@"                              <time>2016-04-13</time>
                                </div>
                                <h3><a href=""#"">Vietbank phân công nhân sự điều hành mới</a></h3>
                                <div class=""brief"">Hội đồng Quản trị Ngân hàng Việt Nam Thương Tín (Vietbank) vừa có quyết định bổ nhiệm ông Nguyễn Đăng Thanh, hiện là phó tổng giám đốc...</div>
                            </figcaption>
                        </figure>
                    </div>
                </div>
                <div class=""col-xs-12 col-md-6 col-lg-4 item-newsWrap"">
                    <div class=""item-news"">
                        <figure>
                            <a href=""#""><img src=""/img/tintuc/quagiainhiet.png"" alt=""Tin tuc""></a>
                            <figcaption>
                                <div class=""title-news clearfix"">
                                    <h4>TIN KHUYẾN MÃI</h4>
                                    <time>2016-04-13</time>
                     ");
            WriteLiteral(@"           </div>
                                <h3><a href=""#"">Chương trình KM “Quà giải nhiệt - Vui hè xuyên Việt”</a></h3>
                                <div class=""brief"">Sau những ngày làm việc vất vả, những chuyến du lịch, nghỉ dưỡng bốn phương luôn là liều thuốc giải tỏa căng thẳng hiệu quả nhất.</div>
                            </figcaption>
                        </figure>
                    </div>
                </div>
                <div class=""col-xs-12 col-md-6 col-lg-4 item-newsWrap"">
                    <div class=""item-news"">
                        <figure>
                            <a href=""#""><img src=""/img/tintuc/uudaidanhchochuthe.png"" alt=""Tin tuc""></a>
                            <figcaption>
                                <div class=""title-news clearfix"">
                                    <h4>Tin Vietbank</h4>
                                    <time>2016-04-13</time>
                                </div>
                                <h3><a href=""#"">Ư");
            WriteLiteral(@"u đãi dành cho chủ thẻ tín dụng Vietbank</a></h3>
                                <div class=""brief"">Sau những ngày làm việc vất vả, những chuyến du lịch, nghỉ dưỡng bốn phương luôn là liều thuốc giải tỏa căng thẳng hiệu quả nhất.</div>
                            </figcaption>
                        </figure>
                    </div>
                </div>
                <div class=""col-xs-12 col-md-6 col-lg-4 item-newsWrap"">
                    <div class=""item-news"">
                        <figure>
                            <a href=""#""><img src=""/img/tintuc/nhansudieuhanhmoi.png"" alt=""Tin tuc""></a>
                            <figcaption>
                                <div class=""title-news clearfix"">
                                    <h4>Tin Vietbank</h4>
                                    <time>2016-04-13</time>
                                </div>
                                <h3><a href=""#"">Vietbank phân công nhân sự điều hành mới</a></h3>
                              ");
            WriteLiteral(@"  <div class=""brief"">Hội đồng Quản trị Ngân hàng Việt Nam Thương Tín (Vietbank) vừa có quyết định bổ nhiệm ông Nguyễn Đăng Thanh, hiện là phó tổng giám đốc...</div>
                            </figcaption>
                        </figure>
                    </div>
                </div>
                <div class=""col-xs-12 col-md-6 col-lg-4 item-newsWrap"">
                    <div class=""item-news"">
                        <figure>
                            <a href=""#""><img src=""/img/tintuc/vuihexuyenviet.png"" alt=""Tin tuc""></a>
                            <figcaption>
                                <div class=""title-news clearfix"">
                                    <h4>TIN KHUYẾN MÃI</h4>
                                    <time>2016-04-13</time>
                                </div>
                                <h3><a href=""#"">Chương trình KM “Quà giải nhiệt - Vui hè xuyên Việt”</a></h3>
                                <div class=""brief"">Sau những ngày làm việc vất vả, những chu");
            WriteLiteral(@"yến du lịch, nghỉ dưỡng bốn phương luôn là liều thuốc giải tỏa căng thẳng hiệu quả nhất.</div>
                            </figcaption>
                        </figure>
                    </div>
                </div>
            </div>
            <div class=""pages newspaper"">
                <ul class=""pagination"">
                    <li class=""active""><span>1</span></li>
                    <li><a href=""#"">2</a></li>
                    <li><a href=""#"">3</a></li>
                </ul>
            </div>
        </div>
    </section>
</main>
");
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
