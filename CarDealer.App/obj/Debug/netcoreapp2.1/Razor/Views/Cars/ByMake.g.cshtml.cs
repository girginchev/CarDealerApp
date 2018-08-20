#pragma checksum "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Cars\ByMake.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f11c5baf9bae88e8b10b714a72e3cc73cc515613"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_ByMake), @"mvc.1.0.view", @"/Views/Cars/ByMake.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cars/ByMake.cshtml", typeof(AspNetCore.Views_Cars_ByMake))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f11c5baf9bae88e8b10b714a72e3cc73cc515613", @"/Views/Cars/ByMake.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e73e2e285481803531579d89843547e5867fcaf", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_ByMake : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarsByMakeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Cars\ByMake.cshtml"
  
    ViewData["Title"] = $"{Model.Make} Cars";

#line default
#line hidden
            BeginContext(84, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(91, 10, false);
#line 7 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Cars\ByMake.cshtml"
Write(Model.Make);

#line default
#line hidden
            EndContext();
            BeginContext(101, 224, true);
            WriteLiteral("</h2>\r\n\r\n<table class=\"table table-bordered table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>Make</th>\r\n            <th>Model</th>\r\n            <th>Travelled Distance</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 18 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Cars\ByMake.cshtml"
         foreach (var car in Model.Cars)
        {

#line default
#line hidden
            BeginContext(378, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(427, 8, false);
#line 22 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Cars\ByMake.cshtml"
           Write(car.Make);

#line default
#line hidden
            EndContext();
            BeginContext(435, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(491, 9, false);
#line 25 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Cars\ByMake.cshtml"
           Write(car.Model);

#line default
#line hidden
            EndContext();
            BeginContext(500, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(556, 21, false);
#line 28 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Cars\ByMake.cshtml"
           Write(car.TravelledDistance);

#line default
#line hidden
            EndContext();
            BeginContext(577, 39, true);
            WriteLiteral(" Km\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 31 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Cars\ByMake.cshtml"
        }

#line default
#line hidden
            BeginContext(627, 26, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarsByMakeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591