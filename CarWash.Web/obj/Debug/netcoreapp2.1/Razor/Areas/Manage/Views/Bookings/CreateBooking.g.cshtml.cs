#pragma checksum "C:\Users\VGD 14\Desktop\2ndsem\cw401\CarWash.Web\Areas\Manage\Views\Bookings\CreateBooking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "542984e5a824b153a8b9bbf3a7de40cc69b24ab7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Bookings_CreateBooking), @"mvc.1.0.view", @"/Areas/Manage/Views/Bookings/CreateBooking.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manage/Views/Bookings/CreateBooking.cshtml", typeof(AspNetCore.Areas_Manage_Views_Bookings_CreateBooking))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"542984e5a824b153a8b9bbf3a7de40cc69b24ab7", @"/Areas/Manage/Views/Bookings/CreateBooking.cshtml")]
    public class Areas_Manage_Views_Bookings_CreateBooking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarWash.Web.Areas.Manage.ViewModels.bookings.CreateBookingViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/service/index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/booking/create-bookings"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\VGD 14\Desktop\2ndsem\cw401\CarWash.Web\Areas\Manage\Views\Bookings\CreateBooking.cshtml"
  
    Layout = "~/areas/manage/views/shared/_forms.cshtml";

#line default
#line hidden
            BeginContext(142, 182, true);
            WriteLiteral("<br /><br /><br />\r\n<br />\r\n<h1 class=\"text-center\">Booking Create</h1>\r\n<hr />\r\n<br /><br />\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            ");
            EndContext();
            BeginContext(324, 2110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26b6a64d89534834a45b5f3fa5b7452f", async() => {
                BeginContext(386, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(405, 23, false);
#line 14 "C:\Users\VGD 14\Desktop\2ndsem\cw401\CarWash.Web\Areas\Manage\Views\Bookings\CreateBooking.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(428, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(447, 24, false);
#line 15 "C:\Users\VGD 14\Desktop\2ndsem\cw401\CarWash.Web\Areas\Manage\Views\Bookings\CreateBooking.cshtml"
           Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(471, 1160, true);
                WriteLiteral(@"


                <div class=""form-group"">
                    <label for=""vehicle"" class=""control-label mb-2"">Vehicle</label>
                    <input type=""text"" class=""form-control"" id=""description"" name=""Vehicle"" aria-describedby=""vehicleHelp"" placeholder=""Enter type of vehicle"">
                </div>
                <div class=""form-group"">
                    <label for=""time"" class=""control-label mb-2"">Time</label>
                    <input type=""text"" class=""form-control"" id=""time"" name=""Time"" aria-describedby=""timeHelp"" placeholder=""Enter time"">
                </div>



                <div class=""form-group"">
                    <label for=""bookingaddress"" class=""control-label mb-2"">Price</label>
                    <input type=""text"" class=""form-control"" id=""bookingaddress"" name=""BookingAddress"" aria-describedby=""bookingaddressHelp"" placeholder=""Enter Address"">
                </div>



                <div class=""form-group"">
                    <label for=""serviceType""");
                WriteLiteral(" class=\"control-label mb-1\">ServiceType</label>\r\n                    <select class=\"form-control\" id=\"serviceType\" name=\"ServiceType\">\r\n");
                EndContext();
#line 39 "C:\Users\VGD 14\Desktop\2ndsem\cw401\CarWash.Web\Areas\Manage\Views\Bookings\CreateBooking.cshtml"
                          
                            var options = Enum.GetValues(typeof(CarWash.Web.Infrastructures.Domain.Enums.ServiceType)).Cast<CarWash.Web.Infrastructures.Domain.Enums.ServiceType>();

                            foreach (CarWash.Web.Infrastructures.Domain.Enums.ServiceType option in options)
                            {

#line default
#line hidden
                BeginContext(1984, 39, true);
                WriteLiteral("                                <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2023, "\"", 2038, 1);
#line 44 "C:\Users\VGD 14\Desktop\2ndsem\cw401\CarWash.Web\Areas\Manage\Views\Bookings\CreateBooking.cshtml"
WriteAttributeValue("", 2031, option, 2031, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2039, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2041, 17, false);
#line 44 "C:\Users\VGD 14\Desktop\2ndsem\cw401\CarWash.Web\Areas\Manage\Views\Bookings\CreateBooking.cshtml"
                                                   Write(option.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(2058, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 45 "C:\Users\VGD 14\Desktop\2ndsem\cw401\CarWash.Web\Areas\Manage\Views\Bookings\CreateBooking.cshtml"
                            }
                        

#line default
#line hidden
                BeginContext(2127, 196, true);
                WriteLiteral("                    </select>\r\n                </div>\r\n\r\n                <div class=\"mt-2\">\r\n                    <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n                    ");
                EndContext();
                BeginContext(2323, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d528e2c71a04409d8218b17a63b79b24", async() => {
                    BeginContext(2379, 6, true);
                    WriteLiteral("Cancel");
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
                BeginContext(2389, 38, true);
                WriteLiteral("\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2434, 36, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarWash.Web.Areas.Manage.ViewModels.bookings.CreateBookingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591