#pragma checksum "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fb7cb333938e2a350ad9c9d4351b591d66dc00a"
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
#nullable restore
#line 1 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
using reCAPTCHA.AspNetCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fb7cb333938e2a350ad9c9d4351b591d66dc00a", @"/Views/Personal/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226e66e476153809e3942cb65fb4710596043976", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VietbankWebsite.Entities.ProductDetail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/product.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/swiper.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/swiper.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/page/product-detail.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5fb7cb333938e2a350ad9c9d4351b591d66dc00a5724", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5fb7cb333938e2a350ad9c9d4351b591d66dc00a6902", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
            WriteLiteral("<main class=\"pt-80\">\r\n    <section style=\"top:0;\" class=\"breadcrumb-wrap\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-12\">\r\n                    <ol class=\"breadcrumb\">\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 611, "\"", 638, 1);
#nullable restore
#line 18 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
WriteAttributeValue("", 618, ViewBag.PersonalUrl, 618, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
                                                      Write(ViewBag.PersonalName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 702, "\"", 728, 1);
#nullable restore
#line 19 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
WriteAttributeValue("", 709, ViewBag.ProductUrl, 709, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
                                                     Write(ViewBag.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 791, "\"", 816, 1);
#nullable restore
#line 20 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
WriteAttributeValue("", 798, Model.CategoryUrl, 798, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
                                                    Write(Model.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li class=\"active\"><span style=\"color:#999;\">");
#nullable restore
#line 21 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
                                                                Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                    </ol>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <section class=\"banner-wrap\">\r\n        <div class=\"imgBg\"");
            BeginWriteAttribute("style", " style=\"", 1107, "\"", 1160, 3);
            WriteAttributeValue("", 1115, "background-image:url(\'", 1115, 22, true);
#nullable restore
#line 28 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
WriteAttributeValue("", 1137, Model.BannerProduct, 1137, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1157, "\');", 1157, 3, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n");
            WriteLiteral(@"    </section>
    <section class=""menu-wrap"">
        <div class=""container"">
            <ul class=""row menu-horizontal"" id=""myTopnav"">
                <li class=""active col-12 col-sm-12 col-md-12 col-lg-2""><a href=""#1"">Đặc tính sản phẩm</a></li>
                <li class=""col-12 col-sm-12 col-md-12 col-lg-2""><a href=""#2"">Tiện ích sản phẩm</a></li>
                <li class=""col-12 col-sm-12 col-md-12 col-lg-2""><a href=""#3"">Biểu lãi suất</a></li>
                <li class=""col-12 col-sm-12 col-md-12 col-lg-2""><a href=""#4"">Hướng dẫn đăng kí</a></li>
                <li class=""col-12 col-sm-12 col-md-12 col-lg-2""><a href=""#5"">Ưu đãi cho khách hàng</a></li>
                <li class=""col-12 col-sm-12 col-md-12 col-lg-2""><a href=""#6"">Cẩm nang cho khách hàng</a></li>
            </ul>

            <a class=""mobile-menu-toggle js-toggle-menu hamburger-menu"" href=""#"">
                <div class=""mobile-header-nav"">
                    <span class=""menu-item""></span>
                    <span class=""");
            WriteLiteral("menu-item\"></span>\r\n                    <span class=\"menu-item\"></span>\r\n                </div>\r\n                <p>Danh mục</p>\r\n            </a>\r\n        </div>\r\n    </section>\r\n    ");
#nullable restore
#line 73 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
Write(Html.Raw(Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <section class=""interest-rate mt-50"" id=""3"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-8 col-xl-8"">
                    <div class=""img-bullet"">
                        <img src=""/images/bullet.png"" alt=""Bullet"" />
                        <h1 class=""title"">biểu lãi suất tiết kiệm vietbank</h1>
                    </div>
                </div>
                <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-4 col-xl-4"">
                    <div class=""dflex-end"">
                        <a href=""https://static.vietbank.com.vn/web/lai%20suat%20%20huy%20dong%20_KHDN/BIEU%20PHI%20LSHD.PDF"" class=""btn btn-a"">
                            <span>Xem ngay</span>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section class=""form-index mt-50"" id=""4"">
        <div class=""container"">
            <div class=""row"">
             ");
            WriteLiteral(@"   <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-6 col-xl-6 mb-30"">
                    <div class=""register-guide"">
                        <div class=""box-title"">
                            <h1 class=""title"">Hướng dẫn đăng kí</h1>
                        </div>
                        <div class=""step"">
                            <div class=""row"">
                                <div class=""col-lg-3 col-xs-3"">
                                    <p class=""title-step"">Bước 1</p>
                                </div>
                                <div class=""col-lg-9 col-xs-9"">
                                    <p>Truy cập vào website <a href=""https://online.vietbank.com.vn/ibk/vn/sotietkiem/index.jsp""><span>VietBank Online</span></a></p>
                                </div>
                            </div>
                        </div>
                        <div class=""step"">
                            <div class=""row"">
                                <div class=""col-lg-3 c");
            WriteLiteral(@"ol-xs-3"">
                                    <p class=""title-step"">Bước 2</p>
                                </div>
                                <div class=""col-lg-9 col-xs-9"">
                                    <p>Nhập số tài khoản tiết kiệm và số CMND/ Passport.</span></p>
                                </div>
                            </div>
                        </div>
                        <div class=""step"">
                            <div class=""row"">
                                <div class=""col-lg-3 col-xs-3"">
                                    <p class=""title-step"">Bước 3</p>
                                </div>
                                <div class=""col-lg-9 col-xs-9"">
                                    <!-- <p>Chọn hình thức vay &nbsp;<span>Vay > Vay du học</span></p> -->
                                    <p>Vietbank gửi tin nhắn mã xác thực (OTP) đến ĐTDĐ của khách hàng. Thời hạn hiệu lực OTP: 05 phút.</p>
                                </div>
         ");
            WriteLiteral(@"                   </div>
                        </div>
                        <div class=""step"">
                            <div class=""row"">
                                <div class=""col-lg-3 col-xs-3"">
                                    <p class=""title-step"">Bước 4</p>
                                </div>
                                <div class=""col-lg-9 col-xs-9"">
                                    <p>
                                        Khách hàng nhập mã OTP vào màn hình xác nhận và nhấn <span> Đồng ý.</span>
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class=""step"">
                            <div class=""row"">
                                <div class=""col-lg-3 col-xs-3"">
                                    <p class=""title-step"">Bước 5</p>
                                </div>
                                <div class=""col-lg-9 col-xs-9");
            WriteLiteral(@""">
                                    <p>Chương trình hiển thị thông tin chi tiết sổ tiết kiệm của khách hàng (Họ tên khách hàng, số dư, ngày gửi, ngày hết hạn).</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-6 col-xl-6"">
                    <div class=""form-register"">
                        <div class=""box-title"">
                            <h1 class=""title"">Hỗ trợ tư vấn</h1>
                            <div class=""icon-container"">
                                <i class=""fa fa-phone""></i>
                            </div>
                            <p>Hotline: <span style=""color: yellow"">1800 1122</span></p>
                        </div>
                        <div class=""form-wrapper"">
                            <div class=""note-form"">
                                <p>Nhập thông tin về bạn để được hỗ tr");
            WriteLiteral("ợ</p>\r\n                            </div>\r\n");
#nullable restore
#line 169 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
                             using (Html.BeginForm())
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 171 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
                           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 172 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
                           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""row"">
                                    <div class=""col-12 col-sm-12 col-md-3 col-lg-3 col-xs-3"">
                                        <p>Họ và tên</p>
                                    </div>
                                    <div class=""col-12 col-sm-12 col-md-9 col-lg-9 col-xs-9"">
                                        <input data-validation=""required"" type=""text"" name=""NameCustomer"" placeholder=""Họ và tên"" required />
                                        <input type=""text"" name=""TitlePost""");
            BeginWriteAttribute("value", " value=\"", 9498, "\"", 9518, 1);
#nullable restore
#line 179 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
WriteAttributeValue("", 9506, Model.Title, 9506, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"hidden\" />\r\n                                        <input type=\"text\" id=\"categoryId\"");
            BeginWriteAttribute("value", " value=\"", 9613, "\"", 9638, 1);
#nullable restore
#line 180 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
WriteAttributeValue("", 9621, Model.CategoryId, 9621, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"hidden\" />\r\n                                        <input type=\"text\" id=\"categoryUrl\"");
            BeginWriteAttribute("value", " value=\"", 9734, "\"", 9760, 1);
#nullable restore
#line 181 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
WriteAttributeValue("", 9742, Model.CategoryUrl, 9742, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""hidden"" />
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-12 col-sm-12 col-md-3 col-lg-3 col-xs-3"">
                                        <p>Email</p>
                                    </div>
                                    <div class=""col-12 col-sm-12 col-md-9 col-lg-9 col-xs-9"">
                                        <input data-validation=""required"" type=""email"" name=""EmailCustomer"" placeholder=""Email"" required />
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-12 col-sm-12 col-md-3 col-lg-3 col-xs-3"">
                                        <p>Số điện thoại</p>
                                    </div>
                                    <div class=""col-12 col-sm-12 col-md-9 col-lg-9 col-xs-9"">
         ");
            WriteLiteral(@"                               <input data-validation=""required"" type=""text"" name=""PhonerCustomer"" placeholder=""Số điện thoại"" required />
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-12 col-sm-12 col-md-3 col-lg-3 col-xs-3"">
                                        <p>Nội dung</p>
                                    </div>
                                    <div class=""col-12 col-sm-12 col-md-9 col-lg-9 col-xs-9"">
                                        <textarea data-validation=""required"" name=""ContentCustomer"" class=""form-control"" rows=""4"" placeholder=""Nội dung""></textarea>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-12 col-sm-12 col-md-3 col-lg-3 col-xs-3"">
                                        <p>Mã xác thực</p>
  ");
            WriteLiteral("                                  </div>\r\n                                    <div class=\"col-12 col-sm-12 col-md-9 col-lg-9 col-xs-9\">\r\n                                        ");
#nullable restore
#line 213 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
                                   Write(Html.Recaptcha(RecaptchaSettings?.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""dflex-center"">
                                    <button type=""submit"" class=""btn btn-a"">Gửi</button>
                                </div>
                                <div class=""note"">
                                    <p class=""notice"">
                                        (*)Tất cả thông tin bạn cung cấp sẽ được lưu trữ và giữ bí mật. Chúng
                                        tôi không bán, cho thuê danh sách và thông tin khách hàng cho các công ty khác.
                                    </p>
                                </div>
");
#nullable restore
#line 225 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section class=""sec_slide2 mt-50"" id=""5"">
        <div class=""container"">
            <div class=""title-menu"">
                <h1>Ưu đãi cho khách hàng</h1>
            </div>
            <div class=""swiper-main"">
                <div class=""swiper-container"">
                    <div class=""swiper-wrapper"" id=""list-promotion"">
                    </div>
                </div>
                <!-- Add Arrows -->
                <div class=""swiper-button-next""></div>
                <div class=""swiper-button-prev""></div>
            </div>
        </div>
    </section>
    <section class=""customers"" id=""6"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12 col-sm-12 col-md-12 col-lg-6 col-xl-6"">
                    <div class=""title-menu"">
                        <h1>Cẩm nang cho khách hàng</h1>
        ");
            WriteLiteral(@"                <a href=""http://cmsfe.vietbank.com.vn/ve-vietbank/tin-tuc/tin-khuyen-mai/nhanh-san-ma-%E2%80%93-nhan-tien-lien""><p class=""notice"">Xem tất cả</p></a>
                    </div>
                    <div class=""list-posts"" id=""list-posts"">
                    </div>
                </div>
                <div class=""col-12 col-sm-12 col-md-12 col-lg-6 col-xl-6"">
                    <div class=""row no-gutters title-menu"">
                        <h1>Sản phẩm liên quan</h1>
                        <a");
            BeginWriteAttribute("href", " href=\"", 14304, "\"", 14329, 1);
#nullable restore
#line 262 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
WriteAttributeValue("", 14311, Model.CategoryUrl, 14311, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><p class=""notice"">Xem tất cả</p></a>
                    </div>
                    <div class=""list-posts"" id=""list-random-post""></div>
                </div>
            </div>
        </div>
    </section>
    <!--<section class=""customers-reviews"">
        <div class=""container"">
            <div class=""title-menu"">
                <h1>Nhận xét từ khách hàng</h1>
            </div>
            <div class=""reviews"">
                <div class=""row"">
                    <div class=""col-12 col-sm-12 col--md-12 col-lg-8 mb-30"">
                        <a href=""#"">
                            <div class=""video tRes_65"">
                                <video controls=""controls"">
                                    <source src=""""></source>
                                </video>
                            </div>
                        </a>
                    </div>
                    <div class=""col-12 col-sm-12 col-md-12 col-lg-4"">
                        <div class=""row no-gutter");
            WriteLiteral(@"s"">
                            <div class=""col-12 col-sm-12 col-md-12 col-lg-12 pd-res1"">
                                <a href=""#"">
                                    <div class=""img tRes_64"">
                                        <img src=""/images/cus1.jpg"" alt="""" data-lazy-type=""images"" data-lazy-src=""/images/cus1.jpg"" />
                                    </div>
                                </a>
                            </div>
                            <div class=""col-12 col-sm-6 col-md-12 col-lg-12 pd-res2"">
                                <a href=""#"">
                                    <div class=""img tRes_64"">
                                        <img src=""/images/cus2.jpg"" alt="""" data-lazy-type=""images"" data-lazy-src=""/images/cus2.jpg"" />
                                    </div>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>");
            WriteLiteral(@"
    </section>-->
    <section class=""banner-bottom mt-50"">
        <div class=""banner-color""></div>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-6 col-sm-6 col-md-6 col-lg-3"">
                    <div class=""inner-banner"">
                        <a href=""#"">
                            <img src=""/images/ico_bieumau.png""");
            BeginWriteAttribute("alt", " alt=\"", 16760, "\"", 16766, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                            <h4>Biểu mẫu</h4>
                            <p>Tham khảo nội dung biểu mẫu mà bạn cần tại đây</p>
                        </a>
                    </div>
                </div>
                <div class=""col-6 col-sm-6 col-md-6 col-lg-3"">
                    <div class=""inner-banner"">
                        <a href=""#"">
                            <img src=""/images/ico_tong dai.png""");
            BeginWriteAttribute("alt", " alt=\"", 17197, "\"", 17203, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                            <h4>Tổng đài 1800 1122</h4>
                            <p>Tham khảo nội dung biểu mẫu mà bạn cần tại đây</p>
                        </a>
                    </div>
                </div>
                <div class=""col-6 col-sm-6 col-md-6 col-lg-3"">
                    <div class=""inner-banner"">
                        <a href=""#"">
                            <img src=""/images/ico_email.png""");
            BeginWriteAttribute("alt", " alt=\"", 17641, "\"", 17647, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                            <h4>Gửi Email cho chúng tôi</h4>
                            <p>Tham khảo nội dung biểu mẫu mà bạn cần tại đây</p>
                        </a>
                    </div>
                </div>
                <div class=""col-6 col-sm-6 col-md-6 col-lg-3"">
                    <div class=""inner-banner"">
                        <a href=""#"">
                            <img src=""/images/ico_chi nhanh.png""");
            BeginWriteAttribute("alt", " alt=\"", 18094, "\"", 18100, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                            <h4>Chi nhánh</h4>
                            <p>Tham khảo nội dung biểu mẫu mà bạn cần tại đây</p>
                        </a>
                    </div>
                </div>
            </div>
        </div>

    </section>
</main>
");
#nullable restore
#line 352 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
  
    if (TempData["success"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success\" style=\"width: 400px;position: fixed;bottom: 10px;z-index: 99999;left: 20px;\">\r\n            <strong>Yêu cầu bạn gửi thành công!</strong>\r\n        </div>\r\n");
#nullable restore
#line 358 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\ProductDetail.cshtml"
    }

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fb7cb333938e2a350ad9c9d4351b591d66dc00a32643", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fb7cb333938e2a350ad9c9d4351b591d66dc00a33743", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
        public IOptions<RecaptchaSettings> RecaptchaSettings { get; private set; }
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
