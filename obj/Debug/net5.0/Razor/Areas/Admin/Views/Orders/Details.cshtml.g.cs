#pragma checksum "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Orders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6098b0b4dfbc5b3cf3dd43b8879eea599de4dc3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Orders_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Orders/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6098b0b4dfbc5b3cf3dd43b8879eea599de4dc3a", @"/Areas/Admin/Views/Orders/Details.cshtml")]
    public class Areas_Admin_Views_Orders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectDotNetV2.Data.Entities.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Orders\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""page-wrapper"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <h1 class=""page-header"">Product</h1>
            </div>
            <!-- /.col-lg-12 -->
        </div>
        <!-- /.row -->
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""panel panel-default"">
                    <!-- /.panel-heading -->
                    <div class=""panel-body"">
                        <div class=""table-responsive"">


                            <div class=""row"">
                                <form asp-action=""Create"">

                                    <div class=""col-md-6"">
                                        <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
                                        <div class=""form-group"">
                                            <label asp-for=""Name""");
            BeginWriteAttribute("title", " title=\"", 1065, "\"", 1073, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"control-label\"> ");
#nullable restore
#line 29 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Orders\Details.cshtml"
                                                                                             Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                                            <input asp-for=\"Name\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1239, "\"", 1290, 1);
#nullable restore
#line 30 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Orders\Details.cshtml"
WriteAttributeValue(" ", 1247, Html.DisplayFor(model => model.FirstName), 1248, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" disabled=""disabled"" />
                                            <span asp-validation-for=""Name"" class=""text-danger""></span>
                                        </div>
                                        <div class=""form-group"">
                                            <label asp-for=""Name""");
            BeginWriteAttribute("title", " title=\"", 1596, "\"", 1604, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"control-label\"> ");
#nullable restore
#line 34 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Orders\Details.cshtml"
                                                                                             Write(Html.DisplayNameFor(model => model.StreetAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                                            <input asp-for=\"Name\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1774, "\"", 1829, 1);
#nullable restore
#line 35 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Orders\Details.cshtml"
WriteAttributeValue(" ", 1782, Html.DisplayFor(model => model.StreetAddress), 1783, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" disabled=""disabled"" />
                                            <span asp-validation-for=""Name"" class=""text-danger""></span>
                                        </div>
                                        <div class=""form-group"">
                                            <label asp-for=""Color"" class=""control-label"">
                                                ");
#nullable restore
#line 40 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Orders\Details.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </label>\n                                            <input asp-for=\"Color\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 2393, "\"", 2441, 1);
#nullable restore
#line 42 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Orders\Details.cshtml"
WriteAttributeValue("", 2401, Html.DisplayFor(model => model.Country), 2401, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" disabled=""disabled"" />
                                            <span asp-validation-for=""Color"" class=""text-danger""></span>
                                        </div>
                                        <div class=""form-group"">
                                            <label asp-for=""Price"" class=""control-label"">
                                                ");
#nullable restore
#line 47 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Orders\Details.cshtml"
                                           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </label>\n                                            <input asp-for=\"Price\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 3010, "\"", 3062, 1);
#nullable restore
#line 49 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Orders\Details.cshtml"
WriteAttributeValue("", 3018, Html.DisplayFor(model => model.PhoneNumber), 3018, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" disabled=""disabled"" />
                                            <span asp-validation-for=""Price"" class=""text-danger""></span>
                                        </div>
                                        <div class=""form-group"">
                                            <label asp-for=""Price"" class=""control-label"">
                                                ");
#nullable restore
#line 54 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Orders\Details.cshtml"
                                           Write(Html.DisplayNameFor(model => model.OrderDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </label>\n                                            <input asp-for=\"Price\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 3632, "\"", 3685, 1);
#nullable restore
#line 56 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Orders\Details.cshtml"
WriteAttributeValue("", 3640, Html.DisplayFor(model => model.OrderDetails), 3640, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" disabled=""disabled"" />
                                            <span asp-validation-for=""Price"" class=""text-danger""></span>
                                        </div>
                                    </div>
                                    <div class=""col-md-6"">
                                        <div class=""form-group"">
                                            <label asp-for=""Quantity"" class=""control-label"">
                                                ");
#nullable restore
#line 63 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Orders\Details.cshtml"
                                           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </label>\n                                            <input asp-for=\"Quantity\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 4359, "\"", 4408, 1);
#nullable restore
#line 65 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Orders\Details.cshtml"
WriteAttributeValue("", 4367, Html.DisplayFor(model => model.LastName), 4367, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" disabled=""disabled"" />
                                            <span asp-validation-for=""Quantity"" class=""text-danger""></span>
                                        </div>
                                        <div class=""form-group"">
                                            <label asp-for=""Quantity"" class=""control-label"">
                                                ");
#nullable restore
#line 70 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Orders\Details.cshtml"
                                           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </label>\n                                            <input asp-for=\"Quantity\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 4979, "\"", 5024, 1);
#nullable restore
#line 72 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Orders\Details.cshtml"
WriteAttributeValue("", 4987, Html.DisplayFor(model => model.City), 4987, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" disabled=""disabled"" />
                                            <span asp-validation-for=""Quantity"" class=""text-danger""></span>
                                        </div>


                                        <div class=""form-group"">
                                            <label asp-for=""Gender"" class=""control-label"">
                                                ");
#nullable restore
#line 79 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Orders\Details.cshtml"
                                           Write(Html.DisplayNameFor(model => model.OrderTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </label>\n                                            <input asp-for=\"Gender\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 5599, "\"", 5650, 1);
#nullable restore
#line 81 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Orders\Details.cshtml"
WriteAttributeValue("", 5607, Html.DisplayFor(model => model.OrderTotal), 5607, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" disabled=""disabled"" />
                                            <span asp-validation-for=""Gender"" class=""text-danger""></span>
                                        </div>
                                        <div class=""form-group"">
                                            <label asp-for=""Gender"" class=""control-label"">
                                                ");
#nullable restore
#line 86 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Orders\Details.cshtml"
                                           Write(Html.DisplayNameFor(model => model.OrderPlaced));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </label>\n\n                                            <input asp-for=\"Gender\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 6223, "\"", 6275, 1);
#nullable restore
#line 89 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Orders\Details.cshtml"
WriteAttributeValue("", 6231, Html.DisplayFor(model => model.OrderPlaced), 6231, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" disabled=""disabled"" />
                                            <span asp-validation-for=""Gender"" class=""text-danger""></span>
                                        </div>
                                        <div class=""form-group"">
                                            <label asp-for=""Gender"" class=""control-label"">
                                                ");
#nullable restore
#line 94 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Orders\Details.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </label>\n                                            <input asp-for=\"Email\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 6840, "\"", 6886, 1);
#nullable restore
#line 96 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Orders\Details.cshtml"
WriteAttributeValue("", 6848, Html.DisplayFor(model => model.Email), 6848, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" disabled=""disabled""/>
                                            <span asp-validation-for=""Gender"" class=""text-danger""></span>
                                        </div>
                                    </div>


                                </form>
                          
                            </div>
                        </div>



                        <!-- /.table-responsive -->
                    </div>
                    <!-- /.panel-body -->
                </div>
                <!-- /.panel -->
            </div>
            <!-- /.col-lg-12 -->
        </div>
        <!-- /.row -->
        <!-- /.row -->
    </div>
    <!-- /.container-fluid -->
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