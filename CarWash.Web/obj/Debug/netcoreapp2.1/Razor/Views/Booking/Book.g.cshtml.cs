#pragma checksum "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Book.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ac40ff4d25be5b72628c7a2a6329661e2b6e857"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Book), @"mvc.1.0.view", @"/Views/Booking/Book.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Booking/Book.cshtml", typeof(AspNetCore.Views_Booking_Book))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ac40ff4d25be5b72628c7a2a6329661e2b6e857", @"/Views/Booking/Book.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c63ec8b4ff39190a57bd53c4bcdd08e35dae823", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Book : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarWash.Web.ViewModels.bookings.BookViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/feedback/add-comment-with-rating"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("commenting-form collapse"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("add-comment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex mr-3 rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor//jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/bootstrap//js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Book.cshtml"
  
    ViewData["Title"] = "Book";

#line default
#line hidden
            BeginContext(94, 182, true);
            WriteLiteral("\r\n<br /><br /><br />  \r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n\r\n        <!-- Post Content Column -->\r\n        <div class=\"col-lg-8\">\r\n\r\n            <!-- Preview Image -->\r\n");
            EndContext();
            BeginContext(366, 53, true);
            WriteLiteral("            <div class=\"title\">\r\n                <h2>");
            EndContext();
            BeginContext(420, 13, false);
#line 16 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Book.cshtml"
               Write(Model.Vehicle);

#line default
#line hidden
            EndContext();
            BeginContext(433, 105, true);
            WriteLiteral("</h2>\r\n            </div>\r\n            <hr>\r\n            <!-- Date/Time -->\r\n            <p>Updated At : ");
            EndContext();
            BeginContext(539, 15, false);
