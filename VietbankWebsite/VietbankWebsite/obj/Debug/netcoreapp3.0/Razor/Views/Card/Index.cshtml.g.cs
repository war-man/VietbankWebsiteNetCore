#pragma checksum "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7aeb138c87095af13ba0fd7652e861839a1134f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Card_Index), @"mvc.1.0.view", @"/Views/Card/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7aeb138c87095af13ba0fd7652e861839a1134f1", @"/Views/Card/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226e66e476153809e3942cb65fb4710596043976", @"/Views/_ViewImports.cshtml")]
    public class Views_Card_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VietbankWebsite.Entities.CardHomeTemplate>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/card/img/home/visa.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
  
    Layout = "~/Views/Shared/_LayoutCard.cshtml";

#line default
#line hidden
            WriteLiteral("\r\n<section class=\"banner-wrap\">\r\n    <div class=\"banner home-banner\">\r\n");
#line 8 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
         foreach (var item in Model.BoxOne)
        {

#line default
#line hidden
            WriteLiteral("            <div class=\"item\"><a");
            BeginWriteAttribute("href", " href=\"", 267, "\"", 283, 1);
#line 10 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
WriteAttributeValue("", 274, item.Url, 274, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 289, "\"", 305, 1);
#line 10 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
WriteAttributeValue("", 295, item.Path, 295, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 306, "\"", 312, 0);
            EndWriteAttribute();
            WriteLiteral("></a></div>\r\n");
#line 11 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
        }

#line default
#line hidden
            WriteLiteral("    </div>\r\n</section>\r\n<main>\r\n    <section class=\"home-card\">\r\n        <div class=\"container\">\r\n            <div class=\"card-slick\">\r\n");
#line 18 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
                 foreach (var item in Model.BoxTwo)
                {

#line default
#line hidden
            WriteLiteral("                    <div class=\"item\">\r\n                        <a class=\"card-item\"");
            BeginWriteAttribute("href", " href=\"", 629, "\"", 650, 1);
#line 21 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
WriteAttributeValue("", 636, item.UrlTitle, 636, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <figure>\r\n                                <div class=\"card-img\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 788, "\"", 808, 1);
#line 24 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
WriteAttributeValue("", 794, item.UrlImage, 794, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 809, "\"", 815, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </div>\r\n                                <figcaption>\r\n                                    <div class=\"card-logo\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7aeb138c87095af13ba0fd7652e861839a1134f16853", async() => {
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
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"card-name\">");
#line 30 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
                                                      Write(item.Title);

#line default
#line hidden
            WriteLiteral("</div>\r\n                                    <div class=\"card-des\">");
#line 31 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
                                                     Write(item.Description);

#line default
#line hidden
            WriteLiteral("</div>\r\n                                </figcaption>\r\n                            </figure>\r\n                        </a>\r\n                    </div>\r\n");
#line 36 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
                }

#line default
#line hidden
            WriteLiteral("            </div>\r\n        </div>\r\n    </section>\r\n    <section class=\"home-intro\">\r\n        <div class=\"container\">\r\n            <h1 class=\"home-title text-center\">");
#line 42 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
                                          Write(Model.BoxThree.TitleOne);

#line default
#line hidden
            WriteLiteral("</h1>\r\n            <div class=\"home-des text-center\">");
#line 43 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
                                         Write(Model.BoxThree.TitleTwo);

#line default
#line hidden
            WriteLiteral("</div>\r\n            <div class=\"home-content text-center\" style=\"max-width: 770px\">\r\n                <div class=\"content\">\r\n                    <p>");
#line 46 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
                  Write(Model.BoxThree.Description);

#line default
#line hidden
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n            <div class=\"intro-img text-center\"><img");
            BeginWriteAttribute("src", " src=\"", 1969, "\"", 1994, 1);
#line 49 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
WriteAttributeValue("", 1975, Model.BoxThree.Url, 1975, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1995, "\"", 2001, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n        </div>\r\n    </section>\r\n    <section class=\"home-promotion s2\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-12 col-md-6\">\r\n                    <div class=\"img text-center\"><img");
            BeginWriteAttribute("src", " src=\"", 2248, "\"", 2272, 1);
