#pragma checksum "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Waiter\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e9fe7d51c69f3e3c07d65a87d789b67b7db8405"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Waiter_Index), @"mvc.1.0.view", @"/Views/Waiter/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e9fe7d51c69f3e3c07d65a87d789b67b7db8405", @"/Views/Waiter/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e419cb68d7441d90842286bec0e0af2d67534ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Waiter_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Waiter\Index.cshtml"
  
    Layout = "~/Views/Shared/WaiterDash_Layout.cshtml";

    var id = ViewBag.id;
    var allOrders = ViewBag.allOrders  ;
    var dayOrders = ViewBag.dayOrders  ;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid"">

  

    <!-- Content Row -->
    <div class=""row"">

    

        <div class=""col-xl-4 col-md-6 mb-4"">
            <div class=""card border-left-warning shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-warning text-uppercase mb-1"">
                                All Orders
                            </div>
                            <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
#nullable restore
#line 26 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Waiter\Index.cshtml"
                                                                           Write(allOrders);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                        <div class=""col-auto"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""30"" height=""30"" fill=""currentColor"" class=""bi bi-cart-check-fill fa-2x text-gray-300"" viewBox=""0 0 16 16"">
                                <path d=""M.5 1a.5.5 0 0 0 0 1h1.11l.401 1.607 1.498 7.985A.5.5 0 0 0 4 12h1a2 2 0 1 0 0 4 2 2 0 0 0 0-4h7a2 2 0 1 0 0 4 2 2 0 0 0 0-4h1a.5.5 0 0 0 .491-.408l1.5-8A.5.5 0 0 0 14.5 3H2.89l-.405-1.621A.5.5 0 0 0 2 1H.5zM6 14a1 1 0 1 1-2 0 1 1 0 0 1 2 0zm7 0a1 1 0 1 1-2 0 1 1 0 0 1 2 0zm-1.646-7.646-3 3a.5.5 0 0 1-.708 0l-1.5-1.5a.5.5 0 1 1 .708-.708L8 8.293l2.646-2.647a.5.5 0 0 1 .708.708z"" />
                            </svg>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-4 col-md-6 mb-4"">
            <div class=""card border-left-danger shadow h-100 py-2"">
                <div class=""card-body"">
              ");
            WriteLiteral(@"      <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-success text-uppercase mb-1"">
                                Today Orders
                            </div>
                            <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
#nullable restore
#line 45 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Waiter\Index.cshtml"
                                                                           Write(dayOrders);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                        <div class=""col-auto"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""30"" height=""30"" fill=""currentColor"" class=""bi bi-basket2-fill fa-2x text-gray-300"" viewBox=""0 0 16 16"">
                                <path d=""M5.929 1.757a.5.5 0 1 0-.858-.514L2.217 6H.5a.5.5 0 0 0-.5.5v1a.5.5 0 0 0 .5.5h.623l1.844 6.456A.75.75 0 0 0 3.69 15h8.622a.75.75 0 0 0 .722-.544L14.877 8h.623a.5.5 0 0 0 .5-.5v-1a.5.5 0 0 0-.5-.5h-1.717L10.93 1.243a.5.5 0 1 0-.858.514L12.617 6H3.383L5.93 1.757zM4 10a1 1 0 0 1 2 0v2a1 1 0 1 1-2 0v-2zm3 0a1 1 0 0 1 2 0v2a1 1 0 1 1-2 0v-2zm4-1a1 1 0 0 1 1 1v2a1 1 0 1 1-2 0v-2a1 1 0 0 1 1-1z"" />
                            </svg>
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
