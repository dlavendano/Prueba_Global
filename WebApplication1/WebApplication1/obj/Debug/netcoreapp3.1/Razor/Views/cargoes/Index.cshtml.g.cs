#pragma checksum "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\cargoes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a7d479aa140cce502f65325d9efef3c5d427d70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_cargoes_Index), @"mvc.1.0.view", @"/Views/cargoes/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a7d479aa140cce502f65325d9efef3c5d427d70", @"/Views/cargoes/Index.cshtml")]
    public class Views_cargoes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication1.Entities.cargo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\cargoes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\cargoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\cargoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.salario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\cargoes\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\cargoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\cargoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.salario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 786, "\"", 814, 1);
#nullable restore
#line 34 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\cargoes\Index.cshtml"
WriteAttributeValue("", 801, item.cargoId, 801, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 867, "\"", 895, 1);
#nullable restore
#line 35 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\cargoes\Index.cshtml"
WriteAttributeValue("", 882, item.cargoId, 882, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 950, "\"", 978, 1);
#nullable restore
#line 36 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\cargoes\Index.cshtml"
WriteAttributeValue("", 965, item.cargoId, 965, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 39 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\cargoes\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication1.Entities.cargo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
