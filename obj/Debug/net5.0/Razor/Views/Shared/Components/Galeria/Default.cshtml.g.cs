#pragma checksum "C:\Dev\Nova SIngular\Dev.Pavlos\TesteNovaSingular\Views\Shared\Components\Galeria\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a86df8bbf45f0ec904939725663b4ccd3ab5fb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Galeria_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Galeria/Default.cshtml")]
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
#line 1 "C:\Dev\Nova SIngular\Dev.Pavlos\TesteNovaSingular\Views\_ViewImports.cshtml"
using TesteNovaSingular;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\Nova SIngular\Dev.Pavlos\TesteNovaSingular\Views\_ViewImports.cshtml"
using TesteNovaSingular.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a86df8bbf45f0ec904939725663b4ccd3ab5fb8", @"/Views/Shared/Components/Galeria/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df2449a3009928bec8d55480371101e0deff8566", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Galeria_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GaleriaViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""scrollspy"" id=""galeria"">
    <div class=""container-fluid container-galeria"">
        <h1 class=""text-center fw-bold "">Galeria</h1>
        <h3 class=""text-center fw-normal"">Ultimas fotos dos eventos que ocorreram</h3>
        <div class=""row mt-4"">
");
#nullable restore
#line 8 "C:\Dev\Nova SIngular\Dev.Pavlos\TesteNovaSingular\Views\Shared\Components\Galeria\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"item col-sm-6 col-md-4 mb-3\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 441, "\"", 459, 1);
#nullable restore
#line 11 "C:\Dev\Nova SIngular\Dev.Pavlos\TesteNovaSingular\Views\Shared\Components\Galeria\Default.cshtml"
WriteAttributeValue("", 448, item.Image, 448, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fancybox\" data-fancybox=\"gallery1\">\r\n                        <img class=\"image-galeria\"");
            BeginWriteAttribute("src", " src=\"", 555, "\"", 572, 1);
#nullable restore
#line 12 "C:\Dev\Nova SIngular\Dev.Pavlos\TesteNovaSingular\Views\Shared\Components\Galeria\Default.cshtml"
WriteAttributeValue("", 561, item.Thumb, 561, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"nasa-space-apps-banner\">\r\n                    </a>\r\n                </div>\r\n");
#nullable restore
#line 15 "C:\Dev\Nova SIngular\Dev.Pavlos\TesteNovaSingular\Views\Shared\Components\Galeria\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GaleriaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
