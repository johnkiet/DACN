#pragma checksum "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Products\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1efcefe5686a570930f4538c720bf6d54cb644cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Products_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Products/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1efcefe5686a570930f4538c720bf6d54cb644cd", @"/Areas/Admin/Views/Products/Create.cshtml")]
    public class Areas_Admin_Views_Products_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectDotNetV2.Data.Entities.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Luu Pot\Desktop\Project-ASPNET-master\Project-ASPNET-master\Areas\Admin\Views\Products\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Home Page</h1>



<div>
    <h4>Single File Upload</h4>
    <form asp-controller=""Home"" asp-action=""SingleFile""
          enctype=""multipart/form-data"" method=""post"">
        <input type=""file"" name=""file"" />
        <button type=""submit"">Submit</button>
    </form>
</div>


<div>
    <h4>Mutliple File Upload</h4>
    <form asp-controller=""Home"" asp-action=""MultipleFiles""
          enctype=""multipart/form-data"" method=""post"">
        <input type=""file"" multiple name=""files"" />
        <button type=""submit"">Submit</button>
    </form>
</div>

<div>
    <h4>File in Model Upload</h4>
    <form asp-controller=""Home"" asp-action=""FileInModel""
          enctype=""multipart/form-data"" method=""post"">
        <input type=""text"" name=""someForm.Name"" />
        <input type=""file"" multiple name=""someForm.File"" />
        <button type=""submit"">Submit</button>
    </form>
</div>



<div>
    <h4>Single File Upload (JS)</h4>
    <input type=""file"" onchange=""UploadFile(event)"" />
</div>


<div>
    <h4>Multiple File Uploa");
            WriteLiteral("d (JS)</h4>\n    <input type=\"file\" multiple onchange=\"UploadFiles(event)\" />\n</div>\n\n\n<div>\n    <h4>File in Model Upload (JS)</h4>\n    <input type=\"text\" id=\"file-name\" />\n    <input type=\"file\" onchange=\"UploadFileToModel(event)\" />\n</div>\n\n");
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
