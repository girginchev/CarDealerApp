#pragma checksum "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Parts\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba0acbe1ac973193a7b9af09042a62bda01a4cb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parts_All), @"mvc.1.0.view", @"/Views/Parts/All.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Parts/All.cshtml", typeof(AspNetCore.Views_Parts_All))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba0acbe1ac973193a7b9af09042a62bda01a4cb4", @"/Views/Parts/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e73e2e285481803531579d89843547e5867fcaf", @"/Views/_ViewImports.cshtml")]
    public class Views_Parts_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarDealer.App.Models.Parts.PartsPageListingViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Parts\All.cshtml"
  
    ViewData["Title"] = "All Parts";

#line default
#line hidden
            BeginContext(108, 12, true);
            WriteLiteral("\r\n<h2>\r\n    ");
            EndContext();
            BeginContext(121, 17, false);
#line 8 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Parts\All.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(138, 171, true);
            WriteLiteral("\r\n\r\n    <a class=\"btn btn-primary btn-lg top-right\" href=\"/parts/create\">Add Part</a>\r\n</h2>\r\n\r\n\r\n\r\n<ul class=\"pagination\">\r\n    <li class=\"page-item\"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 309, "\"", 351, 2);
            WriteAttributeValue("", 316, "/parts/all?page=", 316, 16, true);
#line 16 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Parts\All.cshtml"
WriteAttributeValue("", 332, Model.PreviousPage, 332, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(352, 20, true);
            WriteLiteral(">Previous</a></li>\r\n");
            EndContext();
#line 17 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Parts\All.cshtml"
     for (int i = 1; i <= Model.TotalPages; i++)
    {

#line default
#line hidden
            BeginContext(429, 11, true);
            WriteLiteral("        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 440, "\"", 510, 2);
            WriteAttributeValue("", 448, "page-item", 448, 9, true);
#line 19 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Parts\All.cshtml"
WriteAttributeValue(" ", 457, Model.CurrentPage == @i ? "active" : string.Empty, 458, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(511, 21, true);
            WriteLiteral("><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 532, "\"", 557, 2);
            WriteAttributeValue("", 539, "/parts/all?page=", 539, 16, true);
#line 19 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Parts\All.cshtml"
WriteAttributeValue("", 555, i, 555, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(558, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(560, 1, false);
#line 19 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Parts\All.cshtml"
                                                                                                                             Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(561, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 20 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Parts\All.cshtml"
    }

#line default
#line hidden
            BeginContext(579, 46, true);
            WriteLiteral("    <li class=\"page-item\"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 625, "\"", 663, 2);
            WriteAttributeValue("", 632, "/parts/all?page=", 632, 16, true);
#line 21 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Parts\All.cshtml"
WriteAttributeValue("", 648, Model.NextPage, 648, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(664, 430, true);
            WriteLiteral(@">Next</a></li>
</ul>


<table class=""table table-bordered table-hover"">
    <thead>
        <tr>
            <th>
                Name
            </th>
            <th>
                Price
            </th>
            <th>
                Quantity
            </th>
            <th>
                Supplier
            </th>
            <th>

            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 46 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Parts\All.cshtml"
         foreach (var part in Model.Parts)
        {

#line default
#line hidden
            BeginContext(1149, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1210, 9, false);
#line 50 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Parts\All.cshtml"
               Write(part.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1219, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1287, 25, false);
#line 53 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Parts\All.cshtml"
               Write(part.Price.ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1312, 69, true);
            WriteLiteral(" $\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1382, 13, false);
#line 56 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Parts\All.cshtml"
               Write(part.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1395, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1463, 17, false);
#line 59 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Parts\All.cshtml"
               Write(part.SupplierName);

#line default
#line hidden
            EndContext();
            BeginContext(1480, 93, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a class=\"btn btn-warning\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1573, "\"", 1600, 2);
            WriteAttributeValue("", 1580, "/Parts/Edit/", 1580, 12, true);
#line 62 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Parts\All.cshtml"
WriteAttributeValue("", 1592, part.Id, 1592, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1601, 56, true);
            WriteLiteral(">Edit</a>\r\n                    <a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1657, "\"", 1686, 2);
            WriteAttributeValue("", 1664, "/Parts/Delete/", 1664, 14, true);
#line 63 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Parts\All.cshtml"
WriteAttributeValue("", 1678, part.Id, 1678, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1687, 55, true);
            WriteLiteral(">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 66 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Parts\All.cshtml"
        }

#line default
#line hidden
            BeginContext(1753, 28, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarDealer.App.Models.Parts.PartsPageListingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
