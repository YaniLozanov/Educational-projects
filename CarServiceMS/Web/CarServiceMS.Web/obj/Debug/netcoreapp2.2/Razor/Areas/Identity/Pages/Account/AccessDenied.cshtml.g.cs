#pragma checksum "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\CarServiceMS\Web\CarServiceMS.Web\Areas\Identity\Pages\Account\AccessDenied.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4f235b96c508a45623867fb9a074d2b23558126"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CarServiceMS.Web.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_AccessDenied), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/AccessDenied.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/AccessDenied.cshtml", typeof(CarServiceMS.Web.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_AccessDenied), null)]
namespace CarServiceMS.Web.Areas.Identity.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\CarServiceMS\Web\CarServiceMS.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\CarServiceMS\Web\CarServiceMS.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using CarServiceMS.Web.Areas.Identity;

#line default
#line hidden
#line 3 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\CarServiceMS\Web\CarServiceMS.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using CarServiceMS.Data.Models;

#line default
#line hidden
#line 1 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\CarServiceMS\Web\CarServiceMS.Web\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using CarServiceMS.Web.Areas.Identity.Pages.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4f235b96c508a45623867fb9a074d2b23558126", @"/Areas/Identity/Pages/Account/AccessDenied.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d5f9a9342278bcd5b638879d860295cf1eec33e", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"465262d15470398ab57a8140185f3a2ac79d30de", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_AccessDenied : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\CarServiceMS\Web\CarServiceMS.Web\Areas\Identity\Pages\Account\AccessDenied.cshtml"
  
    ViewData["Title"] = "Access denied";

#line default
#line hidden
            BeginContext(82, 12, true);
            WriteLiteral("\r\n<header>\r\n");
            EndContext();
#line 8 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\CarServiceMS\Web\CarServiceMS.Web\Areas\Identity\Pages\Account\AccessDenied.cshtml"
     if (this.User.IsInRole("Banned"))
    {

#line default
#line hidden
            BeginContext(141, 47, true);
            WriteLiteral("        <h1 align=\"center\" class=\"text-danger\">");
            EndContext();
            BeginContext(189, 17, false);
#line 10 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\CarServiceMS\Web\CarServiceMS.Web\Areas\Identity\Pages\Account\AccessDenied.cshtml"
                                          Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(206, 190, true);
            WriteLiteral("</h1>\r\n        <h3 align=\"center\" class=\"text-danger\">You have been Banned.</h3>\r\n        <h5 align=\"center\" class=\"text-danger\">For more Information contact with Email: demo_email...</h5>\r\n");
            EndContext();
#line 13 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\CarServiceMS\Web\CarServiceMS.Web\Areas\Identity\Pages\Account\AccessDenied.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(420, 47, true);
            WriteLiteral("        <h1 align=\"center\" class=\"text-danger\">");
            EndContext();
            BeginContext(468, 17, false);
#line 16 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\CarServiceMS\Web\CarServiceMS.Web\Areas\Identity\Pages\Account\AccessDenied.cshtml"
                                          Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(485, 101, true);
            WriteLiteral("</h1>\r\n        <h3 align=\"center\" class=\"text-danger\">You do not have access to this resource.</h3>\r\n");
            EndContext();
#line 18 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\CarServiceMS\Web\CarServiceMS.Web\Areas\Identity\Pages\Account\AccessDenied.cshtml"
    }

#line default
#line hidden
            BeginContext(593, 11, true);
            WriteLiteral("</header>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccessDeniedModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccessDeniedModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccessDeniedModel>)PageContext?.ViewData;
        public AccessDeniedModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
