#pragma checksum "C:\Users\armyj\Desktop\Cashew\Dev\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b18f0862d86df0935aee1b9a790276d8280bec4"
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
#line 4 "C:\Users\armyj\Desktop\Cashew\Dev\Views\_ViewImports.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\armyj\Desktop\Cashew\Dev\Views\_ViewImports.cshtml"
using CashewWeb.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\armyj\Desktop\Cashew\Dev\Views\_ViewImports.cshtml"
using CashewWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\armyj\Desktop\Cashew\Dev\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b18f0862d86df0935aee1b9a790276d8280bec4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd119c6e9fb4d921bcd60e38228f36901d23300c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Creator: Nicholas Jones-->\r\n<!-- Edited: Travis Idle -->\r\n");
#nullable restore
#line 4 "C:\Users\armyj\Desktop\Cashew\Dev\Views\Home\Index.cshtml"
  
    ViewBag.Title = Model.PageTitle;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Card Example -->\r\n<div>\r\n    <h3 class=\"text-center\">");
#nullable restore
#line 9 "C:\Users\armyj\Desktop\Cashew\Dev\Views\Home\Index.cshtml"
                       Write(Model.PageTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
    <!-- Nick and I talked talked about the intent for the homepage to be info about the app
         presented before the login page or to be the login page.
         Moved the Dashboard-related elements to Projects/Index.cshtml as that was the intended page
         for them to belong to. -->
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
