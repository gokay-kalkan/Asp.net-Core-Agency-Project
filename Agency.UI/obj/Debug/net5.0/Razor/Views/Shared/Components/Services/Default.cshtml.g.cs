#pragma checksum "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\Agency\Agency.UI\Views\Shared\Components\Services\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0049ec22c323aafae59ae58b51321652d0db914"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Services_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Services/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0049ec22c323aafae59ae58b51321652d0db914", @"/Views/Shared/Components/Services/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0b8e0418b01a63634e576577fb930514a7a3b70", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Services_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Services>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 5 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\Agency\Agency.UI\Views\Shared\Components\Services\Default.cshtml"
         foreach (var item in Model)
        {



#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-3 col-sm-3 col-xs-12 text-xs-center wow fadeInDown\" data-wow-delay=\".2s\" >\r\n            <div class=\"service-box\">\r\n                <div class=\"icon\">\r\n                    <i class=\"fa fa-support\"></i> <h3>");
#nullable restore
#line 12 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\Agency\Agency.UI\Views\Shared\Components\Services\Default.cshtml"
                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div>\r\n                <p>");
#nullable restore
#line 14 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\Agency\Agency.UI\Views\Shared\Components\Services\Default.cshtml"
              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 17 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\Agency\Agency.UI\Views\Shared\Components\Services\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Services>> Html { get; private set; }
    }
}
#pragma warning restore 1591
