#pragma checksum "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a4c9288700b8555fa0892ea652f58468afde8d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Index), @"mvc.1.0.view", @"/Views/Booking/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Booking/Index.cshtml", typeof(AspNetCore.Views_Booking_Index))]
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
#line 2 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Index.cshtml"
using CarWash.Web.Infrastructures.Domain.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a4c9288700b8555fa0892ea652f58468afde8d8", @"/Views/Booking/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c63ec8b4ff39190a57bd53c4bcdd08e35dae823", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarWash.Web.ViewModels.bookings.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(146, 20, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n");
            EndContext();
            BeginContext(166, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81ee1ccab6134b2895f9d38d71da0665", async() => {
                BeginContext(225, 8, true);
                WriteLiteral("Book Now");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 175, "~/booking/costumer/", 175, 19, true);
#line 9 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Index.cshtml"
AddHtmlAttributeValue("", 194, Model.Id, 194, 9, false);

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
            BeginContext(237, 336, true);
            WriteLiteral(@"
<table class=""table table-bordered table-hover"">
    <thead>
        <tr>
            <th>Vehicle</th>
            <th>Description</th>
            <th>Various Services</th>
            <th>Price</th>
            <th>Booking Address</th>
            <th>Time</th>
        </tr>
    </thead>
    <tbody>
   
        <tr>
");
            EndContext();
#line 24 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Index.cshtml"
             foreach (Booking booking in Model.Bookings)
            {


#line default
#line hidden
            BeginContext(648, 34, true);
            WriteLiteral("            <td>\r\n                ");
            EndContext();
            BeginContext(683, 24, false);
#line 28 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Index.cshtml"
           Write(booking.Services.Vehicle);

#line default
#line hidden
            EndContext();
            BeginContext(707, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
            BeginContext(730, 33, true);
            WriteLiteral("            <td>\r\n               ");
            EndContext();
            BeginContext(764, 28, false);
#line 32 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Index.cshtml"
          Write(booking.Services.Description);

#line default
#line hidden
            EndContext();
            BeginContext(792, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
            BeginContext(815, 33, true);
            WriteLiteral("            <td>\r\n               ");
            EndContext();
            BeginContext(849, 28, false);
#line 36 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Index.cshtml"
          Write(booking.Services.ServiceType);

#line default
#line hidden
            EndContext();
            BeginContext(877, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
            BeginContext(912, 16, true);
            WriteLiteral("            <td>");
            EndContext();
            BeginContext(929, 22, false);
#line 39 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Index.cshtml"
           Write(booking.Services.Price);

#line default
#line hidden
            EndContext();
            BeginContext(951, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
            BeginContext(960, 34, true);
            WriteLiteral("            <td>\r\n                ");
            EndContext();
            BeginContext(995, 22, false);
#line 42 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Index.cshtml"
           Write(booking.BookingAddress);

#line default
#line hidden
            EndContext();
            BeginContext(1017, 37, true);
            WriteLiteral("\r\n            </td>\r\n            <td>");
            EndContext();
            BeginContext(1055, 12, false);
#line 44 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Index.cshtml"
           Write(booking.Time);

#line default
#line hidden
            EndContext();
            BeginContext(1067, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 45 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Views\Booking\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1089, 49, true);
            WriteLiteral("        </tr>\r\n        \r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarWash.Web.ViewModels.bookings.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
