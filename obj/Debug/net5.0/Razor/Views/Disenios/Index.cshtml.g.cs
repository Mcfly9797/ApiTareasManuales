#pragma checksum "C:\Users\villarealnah\Desktop\NuevaApiTareasManuales\ApiTareasManuales\Views\Disenios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6283622cee6fb540825bb06986186e342abb5f67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Disenios_Index), @"mvc.1.0.view", @"/Views/Disenios/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6283622cee6fb540825bb06986186e342abb5f67", @"/Views/Disenios/Index.cshtml")]
    public class Views_Disenios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApiTareasManuales.Models.Disenio>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\villarealnah\Desktop\NuevaApiTareasManuales\ApiTareasManuales\Views\Disenios\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\villarealnah\Desktop\NuevaApiTareasManuales\ApiTareasManuales\Views\Disenios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NombreDisenio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 22 "C:\Users\villarealnah\Desktop\NuevaApiTareasManuales\ApiTareasManuales\Views\Disenios\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 25 "C:\Users\villarealnah\Desktop\NuevaApiTareasManuales\ApiTareasManuales\Views\Disenios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NombreDisenio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 595, "\"", 625, 1);
#nullable restore
#line 28 "C:\Users\villarealnah\Desktop\NuevaApiTareasManuales\ApiTareasManuales\Views\Disenios\Index.cshtml"
WriteAttributeValue("", 610, item.IdDisenio, 610, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 678, "\"", 708, 1);
#nullable restore
#line 29 "C:\Users\villarealnah\Desktop\NuevaApiTareasManuales\ApiTareasManuales\Views\Disenios\Index.cshtml"
WriteAttributeValue("", 693, item.IdDisenio, 693, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 763, "\"", 793, 1);
#nullable restore
#line 30 "C:\Users\villarealnah\Desktop\NuevaApiTareasManuales\ApiTareasManuales\Views\Disenios\Index.cshtml"
WriteAttributeValue("", 778, item.IdDisenio, 778, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\villarealnah\Desktop\NuevaApiTareasManuales\ApiTareasManuales\Views\Disenios\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApiTareasManuales.Models.Disenio>> Html { get; private set; }
    }
}
#pragma warning restore 1591