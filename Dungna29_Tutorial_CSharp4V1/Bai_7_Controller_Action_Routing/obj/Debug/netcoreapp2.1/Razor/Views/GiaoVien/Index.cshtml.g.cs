#pragma checksum "F:\Google Driver Dungna29FPT\8. Demo\Demo C#4\Dungna29_Tutorial_C#4V1\Dungna29_Tutorial_CSharp4V1\Bai_7_Controller_Action_Routing\Views\GiaoVien\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0639e4e9e025020f644d61c124bce2dd63279bf"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0639e4e9e025020f644d61c124bce2dd63279bf", @"/Views/GiaoVien/Index.cshtml")]
    public class Views_GiaoVien_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bai_7_Controller_Action_Routing.Models.TestGiaoVien>
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
#line 2 "F:\Google Driver Dungna29FPT\8. Demo\Demo C#4\Dungna29_Tutorial_C#4V1\Dungna29_Tutorial_CSharp4V1\Bai_7_Controller_Action_Routing\Views\GiaoVien\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(87, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(116, 232, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cce029f747fd42d890b86bd07608bd53", async() => {
                BeginContext(122, 219, true);
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
            BeginContext(348, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(350, 493, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71eb44e239304215a308636040e56e95", async() => {
                BeginContext(356, 53, true);
                WriteLiteral("\r\n    <h2>Xin chào đây là View Index Giáo Viên</h2>\r\n");
                EndContext();
                BeginContext(462, 4, true);
                WriteLiteral("<img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 466, "\"", 501, 1);
#line 23 "F:\Google Driver Dungna29FPT\8. Demo\Demo C#4\Dungna29_Tutorial_C#4V1\Dungna29_Tutorial_CSharp4V1\Bai_7_Controller_Action_Routing\Views\GiaoVien\Index.cshtml"
WriteAttributeValue("", 472, Model._lstGiaoViens[0].Image, 472, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(502, 69, true);
                WriteLiteral(" />\r\n<table>\r\n    <tr>\r\n        <td>Mã giáo viên: </td>\r\n        <td>");
                EndContext();
                BeginContext(572, 27, false);
#line 27 "F:\Google Driver Dungna29FPT\8. Demo\Demo C#4\Dungna29_Tutorial_C#4V1\Dungna29_Tutorial_CSharp4V1\Bai_7_Controller_Action_Routing\Views\GiaoVien\Index.cshtml"
       Write(Model._lstGiaoViens[0].MaGV);

#line default
#line hidden
                EndContext();
                BeginContext(599, 75, true);
                WriteLiteral(" </td>\r\n    </tr>\r\n    <tr>\r\n        <td>Tên giáo viên: </td>\r\n        <td>");
                EndContext();
                BeginContext(675, 26, false);
#line 31 "F:\Google Driver Dungna29FPT\8. Demo\Demo C#4\Dungna29_Tutorial_C#4V1\Dungna29_Tutorial_CSharp4V1\Bai_7_Controller_Action_Routing\Views\GiaoVien\Index.cshtml"
       Write(Model._lstGiaoViens[0].Ten);

#line default
#line hidden
                EndContext();
                BeginContext(701, 77, true);
                WriteLiteral(" </td>\r\n    </tr>\r\n    <tr>\r\n        <td>Email giáo viên: </td>\r\n        <td>");
                EndContext();
                BeginContext(779, 28, false);
#line 35 "F:\Google Driver Dungna29FPT\8. Demo\Demo C#4\Dungna29_Tutorial_C#4V1\Dungna29_Tutorial_CSharp4V1\Bai_7_Controller_Action_Routing\Views\GiaoVien\Index.cshtml"
       Write(Model._lstGiaoViens[0].Email);

#line default
#line hidden
                EndContext();
                BeginContext(807, 29, true);
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
            BeginContext(843, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bai_7_Controller_Action_Routing.Models.TestGiaoVien> Html { get; private set; }
    }
}
#pragma warning restore 1591
