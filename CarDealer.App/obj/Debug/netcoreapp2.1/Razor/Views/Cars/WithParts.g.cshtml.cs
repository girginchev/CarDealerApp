#pragma checksum "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Cars\WithParts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a787baedfb3f67a6fde8e9f7a593fefb7f1df54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_WithParts), @"mvc.1.0.view", @"/Views/Cars/WithParts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cars/WithParts.cshtml", typeof(AspNetCore.Views_Cars_WithParts))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a787baedfb3f67a6fde8e9f7a593fefb7f1df54", @"/Views/Cars/WithParts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e73e2e285481803531579d89843547e5867fcaf", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_WithParts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarWithPartsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Cars\WithParts.cshtml"
  
    ViewData["Title"] = $"Car with {Model.Car.Id} and it's parts";

#line default
#line hidden
            BeginContext(107, 20, true);
            WriteLiteral("\r\n<h2>Parts for car ");
            EndContext();
            BeginContext(128, 14, false);
#line 7 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Cars\WithParts.cshtml"
             Write(Model.Car.Make);

#line default
#line hidden
            EndContext();
            BeginContext(142, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(144, 15, false);
#line 7 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Cars\WithParts.cshtml"
                             Write(Model.Car.Model);

#line default
#line hidden
            EndContext();
            BeginContext(159, 17, true);
            WriteLiteral("</h2>\r\n\r\n\r\n<ul>\r\n");
            EndContext();
#line 11 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Cars\WithParts.cshtml"
     foreach (var part in Model.Car.Parts)
    {

#line default
#line hidden
            BeginContext(227, 16, true);
            WriteLiteral("            <li>");
            EndContext();
            BeginContext(244, 9, false);
#line 13 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Cars\WithParts.cshtml"
           Write(part.Name);

#line default
#line hidden
            EndContext();
            BeginContext(253, 6, true);
            WriteLiteral("  -  $");
            EndContext();
            BeginContext(260, 25, false);
#line 13 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Cars\WithParts.cshtml"
                           Write(part.Price.ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(285, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 14 "C:\Users\girgi\source\repos\CarDealer\CarDealer.App\Views\Cars\WithParts.cshtml"
    }

#line default
#line hidden
            BeginContext(299, 11, true);
            WriteLiteral("</ul>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarWithPartsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
