#pragma checksum "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\empleado\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc6ee418de19760390e987c18e8d25e7d544ea6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_empleado_Index), @"mvc.1.0.view", @"/Views/empleado/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc6ee418de19760390e987c18e8d25e7d544ea6b", @"/Views/empleado/Index.cshtml")]
    public class Views_empleado_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication1.Entities.empleado>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\empleado\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\empleado\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\empleado\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.documento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\empleado\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.fechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\empleado\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.genero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\empleado\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.cargo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\empleado\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\empleado\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\empleado\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.documento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\empleado\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.fechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\empleado\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.genero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\empleado\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.cargo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1384, "\"", 1415, 1);
#nullable restore
#line 52 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\empleado\Index.cshtml"
WriteAttributeValue("", 1399, item.empleadoId, 1399, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1468, "\"", 1499, 1);
#nullable restore
#line 53 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\empleado\Index.cshtml"
WriteAttributeValue("", 1483, item.empleadoId, 1483, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1554, "\"", 1585, 1);
#nullable restore
#line 54 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\empleado\Index.cshtml"
WriteAttributeValue("", 1569, item.empleadoId, 1569, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 57 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\empleado\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication1.Entities.empleado>> Html { get; private set; }
    }
}
#pragma warning restore 1591
