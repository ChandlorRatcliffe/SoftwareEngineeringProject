#pragma checksum "C:\Users\armyj\Desktop\CashewDesign\Implementation\SoftwareEngineeringProject\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50987867fc21af39276d7736b76041d22fb46ed2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\armyj\Desktop\CashewDesign\Implementation\SoftwareEngineeringProject\Views\_ViewImports.cshtml"
using CashewWeb.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\armyj\Desktop\CashewDesign\Implementation\SoftwareEngineeringProject\Views\_ViewImports.cshtml"
using CashewWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50987867fc21af39276d7736b76041d22fb46ed2", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f32711a15edfe4b8d76e8ea81467849dcf32197", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\armyj\Desktop\CashewDesign\Implementation\SoftwareEngineeringProject\Views\Account\Index.cshtml"
  
    ViewBag.Title = "Account Table";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container my-5\">\r\n    <div class=\"row justify-content-center\">\r\n        <div class=\"col-sm-12 col-md-8 col-lg-6 text-center p-5 bg-dark rounded border border-primary\">\r\n");
#nullable restore
#line 8 "C:\Users\armyj\Desktop\CashewDesign\Implementation\SoftwareEngineeringProject\Views\Account\Index.cshtml"
             using (Html.BeginForm("Index", "Account", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <form class=""text-center"">
                    <div class=""form-group text-center mt-2"">
                        <label class=""text-center text-light"" for=""Username"">Email&nbsp;or&nbsp;Username</label>
                        <input class=""form-control text-center text-light bg-dark"" asp-for=""Username"" type=""text"" id=""idInput"" aria-describedby=""idHelp"" placeholder=""Enter Email or Username"">
                        <small class=""form-text text-muted text-center text-light"" id=""idHelp"">Secured</small>
                    </div>
                    <div class=""form-group mt-2"">
                        <label class=""text-center text-light"" for=""Password"">Password</label>
                        <input class=""form-control text-center text-light bg-dark"" type=""password"" asp-for=""Password"" id=""passwordInput"" placeholder=""Password"">
                    </div>
                    <div class=""form-check"">
                        <input class=""form-check-input text-center text-light"" type=""che");
            WriteLiteral(@"ckbox"" id=""exampleCheck1"">
                        <label class=""form-check-label text-center font-co text-light"" for=""exampleCheck1"">Remember&nbsp;Me?</label>
                    </div>
                    <div class=""mt-2"">
                        <button id=""LoginButton"" type=""submit"" class=""btn btn-primary text-light text-center mt-2 border border-secondary"" style=""width: 150px;"">Sign&nbsp;In</button>
                    </div>
                </form>
");
#nullable restore
#line 28 "C:\Users\armyj\Desktop\CashewDesign\Implementation\SoftwareEngineeringProject\Views\Account\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <hr style=\"border-color: gray;\" />\r\n            <div class=\"mt-3\">\r\n\r\n                <button class=\"btn btn-primary text-light text-center mt-2 border border-secondary mx-1\" style=\"width: 150px;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2031, "\"", 2089, 3);
            WriteAttributeValue("", 2041, "location.href=\'", 2041, 15, true);
#nullable restore
#line 32 "C:\Users\armyj\Desktop\CashewDesign\Implementation\SoftwareEngineeringProject\Views\Account\Index.cshtml"
WriteAttributeValue("", 2056, Url.Action("Create", "Account"), 2056, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2088, "\'", 2088, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Create&nbsp;Account</button>\r\n                <button class=\"btn btn-primary text-light text-center mt-2 border border-secondary mx-1\" style=\"width: 150px;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2247, "\"", 2307, 3);
            WriteAttributeValue("", 2257, "location.href=\'", 2257, 15, true);
#nullable restore
#line 33 "C:\Users\armyj\Desktop\CashewDesign\Implementation\SoftwareEngineeringProject\Views\Account\Index.cshtml"
WriteAttributeValue("", 2272, Url.Action("Recovery", "Account"), 2272, 34, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2306, "\'", 2306, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Account&nbsp;Recovery</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591