#pragma checksum "/Users/aaronharrington/Documents/Coding_Dojo/csharp/fundamentals/BeltExam/BrightIdeas/Views/Home/ShowLikes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e04d9e822321102c7ed1ccb029fbf066d14a19c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowLikes), @"mvc.1.0.view", @"/Views/Home/ShowLikes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShowLikes.cshtml", typeof(AspNetCore.Views_Home_ShowLikes))]
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
#line 1 "/Users/aaronharrington/Documents/Coding_Dojo/csharp/fundamentals/BeltExam/BrightIdeas/Views/_ViewImports.cshtml"
using BrightIdeas;

#line default
#line hidden
#line 2 "/Users/aaronharrington/Documents/Coding_Dojo/csharp/fundamentals/BeltExam/BrightIdeas/Views/_ViewImports.cshtml"
using BrightIdeas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e04d9e822321102c7ed1ccb029fbf066d14a19c9", @"/Views/Home/ShowLikes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3089d01e8107546353dc71acbeb0ef609963fe45", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowLikes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Idea>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(12, 104, true);
            WriteLiteral("\n<a href=\"/Bright_Ideas\">Bright Ideas</a>\n<a href=\"/Logout\">Logout</a>\n\n<div class=\"jumbotron\">\n    <h2>");
            EndContext();
            BeginContext(117, 20, false);
#line 7 "/Users/aaronharrington/Documents/Coding_Dojo/csharp/fundamentals/BeltExam/BrightIdeas/Views/Home/ShowLikes.cshtml"
   Write(ViewBag.Poster.Alias);

#line default
#line hidden
            EndContext();
            BeginContext(137, 19, true);
            WriteLiteral(" says</h2>\n    <h2>");
            EndContext();
            BeginContext(157, 10, false);
#line 8 "/Users/aaronharrington/Documents/Coding_Dojo/csharp/fundamentals/BeltExam/BrightIdeas/Views/Home/ShowLikes.cshtml"
   Write(Model.Post);

#line default
#line hidden
            EndContext();
            BeginContext(167, 137, true);
            WriteLiteral("</h2>\n</div>\n\n\n\n<p>People Who Liked This Post:</p>\n<table class=\"table\">\n    <tr>\n        <th>Alias</td>\n        <th>Name</td>\n    </tr>\n");
            EndContext();
#line 19 "/Users/aaronharrington/Documents/Coding_Dojo/csharp/fundamentals/BeltExam/BrightIdeas/Views/Home/ShowLikes.cshtml"
     foreach(Like l in ViewBag.Likes)
    {

#line default
#line hidden
            BeginContext(348, 29, true);
            WriteLiteral("        <tr>\n            <td>");
            EndContext();
            BeginContext(378, 13, false);
#line 22 "/Users/aaronharrington/Documents/Coding_Dojo/csharp/fundamentals/BeltExam/BrightIdeas/Views/Home/ShowLikes.cshtml"
           Write(l.Liker.Alias);

#line default
#line hidden
            EndContext();
            BeginContext(391, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(414, 12, false);
#line 23 "/Users/aaronharrington/Documents/Coding_Dojo/csharp/fundamentals/BeltExam/BrightIdeas/Views/Home/ShowLikes.cshtml"
           Write(l.Liker.Name);

#line default
#line hidden
            EndContext();
            BeginContext(426, 20, true);
            WriteLiteral("</td>\n        </tr>\n");
            EndContext();
#line 25 "/Users/aaronharrington/Documents/Coding_Dojo/csharp/fundamentals/BeltExam/BrightIdeas/Views/Home/ShowLikes.cshtml"
    }

#line default
#line hidden
            BeginContext(452, 8, true);
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Idea> Html { get; private set; }
    }
}
#pragma warning restore 1591
