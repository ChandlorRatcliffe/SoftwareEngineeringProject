#pragma checksum "C:\Users\armyj\Desktop\CashewDesign\Implementation\SoftwareEngineeringProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb1fd14cc168d6098b1a48b77ba3751c65f2e1b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb1fd14cc168d6098b1a48b77ba3751c65f2e1b6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f32711a15edfe4b8d76e8ea81467849dcf32197", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\armyj\Desktop\CashewDesign\Implementation\SoftwareEngineeringProject\Views\Home\Index.cshtml"
  
    ViewBag.Title = Model.PageTitle;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div>\r\n        <h3>");
#nullable restore
#line 8 "C:\Users\armyj\Desktop\CashewDesign\Implementation\SoftwareEngineeringProject\Views\Home\Index.cshtml"
       Write(Model.PageTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n        <div class=\"col-sm\">\r\n            ");
#nullable restore
#line 11 "C:\Users\armyj\Desktop\CashewDesign\Implementation\SoftwareEngineeringProject\Views\Home\Index.cshtml"
       Write(Model.Home.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>

        <div class=""card-deck"">
            <div class=""card"">
                <div class=""card-body"">
                    <h5 class=""card-title"">Card title</h5>
                    <p class=""card-text"">This is a longer card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                    <p class=""card-text""><small class=""text-muted"">Last updated 3 mins ago</small></p>
                </div>
            </div>
            <div class=""card"">
                <div class=""card-body"">
                    <h5 class=""card-title"">Card title</h5>
                    <p class=""card-text"">This card has supporting text below as a natural lead-in to additional content.</p>
                    <p class=""card-text""><small class=""text-muted"">Last updated 3 mins ago</small></p>
                </div>
            </div>
            <div class=""card"">
                <div class=""card-body"">
                    <h5 class=""car");
            WriteLiteral(@"d-title"">Card title</h5>
                    <p class=""card-text"">This is a wider card with supporting text below as a natural lead-in to additional content. This card has even longer content than the first to show that equal height action.</p>
                    <p class=""card-text""><small class=""text-muted"">Last updated 3 mins ago</small></p>
                </div>
            </div>
        </div>
    </div>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
