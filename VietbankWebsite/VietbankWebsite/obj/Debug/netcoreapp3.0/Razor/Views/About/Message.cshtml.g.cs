#pragma checksum "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Message.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3fdb5fddd5d5dd99a16c99661cf0e47d5c76e06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Message), @"mvc.1.0.view", @"/Views/About/Message.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3fdb5fddd5d5dd99a16c99661cf0e47d5c76e06", @"/Views/About/Message.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226e66e476153809e3942cb65fb4710596043976", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Message : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VietbankWebsite.ModelMap.IntroduceDetail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Message.cshtml"
  
    Layout = "~/Views/Shared/_LayoutAbout.cshtml";

#line default
#line hidden
            WriteLiteral(@"<section class=""banner-wrap"">
    <section class=""breadcrumb-wrap"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <ol class=""breadcrumb mrt-10"">
                        <li><a");
            BeginWriteAttribute("href", " href=\"", 365, "\"", 389, 1);
#line 11 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Message.cshtml"
WriteAttributeValue("", 372, ViewBag.AboutUrl, 372, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">");
#line 11 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Message.cshtml"
                                                   Write(ViewBag.AboutName);

#line default
#line hidden
            WriteLiteral("</a></li>\r\n                        <li style=\"color: #999;\" class=\"active\"><strong>");
#line 12 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Message.cshtml"
                                                                   Write(Model.Title);

#line default
#line hidden
            WriteLiteral("</strong></li>\r\n                    </ol>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <section class=\"banner-page imageBanner\">\r\n        <div");
            BeginWriteAttribute("style", " style=\"", 682, "\"", 726, 3);
            WriteAttributeValue("", 690, "background-image:url(\'", 690, 22, true);
#line 19 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Message.cshtml"
WriteAttributeValue("", 712, Model.Image, 712, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 724, "\')", 724, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"imgBg\"></div>\r\n        <div class=\"desc\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-xs-12 col-sm-5 col-lg-5 col-xl-5\">\r\n                        <h1 class=\"title bottom\">");
#line 24 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Message.cshtml"
                                            Write(Model.Title);

#line default
#line hidden
            WriteLiteral("</h1>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</section>\r\n<main>\r\n    ");
#line 32 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\Message.cshtml"
Write(Html.Raw(Model.Content));

#line default
#line hidden
            WriteLiteral("\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VietbankWebsite.ModelMap.IntroduceDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
