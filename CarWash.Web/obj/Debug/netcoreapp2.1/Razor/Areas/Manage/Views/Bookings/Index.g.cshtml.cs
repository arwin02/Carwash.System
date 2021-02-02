#pragma checksum "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "427957ef3f9b45c57c1b1571840e61a80c19fb20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Bookings_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Bookings/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manage/Views/Bookings/Index.cshtml", typeof(AspNetCore.Areas_Manage_Views_Bookings_Index))]
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
#line 2 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
using CarWash.Web.Infrastructures.Domain.Enums;

#line default
#line hidden
#line 3 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
using CarWash.Web.Infrastructures.Domain.Models;

#line default
#line hidden
#line 4 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
using CarWash.Web.Infrastructures.Domain.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"427957ef3f9b45c57c1b1571840e61a80c19fb20", @"/Areas/Manage/Views/Bookings/Index.cshtml")]
    public class Areas_Manage_Views_Bookings_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarWash.Web.Areas.Manage.ViewModels.bookings.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/booking/create-bookings"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg-3 btn-success btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Booking Details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
  
    Layout = "~/areas/manage/views/shared/_forms.cshtml";

#line default
#line hidden
            BeginContext(284, 519, true);
            WriteLiteral(@"

<br /><br /><br />
<br />
<h1 class=""text-center"">List of Bookings</h1>
<hr />
<br /><br />
<div class=""row"">
    <div class=""col-lg-5"">
        <div class=""input-group mt-5"">
            <div class=""input-group-prepend"">
                <span class=""input-group-text"" id=""inputGroup-sizing-sm"">Services</span>
            </div>
            <select class=""form-control"" aria-label=""Small"" aria-describedby=""inputGroup-sizing-sm"" id=""searchStatus"" onchange=""searchTrigger()"" placeholder=""Login Status"">
");
            EndContext();
#line 22 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
                  
                    foreach (ServiceType service in Model.Serviceses)
                    {
                        if (Model.ServiceT == service)
                        {

#line default
#line hidden
            BeginContext(1000, 35, true);
            WriteLiteral("                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1035, "\"", 1051, 1);
#line 27 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
WriteAttributeValue("", 1043, service, 1043, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1052, 10, true);
            WriteLiteral(" selected>");
            EndContext();
            BeginContext(1063, 18, false);
#line 27 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
                                                         Write(service.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1081, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 28 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1176, 35, true);
            WriteLiteral("                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1211, "\"", 1227, 1);
#line 31 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
WriteAttributeValue("", 1219, service, 1219, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1228, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1230, 18, false);
#line 31 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
                                                Write(service.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1248, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 32 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
                        }
                    }
                

#line default
#line hidden
            BeginContext(1328, 282, true);
            WriteLiteral(@"            </select>
        </div>
    </div>

    <div class=""col-lg-3 "">
        <div class=""input-group mt-5"">
            <input type=""text"" id=""searchKeyword"" placeholder=""Search bookings"" class=""form-control"" aria-label=""search booking"" aria-describedby=""basic-addon2""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1610, "\"", 1641, 1);
#line 41 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
WriteAttributeValue("", 1618, Model.Bookings.Keyword, 1618, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1642, 372, true);
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
            BeginContext(2014, 199, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fd5055d34bd433da641bf04efc4b6c8", async() => {
                BeginContext(2100, 109, true);
                WriteLiteral("\r\n                <i class=\"fa fa-plus\"></i>&nbsp;\r\n                <span>Create Booking</span>\r\n            ");
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
            BeginContext(2213, 50, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<hr />\r\n\r\n\r\n");
            EndContext();
#line 60 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
 if (Model.Bookings.Items.Count > 0)
{

#line default
#line hidden
            BeginContext(2304, 341, true);
            WriteLiteral(@"    <table class=""table table-borderless table-striped table-hover"">
        <thead>
            <tr class=""table-info"">
                <th>Vehicle</th>
                <th>Service Type</th>
                <th>Time</th>
                <th>Price</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 73 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
              
                foreach (Booking booking in Model.Bookings.Items)
                {

#line default
#line hidden
            BeginContext(2747, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(2802, 15, false);
#line 77 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
                       Write(booking.Vehicle);

#line default
#line hidden
            EndContext();
            BeginContext(2817, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2853, 19, false);
#line 78 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
                       Write(booking.ServiceType);

#line default
#line hidden
            EndContext();
            BeginContext(2872, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2908, 12, false);
#line 79 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
                       Write(booking.Time);

#line default
#line hidden
            EndContext();
            BeginContext(2920, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2985, 145, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd1f443974e546c6ba593d1ab85e3720", async() => {
                BeginContext(3056, 70, true);
                WriteLiteral("<button type=\"button\" class=\"btn\"><i class=\"fas fa-info\"></i></button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2994, "~/manage/booking/details/", 2994, 25, true);
#line 81 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
AddHtmlAttributeValue("", 3019, booking.Id, 3019, 11, false);

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
            BeginContext(3130, 43, true);
            WriteLiteral("\r\n\r\n                            <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3173, "\"", 3238, 6);
            WriteAttributeValue("", 3183, "confirmDeleteService(\'", 3183, 22, true);
#line 83 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
WriteAttributeValue("", 3205, booking.Id, 3205, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 3216, "\',", 3216, 2, true);
            WriteAttributeValue(" ", 3218, "\'", 3219, 2, true);
#line 83 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
WriteAttributeValue("", 3220, booking.Vehicle, 3220, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 3236, "\')", 3236, 2, true);
            EndWriteAttribute();
            BeginContext(3239, 159, true);
            WriteLiteral(" title=\"Delete Service\"><button type=\"button\" class=\"btn\"><i class=\"fas fa-times\"></i></button></a>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 86 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
                }
            

#line default
#line hidden
            BeginContext(3432, 393, true);
            WriteLiteral(@"        </tbody>
        <tfoot>
            <tr>
                <td colspan=""4"">
                    <nav aria-label=""Page navigation example"">
                        <ul class=""pagination"">
                            <li class=""page-item""><span class=""form-control-plaintext"">Page&nbsp;&nbsp;&nbsp;</span></li>
                            <li class=""page-item""><input type=""number""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3825, "\"", 3858, 1);
#line 95 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
WriteAttributeValue("", 3833, Model.Bookings.PageIndex, 3833, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3859, 41, true);
            WriteLiteral(" class=\"form-control\" style=\"width:50px;\"");
            EndContext();
            BeginWriteAttribute("onKeydown", " onKeydown=\"", 3900, "\"", 4168, 18);
            WriteAttributeValue("", 3912, "javascript:", 3912, 11, true);
            WriteAttributeValue(" ", 3923, "if(event.keyCode", 3924, 17, true);
            WriteAttributeValue(" ", 3940, "==", 3941, 3, true);
            WriteAttributeValue(" ", 3943, "13", 3944, 3, true);
            WriteAttributeValue(" ", 3946, "&&", 3947, 3, true);
            WriteAttributeValue(" ", 3949, "isNaN(parseInt($(this).val()))==false)", 3950, 39, true);
            WriteAttributeValue(" ", 3988, "window.location=\'/manage/booking/index?pageIndex=\'", 3989, 51, true);
            WriteAttributeValue(" ", 4039, "+", 4040, 2, true);
            WriteAttributeValue(" ", 4041, "(isNaN(parseInt($(this).val()))", 4042, 32, true);
            WriteAttributeValue(" ", 4073, "?", 4074, 2, true);
            WriteAttributeValue(" ", 4075, "1", 4076, 2, true);
            WriteAttributeValue(" ", 4077, ":", 4078, 2, true);
            WriteAttributeValue(" ", 4079, "parseInt($(this).val()))", 4080, 25, true);
            WriteAttributeValue(" ", 4104, "+", 4105, 2, true);
            WriteAttributeValue(" ", 4106, "\'&keyword=", 4107, 11, true);
#line 95 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
WriteAttributeValue("", 4117, Model.Bookings.Keyword, 4117, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 4142, "&booking=", 4142, 9, true);
#line 95 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
WriteAttributeValue("", 4151, Model.ServiceT, 4151, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4169, 118, true);
            WriteLiteral(" /></li>\r\n                            <li class=\"page-item\"><span class=\"form-control-plaintext\">&nbsp;&nbsp;&nbsp;of ");
            EndContext();
            BeginContext(4288, 24, false);
#line 96 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
                                                                                                       Write(Model.Bookings.PageCount);

#line default
#line hidden
            EndContext();
            BeginContext(4312, 32, true);
            WriteLiteral("&nbsp;&nbsp;&nbsp;</span></li>\r\n");
            EndContext();
#line 97 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
                              
                                var prev = Model.Bookings.PageIndex - 1;
                                if (prev > 0)
                                {

#line default
#line hidden
            BeginContext(4532, 58, true);
            WriteLiteral("                                    <li class=\"page-item\">");
            EndContext();
            BeginContext(4590, 194, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8427024a5d8249f78153ce9c08412d8f", async() => {
                BeginContext(4741, 39, true);
                WriteLiteral("<span aria-hidden=\"true\">&laquo;</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4617, "~/manage/service?keyword=", 4617, 25, true);
#line 101 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
AddHtmlAttributeValue("", 4642, Model.Bookings.Keyword, 4642, 23, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 4665, "&booking=", 4665, 9, true);
#line 101 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
AddHtmlAttributeValue("", 4674, Model.ServiceT, 4674, 15, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 4689, "&pageSize=", 4689, 10, true);
#line 101 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
AddHtmlAttributeValue("", 4699, Model.Bookings.PageSize, 4699, 24, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 4723, "&pageIndex=", 4723, 11, true);
#line 101 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
AddHtmlAttributeValue("", 4734, prev, 4734, 5, false);

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
            BeginContext(4784, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 102 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(4857, 80, true);
            WriteLiteral("                            <li class=\"page-item\"><a class=\"page-link\" href=\"#\">");
            EndContext();
            BeginContext(4939, 24, false);
#line 104 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
                                                                            Write(Model.Bookings.PageIndex);

#line default
#line hidden
            EndContext();
            BeginContext(4964, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 105 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
                              
                                var next = Model.Bookings.PageIndex + 1;
                                if (next <= Model.Bookings.PageCount)
                                {

#line default
#line hidden
            BeginContext(5187, 58, true);
            WriteLiteral("                                    <li class=\"page-item\">");
            EndContext();
            BeginContext(5245, 194, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36d0ab207d2a42f1be9c895eb7bde1ff", async() => {
                BeginContext(5396, 39, true);
                WriteLiteral("<span aria-hidden=\"true\">&raquo;</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5272, "~/manage/booking?keyword=", 5272, 25, true);
#line 109 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
AddHtmlAttributeValue("", 5297, Model.Bookings.Keyword, 5297, 23, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 5320, "&booking=", 5320, 9, true);
#line 109 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
AddHtmlAttributeValue("", 5329, Model.Bookings, 5329, 15, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 5344, "&pageSize=", 5344, 10, true);
#line 109 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
AddHtmlAttributeValue("", 5354, Model.Bookings.PageSize, 5354, 24, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 5378, "&pageIndex=", 5378, 11, true);
#line 109 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
AddHtmlAttributeValue("", 5389, next, 5389, 5, false);

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
            BeginContext(5439, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 110 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(5512, 133, true);
            WriteLiteral("                        </ul>\r\n                    </nav>\r\n                </td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n");
            EndContext();
#line 118 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(5657, 30, true);
            WriteLiteral("    <p>0 search results.</p>\r\n");
            EndContext();
#line 122 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Bookings\Index.cshtml"
}

#line default
#line hidden
            BeginContext(5690, 1611, true);
            WriteLiteral(@"

<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-delete-booking"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Delete Booking</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to delete <span id=""modal-delete-booking-vehicle""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <a href=""#"" id=""modal-delete-booking-confirm""><button type=""button"" class=""btn btn-primary"">Delete Booking</button></a>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>



<script type=""text/javascript"">



    function co");
            WriteLiteral(@"nfirmDeleteService(bookingId, Vehicle) {
        $(""#modal-delete-booking-vehicle"").html(Vehicle);
        $(""#modal-delete-booking-confirm"").attr(""href"", ""/manage/booking/delete/"" + bookingId);
        $(""#modal-delete-booking"").modal(""show"");
    }

    $(""#searchKeyword"").keyup(function (event) {
        if (event.keyCode === 13) {
            searchTrigger();
        }
    });

    function searchTrigger() {
        window.location = ""/manage/booking?pageIndex=1&keyword="" + $(""#searchKeyword"").val() + ""&service="" + $(""#searchStatus"").val();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarWash.Web.Areas.Manage.ViewModels.bookings.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
