#pragma checksum "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e07b57425033f63ca8e50d1a981a8583b6e04093"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Test_Task.Pages.MyForm.Pages_MyForm_Index), @"mvc.1.0.razor-page", @"/Pages/MyForm/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/MyForm/Index.cshtml", typeof(Test_Task.Pages.MyForm.Pages_MyForm_Index), null)]
namespace Test_Task.Pages.MyForm
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\_ViewImports.cshtml"
using Test_Task;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e07b57425033f63ca8e50d1a981a8583b6e04093", @"/Pages/MyForm/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02c96cfba360596714b6aa7fcbb9578db10150bb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MyForm_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(92, 36, true);
            WriteLiteral("\r\n<h2>Общий список</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(128, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2acc5e7f88974bd889071f52b1ccc398", async() => {
                BeginContext(149, 18, true);
                WriteLiteral("Новое тестирование");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(171, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(264, 48, false);
#line 17 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.User[0].Name));

#line default
#line hidden
            EndContext();
            BeginContext(312, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(368, 46, false);
#line 20 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.User[0].Q1));

#line default
#line hidden
            EndContext();
            BeginContext(414, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(470, 46, false);
#line 23 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.User[0].Q2));

#line default
#line hidden
            EndContext();
            BeginContext(516, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(572, 46, false);
#line 26 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.User[0].Q3));

#line default
#line hidden
            EndContext();
            BeginContext(618, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(674, 46, false);
#line 29 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.User[0].Q4));

#line default
#line hidden
            EndContext();
            BeginContext(720, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(776, 46, false);
#line 32 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.User[0].Q5));

#line default
#line hidden
            EndContext();
            BeginContext(822, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(878, 46, false);
#line 35 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.User[0].Q6));

#line default
#line hidden
            EndContext();
            BeginContext(924, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(980, 46, false);
#line 38 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.User[0].Q7));

#line default
#line hidden
            EndContext();
            BeginContext(1026, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1082, 46, false);
#line 41 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.User[0].Q8));

#line default
#line hidden
            EndContext();
            BeginContext(1128, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1184, 46, false);
#line 44 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.User[0].Q9));

#line default
#line hidden
            EndContext();
            BeginContext(1230, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1286, 47, false);
#line 47 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.User[0].Q10));

#line default
#line hidden
            EndContext();
            BeginContext(1333, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1389, 47, false);
#line 50 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.User[0].Sum));

#line default
#line hidden
            EndContext();
            BeginContext(1436, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 56 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
 foreach (var item in Model.User) {

#line default
#line hidden
            BeginContext(1559, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1608, 39, false);
#line 59 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1647, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1703, 37, false);
#line 62 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Q1));

#line default
#line hidden
            EndContext();
            BeginContext(1740, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1796, 37, false);
#line 65 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Q2));

#line default
#line hidden
            EndContext();
            BeginContext(1833, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1889, 37, false);
#line 68 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Q3));

#line default
#line hidden
            EndContext();
            BeginContext(1926, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1982, 37, false);
#line 71 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Q4));

#line default
#line hidden
            EndContext();
            BeginContext(2019, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2075, 37, false);
#line 74 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Q5));

#line default
#line hidden
            EndContext();
            BeginContext(2112, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2168, 37, false);
#line 77 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Q6));

#line default
#line hidden
            EndContext();
            BeginContext(2205, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2261, 37, false);
#line 80 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Q7));

#line default
#line hidden
            EndContext();
            BeginContext(2298, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2354, 37, false);
#line 83 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Q8));

#line default
#line hidden
            EndContext();
            BeginContext(2391, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2447, 37, false);
#line 86 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Q9));

#line default
#line hidden
            EndContext();
            BeginContext(2484, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2540, 38, false);
#line 89 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Q10));

#line default
#line hidden
            EndContext();
            BeginContext(2578, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2634, 38, false);
#line 92 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Sum));

#line default
#line hidden
            EndContext();
            BeginContext(2672, 43, true);
            WriteLiteral(" /24\r\n            </td>\r\n            <td>\r\n");
            EndContext();
            BeginContext(2871, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2887, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1830ca7450fd48d085586aa441919d8a", async() => {
                BeginContext(2934, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 97 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
                                         WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2944, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 100 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2983, 129, true);
            WriteLiteral("\r\n        <tr>\r\n            <td>\r\n                Средний балл по вопросам\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3113, 16, false);
#line 107 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Model.average[0]);

#line default
#line hidden
            EndContext();
            BeginContext(3129, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3185, 16, false);
#line 110 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Model.average[1]);

#line default
#line hidden
            EndContext();
            BeginContext(3201, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3257, 16, false);
#line 113 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Model.average[2]);

#line default
#line hidden
            EndContext();
            BeginContext(3273, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3329, 16, false);
#line 116 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Model.average[3]);

#line default
#line hidden
            EndContext();
            BeginContext(3345, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3401, 16, false);
#line 119 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Model.average[4]);

#line default
#line hidden
            EndContext();
            BeginContext(3417, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3473, 16, false);
#line 122 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Model.average[5]);

#line default
#line hidden
            EndContext();
            BeginContext(3489, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3545, 16, false);
#line 125 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Model.average[6]);

#line default
#line hidden
            EndContext();
            BeginContext(3561, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3617, 16, false);
#line 128 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Model.average[7]);

#line default
#line hidden
            EndContext();
            BeginContext(3633, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3689, 16, false);
#line 131 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Model.average[8]);

#line default
#line hidden
            EndContext();
            BeginContext(3705, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3761, 16, false);
#line 134 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Model.average[9]);

#line default
#line hidden
            EndContext();
            BeginContext(3777, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3833, 17, false);
#line 137 "C:\Users\Nikita\Desktop\Test_Task\Test_Task\Pages\MyForm\Index.cshtml"
           Write(Model.average[10]);

#line default
#line hidden
            EndContext();
            BeginContext(3850, 79, true);
            WriteLiteral(" /2,4\r\n            </td>\r\n        </tr>\r\n\r\n        \r\n\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Test_Task.Pages.MyForm.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Test_Task.Pages.MyForm.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Test_Task.Pages.MyForm.IndexModel>)PageContext?.ViewData;
        public Test_Task.Pages.MyForm.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
