#pragma checksum "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\AllocateSalesItem\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53fdcab80a0d047887d499528df98ae07891bf5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AllocateSalesItem_Index), @"mvc.1.0.view", @"/Views/AllocateSalesItem/Index.cshtml")]
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
#line 1 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\_ViewImports.cshtml"
using InventoryManagemenSystem_Ims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\_ViewImports.cshtml"
using InventoryManagemenSystem_Ims.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53fdcab80a0d047887d499528df98ae07891bf5d", @"/Views/AllocateSalesItem/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41dd644513de9129ed17d71e01e943119551af52", @"/Views/_ViewImports.cshtml")]
    public class Views_AllocateSalesItem_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InventoryManagemenSystem_Ims.Entities.AllocateSalesItemToSalesManager>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AllocateSalesItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllocateItemsToSalesStore", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\AllocateSalesItem\Index.cshtml"
  
    Layout = "~/Views/Shared/_UserLayout.cshtml";
    ViewData["Title"] = "Allocated Items";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\AllocateSalesItem\Index.cshtml"
 if (TempData["data"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"alert alert-warning alert-dismissible fade show\" role=\"alert\">\r\n\t\t<strong>");
#nullable restore
#line 11 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\AllocateSalesItem\Index.cshtml"
           Write(TempData["data"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n\t\t<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n\t\t\t<span aria-hidden=\"true\">&times;</span>\r\n\t\t</button>\r\n\t</div>\r\n");
#nullable restore
#line 16 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\AllocateSalesItem\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- CSS only -->
<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">


<div class=""card-header"" style=""background-color:midnightblue;"">
    <div class=""card-title"">
        <h1 class=""text-center"">SalesItemAllocated</h1>
    </div>
</div>

<table class=""bg-primary"">
    <thead>
    <tr>


        <th>
            ");
#nullable restore
#line 34 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\AllocateSalesItem\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n\r\n        <th>\r\n            ");
#nullable restore
#line 38 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\AllocateSalesItem\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n\r\n        <th>\r\n            ");
#nullable restore
#line 42 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\AllocateSalesItem\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.QuantityAllocated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n\r\n        <th>\r\n            ");
#nullable restore
#line 46 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\AllocateSalesItem\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.StockKeeper));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 49 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\AllocateSalesItem\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.SalesManager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 52 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\AllocateSalesItem\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n\r\n\r\n        <th>\r\n            Update\r\n        </th>\r\n        <th>\r\n            Details\r\n        </th>\r\n        <th>\r\n            Delete\r\n        </th>\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 68 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\AllocateSalesItem\Index.cshtml"
         foreach (var allocatedItem in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 72 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\AllocateSalesItem\Index.cshtml"
           Write(Html.DisplayFor(modelItem => allocatedItem.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\AllocateSalesItem\Index.cshtml"
           Write(Html.DisplayFor(modelItem => allocatedItem.Item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 80 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\AllocateSalesItem\Index.cshtml"
           Write(Html.DisplayFor(modelItem => allocatedItem.QuantityAllocated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 83 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\AllocateSalesItem\Index.cshtml"
           Write(Html.DisplayFor(modelItem => allocatedItem.StockKeeper));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 87 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\AllocateSalesItem\Index.cshtml"
           Write(Html.DisplayFor(modelItem => allocatedItem.SalesManager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 92 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\AllocateSalesItem\Index.cshtml"
           Write(Html.DisplayFor(modelItem => allocatedItem.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n");
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 105 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\AllocateSalesItem\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<button style=\"background-color: midnightblue\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53fdcab80a0d047887d499528df98ae07891bf5d11984", async() => {
                WriteLiteral("Allocate");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </button>\r\n\r\n<button style=\"background-color: midnightblue\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53fdcab80a0d047887d499528df98ae07891bf5d13411", async() => {
                WriteLiteral("Return to your Dashboard");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </button>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InventoryManagemenSystem_Ims.Entities.AllocateSalesItemToSalesManager>> Html { get; private set; }
    }
}
#pragma warning restore 1591