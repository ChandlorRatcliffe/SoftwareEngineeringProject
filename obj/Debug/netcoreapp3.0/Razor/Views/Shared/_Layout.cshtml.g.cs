#pragma checksum "C:\Users\nxjone\source\repos\NimbleWeb\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d774fcd7283e79ecc16ebe45218c87d36d801b89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d774fcd7283e79ecc16ebe45218c87d36d801b89", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb96027269cb1893c1cbf2b926a1a5dd24ff0b74", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/css/fontawesome.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/js/all.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/js/bootstrap.bundle.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/js/jquery-3.4.1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/css/fontawesome.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/js/jquery-3.4.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d774fcd7283e79ecc16ebe45218c87d36d801b897017", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n\r\n    <title>");
#nullable restore
#line 8 "C:\Users\nxjone\source\repos\NimbleWeb\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n\r\n    <environment include=\"Development\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d774fcd7283e79ecc16ebe45218c87d36d801b897682", async() => {
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
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d774fcd7283e79ecc16ebe45218c87d36d801b898865", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d774fcd7283e79ecc16ebe45218c87d36d801b8910047", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d774fcd7283e79ecc16ebe45218c87d36d801b8911151", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d774fcd7283e79ecc16ebe45218c87d36d801b8912255", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </environment>\r\n    <environment exclude=\"Development\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d774fcd7283e79ecc16ebe45218c87d36d801b8913426", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d774fcd7283e79ecc16ebe45218c87d36d801b8914610", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d774fcd7283e79ecc16ebe45218c87d36d801b8915793", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d774fcd7283e79ecc16ebe45218c87d36d801b8916897", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </environment>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d774fcd7283e79ecc16ebe45218c87d36d801b8918727", async() => {
                WriteLiteral("\r\n    <nav class=\"navbar navbar-expand-md bg-dark navbar-dark sticky-top px-0\">\r\n\r\n        <button class=\"btn btn-dark btn-lg p-0 ml-2\" type=\"button\" href=\"#\" style=\"min-width: 72px;\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1077, "\"", 1131, 3);
                WriteAttributeValue("", 1087, "location.href=\'", 1087, 15, true);
#nullable restore
#line 28 "C:\Users\nxjone\source\repos\NimbleWeb\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1102, Url.Action("Index", "Home"), 1102, 28, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1130, "\'", 1130, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n            <div class=\"form-inline\">\r\n                <span");
                BeginWriteAttribute("class", " class=\"", 1195, "\"", 1203, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <i class=""fas fa-cog fa-spin fa-2x fa-fw""></i>
                </span>
                <span class=""align-self-center text-primary"" style=""font-size: 1.5rem;"">Nimble</span>
            </div>
        </button>

        <button class=""navbar-toggler mr-3"" type=""button"" data-toggle=""collapse"" data-target=""#collapsibleNavbar"">
            <span class=""navbar-toggler-icon""></span>
        </button>

        <div class=""collapse navbar-collapse mt-1 mt-sm-0 mx-1 mx-md-0"" id=""collapsibleNavbar"">
            <button class=""btn btn-dark"" type=""button""");
                BeginWriteAttribute("onclick", " onclick=\"", 1787, "\"", 1847, 3);
                WriteAttributeValue("", 1797, "location.href=\'", 1797, 15, true);
#nullable restore
#line 42 "C:\Users\nxjone\source\repos\NimbleWeb\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1812, Url.Action("Index", "TestRunner"), 1812, 34, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1846, "\'", 1846, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Test&nbsp;Runner</button>\r\n            <button class=\"btn btn-dark\" type=\"button\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1930, "\"", 1990, 3);
                WriteAttributeValue("", 1940, "location.href=\'", 1940, 15, true);
#nullable restore
#line 43 "C:\Users\nxjone\source\repos\NimbleWeb\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1955, Url.Action("Index", "SqlScripts"), 1955, 34, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1989, "\'", 1989, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Sql&nbsp;Scripts</button>\r\n            <button class=\"btn btn-dark\" type=\"button\"");
                BeginWriteAttribute("onclick", " onclick=\"", 2073, "\"", 2128, 3);
                WriteAttributeValue("", 2083, "location.href=\'", 2083, 15, true);
#nullable restore
#line 44 "C:\Users\nxjone\source\repos\NimbleWeb\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2098, Url.Action("Index", "Links"), 2098, 29, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2127, "\'", 2127, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Links</button>\r\n            <button class=\"btn btn-dark\" type=\"button\"");
                BeginWriteAttribute("onclick", " onclick=\"", 2200, "\"", 2253, 3);
                WriteAttributeValue("", 2210, "location.href=\'", 2210, 15, true);
#nullable restore
#line 45 "C:\Users\nxjone\source\repos\NimbleWeb\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2225, Url.Action("Index", "Bug"), 2225, 27, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2252, "\'", 2252, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Bugs</button>\r\n            <button class=\"btn btn-dark\" type=\"button\"");
                BeginWriteAttribute("onclick", " onclick=\"", 2324, "\"", 2384, 3);
                WriteAttributeValue("", 2334, "location.href=\'", 2334, 15, true);
#nullable restore
#line 46 "C:\Users\nxjone\source\repos\NimbleWeb\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2349, Url.Action("Index", "Automation"), 2349, 34, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2383, "\'", 2383, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Automation</button>\r\n            <button class=\"btn btn-dark\" type=\"button\"");
                BeginWriteAttribute("onclick", " onclick=\"", 2461, "\"", 2518, 3);
                WriteAttributeValue("", 2471, "location.href=\'", 2471, 15, true);
#nullable restore
#line 47 "C:\Users\nxjone\source\repos\NimbleWeb\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2486, Url.Action("Index", "Reports"), 2486, 31, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2517, "\'", 2517, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Reports</button>\r\n        </div>\r\n\r\n        <div class=\"col-3 d-none d-lg-block px-0\">\r\n            <form method=\"post\"");
                BeginWriteAttribute("action", " action=\"", 2639, "\"", 2678, 1);
#nullable restore
#line 51 "C:\Users\nxjone\source\repos\NimbleWeb\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2648, Url.Action("Index", "Search"), 2648, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" defaultbutton=""SubmitButton"" runat=""server"">
                <input asp-form=""query"" class=""form-control"" type=""text"" placeholder=""Search"" name=""Query"">
                <span asp-validation-for=""query""></span>
                <button id=""SubmitButton"" type=""submit"" style=""display:none;"">Test</button>
            </form>
        </div>

        <button class=""btn btn-dark mx-1 d-none d-md-block d-lg-block mr-2"" type=""button""");
                BeginWriteAttribute("onclick", " onclick=\"", 3114, "\"", 3171, 3);
                WriteAttributeValue("", 3124, "location.href=\'", 3124, 15, true);
#nullable restore
#line 58 "C:\Users\nxjone\source\repos\NimbleWeb\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3139, Url.Action("Index", "Account"), 3139, 31, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3170, "\'", 3170, 1, true);
                EndWriteAttribute();
                WriteLiteral(@">
            <i class=""far fa-user-circle fa-2x""></i>
        </button>

    </nav>

    <div class=""col-12 d-sm-block d-md-block d-lg-none bg-dark pb-3"">
        <form>
            <input class=""form-control"" type=""text"" placeholder=""Search"">
        </form>
    </div>

    <div class=""col-12 bg-light"" style=""height: 875px;"">
        ");
#nullable restore
#line 71 "C:\Users\nxjone\source\repos\NimbleWeb\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n </html>");
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
