#pragma checksum "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\User\Groups.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40a02023ea9087eb9068c01bee5b94dd43f3c306"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Groups), @"mvc.1.0.view", @"/Views/User/Groups.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40a02023ea9087eb9068c01bee5b94dd43f3c306", @"/Views/User/Groups.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02796557692036e907fccda2cc36bbec15e4942b", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Groups : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LOLComp.Models.GroupModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\User\Groups.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 11 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\User\Groups.cshtml"
           Write(Html.DisplayNameFor(model => model.GroupID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\User\Groups.cshtml"
           Write(Html.DisplayNameFor(model => model.GroupName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 20 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\User\Groups.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 23 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\User\Groups.cshtml"
           Write(Html.DisplayFor(modelItem => item.GroupID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 26 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\User\Groups.cshtml"
           Write(Html.DisplayFor(modelItem => item.GroupName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 29 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\User\Groups.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 30 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\User\Groups.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\User\Groups.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LOLComp.Models.GroupModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
