#pragma checksum "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6fe1e5a71c88e09920b7f940f01abbd1da7210b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_UserGroups_GroupUserIndex), @"mvc.1.0.view", @"/Areas/Manage/Views/UserGroups/GroupUserIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manage/Views/UserGroups/GroupUserIndex.cshtml", typeof(AspNetCore.Areas_Manage_Views_UserGroups_GroupUserIndex))]
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
#line 1 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
using CarWash.Web.Infrastructures.Domain.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6fe1e5a71c88e09920b7f940f01abbd1da7210b", @"/Areas/Manage/Views/UserGroups/GroupUserIndex.cshtml")]
    public class Areas_Manage_Views_UserGroups_GroupUserIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarWash.Web.Areas.Manage.ViewModels.userGroup.UsersIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/user-groups/add-user-to-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/user-groups/remove-user-from-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
  
    Layout = "~/areas/manage/views/shared/_forms.cshtml";

#line default
#line hidden
            BeginContext(191, 22, true);
            WriteLiteral("\r\n<br /><br /><br />\r\n");
            EndContext();
            DefineSection("tableHead", async() => {
                BeginContext(232, 62, true);
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <h3>Group Members of <strong>");
                EndContext();
                BeginContext(295, 15, false);
#line 10 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
                                Write(Model.GroupName);

#line default
#line hidden
                EndContext();
                BeginContext(310, 288, true);
                WriteLiteral(@"</strong></h3>
    </div>
    <div class=""row"">
        <div class=""col-lg-8"">
            <div class=""input-group mb-3"">
                <input type=""text"" id=""searchKeyword"" placeholder=""search member"" class=""form-control"" aria-label=""search groups"" aria-describedby=""basic-addon2""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 598, "\"", 626, 1);
#line 15 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
WriteAttributeValue("", 606, Model.Users.Keyword, 606, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(627, 608, true);
                WriteLiteral(@">
                <div class=""input-group-append"">
                    <span class=""input-group-text"" id=""basic-addon2""><a href=""#"" onclick=""searchTrigger()""><i class=""fa fa-search fa-lg fa-fw"" aria-hidden=""true""></i></a></span>
                </div>
            </div>
        </div>
        <div class=""col-lg-4"">
            <div class=""table-responsive table--no-card m-b-30"">
                <a href=""#"" class=""btn btn-lg btn-info btn-block"" onclick=""showAdd()"" id=""add-user-to-group-button"">
                    <i class=""fa fa-plus""></i>&nbsp;
                    <span>Add a user to group ");
                EndContext();
                BeginContext(1236, 15, false);
#line 25 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
                                         Write(Model.GroupName);

#line default
#line hidden
                EndContext();
                BeginContext(1251, 97, true);
                WriteLiteral("&nbsp;&nbsp;&nbsp;</span>\r\n                </a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(1351, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 32 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
 if (Model.Users.Items.Count > 0)
{

#line default
#line hidden
            BeginContext(1391, 259, true);
            WriteLiteral(@"    <table class=""table table-borderless table-striped table-earning"">
        <thead>
            <tr>
                <th>Name</th>
                <th>Email Address</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 43 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
              
                foreach (User user in Model.Users.Items)
                {

#line default
#line hidden
            BeginContext(1743, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1798, 13, false);
#line 47 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
                       Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1811, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1847, 17, false);
#line 48 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
                       Write(user.EmailAddress);

#line default
#line hidden
            EndContext();
            BeginContext(1864, 37, true);
            WriteLiteral("</td>\r\n                        <td>\r\n");
            EndContext();
#line 50 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
                              
                                if (Model.GroupName.ToLower() != "public")
                                {

#line default
#line hidden
            BeginContext(2044, 47, true);
            WriteLiteral("                                    <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 2091, "\"", 2148, 5);
            WriteAttributeValue("", 2099, "Remove", 2099, 6, true);
#line 53 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
WriteAttributeValue(" ", 2105, user.UserName, 2106, 14, false);

#line default
#line hidden
            WriteAttributeValue(" ", 2120, "from", 2121, 5, true);
            WriteAttributeValue(" ", 2125, "Group", 2126, 6, true);
#line 53 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
WriteAttributeValue(" ", 2131, Model.GroupName, 2132, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2149, "\"", 2210, 5);
            WriteAttributeValue("", 2159, "confirmRemoveFromGroup(\'", 2159, 24, true);
#line 53 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
WriteAttributeValue("", 2183, user.Id, 2183, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2191, "\',\'", 2191, 3, true);
#line 53 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
WriteAttributeValue("", 2194, user.UserName, 2194, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 2208, "\')", 2208, 2, true);
            EndWriteAttribute();
            BeginContext(2211, 78, true);
            WriteLiteral("><button type=\"button\" class=\"btn\"><i class=\"fas fa-times\"></i></button></a>\r\n");
            EndContext();
#line 54 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(2355, 58, true);
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 58 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
                }
            

#line default
#line hidden
            BeginContext(2447, 393, true);
            WriteLiteral(@"        </tbody>
        <tfoot>
            <tr>
                <td colspan=""4"">
                    <nav aria-label=""Page navigation example"">
                        <ul class=""pagination"">
                            <li class=""page-item""><span class=""form-control-plaintext"">Page&nbsp;&nbsp;&nbsp;</span></li>
                            <li class=""page-item""><input type=""number""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2840, "\"", 2870, 1);
#line 67 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
WriteAttributeValue("", 2848, Model.Users.PageIndex, 2848, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2871, 41, true);
            WriteLiteral(" class=\"form-control\" style=\"width:50px;\"");
            EndContext();
            BeginWriteAttribute("onKeydown", " onKeydown=\"", 2912, "\"", 3164, 18);
            WriteAttributeValue("", 2924, "javascript:", 2924, 11, true);
            WriteAttributeValue(" ", 2935, "if(event.keyCode", 2936, 17, true);
            WriteAttributeValue(" ", 2952, "==", 2953, 3, true);
            WriteAttributeValue(" ", 2955, "13", 2956, 3, true);
            WriteAttributeValue(" ", 2958, "&&", 2959, 3, true);
            WriteAttributeValue(" ", 2961, "isNaN(parseInt($(this).val()))==false)", 2962, 39, true);
            WriteAttributeValue(" ", 3000, "window.location=\'/manage/group-users/", 3001, 38, true);
#line 67 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
WriteAttributeValue("", 3038, Model.GroupId, 3038, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 3052, "?pageIndex=\'", 3052, 12, true);
            WriteAttributeValue(" ", 3064, "+", 3065, 2, true);
            WriteAttributeValue(" ", 3066, "(isNaN(parseInt($(this).val()))", 3067, 32, true);
            WriteAttributeValue(" ", 3098, "?", 3099, 2, true);
            WriteAttributeValue(" ", 3100, "1", 3101, 2, true);
            WriteAttributeValue(" ", 3102, ":", 3103, 2, true);
            WriteAttributeValue(" ", 3104, "parseInt($(this).val()))", 3105, 25, true);
            WriteAttributeValue(" ", 3129, "+", 3130, 2, true);
            WriteAttributeValue(" ", 3131, "\'&keyword=", 3132, 11, true);
#line 67 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
WriteAttributeValue("", 3142, Model.Users.Keyword, 3142, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3165, 118, true);
            WriteLiteral(" /></li>\r\n                            <li class=\"page-item\"><span class=\"form-control-plaintext\">&nbsp;&nbsp;&nbsp;of ");
            EndContext();
            BeginContext(3284, 21, false);
#line 68 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
                                                                                                       Write(Model.Users.PageCount);

#line default
#line hidden
            EndContext();
            BeginContext(3305, 32, true);
            WriteLiteral("&nbsp;&nbsp;&nbsp;</span></li>\r\n");
            EndContext();
#line 69 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
                              
                                var prev = Model.Users.PageIndex - 1;
                                if (prev > 0)
                                {

#line default
#line hidden
            BeginContext(3522, 58, true);
            WriteLiteral("                                    <li class=\"page-item\">");
            EndContext();
            BeginContext(3580, 183, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd99410abdbb4113a378bcccd06d00b7", async() => {
                BeginContext(3720, 39, true);
                WriteLiteral("<span aria-hidden=\"true\">&laquo;</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3607, "~/manage/group-users/", 3607, 21, true);
#line 73 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
AddHtmlAttributeValue("", 3628, Model.GroupId, 3628, 14, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 3642, "?keyword=", 3642, 9, true);
#line 73 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
AddHtmlAttributeValue("", 3651, Model.Users.Keyword, 3651, 20, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 3671, "&pageSize=", 3671, 10, true);
#line 73 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
AddHtmlAttributeValue("", 3681, Model.Users.PageSize, 3681, 21, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 3702, "&pageIndex=", 3702, 11, true);
#line 73 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
AddHtmlAttributeValue("", 3713, prev, 3713, 5, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3763, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 74 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(3836, 80, true);
            WriteLiteral("                            <li class=\"page-item\"><a class=\"page-link\" href=\"#\">");
            EndContext();
            BeginContext(3918, 21, false);
#line 76 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
                                                                            Write(Model.Users.PageIndex);

#line default
#line hidden
            EndContext();
            BeginContext(3940, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 77 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
                              
                                var next = Model.Users.PageIndex + 1;
                                if (next <= Model.Users.PageCount)
                                {

#line default
#line hidden
            BeginContext(4157, 58, true);
            WriteLiteral("                                    <li class=\"page-item\">");
            EndContext();
            BeginContext(4215, 183, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2346ff50885043878dfea8273950d72a", async() => {
                BeginContext(4355, 39, true);
                WriteLiteral("<span aria-hidden=\"true\">&raquo;</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4242, "~/manage/group-users/", 4242, 21, true);
#line 81 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
AddHtmlAttributeValue("", 4263, Model.GroupId, 4263, 14, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 4277, "?keyword=", 4277, 9, true);
#line 81 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
AddHtmlAttributeValue("", 4286, Model.Users.Keyword, 4286, 20, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 4306, "&pageSize=", 4306, 10, true);
#line 81 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
AddHtmlAttributeValue("", 4316, Model.Users.PageSize, 4316, 21, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 4337, "&pageIndex=", 4337, 11, true);
#line 81 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
AddHtmlAttributeValue("", 4348, next, 4348, 5, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4398, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 82 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(4471, 133, true);
            WriteLiteral("                        </ul>\r\n                    </nav>\r\n                </td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n");
            EndContext();
#line 90 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(4616, 30, true);
            WriteLiteral("    <p>0 search results.</p>\r\n");
            EndContext();
#line 94 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
}

#line default
#line hidden
            BeginContext(4649, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("extras", async() => {
                BeginContext(4667, 269, true);
                WriteLiteral(@"
    <div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-add"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Add user to Group ");
                EndContext();
                BeginContext(4937, 15, false);
#line 101 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
                                                         Write(Model.GroupName);

#line default
#line hidden
                EndContext();
                BeginContext(4952, 241, true);
                WriteLiteral("</h5>\r\n                    <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                </div>\r\n                ");
                EndContext();
                BeginContext(5193, 707, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b9d25498bd24ac89676430dfa6b5d7e", async() => {
                    BeginContext(5261, 92, true);
                    WriteLiteral("\r\n                    <div class=\"modal-body\">\r\n                        <input type=\"hidden\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 5353, "\"", 5375, 1);
#line 108 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
WriteAttributeValue("", 5361, Model.GroupId, 5361, 14, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(5376, 64, true);
                    WriteLiteral(" name=\"GroupId\" />\r\n                        <input type=\"hidden\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 5440, "\"", 5474, 2);
                    WriteAttributeValue("", 5448, "group-users/", 5448, 12, true);
#line 109 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
WriteAttributeValue("", 5460, Model.GroupId, 5460, 14, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(5475, 418, true);
                    WriteLiteral(@" name=""Redirect"" />
                        <select id=""modal-add-select-user"" name=""UserId""></select>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""submit"" class=""btn btn-success"">Add</button>
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    </div>
                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5900, 389, true);
                WriteLiteral(@"
            </div>
        </div>
    </div>

    <div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-remove-from-group"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Remove <span class=""modal-remove-from-group-groupName""></span> from Group ");
                EndContext();
                BeginContext(6290, 15, false);
#line 125 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
                                                                                                                 Write(Model.GroupName);

#line default
#line hidden
                EndContext();
                BeginContext(6305, 241, true);
                WriteLiteral("</h5>\r\n                    <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                </div>\r\n                ");
                EndContext();
                BeginContext(6546, 878, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6384d3fd6322479f923d04b91be298d8", async() => {
                    BeginContext(6619, 206, true);
                    WriteLiteral("\r\n                    <div class=\"modal-body\">\r\n                        <input type=\"hidden\" name=\"UserId\" id=\"modal-remove-from-group-userId\" />\r\n                        <input type=\"hidden\" name=\"GroupId\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 6825, "\"", 6847, 1);
#line 133 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
WriteAttributeValue("", 6833, Model.GroupId, 6833, 14, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(6848, 49, true);
                    WriteLiteral(" />\r\n                        <input type=\"hidden\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 6897, "\"", 6931, 2);
                    WriteAttributeValue("", 6905, "group-users/", 6905, 12, true);
#line 134 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
WriteAttributeValue("", 6917, Model.GroupId, 6917, 14, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(6932, 147, true);
                    WriteLiteral(" name=\"Redirect\" />\r\n                        <p>Are you sure you want to remove <span class=\"modal-remove-from-group-groupName\"></span> from Group ");
                    EndContext();
                    BeginContext(7080, 15, false);
#line 135 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
                                                                                                                         Write(Model.GroupName);

#line default
#line hidden
                    EndContext();
                    BeginContext(7095, 322, true);
                    WriteLiteral(@"?</p>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""submit"" class=""btn btn-danger"">Remove</button>
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    </div>
                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7424, 50, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(7477, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("pageScripts", async() => {
                BeginContext(7500, 937, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(function () {
            initSelect();
        });

        function destroySelect() {
            try {
                var selectAddUser, $selectAddUser;
                $selectAddUser = $('#modal-add-select-user').selectize();
                selectAddUser = $selectAddUser[0];
                selectAddUser.selectize.destroy();
            }
            catch (err) {
                console.log(err);
            }
        }

        function initSelect() {
            destroySelect();
            var selectAddUser, $selectAddUser;

            $selectAddUser = $('#modal-add-select-user').selectize({
                maxItems: 1,
                preload: true,
                load: function (query, callback) {
                    $.ajax({
                        url: '/users/add-user-to-group-look-up?keyword=' + encodeURIComponent(query) + ""&groupId=");
                EndContext();
                BeginContext(8438, 13, false);
#line 174 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
                                                                                                            Write(Model.GroupId);

#line default
#line hidden
                EndContext();
                BeginContext(8451, 1147, true);
                WriteLiteral(@""",
                        success: function (response) {
                            if (response.length < 1) {
                                $(""#add-user-to-group-button"").hide();
                            } else {
                                $(""#add-user-to-group-button"").show();
                            }
                            callback(response.slice(0, 10));
                        }
                    });
                }
            });

            selectAddUser = $selectAddUser.selectize;
        }

        function showAdd() {
            $(""#modal-add"").modal(""show"");
        }


        function confirmRemoveFromGroup(userId, userName) {
            $("".modal-remove-from-group-userName"").html(userName);
            $(""#modal-remove-from-group-userId"").val(userId);
            $(""#modal-remove-from-group"").modal(""show"");
        }

        $(""#searchKeyword"").keyup(function (event) {
            if (event.keyCode === 13) {
                searchTrigge");
                WriteLiteral("r();\r\n            }\r\n        });\r\n\r\n        function searchTrigger() {\r\n            window.location = \"/manage/group-users/");
                EndContext();
                BeginContext(9599, 13, false);
#line 208 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\GroupUserIndex.cshtml"
                                              Write(Model.GroupId);

#line default
#line hidden
                EndContext();
                BeginContext(9612, 79, true);
                WriteLiteral("?pageIndex=1&keyword=\" + $(\"#searchKeyword\").val();\r\n        }\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarWash.Web.Areas.Manage.ViewModels.userGroup.UsersIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
