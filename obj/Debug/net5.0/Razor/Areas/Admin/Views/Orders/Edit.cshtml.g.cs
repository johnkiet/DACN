#pragma checksum "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Orders\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2320045afe27eaef8cb6684e844eb430448dc34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Orders_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Orders/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2320045afe27eaef8cb6684e844eb430448dc34", @"/Areas/Admin/Views/Orders/Edit.cshtml")]
    public class Areas_Admin_Views_Orders_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectDotNetV2.Data.Entities.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Orders\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Edit</h2>

<h4>Order</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""OrderId"" />
            <div class=""form-group"">
                <label asp-for=""FirstName"" class=""control-label""></label>
                <input asp-for=""FirstName"" class=""form-control"" />
                <span asp-validation-for=""FirstName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""LastName"" class=""control-label""></label>
                <input asp-for=""LastName"" class=""form-control"" />
                <span asp-validation-for=""LastName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Country"" class=""control-label""></label>
                <input asp-for=""Country"" class=""form-control"" />
                <span asp-validation-for=""Countr");
            WriteLiteral(@"y"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""StreetAddress"" class=""control-label""></label>
                <input asp-for=""StreetAddress"" class=""form-control"" />
                <span asp-validation-for=""StreetAddress"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ApartmentAddress"" class=""control-label""></label>
                <input asp-for=""ApartmentAddress"" class=""form-control"" />
                <span asp-validation-for=""ApartmentAddress"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""City"" class=""control-label""></label>
                <input asp-for=""City"" class=""form-control"" />
                <span asp-validation-for=""City"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""State"" class=""control-label""></label>
               ");
            WriteLiteral(@" <input asp-for=""State"" class=""form-control"" />
                <span asp-validation-for=""State"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""PhoneNumber"" class=""control-label""></label>
                <input asp-for=""PhoneNumber"" class=""form-control"" />
                <span asp-validation-for=""PhoneNumber"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Email"" class=""control-label""></label>
                <input asp-for=""Email"" class=""form-control"" />
                <span asp-validation-for=""Email"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""OrderTotal"" class=""control-label""></label>
                <input asp-for=""OrderTotal"" class=""form-control"" />
                <span asp-validation-for=""OrderTotal"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
            ");
            WriteLiteral(@"    <label asp-for=""OrderNote"" class=""control-label""></label>
                <input asp-for=""OrderNote"" class=""form-control"" />
                <span asp-validation-for=""OrderNote"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""OrderPlaced"" class=""control-label""></label>
                <input asp-for=""OrderPlaced"" class=""form-control"" />
                <span asp-validation-for=""OrderPlaced"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""UserId"" class=""control-label""></label>
                <select asp-for=""UserId"" class=""form-control"" asp-items=""ViewBag.UserId""></select>
                <span asp-validation-for=""UserId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to");
            WriteLiteral(" List</a>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectDotNetV2.Data.Entities.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
