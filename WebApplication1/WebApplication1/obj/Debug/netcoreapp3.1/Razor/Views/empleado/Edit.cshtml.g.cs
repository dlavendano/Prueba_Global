#pragma checksum "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\empleado\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a318b2c8e84e9a27739dc716c72a18c291fc9704"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_empleado_Edit), @"mvc.1.0.view", @"/Views/empleado/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a318b2c8e84e9a27739dc716c72a18c291fc9704", @"/Views/empleado/Edit.cshtml")]
    public class Views_empleado_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Entities.empleado>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\empleado\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>empleado</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""empleadoId"" />
            <div class=""form-group"">
                <label asp-for=""nombre"" class=""control-label""></label>
                <input asp-for=""nombre"" class=""form-control"" />
                <span asp-validation-for=""nombre"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""documento"" class=""control-label""></label>
                <input asp-for=""documento"" class=""form-control"" />
                <span asp-validation-for=""documento"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""fechaNacimiento"" class=""control-label""></label>
                <input asp-for=""fechaNacimiento"" class=""form-control"" />
         ");
            WriteLiteral(@"       <span asp-validation-for=""fechaNacimiento"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""genero"" class=""control-label""></label>
                <input asp-for=""genero"" class=""form-control"" />
                <span asp-validation-for=""genero"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""cargo"" class=""control-label""></label>
                <input asp-for=""cargo"" class=""form-control"" />
                <span asp-validation-for=""cargo"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
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
#line 53 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\empleado\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Entities.empleado> Html { get; private set; }
    }
}
#pragma warning restore 1591