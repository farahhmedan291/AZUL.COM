#pragma checksum "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Reservations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c27a7aecba0ef70e280eb159808a985084c3964"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservations_Index), @"mvc.1.0.view", @"/Views/Reservations/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c27a7aecba0ef70e280eb159808a985084c3964", @"/Views/Reservations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e419cb68d7441d90842286bec0e0af2d67534ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservations_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AZUL.COM.Models.Reservation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Reservations\Index.cshtml"
  
    Layout = "~/Views/Shared/dash_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""d-flex justify-content-center"">
    <a href=""/Reservations/SearchByDate"">
        <button type=""button"" class=""btn btn-outline-dark btn-lg"" style=""margin: 40px 15px; "">
                <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-search"" viewBox=""0 0 16 16"">
                    <path d=""M11.742 10.344a6.5 6.5 0 1 0-1.397 1.398h-.001c.03.04.062.078.098.115l3.85 3.85a1 1 0 0 0 1.415-1.414l-3.85-3.85a1.007 1.007 0 0 0-.115-.1zM12 6.5a5.5 5.5 0 1 1-11 0 5.5 5.5 0 0 1 11 0z"" />
                </svg>
            Search
         </button>
    </a>
</div>
    <div id=""tab"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        ");
#nullable restore
#line 24 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Reservations\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ResDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 27 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Reservations\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.CheckInDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 30 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Reservations\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.CheckOutDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 33 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Reservations\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 36 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Reservations\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Room));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </th>
                    <th>
                       Room Price
                    </th>
                    <th>
                        Number of Days
                    </th>
                    <th>
                        Total Price
                    </th>

                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 51 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Reservations\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 55 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Reservations\Index.cshtml"
                   Write(item.ResDate.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    \r\n                    </td>\r\n                    <td>\r\n                       ");
#nullable restore
#line 59 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Reservations\Index.cshtml"
                  Write(item.CheckInDate.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                      \r\n                    </td>\r\n                    <td>\r\n                       ");
#nullable restore
#line 63 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Reservations\Index.cshtml"
                  Write(item.CheckOutDate.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 66 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Reservations\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Customer.FName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 69 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Reservations\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Room.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 72 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Reservations\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Room.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 75 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Reservations\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.numberOfDayes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 78 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Reservations\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ReservationsPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 81 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\Reservations\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
    <div class=""d-flex justify-content-center"">
        <button id=""export1"" onclick=""exportTableToCSV('reservations.csv')"" class=""btn btn-success text-white btn-lg "" style=""margin:20px 10px"">
            <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-file-earmark-spreadsheet-fill"" viewBox=""0 0 16 16"">
                <path d=""M6 12v-2h3v2H6z"" />
                <path d=""M9.293 0H4a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h8a2 2 0 0 0 2-2V4.707A1 1 0 0 0 13.707 4L10 .293A1 1 0 0 0 9.293 0zM9.5 3.5v-2l3 3h-2a1 1 0 0 1-1-1zM3 9h10v1h-3v2h3v1h-3v2H9v-2H6v2H5v-2H3v-1h2v-2H3V9z"" />
            </svg>
        Excel
        </button>
        <button id=""export2"" onclick=""createPDF()"" class=""btn btn-danger btn-lg"" style=""margin:20px 10px"">
            <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-file-earmark-pdf-fill"" viewBox=""0 0 16 16"">
                    <path d=""M");
            WriteLiteral(@"5.523 12.424c.14-.082.293-.162.459-.238a7.878 7.878 0 0 1-.45.606c-.28.337-.498.516-.635.572a.266.266 0 0 1-.035.012.282.282 0 0 1-.026-.044c-.056-.11-.054-.216.04-.36.106-.165.319-.354.647-.548zm2.455-1.647c-.119.025-.237.05-.356.078a21.148 21.148 0 0 0 .5-1.05 12.045 12.045 0 0 0 .51.858c-.217.032-.436.07-.654.114zm2.525.939a3.881 3.881 0 0 1-.435-.41c.228.005.434.022.612.054.317.057.466.147.518.209a.095.095 0 0 1 .026.064.436.436 0 0 1-.06.2.307.307 0 0 1-.094.124.107.107 0 0 1-.069.015c-.09-.003-.258-.066-.498-.256zM8.278 6.97c-.04.244-.108.524-.2.829a4.86 4.86 0 0 1-.089-.346c-.076-.353-.087-.63-.046-.822.038-.177.11-.248.196-.283a.517.517 0 0 1 .145-.04c.013.03.028.092.032.198.005.122-.007.277-.038.465z"" />
                    <path fill-rule=""evenodd"" d=""M4 0h5.293A1 1 0 0 1 10 .293L13.707 4a1 1 0 0 1 .293.707V14a2 2 0 0 1-2 2H4a2 2 0 0 1-2-2V2a2 2 0 0 1 2-2zm5.5 1.5v2a1 1 0 0 0 1 1h2l-3-3zM4.165 13.668c.09.18.23.343.438.419.207.075.412.04.58-.03.318-.13.635-.436.926-.786.333-.401.683-.927 1.021-1.51a");
            WriteLiteral(@"11.651 11.651 0 0 1 1.997-.406c.3.383.61.713.91.95.28.22.603.403.934.417a.856.856 0 0 0 .51-.138c.155-.101.27-.247.354-.416.09-.181.145-.37.138-.563a.844.844 0 0 0-.2-.518c-.226-.27-.596-.4-.96-.465a5.76 5.76 0 0 0-1.335-.05 10.954 10.954 0 0 1-.98-1.686c.25-.66.437-1.284.52-1.794.036-.218.055-.426.048-.614a1.238 1.238 0 0 0-.127-.538.7.7 0 0 0-.477-.365c-.202-.043-.41 0-.601.077-.377.15-.576.47-.651.823-.073.34-.04.736.046 1.136.088.406.238.848.43 1.295a19.697 19.697 0 0 1-1.062 2.227 7.662 7.662 0 0 0-1.482.645c-.37.22-.699.48-.897.787-.21.326-.275.714-.08 1.103z"" />
            </svg> 
           PDF
        </button>
    </div>
        <script>



            function exportTableToCSV(filename) {
                var csv = [];
                var rows = document.querySelectorAll(""table tr"");
                for (var i = 0; i < rows.length; i++) {
                    var row = [], cols = rows[i].querySelectorAll(""td, th"");
                    for (var j = 0; j < cols.length; j++)
            ");
            WriteLiteral(@"            row.push(cols[j].innerText);
                    csv.push(row.join("",""));
                }

                downloadCSV(csv.join(""\n""), filename);
            }

            function downloadCSV(csv, filename) {
                var csvFile;
                var downloadLink;

                csvFile = new Blob([csv], { type: ""text/csv"" });

                downloadLink = document.createElement(""a"");

                downloadLink.download = filename;
                downloadLink.href = window.URL.createObjectURL(csvFile);

                downloadLink.style.display = ""none"";

                document.body.appendChild(downloadLink);

                downloadLink.click();
            }


            function createPDF() {
                var sTable = document.getElementById('tab').innerHTML;

                var style = ""<style>"";
                style = style + ""table {width: 100%;font: 17px Calibri;}"";
                style = style + ""table, th, td {border: solid 1px ");
            WriteLiteral(@"#DDD; border-collapse: collapse;"";
                style = style + ""padding: 2px 3px;text-align: center;}"";
                style = style + ""</style>"";

               
                var win = window.open('', '', 'height=700,width=700');

                win.document.write('<html><head>');
                win.document.write('<title>Book</title>');  
                win.document.write(style);         
                win.document.write('</head>');
                win.document.write('<body>');
                win.document.write(sTable);        
                win.document.write('</body></html>');

                win.document.close(); 	

                win.print();  
            }

           
            var htmlTableToExcel = function (tableId, fileName = '') {
                var downloadedFileName = 'excel_table_data';
                var TableDataType = 'application/vnd.ms-excel';
                var selectTable = document.getElementById(tableId);
                var htmlTable ");
            WriteLiteral(@"= selectTable.outerHTML.replace(/ /g, '%20');

                filename = filename ? filename + '.xls' : downloadedFileName + '.xls';
                var downloadingURL = document.createElement(""a"");
                document.body.appendChild(downloadingURL);

                if (navigator.msSaveOrOpenBlob) {
                    var blob = new Blob(['\ufeff', htmlTable], {
                        type: TableDataType
                    });
                    navigator.msSaveOrOpenBlob(blob, fileName);
                } else {

                    downloadingURL.href = 'data:' + TableDataType + ', ' + htmlTable;
                    downloadingURL.download = fileName;
                    downloadingURL.click();
                }
            }

            function printTable() {
                var el = document.getElementById(""tableData"");

                el.setAttribute('border', '5px');
                el.setAttribute('cellpadding', '5');
                el.setAttribute('color', 'gre");
            WriteLiteral("en\');\r\n                newPrint = window.open(\"\");\r\n                newPrint.document.write(el.outerHTML);\r\n                newPrint.print();\r\n                newPrint.close();\r\n            }\r\n\r\n        </script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AZUL.COM.Models.Reservation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
