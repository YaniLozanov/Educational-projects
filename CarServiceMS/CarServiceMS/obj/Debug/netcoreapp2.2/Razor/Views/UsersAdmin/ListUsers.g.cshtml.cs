#pragma checksum "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\CarServiceMS\CarServiceMS\Views\UsersAdmin\ListUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7d79691f9e03c2237c94a30a3c3c5de1be74690"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UsersAdmin_ListUsers), @"mvc.1.0.view", @"/Views/UsersAdmin/ListUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UsersAdmin/ListUsers.cshtml", typeof(AspNetCore.Views_UsersAdmin_ListUsers))]
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
#line 1 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\CarServiceMS\CarServiceMS\Views\_ViewImports.cshtml"
using CarServiceMS;

#line default
#line hidden
#line 2 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\CarServiceMS\CarServiceMS\Views\_ViewImports.cshtml"
using CarServiceMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7d79691f9e03c2237c94a30a3c3c5de1be74690", @"/Views/UsersAdmin/ListUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f93e211ec252256ce55286b52d647a4d8b93d583", @"/Views/_ViewImports.cshtml")]
    public class Views_UsersAdmin_ListUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarServiceMS.Models.BindingModels.UsersListingModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/CarTable.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Username", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Email", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "PhoneNumber", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "MemberSince", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UsersAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListUserCars", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(181, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(190, 48, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n</html>\r\n");
            EndContext();
            BeginContext(238, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7d79691f9e03c2237c94a30a3c3c5de1be746906990", async() => {
                BeginContext(244, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(252, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d7d79691f9e03c2237c94a30a3c3c5de1be746907379", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(317, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(326, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(330, 4272, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7d79691f9e03c2237c94a30a3c3c5de1be746909600", async() => {
                BeginContext(336, 8, true);
                WriteLiteral("\r\n\r\n\r\n\r\n");
                EndContext();
#line 21 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\CarServiceMS\CarServiceMS\Views\UsersAdmin\ListUsers.cshtml"
     if (@Model.Users != null)
    {
        

#line default
#line hidden
#line 23 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\CarServiceMS\CarServiceMS\Views\UsersAdmin\ListUsers.cshtml"
         if (Model.Users.Any(user => user.Role == "User"))
        {


#line default
#line hidden
                BeginContext(456, 64, true);
                WriteLiteral("            <h1 align=\"center\" style=\"color: black\">Users</h1>\r\n");
                EndContext();
                BeginContext(522, 1170, true);
                WriteLiteral(@"            <div style=""overflow-x:auto;"">
                <table class=""table-fill"" style=""table-layout:auto;"">

                    <thead >
                        <tr>
                            <th  class=""text-center"" colspan=""2"">
                                <input id=""search-box"" class=""form-control input"" onkeyup=""search()"" type=""text"" placeholder=""Search..."" />
                            </th>


                            <th colspan=""2"">


                                <input  type=""checkbox"" id=""checkbox-admin"" onclick=""search()"">
                                <span >Admin</span>

                                <input  type=""checkbox"" id=""checkbox-user"" onclick=""search()"">
                                <span >User</span>

                                <input type=""checkbox"" id=""checkbox-banned"" onclick=""search()"">
                                <span>Banned</span>

                            </th>

                            <th class=""text-center"" colspan");
                WriteLiteral("=\"2\">\r\n                                <select class=\"browser-default custom-select\" id=\"search-selector\">\r\n\r\n                                    ");
                EndContext();
                BeginContext(1692, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7d79691f9e03c2237c94a30a3c3c5de1be7469012008", async() => {
                    BeginContext(1717, 8, true);
                    WriteLiteral("Username");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1734, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(1772, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7d79691f9e03c2237c94a30a3c3c5de1be7469013512", async() => {
                    BeginContext(1794, 5, true);
                    WriteLiteral("Email");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1808, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(1846, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7d79691f9e03c2237c94a30a3c3c5de1be7469015013", async() => {
                    BeginContext(1874, 12, true);
                    WriteLiteral("Phone Number");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1895, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(1933, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7d79691f9e03c2237c94a30a3c3c5de1be7469016522", async() => {
                    BeginContext(1961, 12, true);
                    WriteLiteral("Member Since");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1982, 1220, true);
                WriteLiteral(@"

                                </select>

                            </th>
                        </tr>
                        <tr>

                            <th class=""text-center custom-width-180"">Username</th>
                            <th class=""text-center custom-width-200"">Email</th>
                            <th class=""text-center custom-width-200"">Phone Number</th>
                            <th class=""text-center custom-width-200"">Member Since</th>
                            <th class=""text-center custom-width-150"">Role</th>
                            <th class=""text-left custom-width-150""></th>

                        </tr>
                        <tr></tr>
                    </thead>
                    <tbody class=""table-hover"">

                        <tr id=""NoUsers"" style=""display: none"">
                            <td class=""text-center"" colspan=""6"">
                                <h1>
                                    <strong>There is no such use");
                WriteLiteral("rs.</strong>\r\n                                </h1>\r\n                            </td>\r\n                        </tr>\r\n\r\n                        <!-- List all users, but cuurrent logged user -->\r\n");
                EndContext();
#line 87 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\CarServiceMS\CarServiceMS\Views\UsersAdmin\ListUsers.cshtml"
                         foreach (var user in this.Model.Users.Where(u => u.Username != this.User.Identity.Name))
                        {

#line default
#line hidden
                BeginContext(3344, 106, true);
                WriteLiteral("                            <tr>\r\n                                <td name=\"Username\" class=\"text-center\">");
                EndContext();
                BeginContext(3451, 13, false);
#line 90 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\CarServiceMS\CarServiceMS\Views\UsersAdmin\ListUsers.cshtml"
                                                                   Write(user.Username);

#line default
#line hidden
                EndContext();
                BeginContext(3464, 76, true);
                WriteLiteral("</td>\r\n                                <td name=\"Email\" class=\"text-center\">");
                EndContext();
                BeginContext(3541, 10, false);
#line 91 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\CarServiceMS\CarServiceMS\Views\UsersAdmin\ListUsers.cshtml"
                                                                Write(user.Email);

#line default
#line hidden
                EndContext();
                BeginContext(3551, 82, true);
                WriteLiteral("</td>\r\n                                <td name=\"PhoneNumber\" class=\"text-center\">");
                EndContext();
                BeginContext(3634, 16, false);
#line 92 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\CarServiceMS\CarServiceMS\Views\UsersAdmin\ListUsers.cshtml"
                                                                      Write(user.PhoneNumber);

#line default
#line hidden
                EndContext();
                BeginContext(3650, 83, true);
                WriteLiteral("</td>\r\n                                <td name=\"MemberSince\" class=\"text-center \">");
                EndContext();
                BeginContext(3734, 36, false);
#line 93 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\CarServiceMS\CarServiceMS\Views\UsersAdmin\ListUsers.cshtml"
                                                                       Write(user.MemberSince.ToShortDateString());

#line default
#line hidden
                EndContext();
                BeginContext(3770, 75, true);
                WriteLiteral("</td>\r\n                                <td name=\"Role\" class=\"text-center\">");
                EndContext();
                BeginContext(3846, 9, false);
#line 94 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\CarServiceMS\CarServiceMS\Views\UsersAdmin\ListUsers.cshtml"
                                                               Write(user.Role);

#line default
#line hidden
                EndContext();
                BeginContext(3855, 106, true);
                WriteLiteral("</td>\r\n\r\n                                <td class=\"text-center \">\r\n\r\n                                    ");
                EndContext();
                BeginContext(3961, 259, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7d79691f9e03c2237c94a30a3c3c5de1be7469022545", async() => {
                    BeginContext(4078, 138, true);
                    WriteLiteral("\r\n                                        <button class=\"btn btn-dark button-Register\">Cars</button>\r\n                                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 98 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\CarServiceMS\CarServiceMS\Views\UsersAdmin\ListUsers.cshtml"
                                                                                               WriteLiteral(user.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 98 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\CarServiceMS\CarServiceMS\Views\UsersAdmin\ListUsers.cshtml"
                                                                                                                             WriteLiteral(user.Username);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-username", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4220, 78, true);
                WriteLiteral("\r\n\r\n                                </td>\r\n                            </tr>\r\n");
                EndContext();
#line 104 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\CarServiceMS\CarServiceMS\Views\UsersAdmin\ListUsers.cshtml"
                        }

#line default
#line hidden
                BeginContext(4325, 76, true);
                WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n");
                EndContext();
#line 108 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\CarServiceMS\CarServiceMS\Views\UsersAdmin\ListUsers.cshtml"

        }
        else
        {

#line default
#line hidden
                BeginContext(4439, 57, true);
                WriteLiteral("            <h1 align=\"center\">There are no users!</h1>\r\n");
                EndContext();
#line 113 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\CarServiceMS\CarServiceMS\Views\UsersAdmin\ListUsers.cshtml"

        }

#line default
#line hidden
#line 114 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\CarServiceMS\CarServiceMS\Views\UsersAdmin\ListUsers.cshtml"
         
    }
    else
    {

#line default
#line hidden
                BeginContext(4533, 53, true);
                WriteLiteral("        <h1 align=\"center\">There are no users!</h1>\r\n");
                EndContext();
#line 119 "C:\Users\Qni\Desktop\Projects\C# Web\GitHub\Educational-projects\CarServiceMS\CarServiceMS\Views\UsersAdmin\ListUsers.cshtml"
    }

#line default
#line hidden
                BeginContext(4593, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4602, 4016, true);
            WriteLiteral(@"



<script>
    let serachBox = document.getElementById(""search-box"");
    let serachSelector = document.getElementById(""search-selector"");
    let noUsersRow = document.getElementById(""NoUsers"");
    let searchText = """";

    let checkBoxAdmin = document.getElementById(""checkbox-admin"");
    let checkBoxUser = document.getElementById(""checkbox-user"");
    let checkBoxBanned = document.getElementById(""checkbox-banned"");

    let isAnyCheckBoxChecked = false;


    function search() {

        isAnyCheckBoxChecked = checkBoxAdmin.checked || checkBoxUser.checked || checkBoxBanned.checked;

        let searchElementsCategory = Array.from(document.getElementsByTagName(""td""));

        searchText = serachBox.value;

        let isThereSuchElement = searchElementsCategory.find(element => getElement(element));


        if (isThereSuchElement) {

            searchElementsCategory.forEach(element => filterTheElements(element));
            noUsersRow.style.display = ""none"";

       ");
            WriteLiteral(@" } else {
            searchElementsCategory.forEach(element => filterTheElements(element));


            noUsersRow.style.display = ""table-row"";
        }


    }

    function filterTheElements(element) {


        if (isAnyCheckBoxChecked) {

            let roles = [];

            if (checkBoxAdmin.checked) {
                roles.push(""Admin"");

            } else if (checkBoxUser.checked) {
                roles.push(""User"");

            } else if (checkBoxBanned.checked) {
                roles.push(""Banned"");

            }


            if (element.getAttribute('name') === serachSelector.value) {

                let role = Array.from(element.parentElement.children).find(child => getRoleElement(child)).innerText;


                if (!element.innerText.toUpperCase().includes(searchText.toUpperCase()) ||
                    !roles.includes(role)) {

                    element.parentElement.style.display = ""none"";

                } else {

                ");
            WriteLiteral(@"    let isTheElementHidden = element.parentElement.style.display === ""none"";


                    if (isTheElementHidden) {

                        element.parentElement.style.display = ""table-row"";
                    }
                }

            }

        } else {


            if (element.getAttribute('name') === serachSelector.value) {

                if (!element.innerText.toUpperCase().includes(searchText.toUpperCase())) {

                    element.parentElement.style.display = ""none"";

                } else {

                    let isTheElementHidden = element.parentElement.style.display === ""none"";


                    if (isTheElementHidden) {

                        element.parentElement.style.display = ""table-row"";
                    }
                }

            }

        }

    }

    function getElement(element) {

        if (isAnyCheckBoxChecked) {

            let roles = [];

            if (checkBoxAdmin.checked) {
           ");
            WriteLiteral(@"     roles.push(""Admin"");

            } else if (checkBoxUser.checked) {
                roles.push(""User"");

            } else if (checkBoxBanned.checked) {
                roles.push(""Banned"");

            }


            if (element.innerText.toUpperCase().includes(searchText.toUpperCase()) &&
                element.getAttribute('name') === serachSelector.value) {


                let role = Array.from(element.parentElement.children).find(child => getRoleElement(child)).innerText;

                return roles.includes(role);
            } else {

                return false;
            }

        } else {

            return element.innerText.toUpperCase().includes(searchText.toUpperCase()) &&
                element.getAttribute('name') === serachSelector.value;
        }
    }

    function getRoleElement(child) {
        return child.getAttribute('name') === ""Role""
    }

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarServiceMS.Models.BindingModels.UsersListingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591