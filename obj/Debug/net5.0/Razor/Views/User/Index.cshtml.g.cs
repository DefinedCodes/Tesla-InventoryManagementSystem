#pragma checksum "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cb580216e8a8eb579bb1ea6f0fece2748f9e193"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\User\Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\User\Index.cshtml"
using Microsoft.EntityFrameworkCore.Metadata.Internal;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cb580216e8a8eb579bb1ea6f0fece2748f9e193", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41dd644513de9129ed17d71e01e943119551af52", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendors/images/banner-img.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\User\Index.cshtml"
  
    Layout = "~/Views/Shared/_UserLayout.cshtml";
    ViewData["Title"] = "User";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\User\Index.cshtml"
 if (TempData["data"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"alert alert-warning alert-dismissible fade show\" role=\"alert\">\r\n\t\t<strong>");
#nullable restore
#line 13 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\User\Index.cshtml"
           Write(TempData["data"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n\t\t<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n\t\t\t<span aria-hidden=\"true\">&times;</span>\r\n\t\t</button>\r\n\t</div>\r\n");
#nullable restore
#line 18 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\User\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"pd-ltr-20\" style=\"background-color: #06163a\">\r\n    <div class=\"card-box pd-20 height-100-p mb-30\">\r\n        <div class=\"row align-items-center\">\r\n            <div class=\"col-md-4\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4cb580216e8a8eb579bb1ea6f0fece2748f9e1936366", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div> \r\n            <div class=\"col-md-8\">\r\n                <h4 class=\"font-20 weight-500 mb-10 text-capitalize\">\r\n                    Welcome back!<div class=\"weight-600 font-30 text-blue\">");
#nullable restore
#line 27 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\User\Index.cshtml"
                                                                      Write(User.Identity?.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                </h4>
                <p class=""font-18 max-width-600"">The Outstanding Innovation Begins Here...</p>
            </div>
        </div>
    </div>

    <div class=""footer-wrap pd-20 mb-20 card-box"">
        Inventory is Money, sitting around is another form...
    </div>

</div>

<!DOCTYPE html>
<html lang=""en"">

	<div>
	");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cb580216e8a8eb579bb1ea6f0fece2748f9e1938399", async() => {
                WriteLiteral("\r\n\t\t<title>Bar Chart</title>\r\n\t\t\r\n\t");
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
            WriteLiteral("\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cb580216e8a8eb579bb1ea6f0fece2748f9e1939409", async() => {
                WriteLiteral("\r\n\t\t<canvas id=\"barchart\" height=\"5000\" width=\"2000\"></canvas>\r\n\r\n\t<script>\r\n\t\tvar mn = ");
#nullable restore
#line 52 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\User\Index.cshtml"
            Write(Html.Raw((Json.Serialize(ViewBag.SALESITEM))));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n\t\tvar fn = ");
#nullable restore
#line 53 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\User\Index.cshtml"
            Write(Html.Raw((Json.Serialize(ViewBag.CUSTOMERNUMBERS))));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

		document.addEventListener(""DOMContentLoaded"", () => 
		{
			new Chart(document.querySelector('#barchart'), {
				type: 'bar',
				data: {
					labels: mn,
					datasets: [{
						label: 'Customers',
						data: fn,
						backgroundColor: [
						""rgba(255, 99, 132, 0.2)"",
						""rgba(255, 159, 64, 0.2)"",
						""rgba(255, 205, 86, 0.2)"",
						""rgba(75, 192, 192, 0.2)"",
						""rgba(54, 162, 235, 0.2)"",
						""rgba(153, 102, 235, 0.2)"",
						""rgba(201, 203, 207, 0.2)"",
						],

						borderColor: [
						""rgba(255, 99, 132)"",
						""rgba(255, 159, 64)"",
						""rgba(255, 205, 86)"",
						""rgba(75, 192, 192)"",
						""rgba(54, 162, 235)"",
						""rgba(153, 102, 235)"",
						""rgba(201, 203, 207)"",
						]
					}]
				}
			})
		})
		
		
	</script>
	<script>
		const cust = document.querySelector(""#total-customers"");
		const sales = document.querySelector(""#all-sales"");

		var totalCustomers = ");
#nullable restore
#line 94 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\User\Index.cshtml"
                        Write(ViewBag.CUSTOMERS);

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n\t\tvar totalSales = ");
#nullable restore
#line 95 "C:\Users\Dejik Concepts\Downloads\My Final Project\MyUpdatedProject\Tesla-InventoryManagementSystem\Views\User\Index.cshtml"
                    Write(ViewBag.SALES);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

		window.onload = function(){
			cust.innerText = totalCustomers;
			sales.innerText = totalSales;
		}
	</script>
	<script type=""text/javascript"" src=""https://cdn.jsdelivr.net/npm/chart.js@3.7.1/dist/chart.min.js""></script>
	<script src=""/chart.js""></script>
	
	");
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
            WriteLiteral("\r\n\t</div>\r\n\r\n\r\n\r\n    \r\n</html>\r\n\r\n\t\r\n\r\n<!-- js -->");
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
