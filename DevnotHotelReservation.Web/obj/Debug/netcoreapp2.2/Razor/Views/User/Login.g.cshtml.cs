#pragma checksum "C:\Users\508Games\Documents\Visual Studio 2017\Projects\DevnotHotelReservation\DevnotHotelReservation.Web\Views\User\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "777c3a53e2568d71f94d583669192c66e1f07a46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Login), @"mvc.1.0.view", @"/Views/User/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Login.cshtml", typeof(AspNetCore.Views_User_Login))]
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
#line 1 "C:\Users\508Games\Documents\Visual Studio 2017\Projects\DevnotHotelReservation\DevnotHotelReservation.Web\Views\_ViewImports.cshtml"
using DevnotHotelReservation.Web;

#line default
#line hidden
#line 2 "C:\Users\508Games\Documents\Visual Studio 2017\Projects\DevnotHotelReservation\DevnotHotelReservation.Web\Views\_ViewImports.cshtml"
using DevnotHotelReservation.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"777c3a53e2568d71f94d583669192c66e1f07a46", @"/Views/User/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26af0f3b7b2b51ada6054ce1f8052349b0c97af3", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DevnotHotelReservation.Entity.Model.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\508Games\Documents\Visual Studio 2017\Projects\DevnotHotelReservation\DevnotHotelReservation.Web\Views\User\Login.cshtml"
  
    Layout = "~/Views/Shared/_MyLayout.cshtml";

#line default
#line hidden
            BeginContext(105, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(134, 166, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "777c3a53e2568d71f94d583669192c66e1f07a464669", async() => {
                BeginContext(140, 91, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Login</title>\r\n    ");
                EndContext();
                BeginContext(231, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "777c3a53e2568d71f94d583669192c66e1f07a465148", async() => {
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
                BeginContext(291, 2, true);
                WriteLiteral("\r\n");
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
            BeginContext(300, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(302, 731, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "777c3a53e2568d71f94d583669192c66e1f07a467276", async() => {
                BeginContext(308, 71, true);
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <h2>Giriş Sayfası</h2>\r\n        ");
                EndContext();
                BeginContext(380, 15, false);
#line 17 "C:\Users\508Games\Documents\Visual Studio 2017\Projects\DevnotHotelReservation\DevnotHotelReservation.Web\Views\User\Login.cshtml"
   Write(ViewBag.Message);

#line default
#line hidden
                EndContext();
                BeginContext(395, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 18 "C:\Users\508Games\Documents\Visual Studio 2017\Projects\DevnotHotelReservation\DevnotHotelReservation.Web\Views\User\Login.cshtml"
         using (Html.BeginForm("Login", "User", FormMethod.Post))
        {

#line default
#line hidden
                BeginContext(475, 54, true);
                WriteLiteral("            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(530, 34, false);
#line 21 "C:\Users\508Games\Documents\Visual Studio 2017\Projects\DevnotHotelReservation\DevnotHotelReservation.Web\Views\User\Login.cshtml"
           Write(Html.LabelFor(m => m.EmailAddress));

#line default
#line hidden
                EndContext();
                BeginContext(564, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(583, 93, false);
#line 22 "C:\Users\508Games\Documents\Visual Studio 2017\Projects\DevnotHotelReservation\DevnotHotelReservation.Web\Views\User\Login.cshtml"
           Write(Html.TextBoxFor(m => m.EmailAddress, new { @class = "form-control", placeholder = "E-mail" }));

#line default
#line hidden
                EndContext();
                BeginContext(676, 76, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(753, 30, false);
#line 25 "C:\Users\508Games\Documents\Visual Studio 2017\Projects\DevnotHotelReservation\DevnotHotelReservation.Web\Views\User\Login.cshtml"
           Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
                EndContext();
                BeginContext(783, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(802, 89, false);
#line 26 "C:\Users\508Games\Documents\Visual Studio 2017\Projects\DevnotHotelReservation\DevnotHotelReservation.Web\Views\User\Login.cshtml"
           Write(Html.PasswordFor(m => m.Password, new { @class = "form-control", placeholder = "Sifre" }));

#line default
#line hidden
                EndContext();
                BeginContext(891, 110, true);
                WriteLiteral("\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-success btn-block\">Giriş Yap</button>\r\n");
                EndContext();
#line 29 "C:\Users\508Games\Documents\Visual Studio 2017\Projects\DevnotHotelReservation\DevnotHotelReservation.Web\Views\User\Login.cshtml"
        }

#line default
#line hidden
                BeginContext(1012, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1033, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DevnotHotelReservation.Entity.Model.User> Html { get; private set; }
    }
}
#pragma warning restore 1591