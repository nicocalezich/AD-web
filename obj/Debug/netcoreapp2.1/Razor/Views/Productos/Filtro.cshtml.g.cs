#pragma checksum "C:\Users\nicol\source\repos\adweb2\ADweb\Views\Productos\Filtro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "298e87a6a80f1fd13dd237d5228eb6826b706677"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productos_Filtro), @"mvc.1.0.view", @"/Views/Productos/Filtro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Productos/Filtro.cshtml", typeof(AspNetCore.Views_Productos_Filtro))]
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
#line 1 "C:\Users\nicol\source\repos\adweb2\ADweb\Views\_ViewImports.cshtml"
using ADweb;

#line default
#line hidden
#line 2 "C:\Users\nicol\source\repos\adweb2\ADweb\Views\_ViewImports.cshtml"
using ADweb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"298e87a6a80f1fd13dd237d5228eb6826b706677", @"/Views/Productos/Filtro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87a88c77da4f063b33d1a5056ea81a9db7200bb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Productos_Filtro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ADweb.Models.Productos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onload", new global::Microsoft.AspNetCore.Html.HtmlString("hayProductos()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Filtro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("opcionesIndex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Productos/Filtro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\nicol\source\repos\adweb2\ADweb\Views\Productos\Filtro.cshtml"
  
    ViewData["Title"] = "Productos";

#line default
#line hidden
            BeginContext(91, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(93, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e4465f2487e42a1b895823af20a9a1b", async() => {
                BeginContext(123, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(132, 57, true);
            WriteLiteral("\r\n\r\n<h2>Mis productos <i class=\"fas fa-arrow-right\"></i> ");
            EndContext();
            BeginContext(190, 14, false);
#line 10 "C:\Users\nicol\source\repos\adweb2\ADweb\Views\Productos\Filtro.cshtml"
                                                Write(ViewBag.opcion);

#line default
#line hidden
            EndContext();
            BeginContext(204, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
            BeginContext(213, 530, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16196b0540724828ae8cff2cede4229a", async() => {
                BeginContext(282, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(288, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10b6895042694db78cec44331db53a19", async() => {
                    BeginContext(323, 35, true);
                    WriteLiteral("<i class=\"fas fa-plus\"></i> Agregar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(362, 96, true);
                WriteLiteral("\r\n\r\n    <div class=\"filtro\">\r\n        <select id=\"filtroOpciones\" name=\"selector\">\r\n            ");
                EndContext();
                BeginContext(458, 25, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eddd7e6e4b0c429badc6c8aca80c07f2", async() => {
                    BeginContext(466, 8, true);
                    WriteLiteral("Ver todo");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(483, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 18 "C:\Users\nicol\source\repos\adweb2\ADweb\Views\Productos\Filtro.cshtml"
             foreach (var item in ViewBag.tipos)
            {

#line default
#line hidden
                BeginContext(550, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(566, 22, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "232e7eadffb44060a0b18198f264c6d1", async() => {
                    BeginContext(575, 4, false);
#line 20 "C:\Users\nicol\source\repos\adweb2\ADweb\Views\Productos\Filtro.cshtml"
                   Write(item);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(588, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 21 "C:\Users\nicol\source\repos\adweb2\ADweb\Views\Productos\Filtro.cshtml"
            }

#line default
#line hidden
                BeginContext(605, 29, true);
                WriteLiteral("        </select>\r\n\r\n        ");
                EndContext();
                BeginContext(634, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9995b28891444b8490dc29be2737287c", async() => {
                    BeginContext(676, 37, true);
                    WriteLiteral("<i class=\"fas fa-search\"></i> Filtrar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(722, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(743, 535, true);
            WriteLiteral(@"
<table class=""table"" id=""tablaStock"">
    <thead>
        <tr>
            <th>
                <strong>Producto</strong>
            </th>
            <th>
                <strong>Tipo</strong>
            </th>
            <th>
                <strong>Precio</strong>
            </th>
            <th>
                <strong>Stock</strong>
            </th>
            <th>
                <strong>Cantidad disponible</strong>
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 49 "C:\Users\nicol\source\repos\adweb2\ADweb\Views\Productos\Filtro.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1327, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1388, 43, false);
#line 53 "C:\Users\nicol\source\repos\adweb2\ADweb\Views\Productos\Filtro.cshtml"
               Write(Html.DisplayFor(modelItem => item.Producto));

#line default
#line hidden
            EndContext();
            BeginContext(1431, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1499, 39, false);
#line 56 "C:\Users\nicol\source\repos\adweb2\ADweb\Views\Productos\Filtro.cshtml"
               Write(Html.DisplayFor(modelItem => item.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(1538, 68, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    $");
            EndContext();
            BeginContext(1607, 49, false);
#line 59 "C:\Users\nicol\source\repos\adweb2\ADweb\Views\Productos\Filtro.cshtml"
                Write(Html.DisplayFor(modelItem => item.PrecioKgUnidad));

#line default
#line hidden
            EndContext();
            BeginContext(1656, 2, true);
            WriteLiteral(" /");
            EndContext();
            BeginContext(1659, 16, false);
#line 59 "C:\Users\nicol\source\repos\adweb2\ADweb\Views\Productos\Filtro.cshtml"
                                                                    Write(item.UnidadUsada);

#line default
#line hidden
            EndContext();
            BeginContext(1675, 49, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n\r\n");
            EndContext();
#line 63 "C:\Users\nicol\source\repos\adweb2\ADweb\Views\Productos\Filtro.cshtml"
                     if (item.CantidadDisponible >= 5)
                    {

#line default
#line hidden
            BeginContext(1803, 86, true);
            WriteLiteral("                        <i title=\"Hay stock\" id=\"HayStock\" class=\"fas fa-check\"></i>\r\n");
            EndContext();
#line 66 "C:\Users\nicol\source\repos\adweb2\ADweb\Views\Productos\Filtro.cshtml"
                    }

                    else if (item.CantidadDisponible > 0 && item.CantidadDisponible < 5)
                    {

#line default
#line hidden
            BeginContext(2027, 105, true);
            WriteLiteral("                        <i title=\"Bajo stock\" id=\"AlertaStock\" class=\"fas fa-exclamation-triangle\"></i>\r\n");
            EndContext();
#line 71 "C:\Users\nicol\source\repos\adweb2\ADweb\Views\Productos\Filtro.cshtml"
                    }

                    else
                    {

#line default
#line hidden
            BeginContext(2206, 91, true);
            WriteLiteral("                        <i title=\"No hay stock\" id=\"NoHayStock\" class=\"fas fa-times\"></i>\r\n");
            EndContext();
#line 76 "C:\Users\nicol\source\repos\adweb2\ADweb\Views\Productos\Filtro.cshtml"
                    }

#line default
#line hidden
            BeginContext(2320, 45, true);
            WriteLiteral("                </td>\r\n                <td>\r\n");
            EndContext();
#line 79 "C:\Users\nicol\source\repos\adweb2\ADweb\Views\Productos\Filtro.cshtml"
                     if (item.CantidadDisponible > 0)
                    {
                        if (item.UnidadUsada.Equals("Kg"))
                        {

#line default
#line hidden
            BeginContext(2530, 33, true);
            WriteLiteral("                            <div>");
            EndContext();
            BeginContext(2564, 53, false);
#line 83 "C:\Users\nicol\source\repos\adweb2\ADweb\Views\Productos\Filtro.cshtml"
                            Write(Html.DisplayFor(modelItem => item.CantidadDisponible));

#line default
#line hidden
            EndContext();
            BeginContext(2617, 11, true);
            WriteLiteral(" kg</div>\r\n");
            EndContext();
#line 84 "C:\Users\nicol\source\repos\adweb2\ADweb\Views\Productos\Filtro.cshtml"
                        }

                        else if (item.UnidadUsada.Equals("Unidad") && item.CantidadDisponible > 1)
                        {

#line default
#line hidden
            BeginContext(2784, 33, true);
            WriteLiteral("                            <div>");
            EndContext();
            BeginContext(2818, 53, false);
#line 88 "C:\Users\nicol\source\repos\adweb2\ADweb\Views\Productos\Filtro.cshtml"
                            Write(Html.DisplayFor(modelItem => item.CantidadDisponible));

#line default
#line hidden
            EndContext();
            BeginContext(2871, 17, true);
            WriteLiteral(" unidades</div>\r\n");
            EndContext();
#line 89 "C:\Users\nicol\source\repos\adweb2\ADweb\Views\Productos\Filtro.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2972, 33, true);
            WriteLiteral("                            <div>");
            EndContext();
            BeginContext(3006, 53, false);
#line 92 "C:\Users\nicol\source\repos\adweb2\ADweb\Views\Productos\Filtro.cshtml"
                            Write(Html.DisplayFor(modelItem => item.CantidadDisponible));

#line default
#line hidden
            EndContext();
            BeginContext(3059, 15, true);
            WriteLiteral(" unidad</div>\r\n");
            EndContext();
#line 93 "C:\Users\nicol\source\repos\adweb2\ADweb\Views\Productos\Filtro.cshtml"
                        }
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(3173, 44, true);
            WriteLiteral("                        <em>Sin stock</em>\r\n");
            EndContext();
#line 98 "C:\Users\nicol\source\repos\adweb2\ADweb\Views\Productos\Filtro.cshtml"
                    }

#line default
#line hidden
            BeginContext(3240, 65, true);
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3305, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7936ad7e60942f98ce2e8687a964db7", async() => {
                BeginContext(3350, 34, true);
                WriteLiteral("<i class=\"fas fa-edit\"></i> Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 101 "C:\Users\nicol\source\repos\adweb2\ADweb\Views\Productos\Filtro.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(3388, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(3412, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6828f04112447548a5a771a01b64182", async() => {
                BeginContext(3460, 43, true);
                WriteLiteral("<i class=\"fas fa-info-circle\"></i> Detalles");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 102 "C:\Users\nicol\source\repos\adweb2\ADweb\Views\Productos\Filtro.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(3507, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(3531, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47081c17d76e49dfb3cc14574ed0c71c", async() => {
                BeginContext(3578, 37, true);
                WriteLiteral("<i class=\"fas fa-trash\"></i> Eliminar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 103 "C:\Users\nicol\source\repos\adweb2\ADweb\Views\Productos\Filtro.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(3619, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 106 "C:\Users\nicol\source\repos\adweb2\ADweb\Views\Productos\Filtro.cshtml"
        }

#line default
#line hidden
            BeginContext(3674, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ADweb.Models.Productos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
