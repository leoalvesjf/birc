#pragma checksum "C:\PROJETOS_RC\BIRC\Views\SpareParts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bef72a77e2203c69945f80eaa21930a6d9b4f66b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SpareParts_Index), @"mvc.1.0.view", @"/Views/SpareParts/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bef72a77e2203c69945f80eaa21930a6d9b4f66b", @"/Views/SpareParts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"775e3ee02f4e380fa7dcac6f7588fa97b5b7eb71", @"/Views/_ViewImports.cshtml")]
    public class Views_SpareParts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BIRC.Models.Entities.SpareParts>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SpareMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SpareParts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning fas fa-minus"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#exampleModalCenter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("Edit(this,\'minus\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary fas fa-plus"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("Edit(this,\'plus\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\PROJETOS_RC\BIRC\Views\SpareParts\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"">
<link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.6.3/css/all.css"" integrity=""sha384-UHRtZLI+pbxtHCWp1t77Bi1L4ZtiqrqD80Kn4Z8NTSRyMA2Fd33n5dQ8lWUE00s/"" crossorigin=""anonymous"">

<h3 style=""opacity:0,4; color:#808080"" class=""text-center"">List of Wear Parts - Stations</h3>
<hr />




<div style=""display:inline-block"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bef72a77e2203c69945f80eaa21930a6d9b4f66b7924", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bef72a77e2203c69945f80eaa21930a6d9b4f66b9378", async() => {
                WriteLiteral("Insert a new item");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n</div>\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<div id=\"messageStatus\" class=\"alert alert-success\" role=\"alert\" style=\"display: none;\" messageAlert>\r\n    <span message></span>\r\n</div>\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<hr />\r\n\r\n<table border=\"1\" class=\"table table-sm table-hover border\">\r\n    <thead");
            BeginWriteAttribute("id", " id=\"", 2304, "\"", 2309, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <tr class=\"text-center  bg-primary\" style=\"color:white\">\r\n            <th border>\r\n                ");
#nullable restore
#line 66 "C:\PROJETOS_RC\BIRC\Views\SpareParts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PartNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 69 "C:\PROJETOS_RC\BIRC\Views\SpareParts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 72 "C:\PROJETOS_RC\BIRC\Views\SpareParts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 75 "C:\PROJETOS_RC\BIRC\Views\SpareParts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 78 "C:\PROJETOS_RC\BIRC\Views\SpareParts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DtIn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 81 "C:\PROJETOS_RC\BIRC\Views\SpareParts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PurchaseOrder));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>Actions</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 87 "C:\PROJETOS_RC\BIRC\Views\SpareParts\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"text-center\">\r\n                <td>\r\n                    ");
#nullable restore
#line 91 "C:\PROJETOS_RC\BIRC\Views\SpareParts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PartNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 94 "C:\PROJETOS_RC\BIRC\Views\SpareParts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td");
            BeginWriteAttribute("item-id", " item-id=\"", 3397, "\"", 3415, 1);
#nullable restore
#line 96 "C:\PROJETOS_RC\BIRC\Views\SpareParts\Index.cshtml"
WriteAttributeValue("", 3407, item.Id, 3407, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 97 "C:\PROJETOS_RC\BIRC\Views\SpareParts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 100 "C:\PROJETOS_RC\BIRC\Views\SpareParts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 103 "C:\PROJETOS_RC\BIRC\Views\SpareParts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DtIn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 106 "C:\PROJETOS_RC\BIRC\Views\SpareParts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PurchaseOrder));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td hidden>\r\n                    ");
#nullable restore
#line 109 "C:\PROJETOS_RC\BIRC\Views\SpareParts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bef72a77e2203c69945f80eaa21930a6d9b4f66b15846", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 112 "C:\PROJETOS_RC\BIRC\Views\SpareParts\Index.cshtml"
                                                                                                                                                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bef72a77e2203c69945f80eaa21930a6d9b4f66b18450", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 113 "C:\PROJETOS_RC\BIRC\Views\SpareParts\Index.cshtml"
                                                                                                                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 117 "C:\PROJETOS_RC\BIRC\Views\SpareParts\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
