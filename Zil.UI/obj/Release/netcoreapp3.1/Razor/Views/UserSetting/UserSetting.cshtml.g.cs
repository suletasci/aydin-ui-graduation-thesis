#pragma checksum "C:\Users\ener-\source\repos\Zil\Zil.UI\Views\UserSetting\UserSetting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "151f3df2f4b8c6d74463b163ae49ca113f08b8f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserSetting_UserSetting), @"mvc.1.0.view", @"/Views/UserSetting/UserSetting.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"151f3df2f4b8c6d74463b163ae49ca113f08b8f7", @"/Views/UserSetting/UserSetting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c41035cfd3922bf04d402915796a2569b2a1f680", @"/Views/_ViewImports.cshtml")]
    public class Views_UserSetting_UserSetting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Erkek", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Kadın", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Belirtmek İstemiyorum", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/template/js/jquery-3.3.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Util/Ajax.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/UserSetting/UserSettings.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ener-\source\repos\Zil\Zil.UI\Views\UserSetting\UserSetting.cshtml"
  
    ViewData["Title"] = "UserSetting";
    Layout = "~/Views/Shared/_Layout.cshtml";

    UserSettingModel userSet = Model;

#line default
#line hidden
            WriteLiteral(@"

<div class=""wrapper"">
    <div class=""sa4d25"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <h2 class=""st_title""><i class='uil uil-cog'></i> Ayarlar</h2>
                    <div class=""setting_tabs"">
                        <ul class=""nav nav-pills mb-4"" id=""pills-tab"" role=""tablist"">
                            <li class=""nav-item"">
                                <a class=""nav-link active"" id=""pills-account-tab"" data-toggle=""pill"" href=""#pills-account"" role=""tab"" aria-selected=""true"">Hesap</a>
                            </li>
                        </ul>
                    </div>
                    <div class=""tab-content"" id=""pills-tabContent"">
                        <div class=""tab-pane fade show active"" id=""pills-account"" role=""tabpanel"" aria-labelledby=""pills-account-tab"">
                            <div class=""account_setting"">
                                <h4>Profil Ayarları</h4>
         ");
            WriteLiteral(@"                       <p>Bu sizin Zil'deki kamusal varlığınız. Ücretli kurslarınızı yüklemek, kurslar hakkında yorum yapmak, öğrenciler tarafından satın alınan veya kazanç elde etmek için bir hesaba ihtiyacınız var.</p>
                                <div class=""basic_profile"">
                                    <div class=""basic_ptitle"">
                                        <h4>Profile</h4>
                                        <p>Lütfen bilgileriniz ekleyin</p>
                                    </div>
                                    <div class=""basic_form"">
                                        <div class=""row"">
                                            <div class=""col-lg-8"">
                                                <div class=""row"">

                                                    <div class=""col-lg-6"">
                                                        <div class=""ui search focus mt-30"">
                                                            <div class=""");
            WriteLiteral("ui left icon input swdh11 swdh19\">\r\n                                                                <input class=\"prompt srch_explore\" type=\"text\" name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 2341, "\"", 2366, 1);
#line 40 "C:\Users\ener-\source\repos\Zil\Zil.UI\Views\UserSetting\UserSetting.cshtml"
WriteAttributeValue("", 2349, userSet.UserName, 2349, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" id=\"id_name\"");
            BeginWriteAttribute("required", " required=\"", 2380, "\"", 2391, 0);
            EndWriteAttribute();
            WriteLiteral(@" maxlength=""64"" placeholder=""Ad Soyad"">
                                                            </div>
                                                        </div>
                                                    </div>


                                                    <div class=""col-lg-6"">
                                                        <div class=""ui search focus mt-30"">
                                                            <div class=""ui left icon input swdh11 swdh19"">
                                                                <input class=""prompt srch_explore"" type=""text"" name=""job""");
            BeginWriteAttribute("value", " value=\"", 3027, "\"", 3051, 1);
#line 49 "C:\Users\ener-\source\repos\Zil\Zil.UI\Views\UserSetting\UserSetting.cshtml"
WriteAttributeValue("", 3035, userSet.UserJob, 3035, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" id=\"id_job\"");
            BeginWriteAttribute("required", " required=\"", 3064, "\"", 3075, 0);
            EndWriteAttribute();
            WriteLiteral(@" maxlength=""60"" placeholder=""Meslek"">
                                                                <div class=""form-control-counter"" data-purpose=""form-control-counter"">36</div>
                                                            </div>
                                                            <div class=""help-block"">""Zil'de ""Mühendis"" veya ""Mimar"" gibi profesyonel bir başlık ekleyin.""</div>
                                                        </div>
                                                    </div>
                                                    <div class=""col-lg-6"">
                                                        <div class=""ui search focus mt-30"">
                                                            <div class=""ui left icon input swdh11 swdh19"">
                                                                <input class=""prompt srch_explore"" type=""text"" name=""headline""");
            BeginWriteAttribute("value", " value=\"", 4015, "\"", 4041, 1);
#line 58 "C:\Users\ener-\source\repos\Zil\Zil.UI\Views\UserSetting\UserSetting.cshtml"
WriteAttributeValue("", 4023, userSet.Telephone, 4023, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" id=\"id_telephone\"");
            BeginWriteAttribute("required", " required=\"", 4060, "\"", 4071, 0);
            EndWriteAttribute();
            WriteLiteral(@" maxlength=""60"" placeholder=""Telefon"">
                                                            </div>
                                                        </div>
                                                    </div>

                                                    <div class=""col-lg-6"">
                                                        <div class=""ui search focus mt-30"">
                                                            <div class=""ui left icon input swdh11 swdh19"">
                                                                <input class=""prompt srch_explore"" type=""text"" name=""headline""");
            BeginWriteAttribute("value", " value=\"", 4709, "\"", 4731, 1);
#line 66 "C:\Users\ener-\source\repos\Zil\Zil.UI\Views\UserSetting\UserSetting.cshtml"
WriteAttributeValue("", 4717, userSet.Email, 4717, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" id=\"id_email\"");
            BeginWriteAttribute("required", " required=\"", 4746, "\"", 4757, 0);
            EndWriteAttribute();
            WriteLiteral(@" maxlength=""60"" placeholder=""E mail"">
                                                            </div>
                                                        </div>
                                                    </div>

                                                    <div class=""col-lg-6"">
                                                        <div class=""ui search focus mt-30"">
                                                            <div class=""ui left icon input swdh11 swdh19"">
                                                                <input class=""prompt srch_explore"" type=""date"" name=""dateofbirth""");
            BeginWriteAttribute("value", " value=\"", 5397, "\"", 5422, 1);
#line 74 "C:\Users\ener-\source\repos\Zil\Zil.UI\Views\UserSetting\UserSetting.cshtml"
WriteAttributeValue("", 5405, userSet.BirthDay, 5405, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(@" id=""id_dateofbirth"">
                                                            </div>
                                                        </div>
                                                    </div>

                                                    <div class=""col-lg-6"">
                                                        <div class=""lbel25 mt-30"">
                                                            <select class=""ui hj145 dropdown cntry152 prompt srch_explore""");
            BeginWriteAttribute("value", " value=\"", 5922, "\"", 5945, 1);
#line 81 "C:\Users\ener-\source\repos\Zil\Zil.UI\Views\UserSetting\UserSetting.cshtml"
WriteAttributeValue("", 5930, userSet.Gender, 5930, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" id=\"id_gender\" name=\"card[expire-month]\">\r\n                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "151f3df2f4b8c6d74463b163ae49ca113f08b8f713914", async() => {
                WriteLiteral("Erkek");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "151f3df2f4b8c6d74463b163ae49ca113f08b8f715137", async() => {
                WriteLiteral("Kadın");
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
            WriteLiteral("\r\n                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "151f3df2f4b8c6d74463b163ae49ca113f08b8f716360", async() => {
                WriteLiteral("Belirtmek İstemiyorum");
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
            WriteLiteral(@"
                                                            </select>
                                                        </div>
                                                    </div>



                                                    <div class=""col-lg-12"">
                                                        <div class=""ui search focus mt-30"">
                                                            <div class=""ui form swdh30"">
                                                                <div class=""field"">
                                                                    ");
#line 95 "C:\Users\ener-\source\repos\Zil\Zil.UI\Views\UserSetting\UserSetting.cshtml"
                                                               Write(Html.TextArea("id_about", @userSet.UserDescription, new { rows = "3", type = "text", name = "description", placeholder = "Hakkında kısaca bilgi verebilirsin..." }));

#line default
#line hidden
            WriteLiteral(@"
                                                                </div>
                                                            </div>
                                                            <div class=""help-block"">Bu bölümde bağlantılara ve kupon kodlarına izin verilmiyor.</div>
                                                        </div>
                                                    </div>
                                                    <div class=""col-lg-6"">
                                                        <div class=""ui search focus mt-30"">
                                                            <div class=""ui left icon input swdh11 swdh19"">
                                                                <input class=""prompt srch_explore"" type=""text"" name=""school""");
            BeginWriteAttribute("value", " value=\"", 7924, "\"", 7951, 1);
#line 104 "C:\Users\ener-\source\repos\Zil\Zil.UI\Views\UserSetting\UserSetting.cshtml"
WriteAttributeValue("", 7932, userSet.UserSchool, 7932, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" id=\"id_school\"");
            BeginWriteAttribute("required", " required=\"", 7967, "\"", 7978, 0);
            EndWriteAttribute();
            WriteLiteral(@" maxlength=""60"" placeholder=""Okul"">
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class=""col-lg-12"">
                                                        <div class=""divider-1""></div>
                                                    </div>
                                                    <div class=""col-lg-6"">
                                                        <div class=""ui search focus mt-30"">
                                                            <div class=""ui left icon input swdh11 swdh19"">
                                                                <input class=""prompt srch_explore"" type=""text"" name=""country""");
            BeginWriteAttribute("value", " value=\"", 8834, "\"", 8862, 1);
#line 114 "C:\Users\ener-\source\repos\Zil\Zil.UI\Views\UserSetting\UserSetting.cshtml"
WriteAttributeValue("", 8842, userSet.UserCountry, 8842, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" id=\"id_country\"");
            BeginWriteAttribute("required", " required=\"", 8879, "\"", 8890, 0);
            EndWriteAttribute();
            WriteLiteral(@" maxlength=""60"" placeholder=""Şehir Giriniz"">
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class=""col-lg-6"">
                                                        <div class=""ui search focus mt-30"">
                                                            <div class=""ui left icon input swdh11 swdh19"">
                                                                <input class=""prompt srch_explore"" type=""text"" name=""addressname""");
            BeginWriteAttribute("value", " value=\"", 9535, "\"", 9562, 1);
#line 121 "C:\Users\ener-\source\repos\Zil\Zil.UI\Views\UserSetting\UserSetting.cshtml"
WriteAttributeValue("", 9543, userSet.UserAdress, 9543, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" id=\"id_address\"");
            BeginWriteAttribute("required", " required=\"", 9579, "\"", 9590, 0);
            EndWriteAttribute();
            WriteLiteral(@" maxlength=""64"" placeholder=""Adres"">
                                                                <div class=""form-control-counter"" data-purpose=""form-control-counter"">136</div>
                                                            </div>
                                                        </div>
                                                    </div>




                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <div class=""basic_profile1"">
                                    <div class=""basic_ptitle"">
                                        <h4>Profil Linklerin</h4>
                                    </div>
                                    <div class=""basic_form"">
                                        <div class=""row"">
                                         ");
            WriteLiteral(@"   <div class=""col-lg-8"">
                                                <div class=""row"">

                                                    <div class=""col-lg-6"">
                                                        <div class=""ui search focus mt-30"">
                                                            <div class=""ui left icon labeled input swdh11 swdh31"">
                                                                <div class=""ui label lb12"">
                                                                    https://
                                                                </div>
                                                                <input class=""prompt srch_explore"" type=""text"" name=""site""");
            BeginWriteAttribute("value", " value=\"", 11361, "\"", 11389, 1);
#line 151 "C:\Users\ener-\source\repos\Zil\Zil.UI\Views\UserSetting\UserSetting.cshtml"
WriteAttributeValue("", 11369, userSet.UserWebSite, 11369, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" id=\"id_site\"");
            BeginWriteAttribute("required", " required=\"", 11403, "\"", 11414, 0);
            EndWriteAttribute();
            WriteLiteral(@" maxlength=""64"" placeholder=""website.com"">
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class=""col-lg-6"">
                                                        <div class=""ui search focus mt-30"">
                                                            <div class=""ui left icon labeled input swdh11 swdh31"">
                                                                <div class=""ui label lb12"">
                                                                    twitter.com/
                                                                </div>
                                                                <input class=""prompt srch_explore""");
            BeginWriteAttribute("value", " value=\"", 12281, "\"", 12309, 1);
#line 161 "C:\Users\ener-\source\repos\Zil\Zil.UI\Views\UserSetting\UserSetting.cshtml"
WriteAttributeValue("", 12289, userSet.UserTwitter, 12289, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" name=\"twitterlink\" id=\"id_twitter\"");
            BeginWriteAttribute("required", " required=\"", 12357, "\"", 12368, 0);
            EndWriteAttribute();
            WriteLiteral(@" maxlength=""64"" placeholder=""Twitter Profile"">
                                                            </div>
                                                            <div class=""help-block"">Twitter bağlantınız .</div>
                                                        </div>
                                                    </div>
                                                    <div class=""col-lg-6"">
                                                        <div class=""ui search focus mt-30"">
                                                            <div class=""ui left icon labeled input swdh11 swdh31"">
                                                                <div class=""ui label lb12"">
                                                                    linkedin.com/
                                                                </div>
                                                                <input class=""prompt srch_explore""");
            BeginWriteAttribute("value", " value=\"", 13353, "\"", 13382, 1);
#line 172 "C:\Users\ener-\source\repos\Zil\Zil.UI\Views\UserSetting\UserSetting.cshtml"
WriteAttributeValue("", 13361, userSet.UserLinkedin, 13361, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" name=\"linkedinlink\" id=\"id_linkedin\"");
            BeginWriteAttribute("required", " required=\"", 13432, "\"", 13443, 0);
            EndWriteAttribute();
            WriteLiteral(@" maxlength=""64"" placeholder=""Linkedin Profile"">
                                                            </div>
                                                            <div class=""help-block"">Linkedin bağlantınız .</div>
                                                        </div>
                                                    </div>
                                                    <div class=""col-lg-6"">
                                                        <div class=""ui search focus mt-30"">
                                                            <div class=""ui left icon labeled input swdh11 swdh31"">
                                                                <div class=""ui label lb12"">
                                                                    youtube.com/
                                                                </div>
                                                                <input class=""prompt srch_explore"" type=""text""");
            BeginWriteAttribute("value", " value=\"", 14441, "\"", 14469, 1);
#line 183 "C:\Users\ener-\source\repos\Zil\Zil.UI\Views\UserSetting\UserSetting.cshtml"
WriteAttributeValue("", 14449, userSet.UserYoutube, 14449, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" name=\"youtubelink\" id=\"id_youtube\"");
            BeginWriteAttribute("required", " required=\"", 14505, "\"", 14516, 0);
            EndWriteAttribute();
            WriteLiteral(@" maxlength=""64"" placeholder=""Youtube Profile"">
                                                            </div>
                                                            <div class=""help-block"">Youtube bağlantınız .</div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <button class=""save_btn"" id=""btn_userSetting"" type=""submit"">Değişiklikleri Kaydet</button>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>

</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "151f3df2f4b8c6d74463b163ae49ca113f08b8f730159", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "151f3df2f4b8c6d74463b163ae49ca113f08b8f731199", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "151f3df2f4b8c6d74463b163ae49ca113f08b8f732239", async() => {
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
            WriteLiteral(@"
<script>
    document.getElementById('id_telephone').addEventListener('input', function (e) {
        var x = e.target.value.replace(/\D/g, '').match(/(\d{0,3})(\d{0,3})(\d{0,4})/);
        e.target.value = !x[2] ? x[1] : '(' + x[1] + ') ' + x[2] + (x[3] ? '-' + x[3] : '');
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
