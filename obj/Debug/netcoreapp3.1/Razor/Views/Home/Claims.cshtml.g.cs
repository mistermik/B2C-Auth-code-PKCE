#pragma checksum "C:\Users\mferrari\Source\repos\B2C\PKCE\1-5-B2C\Views\Home\Claims.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7638415cae05cdb6de05a60b7c060524a90fe27a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Claims), @"mvc.1.0.view", @"/Views/Home/Claims.cshtml")]
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
#line 1 "C:\Users\mferrari\Source\repos\B2C\PKCE\1-5-B2C\Views\_ViewImports.cshtml"
using WebApp_OpenIDConnect_DotNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mferrari\Source\repos\B2C\PKCE\1-5-B2C\Views\_ViewImports.cshtml"
using WebApp_OpenIDConnect_DotNet.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\mferrari\Source\repos\B2C\PKCE\1-5-B2C\Views\Home\Claims.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7638415cae05cdb6de05a60b7c060524a90fe27a", @"/Views/Home/Claims.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2df84d8f11b77f9341e7b96d5c0195e79262a1f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Claims : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mferrari\Source\repos\B2C\PKCE\1-5-B2C\Views\Home\Claims.cshtml"
  
	ViewData["Title"] = "Claims";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 6 "C:\Users\mferrari\Source\repos\B2C\PKCE\1-5-B2C\Views\Home\Claims.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h2>\r\n\r\n<table class=\"table-hover table-condensed table-striped\">\r\n\t<tr>\r\n\t\t<th>Claim Type</th>\r\n\t\t<th>Claim Value</th>\r\n\t</tr>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\mferrari\Source\repos\B2C\PKCE\1-5-B2C\Views\Home\Claims.cshtml"
     foreach (Claim claim in User.Claims)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<tr>\r\n\t\t\t<td>");
#nullable restore
#line 17 "C:\Users\mferrari\Source\repos\B2C\PKCE\1-5-B2C\Views\Home\Claims.cshtml"
           Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t<td>");
#nullable restore
#line 18 "C:\Users\mferrari\Source\repos\B2C\PKCE\1-5-B2C\Views\Home\Claims.cshtml"
           Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t</tr>\r\n");
#nullable restore
#line 20 "C:\Users\mferrari\Source\repos\B2C\PKCE\1-5-B2C\Views\Home\Claims.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
