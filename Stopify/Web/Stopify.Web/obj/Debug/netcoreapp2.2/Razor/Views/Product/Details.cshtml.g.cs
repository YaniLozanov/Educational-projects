#pragma checksum "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d065489eaea2bf7e96b88e0a2731892577c57e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Details.cshtml", typeof(AspNetCore.Views_Product_Details))]
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
#line 1 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\_ViewImports.cshtml"
using Stopify.Web;

#line default
#line hidden
#line 2 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\_ViewImports.cshtml"
using Stopify.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d065489eaea2bf7e96b88e0a2731892577c57e0", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2d02c8c36319d7adbb332db74d23d0e414e2205", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Stopify.Web.ViewModels.ProductDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("order-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Product/Order"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Product\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(147, 165, true);
            WriteLiteral("\r\n<div class=\"d-flex justify-content-around row\">\r\n    <div id=\"product-image-and-navigation-holder\" class=\"w-45\">\r\n        <div id=\"image-holder\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 312, "\"", 332, 1);
#line 11 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Product\Details.cshtml"
WriteAttributeValue("", 318, Model.Picture, 318, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(333, 333, true);
            WriteLiteral(@"
                 alt=""..."" class=""img-thumbnail w-100"" />
            <hr class=""hr-2 bg-primary mt-4"" />
            <div id=""navigation-holder"" class=""mt-4 d-flex justify-content-around"">
                <button class=""btn btn-primary text-white font-weight-bold"" data-toggle=""modal"" data-target=""#orderModal"">Order</button>
");
            EndContext();
#line 16 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Product\Details.cshtml"
                 if (this.User.IsInRole("Admin"))
                {

#line default
#line hidden
            BeginContext(736, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 758, "\"", 803, 2);
            WriteAttributeValue("", 765, "/Administration/Product/Edit/", 765, 29, true);
#line 18 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Product\Details.cshtml"
WriteAttributeValue("", 794, Model.Id, 794, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(804, 85, true);
            WriteLiteral(" class=\"btn btn-primary text-white font-weight-bold\">Edit</a>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 889, "\"", 936, 2);
            WriteAttributeValue("", 896, "/Administration/Product/Delete/", 896, 31, true);
#line 19 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Product\Details.cshtml"
WriteAttributeValue("", 927, Model.Id, 927, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(937, 65, true);
            WriteLiteral(" class=\"btn btn-primary text-white font-weight-bold\">Delete</a>\r\n");
            EndContext();
#line 20 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Product\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(1021, 224, true);
            WriteLiteral("            </div>\r\n            <hr class=\"hr-2 bg-primary mt-4\" />\r\n        </div>\r\n    </div>\r\n    <div id=\"product-data-holder\" class=\"w-45\">\r\n        <hr class=\"hr-2 bg-primary\" />\r\n        <h3 class=\"text-center\">Name: ");
            EndContext();
            BeginContext(1246, 10, false);
#line 27 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Product\Details.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1256, 47, true);
            WriteLiteral("</h3>\r\n        <h3 class=\"text-center\">Price: $");
            EndContext();
            BeginContext(1304, 26, false);
#line 28 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Product\Details.cshtml"
                                   Write(Model.Price.ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1330, 90, true);
            WriteLiteral("</h3>\r\n        <hr class=\"hr-2 bg-primary mt-4\" />\r\n        <h3 class=\"text-center\">Type: ");
            EndContext();
            BeginContext(1421, 21, false);
#line 30 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Product\Details.cshtml"
                                 Write(Model.ProductTypeName);

#line default
#line hidden
            EndContext();
            BeginContext(1442, 56, true);
            WriteLiteral("</h3>\r\n        <h3 class=\"text-center\">Manufactured On: ");
            EndContext();
            BeginContext(1499, 43, false);
#line 31 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Product\Details.cshtml"
                                            Write(Model.ManufacturedOn.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1542, 1127, true);
            WriteLiteral(@"</h3>
        <hr class=""hr-2 bg-primary mt-4"" />
        <h3 class=""text-center"">Description</h3>
        <hr class=""hr-2 bg-primary mt-4 w-50"" /> 
        <p class=""text-center"">
            Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
        </p>
    </div>
</div>

<div class=""modal fade"" id=""orderModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""orderModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
      ");
            WriteLiteral("      <div class=\"modal-header\">\r\n                <h5 class=\"modal-title\" id=\"orderModalLabel\">Order - ");
            EndContext();
            BeginContext(2670, 10, false);
#line 45 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Product\Details.cshtml"
                                                                Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2680, 263, true);
            WriteLiteral(@"</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            EndContext();
            BeginContext(2943, 541, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d065489eaea2bf7e96b88e0a2731892577c57e011591", async() => {
                BeginContext(3003, 390, true);
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""quantity"" class=""col-form-label font-weight-bold"">Quantity</label>
                        <input type=""number""
                               class=""form-control""
                               id=""quantity""
                               name=""quantity"">
                        <input type=""hidden""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3393, "\"", 3410, 1);
#line 58 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Product\Details.cshtml"
WriteAttributeValue("", 3401, Model.Id, 3401, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3411, 66, true);
                WriteLiteral(" name=\"productId\" />\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3484, 443, true);
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-primary"" id=""complete-order-button"">Complete</button>
            </div>
        </div>
    </div>
</div>

<script>
    $('#complete-order-button').click(function () {
        $('#order-form').submit();
    });
</script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Stopify.Web.ViewModels.ProductDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
