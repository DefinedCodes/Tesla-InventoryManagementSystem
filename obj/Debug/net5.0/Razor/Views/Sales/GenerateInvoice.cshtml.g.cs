#pragma checksum "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\Sales\GenerateInvoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb33e4367a7d176c70ffb58b27c12150957e4991"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sales_GenerateInvoice), @"mvc.1.0.view", @"/Views/Sales/GenerateInvoice.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\Sales\GenerateInvoice.cshtml"
using System.Security.Cryptography;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\Sales\GenerateInvoice.cshtml"
using System.Security.Principal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\Sales\GenerateInvoice.cshtml"
using Google.Protobuf.WellKnownTypes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb33e4367a7d176c70ffb58b27c12150957e4991", @"/Views/Sales/GenerateInvoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41dd644513de9129ed17d71e01e943119551af52", @"/Views/_ViewImports.cshtml")]
    public class Views_Sales_GenerateInvoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InventoryManagemenSystem_Ims.Entities.Sales>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\Sales\GenerateInvoice.cshtml"
  
    Layout = "~/Views/Shared/_UserLayout.cshtml";
    ViewData["Title"] = "SalesItem";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"" style=""background-image: url('images/images(9).jpeg')"">
    <div class=""row"">
        <div class=""col-md-6 offset-md-3 main"">
            <div class=""col-md-12"">
               <div class=""row"">
                    <div class=""col-md-4"">
                        <img class=""img-fluid"" alt=""Invoce Template"" src=""/images/images (9).jpeg"" />
                    </div>
                   <div class=""col-md-8 text-xs-right"">
                       <strong>
                       <h4 style=""color: #F81D2D;""><strong>Tesla Inventory</strong></h4>
                       <h6>No 3, Gbonagun street Unity Abk</h6>
                       <h6>+234 9014 698 926</h6>
                       <h6>Teslaims@gmail.com</h6>
                       </strong>
                   </div>
                </div>
                <br />
                <div class=""row"">
                    <div class=""col-md-12 text-xs-center"">
                        <h1>Invoice No.</h1>
                        <h");
            WriteLiteral(@"2>
                            <b>
                                3556790
                                <script type=""text/javascript"" src=""js/TeslaInvoice.js""> </script>
                                <div id=""myInvoice""></div>
                                <p id=""yourInvoice""></p>
                            </b>
                        </h2>
                    </div >
                </div>
                <br />
                <div>
                    <table class=""table"">
                        <thead>
                        <tr style=""color: whitesmoke"">
                            <th><h5>Details</h5></th>
                            <th><h5>Value</h5></th>
                        </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 52 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\Sales\GenerateInvoice.cshtml"
                         foreach (var sales in Model)
                        {



#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <strong>\r\n                                    <td class=\"col-md-9\">Id</td>\r\n                                    <td class=\"col-md-3\"><i class=\"fa fa-usd\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 59 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\Sales\GenerateInvoice.cshtml"
                                                                                                 Write(Html.DisplayFor(modelItem=>sales.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </td>
                                </strong>
                            </tr>
                            <tr>
                                <strong>
                                    <td class=""col-md-9"">Customer</td>
                                    <td class=""col-md-3""><i class=""id"" aria-hidden=""true""></i> ");
#nullable restore
#line 65 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\Sales\GenerateInvoice.cshtml"
                                                                                          Write(Html.DisplayFor(modelItem=>sales.Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                </strong>
                            </tr>
                            <tr>
                                <strong>
                                    <td class=""col-md-9"">SalesManager</td>
                                    <td class=""col-md-3""><i class=""id"" aria-hidden=""true""></i> ");
#nullable restore
#line 71 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\Sales\GenerateInvoice.cshtml"
                                                                                          Write(Html.DisplayFor(modelItem=>sales.SalesManager));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                </strong>
                            </tr>
                            <tr>
                                <strong>
                                    <td class=""col-md-9"">Item</td>
                                    <td class=""col-md-3""><i class=""id"" aria-hidden=""true""></i> ");
#nullable restore
#line 77 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\Sales\GenerateInvoice.cshtml"
                                                                                          Write(Html.DisplayFor(modlItem=>sales.Item));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </strong>\r\n                            </tr>\r\n");
            WriteLiteral("                            <tr>\r\n                                <strong>\r\n                                    <td class=\"col-md-9\">PricePerUnit</td>\r\n                                    <td class=\"col-md-3\"><i class=\"fa fa-usd\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 84 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\Sales\GenerateInvoice.cshtml"
                                                                                                 Write(Html.DisplayFor(modelItem=>sales.PricePerUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                </strong>\r\n                            </tr>\r\n");
            WriteLiteral("                            <tr>\r\n                                <strong>\r\n                                    <td class=\"col-md-9\">Quantity</td>\r\n                                    <td class=\"col-md-3\"><i class=\"fa fa-usd\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 91 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\Sales\GenerateInvoice.cshtml"
                                                                                                 Write(Html.DisplayFor(modelItem=>sales.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                </strong>\r\n                            </tr>\r\n");
            WriteLiteral(@"                            <tr style=""color: #F81D2D;"">
                                <td class=""text-xs-right""><h4><strong>Total:</strong></h4>
                                    </td>
                                <td class=""text-xs-left""><h4><strong><i class=""fa fa-usd"" aria-hidden=""true""></i> ");
#nullable restore
#line 99 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\Sales\GenerateInvoice.cshtml"
                                                                                                             Write(Html.DisplayFor(modelItem=>sales.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </strong></h4>\r\n                                    </td>\r\n                            </tr>\r\n");
#nullable restore
#line 102 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\Sales\GenerateInvoice.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n");
#nullable restore
#line 106 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\Sales\GenerateInvoice.cshtml"
                 foreach (var sales in Model)
                {
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        <div class=\"col-md-12\">\r\n                            <p><b>Date :</b> ");
#nullable restore
#line 111 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\Sales\GenerateInvoice.cshtml"
                                        Write(Html.DisplayFor(modelItem=>sales.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <br />\r\n                            <p><b>Signature</b></p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 116 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\Sales\GenerateInvoice.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>

<style>
    .main {
        background: #a19191;
        border-bottom: 15px solid #F81D2D;
        border-top: 15px solid #1E1F23;
        margin-top: 30px;
        margin-bottom: 30px;
        padding: 40px 30px !important;
        position: relative;
        box-shadow: 0 1px 21px #808080;
        font-size:14px;
    }

    .main thead {
		background: #424356;
        color: #fff;
		}
</style>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InventoryManagemenSystem_Ims.Entities.Sales>> Html { get; private set; }
    }
}
#pragma warning restore 1591
