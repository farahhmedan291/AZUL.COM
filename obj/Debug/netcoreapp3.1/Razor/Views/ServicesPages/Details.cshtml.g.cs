#pragma checksum "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "907a950a96f88ae4cbf51cd286336d4b1a890c18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ServicesPages_Details), @"mvc.1.0.view", @"/Views/ServicesPages/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"907a950a96f88ae4cbf51cd286336d4b1a890c18", @"/Views/ServicesPages/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e419cb68d7441d90842286bec0e0af2d67534ec", @"/Views/_ViewImports.cshtml")]
    public class Views_ServicesPages_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AZUL.COM.Models.ServicesPage>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "907a950a96f88ae4cbf51cd286336d4b1a890c184253", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Details</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "907a950a96f88ae4cbf51cd286336d4b1a890c185314", async() => {
                WriteLiteral("\r\n\r\n<div>\r\n    <h4>ServicesPage</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HeaderImage));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.HeaderImage));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DescHeader));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.DescHeader));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DescParagraph));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.DescParagraph));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DescImage1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.DescImage1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DescImage2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.DescImage2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DescImage3));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.DescImage3));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DescSubHeader1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.DescSubHeader1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DescSubHeader2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.DescSubHeader2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DescSubHeader3));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.DescSubHeader3));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DescSubParagraph1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.DescSubParagraph1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DescSubParagraph2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.DescSubParagraph2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DescSubParagraph3));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.DescSubParagraph3));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ServicesHeader1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.ServicesHeader1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ServicesHeader2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.ServicesHeader2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ServicesHeader3));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 108 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.ServicesHeader3));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 111 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ServicesHeader4));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 114 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.ServicesHeader4));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 117 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ServicesHeader5));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 120 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.ServicesHeader5));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 123 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ServicesHeader6));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 126 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.ServicesHeader6));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 129 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ServicesParagraph1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 132 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.ServicesParagraph1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 135 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ServicesParagraph2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 138 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.ServicesParagraph2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 141 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ServicesParagraph3));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 144 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.ServicesParagraph3));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 147 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ServicesParagraph4));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 150 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.ServicesParagraph4));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 153 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ServicesParagraph5));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 156 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.ServicesParagraph5));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 159 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ServicesParagraph6));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 162 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.ServicesParagraph6));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "907a950a96f88ae4cbf51cd286336d4b1a890c1821853", async() => {
                    WriteLiteral("Edit");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 167 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\ServicesPages\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" |\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "907a950a96f88ae4cbf51cd286336d4b1a890c1824097", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AZUL.COM.Models.ServicesPage> Html { get; private set; }
    }
}
#pragma warning restore 1591
