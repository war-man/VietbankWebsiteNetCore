#pragma checksum "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\WebAppCapchar\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a38f333733e585f84c92c26431e75b8f731fa74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
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
#line 1 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\WebAppCapchar\Views\_ViewImports.cshtml"
using WebAppCapchar;

#line default
#line hidden
#line 2 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\WebAppCapchar\Views\_ViewImports.cshtml"
using WebAppCapchar.Models;

#line default
#line hidden
#line 1 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\WebAppCapchar\Views\Home\Privacy.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 2 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\WebAppCapchar\Views\Home\Privacy.cshtml"
using reCAPTCHA.AspNetCore;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a38f333733e585f84c92c26431e75b8f731fa74", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98598d04e97f6287712e8273de78b0ffb3edf25e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#line 6 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\WebAppCapchar\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
            WriteLiteral("<h1>");
#line 9 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\WebAppCapchar\Views\Home\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            WriteLiteral("</h1>\r\n\r\n<p>Use this page to detail your site\'s privacy policy.</p>\r\n\r\n");
#line 13 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\WebAppCapchar\Views\Home\Privacy.cshtml"
 using (Html.BeginForm("Contact", "Home", FormMethod.Post))
{
    

#line default
#line hidden
#line 15 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\WebAppCapchar\Views\Home\Privacy.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
            WriteLiteral("    <fieldset>\r\n        <div class=\"form-group\">\r\n            ");
#line 18 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\WebAppCapchar\Views\Home\Privacy.cshtml"
       Write(Html.LabelFor(model => model.Message));

#line default
#line hidden
            WriteLiteral("\r\n            <br />\r\n            ");
#line 20 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\WebAppCapchar\Views\Home\Privacy.cshtml"
       Write(Html.TextAreaFor(model => model.Message, new { @class = "form-control", rows = "3", style = "width: 300px;" }));

#line default
#line hidden
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#line 23 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\WebAppCapchar\Views\Home\Privacy.cshtml"
       Write(Html.Recaptcha(RecaptchaSettings?.Value));

#line default
#line hidden
            WriteLiteral("\r\n        </div>\r\n        <button id=\"recaptcha\" type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n    </fieldset>\r\n");
#line 27 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\WebAppCapchar\Views\Home\Privacy.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
