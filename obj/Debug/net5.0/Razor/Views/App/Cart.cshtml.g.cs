#pragma checksum "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Views\App\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a1b39d9e3c192bbfafcf25d4d8b692b354c842e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_App_Cart), @"mvc.1.0.view", @"/Views/App/Cart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a1b39d9e3c192bbfafcf25d4d8b692b354c842e", @"/Views/App/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff995e174a512a85a6a2fc5629db289ca757c652", @"/Views/_ViewImports.cshtml")]
    public class Views_App_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/cart/cart17.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/cart/cart18.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/cart/cart19.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
                <!--breadcrumbs area start-->
                <div class=""breadcrumbs_area"">
                    <div class=""row"">
                        <div class=""col-12"">
                            <div class=""breadcrumb_content"">
                                <ul>
                                    <li><a href=""index.html"">home</a></li>
                                    <li><i class=""fa fa-angle-right""></i></li>
                                    <li>Shopping Cart</li>
                                </ul>

                            </div>
                        </div>
                    </div>
                </div>
                <!--breadcrumbs area end-->
                <!--shopping cart area start -->
                <div class=""shopping_cart_area"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a1b39d9e3c192bbfafcf25d4d8b692b354c842e6237", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col-12"">
                                <div class=""table_desc"">
                                    <div class=""cart_page table-responsive"">
                                        <table>
                                            <thead>
                                                <tr>
                                                    <th class=""product_remove"">Delete</th>
                                                    <th class=""product_thumb"">Image</th>
                                                    <th class=""product_name"">Product</th>
                                                    <th class=""product-price"">Price</th>
                                                    <th class=""product_quantity"">Quantity</th>
                                                    <th class=""product_total"">Total</th>
                                                </tr>
                                            </th");
                WriteLiteral(@"ead>
                                            <tbody>
                                                <tr>
                                                    <td class=""product_remove""><a href=""#""><i class=""fa fa-trash-o""></i></a></td>
                                                    <td class=""product_thumb""><a href=""#"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9a1b39d9e3c192bbfafcf25d4d8b692b354c842e7912", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</a></td>
                                                    <td class=""product_name""><a href=""#"">Handbag fringilla</a></td>
                                                    <td class=""product-price"">??65.00</td>
                                                    <td class=""product_quantity""><input min=""0"" max=""100"" value=""1"" type=""number""></td>
                                                    <td class=""product_total"">??130.00</td>


                                                </tr>

                                                <tr>
                                                    <td class=""product_remove""><a href=""#""><i class=""fa fa-trash-o""></i></a></td>
                                                    <td class=""product_thumb""><a href=""#"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9a1b39d9e3c192bbfafcf25d4d8b692b354c842e9884", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</a></td>
                                                    <td class=""product_name""><a href=""#"">Handbags justo</a></td>
                                                    <td class=""product-price"">??90.00</td>
                                                    <td class=""product_quantity""><input min=""0"" max=""100"" value=""1"" type=""number""></td>
                                                    <td class=""product_total"">??180.00</td>


                                                </tr>
                                                <tr>
                                                    <td class=""product_remove""><a href=""#""><i class=""fa fa-trash-o""></i></a></td>
                                                    <td class=""product_thumb""><a href=""#"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9a1b39d9e3c192bbfafcf25d4d8b692b354c842e11852", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</a></td>
                                                    <td class=""product_name""><a href=""#"">Handbag elit</a></td>
                                                    <td class=""product-price"">??80.00</td>
                                                    <td class=""product_quantity""><input min=""0"" max=""100"" value=""1"" type=""number""></td>
                                                    <td class=""product_total"">??160.00</td>


                                                </tr>

                                            </tbody>
                                        </table>
                                    </div>
                                    <div class=""cart_submit"">
                                        <button type=""submit"">update cart</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!--coupon code area start-->
                        <div class=""c");
                WriteLiteral(@"oupon_area"">
                            <div class=""row"">
                                <div class=""col-lg-6 col-md-6"">
                                    <div class=""coupon_code"">
                                        <h3>Coupon</h3>
                                        <div class=""coupon_inner"">
                                            <p>Enter your coupon code if you have one.</p>
                                            <input placeholder=""Coupon code"" type=""text"">
                                            <button type=""submit"">Apply coupon</button>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-lg-6 col-md-6"">
                                    <div class=""coupon_code"">
                                        <h3>Cart Totals</h3>
                                        <div class=""coupon_inner"">
                                            <div class=""cart_sub");
                WriteLiteral(@"total"">
                                                <p>Subtotal</p>
                                                <p class=""cart_amount"">??215.00</p>
                                            </div>
                                            <div class=""cart_subtotal "">
                                                <p>Shipping</p>
                                                <p class=""cart_amount""><span>Flat Rate:</span> ??255.00</p>
                                            </div>
                                            <a href=""#"">Calculate shipping</a>

                                            <div class=""cart_subtotal"">
                                                <p>Total</p>
                                                <p class=""cart_amount"">??215.00</p>
                                            </div>
                                            <div class=""checkout_btn"">
                                                <a href=""#"">Proceed to Checkout</a>
                     ");
                WriteLiteral(@"                       </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!--coupon code area end-->
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n                <!--shopping cart area end -->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
