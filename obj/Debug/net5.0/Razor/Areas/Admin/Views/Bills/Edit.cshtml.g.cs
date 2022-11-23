#pragma checksum "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Bills\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9babb67b19c9a35134e14aecbef1632279113a27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Bills_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Bills/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9babb67b19c9a35134e14aecbef1632279113a27", @"/Areas/Admin/Views/Bills/Edit.cshtml")]
    public class Areas_Admin_Views_Bills_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectDotNetV2.Data.Entities.Bill>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Bills\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Edit</h2>

<h4>Bill</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""BillId"" />
            <div class=""form-group"">
                <label asp-for=""NameOrder"" class=""control-label""></label>
                <input asp-for=""NameOrder"" class=""form-control"" />
                <span asp-validation-for=""NameOrder"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Receiver"" class=""control-label""></label>
                <input asp-for=""Receiver"" class=""form-control"" />
                <span asp-validation-for=""Receiver"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DatePayment"" class=""control-label""></label>
                <input asp-for=""DatePayment"" class=""form-control"" />
                <span asp-validation-for=""");
            WriteLiteral(@"DatePayment"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""price"" class=""control-label""></label>
                <input asp-for=""price"" class=""form-control"" />
                <span asp-validation-for=""price"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-default"" />
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectDotNetV2.Data.Entities.Bill> Html { get; private set; }
    }
}
#pragma warning restore 1591
