#pragma checksum "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\cargoes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9728b2401e0c242fa2617c2829a436e04db23a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_cargoes_Details), @"mvc.1.0.view", @"/Views/cargoes/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9728b2401e0c242fa2617c2829a436e04db23a7", @"/Views/cargoes/Details.cshtml")]
    public class Views_cargoes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Entities.cargo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\cargoes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>cargo</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\cargoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\cargoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\cargoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.salario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\cargoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.salario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 643, "\"", 672, 1);
#nullable restore
#line 28 "D:\Users\Usuario\Documents\webProjects\global\Prueba_Global\WebApplication1\WebApplication1\Views\cargoes\Details.cshtml"
WriteAttributeValue("", 658, Model.cargoId, 658, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Entities.cargo> Html { get; private set; }
    }
}
#pragma warning restore 1591
