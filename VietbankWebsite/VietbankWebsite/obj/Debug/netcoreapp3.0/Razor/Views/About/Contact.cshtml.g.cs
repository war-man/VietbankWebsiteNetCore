#pragma checksum "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59c009ea9b0eb8f15f41b62994b932a18fe9133a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Contact), @"mvc.1.0.view", @"/Views/About/Contact.cshtml")]
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
#line 1 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
using reCAPTCHA.AspNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59c009ea9b0eb8f15f41b62994b932a18fe9133a", @"/Views/About/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226e66e476153809e3942cb65fb4710596043976", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VietbankWebsite.ModelMap.Contact>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
  
    ViewData["Title"] = @Localizer["LienHeName"];
    Layout = "~/Views/Shared/_LayoutAbout.cshtml";

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
            BeginWriteAttribute("href", " href=\"", 611, "\"", 645, 1);
#nullable restore
#line 18 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
WriteAttributeValue("", 618, Localizer["VeVietbankUrl"], 618, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                                             Write(Localizer["VeVietbankName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li class=\"active\"><span>");
#nullable restore
#line 19 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                            Write(Localizer["LienHeName"]);

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
        <div style=""background-image:url('https://static.vietbank.com.vn/web/Banner/lien-he.jpg')"" class=""imgBg""></div>
        <div class=""desc"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xs-12 col-sm-5 col-lg-5 col-xl-5"">
                        <h1 class=""title"">");
#nullable restore
#line 31 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                     Write(Localizer["LienHeName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <div class=\"content\">");
#nullable restore
#line 32 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                        Write(Localizer["LienHeDes"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</section>
<main>
    <section class=""contact"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-5 col-lg-4"">
                    <div class=""block-info-wrap"">
                        <div class=""block-addr"">
                            <h1>");
#nullable restore
#line 46 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                           Write(Localizer["String1"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            <p><strong>");
#nullable restore
#line 47 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                  Write(Localizer["String2"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </strong>");
#nullable restore
#line 47 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                                                 Write(Localizer["String3"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p><strong>");
#nullable restore
#line 48 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                  Write(Localizer["String4"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </strong>");
#nullable restore
#line 48 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                                                 Write(Localizer["String5"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"addr\"><strong>");
#nullable restore
#line 49 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                               Write(Localizer["String6"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </strong>");
#nullable restore
#line 49 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                                                              Write(Localizer["String7"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <h1>");
#nullable restore
#line 50 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                           Write(Localizer["String8"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            <p><strong>");
#nullable restore
#line 51 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                  Write(Localizer["String9"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 51 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                                                  Write(Localizer["String10"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p><strong>");
#nullable restore
#line 52 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                  Write(Localizer["String11"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </strong>");
#nullable restore
#line 52 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                                                  Write(Localizer["String12"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"addr\"><strong>");
#nullable restore
#line 53 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                               Write(Localizer["String13"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </strong>");
#nullable restore
#line 53 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                                                               Write(Localizer["String14"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p><strong>");
#nullable restore
#line 54 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                  Write(Localizer["String15"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </strong>");
#nullable restore
#line 54 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                                                  Write(Localizer["String16"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p><strong>");
#nullable restore
#line 55 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                  Write(Localizer["String17"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> ");
#nullable restore
#line 55 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                                                  Write(Localizer["String18"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"block-atmLink\">\r\n                            <h2>");
#nullable restore
#line 58 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                           Write(Localizer["String19"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <div class=\"row\">\r\n                                <div class=\"col-md-6\">\r\n                                    <div class=\"text\">");
#nullable restore
#line 61 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                                 Write(Localizer["String20"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><a href=\"#\">\r\n                                        <i class=\"fa fa-angle-right\"></i>\r\n                                        ");
#nullable restore
#line 63 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                   Write(Localizer["String21"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </div>\r\n                                <div class=\"col-md-6\"><img");
            BeginWriteAttribute("alt", " alt=\"", 3290, "\"", 3320, 1);
#nullable restore
#line 66 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
WriteAttributeValue("", 3296, Localizer["LienHeName"], 3296, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"lazyload\" data-src=\"/img/bando_icon.png\" src=\"/img/bando_icon.png\"></div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-7 col-lg-8\">\r\n");
#nullable restore
#line 72 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                     if (TempData["success"] != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"alert alert-success\" role=\"alert\">\r\n                            ");
#nullable restore
#line 75 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                       Write(Localizer["MessageSuccess"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 77 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                         using (Html.BeginForm())
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"block-form\">\r\n                                <p class=\"title\">");
#nullable restore
#line 85 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                            Write(Localizer["String22"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-md-6\">\r\n                                        <label>\r\n                                            ");
#nullable restore
#line 89 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                       Write(Localizer["String23"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            (<span class=\"red\">*</span>):\r\n                                        </label>\r\n                                        ");
#nullable restore
#line 92 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                   Write(Html.EditorFor(model => model.FullName, new { htmlAttributes = new { @class = "text-box single-line" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 93 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.FullName, "", new { @class = "field-validation-valid text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"col-md-6\">\r\n                                        <label>");
#nullable restore
#line 96 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                          Write(Localizer["String24"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                        ");
#nullable restore
#line 97 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                   Write(Html.EditorFor(model => model.Phone, new { htmlAttributes = new { @class = "text-box single-line" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 98 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Phone, "", new { @class = "field-validation-valid text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-md-6\">\r\n                                        <label>");
#nullable restore
#line 103 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                          Write(Localizer["String25"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                        ");
#nullable restore
#line 104 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                   Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "text-box single-line" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 105 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "field-validation-valid text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"col-md-6\">\r\n                                        <label>\r\n                                            ");
#nullable restore
#line 109 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                       Write(Localizer["String26"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            (<span class=\"red\">*</span>):\r\n                                        </label>\r\n                                        ");
#nullable restore
#line 112 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                   Write(Html.EditorFor(model => model.Address, new { htmlAttributes = new { @class = "text-box single-line" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 113 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Address, "", new { @class = "field-validation-valid text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-md-6\">\r\n                                        <label>");
#nullable restore
#line 118 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                          Write(Localizer["String27"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                        ");
#nullable restore
#line 119 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                   Write(Html.EditorFor(model => model.Title, new { htmlAttributes = new { @class = "text-box single-line" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 120 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Title, "", new { @class = "field-validation-valid text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"col-md-6\">\r\n                                        <label>\r\n                                            ");
#nullable restore
#line 124 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                       Write(Localizer["String28"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            (<span class=\"red\">*</span>):\r\n                                        </label>\r\n                                        ");
#nullable restore
#line 127 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                   Write(Html.EditorFor(model => model.Career, new { htmlAttributes = new { @class = "text-box single-line" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 128 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Career, "", new { @class = "field-validation-valid text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-md-12"">
                                        <label>
                                            ");
#nullable restore
#line 134 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                       Write(Localizer["String29"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            (<span class=\"red\">*</span>):\r\n                                        </label>\r\n                                        ");
#nullable restore
#line 137 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                   Write(Html.TextArea("Message", new { rows = 10, columns = 40 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 138 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Message, "", new { @class = "field-validation-valid text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-md-12"">
                                        <label>
                                            ");
#nullable restore
#line 144 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                       Write(Localizer["String30"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            (<span class=\"red\">*</span>):\r\n                                        </label>\r\n                                        <div class=\"captcha-box clearfix\">\r\n                                            ");
#nullable restore
#line 148 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                       Write(Html.Recaptcha(RecaptchaSettings?.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                    </div>
                                </div>
                                <div class=""row mrt-30"">
                                    <div class=""col-sm-12""><button type=""submit"" class=""btn confirm"">");
#nullable restore
#line 153 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                                                                                                Write(Localizer["String31"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button></div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 156 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 156 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Contact.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VietbankWebsite.ModelMap.Contact> Html { get; private set; }
    }
}
#pragma warning restore 1591