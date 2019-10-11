#pragma checksum "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Panda-ASP.Net Core Mvc\Panda.App\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1099faf0cf8c3734e8f3d71a2b1c4a342f71d3fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Panda.App.Views.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(Panda.App.Views.Home.Views_Home_Index))]
namespace Panda.App.Views.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Panda-ASP.Net Core Mvc\Panda.App\Views\_ViewImports.cshtml"
using Panda.App;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1099faf0cf8c3734e8f3d71a2b1c4a342f71d3fc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9f96f78b3e00c66c5a1299bf60ecf64f3274959", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Panda.App.Models.Package.PackageHomeViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Panda-ASP.Net Core Mvc\Panda.App\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

    List<Panda.App.Models.Package.PackageHomeViewModel> pendingPackages = null;
    List<Panda.App.Models.Package.PackageHomeViewModel> shippedPackages = null;
    List<Panda.App.Models.Package.PackageHomeViewModel> deliveredPackages = null;

    if (this.User.Identity.IsAuthenticated)
    {
        pendingPackages = Model.Where(package => package.Status == "Pending").ToList();
        shippedPackages = Model.Where(package => package.Status == "Shipped").ToList();
        deliveredPackages = Model.Where(package => package.Status == "Delivered").ToList();
    }

#line default
#line hidden
            BeginContext(729, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 19 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Panda-ASP.Net Core Mvc\Panda.App\Views\Home\Index.cshtml"
 if (!this.User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(777, 338, true);
            WriteLiteral(@"    <div class=""jumbotron mt-3 bg-panda"">
        <h1 class=""text-white"">Welcome to PANDA Delivery Services.</h1>
        <hr class=""bg-white hr-2"" />
        <h3 class=""text-white""><a href=""/login"">Login</a> if you have an account.</h3>
        <h3 class=""text-white""><a href=""/register"">Register</a> if you don't.</h3>
    </div>
");
            EndContext();
#line 27 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Panda-ASP.Net Core Mvc\Panda.App\Views\Home\Index.cshtml"
}
else
{
    if (this.User.IsInRole("Admin"))
    {

#line default
#line hidden
            BeginContext(1172, 53, true);
            WriteLiteral("        <h1 class=\"text-center\">Hello, Administrator ");
            EndContext();
            BeginContext(1226, 23, false);
#line 32 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Panda-ASP.Net Core Mvc\Panda.App\Views\Home\Index.cshtml"
                                                Write(this.User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1249, 8, true);
            WriteLiteral("!</h1>\r\n");
            EndContext();
#line 33 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Panda-ASP.Net Core Mvc\Panda.App\Views\Home\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1281, 31, true);
            WriteLiteral("<h1 class=\"text-center\">Hello, ");
            EndContext();
            BeginContext(1313, 23, false);
#line 36 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Panda-ASP.Net Core Mvc\Panda.App\Views\Home\Index.cshtml"
                          Write(this.User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1336, 8, true);
            WriteLiteral("!</h1>\r\n");
            EndContext();
#line 37 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Panda-ASP.Net Core Mvc\Panda.App\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1351, 213, true);
            WriteLiteral("    <hr class=\"hr-2 bg-panda\">\r\n    <div class=\"d-flex justify-content-between\">\r\n        <div class=\"w-25 bg-white\">\r\n            <h2 class=\"text-center\">Pending</h2>\r\n            <div class=\"border-panda p-3\">\r\n");
            EndContext();
#line 43 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Panda-ASP.Net Core Mvc\Panda.App\Views\Home\Index.cshtml"
                 foreach (var package in pendingPackages)
                {

#line default
#line hidden
            BeginContext(1642, 110, true);
            WriteLiteral("                    <div class=\"p-2 d-flex justify-content-around\">\r\n                        <h4 class=\"w-75\">");
            EndContext();
            BeginContext(1753, 19, false);
#line 46 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Panda-ASP.Net Core Mvc\Panda.App\Views\Home\Index.cshtml"
                                    Write(package.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1772, 33, true);
            WriteLiteral("</h4>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1805, "\"", 1841, 2);
            WriteAttributeValue("", 1812, "/Packages/Details/", 1812, 18, true);
#line 47 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Panda-ASP.Net Core Mvc\Panda.App\Views\Home\Index.cshtml"
WriteAttributeValue("", 1830, package.Id, 1830, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1842, 79, true);
            WriteLiteral(" class=\"btn bg-panda text-white w-25\">Details</a>\r\n                    </div>\r\n");
            EndContext();
#line 49 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Panda-ASP.Net Core Mvc\Panda.App\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1940, 167, true);
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"w-25 bg-white\">\r\n            <h2 class=\"text-center\">Shipped</h2>\r\n            <div class=\"border-panda p-3\">\r\n");
            EndContext();
#line 55 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Panda-ASP.Net Core Mvc\Panda.App\Views\Home\Index.cshtml"
                 foreach (var package in shippedPackages)
                {

#line default
#line hidden
            BeginContext(2185, 110, true);
            WriteLiteral("                    <div class=\"p-2 d-flex justify-content-around\">\r\n                        <h4 class=\"w-75\">");
            EndContext();
            BeginContext(2296, 19, false);
#line 58 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Panda-ASP.Net Core Mvc\Panda.App\Views\Home\Index.cshtml"
                                    Write(package.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2315, 33, true);
            WriteLiteral("</h4>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2348, "\"", 2384, 2);
            WriteAttributeValue("", 2355, "/Packages/Details/", 2355, 18, true);
#line 59 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Panda-ASP.Net Core Mvc\Panda.App\Views\Home\Index.cshtml"
WriteAttributeValue("", 2373, package.Id, 2373, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2385, 79, true);
            WriteLiteral(" class=\"btn bg-panda text-white w-25\">Details</a>\r\n                    </div>\r\n");
            EndContext();
#line 61 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Panda-ASP.Net Core Mvc\Panda.App\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2483, 169, true);
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"w-25 bg-white\">\r\n            <h2 class=\"text-center\">Delivered</h2>\r\n            <div class=\"border-panda p-3\">\r\n");
            EndContext();
#line 67 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Panda-ASP.Net Core Mvc\Panda.App\Views\Home\Index.cshtml"
                 foreach (var package in deliveredPackages)
                {

#line default
#line hidden
            BeginContext(2732, 110, true);
            WriteLiteral("                    <div class=\"p-2 d-flex justify-content-around\">\r\n                        <h4 class=\"w-75\">");
            EndContext();
            BeginContext(2843, 19, false);
#line 70 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Panda-ASP.Net Core Mvc\Panda.App\Views\Home\Index.cshtml"
                                    Write(package.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2862, 33, true);
            WriteLiteral("</h4>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2895, "\"", 2931, 2);
            WriteAttributeValue("", 2902, "/Packages/Acquire/", 2902, 18, true);
#line 71 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Panda-ASP.Net Core Mvc\Panda.App\Views\Home\Index.cshtml"
WriteAttributeValue("", 2920, package.Id, 2920, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2932, 79, true);
            WriteLiteral(" class=\"btn bg-panda text-white w-25\">Acquire</a>\r\n                    </div>\r\n");
            EndContext();
#line 73 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Panda-ASP.Net Core Mvc\Panda.App\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3030, 48, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 77 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\Panda-ASP.Net Core Mvc\Panda.App\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Panda.App.Models.Package.PackageHomeViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
