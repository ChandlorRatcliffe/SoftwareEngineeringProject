#pragma checksum "C:\Users\nxjone\Desktop\Dev\Views\Search\Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cf042aa8c5e2458b68ced05969bcff95cb84025"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Results), @"mvc.1.0.view", @"/Views/Search/Results.cshtml")]
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
#line 4 "C:\Users\nxjone\Desktop\Dev\Views\_ViewImports.cshtml"
using CashewWeb.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nxjone\Desktop\Dev\Views\_ViewImports.cshtml"
using CashewWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cf042aa8c5e2458b68ced05969bcff95cb84025", @"/Views/Search/Results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c649225a0d8039030c587dcf11a1822bcb70f220", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Search>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\nxjone\Desktop\Dev\Views\Search\Results.cshtml"
  
    ViewBag.Title = "Search Table";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table>\r\n    <tr>\r\n        <th>Id</th>\r\n    </tr>\r\n\r\n    <tbody>\r\n");
#nullable restore
#line 13 "C:\Users\nxjone\Desktop\Dev\Views\Search\Results.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 16 "C:\Users\nxjone\Desktop\Dev\Views\Search\Results.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 18 "C:\Users\nxjone\Desktop\Dev\Views\Search\Results.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Search>> Html { get; private set; }
    }
}
#pragma warning restore 1591
