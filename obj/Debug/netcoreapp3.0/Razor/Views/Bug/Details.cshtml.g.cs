#pragma checksum "C:\Users\nxjone\source\repos\NimbleWeb\Views\Bug\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "401c53d466e8e0752dffa8762e10d7ebf3da175b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bug_Details), @"mvc.1.0.view", @"/Views/Bug/Details.cshtml")]
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
#line 1 "C:\Users\nxjone\source\repos\NimbleWeb\Views\_ViewImports.cshtml"
using NimbleWeb.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nxjone\source\repos\NimbleWeb\Views\_ViewImports.cshtml"
using NimbleWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"401c53d466e8e0752dffa8762e10d7ebf3da175b", @"/Views/Bug/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb96027269cb1893c1cbf2b926a1a5dd24ff0b74", @"/Views/_ViewImports.cshtml")]
    public class Views_Bug_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BugDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\nxjone\source\repos\NimbleWeb\Views\Bug\Details.cshtml"
  
    ViewBag.Title = "Bug Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h3>");
#nullable restore
#line 8 "C:\Users\nxjone\source\repos\NimbleWeb\Views\Bug\Details.cshtml"
   Write(Model.PageTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n\r\n    <div>\r\n        Name: ");
#nullable restore
#line 12 "C:\Users\nxjone\source\repos\NimbleWeb\Views\Bug\Details.cshtml"
         Write(Model.Bug.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div>\r\n        Priority: ");
#nullable restore
#line 16 "C:\Users\nxjone\source\repos\NimbleWeb\Views\Bug\Details.cshtml"
             Write(Model.Bug.Priority);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div>\r\n        Description: ");
#nullable restore
#line 20 "C:\Users\nxjone\source\repos\NimbleWeb\Views\Bug\Details.cshtml"
                Write(Model.Bug.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div>\r\n        User: ");
#nullable restore
#line 24 "C:\Users\nxjone\source\repos\NimbleWeb\Views\Bug\Details.cshtml"
         Write(Model.Bug.User);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BugDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
