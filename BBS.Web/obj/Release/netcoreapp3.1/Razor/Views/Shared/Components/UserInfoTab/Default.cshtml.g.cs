#pragma checksum "E:\DEMO_SPACES\BBS\BBS.Web\Views\Shared\Components\UserInfoTab\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df3aef3599d17a344ecc22797b8b9257c0737278"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_UserInfoTab_Default), @"mvc.1.0.view", @"/Views/Shared/Components/UserInfoTab/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df3aef3599d17a344ecc22797b8b9257c0737278", @"/Views/Shared/Components/UserInfoTab/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12e4de8eda15c20b299cbcef35d03eb9e2df59b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_UserInfoTab_Default : BBS.Web.Infrastructure.BBSRazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\r\n    .tt-tab-wrapper .nav-tabs {\r\n        border-bottom: none\r\n    }\r\n</style>\r\n<div class=\"tt-wrapper-inner\">\r\n    <ul class=\"nav nav-tabs pt-tabs-default\">\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 241, "\"", 295, 1);
#line 10 "E:\DEMO_SPACES\BBS\BBS.Web\Views\Shared\Components\UserInfoTab\Default.cshtml"
WriteAttributeValue("", 248, Url.Action("Topic", "User", new { id = Model}), 248, 47, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral("><span>TA的主题</span></a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 398, "\"", 453, 1);
#line 13 "E:\DEMO_SPACES\BBS\BBS.Web\Views\Shared\Components\UserInfoTab\Default.cshtml"
WriteAttributeValue("", 405, Url.Action("Follow", "User", new { id = Model}), 405, 48, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral("><span>TA的关注</span></a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 556, "\"", 609, 1);
#line 16 "E:\DEMO_SPACES\BBS\BBS.Web\Views\Shared\Components\UserInfoTab\Default.cshtml"
WriteAttributeValue("", 563, Url.Action("Fans", "User", new { id = Model}), 563, 46, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(@"><span>TA的粉丝</span></a>
        </li>
    </ul>
</div>
<script type=""text/javascript"">
    $(function () {
        $("".nav-link"").each(function () {
            var href = $(this).attr(""href"");
            if (window.location.href.indexOf(href) != -1) {
                $(this).addClass(""active"");
            }
        });
    })
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591