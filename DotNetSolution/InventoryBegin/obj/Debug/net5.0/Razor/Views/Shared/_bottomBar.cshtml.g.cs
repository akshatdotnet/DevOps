#pragma checksum "D:\Vaishnav Engineering\Code\.NET5\InventoryBegin\Views\Shared\_bottomBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0c783b27a070d6389fbfd26a4fd7292b9337f05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__bottomBar), @"mvc.1.0.view", @"/Views/Shared/_bottomBar.cshtml")]
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
#line 1 "D:\Vaishnav Engineering\Code\.NET5\InventoryBegin\Views\_ViewImports.cshtml"
using InventoryBeginners;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Vaishnav Engineering\Code\.NET5\InventoryBegin\Views\_ViewImports.cshtml"
using InventoryBeginners.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0c783b27a070d6389fbfd26a4fd7292b9337f05", @"/Views/Shared/_bottomBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a64d2b7eca56cd5461ef845e02b1e70f851f2bdc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__bottomBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagerModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("pageSelector"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("ChangePageSize(this);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container m-0 p-0 btn-group\" style=\"background-color:black; border-radius:10px;  height:45px; color:white;\">\r\n\r\n    <div class=\"col-4 btn-group p-1 m-1\">\r\n        <p>\r\n            Showing ");
#nullable restore
#line 7 "D:\Vaishnav Engineering\Code\.NET5\InventoryBegin\Views\Shared\_bottomBar.cshtml"
               Write(Model.StartRecord);

#line default
#line hidden
#nullable disable
            WriteLiteral(" to ");
#nullable restore
#line 7 "D:\Vaishnav Engineering\Code\.NET5\InventoryBegin\Views\Shared\_bottomBar.cshtml"
                                     Write(Model.EndRecord);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 7 "D:\Vaishnav Engineering\Code\.NET5\InventoryBegin\Views\Shared\_bottomBar.cshtml"
                                                         Write(Model.TotalItems);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Rows\r\n        </p>\r\n    </div>\r\n\r\n\r\n\r\n    <div class=\"col-3 btn-group justify-content-end\">\r\n        <span class=\"col-7 mt-2 p-0\">\r\n            Rows Per Page\r\n        </span>\r\n\r\n        <span class=\"col-5 p-1\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0c783b27a070d6389fbfd26a4fd7292b9337f055408", async() => {
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 19 "D:\Vaishnav Engineering\Code\.NET5\InventoryBegin\Views\Shared\_bottomBar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.GetPageSizes();;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </span>\r\n    </div>\r\n\r\n\r\n\r\n    <div class=\"col-4 btn-group justify-content-end mt-2\">\r\n        <p>\r\n            Showing ");
#nullable restore
#line 29 "D:\Vaishnav Engineering\Code\.NET5\InventoryBegin\Views\Shared\_bottomBar.cshtml"
               Write(Model.CurrentPage);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 29 "D:\Vaishnav Engineering\Code\.NET5\InventoryBegin\Views\Shared\_bottomBar.cshtml"
                                    Write(Model.TotalPages);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Pages\r\n        </p>\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n<script>\r\n    function ChangePageSize(obj)\r\n    {\r\n        var controllerName = \'");
#nullable restore
#line 39 "D:\Vaishnav Engineering\Code\.NET5\InventoryBegin\Views\Shared\_bottomBar.cshtml"
                         Write(this.ViewContext.RouteData.Values["controller"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n        window.location.href = \"/\" + controllerName + \"/");
#nullable restore
#line 40 "D:\Vaishnav Engineering\Code\.NET5\InventoryBegin\Views\Shared\_bottomBar.cshtml"
                                                   Write(Model.Action);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" + \"?pageSize=\" + obj.value + \"&SearchText@Model.SearchText\" + \"&sortExpression=\" + \"");
#nullable restore
#line 40 "D:\Vaishnav Engineering\Code\.NET5\InventoryBegin\Views\Shared\_bottomBar.cshtml"
                                                                                                                                                      Write(Model.SortExpression);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n    }\r\n\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagerModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
