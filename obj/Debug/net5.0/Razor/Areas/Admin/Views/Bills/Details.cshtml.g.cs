#pragma checksum "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Bills\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2ec7331bce7b1d016b2ca1462ad8acce2761be1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Bills_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Bills/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2ec7331bce7b1d016b2ca1462ad8acce2761be1", @"/Areas/Admin/Views/Bills/Details.cshtml")]
    public class Areas_Admin_Views_Bills_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectDotNetV2.Data.Entities.Bill>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Bills\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Details</h2>\n\n<div>\n    <h4>Bill</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
#nullable restore
#line 15 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Bills\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NameOrder));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 18 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Bills\Details.cshtml"
       Write(Html.DisplayFor(model => model.NameOrder));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
#nullable restore
#line 21 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Bills\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Receiver));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 24 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Bills\Details.cshtml"
       Write(Html.DisplayFor(model => model.Receiver));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
#nullable restore
#line 27 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Bills\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DatePayment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 30 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Bills\Details.cshtml"
       Write(Html.DisplayFor(model => model.DatePayment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
#nullable restore
#line 33 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Bills\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 36 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Bills\Details.cshtml"
       Write(Html.DisplayFor(model => model.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 939, "\"", 967, 1);
#nullable restore
#line 41 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Bills\Details.cshtml"
WriteAttributeValue("", 954, Model.BillId, 954, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\n    <a asp-action=\"Index\">Back to List</a>\n</div>\n");
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
