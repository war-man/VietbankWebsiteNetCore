#pragma checksum "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e3d856f5d7a6d7922a4bdd4193b64f7b94066e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personal_Faqs), @"mvc.1.0.view", @"/Views/Personal/Faqs.cshtml")]
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
#line 2 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e3d856f5d7a6d7922a4bdd4193b64f7b94066e5", @"/Views/Personal/Faqs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226e66e476153809e3942cb65fb4710596043976", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_Faqs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VietbankWebsite.ModelMap.Faqs>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Partial/_ToolCalulationPersonalBar.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
  
    Layout = "~/Views/Shared/_LayoutPersonal.cshtml";

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
            BeginWriteAttribute("href", " href=\"", 439, "\"", 471, 1);
#nullable restore
#line 14 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
WriteAttributeValue("", 446, Localizer["PersonalUrl"], 446, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 14 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
                                                           Write(Localizer["PersonalName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 540, "\"", 571, 1);
#nullable restore
#line 15 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
WriteAttributeValue("", 547, Localizer["SupportUrl"], 547, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
                                                          Write(Localizer["SupportName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li class=\"active\"><span style=\"color:#999;\">");
#nullable restore
#line 16 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
                                                                Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                    </ol>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <section class=\"banner-page imageBanner\">\r\n        <div");
            BeginWriteAttribute("style", " style=\"", 866, "\"", 910, 3);
            WriteAttributeValue("", 874, "background-image:url(\'", 874, 22, true);
#nullable restore
#line 23 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
WriteAttributeValue("", 896, Model.Image, 896, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 908, "\')", 908, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"imgBg\"></div>\r\n        <div class=\"desc\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-xs-12 col-sm-5 col-lg-5 col-xl-5\">\r\n                        <h1 class=\"title\">");
#nullable restore
#line 28 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
                                     Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <div class=\"content\">");
#nullable restore
#line 29 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
                                        Write(Localizer["FaqsDes"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</section>\r\n<main>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-xs-12 col-lg-3\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e3d856f5d7a6d7922a4bdd4193b64f7b94066e57822", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-xs-12 col-lg-9\">\r\n                <section id=\"support-personal\" class=\"hotro-ct\">\r\n                    <div class=\"tabs-support\">\r\n                        <ul role=\"tablist\" class=\"nav-jt-sp\">\r\n");
#nullable restore
#line 46 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
                             foreach (var item in Model.FaqsCategories)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
                                 if (Model.FaqsCategories.First() == item)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"nav-item\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2112, "\"", 2132, 2);
            WriteAttributeValue("", 2119, "#tab_", 2119, 5, true);
#nullable restore
#line 51 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
WriteAttributeValue("", 2124, item.Id, 2124, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tab\" role=\"tab\" class=\"active\" aria-expanded=\"false\">");
#nullable restore
#line 51 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
                                                                                                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </li>\r\n");
#nullable restore
#line 53 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"nav-item\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2468, "\"", 2488, 2);
            WriteAttributeValue("", 2475, "#tab_", 2475, 5, true);
#nullable restore
#line 57 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
WriteAttributeValue("", 2480, item.Id, 2480, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tab\" role=\"tab\" aria-expanded=\"false\">");
#nullable restore
#line 57 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
                                                                                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </li>\r\n");
#nullable restore
#line 59 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
                                 

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n                    <div class=\"tab-content\">\r\n");
#nullable restore
#line 65 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
                         foreach (var category in Model.FaqsCategories)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
                             if (Model.FaqsCategories.First() == category)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div role=\"tabpanel\" class=\"thetindung tab-pane active\"");
            BeginWriteAttribute("id", " id=\"", 3068, "\"", 3089, 2);
            WriteAttributeValue("", 3073, "tab_", 3073, 4, true);
#nullable restore
#line 69 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
WriteAttributeValue("", 3077, category.Id, 3077, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-expanded=\"false\">\r\n");
#nullable restore
#line 70 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
                                     foreach (var item in category.FaqsItems)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"panel-faqs\">\r\n                                            <div class=\"title\"><span>");
#nullable restore
#line 73 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
                                                                Write(item.Question);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                                            <div class=\"content\"><span><p>");
#nullable restore
#line 74 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
                                                                     Write(Html.Raw(item.Answer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></span></div>\r\n                                        </div>\r\n");
#nullable restore
#line 76 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n");
#nullable restore
#line 78 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div role=\"tabpanel\" class=\"thetindung tab-pane\"");
            BeginWriteAttribute("id", " id=\"", 3815, "\"", 3836, 2);
            WriteAttributeValue("", 3820, "tab_", 3820, 4, true);
#nullable restore
#line 81 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
WriteAttributeValue("", 3824, category.Id, 3824, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-expanded=\"false\">\r\n");
#nullable restore
#line 82 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
                                     foreach (var item in category.FaqsItems)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"panel-faqs\">\r\n                                            <div class=\"title\"><span>");
#nullable restore
#line 85 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
                                                                Write(item.Question);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                                            <div class=\"content\"><span><p>");
#nullable restore
#line 86 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
                                                                     Write(Html.Raw(item.Answer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></span></div>\r\n                                        </div>\r\n");
#nullable restore
#line 88 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n");
#nullable restore
#line 90 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Faqs.cshtml"
                             

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </section>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VietbankWebsite.ModelMap.Faqs> Html { get; private set; }
    }
}
#pragma warning restore 1591
