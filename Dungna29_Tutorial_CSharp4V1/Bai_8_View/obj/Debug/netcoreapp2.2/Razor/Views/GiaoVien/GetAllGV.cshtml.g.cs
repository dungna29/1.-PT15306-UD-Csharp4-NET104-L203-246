#pragma checksum "F:\Google Driver Dungna29FPT\8. Demo\Demo C#4\Dungna29_Tutorial_C#4V1\Dungna29_Tutorial_CSharp4V1\Bai_8_View\Views\GiaoVien\GetAllGV.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "184c59b9873505a7196cffce3f03865b401b2d78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GiaoVien_GetAllGV), @"mvc.1.0.view", @"/Views/GiaoVien/GetAllGV.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GiaoVien/GetAllGV.cshtml", typeof(AspNetCore.Views_GiaoVien_GetAllGV))]
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
#line 1 "F:\Google Driver Dungna29FPT\8. Demo\Demo C#4\Dungna29_Tutorial_C#4V1\Dungna29_Tutorial_CSharp4V1\Bai_8_View\Views\GiaoVien\GetAllGV.cshtml"
using Bai_8_View.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"184c59b9873505a7196cffce3f03865b401b2d78", @"/Views/GiaoVien/GetAllGV.cshtml")]
    public class Views_GiaoVien_GetAllGV : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\Google Driver Dungna29FPT\8. Demo\Demo C#4\Dungna29_Tutorial_C#4V1\Dungna29_Tutorial_CSharp4V1\Bai_8_View\Views\GiaoVien\GetAllGV.cshtml"
  
    Layout = "~/Views/Shared/_Layouts.cshtml";

#line default
#line hidden
            BeginContext(81, 484, true);
            WriteLiteral(@"


<p>Test Section</p>

<div class=""w3-container"">
    <h2>Danh sách giáo viên FPOLY</h2>
    <p>If you different hover colors, add w3-hover-<em>color</em> classes to each tr element:</p>

    <table class=""w3-table-all"">
        <thead>
            <tr class=""w3-light-grey w3-hover-red"">
                <th>Mã Giáo Viên</th>
                <th>Tên Giáo Viên</th>
                <th>Email</th>
                <th>Image</th>
            </tr>
        </thead>

");
            EndContext();
#line 24 "F:\Google Driver Dungna29FPT\8. Demo\Demo C#4\Dungna29_Tutorial_C#4V1\Dungna29_Tutorial_CSharp4V1\Bai_8_View\Views\GiaoVien\GetAllGV.cshtml"
         foreach (var x in new ServiceGiaoVien()._lstGiaoViens)
        {

#line default
#line hidden
            BeginContext(641, 61, true);
            WriteLiteral("            <tr class=\"w3-hover-green\">\r\n                <td>");
            EndContext();
            BeginContext(703, 6, false);
#line 27 "F:\Google Driver Dungna29FPT\8. Demo\Demo C#4\Dungna29_Tutorial_C#4V1\Dungna29_Tutorial_CSharp4V1\Bai_8_View\Views\GiaoVien\GetAllGV.cshtml"
               Write(x.MaGV);

#line default
#line hidden
            EndContext();
            BeginContext(709, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(737, 5, false);
#line 28 "F:\Google Driver Dungna29FPT\8. Demo\Demo C#4\Dungna29_Tutorial_C#4V1\Dungna29_Tutorial_CSharp4V1\Bai_8_View\Views\GiaoVien\GetAllGV.cshtml"
               Write(x.Ten);

#line default
#line hidden
            EndContext();
            BeginContext(742, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(770, 7, false);
#line 29 "F:\Google Driver Dungna29FPT\8. Demo\Demo C#4\Dungna29_Tutorial_C#4V1\Dungna29_Tutorial_CSharp4V1\Bai_8_View\Views\GiaoVien\GetAllGV.cshtml"
               Write(x.Email);

#line default
#line hidden
            EndContext();
            BeginContext(777, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(805, 7, false);
#line 30 "F:\Google Driver Dungna29FPT\8. Demo\Demo C#4\Dungna29_Tutorial_C#4V1\Dungna29_Tutorial_CSharp4V1\Bai_8_View\Views\GiaoVien\GetAllGV.cshtml"
               Write(x.Image);

#line default
#line hidden
            EndContext();
            BeginContext(812, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 32 "F:\Google Driver Dungna29FPT\8. Demo\Demo C#4\Dungna29_Tutorial_C#4V1\Dungna29_Tutorial_CSharp4V1\Bai_8_View\Views\GiaoVien\GetAllGV.cshtml"
        }

#line default
#line hidden
            BeginContext(849, 54, true);
            WriteLiteral("\r\n\r\n    </table>\r\n    <h1>Tổng số giáo viên hiện nay: ");
            EndContext();
            BeginContext(905, 41, false);
#line 36 "F:\Google Driver Dungna29FPT\8. Demo\Demo C#4\Dungna29_Tutorial_C#4V1\Dungna29_Tutorial_CSharp4V1\Bai_8_View\Views\GiaoVien\GetAllGV.cshtml"
                                Write(new ServiceGiaoVien()._lstGiaoViens.Count);

#line default
#line hidden
            EndContext();
            BeginContext(947, 19, true);
            WriteLiteral("</h1>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
