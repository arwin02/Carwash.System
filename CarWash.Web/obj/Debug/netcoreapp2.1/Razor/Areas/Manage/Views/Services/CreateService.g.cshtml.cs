#pragma checksum "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\CreateService.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df55ed69d554efbe1800ae1b92bebb4919eb69b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Services_CreateService), @"mvc.1.0.view", @"/Areas/Manage/Views/Services/CreateService.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manage/Views/Services/CreateService.cshtml", typeof(AspNetCore.Areas_Manage_Views_Services_CreateService))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df55ed69d554efbe1800ae1b92bebb4919eb69b1", @"/Areas/Manage/Views/Services/CreateService.cshtml")]
    public class Areas_Manage_Views_Services_CreateService : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarWash.Web.Areas.Manage.ViewModels.services.CreateServiceViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/service/index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/service/create-services"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\CreateService.cshtml"
  
    Layout = "~/areas/manage/views/shared/_forms.cshtml";

#line default
#line hidden
            BeginContext(142, 184, true);
            WriteLiteral("\r\n<br /><br /><br />\r\n<br />\r\n<h1 class=\"text-center\">Create Service</h1>\r\n<hr />\r\n<br /><br />\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            ");
            EndContext();
            BeginContext(326, 2101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e85a79eefeb349c9be54eecb623d9b32", async() => {
                BeginContext(388, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(407, 23, false);
#line 15 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\CreateService.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(430, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(449, 24, false);
#line 16 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\CreateService.cshtml"
           Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(473, 226, true);
                WriteLiteral("\r\n\r\n                <div class=\"form-group\">\r\n                    <label for=\"serviceType\" class=\"control-label mb-1\">ServiceType</label>\r\n                    <select class=\"form-control\" id=\"serviceType\" name=\"ServiceType\">\r\n");
                EndContext();
#line 21 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\CreateService.cshtml"
                          
                            var options = Enum.GetValues(typeof(CarWash.Web.Infrastructures.Domain.Enums.ServiceType)).Cast<CarWash.Web.Infrastructures.Domain.Enums.ServiceType>();

                            foreach (CarWash.Web.Infrastructures.Domain.Enums.ServiceType option in options)
                            {

#line default
#line hidden
                BeginContext(1052, 39, true);
                WriteLiteral("                                <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1091, "\"", 1106, 1);
#line 26 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\CreateService.cshtml"
WriteAttributeValue("", 1099, option, 1099, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1107, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1109, 17, false);
#line 26 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\CreateService.cshtml"
                                                   Write(option.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(1126, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 27 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\Carwash\CarWash.Web\Areas\Manage\Views\Services\CreateService.cshtml"
                            }
                        

#line default
#line hidden
                BeginContext(1195, 1121, true);
                WriteLiteral(@"                    </select>
                </div>
                <div class=""form-group"">
                    <label for=""description"" class=""control-label mb-2"">Description</label>
                    <input type=""text"" class=""form-control"" id=""description"" name=""Description"" aria-describedby=""descriptionHelp"" placeholder=""Enter Description"">
                </div>
                <div class=""form-group"">
                    <label for=""vehicle"" class=""control-label mb-2"">Vehicle</label>
                    <input type=""text"" class=""form-control"" id=""vehicle"" name=""Vehicle"" aria-describedby=""vehicleHelp"" placeholder=""Enter vehicle"">
                </div>
                <div class=""form-group"">
                    <label for=""price"" class=""control-label mb-2"">Price</label>
                    <input type=""text"" class=""form-control"" id=""price"" name=""Price"" aria-describedby=""priceHelp"" placeholder=""Enter Price"">
                </div>
             
                <div class=""mt-2"">
      ");
                WriteLiteral("              <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n                    ");
                EndContext();
                BeginContext(2316, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e567b55f7568494ba6eb289fe8e849bd", async() => {
                    BeginContext(2372, 6, true);
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
                BeginContext(2382, 38, true);
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
            BeginContext(2427, 38, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarWash.Web.Areas.Manage.ViewModels.services.CreateServiceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
