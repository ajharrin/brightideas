#pragma checksum "/Users/aaronharrington/Documents/Coding_Dojo/csharp/fundamentals/BeltExam/BrightIdeas/Views/Home/Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4b76adbb1d92f122f9f532998be88460186f397"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Profile), @"mvc.1.0.view", @"/Views/Home/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Profile.cshtml", typeof(AspNetCore.Views_Home_Profile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4b76adbb1d92f122f9f532998be88460186f397", @"/Views/Home/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3089d01e8107546353dc71acbeb0ef609963fe45", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 83, true);
            WriteLiteral("<a href=\"/idea\">Bright Ideas</a>   <a href=\"/logout\">Logout</a>\n<ul>\n    <li>Name: ");
            EndContext();
            BeginContext(84, 21, false);
#line 3 "/Users/aaronharrington/Documents/Coding_Dojo/csharp/fundamentals/BeltExam/BrightIdeas/Views/Home/Profile.cshtml"
         Write(ViewBag.ViewUser.Name);

#line default
#line hidden
            EndContext();
            BeginContext(105, 21, true);
            WriteLiteral("</li>\n    <li>Alias: ");
            EndContext();
            BeginContext(127, 22, false);
#line 4 "/Users/aaronharrington/Documents/Coding_Dojo/csharp/fundamentals/BeltExam/BrightIdeas/Views/Home/Profile.cshtml"
          Write(ViewBag.ViewUser.Alias);

#line default
#line hidden
            EndContext();
            BeginContext(149, 21, true);
            WriteLiteral("</li>\n    <li>Email: ");
            EndContext();
            BeginContext(171, 22, false);
#line 5 "/Users/aaronharrington/Documents/Coding_Dojo/csharp/fundamentals/BeltExam/BrightIdeas/Views/Home/Profile.cshtml"
          Write(ViewBag.ViewUser.Email);

#line default
#line hidden
            EndContext();
            BeginContext(193, 43, true);
            WriteLiteral("</li>\n</ul>\n<hr>\n<p>Total number of Ideas: ");
            EndContext();
            BeginContext(237, 32, false);
#line 8 "/Users/aaronharrington/Documents/Coding_Dojo/csharp/fundamentals/BeltExam/BrightIdeas/Views/Home/Profile.cshtml"
                     Write(ViewBag.ViewUser.UserIdeas.Count);

#line default
#line hidden
            EndContext();
            BeginContext(269, 37, true);
            WriteLiteral("</p>\n<p>Total number of Likes given: ");
            EndContext();
            BeginContext(307, 33, false);
#line 9 "/Users/aaronharrington/Documents/Coding_Dojo/csharp/fundamentals/BeltExam/BrightIdeas/Views/Home/Profile.cshtml"
                           Write(ViewBag.ViewUser.IdeasLiked.Count);

#line default
#line hidden
            EndContext();
            BeginContext(340, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