#line 20 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Book.cshtml"
                       Write(Model.UpdatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(554, 87, true);
            WriteLiteral("</p>\r\n            <hr>\r\n            <!-- Post Content -->\r\n            <p class=\"lead\">");
            EndContext();
            BeginContext(642, 17, false);
#line 23 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Book.cshtml"
                       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(659, 370, true);
            WriteLiteral(@"</p>
            <hr>

            <!-- Comments Form -->
                <button class=""btn btn-dark"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#add-comment-form"" aria-expanded=""false"" aria-controls=""add-comment-form"">
                    Leave a feedback
                </button>
  
                <button id=""unlikeButton"" class=""btn btn-dark""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1029, "\"", 1090, 1);
#line 31 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Book.cshtml"
WriteAttributeValue("", 1037, Model.IsLiked ? "display:visible" : "display:none", 1037, 53, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1091, "\"", 1144, 5);
            WriteAttributeValue("", 1101, "feedbackUnlike(\'", 1101, 16, true);
#line 31 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Book.cshtml"
WriteAttributeValue("", 1117, Model.Id, 1117, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 1126, "\',\'", 1126, 3, true);
#line 31 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Book.cshtml"
WriteAttributeValue("", 1129, Model.UserId, 1129, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 1142, "\')", 1142, 2, true);
            EndWriteAttribute();
            BeginContext(1145, 116, true);
            WriteLiteral("><i class=\"fa fa-thumbs-down text-light\"></i></button>\r\n                <button id=\"likeButton\" class=\"btn btn-dark\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1261, "\"", 1322, 1);
#line 32 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Book.cshtml"
WriteAttributeValue("", 1269, Model.IsLiked ? "display:none" : "display:visible", 1269, 53, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1323, "\"", 1374, 5);
            WriteAttributeValue("", 1333, "feedbackLike(\'", 1333, 14, true);
#line 32 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Book.cshtml"
WriteAttributeValue("", 1347, Model.Id, 1347, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 1356, "\',\'", 1356, 3, true);
#line 32 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Book.cshtml"
WriteAttributeValue("", 1359, Model.UserId, 1359, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 1372, "\')", 1372, 2, true);
            EndWriteAttribute();
            BeginContext(1375, 128, true);
            WriteLiteral("><i class=\"fa fa-thumbs-up text-light\"></i></button>\r\n                <h3 class=\"h6\">Rated : <span id=\"rating-score\" class=\"h4\">");
            EndContext();
            BeginContext(1504, 33, false);
#line 33 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Book.cshtml"
                                                                     Write(Model.RatingAve.ToString("##.##"));

#line default
#line hidden
            EndContext();
            BeginContext(1537, 91, true);
            WriteLiteral("</span><i class=\"fa fa-star\"></i>&nbsp;&nbsp;&nbsp; Liked by : <span class=\"h4\" id=\"likes\">");
            EndContext();
            BeginContext(1629, 11, false);
#line 33 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Book.cshtml"
                                                                                                                                                                                                  Write(Model.Likes);

#line default
#line hidden
            EndContext();
            BeginContext(1640, 152, true);
            WriteLiteral("</span><i class=\"fa fa-thumbs-up\"></i> </h3>\r\n                <hr />\r\n                <div class=\"collapse\" id=\"add-comment-form\">\r\n                    ");
            EndContext();
            BeginContext(1792, 3112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae1c72da5e184120a308441e8180bfac", async() => {
                BeginContext(1910, 2278, true);
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""form-group col-md-12"">
                                <div class=""form-row"">
                                    <label class=""myratings col-md-2"">Score : <span id=""score""></span></label>
                                    <fieldset class=""rating col-md-4 form-control"">
                                        <input type=""radio"" id=""star5"" name=""rating"" value=""5"" /><label class=""full"" for=""star5"" title=""Awesome - 5 stars""></label>
                                        <input type=""radio"" id=""star4half"" name=""rating"" value=""4.5"" /><label class=""half"" for=""star4half"" title=""Pretty good - 4.5 stars""></label>
                                        <input type=""radio"" id=""star4"" name=""rating"" value=""4"" /><label class=""full"" for=""star4"" title=""Pretty good - 4 stars""></label>
                                        <input type=""radio"" id=""star3half"" name=""rating"" value=""3.5"" /><label class=""half"" for=""star3half"" title=""M");
                WriteLiteral(@"eh - 3.5 stars""></label>
                                        <input type=""radio"" id=""star3"" name=""rating"" value=""3"" /><label class=""full"" for=""star3"" title=""Meh - 3 stars""></label>
                                        <input type=""radio"" id=""star2half"" name=""rating"" value=""2.5"" /><label class=""half"" for=""star2half"" title=""Kinda bad - 2.5 stars""></label>
                                        <input type=""radio"" id=""star2"" name=""rating"" value=""2"" /><label class=""full"" for=""star2"" title=""Kinda bad - 2 stars""></label>
                                        <input type=""radio"" id=""star1half"" name=""rating"" value=""1.5"" /><label class=""half"" for=""star1half"" title=""Meh - 1.5 stars""></label>
                                        <input type=""radio"" id=""star1"" name=""rating"" value=""1"" /><label class=""full"" for=""star1"" title=""Sucks big time - 1 star""></label>
                                        <input type=""radio"" id=""starhalf"" name=""rating"" value=""0.5"" /><label class=""half"" for=""starhalf"" title=""Suc");
                WriteLiteral("ks big time - 0.5 stars\"></label>\r\n                                    </fieldset>\r\n                                    <input id=\"ratings\" name=\"Score\" type=\"hidden\" />\r\n                                    <input name=\"ServiceId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4188, "\"", 4205, 1);
#line 54 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Book.cshtml"
WriteAttributeValue("", 4196, Model.Id, 4196, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4206, 75, true);
                WriteLiteral(" type=\"hidden\" />\r\n                                    <input name=\"UserId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4281, "\"", 4302, 1);
#line 55 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Book.cshtml"
WriteAttributeValue("", 4289, Model.UserId, 4289, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4303, 594, true);
                WriteLiteral(@" type=""hidden"" />
                                </div>
                            </div>

                            <div class=""form-group col-md-12"">
                                <textarea name=""Comment"" id=""usercomment"" placeholder=""Type your comment"" class=""form-control""></textarea>
                            </div>
                            <div class=""form-group col-md-12"">
                                <button type=""submit"" class=""btn btn-secondary"">Submit Comment</button>
                            </div>
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4904, 40, true);
            WriteLiteral("\r\n                </div>\r\n\r\n          \r\n");
            EndContext();
#line 70 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Book.cshtml"
              
                if (Model.CommentItems != null)
                {
                    if (Model.CommentItems.Count > 0)
                    {
                        foreach (var comment in Model.CommentItems)
                        {

#line default
#line hidden
            BeginContext(5202, 115, true);
            WriteLiteral("                            <!-- Single Comment -->\r\n                <div class=\"media mb-4\">\r\n                    ");
            EndContext();
            BeginContext(5317, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "03645044b96b4e5e8468f48b1702c8e1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5362, "~/", 5362, 2, true);
#line 79 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Book.cshtml"
AddHtmlAttributeValue("", 5364, comment.UserIcon, 5364, 19, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5395, 41, true);
            WriteLiteral("\r\n                    <span class=\"date\">");
            EndContext();
            BeginContext(5437, 54, false);
#line 80 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Book.cshtml"
                                  Write(comment.UpdatedAt.ToString("dddd, dd MMMM yyyy HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(5491, 96, true);
            WriteLiteral("</span>\r\n                    <div class=\"media-body\">\r\n                        <h5 class=\"mt-0\">");
            EndContext();
            BeginContext(5588, 16, false);
#line 82 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Book.cshtml"
                                    Write(comment.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(5604, 33, true);
            WriteLiteral("</h5>\r\n\r\n                        ");
            EndContext();
            BeginContext(5638, 15, false);
#line 84 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Book.cshtml"
                   Write(comment.Content);

#line default
#line hidden
            EndContext();
            BeginContext(5653, 129, true);
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"footer-\">\r\n\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 91 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Book.cshtml"

                          
                        }
                    }
                }
            

#line default
#line hidden
            BeginContext(5896, 39, true);
            WriteLiteral("\r\n            <!-- Single Comment -->\r\n");
            EndContext();
            BeginContext(6491, 53, true);
            WriteLiteral("\r\n            <!-- Comment with nested comments -->\r\n");
            EndContext();
            BeginContext(8242, 311, true);
            WriteLiteral(@"
        </div>

        <!-- Sidebar Widgets Column -->
        <div class=""col-md-4"">

            <!-- Side Widget -->
            <div class=""card my-5"">
                <h5 class=""card-header"">Details</h5>
                <div class=""card-body"">
                    <strong>Price :</strong><span>");
            EndContext();
            BeginContext(8554, 25, false);
#line 142 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Book.cshtml"
                                             Write(Model.Price.ToString("F"));

#line default
#line hidden
            EndContext();
            BeginContext(8579, 110, true);
            WriteLiteral("</span>\r\n                    <br />\r\n                    <strong>Status :</strong>\r\n                    <span>");
            EndContext();
            BeginContext(8690, 17, false);
#line 145 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Book.cshtml"
                     Write(Model.ServiceType);

#line default
#line hidden
            EndContext();
            BeginContext(8707, 1596, true);
            WriteLiteral(@" </span>
                  


                </div>
            </div>

        </div>

    </div>
    <!-- /.row -->

</div>

    <style>


        .myratings {
            margin-top: 5px;
            font-size: 1.5em;
        }

        fieldset,
        label {
            margin: 0;
            padding: 0;
        }

        .rating {
            border: none;
            cursor: pointer;
        }

            .rating > [id^=""star""] {
                display: none;
            }

            .rating > label:before {
                margin: 5px;
                font-size: 3em;
                font-family: FontAwesome;
                display: inline-block;
                content: ""\2605"";
            }

            .rating > .half:before {
                content: ""\2605"";
                position: absolute;
            }

            .rating > label {
                color: #ddd;
                float: right;
                cursor: pointer;
      ");
            WriteLiteral(@"      }

            .rating > [id^=""star""]:checked ~ label,
            .rating:not(:checked) > label:hover,
            .rating:not(:checked) > label:hover ~ label {
                color: #FFD700;
            }

                .rating > [id^=""star""]:checked + label:hover,
                .rating > [id^=""star""]:checked ~ label:hover,
                .rating > label:hover ~ [id^=""star""]:checked ~ label,
                .rating > [id^=""star""]:checked ~ label:hover ~ label {
                    color: #FFED85;
                }
    </style>



    ");
            EndContext();
            BeginContext(10303, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e86e349b30d549af8ceb84a2574a3098", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10357, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(10363, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bc4db71d8334f9f8bf05ae0a38c8c36", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10433, 2206, true);
            WriteLiteral(@"
    <script>
    $(document).ready(function () {

        $(""input[type='radio']"").click(function () {
            var score = $(""input[type='radio']:checked"").val();

            $(""#score"").html(score);

            if (score < 3) {
                $('.myratings').css('color', 'red');
            } else {
                $('.myratings').css('color', 'green');
            }

            $("".myratings"").text(""Score : "" + score);
            $(""#ratings"").val(score);
        });
    });

    function feedbackLike(serviceId,userId) {
    var model = {
        ServiceId: serviceId,
        UserId: userId,
        IsLiked: true
    }

        feedbackLikeAjax(model);

    }

    function feedbackLikeAjax(model) {
        route = ""/feedback/likes"";
        $.ajax({
            url: route,
            dataType: ""json"",
            data: model,
            type: ""POST"",
            async: false
        }).done(function (obj) {
            var result = obj.data;

           ");
            WriteLiteral(@" $(""#likes"").html(result.likes);

            if (result.isLiked == true) {
                $(""#likeButton"").hide();
                $(""#unlikeButton"").show();
            }
            else {
                $(""#unlikeButton"").hide();
                $(""#likeButton"").show();
            }
        });
    }

    function feedbackUnlike(serviceId, userId) {
        var model = {
            ServiceId: serviceId,
            UserId: userId,
            IsLiked: false
        }

        feedbackUnlikeAjax(model);

    }

    function feedbackUnlikeAjax(model) {
        $.ajax({
            url: ""/feedback/likes"",
            dataType: ""json"",
            data: model,
            type: ""POST"",
            async: false
        }).done(function (obj) {
            var result = obj.data;

            $(""#likes"").html(result.likes);

            if (result.isLiked == true) {
                $(""#likeButton"").hide();
                $(""#unlikeButton"").show();
            }
      ");
            WriteLiteral("      else {\r\n                $(\"#unlikeButton\").hide();\r\n                $(\"#likeButton\").show();\r\n            }\r\n        });\r\n    }\r\n\r\n\r\n\r\n\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarWash.Web.ViewModels.bookings.BookViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
