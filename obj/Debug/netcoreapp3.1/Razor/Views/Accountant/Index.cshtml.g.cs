#pragma checksum "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Accountant\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dbe5cb57d4b86d1c20a936b76381c4c033d79d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accountant_Index), @"mvc.1.0.view", @"/Views/Accountant/Index.cshtml")]
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
#line 1 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\_ViewImports.cshtml"
using AZUL.COM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\_ViewImports.cshtml"
using AZUL.COM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dbe5cb57d4b86d1c20a936b76381c4c033d79d9", @"/Views/Accountant/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e419cb68d7441d90842286bec0e0af2d67534ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Accountant_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Accountant\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AccDash_Layout.cshtml";
    var id = ViewBag.id;
    var room = ViewBag.roomNumber;
    var customer = ViewBag.customrNumber;
    var service = ViewBag.serNumber;
    var salary = ViewBag.Salary;
    var books = ViewBag.books;
    var NetProfit = ViewBag.NetProfit;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">

    <!-- Page Heading -->
    <div class=""d-sm-flex align-items-center justify-content-between mb-4"">
        <h1 class=""h3 mb-0 text-gray-800"">Admin Dashboard</h1>

    </div>

    <!-- Content Row -->
    <div class=""row"">

        <!-- Earnings (Monthly) Card Example -->
        <div class=""col-xl-4 col-md-6 mb-4"">
            <div class=""card border-left-dark shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-dark text-uppercase mb-1"">
                                Users
                            </div>
                            <div class=""h5 mb-0 font-weight-bold text-gray-800"">
                                ");
#nullable restore
#line 35 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Accountant\Index.cshtml"
                           Write(customer);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-auto"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""30"" height=""30"" fill=""currentColor"" class=""bi bi-person-fill fa-2x text-gray-300"" viewBox=""0 0 16 16"">
                                <path d=""M3 14s-1 0-1-1 1-4 6-4 6 3 6 4-1 1-1 1H3zm5-6a3 3 0 1 0 0-6 3 3 0 0 0 0 6z"" />
                            </svg>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Earnings (Monthly) Card Example -->
        <div class=""col-xl-4 col-md-6 mb-4"">
            <div class=""card border-left-success shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-success text-uppercase mb-1"">
                       ");
            WriteLiteral("         Services\r\n                            </div>\r\n                            <div class=\"h5 mb-0 font-weight-bold text-gray-800\">");
#nullable restore
#line 57 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Accountant\Index.cshtml"
                                                                           Write(service);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                        <div class=""col-auto"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""30"" height=""30"" fill=""currentColor"" class=""bi bi-percent fa-2x text-gray-300"" viewBox=""0 0 16 16"">
                                <path d=""M13.442 2.558a.625.625 0 0 1 0 .884l-10 10a.625.625 0 1 1-.884-.884l10-10a.625.625 0 0 1 .884 0zM4.5 6a1.5 1.5 0 1 1 0-3 1.5 1.5 0 0 1 0 3zm0 1a2.5 2.5 0 1 0 0-5 2.5 2.5 0 0 0 0 5zm7 6a1.5 1.5 0 1 1 0-3 1.5 1.5 0 0 1 0 3zm0 1a2.5 2.5 0 1 0 0-5 2.5 2.5 0 0 0 0 5z"" />
                            </svg>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Rooms Card Example -->
        <div class=""col-xl-4 col-md-6 mb-4"">
            <div class=""card border-left-info shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class");
            WriteLiteral(@"=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-info text-uppercase mb-1"">
                                Net Profit
                            </div>
                            <div class=""row no-gutters align-items-center"">
                                <div class=""col-auto"">
                                    <div class=""h5 mb-0 mr-3 font-weight-bold text-gray-800"">");
#nullable restore
#line 80 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Accountant\Index.cshtml"
                                                                                        Write(NetProfit);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                </div>
                               
                            </div>
                        </div>
                        <div class=""col-auto"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""30"" height=""30"" fill=""currentColor"" class=""bi bi-graph-up fa-2x text-gray-300"" viewBox=""0 0 16 16"">
                                <path fill-rule=""evenodd"" d=""M0 0h1v15h15v1H0V0zm10 3.5a.5.5 0 0 1 .5-.5h4a.5.5 0 0 1 .5.5v4a.5.5 0 0 1-1 0V4.9l-3.613 4.417a.5.5 0 0 1-.74.037L7.06 6.767l-3.656 5.027a.5.5 0 0 1-.808-.588l4-5.5a.5.5 0 0 1 .758-.06l2.609 2.61L13.445 4H10.5a.5.5 0 0 1-.5-.5z"" />
                            </svg>
                            
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Reservations Card Example -->
        <div class=""col-xl-4 col-md-6 mb-4"">
            <div class=""card border-left-warning shadow h-100 py-2"">
        ");
            WriteLiteral(@"        <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-warning text-uppercase mb-1"">
                                Rooms
                            </div>
                            <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
#nullable restore
#line 105 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Accountant\Index.cshtml"
                                                                           Write(room);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                        <div class=""col-auto"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""30"" height=""30"" fill=""currentColor"" class=""bi bi-shop-window fa-2x text-gray-300"" viewBox=""0 0 16 16"">
                                <path d=""M2.97 1.35A1 1 0 0 1 3.73 1h8.54a1 1 0 0 1 .76.35l2.609 3.044A1.5 1.5 0 0 1 16 5.37v.255a2.375 2.375 0 0 1-4.25 1.458A2.371 2.371 0 0 1 9.875 8 2.37 2.37 0 0 1 8 7.083 2.37 2.37 0 0 1 6.125 8a2.37 2.37 0 0 1-1.875-.917A2.375 2.375 0 0 1 0 5.625V5.37a1.5 1.5 0 0 1 .361-.976l2.61-3.045zm1.78 4.275a1.375 1.375 0 0 0 2.75 0 .5.5 0 0 1 1 0 1.375 1.375 0 0 0 2.75 0 .5.5 0 0 1 1 0 1.375 1.375 0 1 0 2.75 0V5.37a.5.5 0 0 0-.12-.325L12.27 2H3.73L1.12 5.045A.5.5 0 0 0 1 5.37v.255a1.375 1.375 0 0 0 2.75 0 .5.5 0 0 1 1 0zM1.5 8.5A.5.5 0 0 1 2 9v6h12V9a.5.5 0 0 1 1 0v6h.5a.5.5 0 0 1 0 1H.5a.5.5 0 0 1 0-1H1V9a.5.5 0 0 1 .5-.5zm2 .5a.5.5 0 0 1 .5.5V13h8V9.5a.5.5 0 0 1 1 0V13a1 1 0 0 1-1 1H4a1 1 0 0 1-1-1V9.5a.5.5 0 0 1 .5-");
            WriteLiteral(@".5z"" />
                            </svg>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-4 col-md-6 mb-4"">
            <div class=""card border-left-success shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-success text-uppercase mb-1"">
                                Outlay
                            </div>
                            <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
#nullable restore
#line 124 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Accountant\Index.cshtml"
                                                                           Write(salary);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fas fa-dollar-sign fa-2x text-gray-300""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-4 col-md-6 mb-4"">
            <div class=""card border-left-success shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-success text-uppercase mb-1"">
                                Earnings
                            </div>
                            <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
#nullable restore
#line 141 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Accountant\Index.cshtml"
                                                                           Write(books);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fas fa-dollar-sign fa-2x text-gray-300""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>




</div>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
