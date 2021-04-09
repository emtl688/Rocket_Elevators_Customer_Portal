#pragma checksum "C:\Users\Eric\Desktop\CustomerPortal\Rocket_Elevators_Customer_Portal\Views\Home\Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2522b914a9747ed2632dd945ee6de26147a4298a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Products), @"mvc.1.0.view", @"/Views/Home/Products.cshtml")]
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
#line 1 "C:\Users\Eric\Desktop\CustomerPortal\Rocket_Elevators_Customer_Portal\Views\_ViewImports.cshtml"
using Rocket_Elevators_Customer_Portal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eric\Desktop\CustomerPortal\Rocket_Elevators_Customer_Portal\Views\_ViewImports.cshtml"
using Rocket_Elevators_Customer_Portal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2522b914a9747ed2632dd945ee6de26147a4298a", @"/Views/Home/Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c43fdba9ec3567df5250e21f4feb7b14e91ed237", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Eric\Desktop\CustomerPortal\Rocket_Elevators_Customer_Portal\Views\Home\Products.cshtml"
  
    ViewData["Title"] = "My Products";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Product management</h1>
    <p>
        See the details of the different products purchased from us: batteries, columns and elevators.
    </p>

    <div class=""accordion"" id=""accordionExample"">

");
            WriteLiteral(@"        <div class=""card"">
            <div class=""card-header"" id=""headingOne"">
                <h5 class=""mb-0"">
                    <button class=""btn btn-link"" type=""button"" data-toggle=""collapse"" data-target=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne"">
                        Batteries
                    </button>
                </h5>
            </div>
            <div id=""collapseOne"" class=""collapse"" aria-labelledby=""headingOne"" data-parent=""#accordionExample"">
                <div class=""card-body"">
                    <table class=""table table-bordered table-striped"">
                        <thead>
                            <tr>
                                <th>Battery Id</th>
                                <th>Building Id</th>
                                <th>Status</th>
                                <th>Certificate of Operations</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 36 "C:\Users\Eric\Desktop\CustomerPortal\Rocket_Elevators_Customer_Portal\Views\Home\Products.cshtml"
                             foreach (var Battery in Model.Buildings.SelectMany(Building => Building.Batteries))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 39 "C:\Users\Eric\Desktop\CustomerPortal\Rocket_Elevators_Customer_Portal\Views\Home\Products.cshtml"
                                   Write(Battery.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 40 "C:\Users\Eric\Desktop\CustomerPortal\Rocket_Elevators_Customer_Portal\Views\Home\Products.cshtml"
                                   Write(Battery.BuildingId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 41 "C:\Users\Eric\Desktop\CustomerPortal\Rocket_Elevators_Customer_Portal\Views\Home\Products.cshtml"
                                   Write(Battery.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 42 "C:\Users\Eric\Desktop\CustomerPortal\Rocket_Elevators_Customer_Portal\Views\Home\Products.cshtml"
                                   Write(Battery.CertificateOfOperations);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 44 "C:\Users\Eric\Desktop\CustomerPortal\Rocket_Elevators_Customer_Portal\Views\Home\Products.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n");
            WriteLiteral(@"        <div class=""card"">
            <div class=""card-header"" id=""headingTwo"">
                <h5 class=""mb-0"">
                    <button class=""btn btn-link collapsed"" type=""button"" data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"">
                        Columns
                    </button>
                </h5>
            </div>
            <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionExample"">
                <div class=""card-body"">
                    <table class=""table table-bordered table-striped"">
                        <thead>
                            <tr>
                                <th>Column Id</th>
                                <th>Battery Id</th>
                                <th>Building Type</th>
                                <th>Floors Served</th>
                                <th>Status</th>
                            </tr>
                        </the");
            WriteLiteral("ad>\r\n                        <tbody>\r\n");
#nullable restore
#line 73 "C:\Users\Eric\Desktop\CustomerPortal\Rocket_Elevators_Customer_Portal\Views\Home\Products.cshtml"
                             foreach (var column in Model.Buildings.SelectMany(building => building.Batteries.SelectMany(battery => battery.Columns)))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 76 "C:\Users\Eric\Desktop\CustomerPortal\Rocket_Elevators_Customer_Portal\Views\Home\Products.cshtml"
                                   Write(column.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 77 "C:\Users\Eric\Desktop\CustomerPortal\Rocket_Elevators_Customer_Portal\Views\Home\Products.cshtml"
                                   Write(column.BatteryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 78 "C:\Users\Eric\Desktop\CustomerPortal\Rocket_Elevators_Customer_Portal\Views\Home\Products.cshtml"
                                   Write(column.BuildingType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 79 "C:\Users\Eric\Desktop\CustomerPortal\Rocket_Elevators_Customer_Portal\Views\Home\Products.cshtml"
                                   Write(column.NumberOfFloorsServed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 80 "C:\Users\Eric\Desktop\CustomerPortal\Rocket_Elevators_Customer_Portal\Views\Home\Products.cshtml"
                                   Write(column.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 82 "C:\Users\Eric\Desktop\CustomerPortal\Rocket_Elevators_Customer_Portal\Views\Home\Products.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <div class=""card"">
            <div class=""card-header"" id=""headingThree"">
                <h5 class=""mb-0"">
                    <button class=""btn btn-link collapsed"" type=""button"" data-toggle=""collapse"" data-target=""#collapseThree"" aria-expanded=""false"" aria-controls=""collapseThree"">
                        Elevators
                    </button>
                </h5>
            </div>

");
            WriteLiteral(@"            <div id=""collapseThree"" class=""collapse"" aria-labelledby=""headingThree"" data-parent=""#accordionExample"">
                <div class=""card-body"">
                    <table class=""table table-bordered table-striped"">
                        <thead>
                            <tr>
                                <th>Elevator Id</th>
                                <th>Column Id</th>
                                <th>Model</th>
                                <th>Serial Number</th>
                                <th>Status</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 111 "C:\Users\Eric\Desktop\CustomerPortal\Rocket_Elevators_Customer_Portal\Views\Home\Products.cshtml"
                             foreach (var elevator in Model.Buildings.SelectMany(building => building.Batteries.SelectMany(battery => battery.Columns.SelectMany(column => column.Elevators))))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 114 "C:\Users\Eric\Desktop\CustomerPortal\Rocket_Elevators_Customer_Portal\Views\Home\Products.cshtml"
                                   Write(elevator.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 115 "C:\Users\Eric\Desktop\CustomerPortal\Rocket_Elevators_Customer_Portal\Views\Home\Products.cshtml"
                                   Write(elevator.ColumnId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 116 "C:\Users\Eric\Desktop\CustomerPortal\Rocket_Elevators_Customer_Portal\Views\Home\Products.cshtml"
                                   Write(elevator.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 117 "C:\Users\Eric\Desktop\CustomerPortal\Rocket_Elevators_Customer_Portal\Views\Home\Products.cshtml"
                                   Write(elevator.SerialNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 118 "C:\Users\Eric\Desktop\CustomerPortal\Rocket_Elevators_Customer_Portal\Views\Home\Products.cshtml"
                                   Write(elevator.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 120 "C:\Users\Eric\Desktop\CustomerPortal\Rocket_Elevators_Customer_Portal\Views\Home\Products.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
