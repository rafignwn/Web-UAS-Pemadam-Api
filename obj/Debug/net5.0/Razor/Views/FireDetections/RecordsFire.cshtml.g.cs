#pragma checksum "C:\Web ASP\Web-UAS\Views\FireDetections\RecordsFire.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9d7be1a6645c96c6e1d4e0eb6c206725fccf81f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FireDetections_RecordsFire), @"mvc.1.0.view", @"/Views/FireDetections/RecordsFire.cshtml")]
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
#line 1 "C:\Web ASP\Web-UAS\Views\_ViewImports.cshtml"
using Web_UAS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Web ASP\Web-UAS\Views\_ViewImports.cshtml"
using Web_UAS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9d7be1a6645c96c6e1d4e0eb6c206725fccf81f", @"/Views/FireDetections/RecordsFire.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"371caa7fa2cb34072b1bf09ebd5207e612ad55be", @"/Views/_ViewImports.cshtml")]
    public class Views_FireDetections_RecordsFire : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Web_UAS.Models.Fire>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Web ASP\Web-UAS\Views\FireDetections\RecordsFire.cshtml"
  
    ViewData["Title"] = "Catatan Kebakaran";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container mt-4"">
    <div class=""row"">
        <div class=""col-3""></div>
        <div class=""col-6"">
            <h1 class="" text-center my-4 mb-2"">Catatan Saat Api Terdeteksi</h1>
            <table class=""table table-bordered mt-2"">
                <thead class=""table-dark"">
                    <tr>
                        <td>#</td>
                        <td>Jam Saat Api Terdeteksi</td>
                        <td>Tanggal Saat Api Terdeteksi</td>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 20 "C:\Web ASP\Web-UAS\Views\FireDetections\RecordsFire.cshtml"
                      int i = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Web ASP\Web-UAS\Views\FireDetections\RecordsFire.cshtml"
                     foreach (var data in Model)
                    { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 24 "C:\Web ASP\Web-UAS\Views\FireDetections\RecordsFire.cshtml"
                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>");
#nullable restore
#line 24 "C:\Web ASP\Web-UAS\Views\FireDetections\RecordsFire.cshtml"
                                     i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 25 "C:\Web ASP\Web-UAS\Views\FireDetections\RecordsFire.cshtml"
                       Write(Html.DisplayFor(modelItem => data.jam));

#line default
#line hidden
#nullable disable
            WriteLiteral(" WIB</td>\r\n                        <td>");
#nullable restore
#line 26 "C:\Web ASP\Web-UAS\Views\FireDetections\RecordsFire.cshtml"
                       Write(Html.DisplayFor(modelItem => data.tanggal));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 28 "C:\Web ASP\Web-UAS\Views\FireDetections\RecordsFire.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <div class=\"col-3\"></div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Web_UAS.Models.Fire>> Html { get; private set; }
    }
}
#pragma warning restore 1591
