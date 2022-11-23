#pragma checksum "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "075df4fd402b990cd014fe10d1c67b9493669d0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Products_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Products/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"075df4fd402b990cd014fe10d1c67b9493669d0e", @"/Areas/Admin/Views/Products/Details.cshtml")]
    public class Areas_Admin_Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectDotNetV2.Data.Entities.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:20%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Products\Details.cshtml"
  
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
            BeginWriteAttribute("title", " title=\"", 1068, "\"", 1076, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"control-label\"> ");
#nullable restore
#line 30 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Products\Details.cshtml"
                                                                                             Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                                            <input asp-for=\"Name\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1237, "\"", 1283, 1);
#nullable restore
#line 31 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Products\Details.cshtml"
WriteAttributeValue(" ", 1245, Html.DisplayFor(model => model.Name), 1246, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" disabled=""disabled"" />
                                            <span asp-validation-for=""Name"" class=""text-danger""></span>
                                        </div>
                                        <div class=""form-group"">
                                            <label asp-for=""ShortDescription"" class=""control-label"">
                                                ");
#nullable restore
#line 36 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Products\Details.cshtml"
                                           Write(Html.DisplayNameFor(model => model.ShortDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </label>\n                                            <textarea style=\"width:100%;\" class=\"form-text\" disabled=\"disabled\">");
#nullable restore
#line 38 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Products\Details.cshtml"
                                                                                                           Write(Html.DisplayFor(model => model.ShortDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </textarea>
                                            <span asp-validation-for=""ShortDescription"" class=""text-danger""></span>
                                        </div>
                                        <div class=""form-group"">
                                            <label asp-for=""Color"" class=""control-label"">
                                                ");
#nullable restore
#line 43 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Products\Details.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </label>\n                                            <input asp-for=\"Color\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 2503, "\"", 2561, 1);
#nullable restore
#line 45 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Products\Details.cshtml"
WriteAttributeValue("            ", 2511, Html.DisplayFor(model => model.Color), 2523, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"disabled=""disabled"" />
                                            <span asp-validation-for=""Color"" class=""text-danger""></span>
                                        </div>
                                        <div class=""form-group"">
                                            <label asp-for=""Price"" class=""control-label"">
                                                ");
#nullable restore
#line 50 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Products\Details.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </label>\n                                            <input asp-for=\"Price\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 3123, "\"", 3169, 1);
#nullable restore
#line 52 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Products\Details.cshtml"
WriteAttributeValue("", 3131, Html.DisplayFor(model => model.Price), 3131, 38, false);

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
#line 61 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Products\Details.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </label>\n                                            <input asp-for=\"Quantity\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 3845, "\"", 3894, 1);
#nullable restore
#line 63 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Products\Details.cshtml"
WriteAttributeValue("", 3853, Html.DisplayFor(model => model.Quantity), 3853, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" disabled=""disabled"" />
                                            <span asp-validation-for=""Quantity"" class=""text-danger""></span>
                                        </div>
                                        <div class=""form-group"">
                                            <label asp-for=""Description"" class=""control-label"">
                                                ");
#nullable restore
#line 68 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Products\Details.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </label>\n                                            <textarea style=\"width:100%;\" class=\"form-text\" disabled=\"disabled\">");
#nullable restore
#line 70 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Products\Details.cshtml"
                                                                                                           Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
                                            <span asp-validation-for=""Description"" class=""text-danger""></span>
                                        </div>
                                        <div class=""form-group"">
                                            <label asp-for=""CategoryId"" class=""control-label"">
                                                ");
#nullable restore
#line 75 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Products\Details.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </label>
                                            <select asp-for=""CategoryId"" class=""form-control"" asp-items=""ViewBag.CategoryId""></select>
                                        </div>
                                        <div class=""form-group"">
                                            <label asp-for=""Gender"" class=""control-label"">
                                                ");
#nullable restore
#line 81 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Products\Details.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </label>\n                                            <input asp-for=\"Gender\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 5589, "\"", 5649, 2);
#nullable restore
#line 83 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Products\Details.cshtml"
WriteAttributeValue("            ", 5597, Html.DisplayFor(model => model.Gender), 5609, 39, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("\n", 5648, "", 5649, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" disabled=""disabled"" />
                                            <span asp-validation-for=""Gender"" class=""text-danger""></span>
                                        </div>
                                    </div>


                                </form>
                                <h5 style=""text-align:center;"">Image Products</h5>
");
#nullable restore
#line 92 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Products\Details.cshtml"
                                  var image1 = @Html.DisplayFor(model => model.ProductFirstImage);
                                    var image2 = @Html.DisplayFor(model => model.ProductSecondImage);
                                    var image3 = @Html.DisplayFor(model => model.ProductThirdImage);

                                    if (image1 != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "075df4fd402b990cd014fe10d1c67b9493669d0e15050", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6442, "~/assets/img/product/", 6442, 21, true);
#nullable restore
#line 98 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Products\Details.cshtml"
AddHtmlAttributeValue("", 6463, image1, 6463, 7, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 99 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Products\Details.cshtml"
                                    }
                                    if (image2 != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "075df4fd402b990cd014fe10d1c67b9493669d0e17045", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6676, "~/assets/img/product/", 6676, 21, true);
#nullable restore
#line 102 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Products\Details.cshtml"
AddHtmlAttributeValue("", 6697, image2, 6697, 7, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 103 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Products\Details.cshtml"

                                    }
                                    if (image3 != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "075df4fd402b990cd014fe10d1c67b9493669d0e19043", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6912, "~/assets/img/product/", 6912, 21, true);
#nullable restore
#line 107 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Products\Details.cshtml"
AddHtmlAttributeValue("", 6933, image3, 6933, 7, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 108 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Products\Details.cshtml"

                                    }

                                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"





                                }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectDotNetV2.Data.Entities.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
