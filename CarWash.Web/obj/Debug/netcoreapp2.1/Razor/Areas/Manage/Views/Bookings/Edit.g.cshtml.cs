#pragma checksum "C:\Users\VGD 14\Desktop\2ndsem\cw401\CarWash.Web\Areas\Manage\Views\Bookings\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cd58abc8f860e568019d6fbff698bc81e5f98bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Bookings_Edit), @"mvc.1.0.view", @"/Areas/Manage/Views/Bookings/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manage/Views/Bookings/Edit.cshtml", typeof(AspNetCore.Areas_Manage_Views_Bookings_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cd58abc8f860e568019d6fbff698bc81e5f98bc", @"/Areas/Manage/Views/Bookings/Edit.cshtml")]
    public class Areas_Manage_Views_Bookings_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarWash.Web.Areas.Manage.ViewModels.bookings.EditViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/booking/bookings-edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\VGD 14\Desktop\2ndsem\cw401\CarWash.Web\Areas\Manage\Views\Bookings\Edit.cshtml"
  
    Layout = "~/areas/manage/views/shared/_forms.cshtml";

#line default
#line hidden
            BeginContext(133, 183, true);
            WriteLiteral("\r\n<br /><br /><br />\r\n<br />\r\n<h1 class=\"text-center\">Edit Bookings</h1>\r\n<hr />\r\n<br /><br />\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            ");
            EndContext();
            BeginContext(316, 2567, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a29560f94d7a48f48ecc702988e386eb", async() => {
                BeginContext(376, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(395, 23, false);
#line 15 "C:\Users\VGD 14\Desktop\2ndsem\cw401\CarWash.Web\Areas\Manage\Views\Bookings\Edit.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(418, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(437, 24, false);
#line 16 "C:\Users\VGD 14\Desktop\2ndsem\cw401\CarWash.Web\Areas\Manage\Views\Bookings\Edit.cshtml"
           Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(461, 48, true);
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 509, "\"", 526, 1);
#line 17 "C:\Users\VGD 14\Desktop\2ndsem\cw401\CarWash.Web\Areas\Manage\Views\Bookings\Edit.cshtml"
WriteAttributeValue("", 517, Model.Id, 517, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(527, 229, true);
                WriteLiteral(" />\r\n\r\n                <div class=\"form-group\">\r\n                    <label for=\"serviceType\" class=\"control-label mb-1\">ServiceType</label>\r\n                    <select class=\"form-control\" id=\"serviceType\" name=\"ServiceType\">\r\n");
                EndContext();
#line 22 "C:\Users\VGD 14\Desktop\2ndsem\cw401\CarWash.Web\Areas\Manage\Views\Bookings\Edit.cshtml"
                          
                            var options = Enum.GetValues(typeof(CarWash.Web.Infrastructures.Domain.Enums.ServiceType)).Cast<CarWash.Web.Infrastructures.Domain.Enums.ServiceType>();

                            foreach (CarWash.Web.Infrastructures.Domain.Enums.ServiceType option in options)
                            {

#line default
#line hidden
                BeginContext(1109, 39, true);
                WriteLiteral("                                <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1148, "\"", 1163, 1);
#line 27 "C:\Users\VGD 14\Desktop\2ndsem\cw401\CarWash.Web\Areas\Manage\Views\Bookings\Edit.cshtml"
WriteAttributeValue("", 1156, option, 1156, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1164, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1166, 17, false);
#line 27 "C:\Users\VGD 14\Desktop\2ndsem\cw401\CarWash.Web\Areas\Manage\Views\Bookings\Edit.cshtml"
                                                   Write(option.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(1183, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 28 "C:\Users\VGD 14\Desktop\2ndsem\cw401\CarWash.Web\Areas\Manage\Views\Bookings\Edit.cshtml"
                            }
                        

#line default
#line hidden
                BeginContext(1252, 285, true);
                WriteLiteral(@"                    </select>
                </div>
                <div class=""form-group"">
                    <label for=""time"" class=""control-label mb-2"">Time</label>
                    <input type=""text"" class=""form-control"" id=""time"" name=""Time"" aria-describedby=""timeHelp""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1537, "\"", 1556, 1);
#line 34 "C:\Users\VGD 14\Desktop\2ndsem\cw401\CarWash.Web\Areas\Manage\Views\Bookings\Edit.cshtml"
WriteAttributeValue("", 1545, Model.Time, 1545, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1557, 335, true);
                WriteLiteral(@" placeholder=""Enter Time"">
                </div>

                <div class=""form-group"">
                    <label for=""bookingaddress"" class=""control-label mb-2"">Booking Address</label>
                    <input type=""text"" class=""form-control"" id=""bookingaddress"" name=""BookingAddress"" aria-describedby=""bookingaddressHelp""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1892, "\"", 1921, 1);
#line 39 "C:\Users\VGD 14\Desktop\2ndsem\cw401\CarWash.Web\Areas\Manage\Views\Bookings\Edit.cshtml"
WriteAttributeValue("", 1900, Model.BookingAddress, 1900, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1922, 275, true);
                WriteLiteral(@" placeholder=""Enter Description"">
                </div>

                <div class=""form-group"">
                    <label for=""vehicle"" class=""control-label mb-2"">Vehicle</label>
                    <input type=""text"" class=""form-control"" id=""vehicle"" name=""Vehicle""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2197, "\"", 2219, 1);
#line 44 "C:\Users\VGD 14\Desktop\2ndsem\cw401\CarWash.Web\Areas\Manage\Views\Bookings\Edit.cshtml"
WriteAttributeValue("", 2205, Model.Vehicle, 2205, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2220, 86, true);
                WriteLiteral(" aria-describedby=\"vehicleHelp\" placeholder=\"Enter vehicle\">\r\n                </div>\r\n");
                EndContext();
                BeginContext(2619, 141, true);
                WriteLiteral("\r\n                <div class=\"mt-2\">\r\n                    <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n                    ");
                EndContext();
                BeginContext(2760, 78, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "171c004bc43647efb706b5ae7314d4ec", async() => {
                    BeginContext(2828, 6, true);
                    WriteLiteral("Cancel");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2769, "~/manage/booking/details/", 2769, 25, true);
#line 53 "C:\Users\VGD 14\Desktop\2ndsem\cw401\CarWash.Web\Areas\Manage\Views\Bookings\Edit.cshtml"
AddHtmlAttributeValue("", 2794, Model.Id, 2794, 9, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2838, 38, true);
                WriteLiteral("\r\n                </div>\r\n            ");
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
            BeginContext(2883, 38, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarWash.Web.Areas.Manage.ViewModels.bookings.EditViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591