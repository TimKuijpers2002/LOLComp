#pragma checksum "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9432658957b09dc090385cee6f45ab79dbba70f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LOL_Profile), @"mvc.1.0.view", @"/Views/LOL/Profile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9432658957b09dc090385cee6f45ab79dbba70f4", @"/Views/LOL/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02796557692036e907fccda2cc36bbec15e4942b", @"/Views/_ViewImports.cshtml")]
    public class Views_LOL_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LOLComp.Models.SummonerViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Profile.cshtml"
  
    ViewData["Title"] = "Profile";
    Layout = "~/Views/Shared/_LayoutLOLPage.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Profile</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Profile.cshtml"
       Write(Html.DisplayNameFor(model => model.ProfileIconID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Profile.cshtml"
       Write(Html.DisplayFor(model => model.ProfileIconID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Profile.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Profile.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Profile.cshtml"
       Write(Html.DisplayNameFor(model => model.SummonerLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Profile.cshtml"
       Write(Html.DisplayFor(model => model.SummonerLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Profile.cshtml"
       Write(Html.DisplayNameFor(model => model.Region));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Profile.cshtml"
       Write(Html.DisplayFor(model => model.Region));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n</div>\r\n");
#nullable restore
#line 38 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Profile.cshtml"
  
    var differentChampions = Model.matchViewModels.Select(x => x.yourChampion).Distinct().ToList();
    foreach (var champion in differentChampions)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Profile.cshtml"
   Write(Html.ActionLink(" Sort by:" + champion + " |", "Profile", "LOL", new { summonerName = Model.Name, region = Model.Region, championId = champion }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Profile.cshtml"
                                                                                                                                                          ;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <partial>\r\n");
#nullable restore
#line 47 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Profile.cshtml"
          
            Html.RenderPartial("Matches", Model.matchViewModels);
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </partial>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9432658957b09dc090385cee6f45ab79dbba70f48477", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 54 "C:\Users\TimKu\OneDrive\Bureaublad\Semester 2.3\Maatwerk files\Individueel\Main Project\LOLComp\LOLComp\Views\LOL\Profile.cshtml"
                             Write(Html.ActionLink("Remove filters", "Profile", "LOL", new { summonerName = Model.Name, region = Model.Region}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LOLComp.Models.SummonerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
