#pragma checksum "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Account\ChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0059584fa38e187ee1876eab485c871882f8f0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ChangePassword), @"mvc.1.0.view", @"/Views/Account/ChangePassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/ChangePassword.cshtml", typeof(AspNetCore.Views_Account_ChangePassword))]
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
#line 1 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\_ViewImports.cshtml"
using CarWash.Web;

#line default
#line hidden
#line 2 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\_ViewImports.cshtml"
using CarWash.Web.Models;

#line default
#line hidden
#line 4 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 5 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\_ViewImports.cshtml"
using CarWash.Web.Infrastructures.Domain.Helpers;

#line default
#line hidden
#line 6 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0059584fa38e187ee1876eab485c871882f8f0a", @"/Views/Account/ChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c63ec8b4ff39190a57bd53c4bcdd08e35dae823", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarWash.Web.ViewModels.ChangePasswordViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/account/change-password"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Account\ChangePassword.cshtml"
  
    ViewData["Title"] = "ChangePassword";

#line default
#line hidden
            BeginContext(105, 429, true);
            WriteLiteral(@"



<div class=""container mt-5"">
    <div class=""row"">
        <div class=""col-md-11 mx-auto"">
            <div id=""first"">
                <div class=""myform form "">
                    <div class=""logo mb-3"">
                        <div class=""col-md-12 text-center"">
                            <h1>Change Password your account</h1>
                        </div>
                    </div>
                    ");
            EndContext();
            BeginContext(534, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "865e100af68f4957bccc64006e1659a4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 19 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Account\ChangePassword.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(606, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(629, 23, false);
#line 20 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Account\ChangePassword.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(652, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(674, 2436, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2087d8baaccf4c978852ccc4b0c0fc3a", async() => {
                BeginContext(752, 60, true);
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"UserId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 812, "\"", 833, 1);
#line 22 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Account\ChangePassword.cshtml"
WriteAttributeValue("", 820, Model.UserId, 820, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(834, 2269, true);
                WriteLiteral(@" />
                        <div class=""form-group"">
                            <label for=""oldPassword"" class=""cols-sm-2 control-label"">Old Password </label>
                            <div class=""cols-sm-10"">
                                <div class=""input-group"">
                                    <span class=""input-group-addon""><i class=""fa fa-user"" aria-hidden=""true""></i></span>
                                    <input type=""text"" class=""form-control"" name=""OldPassword"" id=""oldPassword"" placeholder=""Enter your Old Password"" />
                                </div>
                            </div>
                        </div>

                        <div class=""form-group"">
                            <label for=""newPassword"" class=""cols-sm-2 control-label"">New Password </label>
                            <div class=""cols-sm-10"">
                                <div class=""input-group"">
                                    <span class=""input-group-addon""><i class=""fa fa-user"" a");
                WriteLiteral(@"ria-hidden=""true""></i></span>
                                    <input type=""text"" class=""form-control"" name=""NewPassword"" id=""newPassword"" placeholder=""Enter your New Password"" />
                                </div>
                            </div>
                        </div>

                        <div class=""form-group"">
                            <label for=""confirmNewPassword"" class=""cols-sm-2 control-label"">Confirm Password </label>
                            <div class=""cols-sm-10"">
                                <div class=""input-group"">
                                    <span class=""input-group-addon""><i class=""fa fa-user"" aria-hidden=""true""></i></span>
                                    <input type=""text"" class=""form-control"" name=""ConfirmNewPassword"" id=""confirmPassword"" placeholder=""Enter your Confirm New Password"" />
                                </div>
                            </div>
                        </div>


                        <div class=""form");
                WriteLiteral("-group \">\r\n                            <button type=\"submit\" id=\"submit\" value=\"ChangePassword\" class=\"btn btn-primary btn-lg btn-block login-button\">Submit</button>\r\n                        </div>\r\n\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3110, 88, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(3198, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae7c44ee502d443ea227e4030d73d6b1", async() => {
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
            EndContext();
            BeginContext(3251, 1099, true);
            WriteLiteral(@"
<script type=""text/javascript"">
    $(document).ready(function () {
        $(""#submit"").attr('disabled', 'disabled');

        $(""form"").keyup(function () {
            // To Disable Submit Button
            $(""#submit"").attr('disabled', 'disabled');
            // Validating Fields
            var oldPassword = $(""#oldPassword"").val();
            var newPassword = $(""#newPassword"").val();
            var confirmPassword = $(""#confirmPassword"").val();


            if (!(oldPassword == """" || newPassword == """" || confirmPassword == """"))
            {

                // To Enable Submit Button
                $(""#submit"").removeAttr('disabled');
                $(""#submit"").css({
                    ""cursor"": ""pointer"",
                    ""box-shadow"": ""1px 0px 6px #333""
                });

            }
        });
        // On Click Of Submit Button
        $(""#submit"").click(function () {
            $(""#submit"").css({
                ""cursor"": ""default"",
               ");
            WriteLiteral(" \"box-shadow\": \"none\"\r\n            });\r\n\r\n        });\r\n    });\r\n\r\n</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarWash.Web.ViewModels.ChangePasswordViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
