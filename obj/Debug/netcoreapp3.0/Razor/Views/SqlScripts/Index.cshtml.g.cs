#pragma checksum "C:\Users\nxjone\source\repos\NimbleWeb\Views\SqlScripts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f61749b4073b70498dee9dd4450da5681bbb7de4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SqlScripts_Index), @"mvc.1.0.view", @"/Views/SqlScripts/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f61749b4073b70498dee9dd4450da5681bbb7de4", @"/Views/SqlScripts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb96027269cb1893c1cbf2b926a1a5dd24ff0b74", @"/Views/_ViewImports.cshtml")]
    public class Views_SqlScripts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SqlScripts>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\nxjone\source\repos\NimbleWeb\Views\SqlScripts\Index.cshtml"
  
    ViewBag.Title = "SqlScripts Table";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table>\r\n    <tr>\r\n        <th>Id</th>\r\n    </tr>\r\n\r\n    <tbody>\r\n");
#nullable restore
#line 13 "C:\Users\nxjone\source\repos\NimbleWeb\Views\SqlScripts\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 16 "C:\Users\nxjone\source\repos\NimbleWeb\Views\SqlScripts\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 18 "C:\Users\nxjone\source\repos\NimbleWeb\Views\SqlScripts\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SqlScripts>> Html { get; private set; }
    }
}
#pragma warning restore 1591
