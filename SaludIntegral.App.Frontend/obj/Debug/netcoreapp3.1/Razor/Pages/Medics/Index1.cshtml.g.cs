#pragma checksum "C:\EPS_DJ\SaludIntegral.App\SaludIntegral.App.Frontend\Pages\Medics\Index1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f2e0182e418f431e5eebb369f0ccf5ffd38d0ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SaludIntegral.App.Frontend.Pages.Medics.Pages_Medics_Index1), @"mvc.1.0.razor-page", @"/Pages/Medics/Index1.cshtml")]
namespace SaludIntegral.App.Frontend.Pages.Medics
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
#line 1 "C:\EPS_DJ\SaludIntegral.App\SaludIntegral.App.Frontend\Pages\_ViewImports.cshtml"
using SaludIntegral.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f2e0182e418f431e5eebb369f0ccf5ffd38d0ba", @"/Pages/Medics/Index1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd79676c395a17293a7991e10f450fd86c52d95b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Medics_Index1 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Listado de Medicos</h1>\r\n<table class=\"table table-striped\">\r\n    <tr>\r\n        <th scope=\"col\">Nombre</th>\r\n        <th scope=\"col\">Email</th>\r\n        <th scope=\"col\">Especialidad</th>\r\n    </tr>\r\n");
#nullable restore
#line 12 "C:\EPS_DJ\SaludIntegral.App\SaludIntegral.App.Frontend\Pages\Medics\Index1.cshtml"
     foreach (var medico in Model.medicos)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 15 "C:\EPS_DJ\SaludIntegral.App\SaludIntegral.App.Frontend\Pages\Medics\Index1.cshtml"
           Write(medico.Names);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "C:\EPS_DJ\SaludIntegral.App\SaludIntegral.App.Frontend\Pages\Medics\Index1.cshtml"
           Write(medico.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "C:\EPS_DJ\SaludIntegral.App\SaludIntegral.App.Frontend\Pages\Medics\Index1.cshtml"
           Write(medico.Specialization);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 19 "C:\EPS_DJ\SaludIntegral.App\SaludIntegral.App.Frontend\Pages\Medics\Index1.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SaludIntegral.App.Frontend.Pages.Medics.Index1Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SaludIntegral.App.Frontend.Pages.Medics.Index1Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SaludIntegral.App.Frontend.Pages.Medics.Index1Model>)PageContext?.ViewData;
        public SaludIntegral.App.Frontend.Pages.Medics.Index1Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
