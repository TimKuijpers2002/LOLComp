#pragma checksum "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Matches.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73a5cc6b142be1ed82a2f5bcf78d7200b13f35ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LOL_Matches), @"mvc.1.0.view", @"/Views/LOL/Matches.cshtml")]
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
#line 1 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\_ViewImports.cshtml"
using LOLComp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\_ViewImports.cshtml"
using LOLComp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73a5cc6b142be1ed82a2f5bcf78d7200b13f35ea", @"/Views/LOL/Matches.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02796557692036e907fccda2cc36bbec15e4942b", @"/Views/_ViewImports.cshtml")]
    public class Views_LOL_Matches : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LOLComp.Models.MatchViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 7 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Matches.cshtml"
           Write(Html.DisplayNameFor(model => model.gameType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 10 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Matches.cshtml"
           Write(Html.DisplayNameFor(model => model.gameDuration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Matches.cshtml"
           Write(Html.DisplayNameFor(model => model.platformId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Matches.cshtml"
           Write(Html.DisplayNameFor(model => model.seasonId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Matches.cshtml"
           Write(Html.DisplayNameFor(model => model.gameVersion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Matches.cshtml"
           Write(Html.DisplayNameFor(model => model.mapId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Matches.cshtml"
           Write(Html.DisplayNameFor(model => model.gameMode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Matches.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Matches.cshtml"
           Write(Html.DisplayFor(modelItem => item.gameType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Matches.cshtml"
           Write(Html.DisplayFor(modelItem => item.gameDuration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Matches.cshtml"
           Write(Html.DisplayFor(modelItem => item.platformId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Matches.cshtml"
           Write(Html.DisplayFor(modelItem => item.seasonId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Matches.cshtml"
           Write(Html.DisplayFor(modelItem => item.gameVersion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Matches.cshtml"
           Write(Html.DisplayFor(modelItem => item.mapId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Matches.cshtml"
           Write(Html.DisplayFor(modelItem => item.gameMode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Matches.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 58 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Matches.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LOLComp.Models.MatchViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
