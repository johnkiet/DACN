#pragma checksum "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Information\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be8e566ec21c7bbb9f2b3a20a22691a90f594edf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Information_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Information/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be8e566ec21c7bbb9f2b3a20a22691a90f594edf", @"/Areas/Admin/Views/Information/Index.cshtml")]
    public class Areas_Admin_Views_Information_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectDotNetV2.Data.Entities.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Information\Index.cshtml"
  
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
            BeginWriteAttribute("title", " title=\"", 1064, "\"", 1072, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"control-label\"> ");
#nullable restore
#line 29 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Information\Index.cshtml"
                                                                                             Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                                            <input asp-for=\"Name\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1237, "\"", 1287, 1);
#nullable restore
#line 30 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Information\Index.cshtml"
WriteAttributeValue(" ", 1245, Html.DisplayFor(model => model.UserName), 1246, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" disabled=""disabled"" />
                                            <span asp-validation-for=""Name"" class=""text-danger""></span>
                                        </div>
                                        <div class=""form-group"">
                                            <label asp-for=""Name""");
            BeginWriteAttribute("title", " title=\"", 1593, "\"", 1601, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"control-label\"> ");
#nullable restore
#line 34 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Information\Index.cshtml"
                                                                                             Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                                            <input asp-for=\"Name\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1769, "\"", 1822, 1);
#nullable restore
#line 35 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Information\Index.cshtml"
WriteAttributeValue(" ", 1777, Html.DisplayFor(model => model.CreatedDate), 1778, 44, false);

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
#line 40 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Information\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.NormalizedEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </label>\n                                            <input asp-for=\"Color\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 2394, "\"", 2451, 1);
#nullable restore
#line 42 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Information\Index.cshtml"
WriteAttributeValue("", 2402, Html.DisplayFor(model => model.ConcurrencyStamp), 2402, 49, false);

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
#line 47 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Information\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </label>\n                                            <input asp-for=\"Price\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 3020, "\"", 3072, 1);
#nullable restore
#line 49 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Information\Index.cshtml"
WriteAttributeValue("", 3028, Html.DisplayFor(model => model.PhoneNumber), 3028, 44, false);

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
#line 54 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Information\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </label>\n                                            <input asp-for=\"Price\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 3635, "\"", 3681, 1);
#nullable restore
#line 56 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Information\Index.cshtml"
WriteAttributeValue("", 3643, Html.DisplayFor(model => model.Email), 3643, 38, false);

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
#line 63 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Information\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.NormalizedUserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </label>\n                                            <input asp-for=\"Quantity\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 4365, "\"", 4424, 1);
#nullable restore
#line 65 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Information\Index.cshtml"
WriteAttributeValue("", 4373, Html.DisplayFor(model => model.NormalizedUserName), 4373, 51, false);

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
#line 70 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Information\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </label>\n                                            <input asp-for=\"Quantity\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 5002, "\"", 5054, 1);
#nullable restore
#line 72 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Information\Index.cshtml"
WriteAttributeValue("", 5010, Html.DisplayFor(model => model.PhoneNumber), 5010, 44, false);

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
#line 79 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Information\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.PasswordHash));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </label>\n                                            <input asp-for=\"Gender\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 5631, "\"", 5684, 1);
#nullable restore
#line 81 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Information\Index.cshtml"
WriteAttributeValue("", 5639, Html.DisplayFor(model => model.PasswordHash), 5639, 45, false);

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
#line 86 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Information\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.PhoneNumberConfirmed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </label>\n\n                                            <input asp-for=\"Gender\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 6266, "\"", 6327, 1);
#nullable restore
#line 89 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Information\Index.cshtml"
WriteAttributeValue("", 6274, Html.DisplayFor(model => model.PhoneNumberConfirmed), 6274, 53, false);

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
#line 94 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Information\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </label>\n                                            <input asp-for=\"Email\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 6892, "\"", 6938, 1);
#nullable restore
#line 96 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Information\Index.cshtml"
WriteAttributeValue("", 6900, Html.DisplayFor(model => model.Email), 6900, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" disabled=""disabled"" />
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectDotNetV2.Data.Entities.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
