#pragma checksum "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\OrderDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b82ea24d1bae8f3d7e32b210fa5e018967fb632"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_OrderDetails_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/OrderDetails/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b82ea24d1bae8f3d7e32b210fa5e018967fb632", @"/Areas/Admin/Views/OrderDetails/Index.cshtml")]
    public class Areas_Admin_Views_OrderDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjectDotNetV2.Data.Entities.OrderDetail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\OrderDetails\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Index</h2>\n\n<p>\n    <a asp-action=\"Create\">Create New</a>\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 17 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\OrderDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 20 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\OrderDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 23 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\OrderDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 26 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\OrderDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Order));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 32 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\OrderDetails\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 35 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\OrderDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 38 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\OrderDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 41 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\OrderDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Product.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 44 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\OrderDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Order.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 47 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\OrderDetails\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjectDotNetV2.Data.Entities.OrderDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
