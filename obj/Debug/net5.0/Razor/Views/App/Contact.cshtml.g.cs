#pragma checksum "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Views\App\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00cd0916c10bd21c0d9a9f1a241c13eb0cdec41b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_App_Contact), @"mvc.1.0.view", @"/Views/App/Contact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00cd0916c10bd21c0d9a9f1a241c13eb0cdec41b", @"/Views/App/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff995e174a512a85a6a2fc5629db289ca757c652", @"/Views/_ViewImports.cshtml")]
    public class Views_App_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("assets/mail.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                                    <li>contact</li>
                                </ul>

                            </div>
                        </div>
                    </div>
                </div>
                <!--breadcrumbs area end-->
                <!--contact area start-->
                <div class=""contact_area"">
                    <div class=""row"">
                        <div class=""col-lg-6 col-md-12"">
                            <div class=""contact_message"">
                                <h3>Tell us your project</h3>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00cd0916c10bd21c0d9a9f1a241c13eb0cdec41b5530", async() => {
                WriteLiteral(@"
                                    <div class=""row"">
                                        <div class=""col-lg-6"">
                                            <input name=""name"" placeholder=""Name *"" type=""text"">
                                        </div>
                                        <div class=""col-lg-6"">
                                            <input name=""email"" placeholder=""Email *"" type=""email"">
                                        </div>
                                        <div class=""col-lg-6"">
                                            <input name=""subject"" placeholder=""Subject *"" type=""text"">
                                        </div>
                                        <div class=""col-lg-6"">
                                            <input name=""phone"" placeholder=""Phone *"" type=""text"">
                                        </div>

                                        <div class=""col-12"">
                                            <div class=""contact_text");
                WriteLiteral(@"area"">
                                                <textarea placeholder=""Message *"" name=""message"" class=""form-control2""></textarea>
                                            </div>
                                            <button type=""submit""> Send Message </button>
                                        </div>
                                        <div class=""col-12"">
                                            <p class=""form-messege"">
                                        </div>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>

                        <div class=""col-lg-6 col-md-12"">
                            <div class=""contact_message contact_info"">
                                <h3>contact us</h3>
                                <p>
                                    Established in 2001 under license No. 2052 / Q??-BGD & ??T-TCCB dated 27/04/2001 of the Ministry of Education and Training.
                                    Faculty has three subjects: Information Systems, Computer Networks, Software Engineering..
                                </p>
                                <ul>
                                    <li><i class=""fa fa-fax""></i>  Address : VQFR+7HJ, Dong Hoa, Thu Duc , Binh Duong</li>
                                    <li><i class=""fa fa-phone""></i> <a href=""#"">faxion@gmail.com</a></li>
                                    <li><i class=""fa fa-envelope-o""></i> (84) 6969 6969</li>
                                </ul>
                     ");
            WriteLiteral(@"           <h3><strong>Working hours</strong></h3>
                                <p><strong>Monday ??? Saturday</strong>:  8AM ??? 22PM</p>
                            </div>
                        </div>
                    </div>
                </div>

                <!--contact area end-->
                <!--contact map start-->
                <div class=""contact_map"">
                    <div class=""row"">
                        <div class=""col-12"">
                            <iframe src=""https://www.google.com/maps/embed?pb"" width=""500"" height=""450"" style=""border:0""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 4290, "\"", 4308, 0);
            EndWriteAttribute();
            WriteLiteral("></iframe>\n                        </div>\n                    </div>\n                </div>\n                <!--contact map end-->\n\n");
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
