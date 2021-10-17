#pragma checksum "C:\Proyecto_EPS_SaludIntegral\SaludIntegral.App.FrontEnd\Pages\CreateDoctorAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c72eb761c6ef583b453dad897c8154c526d640c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SaludIntegral.App.Frontend.Pages.Pages_CreateDoctorAccount), @"mvc.1.0.razor-page", @"/Pages/CreateDoctorAccount.cshtml")]
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
#line 1 "C:\Proyecto_EPS_SaludIntegral\SaludIntegral.App.FrontEnd\Pages\_ViewImports.cshtml"
using SaludIntegral.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c72eb761c6ef583b453dad897c8154c526d640c7", @"/Pages/CreateDoctorAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd79676c395a17293a7991e10f450fd86c52d95b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CreateDoctorAccount : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Proyecto_EPS_SaludIntegral\SaludIntegral.App.FrontEnd\Pages\CreateDoctorAccount.cshtml"
  
    ViewData["Title"] = "Create Doctor Account page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Proyecto_EPS_SaludIntegral\SaludIntegral.App.FrontEnd\Pages\CreateDoctorAccount.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>Use this page to enter data Doctor´s Account.</p>\r\n<button>\r\n    <a href=\"/CreateAccount\">Go Back</a>\r\n</button>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c72eb761c6ef583b453dad897c8154c526d640c73596", async() => {
                WriteLiteral(@"
    <main>
        <style>
            .round_table {
                border-collapse: separate;
                border-spacing: 10;
                border: 2px solid grey;
                border-radius: 15px;
                -moz-border-radius: 20px;
                padding: 2px;
                -webkit-border-radius: 10px;
            }
        </style>
        <table class=""round_table"" align=""Center"">
            <tr>
                <td colspan=""3"" style=""text-align:center"">
                    <img src=""Images4Site/doctor.png"" width=""150"" alt=""Logo_Doctor"" height=""150""/>
                    <h5>
                        <p><p>¡Wellcome!</p></p>
                    </h5>
                    <p><p>Fill out the form to create an account in the system </p></p>
                </td>
            </tr>
            <tr>
                <td style=""text-align:left"">
                    <p><h6>Complete Name</h6>
                    <p><input type=""text"" size=""30"" maxlength=""30"" value=""--T");
                WriteLiteral(@"ype Your Complete Name--"" name=""Complete_Name""></p></p>
                </td>
                <td>
                </td>
                <td style=""text-align:left"">
                    <p><h6>ID Number</h6>
                    <p><input type=""text"" size=""30"" maxlength=""30"" value=""--Type Your ID Number--"" name=""ID_Number""></p></p>
                </td>
            </tr>
            <tr>
                <td style=""text-align:left"">
                    <p><h6>Gender</h6>
                    <p><input type=""text"" size=""30"" maxlength=""30"" value=""--Select Your Gender--"" name=""Gender""></p></p>
                </td>
                <td>  
                </td>
                <td style=""text-align:left"">
                    <p><h6>Movíl Number</h6>
                    <p><input type=""text"" size=""30"" maxlength=""30"" value=""--Type Your Movíl Number--"" name=""Movíl_Number""></p></p>
                </td>
            </tr>
            <tr>
                <td style=""text-align:left"">
                ");
                WriteLiteral(@"    <p><h6>Email</h6>
                    <p><input type=""text"" size=""30"" maxlength=""30"" value=""--Type Your Email--"" name=""Email""></p></p>
                </td>
                <td>  
                </td>
                <td style=""text-align:left"">
                    <p><h6>Age</h6>
                    <p><input type=""text"" size=""30"" maxlength=""30"" value=""--Select Your Date of Birth--"" name=""DOB""></p></p>
                </td>
            </tr>
            <tr>
                <td style=""text-align:left"">
                    <p><h6>Medic Number Registration</h6>
                    <p><input type=""text"" size=""30"" maxlength=""30"" value=""--Type Your Medic Number Registration--"" name=""MNR""></p></p>
                </td>
                <td>  
                </td>
                <td style=""text-align:left"">
                    <p><h6>Medic Specialization</h6>
                    <p><input type=""text"" size=""30"" maxlength=""30"" value=""--Type Your Medic Specialization--"" name=""Medic_Specializat");
                WriteLiteral(@"ion""></p></p>
                </td>
            </tr>
            <tr><td><p></p></td></tr>
            <tr>
                <td colspan=""3"" style=""text-align:center"">
                    <p>
                        <button>
                            <a>Create Account</a>
                        </button>
                    </p>
                    <p>
                        <a>¿Do you already have an account?</a>
                        <a ");
                WriteLiteral(" href=\"/Loggin\">¡Loggin Here!</a>\r\n                    </p>\r\n                </td>\r\n            </tr>\r\n            <tr><td><p></p></td></tr>\r\n        </table>\r\n    </main>\r\n");
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreateDoctorAccountModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CreateDoctorAccountModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CreateDoctorAccountModel>)PageContext?.ViewData;
        public CreateDoctorAccountModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
