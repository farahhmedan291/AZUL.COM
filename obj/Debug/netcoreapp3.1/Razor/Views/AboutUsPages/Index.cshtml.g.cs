#pragma checksum "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b85f229fc578eb6e4a9a67085cfe9b2663a8d7a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AboutUsPages_Index), @"mvc.1.0.view", @"/Views/AboutUsPages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b85f229fc578eb6e4a9a67085cfe9b2663a8d7a3", @"/Views/AboutUsPages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e419cb68d7441d90842286bec0e0af2d67534ec", @"/Views/_ViewImports.cshtml")]
    public class Views_AboutUsPages_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AZUL.COM.Models.AboutUsPage>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b85f229fc578eb6e4a9a67085cfe9b2663a8d7a34851", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b85f229fc578eb6e4a9a67085cfe9b2663a8d7a35910", async() => {
                WriteLiteral("\r\n<p>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b85f229fc578eb6e4a9a67085cfe9b2663a8d7a36179", async() => {
                    WriteLiteral("Create New");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HeaderImage));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DescImage));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DescHeader));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DescParagraph));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DescImage2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DescHeader2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DescParagraph2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FeaturesImage1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FeaturesImage2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FeaturesImage3));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FeaturesHeader));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 55 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FeaturesImagePoint1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 58 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FeaturesImagePoint2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 61 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FeaturesImagePoint3));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 64 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FeaturesImagePoint4));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 67 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FeaturesImagePoint5));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 70 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FeaturesImagePoint6));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 73 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FeaturesImagePoint7));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 76 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FeaturesImagePoint8));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 79 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FeaturesImagePoint9));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 82 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RateHeader));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 85 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RateParagraph1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 88 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RateParagraph2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 91 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RateName1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 94 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RateName2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 97 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RateImage1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 100 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RateImage2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 106 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 109 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HeaderImage));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 112 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DescImage));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 115 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DescHeader));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 118 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DescParagraph));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 121 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DescImage2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 124 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DescHeader2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 127 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DescParagraph2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 130 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FeaturesImage1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 133 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FeaturesImage2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 136 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FeaturesImage3));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 139 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FeaturesHeader));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 142 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FeaturesImagePoint1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 145 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FeaturesImagePoint2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 148 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FeaturesImagePoint3));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 151 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FeaturesImagePoint4));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 154 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FeaturesImagePoint5));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 157 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FeaturesImagePoint6));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 160 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FeaturesImagePoint7));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 163 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FeaturesImagePoint8));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 166 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FeaturesImagePoint9));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 169 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RateHeader));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 172 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RateParagraph1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 175 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RateParagraph2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 178 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RateName1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 181 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RateName2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 184 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RateImage1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 187 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RateImage2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b85f229fc578eb6e4a9a67085cfe9b2663a8d7a325596", async() => {
                    WriteLiteral("Edit");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 190 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
                                       WriteLiteral(item.Id);

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
                WriteLiteral(" |\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b85f229fc578eb6e4a9a67085cfe9b2663a8d7a327860", async() => {
                    WriteLiteral("Details");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 191 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
                                          WriteLiteral(item.Id);

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
                WriteLiteral(" |\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b85f229fc578eb6e4a9a67085cfe9b2663a8d7a330130", async() => {
                    WriteLiteral("Delete");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 192 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
                                         WriteLiteral(item.Id);

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
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 195 "C:\Users\Dell\Desktop\The First Project\AZUL.COM\Views\AboutUsPages\Index.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AZUL.COM.Models.AboutUsPage>> Html { get; private set; }
    }
}
#pragma warning restore 1591