#pragma checksum "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\tiendas\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c63f7d924e6b993aa125197e0fd3e86fc3908f4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_tiendas_Create), @"mvc.1.0.view", @"/Views/tiendas/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c63f7d924e6b993aa125197e0fd3e86fc3908f4f", @"/Views/tiendas/Create.cshtml")]
    public class Views_tiendas_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Entities.tienda>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\tiendas\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>tienda</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""nombre"" class=""control-label""></label>
                <input asp-for=""nombre"" class=""form-control"" />
                <span asp-validation-for=""nombre"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""direccion"" class=""control-label""></label>
                <input asp-for=""direccion"" class=""form-control"" />
                <span asp-validation-for=""direccion"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""telefono"" class=""control-label""></label>
                <input asp-for=""telefono"" class=""form-control"" />
                <span asp-validation-for=""telefono"" class=""text-danger""></span>");
            WriteLiteral(@"
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 42 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\tiendas\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Entities.tienda> Html { get; private set; }
    }
}
#pragma warning restore 1591
