#pragma checksum "/Users/husker/Documents/GitHub/DevBuild2020_Assessment6/DevBuild2020_Assessment5/Views/Admin/AdminIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cab1981ae01fb77aefcddc0dd10a180de13e24b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminIndex), @"mvc.1.0.view", @"/Views/Admin/AdminIndex.cshtml")]
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
#line 1 "/Users/husker/Documents/GitHub/DevBuild2020_Assessment6/DevBuild2020_Assessment5/Views/_ViewImports.cshtml"
using DevBuild2020_Assessment5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/husker/Documents/GitHub/DevBuild2020_Assessment6/DevBuild2020_Assessment5/Views/_ViewImports.cshtml"
using DevBuild2020_Assessment5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cab1981ae01fb77aefcddc0dd10a180de13e24b4", @"/Views/Admin/AdminIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d8dd276a16b29e703a1b0162075cb63c372379c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "/Users/husker/Documents/GitHub/DevBuild2020_Assessment6/DevBuild2020_Assessment5/Views/Admin/AdminIndex.cshtml"
  
    ViewData["Title"] = "Admin Index";
    List<RsvpForm> Products = (List<RsvpForm>)ViewData["Products"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Product Administration**</h1>\n");
#nullable restore
#line 8 "/Users/husker/Documents/GitHub/DevBuild2020_Assessment6/DevBuild2020_Assessment5/Views/Admin/AdminIndex.cshtml"
 if  (TempData["UserMsg"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 10 "/Users/husker/Documents/GitHub/DevBuild2020_Assessment6/DevBuild2020_Assessment5/Views/Admin/AdminIndex.cshtml"
  Write(TempData["UserMsg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 11 "/Users/husker/Documents/GitHub/DevBuild2020_Assessment6/DevBuild2020_Assessment5/Views/Admin/AdminIndex.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div><a href=\"/Admin/AddForm\">Add</a></div>\n\n\n\n");
#nullable restore
#line 18 "/Users/husker/Documents/GitHub/DevBuild2020_Assessment6/DevBuild2020_Assessment5/Views/Admin/AdminIndex.cshtml"
 foreach (RsvpForm r in Products)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\n        ");
#nullable restore
#line 21 "/Users/husker/Documents/GitHub/DevBuild2020_Assessment6/DevBuild2020_Assessment5/Views/Admin/AdminIndex.cshtml"
   Write(r.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 21 "/Users/husker/Documents/GitHub/DevBuild2020_Assessment6/DevBuild2020_Assessment5/Views/Admin/AdminIndex.cshtml"
                Write(r.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 21 "/Users/husker/Documents/GitHub/DevBuild2020_Assessment6/DevBuild2020_Assessment5/Views/Admin/AdminIndex.cshtml"
                            Write(r.EmailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 21 "/Users/husker/Documents/GitHub/DevBuild2020_Assessment6/DevBuild2020_Assessment5/Views/Admin/AdminIndex.cshtml"
                                            Write(r.Attending);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <a");
            BeginWriteAttribute("href", " href=\"", 386, "\"", 410, 2);
            WriteAttributeValue("", 393, "/Admin/Edit/", 393, 12, true);
#nullable restore
#line 22 "/Users/husker/Documents/GitHub/DevBuild2020_Assessment6/DevBuild2020_Assessment5/Views/Admin/AdminIndex.cshtml"
WriteAttributeValue("", 405, r.Id, 405, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\n        <a");
            BeginWriteAttribute("href", " href=\"", 431, "\"", 457, 2);
            WriteAttributeValue("", 438, "/Admin/Delete/", 438, 14, true);
#nullable restore
#line 23 "/Users/husker/Documents/GitHub/DevBuild2020_Assessment6/DevBuild2020_Assessment5/Views/Admin/AdminIndex.cshtml"
WriteAttributeValue("", 452, r.Id, 452, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\n    </div>\n");
#nullable restore
#line 25 "/Users/husker/Documents/GitHub/DevBuild2020_Assessment6/DevBuild2020_Assessment5/Views/Admin/AdminIndex.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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