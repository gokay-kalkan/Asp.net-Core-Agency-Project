#pragma checksum "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\Agency\Agency.UI\Views\Shared\Components\About\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f65445a3983a2b10b00224a57e05a1a45e96bcb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_About_Default), @"mvc.1.0.view", @"/Views/Shared/Components/About/Default.cshtml")]
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
#line 1 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\Agency\Agency.UI\Views\_ViewImports.cshtml"
using Agency.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\Agency\Agency.UI\Views\_ViewImports.cshtml"
using Agency.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\Agency\Agency.UI\Views\_ViewImports.cshtml"
using EntityLayer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f65445a3983a2b10b00224a57e05a1a45e96bcb7", @"/Views/Shared/Components/About/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0b8e0418b01a63634e576577fb930514a7a3b70", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_About_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<About>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Custom Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<section id=\"about\" class=\"about-sec section-wrapper description\">\r\n    <div class=\"container\">\r\n");
#nullable restore
#line 5 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\Agency\Agency.UI\Views\Shared\Components\About\Default.cshtml"
         foreach (var item in Model)
        {

        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">
            <!-- Section Header -->
            <div class=""col-md-12 col-sm-12 col-xs-12 section-header wow fadeInDown"">
                <h2><span class=""highlight-text"">Hakkımızda</span></h2>

                <p class=""col-md-8 col-sm-10 col-xs-12 col-md-offset-2 col-sm-offset-1"">");
#nullable restore
#line 14 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\Agency\Agency.UI\Views\Shared\Components\About\Default.cshtml"
                                                                                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n           \r\n            <div class=\"col-md-2\"></div>\r\n            <div class=\"col-md-6 col-sm-6 col-xs-12 custom-sec-img wow fadeInDown\">\r\n                \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f65445a3983a2b10b00224a57e05a1a45e96bcb75046", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 721, "~/img/", 721, 6, true);
#nullable restore
#line 20 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\Agency\Agency.UI\Views\Shared\Components\About\Default.cshtml"
AddHtmlAttributeValue("", 727, item.Image, 727, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 24 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\Agency\Agency.UI\Views\Shared\Components\About\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<About>> Html { get; private set; }
    }
}
#pragma warning restore 1591
