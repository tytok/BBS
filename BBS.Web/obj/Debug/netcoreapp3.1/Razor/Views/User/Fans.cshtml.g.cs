#pragma checksum "E:\DEMO_SPACES\BBS\BBS.Web\Views\User\Fans.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cefafcfe4987f4724442224a2aca09b841f3d8a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Fans), @"mvc.1.0.view", @"/Views/User/Fans.cshtml")]
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
#line 1 "E:\DEMO_SPACES\BBS\BBS.Web\Views\_ViewImports.cshtml"
using BBS.Web;

#line default
#line hidden
#line 2 "E:\DEMO_SPACES\BBS\BBS.Web\Views\_ViewImports.cshtml"
using BBS.Models;

#line default
#line hidden
#line 3 "E:\DEMO_SPACES\BBS\BBS.Web\Views\_ViewImports.cshtml"
using BBS.Framework.Configs;

#line default
#line hidden
#line 4 "E:\DEMO_SPACES\BBS\BBS.Web\Views\_ViewImports.cshtml"
using BBS.Framework.Models;

#line default
#line hidden
#line 5 "E:\DEMO_SPACES\BBS\BBS.Web\Views\_ViewImports.cshtml"
using BBS.Framework.Extensions;

#line default
#line hidden
#line 6 "E:\DEMO_SPACES\BBS\BBS.Web\Views\_ViewImports.cshtml"
using StackExchange.Profiling;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cefafcfe4987f4724442224a2aca09b841f3d8a8", @"/Views/User/Fans.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12e4de8eda15c20b299cbcef35d03eb9e2df59b1", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Fans : BBS.Web.Infrastructure.BBSRazorPage<PagedList<AccountModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\DEMO_SPACES\BBS\BBS.Web\Views\User\Fans.cshtml"
  
    ViewData["Title"] = "TA的粉丝";

#line default
#line hidden
            WriteLiteral(@"<style>
    .avatar_list ul {
        padding: 0;
        margin: 0;
        padding-right: 5px;
        display: flex;
        flex-flow: row wrap;
    }

    .avatar_list li {
        margin: 10px 5px;
        text-align: center;
        list-style: none;
        max-width: 95px
    }

        .avatar_list li .avatar_name {
            white-space: nowrap;
            overflow: hidden;
            text-overflow: ellipsis;
        }
</style>
");
#line 27 "E:\DEMO_SPACES\BBS\BBS.Web\Views\User\Fans.cshtml"
Write(await Component.InvokeAsync("UserInfo"));

#line default
#line hidden
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"tt-tab-wrapper\">\r\n        ");
#line 30 "E:\DEMO_SPACES\BBS\BBS.Web\Views\User\Fans.cshtml"
   Write(await Component.InvokeAsync("UserInfoTab", ViewBag.Id));

#line default
#line hidden
            WriteLiteral("\r\n        <div class=\"tab-content pt-3 pb-3 alert-white\">\r\n            <div class=\"tab-pane tt-indent-none show active\" role=\"tabpanel\">\r\n                <div class=\"tt-wrapper-inner tt-layout-tab\">\r\n");
#line 34 "E:\DEMO_SPACES\BBS\BBS.Web\Views\User\Fans.cshtml"
                     if (Model.Count <= 0)
                    {

#line default
#line hidden
            WriteLiteral("                        <img src=\"/images/404.png\">\r\n");
#line 37 "E:\DEMO_SPACES\BBS\BBS.Web\Views\User\Fans.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            WriteLiteral("                        <div class=\"avatar_list\">\r\n                            <ul>\r\n");
#line 42 "E:\DEMO_SPACES\BBS\BBS.Web\Views\User\Fans.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
            WriteLiteral("                                    <li>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1364, "\"", 1421, 1);
#line 45 "E:\DEMO_SPACES\BBS\BBS.Web\Views\User\Fans.cshtml"
WriteAttributeValue("", 1371, Url.Action("Topic", "User", new { id = item.Id }), 1371, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1422, "\"", 1444, 1);
#line 45 "E:\DEMO_SPACES\BBS\BBS.Web\Views\User\Fans.cshtml"
WriteAttributeValue("", 1430, item.NickName, 1430, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <div class=\"rounded-circle\">\r\n                                                <img");
            BeginWriteAttribute("src", " src=\"", 1574, "\"", 1592, 1);
#line 47 "E:\DEMO_SPACES\BBS\BBS.Web\Views\User\Fans.cshtml"
WriteAttributeValue("", 1580, item.Avatar, 1580, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            </div>\r\n                                            <div class=\"avatar_name\">\r\n                                                ");
#line 50 "E:\DEMO_SPACES\BBS\BBS.Web\Views\User\Fans.cshtml"
                                           Write(item.NickName);

#line default
#line hidden
            WriteLiteral("\r\n                                            </div>\r\n                                        </a>\r\n                                    </li>\r\n");
#line 54 "E:\DEMO_SPACES\BBS\BBS.Web\Views\User\Fans.cshtml"
                                }

#line default
#line hidden
            WriteLiteral("                            </ul>\r\n                        </div>\r\n                        <nav class=\"mt-3\">\r\n                            ");
#line 58 "E:\DEMO_SPACES\BBS\BBS.Web\Views\User\Fans.cshtml"
                       Write(await Component.InvokeAsync("Pagination", Model.ToPagination("Fans", "User")));

#line default
#line hidden
            WriteLiteral("\r\n                        </nav>\r\n");
#line 60 "E:\DEMO_SPACES\BBS\BBS.Web\Views\User\Fans.cshtml"
                    }

#line default
#line hidden
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList<AccountModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591