#nullable restore
#line 121 "C:\PROJETOS_RC\BIRC\Views\SpareParts\Index.cshtml"
 using (Html.BeginForm("EditItem", "SpareParts", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <!-- Modal -->
    <div class=""modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLongTitle"">Quantity Update</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <input id=""value"" type=""text"" name=""value"" class=""form-control"" hidden />
                    <input id=""typeedtion"" type=""text"" class=""form-control"" hidden />

                    <div class=""form-group"" hidden>
                        <label class=""control-label"">Id</label>
                        <input id=""id"" type=""te");
            WriteLiteral(@"xt"" name=""id"" class=""form-control"" />
                    </div>

                    <div class=""form-group"">
                        <label class=""control-label"">PartNumber</label>
                        <input id=""partNumber"" type=""text"" name=""partNumber"" class=""form-control""  />
                    </div>

                    <div class=""form-group"">
                        <label class=""control-label"">Description</label>
                        <input id=""description"" type=""text"" name=""description"" class=""form-control""  />
                    </div>

                    <div class=""form-group col-md-4"">

                        <label for=""inputvalue"">Quantity</label>
                        <input name=""quantity"" type=""number"" class=""form-control"" id=""quantity"" value=""0"" max=""1000"" min=""0"">
                    </div>

                    <div class=""form-group"">
                        <label class=""control-label"">Purchase Order</label>
                        <input id=""po"" type=""");
            WriteLiteral(@"text"" name=""po"" class=""form-control"" >
                    </div>

                    <div class=""form-group"">
                        <label class=""control-label"">Location</label>
                        <input id=""location"" type=""text"" name=""location"" class=""form-control"" readonly />
                    </div>

                   <div class=""form-group"">
                        <label class=""control-label"">dtIn</label>
                        <input id=""dtIn"" type=""text"" name=""dtIn"" class=""form-control""  />
                    </div>


                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button id=""btnSave"" type=""button"" onclick=""SaveElement()"" class=""btn btn-primary"">Save</button>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 182 "C:\PROJETOS_RC\BIRC\Views\SpareParts\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    function Edit(e, typeEdtion) {
        var line = $(e).closest(""tr"");
        console.log(line)
        var partNumber = line.find(""td:eq(0)"").text().trim();
        var description = line.find(""td:eq(1)"").text().trim();
        var quantity = line.find(""td:eq(2)"").text().trim();
        var location = line.find(""td:eq(3)"").text().trim();
        var id = line.find(""td:eq(6)"").text().trim();
        var value = line.find(""td:eq(2)"").text().trim();
        var po = line.find(""td:eq(5)"").text().trim();
        var dtIn = line.find(""td:eq(4)"").text().trim();

        $(""#partNumber"").val(partNumber);
        $(""#description"").val(description);
        $(""#quantity"").val(0);
        $(""#location"").val(location);
        $(""#po"").val(po);
        $(""#typeedtion"").val(typeEdtion);
        $(""#id"").val(id);
        $(""#value"").val(value);
        $(""#dtIn"").val(dtIn);
    }

    function SaveElement() {

        let data = CreateElement();
        let url = ""/SpareParts/Edit");
            WriteLiteral(@"Item"";
        console.log(data);
        let qtyFormated = 0;
        if (data.TypeEdtion === ""minus"")
            qtyFormated = parseInt(data.Value) - parseInt(data.Quantity);
        else
            qtyFormated = parseInt(data.Value) + parseInt(data.Quantity);


        $.post(url, data, function (resp) {
            let itemId = ""[item-id="" + data.Id + ""]"";
            $(itemId).html(qtyFormated);
            $('[message]').html(""Successfully updated"");
            $('[messageAlert]').addClass(""show"");
            $('.modal').modal('hide');
            $('#messageStatus').show();
            setTimeout(function () {
                $('#messageStatus').hide();
            }, 3500);
        }).fail(function (error) {
            $('[messageAlert]').removeClass(""alert-success"").addClass(""alert-warning"").addClass(""show"");
            $('[message]').html(""Error - Call to ADMIN"" + error.responseText)
            $('#messageStatus').show();
         //   setTimeout(function () {
        ");
            WriteLiteral(@" //   $('#messageStatus').hide();
         //   }, 3500);
        });
    }

    function CreateElement() {

        return {
            PartNumber: $(""#partNumber"").val(),
            Description: $(""#description"").val(),
            Quantity: $(""#quantity"").val(),
            Location: $(""#location"").val(),
            Id: $(""#id"").val(),
            Value: $(""#value"").val(),
            Po: $(""#po"").val(),
            TypeEdtion: $(""#typeedtion"").val(),
            DtIn: $(""#dtIn"").val()
            
        };
    }
</script>



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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BIRC.Models.Entities.SpareParts>> Html { get; private set; }
    }
}
#pragma warning restore 1591
