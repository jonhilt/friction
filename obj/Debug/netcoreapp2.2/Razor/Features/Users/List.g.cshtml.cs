#pragma checksum "D:\Jon\OneDrive\Talks\Layers to Vertical Slices\FrictionProject\Friction.WebVS\Features\Users\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "881c68b55e655d8c8c302e6f0e44e431efb5fa84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Features_Users_List), @"mvc.1.0.view", @"/Features/Users/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Features/Users/List.cshtml", typeof(AspNetCore.Features_Users_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"881c68b55e655d8c8c302e6f0e44e431efb5fa84", @"/Features/Users/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Features/_ViewImports.cshtml")]
    public class Features_Users_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Friction.WebVS.Features.Users.List.Model>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Jon\OneDrive\Talks\Layers to Vertical Slices\FrictionProject\Friction.WebVS\Features\Users\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(89, 20, true);
            WriteLiteral("\r\n<h1>Users</h1>\r\n\r\n");
            EndContext();
#line 8 "D:\Jon\OneDrive\Talks\Layers to Vertical Slices\FrictionProject\Friction.WebVS\Features\Users\List.cshtml"
 foreach (var user in Model.Users)
{

#line default
#line hidden
            BeginContext(148, 213, true);
            WriteLiteral("    <table>\r\n        <thead>\r\n            <tr>\r\n                <th>First Name</th>\r\n                <th>Last Name</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n            <tr>\r\n                <td>");
            EndContext();
            BeginContext(362, 14, false);
#line 19 "D:\Jon\OneDrive\Talks\Layers to Vertical Slices\FrictionProject\Friction.WebVS\Features\Users\List.cshtml"
               Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(376, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(404, 13, false);
#line 20 "D:\Jon\OneDrive\Talks\Layers to Vertical Slices\FrictionProject\Friction.WebVS\Features\Users\List.cshtml"
               Write(user.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(417, 58, true);
            WriteLiteral("</td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 24 "D:\Jon\OneDrive\Talks\Layers to Vertical Slices\FrictionProject\Friction.WebVS\Features\Users\List.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Friction.WebVS.Features.Users.List.Model> Html { get; private set; }
    }
}
#pragma warning restore 1591