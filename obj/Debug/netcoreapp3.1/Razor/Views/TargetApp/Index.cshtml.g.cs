#pragma checksum "C:\Users\guclu\source\repos\CaseCoreApp\CaseCoreApp\Views\TargetApp\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33cef1d67d29f3f4b2151e42e12588614b04f3e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TargetApp_Index), @"mvc.1.0.view", @"/Views/TargetApp/Index.cshtml")]
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
#line 1 "C:\Users\guclu\source\repos\CaseCoreApp\CaseCoreApp\Views\_ViewImports.cshtml"
using CaseCoreApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\guclu\source\repos\CaseCoreApp\CaseCoreApp\Views\TargetApp\Index.cshtml"
using CaseCoreApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33cef1d67d29f3f4b2151e42e12588614b04f3e4", @"/Views/TargetApp/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23694572e465a0b57a537b83e8ad8f5949d71e43", @"/Views/_ViewImports.cshtml")]
    public class Views_TargetApp_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TargetApp>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\guclu\source\repos\CaseCoreApp\CaseCoreApp\Views\TargetApp\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_PageLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<table class=""table table-bordered"">
    <tr>
        <th>Id</th>
        <th>Kullanıcı</th>
        <th>Açıklama</th>
        <th>Url Adresi</th>
        <th>Interval</th>
        <th>Düzenle</th>
        <th>Sil</th>
        <th>Detaylar</th>
    </tr>
");
#nullable restore
#line 20 "C:\Users\guclu\source\repos\CaseCoreApp\CaseCoreApp\Views\TargetApp\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\guclu\source\repos\CaseCoreApp\CaseCoreApp\Views\TargetApp\Index.cshtml"
           Write(x.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\guclu\source\repos\CaseCoreApp\CaseCoreApp\Views\TargetApp\Index.cshtml"
           Write(x.User.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\guclu\source\repos\CaseCoreApp\CaseCoreApp\Views\TargetApp\Index.cshtml"
           Write(x.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\guclu\source\repos\CaseCoreApp\CaseCoreApp\Views\TargetApp\Index.cshtml"
           Write(x.url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\guclu\source\repos\CaseCoreApp\CaseCoreApp\Views\TargetApp\Index.cshtml"
           Write(x.interval);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 649, "\"", 682, 2);
            WriteAttributeValue("", 656, "/TargetApp/UrlDetail/", 656, 21, true);
#nullable restore
#line 28 "C:\Users\guclu\source\repos\CaseCoreApp\CaseCoreApp\Views\TargetApp\Index.cshtml"
WriteAttributeValue("", 677, x.id, 677, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 745, "\"", 778, 2);
            WriteAttributeValue("", 752, "/TargetApp/DeleteUrl/", 752, 21, true);
#nullable restore
#line 29 "C:\Users\guclu\source\repos\CaseCoreApp\CaseCoreApp\Views\TargetApp\Index.cshtml"
WriteAttributeValue("", 773, x.id, 773, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 835, "\"", 869, 2);
            WriteAttributeValue("", 842, "/TargetApp/UrlControl/", 842, 22, true);
#nullable restore
#line 30 "C:\Users\guclu\source\repos\CaseCoreApp\CaseCoreApp\Views\TargetApp\Index.cshtml"
WriteAttributeValue("", 864, x.id, 864, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Kontrol Et</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\guclu\source\repos\CaseCoreApp\CaseCoreApp\Views\TargetApp\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n<a href=\"/TargetApp/NewUrl\" class=\"btn btn-primary\">Yeni URL Ekle</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TargetApp>> Html { get; private set; }
    }
}
#pragma warning restore 1591
