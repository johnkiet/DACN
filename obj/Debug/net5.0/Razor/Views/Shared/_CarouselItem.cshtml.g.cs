#pragma checksum "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Views\Shared\_CarouselItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "866cd7a2a2b45027fb98ac59f441c651b1ccc98b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CarouselItem), @"mvc.1.0.view", @"/Views/Shared/_CarouselItem.cshtml")]
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
#line 1 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Views\_ViewImports.cshtml"
using ProjectDotNetV2.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Views\_ViewImports.cshtml"
using ProjectDotNetV2.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Views\_ViewImports.cshtml"
using ProjectDotNetV2.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"866cd7a2a2b45027fb98ac59f441c651b1ccc98b", @"/Views/Shared/_CarouselItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff995e174a512a85a6a2fc5629db289ca757c652", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CarouselItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "App", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SingleProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/cart/span-new.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div class=\"col-lg-3\">\n        <div class=\"single_product\">\n            <div class=\"product_thumb\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "866cd7a2a2b45027fb98ac59f441c651b1ccc98b5617", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "866cd7a2a2b45027fb98ac59f441c651b1ccc98b5833", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 221, "~/assets/img/product/", 221, 21, true);
#nullable restore
#line 5 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Views\Shared\_CarouselItem.cshtml"
AddHtmlAttributeValue("", 242, Model.ProductFirstImage, 242, 24, false);

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
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 5 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Views\Shared\_CarouselItem.cshtml"
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
            WriteLiteral("\n                <div class=\"img_icone\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "866cd7a2a2b45027fb98ac59f441c651b1ccc98b9681", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n");
            WriteLiteral("                <div class=\"product_action\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "866cd7a2a2b45027fb98ac59f441c651b1ccc98b10916", async() => {
                WriteLiteral(" <i class=\"fa fa-shopping-cart\"></i> Add to cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Views\Shared\_CarouselItem.cshtml"
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
            WriteLiteral("\n                </div>\n            </div>\n            <div class=\"product_content\">\n                <span class=\"product_price\">$");
#nullable restore
#line 17 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Views\Shared\_CarouselItem.cshtml"
                                        Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                <h3 class=\"product_title\"><a href=\"single-product.html\">");
#nullable restore
#line 18 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Views\Shared\_CarouselItem.cshtml"
                                                                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></h3>
            </div>
            <div class=""product_info"">
                <ul>
                    <li><a href=""#"" title="" Add to Wishlist "">Add to Wishlist</a></li>
                    <li><a href=""#"" data-toggle=""modal"" data-target=""#modal_box"" title=""Quick view"">View Detail</a></li>
                </ul>
            </div>
        </div>
    </div>
    <!-- modal area start -->
    <!--<div class=""modal fade"" id=""modal_box"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
            <div class=""modal-content"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
                <div class=""modal_body"">
                    <div class=""container"">
                        <div class=""row"">
                            <div class=""col-lg-5 col-md-5 col-sm-12"">
                                <div class=""mo");
            WriteLiteral(@"dal_tab"">
                                    <div class=""tab-content"" id=""pills-tabContent"">
                                        <div class=""tab-pane fade show active"" id=""tab1"" role=""tabpanel"">
                                            <div class=""modal_tab_img"">
                                                <a href=""#""><img src=""~/assets/img/product/");
#nullable restore
#line 43 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Views\Shared\_CarouselItem.cshtml"
                                                                                      Write(Model.ProductFirstImage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" alt=""""></a>
                                            </div>
                                        </div>
                                        <div class=""tab-pane fade"" id=""tab2"" role=""tabpanel"">
                                            <div class=""modal_tab_img"">
                                                <a href=""#""><img src=""~/assets/img/product/");
#nullable restore
#line 48 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Views\Shared\_CarouselItem.cshtml"
                                                                                      Write(Model.ProductSecondImage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" alt=""""></a>
                                            </div>
                                        </div>
                                        <div class=""tab-pane fade"" id=""tab3"" role=""tabpanel"">
                                            <div class=""modal_tab_img"">
                                                <a href=""#""><img src=""~/assets/img/product/");
#nullable restore
#line 53 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Views\Shared\_CarouselItem.cshtml"
                                                                                      Write(Model.ProductThirdImage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" alt=""""></a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""modal_tab_button"">
                                        <ul class=""nav product_navactive"" role=""tablist"">
                                            <li>
                                                <a class=""nav-link active"" data-toggle=""tab"" href=""#tab1"" role=""tab"" aria-controls=""tab1"" aria-selected=""false""><img src=""~/assets/img/product/");
#nullable restore
#line 60 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Views\Shared\_CarouselItem.cshtml"
                                                                                                                                                                                          Write(Model.ProductFirstImage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" alt=""""></a>
                                            </li>
                                            <li>
                                                <a class=""nav-link"" data-toggle=""tab"" href=""#tab2"" role=""tab"" aria-controls=""tab2"" aria-selected=""false""><img src=""~/assets/img/product/");
#nullable restore
#line 63 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Views\Shared\_CarouselItem.cshtml"
                                                                                                                                                                                   Write(Model.ProductSecondImage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" alt=""""></a>
                                            </li>
                                            <li>
                                                <a class=""nav-link button_three"" data-toggle=""tab"" href=""#tab3"" role=""tab"" aria-controls=""tab3"" aria-selected=""false""><img src=""~/assets/img/product/");
#nullable restore
#line 66 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Views\Shared\_CarouselItem.cshtml"
                                                                                                                                                                                                Write(Model.ProductThirdImage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" alt=""""></a>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-lg-7 col-md-7 col-sm-12"">
                                <div class=""modal_right"">
                                    <div class=""modal_title mb-10"">
                                        <h2>");
#nullable restore
#line 75 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Views\Shared\_CarouselItem.cshtml"
                                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                                    </div>\n                                    <div class=\"modal_price mb-10\">\n                                        <span class=\"new_price\">$");
#nullable restore
#line 78 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Views\Shared\_CarouselItem.cshtml"
                                                            Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>-->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
