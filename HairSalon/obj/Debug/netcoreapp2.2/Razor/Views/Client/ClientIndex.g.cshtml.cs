#pragma checksum "D:\Users\TheKerj\desktop\epicodus19\HairSalon.Solutions\HairSalon\Views\Client\ClientIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ba6a6182913cd955519cb91644277c24ec6a13b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_ClientIndex), @"mvc.1.0.view", @"/Views/Client/ClientIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Client/ClientIndex.cshtml", typeof(AspNetCore.Views_Client_ClientIndex))]
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
#line 1 "D:\Users\TheKerj\desktop\epicodus19\HairSalon.Solutions\HairSalon\Views\Client\ClientIndex.cshtml"
using HairSalon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ba6a6182913cd955519cb91644277c24ec6a13b", @"/Views/Client/ClientIndex.cshtml")]
    public class Views_Client_ClientIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(55, 245, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ba6a6182913cd955519cb91644277c24ec6a13b4337", async() => {
                BeginContext(61, 181, true);
                WriteLiteral("\r\n    <meta charset=\'utf-8\'>\r\n    <title>View your clients</title>\r\n    <link rel=\'stylesheet\' href=\'https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css\'>\r\n    ");
                EndContext();
                BeginContext(242, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8ba6a6182913cd955519cb91644277c24ec6a13b4910", async() => {
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
                BeginContext(289, 4, true);
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
            BeginContext(300, 4, true);
            WriteLiteral("\r\n  ");
            EndContext();
            BeginContext(304, 632, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ba6a6182913cd955519cb91644277c24ec6a13b7043", async() => {
                BeginContext(328, 59, true);
                WriteLiteral("\r\n\r\n    <h1 class=\"jumbotron\">Here are the clients</h1>\r\n\r\n");
                EndContext();
#line 15 "D:\Users\TheKerj\desktop\epicodus19\HairSalon.Solutions\HairSalon\Views\Client\ClientIndex.cshtml"
     if (Model.Count == 0)
    {

#line default
#line hidden
                BeginContext(422, 39, true);
                WriteLiteral("      <p>There are no clients :(!</p>\r\n");
                EndContext();
#line 18 "D:\Users\TheKerj\desktop\epicodus19\HairSalon.Solutions\HairSalon\Views\Client\ClientIndex.cshtml"
    }

#line default
#line hidden
                BeginContext(468, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 19 "D:\Users\TheKerj\desktop\epicodus19\HairSalon.Solutions\HairSalon\Views\Client\ClientIndex.cshtml"
     if(Model.Count != 0)
    {
      

#line default
#line hidden
#line 21 "D:\Users\TheKerj\desktop\epicodus19\HairSalon.Solutions\HairSalon\Views\Client\ClientIndex.cshtml"
       foreach (Client client in Model)
      {

#line default
#line hidden
                BeginContext(552, 50, true);
                WriteLiteral("      <li>\r\n        To the Stylist for\r\n        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 602, "\'", 627, 2);
                WriteAttributeValue("", 609, "/Client/", 609, 8, true);
#line 25 "D:\Users\TheKerj\desktop\epicodus19\HairSalon.Solutions\HairSalon\Views\Client\ClientIndex.cshtml"
WriteAttributeValue("", 617, client.Id, 617, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(628, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(630, 11, false);
#line 25 "D:\Users\TheKerj\desktop\epicodus19\HairSalon.Solutions\HairSalon\Views\Client\ClientIndex.cshtml"
                                Write(client.Name);

#line default
#line hidden
                EndContext();
                BeginContext(641, 20, true);
                WriteLiteral("</a><br>\r\n        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 661, "\'", 691, 3);
                WriteAttributeValue("", 668, "/client/", 668, 8, true);
#line 26 "D:\Users\TheKerj\desktop\epicodus19\HairSalon.Solutions\HairSalon\Views\Client\ClientIndex.cshtml"
WriteAttributeValue("", 676, client.Id, 676, 10, false);

#line default
#line hidden
                WriteAttributeValue("", 686, "/Edit", 686, 5, true);
                EndWriteAttribute();
                BeginContext(692, 31, true);
                WriteLiteral(">Edit Client</a>\r\n      </li>\r\n");
                EndContext();
#line 28 "D:\Users\TheKerj\desktop\epicodus19\HairSalon.Solutions\HairSalon\Views\Client\ClientIndex.cshtml"
      }

#line default
#line hidden
#line 28 "D:\Users\TheKerj\desktop\epicodus19\HairSalon.Solutions\HairSalon\Views\Client\ClientIndex.cshtml"
       
    }

#line default
#line hidden
                BeginContext(739, 190, true);
                WriteLiteral("    </ul>\r\n\r\n    <a href=\'/client/new\'>Add a Client to the list</a><br>\r\n    <a href=\'/Stylist\'>Check out the list of Kaiju stylists</a><br>\r\n    <a href=\'/\'>Go Home</a>\r\n\r\n\r\n    </html>\r\n  ");
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
            BeginContext(936, 2, true);
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
