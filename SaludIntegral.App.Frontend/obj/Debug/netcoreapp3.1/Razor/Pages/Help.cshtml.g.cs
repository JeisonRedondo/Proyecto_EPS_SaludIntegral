#pragma checksum "C:\Proyecto_EPS_SaludIntegral\SaludIntegral.App.Frontend\Pages\Help.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1fce254a7dc55e0fc0e217c108467ba71861db6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SaludIntegral.App.Frontend.Pages.Pages_Help), @"mvc.1.0.razor-page", @"/Pages/Help.cshtml")]
namespace SaludIntegral.App.Frontend.Pages
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
#line 1 "C:\Proyecto_EPS_SaludIntegral\SaludIntegral.App.Frontend\Pages\_ViewImports.cshtml"
using SaludIntegral.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1fce254a7dc55e0fc0e217c108467ba71861db6", @"/Pages/Help.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd79676c395a17293a7991e10f450fd86c52d95b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Help : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Proyecto_EPS_SaludIntegral\SaludIntegral.App.Frontend\Pages\Help.cshtml"
  
    ViewData["Title"] = "Help";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""text-center"">
    <h2>Have questions?</h2>
    <br>
    <h3>Check our FAQ section<h3>
    <br>
    <div class=""container-fluid text-left"">
        <details>
        <summary class=""padding-bottom-lg"" style=""font-family: 'Montserrat', sans-serif; font-weight: 300;"">How can I access to my admin panel?</summary>
        <p style=""font-family: 'Montserrat', sans-serif; font-size: 14px; font-weight: 300;"">You can click on the button ""Login/Signup"".
            Then you enter your login information and access.
        </p>
    </details>
    <details>
        <summary class=""padding-bottom-lg"" style=""font-family: 'Montserrat', sans-serif; font-weight: 300;"">How can I create a new account?</summary>
        <p style=""font-family: 'Montserrat', sans-serif; font-size: 14px; font-weight: 300;"">You can click on the button ""Login/Signup"".
            Then click on text ""Don't have an account?"".
            Enter your information and that's all.
        </p>
    </details>
    <details>
   ");
            WriteLiteral(@"     <summary class=""padding-bottom-lg"" style=""font-family: 'Montserrat', sans-serif; font-weight: 300;"">Can I confirm my appointments from admin panel?</summary>
        <p style=""font-family: 'Montserrat', sans-serif; font-size: 14px; font-weight: 300;"">
            Yes. You only have to navigate from sidebar and click on confirm appointment option.
            Then you can confirm or cancel the appointment if it's possible.
        </p>
    </details>
    <details>
        <summary class=""padding-bottom-lg"" style=""font-family: 'Montserrat', sans-serif; font-weight: 300;"">What are my entrance credentials?</summary>
        <p style=""font-family: 'Montserrat', sans-serif; font-size: 14px; font-weight: 300;"">
            To login you have to know your email and the password you set when yo created the account.
        </p>
    </details>
    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SaludIntegral.App.Frontend.Pages.HelpModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SaludIntegral.App.Frontend.Pages.HelpModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SaludIntegral.App.Frontend.Pages.HelpModel>)PageContext?.ViewData;
        public SaludIntegral.App.Frontend.Pages.HelpModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591