#pragma checksum "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f9f2aa5f583f90a6f9f448b41523dd3debe3941"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f9f2aa5f583f90a6f9f448b41523dd3debe3941", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2d02c8c36319d7adbb332db74d23d0e414e2205", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Stopify.Web.ViewModels.Home.Index.ProductHomeViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("order-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

    // TODO: Refactor this!
    var criteria = new Dictionary<string, string>()
{
        { "price-lowest-to-highest", "Price (lowest to highest)" },
        { "price-highest-to-lowest", "Price (highest to lowest)" },
        { "date-oldest-to-newest", "Date of Manufacturing (oldest to newest)" },
        { "date-newest-to-oldest", "Date of Manufacturing (newest to oldest)" }
    };

#line default
#line hidden
            BeginContext(512, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 16 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Home\Index.cshtml"
 if (!this.User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(560, 241, true);
            WriteLiteral("    <div class=\"jumbotron bg-primary mt-3 mb-3\">\r\n        <h1 class=\"font-weight-bold text-white\">Stopify Web Shop</h1>\r\n        <hr class=\"bg-white hr-2\" />\r\n        <h3 class=\"text-white\">Have a nice shopping experience!</h3>\r\n    </div>\r\n");
            EndContext();
#line 23 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(813, 511, true);
            WriteLiteral(@"    <div class=""d-flex justify-content-between"">
        <div id=""products-search-bar-holder"" class=""form-group d-flex justify-content-between w-50"">
            <input type=""text"" class=""form-control text-primary"" id=""products-search-bar"" name=""search"" placeholder=""Search..."" />
        </div>
        <div id=""sort-holder"" class=""form-group w-40 d-flex justify-content-between"">
            <label for=""sort"" class=""text-primary font-weight-bold w-30 h4 mt-1 text-right"">Order By: </label>
            ");
            EndContext();
            BeginContext(1324, 953, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f9f2aa5f583f90a6f9f448b41523dd3debe39416657", async() => {
                BeginContext(1370, 103, true);
                WriteLiteral("\r\n                <select id=\"sort\" class=\"form-control text-primary pl-2 ml-3 w-70\" name=\"criteria\">\r\n");
                EndContext();
#line 34 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Home\Index.cshtml"
                     if (this.ViewData["criteria"] == null)
                    {

#line default
#line hidden
                BeginContext(1557, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1581, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f9f2aa5f583f90a6f9f448b41523dd3debe39417528", async() => {
                    BeginContext(1598, 4, true);
                    WriteLiteral("None");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1611, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 37 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
                BeginContext(1685, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1709, 21, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f9f2aa5f583f90a6f9f448b41523dd3debe39419469", async() => {
                    BeginContext(1717, 4, true);
                    WriteLiteral("None");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1730, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 41 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(1755, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 43 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Home\Index.cshtml"
                     foreach (var elem in criteria)
                    {
                        if (elem.Key == (string)this.ViewData["criteria"])
                        {

#line default
#line hidden
                BeginContext(1936, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1964, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f9f2aa5f583f90a6f9f448b41523dd3debe394111493", async() => {
                    BeginContext(2000, 10, false);
#line 47 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Home\Index.cshtml"
                                                          Write(elem.Value);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 47 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Home\Index.cshtml"
                               WriteLiteral(elem.Key);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2019, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 48 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Home\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(2105, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(2133, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f9f2aa5f583f90a6f9f448b41523dd3debe394114314", async() => {
                    BeginContext(2160, 10, false);
#line 51 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Home\Index.cshtml"
                                                 Write(elem.Value);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 51 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Home\Index.cshtml"
                               WriteLiteral(elem.Key);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2179, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 52 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Home\Index.cshtml"
                        }
                    }

#line default
#line hidden
                BeginContext(2231, 39, true);
                WriteLiteral("                </select>\r\n            ");
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
            BeginContext(2277, 102, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <hr class=\"hr-2 bg-primary\">\r\n    <div id=\"products\" class=\"mt-3\">\r\n");
            EndContext();
#line 60 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Home\Index.cshtml"
         for (int i = 0; i < Model.Count; i += 5)
        {

#line default
#line hidden
            BeginContext(2441, 79, true);
            WriteLiteral("            <div class=\"products-row row d-flex justify-content-around my-5\">\r\n");
            EndContext();
#line 63 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Home\Index.cshtml"
                 for (int j = i; j < i + 5; j++)
                {
                    if (j < Model.Count)
                    {

#line default
#line hidden
            BeginContext(2654, 208, true);
            WriteLiteral("                        <div class=\"product col-md-2\">\r\n                            <div class=\"image-holder d-flex justify-content-center\">\r\n                               \r\n                               <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2862, "\"", 2898, 2);
            WriteAttributeValue("", 2869, "/Product/Details/", 2869, 17, true);
#line 70 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 2886, Model[j].Id, 2886, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2899, 78, true);
            WriteLiteral(">\r\n                                   <img class=\"img-thumbnail product-image\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2977, "\"", 3000, 1);
#line 71 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 2983, Model[j].Picture, 2983, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3001, 189, true);
            WriteLiteral(" alt=\"...\">\r\n                               </a>\r\n                               \r\n                            </div>\r\n                            <h5 class=\"text-primary text-center mt-3\">");
            EndContext();
            BeginContext(3191, 13, false);
#line 75 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Home\Index.cshtml"
                                                                 Write(Model[j].Name);

#line default
#line hidden
            EndContext();
            BeginContext(3204, 85, true);
            WriteLiteral("</h5>\r\n                            <h5 class=\"text-primary text-center mt-3\">Price: $");
            EndContext();
            BeginContext(3290, 29, false);
#line 76 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Home\Index.cshtml"
                                                                         Write(Model[j].Price.ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(3319, 39, true);
            WriteLiteral("</h5>\r\n                        </div>\r\n");
            EndContext();
#line 78 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(3430, 94, true);
            WriteLiteral("                        <div class=\"product col-md-2 empty\">\r\n                        </div>\r\n");
            EndContext();
#line 83 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Home\Index.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(3566, 20, true);
            WriteLiteral("            </div>\r\n");
            EndContext();
#line 86 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3597, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
            BeginContext(3611, 590, true);
            WriteLiteral(@"    <script>
        $('#sort').change(function () {
            $('#order-form').submit();
        });

        $('#products-search-bar').on(""change paste keyup"", function () {
            $('.product').show();

            let searchValue = $('#products-search-bar').val();

            for (let elem of $('.product')) {
                let productName = $($(elem).children()[1]).text();

                if (!productName.toLowerCase().includes(searchValue.toLowerCase())) {
                    $(elem).hide();
                }
            }
        });
    </script>
");
            EndContext();
#line 108 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Stopify\Web\Stopify.Web\Views\Home\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Stopify.Web.ViewModels.Home.Index.ProductHomeViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
