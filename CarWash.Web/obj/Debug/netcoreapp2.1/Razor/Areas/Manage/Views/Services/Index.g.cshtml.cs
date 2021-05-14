#pragma checksum "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cde2ac0f121a04aca585dad1c98b32ac84949ff9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Services_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Services/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manage/Views/Services/Index.cshtml", typeof(AspNetCore.Areas_Manage_Views_Services_Index))]
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
#line 2 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
using CarWash.Web.Infrastructures.Domain.Enums;

#line default
#line hidden
#line 3 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
using CarWash.Web.Infrastructures.Domain.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cde2ac0f121a04aca585dad1c98b32ac84949ff9", @"/Areas/Manage/Views/Services/Index.cshtml")]
    public class Areas_Manage_Views_Services_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarWash.Web.Areas.Manage.ViewModels.services.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/service/create-services/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg-3 btn-success btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Service Details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
  
    Layout = "~/areas/manage/views/shared/_forms.cshtml";

#line default
#line hidden
            BeginContext(233, 514, true);
            WriteLiteral(@"

<br /><br /><br />
<br />
<h1 class=""text-center"">List of services</h1>
<hr />
<br /><br />
<div class=""row"">
    <div class=""col-lg-5"">
        <div class=""input-group mt-5"">
            <div class=""input-group-prepend"">
                <span class=""input-group-text"" id=""inputGroup-sizing-sm"">Services</span>
            </div>
            <select class=""form-control"" aria-label=""Small"" aria-describedby=""inputGroup-sizing-sm"" id=""searchStatus"" onchange=""searchTrigger()"" placeholder=""Service"">
");
            EndContext();
#line 21 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
                  
                    foreach (ServiceType service in Model.Serviceses)
                    {
                        if (Model.ServiceT == service)
                        {

#line default
#line hidden
            BeginContext(944, 35, true);
            WriteLiteral("                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 979, "\"", 995, 1);
#line 26 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
WriteAttributeValue("", 987, service, 987, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(996, 10, true);
            WriteLiteral(" selected>");
            EndContext();
            BeginContext(1007, 18, false);
#line 26 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
                                                         Write(service.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1025, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 27 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1120, 35, true);
            WriteLiteral("                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1155, "\"", 1171, 1);
#line 30 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
WriteAttributeValue("", 1163, service, 1163, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1172, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1174, 18, false);
#line 30 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
                                                Write(service.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1192, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 31 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
                        }
                    }
                

#line default
#line hidden
            BeginContext(1272, 283, true);
            WriteLiteral(@"            </select>
        </div>
    </div>

    <div class=""col-lg-3 "">
        <div class=""input-group mt-5"">
            <input type=""text"" id=""searchKeyword"" placeholder=""search services"" class=""form-control"" aria-label=""search services"" aria-describedby=""basic-addon2""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1555, "\"", 1586, 1);
#line 40 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
WriteAttributeValue("", 1563, Model.Services.Keyword, 1563, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1587, 372, true);
            WriteLiteral(@">
            <div class=""input-group-append"">
                <span class=""input-group-text"" id=""basic-addon2""><a href=""#"" onclick=""searchTrigger()""><i class=""fa fa-search"" aria-hidden=""true""></i></a></span>
            </div>
        </div>
    </div>

    <div class=""col-lg-3"">
        <div class=""table-responsive table--no-card m-b-30 mt-md-5"">
            ");
            EndContext();
            BeginContext(1959, 201, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a23d85675be647dc840102b334d2487a", async() => {
                BeginContext(2046, 110, true);
                WriteLiteral("\r\n                <i class=\"fa fa-plus\"></i>&nbsp;\r\n                <span>Create Services</span>\r\n            ");
                EndContext();
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
            EndContext();
            BeginContext(2160, 50, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<hr />\r\n\r\n\r\n");
            EndContext();
#line 59 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
 if (Model.Services.Items.Count > 0)
{

#line default
#line hidden
            BeginContext(2251, 310, true);
            WriteLiteral(@"    <table class=""table table-borderless table-striped table-hover"">
        <thead>
            <tr class=""table-info"">
                <th>Vehicle</th>
                <th>Service Type</th>
                <th>Price</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 71 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
              
                foreach (Service service in Model.Services.Items)
                {

#line default
#line hidden
            BeginContext(2663, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(2718, 15, false);
#line 75 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
                       Write(service.Vehicle);

#line default
#line hidden
            EndContext();
            BeginContext(2733, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2769, 19, false);
#line 76 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
                       Write(service.ServiceType);

#line default
#line hidden
            EndContext();
            BeginContext(2788, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2853, 145, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bbd95bbe7de4fce835c1c63f3ebb1ab", async() => {
                BeginContext(2924, 70, true);
                WriteLiteral("<button type=\"button\" class=\"btn\"><i class=\"fas fa-info\"></i></button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2862, "~/manage/service/details/", 2862, 25, true);
#line 78 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
AddHtmlAttributeValue("", 2887, service.Id, 2887, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2998, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3028, 148, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "629bbfd5b15f44fdad537963a8096487", async() => {
                BeginContext(3102, 70, true);
                WriteLiteral("<button type=\"button\" class=\"btn\"><i class=\"fa fa-image\"></i></button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3037, "~/manage/service/update-thumbnail/", 3037, 34, true);
#line 79 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
AddHtmlAttributeValue("", 3071, service.Id, 3071, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3176, 41, true);
            WriteLiteral("\r\n                            <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3217, "\"", 3282, 6);
            WriteAttributeValue("", 3227, "confirmDeleteService(\'", 3227, 22, true);
#line 80 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
WriteAttributeValue("", 3249, service.Id, 3249, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 3260, "\',", 3260, 2, true);
            WriteAttributeValue(" ", 3262, "\'", 3263, 2, true);
#line 80 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
WriteAttributeValue("", 3264, service.Vehicle, 3264, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 3280, "\')", 3280, 2, true);
            EndWriteAttribute();
            BeginContext(3283, 159, true);
            WriteLiteral(" title=\"Delete Service\"><button type=\"button\" class=\"btn\"><i class=\"fas fa-times\"></i></button></a>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 83 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
                }
            

#line default
#line hidden
            BeginContext(3476, 393, true);
            WriteLiteral(@"        </tbody>
        <tfoot>
            <tr>
                <td colspan=""4"">
                    <nav aria-label=""Page navigation example"">
                        <ul class=""pagination"">
                            <li class=""page-item""><span class=""form-control-plaintext"">Page&nbsp;&nbsp;&nbsp;</span></li>
                            <li class=""page-item""><input type=""number""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3869, "\"", 3902, 1);
#line 92 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
WriteAttributeValue("", 3877, Model.Services.PageIndex, 3877, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3903, 41, true);
            WriteLiteral(" class=\"form-control\" style=\"width:50px;\"");
            EndContext();
            BeginWriteAttribute("onKeydown", " onKeydown=\"", 3944, "\"", 4212, 18);
            WriteAttributeValue("", 3956, "javascript:", 3956, 11, true);
            WriteAttributeValue(" ", 3967, "if(event.keyCode", 3968, 17, true);
            WriteAttributeValue(" ", 3984, "==", 3985, 3, true);
            WriteAttributeValue(" ", 3987, "13", 3988, 3, true);
            WriteAttributeValue(" ", 3990, "&&", 3991, 3, true);
            WriteAttributeValue(" ", 3993, "isNaN(parseInt($(this).val()))==false)", 3994, 39, true);
            WriteAttributeValue(" ", 4032, "window.location=\'/manage/service/index?pageIndex=\'", 4033, 51, true);
            WriteAttributeValue(" ", 4083, "+", 4084, 2, true);
            WriteAttributeValue(" ", 4085, "(isNaN(parseInt($(this).val()))", 4086, 32, true);
            WriteAttributeValue(" ", 4117, "?", 4118, 2, true);
            WriteAttributeValue(" ", 4119, "1", 4120, 2, true);
            WriteAttributeValue(" ", 4121, ":", 4122, 2, true);
            WriteAttributeValue(" ", 4123, "parseInt($(this).val()))", 4124, 25, true);
            WriteAttributeValue(" ", 4148, "+", 4149, 2, true);
            WriteAttributeValue(" ", 4150, "\'&keyword=", 4151, 11, true);
#line 92 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
WriteAttributeValue("", 4161, Model.Services.Keyword, 4161, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 4186, "&service=", 4186, 9, true);
#line 92 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
WriteAttributeValue("", 4195, Model.ServiceT, 4195, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4213, 118, true);
            WriteLiteral(" /></li>\r\n                            <li class=\"page-item\"><span class=\"form-control-plaintext\">&nbsp;&nbsp;&nbsp;of ");
            EndContext();
            BeginContext(4332, 24, false);
#line 93 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
                                                                                                       Write(Model.Services.PageCount);

#line default
#line hidden
            EndContext();
            BeginContext(4356, 32, true);
            WriteLiteral("&nbsp;&nbsp;&nbsp;</span></li>\r\n");
            EndContext();
#line 94 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
                              
                                var prev = Model.Services.PageIndex - 1;
                                if (prev > 0)
                                {

#line default
#line hidden
            BeginContext(4576, 58, true);
            WriteLiteral("                                    <li class=\"page-item\">");
            EndContext();
            BeginContext(4634, 194, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7078df93464644919aed49db8ff210a0", async() => {
                BeginContext(4785, 39, true);
                WriteLiteral("<span aria-hidden=\"true\">&laquo;</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4661, "~/manage/service?keyword=", 4661, 25, true);
#line 98 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
AddHtmlAttributeValue("", 4686, Model.Services.Keyword, 4686, 23, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 4709, "&service=", 4709, 9, true);
#line 98 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
AddHtmlAttributeValue("", 4718, Model.ServiceT, 4718, 15, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 4733, "&pageSize=", 4733, 10, true);
#line 98 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
AddHtmlAttributeValue("", 4743, Model.Services.PageSize, 4743, 24, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 4767, "&pageIndex=", 4767, 11, true);
#line 98 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
AddHtmlAttributeValue("", 4778, prev, 4778, 5, false);

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
            BeginContext(4828, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 99 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(4901, 80, true);
            WriteLiteral("                            <li class=\"page-item\"><a class=\"page-link\" href=\"#\">");
            EndContext();
            BeginContext(4983, 24, false);
#line 101 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
                                                                            Write(Model.Services.PageIndex);

#line default
#line hidden
            EndContext();
            BeginContext(5008, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 102 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
                              
                                var next = Model.Services.PageIndex + 1;
                                if (next <= Model.Services.PageCount)
                                {

#line default
#line hidden
            BeginContext(5231, 58, true);
            WriteLiteral("                                    <li class=\"page-item\">");
            EndContext();
            BeginContext(5289, 194, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e078fdfd0e142629dc0721fd93266cc", async() => {
                BeginContext(5440, 39, true);
                WriteLiteral("<span aria-hidden=\"true\">&raquo;</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5316, "~/manage/service?keyword=", 5316, 25, true);
#line 106 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
AddHtmlAttributeValue("", 5341, Model.Services.Keyword, 5341, 23, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 5364, "&service=", 5364, 9, true);
#line 106 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
AddHtmlAttributeValue("", 5373, Model.ServiceT, 5373, 15, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 5388, "&pageSize=", 5388, 10, true);
#line 106 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
AddHtmlAttributeValue("", 5398, Model.Services.PageSize, 5398, 24, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 5422, "&pageIndex=", 5422, 11, true);
#line 106 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
AddHtmlAttributeValue("", 5433, next, 5433, 5, false);

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
            BeginContext(5483, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 107 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(5556, 133, true);
            WriteLiteral("                        </ul>\r\n                    </nav>\r\n                </td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n");
            EndContext();
#line 115 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(5701, 30, true);
            WriteLiteral("    <p>0 search results.</p>\r\n");
            EndContext();
#line 119 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Index.cshtml"
}

#line default
#line hidden
            BeginContext(5734, 1611, true);
            WriteLiteral(@"

<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-delete-service"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Delete Service</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to delete <span id=""modal-delete-service-vehicle""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <a href=""#"" id=""modal-delete-service-confirm""><button type=""button"" class=""btn btn-primary"">Delete Service</button></a>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>



<script type=""text/javascript"">



    function co");
            WriteLiteral(@"nfirmDeleteService(serviceId, Vehicle) {
        $(""#modal-delete-service-vehicle"").html(Vehicle);
        $(""#modal-delete-service-confirm"").attr(""href"", ""/manage/service/delete/"" + serviceId);
        $(""#modal-delete-service"").modal(""show"");
    }

    $(""#searchKeyword"").keyup(function (event) {
        if (event.keyCode === 13) {
            searchTrigger();
        }
    });

    function searchTrigger() {
        window.location = ""/manage/service?pageIndex=1&keyword="" + $(""#searchKeyword"").val() + ""&service="" + $(""#searchStatus"").val();
    }


</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarWash.Web.Areas.Manage.ViewModels.services.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
