#pragma checksum "C:\Web ASP\Web-UAS\Views\Home\CatatanApi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17cbe9052d9646805c66100e205b39f9949411b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CatatanApi), @"mvc.1.0.view", @"/Views/Home/CatatanApi.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17cbe9052d9646805c66100e205b39f9949411b7", @"/Views/Home/CatatanApi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"371caa7fa2cb34072b1bf09ebd5207e612ad55be", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CatatanApi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Web ASP\Web-UAS\Views\Home\CatatanApi.cshtml"
  
    ViewData["Title"] = "Catatan Api";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    $(document).ready(function(){
        setInterval(function(){getData()}, 2500);
        function getData(){
            jQuery.ajax({
                method : ""GET"",
                url : ""http://localhost/RecordsFire"",
                data : """",
                beforeSend : function(){},
                complete : function(){},
                success : function (data){
                    $(""body"").html(data);
                }
            });
        }
    });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
