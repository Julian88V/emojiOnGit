#pragma checksum "/Users/juliangoudy/Projects/GitHubEmojis/GitHubEmojis/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65eb2fbee71a8b0427b795d67930d91ec0ae7457"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GitHubEmojis.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(GitHubEmojis.Pages.Pages_Index), null)]
namespace GitHubEmojis.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/juliangoudy/Projects/GitHubEmojis/GitHubEmojis/Pages/_ViewImports.cshtml"
using GitHubEmojis;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65eb2fbee71a8b0427b795d67930d91ec0ae7457", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f614f2fd6316609502264b93aa91d4a0f30e19a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 52, true);
            WriteLiteral("<h1>Emojis on GitHub</h1>\r\n<div class=\"allEmojis\">\r\n");
            EndContext();
#line 8 "/Users/juliangoudy/Projects/GitHubEmojis/GitHubEmojis/Pages/Index.cshtml"
     foreach (var em in Model.Emojis)
    {

#line default
#line hidden
            BeginContext(133, 45, true);
            WriteLiteral("        <div class=\"emoji\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 178, "\"", 191, 1);
#line 11 "/Users/juliangoudy/Projects/GitHubEmojis/GitHubEmojis/Pages/Index.cshtml"
WriteAttributeValue("", 184, em.Url, 184, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 192, "\"", 211, 2);
            WriteAttributeValue("", 198, "emoji", 198, 5, true);
#line 11 "/Users/juliangoudy/Projects/GitHubEmojis/GitHubEmojis/Pages/Index.cshtml"
WriteAttributeValue(" ", 203, em.Key, 204, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(212, 48, true);
            WriteLiteral(" height=\"128\" width=\"128\" />\r\n            <code>");
            EndContext();
            BeginContext(261, 6, false);
#line 12 "/Users/juliangoudy/Projects/GitHubEmojis/GitHubEmojis/Pages/Index.cshtml"
             Write(em.Key);

#line default
#line hidden
            EndContext();
            BeginContext(267, 25, true);
            WriteLiteral("</code>\r\n        </div>\r\n");
            EndContext();
#line 14 "/Users/juliangoudy/Projects/GitHubEmojis/GitHubEmojis/Pages/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(299, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591