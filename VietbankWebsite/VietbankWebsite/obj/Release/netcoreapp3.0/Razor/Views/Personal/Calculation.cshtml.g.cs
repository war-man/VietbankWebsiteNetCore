#pragma checksum "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8db355b775d8fabc5694db4437c1b1252d6a4420"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personal_Calculation), @"mvc.1.0.view", @"/Views/Personal/Calculation.cshtml")]
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
#line 2 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8db355b775d8fabc5694db4437c1b1252d6a4420", @"/Views/Personal/Calculation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226e66e476153809e3942cb65fb4710596043976", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_Calculation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VietbankWebsite.ModelMap.IntroduceDetail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Partial/_ToolCalulationPersonalBar.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "tuần", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "tháng", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.table2excel.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/page/tool-calulation.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
  
    ViewData["Title"] = @Localizer["CalculationName"].Value;
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
            BeginWriteAttribute("href", " href=\"", 512, "\"", 544, 1);
#nullable restore
#line 15 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
WriteAttributeValue("", 519, Localizer["PersonalUrl"], 519, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                                           Write(Localizer["PersonalName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 613, "\"", 644, 1);
#nullable restore
#line 16 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
WriteAttributeValue("", 620, Localizer["SupportUrl"], 620, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                                          Write(Localizer["SupportName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li class=\"active\"><span>");
#nullable restore
#line 17 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                            Write(Localizer["CalculationName"]);

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
        <div style=""background-image:url('/img/banner_page/banner_bieuphi.png')"" class=""imgBg""></div>
        <div class=""desc"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xs-12 col-sm-5 col-lg-5 col-xl-5"">
                        <h1 class=""title"">");
#nullable restore
#line 29 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                     Write(Localizer["CalculationName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <div class=\"content\">");
#nullable restore
#line 30 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                        Write(Localizer["CalculationDes"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</section>\r\n<main>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-xs-12 col-lg-3\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8db355b775d8fabc5694db4437c1b1252d6a44209413", async() => {
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
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-xs-12 col-lg-9\">\r\n                <section class=\"hotro-ct\">\r\n                    <h1 class=\"title\">");
#nullable restore
#line 45 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                 Write(Localizer["CalculationName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                                                                                                                                    </h1>\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 2058, "\"", 2066, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""support-personal"">
                        <div class=""tabs-support"">
                            <ul role=""tablist"" class=""nav-jt-sp"">
                                <li class=""nav-item"">
                                    <a href=""#tab1"" data-toggle=""tab"" role=""tab"" class=""active"" aria-expanded=""true"">");
#nullable restore
#line 50 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                                                                                                Write(Localizer["TabOneTitle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </li>\r\n                                <li class=\"nav-item\">\r\n                                    <a href=\"#tab2\" data-toggle=\"tab\" role=\"tab\"");
            BeginWriteAttribute("class", " class=\"", 2588, "\"", 2596, 0);
            EndWriteAttribute();
            WriteLiteral(" aria-expanded=\"false\">");
#nullable restore
#line 53 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                                                                                           Write(Localizer["TabTwoTitle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </li>\r\n                                <li class=\"nav-item\">\r\n                                    <a href=\"#tab3\" data-toggle=\"tab\" role=\"tab\"");
            BeginWriteAttribute("class", " class=\"", 2825, "\"", 2833, 0);
            EndWriteAttribute();
            WriteLiteral(" aria-expanded=\"false\">");
#nullable restore
#line 56 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                                                                                           Write(Localizer["TabThreeTitle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                </li>
                            </ul>
                        </div>
                        <div class=""tab-content"">
                            <div role=""tabpanel"" class=""thetindung tab-pane active"" id=""tab1"" aria-expanded=""true"">
                                <div class=""block-borrowTool"">
                                    <div class=""form-group"">
                                        <label>");
#nullable restore
#line 64 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                          Write(Localizer["TabOneLabelOne"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                        <div class=""group"">
                                            <input id=""so-tien-tra-moi-thang"" class=""form-control"">
                                        </div>
                                    </div>
                                    <div class=""form-group"">
                                        <label>");
#nullable restore
#line 70 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                          Write(Localizer["TabOneLabelTwo"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                        <div class=\"group\">\r\n                                            <input id=\"so-thang-vay\" class=\"form-control\"><span class=\"unit\">");
#nullable restore
#line 72 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                                                                                        Write(Localizer["TabOneLabelTwoUnit"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"form-group\">\r\n                                        <label>");
#nullable restore
#line 76 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                          Write(Localizer["TabOneLabelThree"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                        <div class=""group"">
                                            <input id=""lai-suat-vay"" class=""form-control""><span class=""unit"">%</span>
                                        </div>
                                    </div>
                                    <div class=""form-group"">
                                        <input style=""float: left;"" id=""submit-uoctinhkhoangvai"" type=""submit""");
            BeginWriteAttribute("value", " value=\"", 4672, "\"", 4709, 1);
#nullable restore
#line 82 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
WriteAttributeValue("", 4680, Localizer["TabOneLabelFour"], 4680, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                    <div class=\"result\">\r\n                                        <h3>");
#nullable restore
#line 85 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                       Write(Localizer["TabOneLabelFive"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                        <div class=\"row flex flex-wrap\">\r\n                                            <div class=\"col-xs-12 col-md-6\">\r\n                                                <div class=\"item-result\"><strong>");
#nullable restore
#line 88 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                                                            Write(Localizer["TabOneLabelSix"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </strong><span id=""du-dinh-tra-no""></span></div>
                                            </div>
                                            <div class=""col-xs-12 col-md-6"">
                                                <div class=""item-result""><strong>");
#nullable restore
#line 91 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                                                            Write(Localizer["TabOneLabelSeven"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </strong><span id=""so-tien-vay-toi-da""></span></div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div role=""tabpanel"" class=""thetindung tab-pane"" id=""tab2"" aria-expanded=""false"">
                                <div class=""block-calculatorTool"">
                                    <div class=""row flex flex-wrap"">
                                        <div class=""col-xs-12 col-md-6"">
                                            <div class=""form-group"">
                                                <label>");
#nullable restore
#line 102 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                                  Write(Localizer["TabTwoLabelOne"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                                <div class=\"group\">\r\n                                                    <input id=\"sotienvay\"");
            BeginWriteAttribute("value", " value=\"", 6351, "\"", 6359, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control""><span class=""unit"">VND</span>
                                                </div>
                                            </div>
                                            <div class=""form-group"">
                                                <label>");
#nullable restore
#line 108 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                                  Write(Localizer["TabTwoLabelTwo"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                                <div class=\"group\">\r\n                                                    <input id=\"thoigianvay\"");
            BeginWriteAttribute("value", " value=\"", 6828, "\"", 6836, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\"><span class=\"unit\">");
#nullable restore
#line 110 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                                                                                                        Write(Localizer["TabOneLabelTwoUnit"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                </div>\r\n                                            </div>\r\n                                            <div class=\"form-group\">\r\n                                                <label>");
#nullable restore
#line 114 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                                  Write(Localizer["TabTwoLabelThree"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                                <div class=\"group\">\r\n                                                    <input id=\"laisuat\"");
            BeginWriteAttribute("value", " value=\"", 7332, "\"", 7340, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control""><span class=""unit"">%</span>
                                                </div>
                                            </div>
                                        </div>

                                        <div class=""col-xs-12"">
                                            <div class=""form-group"">
                                                <input id=""btn-tinhnogiamdan"" type=""submit""");
            BeginWriteAttribute("value", " value=\"", 7776, "\"", 7813, 1);
#nullable restore
#line 123 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
WriteAttributeValue("", 7784, Localizer["TabTwoLabelFive"], 7784, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""block-calculatorTool"">
                                    <div class=""title-wrap"">
                                        <h3 class=""title-tool"">");
#nullable restore
#line 130 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                                          Write(Localizer["TabTwoLabelFour"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                                        <div class=""support-wrap"">
                                            <a onclick=""jtExportToExcel();event.preventDefault();"" href=""#""><img class=""lazyload"" data-src=""/img/excel_icon.png"" src=""/img/excel_icon.png""><span>");
#nullable restore
#line 132 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                                                                                                                                                                            Write(Localizer["ExportExcel"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n                                            <a onclick=\"jtprinttygia(); event.preventDefault();\" href=\"#\"><img class=\"lazyload\" data-src=\"/img/print_icon.png\" src=\"/img/print_icon.png\"><span>");
#nullable restore
#line 133 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                                                                                                                                                                          Write(Localizer["Print"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></a>
                                        </div>
                                    </div>
                                    <div class=""table-responsive"">
                                        <table id=""kq-tinhdunobandau"" class=""table""></table>
                                    </div>
                                </div>
                            </div>
                            <div role=""tabpanel"" class=""thetindung tab-pane"" id=""tab3"" aria-expanded=""false"">
                                <div class=""block-revive"">
                                    <div class=""row flex flex-wrap"">
                                        <div class=""col-xs-12 col-md-6"">
                                            <div class=""form-group"">
                                                <label>");
#nullable restore
#line 146 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                                  Write(Localizer["TabThreeLabelOne"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                                <div class=\"group\">\r\n                                                    <input id=\"so-tien-goi-person\"");
            BeginWriteAttribute("value", " value=\"", 9757, "\"", 9765, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control""><span class=""unit"">VND</span>
                                                </div>
                                            </div>
                                            <div class=""form-group"">
                                                <label>");
#nullable restore
#line 152 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                                  Write(Localizer["TabThreeLabelTwo"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                                <div id=""ky-hang-gui-person"" class=""group"">
                                                    <input disabled=""disabled"" class=""form-control""><span class=""unit hidden""></span>
                                                    <select style=""position: absolute; width: 120px; top: 0px; right: 0px; z-index: 100; background-color: white; border-bottom-left-radius: inherit; border-top-left-radius: inherit;"" id=""ky-lanh-lai-person"" class=""form-control"">
                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8db355b775d8fabc5694db4437c1b1252d6a442027484", async() => {
#nullable restore
#line 156 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                                                    Write(Localizer["TabThreeLabelTwoOne"]);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8db355b775d8fabc5694db4437c1b1252d6a442028950", async() => {
#nullable restore
#line 157 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                                                        Write(Localizer["TabThreeLabelTwoTwo"]);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8db355b775d8fabc5694db4437c1b1252d6a442030420", async() => {
#nullable restore
#line 158 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                                                         Write(Localizer["TabThreeLabelTwoThree"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
                                            </div>
                                        </div>
                                        <div class=""col-xs-12 col-md-6"">

                                            <div class=""form-group"">
                                                <label>");
#nullable restore
#line 167 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                                  Write(Localizer["TabThreeLabelThree"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                                <div class=""group"">
                                                    <input id=""lai-suat-person"" class=""form-control""><span class=""unit"">%</span>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    ");
#nullable restore
#line 174 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                               Write(Html.Raw(Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            \r\n                                    <div class=\"form-group btn-result\">\r\n                                    <input id=\"uoc-tinh-person\" type=\"submit\"");
            BeginWriteAttribute("value", " value=\"", 12080, "\"", 12117, 1);
#nullable restore
#line 176 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
WriteAttributeValue("", 12088, Localizer["TabTwoLabelFive"], 12088, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                    <div class=\"result\">\r\n                                        <h3>");
#nullable restore
#line 179 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                       Write(Localizer["TabThreeLabelFour"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                        <div class=\"row flex flex-wrap\">\r\n                                            <div class=\"col-xs-12 col-md-6\">\r\n\r\n                                                <div class=\"item-result\"><strong>");
#nullable restore
#line 183 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                                                            Write(Localizer["TabThreeLabelFive"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </strong><span class=""tong-tien-lai""></span></div>
                                            </div>
                                            <div class=""col-xs-12 col-md-6"">
                                                <div class=""item-result""><strong>");
#nullable restore
#line 186 "T:\Github\VietbankWebsiteNetCore\VietbankWebsite\VietbankWebsite\Views\Personal\Calculation.cshtml"
                                                                            Write(Localizer["TabThreeLabelSix"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </strong><span class=""tong-so-tien-nhan-duoc""></span></div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </section>
            </div>
        </div>
    </div>
</main>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8db355b775d8fabc5694db4437c1b1252d6a442036071", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8db355b775d8fabc5694db4437c1b1252d6a442037171", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VietbankWebsite.ModelMap.IntroduceDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
