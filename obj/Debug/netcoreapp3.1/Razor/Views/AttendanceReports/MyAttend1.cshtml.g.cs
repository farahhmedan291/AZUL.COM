#pragma checksum "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AttendanceReports\MyAttend1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f461235cb512deeba67ac0d8786e450aa1c3542"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AttendanceReports_MyAttend1), @"mvc.1.0.view", @"/Views/AttendanceReports/MyAttend1.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f461235cb512deeba67ac0d8786e450aa1c3542", @"/Views/AttendanceReports/MyAttend1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e419cb68d7441d90842286bec0e0af2d67534ec", @"/Views/_ViewImports.cshtml")]
    public class Views_AttendanceReports_MyAttend1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AZUL.COM.Models.AttendanceReport>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AttendanceReports\MyAttend1.cshtml"
  
    ViewData["Title"] = "MyAttend1";
    Layout = "~/Views/Shared/AccDash_Layout.cshtml";
    var attendDay = ViewBag.attendDay;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <!-- Content Row -->
    <div class=""row"">

        <!-- Earnings (Monthly) Card Example -->
        <div class=""col-xl-4 col-md-6 mb-4"">
            <div class=""card border-left-dark shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-dark text-uppercase mb-1"">
                                Number of Days
                            </div>
                            <div class=""h5 mb-0 font-weight-bold text-gray-800"">
                                ");
#nullable restore
#line 23 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AttendanceReports\MyAttend1.cshtml"
                           Write(attendDay);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-auto"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-calendar-day"" viewBox=""0 0 16 16"">
                                <path d=""M4.684 11.523v-2.3h2.261v-.61H4.684V6.801h2.464v-.61H4v5.332h.684zm3.296 0h.676V8.98c0-.554.227-1.007.953-1.007.125 0 .258.004.329.015v-.613a1.806 1.806 0 0 0-.254-.02c-.582 0-.891.32-1.012.567h-.02v-.504H7.98v4.105zm2.805-5.093c0 .238.192.425.43.425a.428.428 0 1 0 0-.855.426.426 0 0 0-.43.43zm.094 5.093h.672V7.418h-.672v4.105z"" />
                                <path d=""M3.5 0a.5.5 0 0 1 .5.5V1h8V.5a.5.5 0 0 1 1 0V1h1a2 2 0 0 1 2 2v11a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V3a2 2 0 0 1 2-2h1V.5a.5.5 0 0 1 .5-.5zM1 4v10a1 1 0 0 0 1 1h12a1 1 0 0 0 1-1V4H1z"" />
                            </svg>
                        </div>
                    </div>
                </div>
            </div>



");
            WriteLiteral("\r\n        </div>\r\n\r\n\r\n\r\n\r\n    </div>\r\n</div>\r\n\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 51 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AttendanceReports\MyAttend1.cshtml"
               Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 54 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AttendanceReports\MyAttend1.cshtml"
               Write(Html.DisplayNameFor(model => model.EnterHour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 57 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AttendanceReports\MyAttend1.cshtml"
               Write(Html.DisplayNameFor(model => model.ExitHour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n                <th>\r\n                    ");
#nullable restore
#line 61 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AttendanceReports\MyAttend1.cshtml"
               Write(Html.DisplayNameFor(model => model.numberOfHour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 68 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AttendanceReports\MyAttend1.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 72 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AttendanceReports\MyAttend1.cshtml"
                   Write(item.Date.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 75 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AttendanceReports\MyAttend1.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EnterHour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 78 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AttendanceReports\MyAttend1.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ExitHour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 83 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AttendanceReports\MyAttend1.cshtml"
                   Write(Html.DisplayFor(modelItem => item.numberOfHour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 87 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AttendanceReports\MyAttend1.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AZUL.COM.Models.AttendanceReport>> Html { get; private set; }
    }
}
#pragma warning restore 1591