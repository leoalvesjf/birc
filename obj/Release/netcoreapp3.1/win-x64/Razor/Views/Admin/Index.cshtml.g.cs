#pragma checksum "C:\PROJETOS_RC\BIRC\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2031cfa88b959cae8cbc2ff10cde1760b2b5cc95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2031cfa88b959cae8cbc2ff10cde1760b2b5cc95", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"775e3ee02f4e380fa7dcac6f7588fa97b5b7eb71", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\PROJETOS_RC\BIRC\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3 class=""text-center"">Working Days</h3>
<hr />
<style>
    h3 {
        font-size: 21px;
        color: #808080;
    }

    .table {
        max-width: 50%;
        align-content: center;
    }

    .btn-custom {
        /* padding: 0px 15px 3px 2px;*/
        border-radius: 50px;
        text-align: center;
    }

    .btn-icon {
        padding: 8px;
        background: white;
    }
</style>


<table class=""table table-bordered table-sm table-hover "">
    <thead class=""text-center, thead-dark"">
        <tr class=""active text-center"">
            <th>
                Mês Atual
            </th>
            <th>
                Dias Util Mês
            </th>
            <th align=""center"">
                Dias util até o momento 
            </th>
        </tr>
    </thead>
    <tbody class=""text-center"">


        <tr>
            <td>
                ");
#nullable restore
#line 52 "C:\PROJETOS_RC\BIRC\Views\Admin\Index.cshtml"
           Write(DateTime.Now.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\PROJETOS_RC\BIRC\Views\Admin\Index.cshtml"
           Write(ViewBag.result);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\PROJETOS_RC\BIRC\Views\Admin\Index.cshtml"
           Write(ViewBag.Days);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n\r\n    </tbody>\r\n</table>\r\n\r\n\r\n");
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
