#pragma checksum "C:\Users\binar\source\repos\Lab7_mel\Lab7_mel\Views\Home\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf7889c1c8d565f3350321d073e790795cccd6ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Edit), @"mvc.1.0.view", @"/Views/Home/Edit.cshtml")]
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
#line 1 "C:\Users\binar\source\repos\Lab7_mel\Lab7_mel\Views\_ViewImports.cshtml"
using Lab7_mel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\binar\source\repos\Lab7_mel\Lab7_mel\Views\_ViewImports.cshtml"
using Lab7_mel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf7889c1c8d565f3350321d073e790795cccd6ab", @"/Views/Home/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b5a53b719b36ced7c0c53712406d84c108b3b26", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Car>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\binar\source\repos\Lab7_mel\Lab7_mel\Views\Home\Edit.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf7889c1c8d565f3350321d073e790795cccd6ab3602", async() => {
                WriteLiteral("\r\n    <link href=\"C:\\Users\\binar\\source\\repos\\Lab7_mel\\Lab7_mel\\Content\\style.css\" rel=\"stylesheet\" />\r\n");
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
            WriteLiteral("\r\n<h4>Car</h4>\r\n<div style=\"border: 1px solid black; background-color: #F5F5DC;\">\r\n");
#nullable restore
#line 10 "C:\Users\binar\source\repos\Lab7_mel\Lab7_mel\Views\Home\Edit.cshtml"
     using (Html.BeginForm("Edit", "Home"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"dataBox\">\r\n            <label>ID </label><br />\r\n            ");
#nullable restore
#line 14 "C:\Users\binar\source\repos\Lab7_mel\Lab7_mel\Views\Home\Edit.cshtml"
       Write(Html.DisplayFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 15 "C:\Users\binar\source\repos\Lab7_mel\Lab7_mel\Views\Home\Edit.cshtml"
       Write(Html.HiddenFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n        <div class=\"dataBox\">\r\n            <label>Название модели </label><br />\r\n            ");
#nullable restore
#line 20 "C:\Users\binar\source\repos\Lab7_mel\Lab7_mel\Views\Home\Edit.cshtml"
       Write(Html.TextBoxFor(m => m.Name, new { @class = "text-box" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"dataBox\">\r\n            <label>Год выпуска</label><br />\r\n            ");
#nullable restore
#line 24 "C:\Users\binar\source\repos\Lab7_mel\Lab7_mel\Views\Home\Edit.cshtml"
       Write(Html.TextBoxFor(m => m.Year, "2020", new
            {
                type = "number",
                @class =
           "text-box"
            }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"dataBox\">\r\n            <label>Стоимость</label><br />\r\n            ");
#nullable restore
#line 33 "C:\Users\binar\source\repos\Lab7_mel\Lab7_mel\Views\Home\Edit.cshtml"
       Write(Html.TextBoxFor(m => m.Price, "1000000", new
            {
                type = "number",
                @class =
           "text-box"
            }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"dataBox\">\r\n            <label>Страна</label><br />\r\n            ");
#nullable restore
#line 42 "C:\Users\binar\source\repos\Lab7_mel\Lab7_mel\Views\Home\Edit.cshtml"
       Write(Html.DropDownListFor(m => m.GeneratorID, (SelectList)ViewBag.gener));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"dataBox\">\r\n            <input type=\"submit\" value=\"Сохранить\" />\r\n        </div>\r\n");
#nullable restore
#line 48 "C:\Users\binar\source\repos\Lab7_mel\Lab7_mel\Views\Home\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf7889c1c8d565f3350321d073e790795cccd6ab7646", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Car> Html { get; private set; }
    }
}
#pragma warning restore 1591
