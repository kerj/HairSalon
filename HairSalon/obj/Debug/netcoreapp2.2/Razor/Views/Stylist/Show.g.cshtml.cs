#pragma checksum "D:\Users\TheKerj\desktop\epicodus19\HairSalon.Solutions\HairSalon\Views\Stylist\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d4693f3ba37b12be2dc9df1d1f5c4f4799a1c71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylist_Show), @"mvc.1.0.view", @"/Views/Stylist/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylist/Show.cshtml", typeof(AspNetCore.Views_Stylist_Show))]
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
#line 1 "D:\Users\TheKerj\desktop\epicodus19\HairSalon.Solutions\HairSalon\Views\Stylist\Show.cshtml"
using HairSalon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d4693f3ba37b12be2dc9df1d1f5c4f4799a1c71", @"/Views/Stylist/Show.cshtml")]
    public class Views_Stylist_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n  ");
            EndContext();
            BeginContext(55, 244, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d4693f3ba37b12be2dc9df1d1f5c4f4799a1c714289", async() => {
                BeginContext(61, 180, true);
                WriteLiteral("\r\n    <meta charset=\'utf-8\'>\r\n    <title>List of Stylists</title>\r\n    <link rel=\'stylesheet\' href=\'https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css\'>\r\n    ");
                EndContext();
                BeginContext(241, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1d4693f3ba37b12be2dc9df1d1f5c4f4799a1c714861", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(288, 4, true);
                WriteLiteral("\r\n  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(299, 4, true);
            WriteLiteral("\r\n  ");
            EndContext();
            BeginContext(303, 564, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d4693f3ba37b12be2dc9df1d1f5c4f4799a1c716994", async() => {
                BeginContext(327, 39, true);
                WriteLiteral("\r\n    <h1 class=\"jumbotron\">Details on ");
                EndContext();
                BeginContext(367, 10, false);
#line 12 "D:\Users\TheKerj\desktop\epicodus19\HairSalon.Solutions\HairSalon\Views\Stylist\Show.cshtml"
                                Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(377, 38, true);
                WriteLiteral("</h1>\r\n    <ul>\r\n      <li>Their Bio: ");
                EndContext();
                BeginContext(416, 9, false);
#line 14 "D:\Users\TheKerj\desktop\epicodus19\HairSalon.Solutions\HairSalon\Views\Stylist\Show.cshtml"
                Write(Model.Bio);

#line default
#line hidden
                EndContext();
                BeginContext(425, 34, true);
                WriteLiteral("</li>\r\n      <li>Their Specialty: ");
                EndContext();
                BeginContext(460, 15, false);
#line 15 "D:\Users\TheKerj\desktop\epicodus19\HairSalon.Solutions\HairSalon\Views\Stylist\Show.cshtml"
                      Write(Model.Specialty);

#line default
#line hidden
                EndContext();
                BeginContext(475, 19, true);
                WriteLiteral("</li>\r\n      <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 494, "\'", 526, 3);
                WriteAttributeValue("", 501, "/Stylist/", 501, 9, true);
#line 16 "D:\Users\TheKerj\desktop\epicodus19\HairSalon.Solutions\HairSalon\Views\Stylist\Show.cshtml"
WriteAttributeValue("", 510, Model.Id, 510, 9, false);

#line default
#line hidden
                WriteAttributeValue("", 519, "/client", 519, 7, true);
                EndWriteAttribute();
                BeginContext(527, 201, true);
                WriteLiteral(">View Clients</li>\r\n    </ul>\r\n\r\n    <a href=\'/\'>Go Home</a><br>\r\n    <a href=\'/Stylist/NewStylist\'>Add a Kaiju Stylist.</a><br>\r\n    <a href=\'/Specialty\'>View List of Specialties.</a><br>\r\n\r\n    <form");
                EndContext();
                BeginWriteAttribute("action", " action=\'", 728, "\'", 762, 3);
                WriteAttributeValue("", 737, "/Stylist/", 737, 9, true);
#line 23 "D:\Users\TheKerj\desktop\epicodus19\HairSalon.Solutions\HairSalon\Views\Stylist\Show.cshtml"
WriteAttributeValue("", 746, Model.Id, 746, 9, false);

#line default
#line hidden
                WriteAttributeValue("", 755, "/delete", 755, 7, true);
                EndWriteAttribute();
                BeginContext(763, 97, true);
                WriteLiteral(" method=\"post\">\r\n      <button type=\'submit\'>Delete Item</button>\r\n    </form>\r\n\r\n    </html>\r\n  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(867, 2, true);
            WriteLiteral("\r\n");
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
