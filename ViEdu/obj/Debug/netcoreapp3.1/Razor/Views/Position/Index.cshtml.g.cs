#pragma checksum "/Users/lexuantan/Projects/ViEdu/ViEdu/Views/Position/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cadb322fc12e6563c7564fc6d12ab4ed615f3a92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Position_Index), @"mvc.1.0.view", @"/Views/Position/Index.cshtml")]
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
#line 1 "/Users/lexuantan/Projects/ViEdu/ViEdu/Views/_ViewImports.cshtml"
using ViEdu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/lexuantan/Projects/ViEdu/ViEdu/Views/_ViewImports.cshtml"
using ViEdu.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cadb322fc12e6563c7564fc6d12ab4ed615f3a92", @"/Views/Position/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30d216d0b773c60bd6c935f5abd3a68e6442d3c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Position_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ViEdu.Data.Entities.Position>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Position", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/lexuantan/Projects/ViEdu/ViEdu/Views/Position/Index.cshtml"
  
    ViewData["Title"] = "Trang chủ Position";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\n    <h1 class=\"mt-4\">Danh sách vị trí công việc</h1>\n    <div class=\"card mb-12\">\n        <div class=\"card-header\">\n            <div class=\"row\">\n                <div class=\"col-md-6 col-xs-12\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cadb322fc12e6563c7564fc6d12ab4ed615f3a924441", async() => {
                WriteLiteral("Tạo mới");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"">
                    <thead>
                        <tr>
                            <th>
                                Mã công việc
                            </th>
                            <th>
                                Tên công việc
                            </th>
                            <th>
                                Thuộc phòng ban
                            </th>
                            <th>
                                Ngày khởi tạo
                            </th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 37 "/Users/lexuantan/Projects/ViEdu/ViEdu/Views/Position/Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td>\n                                    ");
#nullable restore
#line 41 "/Users/lexuantan/Projects/ViEdu/ViEdu/Views/Position/Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.POSITION_CD));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 44 "/Users/lexuantan/Projects/ViEdu/ViEdu/Views/Position/Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.NAME));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 47 "/Users/lexuantan/Projects/ViEdu/ViEdu/Views/Position/Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.DEPT_CD));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 50 "/Users/lexuantan/Projects/ViEdu/ViEdu/Views/Position/Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.CREATED_DATE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 53 "/Users/lexuantan/Projects/ViEdu/ViEdu/Views/Position/Index.cshtml"
                               Write(Html.ActionLink("Sửa", "Edit", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                                    ");
#nullable restore
#line 54 "/Users/lexuantan/Projects/ViEdu/ViEdu/Views/Position/Index.cshtml"
                               Write(Html.ActionLink("Xem", "Details", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                                    ");
#nullable restore
#line 55 "/Users/lexuantan/Projects/ViEdu/ViEdu/Views/Position/Index.cshtml"
                               Write(Html.ActionLink("Xóa", "Delete", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                                </td>\n                            </tr>\n");
#nullable restore
#line 59 "/Users/lexuantan/Projects/ViEdu/ViEdu/Views/Position/Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n            </div>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ViEdu.Data.Entities.Position>> Html { get; private set; }
    }
}
#pragma warning restore 1591
