#pragma checksum "F:\Csharp projects\DTV\DTV App\DTV App\Views\Administration\Admindex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "202060a142a1de9cd7507e537de2f7dc10428bb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administration_Admindex), @"mvc.1.0.view", @"/Views/Administration/Admindex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administration/Admindex.cshtml", typeof(AspNetCore.Views_Administration_Admindex))]
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
#line 1 "F:\Csharp projects\DTV\DTV App\DTV App\Views\_ViewImports.cshtml"
using DTV_App;

#line default
#line hidden
#line 2 "F:\Csharp projects\DTV\DTV App\DTV App\Views\_ViewImports.cshtml"
using DTV_App.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"202060a142a1de9cd7507e537de2f7dc10428bb2", @"/Views/Administration/Admindex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53e492dd68320458757fd065f0105020740affff", @"/Views/_ViewImports.cshtml")]
    public class Views_Administration_Admindex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DTV_App.Models.ViewModels.LoginAdminVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\Csharp projects\DTV\DTV App\DTV App\Views\Administration\Admindex.cshtml"
  
    ViewData["Title"] = "Admindex";
    Layout = "~/Views/Administration/AdminLayout.cshtml";
    

#line default
#line hidden
            BeginContext(158, 18, true);
            WriteLiteral("\r\n<h2>Siema Admin ");
            EndContext();
            BeginContext(177, 8, false);
#line 9 "F:\Csharp projects\DTV\DTV App\DTV App\Views\Administration\Admindex.cshtml"
           Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(185, 11, true);
            WriteLiteral("  </h2>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DTV_App.Models.ViewModels.LoginAdminVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
