#pragma checksum "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0153e66f79d885b4937a6e45bf089fb8f0dbbe1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_UserGroups_UserGroupIndex), @"mvc.1.0.view", @"/Areas/Manage/Views/UserGroups/UserGroupIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manage/Views/UserGroups/UserGroupIndex.cshtml", typeof(AspNetCore.Areas_Manage_Views_UserGroups_UserGroupIndex))]
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
#line 1 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
using CarWash.Web.Infrastructures.Domain.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0153e66f79d885b4937a6e45bf089fb8f0dbbe1e", @"/Areas/Manage/Views/UserGroups/UserGroupIndex.cshtml")]
    public class Areas_Manage_Views_UserGroups_UserGroupIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarWash.Web.Areas.Manage.ViewModels.userGroup.GroupIndexViewModel>
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
#line 3 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
  
    Layout = "~/areas/manage/views/shared/_forms.cshtml";

#line default
#line hidden
            BeginContext(191, 100, true);
            WriteLiteral("\r\n<br /><br /><br />\r\n<div class=\"row\">\r\n    <div class=\"lg-5 mt-5 ml-3 mb-3\">\r\n        <h3><strong>");
            EndContext();
            BeginContext(292, 14, false);
#line 10 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
               Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(306, 313, true);
            WriteLiteral(@"</strong> is a member of the groups below.</h3>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-9"">
        <div class=""input-group mb-3"">
            <input type=""text"" id=""searchKeyword"" placeholder=""search groups"" class=""form-control"" aria-label=""search groups"" aria-describedby=""basic-addon2""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 619, "\"", 648, 1);