#line 56 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
WriteAttributeValue("", 2254, Model.BoxFour.Url, 2254, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2273, "\"", 2279, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                </div>\r\n                <div class=\"col-12 col-md-6\">\r\n                    <div class=\"promotion-content text-center\">\r\n                        <h2 class=\"home-title\">");
#line 60 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
                                          Write(Model.BoxFour.TitleOne);

#line default
#line hidden
            WriteLiteral("</h2>\r\n                        <div class=\"home-des\">");
#line 61 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
                                         Write(Model.BoxFour.TitleTwo);

#line default
#line hidden
            WriteLiteral("</div>\r\n                        <div class=\"home-content\" style=\"max-width:350px\">\r\n                            <div class=\"content\">\r\n                                <p>");
#line 64 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
                              Write(Model.BoxFour.Description);

#line default
#line hidden
            WriteLiteral(@"</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section class=""home-promotion"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12 col-md-6"">
                    <div class=""promotion-content text-center"">
                        <h2 class=""home-title"">");
#line 77 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
                                          Write(Model.BoxFive.TitleOne);

#line default
#line hidden
            WriteLiteral("</h2>\r\n                        <div class=\"home-des\">");
#line 78 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
                                         Write(Model.BoxFive.TitleTwo);

#line default
#line hidden
            WriteLiteral("</div>\r\n                        <div class=\"home-content\" style=\"max-width:350px\">\r\n                            <div class=\"content\">\r\n                                <p>");
#line 81 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
                              Write(Model.BoxFive.Description);

#line default
#line hidden
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-12 col-md-6\">\r\n                    <div class=\"img text-center\"><img");
            BeginWriteAttribute("src", " src=\"", 3727, "\"", 3751, 1);
#line 87 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
WriteAttributeValue("", 3733, Model.BoxFive.Url, 3733, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3752, "\"", 3758, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <section class=\"home-feature s2\">\r\n        <div class=\"container\">\r\n            <h2 class=\"home-title text-center\">");
#line 94 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
                                          Write(Model.BoxSix.TitleOne);

#line default
#line hidden
            WriteLiteral("</h2>\r\n            <div class=\"home-des text-center\">");
#line 95 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
                                         Write(Model.BoxSix.TitleTwo);

#line default
#line hidden
            WriteLiteral("</div>\r\n            <div class=\"home-content text-center\" style=\"max-width:460px\">\r\n                <div class=\"content\">\r\n                    <p>");
#line 98 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
                  Write(Model.BoxSix.Description);

#line default
#line hidden
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n            ");
#line 101 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
       Write(Html.Raw(Model.BoxSix.ListBox));

#line default
#line hidden
            WriteLiteral("\r\n        </div>\r\n    </section>\r\n    <section class=\"home-promotion\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-12 col-md-6\">\r\n                    <div class=\"img text-center\"><img");
            BeginWriteAttribute("src", " src=\"", 4560, "\"", 4585, 1);
#line 108 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
WriteAttributeValue("", 4566, Model.BoxSeven.Url, 4566, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4586, "\"", 4592, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                </div>\r\n                <div class=\"col-12 col-md-6\">\r\n                    <div class=\"promotion-content text-center\">\r\n                        <h2 class=\"home-title\">");
#line 112 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
                                          Write(Model.BoxSeven.TitleOne);

#line default
#line hidden
            WriteLiteral("</h2>\r\n                        <div class=\"home-des\">");
#line 113 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
                                         Write(Model.BoxSeven.TitleTwo);

#line default
#line hidden
            WriteLiteral("</div>\r\n                        <div class=\"home-content\" style=\"max-width:350px\">\r\n                            <div class=\"content\">\r\n                                <p>");
#line 116 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Card\Index.cshtml"
                              Write(Model.BoxSeven.Description);

#line default
#line hidden
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VietbankWebsite.Entities.CardHomeTemplate> Html { get; private set; }
    }
}
#pragma warning restore 1591
