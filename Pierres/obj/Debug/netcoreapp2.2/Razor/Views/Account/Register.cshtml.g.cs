#pragma checksum "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b53ca61411fa22845e402cc51a400d4e7dd0226"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Register.cshtml", typeof(AspNetCore.Views_Account_Register))]
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
#line 5 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Account\Register.cshtml"
using Pierres.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b53ca61411fa22845e402cc51a400d4e7dd0226", @"/Views/Account/Register.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Account\Register.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(87, 40, true);
            WriteLiteral("\r\n<h2>Register a new user</h2>\r\n<hr />\r\n");
            EndContext();
#line 11 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Account\Register.cshtml"
 using (Html.BeginForm("Register", "Account", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(200, 33, false);
#line 13 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Account\Register.cshtml"
Write(Html.LabelFor(user => user.Email));

#line default
#line hidden
            EndContext();
            BeginContext(240, 34, false);
#line 14 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Account\Register.cshtml"
Write(Html.TextBoxFor(user=> user.Email));

#line default
#line hidden
            EndContext();
            BeginContext(283, 35, false);
#line 16 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Account\Register.cshtml"
Write(Html.LabelFor(user=> user.Password));

#line default
#line hidden
            EndContext();
            BeginContext(325, 38, false);
#line 17 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Account\Register.cshtml"
Write(Html.PasswordFor(user=> user.Password));

#line default
#line hidden
            EndContext();
            BeginContext(372, 42, false);
#line 19 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Account\Register.cshtml"
Write(Html.LabelFor(user=> user.ConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(421, 45, false);
#line 20 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Account\Register.cshtml"
Write(Html.PasswordFor(user=> user.ConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(470, 46, true);
            WriteLiteral("    <input type=\"submit\" value=\"Register\" />\r\n");
            EndContext();
#line 23 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Account\Register.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591