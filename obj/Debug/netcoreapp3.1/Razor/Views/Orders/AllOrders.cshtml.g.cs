#pragma checksum "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Orders\AllOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "626dc9003f7aaa7a4c171c0777fc949c0f074f49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_AllOrders), @"mvc.1.0.view", @"/Views/Orders/AllOrders.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"626dc9003f7aaa7a4c171c0777fc949c0f074f49", @"/Views/Orders/AllOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e419cb68d7441d90842286bec0e0af2d67534ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_AllOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AZUL.COM.Models.Orders>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Orders\AllOrders.cshtml"
  
    ViewData["Title"] = "AllOrders";
    Layout = "~/Views/Shared/WaiterDash_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"margin:60px;\">All Orders</h1>\r\n\r\n<table class=\"table\"style=\"margin:60px;\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Orders\AllOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            \r\n            <th>\r\n                Meal Name\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Orders\AllOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 26 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Orders\AllOrders.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 30 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Orders\AllOrders.cshtml"
               Write(item.Date.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n               \r\n                <td>\r\n                    ");
#nullable restore
#line 34 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Orders\AllOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.Meal.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Orders\AllOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.Customer.FName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n               \r\n            </tr>\r\n");
#nullable restore
#line 41 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Orders\AllOrders.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AZUL.COM.Models.Orders>> Html { get; private set; }
    }
}
#pragma warning restore 1591