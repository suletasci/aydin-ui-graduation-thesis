#pragma checksum "C:\Users\ener-\source\repos\Zil\Zil.UI\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e78e8da8bfff4483eeb70d6fea39d1470459a829"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
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
#line 1 "C:\Users\ener-\source\repos\Zil\Zil.UI\Views\_ViewImports.cshtml"
using Zil.UI;

#line default
#line hidden
#line 2 "C:\Users\ener-\source\repos\Zil\Zil.UI\Views\_ViewImports.cshtml"
using Zil.UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e78e8da8bfff4483eeb70d6fea39d1470459a829", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c41035cfd3922bf04d402915796a2569b2a1f680", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Courses>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/template/images/courses/img-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(" \r\n");
#line 3 "C:\Users\ener-\source\repos\Zil\Zil.UI\Views\Home\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            WriteLiteral(@" 
  

<!-- Body Start -->
<div class=""wrapper _bg4586"">
    <div class=""_215b01"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""section3125"">
                        <div class=""row justify-content-center"">
                            <div class=""col-xl-4 col-lg-5 col-md-6"">
                                <div class=""preview_video"">
                                    <a href=""#"" class=""fcrse_img"" data-toggle=""modal"" data-target=""#videoModal"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e78e8da8bfff4483eeb70d6fea39d1470459a8294522", async() => {
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
            WriteLiteral("\r\n                                        <div class=\"course-overlay\">\r\n");
#line 23 "C:\Users\ener-\source\repos\Zil\Zil.UI\Views\Home\Detail.cshtml"
                                             if (Model.CoursePlatform == null)
                                            {

#line default
#line hidden
            WriteLiteral("                                                <div class=\"badge_seller\">Birebir Eğitim</div>\r\n");
#line 26 "C:\Users\ener-\source\repos\Zil\Zil.UI\Views\Home\Detail.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            WriteLiteral("                                                <div class=\"badge_seller\">Online Eğitim</div>\r\n");
#line 30 "C:\Users\ener-\source\repos\Zil\Zil.UI\Views\Home\Detail.cshtml"
                                            }

#line default
#line hidden
            WriteLiteral(@"                                             


                                            <span class=""play_btn1""><i class=""uil uil-play""></i></span>
                                            <span class=""_215b02"">Kurs Önizleme</span>
                                        </div>
                                    </a>
                                </div>
                                <div class=""_215b10"">
                                    <a href=""#"" class=""_215b11"">
                                        <span><i class='uil uil-heart-alt'></i></span>İstek
                                    </a>
                                    <a href=""#"" class=""_215b12"">
                                        <span><i class=""uil uil-windsock""></i></span>Şikayet
                                    </a>
                                </div>
                            </div>
                            <div class=""col-xl-8 col-lg-7 col-md-6"">
                                <div class=""_2");
            WriteLiteral("15b03\">\r\n                                    <h2>");
#line 50 "C:\Users\ener-\source\repos\Zil\Zil.UI\Views\Home\Detail.cshtml"
                                   Write(Model.CourseTitle);

#line default
#line hidden
            WriteLiteral("</h2>\r\n                                    <span class=\"_215b04\">");
#line 51 "C:\Users\ener-\source\repos\Zil\Zil.UI\Views\Home\Detail.cshtml"
                                                     Write(Model.CourseSubtitle);

#line default
#line hidden
            WriteLiteral(@"</span>
                                </div>
                                <div class=""_215b05"">
                                    <div class=""crse_reviews mr-2"">
                                        <i class=""uil uil-star""></i>4.5
                                    </div>
                                    (81,665 ratings)
                                </div>
                                <div class=""_215b05"">
                                    114,521 students enrolled
                                </div>
                                <div class=""_215b06"">
                                    <div class=""_215b07"">
                                        <span><i class='uil uil-comment'></i></span>
                                        ");
#line 65 "C:\Users\ener-\source\repos\Zil\Zil.UI\Views\Home\Detail.cshtml"
                                   Write(Model.CourseLanguage);

#line default
#line hidden
            WriteLiteral(@"
                                    </div> 
                                </div> 
                                <ul class=""_215b31""> 
                                    <li><button class=""btn_buy"">Dersi Satın Al(Katıl)</button></li>
                                </ul> 
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""_215b15 _byt1458"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""user_dt5"">
                        <div class=""user_dt_left"">
                            <div class=""live_user_dt"">
                                <div class=""user_img5"">
                                    <a href=""#""><img src=""images/left-imgs/img-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4215, "\"", 4221, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                                </div>\r\n                                <div class=\"user_cntnt\">\r\n                                    <a href=\"#\" class=\"_df7852\">");
#line 90 "C:\Users\ener-\source\repos\Zil\Zil.UI\Views\Home\Detail.cshtml"
                                                           Write(Model.CreatedUser);

#line default
#line hidden
            WriteLiteral(@"</a>
                                    <button class=""subscribe-btn"">Profile Git</button>
                                </div>
                            </div>
                        </div>
                        <div class=""user_dt_right"">
                            <ul>
                                <li>
                                    <a href=""#"" class=""lkcm152""><i class=""uil uil-eye""></i><span>1452</span></a>
                                </li>
                                <li>
                                    <a href=""#"" class=""lkcm152""><i class=""uil uil-thumbs-up""></i><span>100</span></a>
                                </li>
                                <li>
                                    <a href=""#"" class=""lkcm152""><i class=""uil uil-thumbs-down""></i><span>20</span></a>
                                </li>
                                <li>
                                    <a href=""#"" class=""lkcm152""><i class=""uil uil-share-alt""></i><span>9</span></");
            WriteLiteral(@"a>
                                </li>
                            </ul>
                        </div>
                    </div>

                    <div class=""course_tabs"">
                        <nav>
                            <div class=""nav nav-tabs tab_crse justify-content-center"" id=""nav-tab"" role=""tablist"">
                                <a class=""nav-item nav-link active"" id=""nav-about-tab"" data-toggle=""tab"" href=""#nav-about"" role=""tab"" aria-selected=""true"">Hakkında</a>
");
            WriteLiteral(@"                            </div>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
    </div>




    <div class=""_215b17"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""course_tab_content"">
                        <div class=""tab-content"" id=""nav-tabContent"">
                            <div class=""tab-pane fade show active"" id=""nav-about"" role=""tabpanel"">
                                <div class=""_htg451"">
                                    <div class=""_htg452"">
                                        <h3>Gereksinimler</h3>
                                        <ul>
                                            <li><span class=""_5f7g11"">");
#line 141 "C:\Users\ener-\source\repos\Zil\Zil.UI\Views\Home\Detail.cshtml"
                                                                 Write(Model.CoursePrecondition);

#line default
#line hidden
            WriteLiteral(@"</span></li> 
                                        </ul>
                                    </div>
                                    <div class=""_htg452 mt-35"">
                                        <h3>Açıklama</h3>
                                        <p>");
#line 146 "C:\Users\ener-\source\repos\Zil\Zil.UI\Views\Home\Detail.cshtml"
                                      Write(Model.CourseDescription);

#line default
#line hidden
            WriteLiteral(@":</p> 
                                    </div> 

                                   
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>



</div>
<!-- Body End -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Courses> Html { get; private set; }
    }
}
#pragma warning restore 1591
