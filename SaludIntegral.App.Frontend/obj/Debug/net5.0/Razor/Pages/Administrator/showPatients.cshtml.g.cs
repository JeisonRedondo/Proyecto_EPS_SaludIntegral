#pragma checksum "C:\EPS_DJ\SaludIntegral.App\SaludIntegral.App.Frontend\Pages\Administrator\showPatients.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1874472e307a98df85288f6705cdc8488d17798"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SaludIntegral.App.Frontend.Pages.Administrator.Pages_Administrator_showPatients), @"mvc.1.0.razor-page", @"/Pages/Administrator/showPatients.cshtml")]
namespace SaludIntegral.App.Frontend.Pages.Administrator
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
#nullable restore
#line 2 "C:\EPS_DJ\SaludIntegral.App\SaludIntegral.App.Frontend\Pages\Administrator\showPatients.cshtml"
using SaludIntegral.App.Dominio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1874472e307a98df85288f6705cdc8488d17798", @"/Pages/Administrator/showPatients.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd79676c395a17293a7991e10f450fd86c52d95b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Administrator_showPatients : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./EditPatient", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Listado de pacientes</h1>\r\n<table class=\"table table-striped\">\r\n");
#nullable restore
#line 8 "C:\EPS_DJ\SaludIntegral.App\SaludIntegral.App.Frontend\Pages\Administrator\showPatients.cshtml"
     foreach(var paciente in Model.patients)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 11 "C:\EPS_DJ\SaludIntegral.App\SaludIntegral.App.Frontend\Pages\Administrator\showPatients.cshtml"
           Write(paciente.Names);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 12 "C:\EPS_DJ\SaludIntegral.App\SaludIntegral.App.Frontend\Pages\Administrator\showPatients.cshtml"
           Write(paciente.Identification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 13 "C:\EPS_DJ\SaludIntegral.App\SaludIntegral.App.Frontend\Pages\Administrator\showPatients.cshtml"
           Write(paciente.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 14 "C:\EPS_DJ\SaludIntegral.App\SaludIntegral.App.Frontend\Pages\Administrator\showPatients.cshtml"
           Write(paciente.EPS);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        </tr>\r\n         <tbody>\r\n");
#nullable restore
#line 18 "C:\EPS_DJ\SaludIntegral.App\SaludIntegral.App.Frontend\Pages\Administrator\showPatients.cshtml"
         foreach (var paciente in Model.pacientes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "C:\EPS_DJ\SaludIntegral.App\SaludIntegral.App.Frontend\Pages\Administrator\showPatients.cshtml"
               Write(paciente.Names);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\EPS_DJ\SaludIntegral.App\SaludIntegral.App.Frontend\Pages\Administrator\showPatients.cshtml"
               Write(paciente.Identification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\EPS_DJ\SaludIntegral.App\SaludIntegral.App.Frontend\Pages\Administrator\showPatients.cshtml"
               Write(paciente.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <!--<td><a class=\"btn btn-secondary\" asp-page=\"./Details1\" asp-route-id=\"");
#nullable restore
#line 24 "C:\EPS_DJ\SaludIntegral.App\SaludIntegral.App.Frontend\Pages\Administrator\showPatients.cshtml"
                                                                                    Write(paciente.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Detalle</a></td>-->\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1874472e307a98df85288f6705cdc8488d177986953", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\EPS_DJ\SaludIntegral.App\SaludIntegral.App.Frontend\Pages\Administrator\showPatients.cshtml"
                                                                            WriteLiteral(paciente.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 27 "C:\EPS_DJ\SaludIntegral.App\SaludIntegral.App.Frontend\Pages\Administrator\showPatients.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n");
#nullable restore
#line 29 "C:\EPS_DJ\SaludIntegral.App\SaludIntegral.App.Frontend\Pages\Administrator\showPatients.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SaludIntegral.App.Frontend.Pages.showPatientsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SaludIntegral.App.Frontend.Pages.showPatientsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SaludIntegral.App.Frontend.Pages.showPatientsModel>)PageContext?.ViewData;
        public SaludIntegral.App.Frontend.Pages.showPatientsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
