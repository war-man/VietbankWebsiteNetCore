#pragma checksum "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\DirectorDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac64bb72ef268f17bd38c4a869691201a994f5b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_DirectorDetail), @"mvc.1.0.view", @"/Views/About/DirectorDetail.cshtml")]
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
#line 2 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\DirectorDetail.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac64bb72ef268f17bd38c4a869691201a994f5b1", @"/Views/About/DirectorDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226e66e476153809e3942cb65fb4710596043976", @"/Views/_ViewImports.cshtml")]
    public class Views_About_DirectorDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VietbankWebsite.ModelMap.LeadershipDetail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\DirectorDetail.cshtml"
  
    Layout = "~/Views/Shared/_LayoutAbout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class="" banner-wrap"">
    <section class=""breadcrumb-wrap brown"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <ol class=""breadcrumb mrt-10"">
                        <li><a");
            BeginWriteAttribute("href", " href=\"", 453, "\"", 482, 1);
#nullable restore
#line 13 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\DirectorDetail.cshtml"
WriteAttributeValue("", 460, Localizer["AboutUrl"], 460, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 13 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\DirectorDetail.cshtml"
                                                        Write(Localizer["AboutName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 548, "\"", 582, 1);
#nullable restore
#line 14 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\DirectorDetail.cshtml"
WriteAttributeValue("", 555, Localizer["LeadershipUrl"], 555, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 14 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\DirectorDetail.cshtml"
                                                             Write(Localizer["LeadershipName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 653, "\"", 685, 1);
#nullable restore
#line 15 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\DirectorDetail.cshtml"
WriteAttributeValue("", 660, Localizer["DirectorUrl"], 660, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\DirectorDetail.cshtml"
                                                           Write(Localizer["DirectorName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li style=\"color: #999;\" class=\" active\"><strong>");
#nullable restore
#line 16 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\DirectorDetail.cshtml"
                                                                    Write(Model.Title);

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
#line 26 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\DirectorDetail.cshtml"
                                Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                                                                                                                                      </h1>
                </div>
            </div>
        </div>
    </section>
</section>
<main>
    <div class=""container"">
        <div class=""row"">
            <div id=""leadership-menu"" class=""col-xs-12"">
                <ul class=""nav nav-bld"">
                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1584, "\"", 1616, 1);
#nullable restore
#line 37 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\DirectorDetail.cshtml"
WriteAttributeValue("", 1591, Localizer["DirectorUrl"], 1591, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"active\">");
#nullable restore
#line 37 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\DirectorDetail.cshtml"
                                                                      Write(Localizer["DirectorName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1696, "\"", 1731, 1);
#nullable restore
#line 38 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\DirectorDetail.cshtml"
WriteAttributeValue("", 1703, Localizer["SupervisoryUrl"], 1703, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 38 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\DirectorDetail.cshtml"
                                                          Write(Localizer["SupervisoryName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1799, "\"", 1833, 1);
#nullable restore
#line 39 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\DirectorDetail.cshtml"
WriteAttributeValue("", 1806, Localizer["ManagementUrl"], 1806, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 39 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\DirectorDetail.cshtml"
                                                         Write(Localizer["ManagementName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    ");
#nullable restore
#line 45 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\About\DirectorDetail.cshtml"
Write(Html.Raw(Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VietbankWebsite.ModelMap.LeadershipDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
