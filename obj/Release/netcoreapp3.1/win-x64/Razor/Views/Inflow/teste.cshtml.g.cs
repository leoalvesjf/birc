#pragma checksum "C:\PROJETOS_RC\BIRC\Views\Inflow\teste.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82811a2a60ba1786ff87b835c5b29139869a0cc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inflow_teste), @"mvc.1.0.view", @"/Views/Inflow/teste.cshtml")]
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
#line 1 "C:\PROJETOS_RC\BIRC\Views\_ViewImports.cshtml"
using BIRC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\PROJETOS_RC\BIRC\Views\_ViewImports.cshtml"
using BIRC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82811a2a60ba1786ff87b835c5b29139869a0cc3", @"/Views/Inflow/teste.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"775e3ee02f4e380fa7dcac6f7588fa97b5b7eb71", @"/Views/_ViewImports.cshtml")]
    public class Views_Inflow_teste : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BIRC.Models.Entities.Inflow>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\PROJETOS_RC\BIRC\Views\Inflow\teste.cshtml"
  
    ViewData["Title"] = "Lista";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h1>Inflow</h1>



<div class=""row"">
    <div class=""col-md-12"">
        <table id=""myTable"" class=""table table-bordered table-striped"">

            <thead>
                <tr class=""text-center"">
                    <th>PRODUCT GROUPS</th>
                    <th>DATE IN</th>
                    <th>PRODUCT NUMBER</th>
                    <th>SERIAL NUMBER</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 26 "C:\PROJETOS_RC\BIRC\Views\Inflow\teste.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"text-center\">\r\n                        <td>");
#nullable restore
#line 29 "C:\PROJETOS_RC\BIRC\Views\Inflow\teste.cshtml"
                       Write(item.Family);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "C:\PROJETOS_RC\BIRC\Views\Inflow\teste.cshtml"
                       Write(item.DateIn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "C:\PROJETOS_RC\BIRC\Views\Inflow\teste.cshtml"
                       Write(item.Product);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "C:\PROJETOS_RC\BIRC\Views\Inflow\teste.cshtml"
                       Write(item.Serial);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 34 "C:\PROJETOS_RC\BIRC\Views\Inflow\teste.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n        \r\n               \r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BIRC.Models.Entities.Inflow>> Html { get; private set; }
    }
}
#pragma warning restore 1591