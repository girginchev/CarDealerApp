#pragma checksum "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Customers\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c94d00dcc1cba15dc003788789b482b19023e660"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_All), @"mvc.1.0.view", @"/Views/Customers/All.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customers/All.cshtml", typeof(AspNetCore.Views_Customers_All))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c94d00dcc1cba15dc003788789b482b19023e660", @"/Views/Customers/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e73e2e285481803531579d89843547e5867fcaf", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarDealer.App.Models.Customers.CustomerOrderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Customers\All.cshtml"
  
    ViewData["Title"] = "All Customers";

#line default
#line hidden
            BeginContext(113, 594, true);
            WriteLiteral(@"
<h2>All Customers</h2> 
    <div class=""dropdown"">
        <button type=""button"" class=""btn btn-primary dropdown-toggle"" data-toggle=""dropdown"">
            Order by Birthdate
        </button>
        <div class=""dropdown-menu"">
            <ul>
                <li>
                    <a class=""dropdown-item"" href=""/customers/all/ascending"">Ascending</a>
                </li>
                <li>
                    <a class=""dropdown-item"" href=""/customers/all/descending"">Descending</a>
                </li>
            </ul>
        </div>
    </div>
<h3>Ordered by ");
            EndContext();
            BeginContext(708, 36, false);
#line 23 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Customers\All.cshtml"
          Write(Model.OrderType.ToString().ToLower());

#line default
#line hidden
            EndContext();
            BeginContext(744, 368, true);
            WriteLiteral(@" direction</h3>

<table class=""table table-bordered table-hover"">
    <thead>
        <tr>
            <th>
                Name
            </th>
            <th>
                BirthDate
            </th>
            <th>
                 Young driver
            </th>
            <th>

            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 43 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Customers\All.cshtml"
         foreach (var customer in Model.AllCustomers)
        {

#line default
#line hidden
            BeginContext(1178, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1227, 13, false);
#line 47 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Customers\All.cshtml"
           Write(customer.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1240, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1296, 18, false);
#line 50 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Customers\All.cshtml"
           Write(customer.BirthDate);

#line default
#line hidden
            EndContext();
            BeginContext(1314, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1371, 37, false);
#line 53 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Customers\All.cshtml"
            Write(customer.IsYoungDriver ? "Yes" : "No");

#line default
#line hidden
            EndContext();
            BeginContext(1409, 88, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a class=\"btn btn-sm btn-warning\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1497, "\"", 1532, 2);
            WriteAttributeValue("", 1504, "/customers/edit/", 1504, 16, true);
#line 56 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Customers\All.cshtml"
WriteAttributeValue("", 1520, customer.Id, 1520, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1533, 45, true);
            WriteLiteral(">Edit</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 59 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Customers\All.cshtml"
        }

#line default
#line hidden
            BeginContext(1589, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarDealer.App.Models.Customers.CustomerOrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