#line 16 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
WriteAttributeValue("", 627, Model.Groups.Keyword, 627, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(649, 554, true);
            WriteLiteral(@">
            <div class=""input-group-append"">
                <span class=""input-group-text"" id=""basic-addon2""><a href=""#"" onclick=""searchTrigger()""><i class=""fa fa-search fa-lg fa-fw"" aria-hidden=""true""></i></a></span>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div class=""table-responsive table--no-card m-b-30"">
            <a href=""#"" class=""btn btn-lg-3 btn-info btn-block"" onclick=""showAdd()"" id=""add-user-to-group-button"">
                <i class=""fa fa-plus""></i>&nbsp;
                <span>Add ");
            EndContext();
            BeginContext(1204, 14, false);
#line 26 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                     Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1218, 76, true);
            WriteLiteral(" to Group</span>\r\n            </a>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
#line 33 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
 if (Model.Groups.Items.Count > 0)
{

#line default
#line hidden
            BeginContext(1333, 219, true);
            WriteLiteral("    <table class=\"table table-borderless table-striped table-earning\">\r\n        <thead>\r\n            <tr>\r\n                <th>Name</th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 43 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
              

                foreach (Group group in Model.Groups.Items)
                {

#line default
#line hidden
            BeginContext(1650, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1705, 10, false);
#line 48 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                       Write(group.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1715, 37, true);
            WriteLiteral("</td>\r\n                        <td>\r\n");
            EndContext();
#line 50 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                              
                                if (group.Name.ToLower() != "public")
                                {

#line default
#line hidden
            BeginContext(1890, 47, true);
            WriteLiteral("                                    <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1937, "\"", 1978, 4);
            WriteAttributeValue("", 1945, "Remove", 1945, 6, true);
#line 53 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
WriteAttributeValue(" ", 1951, Model.UserName, 1952, 15, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1967, "from", 1968, 5, true);
            WriteAttributeValue(" ", 1972, "Group", 1973, 6, true);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1979, "\"", 2038, 5);
            WriteAttributeValue("", 1989, "confirmRemoveFromGroup(\'", 1989, 24, true);
#line 53 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
WriteAttributeValue("", 2013, group.Id, 2013, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 2022, "\',\'", 2022, 3, true);
#line 53 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
WriteAttributeValue("", 2025, group.Name, 2025, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 2036, "\')", 2036, 2, true);
            EndWriteAttribute();
            BeginContext(2039, 78, true);
            WriteLiteral("><button type=\"button\" class=\"btn\"><i class=\"fas fa-times\"></i></button></a>\r\n");
            EndContext();
#line 54 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(2183, 58, true);
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 58 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                }
            

#line default
#line hidden
            BeginContext(2275, 393, true);
            WriteLiteral(@"        </tbody>
        <tfoot>
            <tr>
                <td colspan=""4"">
                    <nav aria-label=""Page navigation example"">
                        <ul class=""pagination"">
                            <li class=""page-item""><span class=""form-control-plaintext"">Page&nbsp;&nbsp;&nbsp;</span></li>
                            <li class=""page-item""><input type=""number""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2668, "\"", 2699, 1);
#line 67 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
WriteAttributeValue("", 2676, Model.Groups.PageIndex, 2676, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2700, 41, true);
            WriteLiteral(" class=\"form-control\" style=\"width:50px;\"");
            EndContext();
            BeginWriteAttribute("onKeydown", " onKeydown=\"", 2741, "\"", 2993, 18);
            WriteAttributeValue("", 2753, "javascript:", 2753, 11, true);
            WriteAttributeValue(" ", 2764, "if(event.keyCode", 2765, 17, true);
            WriteAttributeValue(" ", 2781, "==", 2782, 3, true);
            WriteAttributeValue(" ", 2784, "13", 2785, 3, true);
            WriteAttributeValue(" ", 2787, "&&", 2788, 3, true);
            WriteAttributeValue(" ", 2790, "isNaN(parseInt($(this).val()))==false)", 2791, 39, true);
            WriteAttributeValue(" ", 2829, "window.location=\'/manage/user-groups/", 2830, 38, true);
#line 67 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
WriteAttributeValue("", 2867, Model.UserId, 2867, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 2880, "?pageIndex=\'", 2880, 12, true);
            WriteAttributeValue(" ", 2892, "+", 2893, 2, true);
            WriteAttributeValue(" ", 2894, "(isNaN(parseInt($(this).val()))", 2895, 32, true);
            WriteAttributeValue(" ", 2926, "?", 2927, 2, true);
            WriteAttributeValue(" ", 2928, "1", 2929, 2, true);
            WriteAttributeValue(" ", 2930, ":", 2931, 2, true);
            WriteAttributeValue(" ", 2932, "parseInt($(this).val()))", 2933, 25, true);
            WriteAttributeValue(" ", 2957, "+", 2958, 2, true);
            WriteAttributeValue(" ", 2959, "\'&keyword=", 2960, 11, true);
#line 67 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
WriteAttributeValue("", 2970, Model.Groups.Keyword, 2970, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2994, 118, true);
            WriteLiteral(" /></li>\r\n                            <li class=\"page-item\"><span class=\"form-control-plaintext\">&nbsp;&nbsp;&nbsp;of ");
            EndContext();
            BeginContext(3113, 22, false);
#line 68 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                                                                                                       Write(Model.Groups.PageCount);

#line default
#line hidden
            EndContext();
            BeginContext(3135, 32, true);
            WriteLiteral("&nbsp;&nbsp;&nbsp;</span></li>\r\n");
            EndContext();
#line 69 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                              
                                var prev = Model.Groups.PageIndex - 1;
                                if (prev > 0)
                                {

#line default
#line hidden
            BeginContext(3353, 58, true);
            WriteLiteral("                                    <li class=\"page-item\">");
            EndContext();
            BeginContext(3411, 184, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a80c95789d3462ca4da36a7c177cb51", async() => {
                BeginContext(3552, 39, true);
                WriteLiteral("<span aria-hidden=\"true\">&laquo;</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3438, "~/manage/user-groups/", 3438, 21, true);
#line 73 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
AddHtmlAttributeValue("", 3459, Model.UserId, 3459, 13, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 3472, "?keyword=", 3472, 9, true);
#line 73 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
AddHtmlAttributeValue("", 3481, Model.Groups.Keyword, 3481, 21, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 3502, "&pageSize=", 3502, 10, true);
#line 73 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
AddHtmlAttributeValue("", 3512, Model.Groups.PageSize, 3512, 22, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 3534, "&pageIndex=", 3534, 11, true);
#line 73 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
AddHtmlAttributeValue("", 3545, prev, 3545, 5, false);

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
            BeginContext(3595, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 74 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(3668, 80, true);
            WriteLiteral("                            <li class=\"page-item\"><a class=\"page-link\" href=\"#\">");
            EndContext();
            BeginContext(3750, 22, false);
#line 76 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                                                                            Write(Model.Groups.PageIndex);

#line default
#line hidden
            EndContext();
            BeginContext(3773, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 77 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                              
                                var next = Model.Groups.PageIndex + 1;
                                if (next <= Model.Groups.PageCount)
                                {

#line default
#line hidden
            BeginContext(3992, 58, true);
            WriteLiteral("                                    <li class=\"page-item\">");
            EndContext();
            BeginContext(4050, 184, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "637310719b32425e962c19a259bb00af", async() => {
                BeginContext(4191, 39, true);
                WriteLiteral("<span aria-hidden=\"true\">&raquo;</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4077, "~/manage/user-groups/", 4077, 21, true);
#line 81 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
AddHtmlAttributeValue("", 4098, Model.UserId, 4098, 13, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 4111, "?keyword=", 4111, 9, true);
#line 81 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
AddHtmlAttributeValue("", 4120, Model.Groups.Keyword, 4120, 21, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 4141, "&pageSize=", 4141, 10, true);
#line 81 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
AddHtmlAttributeValue("", 4151, Model.Groups.PageSize, 4151, 22, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 4173, "&pageIndex=", 4173, 11, true);
#line 81 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
AddHtmlAttributeValue("", 4184, next, 4184, 5, false);

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
            BeginContext(4234, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 82 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(4307, 133, true);
            WriteLiteral("                        </ul>\r\n                    </nav>\r\n                </td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n");
            EndContext();
#line 90 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(4452, 30, true);
            WriteLiteral("    <p>0 search results.</p>\r\n");
            EndContext();
#line 94 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
}

#line default
#line hidden
            BeginContext(4485, 237, true);
            WriteLiteral("\r\n\r\n<div class=\"modal\" tabindex=\"-1\" role=\"dialog\" id=\"modal-add\">\r\n    <div class=\"modal-dialog\" role=\"document\">\r\n        <div class=\"modal-content\">\r\n            <div class=\"modal-header\">\r\n                <h5 class=\"modal-title\">Add ");
            EndContext();
            BeginContext(4723, 14, false);
#line 101 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                                       Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(4737, 230, true);
            WriteLiteral(" to Group</h5>\r\n                <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                    <span aria-hidden=\"true\">&times;</span>\r\n                </button>\r\n            </div>\r\n            ");
            EndContext();
            BeginContext(4967, 666, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f26d2a34bf4d418b89eea5c79fc5e5fe", async() => {
                BeginContext(5035, 84, true);
                WriteLiteral("\r\n                <div class=\"modal-body\">\r\n                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 5119, "\"", 5140, 1);
#line 108 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
WriteAttributeValue("", 5127, Model.UserId, 5127, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5141, 59, true);
                WriteLiteral(" name=\"UserId\" />\r\n                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 5200, "\"", 5233, 2);
                WriteAttributeValue("", 5208, "user-groups/", 5208, 12, true);
#line 109 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
WriteAttributeValue("", 5220, Model.UserId, 5220, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5234, 392, true);
                WriteLiteral(@" name=""Redirect"" />
                    <select id=""modal-add-select-group"" name=""GroupId""></select>
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
            BeginContext(5633, 290, true);
            WriteLiteral(@"
        </div>
    </div>
</div>

<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-remove-from-group"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Remove ");
            EndContext();
            BeginContext(5924, 14, false);
#line 125 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                                          Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(5938, 288, true);
            WriteLiteral(@" from Group <span class=""modal-remove-from-group-groupName""></span></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            EndContext();
            BeginContext(6226, 841, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47aa2b59163e41d4a4cdac9811885741", async() => {
                BeginContext(6299, 98, true);
                WriteLiteral("\r\n                <div class=\"modal-body\">\r\n                    <input type=\"hidden\" name=\"UserId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 6397, "\"", 6418, 1);
#line 132 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
WriteAttributeValue("", 6405, Model.UserId, 6405, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6419, 151, true);
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"GroupId\" value=\"\" id=\"modal-remove-from-group-groupId\" />\r\n                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 6570, "\"", 6603, 2);
                WriteAttributeValue("", 6578, "user-groups/", 6578, 12, true);
#line 134 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
WriteAttributeValue("", 6590, Model.UserId, 6590, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6604, 76, true);
                WriteLiteral(" name=\"Redirect\" />\r\n                    <p>Are you sure you want to remove ");
                EndContext();
                BeginContext(6681, 14, false);
#line 135 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                                                  Write(Model.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(6695, 365, true);
                WriteLiteral(@" from Group <span class=""modal-remove-from-group-groupName""></span>?</p>
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
            BeginContext(7067, 984, true);
            WriteLiteral(@"
        </div>
    </div>
</div>


<script type=""text/javascript"">
        $(function () {
            initSelect();
        });

        function destroySelect() {
            try {
                var selectAddGroup, $selectAddGroup;
                $selectAddGroup = $('#modal-add-select-group').selectize();
                selectAddGroup = $selectAddGroup[0];
                selectAddGroup.selectize.destroy();
            }
            catch (err) {
                console.log(err);
            }
        }

        function initSelect() {
            destroySelect();
            var selectAddGroup, $selectAddGroup;

            $selectAddGroup = $('#modal-add-select-group').selectize({
                maxItems: 1,
                preload: true,
                load: function (query, callback) {
                    $.ajax({
                        url: '/groups/add-user-to-group-look-up?keyword=' + encodeURIComponent(query) + ""&userId=");
            EndContext();
            BeginContext(8052, 12, false);
#line 173 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                                                                                                            Write(Model.UserId);

#line default
#line hidden
            EndContext();
            BeginContext(8064, 1157, true);
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

            selectAddGroup = $selectAddGroup.selectize;
        }

        function showAdd() {
            $(""#modal-add"").modal(""show"");
        }


        function confirmRemoveFromGroup(groupId, groupName) {
            $("".modal-remove-from-group-groupName"").html(groupName);
            $(""#modal-remove-from-group-groupId"").val(groupId);
            $(""#modal-remove-from-group"").modal(""show"");
        }

        $(""#searchKeyword"").keyup(function (event) {
            if (event.keyCode === 13) {
                se");
            WriteLiteral("archTrigger();\r\n            }\r\n        });\r\n\r\n        function searchTrigger() {\r\n            window.location = \"/manage/user-groups/");
            EndContext();
            BeginContext(9222, 12, false);
#line 208 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                                              Write(Model.UserId);

#line default
#line hidden
            EndContext();
            BeginContext(9234, 75, true);
            WriteLiteral("?pageIndex=1&keyword=\" + $(\"#searchKeyword\").val();\r\n        }\r\n</script>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarWash.Web.Areas.Manage.ViewModels.userGroup.GroupIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
