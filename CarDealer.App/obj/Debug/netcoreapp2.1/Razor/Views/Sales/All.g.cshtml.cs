#pragma checksum "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Sales\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0665d294e4509b24eb958d2e67487b1c7e9e8f9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sales_All), @"mvc.1.0.view", @"/Views/Sales/All.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sales/All.cshtml", typeof(AspNetCore.Views_Sales_All))]
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
#line 1 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\_ViewImports.cshtml"
using CarDealer.App;

#line default
#line hidden
#line 2 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\_ViewImports.cshtml"
using CarDealer.App.Models;

#line default
#line hidden
#line 3 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\_ViewImports.cshtml"
using CarDealer.App.Models.Cars;

#line default
#line hidden
#line 4 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\_ViewImports.cshtml"
using CarDealer.App.Models.Customers;

#line default
#line hidden
#line 5 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\_ViewImports.cshtml"
using CarDealer.App.Models.Suppliers;

#line default
#line hidden
#line 6 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\_ViewImports.cshtml"
using CarDealer.App.Models.Parts;

#line default
#line hidden
#line 7 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\_ViewImports.cshtml"
using CarDealer.Services.Models.Customers;

#line default
#line hidden
#line 8 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\_ViewImports.cshtml"
using CarDealer.Services.Models.Sales;

#line default
#line hidden
#line 9 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\_ViewImports.cshtml"
using CarDealer.Services.Models.Parts;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0665d294e4509b24eb958d2e67487b1c7e9e8f9b", @"/Views/Sales/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e73e2e285481803531579d89843547e5867fcaf", @"/Views/_ViewImports.cshtml")]
    public class Views_Sales_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SaleListServiceModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Sales\All.cshtml"
  
    ViewData["Title"] = "All Sales";

#line default
#line hidden
            BeginContext(89, 514, true);
            WriteLiteral(@"
<h2>All Sales</h2>

<h3><a href=""/sales/discounted"">Show only discounted sales</a></h3>


<table class=""table table-bordered table-hover"">
    <thead>
        <tr>
            <th>
                Customer
            </th>
            <th>
                Discount
            </th>
            <th>
                Price
            </th>
            <th>
                Discounted Price
            </th>
            <th>
            </th>
        </tr>
        </thead>
    <tbody>
");
            EndContext();
#line 32 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Sales\All.cshtml"
         foreach (var sale in Model)
        {

#line default
#line hidden
            BeginContext(652, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(701, 17, false);
#line 36 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Sales\All.cshtml"
           Write(sale.CustomerName);

#line default
#line hidden
            EndContext();
            BeginContext(718, 57, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n\r\n                ");
            EndContext();
            BeginContext(777, 72, false);
#line 40 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Sales\All.cshtml"
            Write(((sale.Discount + (sale.IsYoungDriver ? 0.05 : 0)) * 100).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(850, 56, true);
            WriteLiteral("%\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(907, 25, false);
#line 43 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Sales\All.cshtml"
           Write(sale.Price.ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(932, 57, true);
            WriteLiteral(" $\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(990, 35, false);
#line 46 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Sales\All.cshtml"
           Write(sale.DiscountedPrice.ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1025, 59, true);
            WriteLiteral(" $\r\n            </td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1084, "\"", 1106, 2);
            WriteAttributeValue("", 1091, "/sales/", 1091, 7, true);
#line 49 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Sales\All.cshtml"
WriteAttributeValue("", 1098, sale.Id, 1098, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1107, 48, true);
            WriteLiteral(">Details</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 52 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Sales\All.cshtml"
        }

#line default
#line hidden
            BeginContext(1166, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SaleListServiceModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
