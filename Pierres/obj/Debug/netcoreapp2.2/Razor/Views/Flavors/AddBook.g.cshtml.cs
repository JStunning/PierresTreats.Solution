#pragma checksum "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Flavors\AddBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad4a2f51898c54ad0291869076980fffcbd1053e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flavors_AddBook), @"mvc.1.0.view", @"/Views/Flavors/AddBook.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Flavors/AddBook.cshtml", typeof(AspNetCore.Views_Flavors_AddBook))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad4a2f51898c54ad0291869076980fffcbd1053e", @"/Views/Flavors/AddBook.cshtml")]
    public class Views_Flavors_AddBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pierres.Models.Flavor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Flavors\AddBook.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(62, 56, true);
            WriteLiteral("\r\n<h2>Add a treat</h2>\r\n\r\n<h4>Add a treat to this task: ");
            EndContext();
            BeginContext(119, 42, false);
#line 9 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Flavors\AddBook.cshtml"
                         Write(Html.DisplayFor(model => model.FlavorName));

#line default
#line hidden
            EndContext();
            BeginContext(161, 9, true);
            WriteLiteral("</h4>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Flavors\AddBook.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(205, 39, false);
#line 13 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Flavors\AddBook.cshtml"
Write(Html.HiddenFor(model => model.FlavorId));

#line default
#line hidden
            EndContext();
            BeginContext(253, 26, false);
#line 15 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Flavors\AddBook.cshtml"
Write(Html.Label("Select treat"));

#line default
#line hidden
            EndContext();
            BeginContext(286, 28, false);
#line 16 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Flavors\AddBook.cshtml"
Write(Html.DropDownList("TreatId"));

#line default
#line hidden
            EndContext();
            BeginContext(318, 57, true);
            WriteLiteral("    <input class=\"button\" type=\"submit\" value=\"Save\" />\r\n");
            EndContext();
#line 19 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Flavors\AddBook.cshtml"
}

#line default
#line hidden
            BeginContext(378, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(384, 40, false);
#line 21 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Flavors\AddBook.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(424, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pierres.Models.Flavor> Html { get; private set; }
    }
}
#pragma warning restore 1591
