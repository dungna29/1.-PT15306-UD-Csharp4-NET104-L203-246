#pragma checksum "F:\Google Driver Dungna29FPT\8. Demo\Demo C#4\Dungna29_Tutorial_C#4V1\Dungna29_Tutorial_CSharp4V1\Bai_8_View\Views\GiaoVien\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c4e04df4d9d73a5f1b7ed44b124399edcf41762"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GiaoVien_Index), @"mvc.1.0.view", @"/Views/GiaoVien/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GiaoVien/Index.cshtml", typeof(AspNetCore.Views_GiaoVien_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c4e04df4d9d73a5f1b7ed44b124399edcf41762", @"/Views/GiaoVien/Index.cshtml")]
    public class Views_GiaoVien_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\Google Driver Dungna29FPT\8. Demo\Demo C#4\Dungna29_Tutorial_C#4V1\Dungna29_Tutorial_CSharp4V1\Bai_8_View\Views\GiaoVien\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(58, 232, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c4e04df4d9d73a5f1b7ed44b124399edcf417623283", async() => {
                BeginContext(64, 219, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n    <style>\r\n        img {\r\n            float: left;\r\n            width: 70px;\r\n            height: 80px;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(290, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(292, 485, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c4e04df4d9d73a5f1b7ed44b124399edcf417624704", async() => {
                BeginContext(298, 49, true);
                WriteLiteral("\r\n<h2>Xin chào đây là View Index Giáo Viên</h2>\r\n");
                EndContext();
                BeginContext(396, 4, true);
                WriteLiteral("<img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 400, "\"", 435, 1);
#line 23 "F:\Google Driver Dungna29FPT\8. Demo\Demo C#4\Dungna29_Tutorial_C#4V1\Dungna29_Tutorial_CSharp4V1\Bai_8_View\Views\GiaoVien\Index.cshtml"
WriteAttributeValue("", 406, Model._lstGiaoViens[0].Image, 406, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(436, 69, true);
                WriteLiteral(" />\r\n<table>\r\n    <tr>\r\n        <td>Mã giáo viên: </td>\r\n        <td>");
                EndContext();
                BeginContext(506, 27, false);
#line 27 "F:\Google Driver Dungna29FPT\8. Demo\Demo C#4\Dungna29_Tutorial_C#4V1\Dungna29_Tutorial_CSharp4V1\Bai_8_View\Views\GiaoVien\Index.cshtml"
       Write(Model._lstGiaoViens[0].MaGV);

#line default
#line hidden
                EndContext();
                BeginContext(533, 75, true);
                WriteLiteral(" </td>\r\n    </tr>\r\n    <tr>\r\n        <td>Tên giáo viên: </td>\r\n        <td>");
                EndContext();
                BeginContext(609, 26, false);
#line 31 "F:\Google Driver Dungna29FPT\8. Demo\Demo C#4\Dungna29_Tutorial_C#4V1\Dungna29_Tutorial_CSharp4V1\Bai_8_View\Views\GiaoVien\Index.cshtml"
       Write(Model._lstGiaoViens[0].Ten);

#line default
#line hidden
                EndContext();
                BeginContext(635, 77, true);
                WriteLiteral(" </td>\r\n    </tr>\r\n    <tr>\r\n        <td>Email giáo viên: </td>\r\n        <td>");
                EndContext();
                BeginContext(713, 28, false);
#line 35 "F:\Google Driver Dungna29FPT\8. Demo\Demo C#4\Dungna29_Tutorial_C#4V1\Dungna29_Tutorial_CSharp4V1\Bai_8_View\Views\GiaoVien\Index.cshtml"
       Write(Model._lstGiaoViens[0].Email);

#line default
#line hidden
                EndContext();
                BeginContext(741, 29, true);
                WriteLiteral(" </td>\r\n    </tr>\r\n</table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(777, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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