#pragma checksum "C:\Users\tbarron\source\repos\DevBuild2020_Assessment5\DevBuild2020_Assessment5\Views\Rsvp\RsvpIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48da3fde9806a87f0bfcdc5027c64c9c1e2ceb2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rsvp_RsvpIndex), @"mvc.1.0.view", @"/Views/Rsvp/RsvpIndex.cshtml")]
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
#line 1 "C:\Users\tbarron\source\repos\DevBuild2020_Assessment5\DevBuild2020_Assessment5\Views\_ViewImports.cshtml"
using DevBuild2020_Assessment5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tbarron\source\repos\DevBuild2020_Assessment5\DevBuild2020_Assessment5\Views\_ViewImports.cshtml"
using DevBuild2020_Assessment5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48da3fde9806a87f0bfcdc5027c64c9c1e2ceb2c", @"/Views/Rsvp/RsvpIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07d0dc1d6bb85d3e707d601f4ce8e1c6aa1046a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Rsvp_RsvpIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DevBuild2020_Assessment5.Models.RsvpForm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Rsvp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Rsvp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\tbarron\source\repos\DevBuild2020_Assessment5\DevBuild2020_Assessment5\Views\Rsvp\RsvpIndex.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>RSVP</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48da3fde9806a87f0bfcdc5027c64c9c1e2ceb2c4679", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 10 "C:\Users\tbarron\source\repos\DevBuild2020_Assessment5\DevBuild2020_Assessment5\Views\Rsvp\RsvpIndex.cshtml"
Write(Html.LabelFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral(": ");
#nullable restore
#line 10 "C:\Users\tbarron\source\repos\DevBuild2020_Assessment5\DevBuild2020_Assessment5\Views\Rsvp\RsvpIndex.cshtml"
                                 Write(Html.EditorFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n\r\n    ");
#nullable restore
#line 12 "C:\Users\tbarron\source\repos\DevBuild2020_Assessment5\DevBuild2020_Assessment5\Views\Rsvp\RsvpIndex.cshtml"
Write(Html.LabelFor(m => m.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral(": ");
#nullable restore
#line 12 "C:\Users\tbarron\source\repos\DevBuild2020_Assessment5\DevBuild2020_Assessment5\Views\Rsvp\RsvpIndex.cshtml"
                                Write(Html.EditorFor(m => m.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n\r\n    ");
#nullable restore
#line 14 "C:\Users\tbarron\source\repos\DevBuild2020_Assessment5\DevBuild2020_Assessment5\Views\Rsvp\RsvpIndex.cshtml"
Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral(": ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "48da3fde9806a87f0bfcdc5027c64c9c1e2ceb2c6369", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 14 "C:\Users\tbarron\source\repos\DevBuild2020_Assessment5\DevBuild2020_Assessment5\Views\Rsvp\RsvpIndex.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("<br />\r\n\r\n    ");
#nullable restore
#line 16 "C:\Users\tbarron\source\repos\DevBuild2020_Assessment5\DevBuild2020_Assessment5\Views\Rsvp\RsvpIndex.cshtml"
Write(Html.LabelFor(m => m.Attending));

#line default
#line hidden
#nullable disable
                WriteLiteral(":\r\n    ");
#nullable restore
#line 17 "C:\Users\tbarron\source\repos\DevBuild2020_Assessment5\DevBuild2020_Assessment5\Views\Rsvp\RsvpIndex.cshtml"
Write(Html.RadioButtonFor(m => m.Attending, "true"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" Yes\r\n    ");
#nullable restore
#line 18 "C:\Users\tbarron\source\repos\DevBuild2020_Assessment5\DevBuild2020_Assessment5\Views\Rsvp\RsvpIndex.cshtml"
Write(Html.RadioButtonFor(m => m.Attending, "false"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" No <br />\r\n\r\n");
                WriteLiteral("\r\n    ");
#nullable restore
#line 29 "C:\Users\tbarron\source\repos\DevBuild2020_Assessment5\DevBuild2020_Assessment5\Views\Rsvp\RsvpIndex.cshtml"
Write(Html.LabelFor(m => m.Guest));

#line default
#line hidden
#nullable disable
                WriteLiteral(": ");
#nullable restore
#line 29 "C:\Users\tbarron\source\repos\DevBuild2020_Assessment5\DevBuild2020_Assessment5\Views\Rsvp\RsvpIndex.cshtml"
                             Write(Html.EditorFor(m => m.Guest));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n    <input type=\"submit\" value=\"REGISTER\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DevBuild2020_Assessment5.Models.RsvpForm> Html { get; private set; }
    }
}
#pragma warning restore 1591