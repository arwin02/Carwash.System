#pragma checksum "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29d32b87a5c2da2d5c1ac59e8a072deeb8a7624f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Services_Edit), @"mvc.1.0.view", @"/Areas/Manage/Views/Services/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manage/Views/Services/Edit.cshtml", typeof(AspNetCore.Areas_Manage_Views_Services_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29d32b87a5c2da2d5c1ac59e8a072deeb8a7624f", @"/Areas/Manage/Views/Services/Edit.cshtml")]
    public class Areas_Manage_Views_Services_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarWash.Web.Areas.Manage.ViewModels.services.EditServiceViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/service/services-edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Edit.cshtml"
  
    Layout = "~/areas/manage/views/shared/_forms.cshtml";

#line default
#line hidden
            BeginContext(140, 182, true);
            WriteLiteral("\r\n<br /><br /><br />\r\n<br />\r\n<h1 class=\"text-center\">Edit Service</h1>\r\n<hr />\r\n<br /><br />\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            ");
            EndContext();
            BeginContext(322, 2238, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a04edb16d4a14cb8bca5cdd78edfe9ff", async() => {
                BeginContext(382, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(401, 23, false);
#line 15 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Edit.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(424, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(443, 24, false);
#line 16 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Edit.cshtml"
           Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(467, 48, true);
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 515, "\"", 532, 1);
#line 17 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Edit.cshtml"
WriteAttributeValue("", 523, Model.Id, 523, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(533, 229, true);
                WriteLiteral(" />\r\n\r\n                <div class=\"form-group\">\r\n                    <label for=\"serviceType\" class=\"control-label mb-1\">ServiceType</label>\r\n                    <select class=\"form-control\" id=\"serviceType\" name=\"ServiceType\">\r\n");
                EndContext();
#line 22 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Edit.cshtml"
                          
                            var options = Enum.GetValues(typeof(CarWash.Web.Infrastructures.Domain.Enums.ServiceType)).Cast<CarWash.Web.Infrastructures.Domain.Enums.ServiceType>();

                            foreach (CarWash.Web.Infrastructures.Domain.Enums.ServiceType option in options)
                            {

#line default
#line hidden
                BeginContext(1115, 39, true);
                WriteLiteral("                                <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1154, "\"", 1169, 1);
#line 27 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Edit.cshtml"
WriteAttributeValue("", 1162, option, 1162, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1170, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1172, 17, false);
#line 27 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Edit.cshtml"
                                                   Write(option.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(1189, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 28 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Edit.cshtml"
                            }
                        

#line default
#line hidden
                BeginContext(1258, 320, true);
                WriteLiteral(@"                    </select>
                </div>
                <div class=""form-group"">
                    <label for=""description"" class=""control-label mb-2"">Description</label>
                    <input type=""text"" class=""form-control"" id=""description"" name=""Description"" aria-describedby=""descriptionHelp""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1578, "\"", 1604, 1);
#line 34 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Edit.cshtml"
WriteAttributeValue("", 1586, Model.Description, 1586, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1605, 273, true);
                WriteLiteral(@" placeholder=""Enter Description"">
                </div>
                <div class=""form-group"">
                    <label for=""vehicle"" class=""control-label mb-2"">Vehicle</label>
                    <input type=""text"" class=""form-control"" id=""vehicle"" name=""Vehicle""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1878, "\"", 1900, 1);
#line 38 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Edit.cshtml"
WriteAttributeValue("", 1886, Model.Vehicle, 1886, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1901, 292, true);
                WriteLiteral(@" aria-describedby=""vehicleHelp"" placeholder=""Enter vehicle"">
                </div>
                <div class=""form-group"">
                    <label for=""price"" class=""control-label mb-2"">Price</label>
                    <input type=""text"" class=""form-control"" id=""price"" name=""Price""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2193, "\"", 2213, 1);
#line 42 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Edit.cshtml"
WriteAttributeValue("", 2201, Model.Price, 2201, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2214, 223, true);
                WriteLiteral(" aria-describedby=\"priceHelp\" placeholder=\"Enter Price\">\r\n                </div>\r\n\r\n                <div class=\"mt-2\">\r\n                    <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n                    ");
                EndContext();
                BeginContext(2437, 78, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97b46b59e5444b7089cf2c6bcc7a0faa", async() => {
                    BeginContext(2505, 6, true);
                    WriteLiteral("Cancel");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2446, "~/manage/service/details/", 2446, 25, true);
#line 47 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\Edit.cshtml"
AddHtmlAttributeValue("", 2471, Model.Id, 2471, 9, false);

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
                BeginContext(2515, 38, true);
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
            BeginContext(2560, 38, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarWash.Web.Areas.Manage.ViewModels.services.EditServiceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
