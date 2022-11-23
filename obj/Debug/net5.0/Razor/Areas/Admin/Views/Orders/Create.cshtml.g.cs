#pragma checksum "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Orders\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90003dc85686ea3e8a7ca53768fdb9619c382ccb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Orders_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Orders/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90003dc85686ea3e8a7ca53768fdb9619c382ccb", @"/Areas/Admin/Views/Orders/Create.cshtml")]
    public class Areas_Admin_Views_Orders_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectDotNetV2.Data.Entities.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Orders\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Create</h2>

<h4>Order</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
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
                <span asp-validation-for=""Country"" class=""text-danger""></span>
            </div>
");
            WriteLiteral(@"            <div class=""form-group"">
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
                <input asp-for=""State"" class=""form-control"" />
  ");
            WriteLiteral(@"              <span asp-validation-for=""State"" class=""text-danger""></span>
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
                <label asp-for=""OrderNote"" class=""control-labe");
            WriteLiteral(@"l""></label>
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
                <select asp-for=""UserId"" class =""form-control"" asp-items=""ViewBag.UserId""></select>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectDotNetV2.Data.Entities.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
