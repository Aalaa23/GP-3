#pragma checksum "C:\Users\lenovo\source\repos\GP-3\Gp-3\Views\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e46c1b90674768a5fdecc89d5567dc9690964523"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login), @"mvc.1.0.view", @"/Views/Login.cshtml")]
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
#line 1 "C:\Users\lenovo\source\repos\GP-3\Gp-3\Views\_ViewImports.cshtml"
using Gp_3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\source\repos\GP-3\Gp-3\Views\_ViewImports.cshtml"
using Gp_3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\source\repos\GP-3\Gp-3\Views\Login.cshtml"
using Gp_3.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e46c1b90674768a5fdecc89d5567dc9690964523", @"/Views/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24aff37f62a436d6804e336eb3afc78cbca03912", @"/Views/_ViewImports.cshtml")]
    public class Views_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\lenovo\source\repos\GP-3\Gp-3\Views\Login.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e46c1b90674768a5fdecc89d5567dc96909645233529", async() => {
                WriteLiteral(@"
    <title>Login</title>
    <!-- Meta tag Keywords -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" />
    <meta name=""keywords"" content=""Smart Login Form Responsive Widget,Login form widgets, Sign up Web forms , Login signup Responsive web form,Flat Pricing table,Flat Drop downs,Registration Forms,News letter Forms,Elements"" />
    <script type=""application/x-javascript"">
         addEventListener(""load"", function() { setTimeout(hideURLbar, 0); }, false);
        function hideURLbar(){ window.scrollTo(0,1); } </script>
    <!-- Meta tag Keywords -->
    <!-- css files -->
    <link href=""/smartlogin/css/style.css"" rel=""stylesheet"" type=""text/css"" media=""all"">
    <!-- online-fonts -->
    <link href=""//fonts.googleapis.com/css?family=Roboto+Slab:100,300,400,700Roboto:100,100i,300,300i,400,400i,500,500i,700,700i,900,900iSlabo+27px&subset=cyrillic,cyrillic-ext,greek,greek-ext,latin-ext,vietnamese"" ");
                WriteLiteral("rel=\"stylesheet\">\r\n    <!--//online-fonts -->\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e46c1b90674768a5fdecc89d5567dc96909645235630", async() => {
                WriteLiteral("\r\n    <!--header-->\r\n    <div class=\"agileheader\">\r\n        <h1>Smart Login Form</h1>\r\n    </div>\r\n    <!--//header-->\r\n    <!--main-->\r\n    <div class=\"main-w3l\">\r\n        <div class=\"w3layouts-main\">\r\n            <h2>Login Now</h2>\r\n");
#nullable restore
#line 36 "C:\Users\lenovo\source\repos\GP-3\Gp-3\Views\Login.cshtml"
             using (Html.BeginForm("SmartLogin", "Account", new { ReturnUrl = ViewBag.ReturnUrl }, FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
            {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\lenovo\source\repos\GP-3\Gp-3\Views\Login.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\lenovo\source\repos\GP-3\Gp-3\Views\Login.cshtml"
       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 41 "C:\Users\lenovo\source\repos\GP-3\Gp-3\Views\Login.cshtml"
           Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control", @placeholder = "E-Mail", @type = "email" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 42 "C:\Users\lenovo\source\repos\GP-3\Gp-3\Views\Login.cshtml"
           Write(Html.ValidationMessageFor(m => m.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 45 "C:\Users\lenovo\source\repos\GP-3\Gp-3\Views\Login.cshtml"
           Write(Html.PasswordFor(m => m.Password, new { @class = "form-control", @placeholder = "Password" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 46 "C:\Users\lenovo\source\repos\GP-3\Gp-3\Views\Login.cshtml"
           Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <h6><a href=\"#\">Forgot Password?</a></h6>\r\n            <div class=\"clear\"></div>\r\n            <span>");
#nullable restore
#line 50 "C:\Users\lenovo\source\repos\GP-3\Gp-3\Views\Login.cshtml"
             Write(Html.CheckBoxFor(m => m.RememberMe));

#line default
#line hidden
#nullable disable
                WriteLiteral("Remember Me</span>\r\n            <input type=\"submit\" value=\"login\" name=\"login\">\r\n");
#nullable restore
#line 52 "C:\Users\lenovo\source\repos\GP-3\Gp-3\Views\Login.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p>Don\'t Have an Account ?<a href=\"#\">Register Now</a></p>\r\n        </div>\r\n    </div>\r\n    <!--//main-->\r\n    <!--footer-->\r\n    <div class=\"footer-w3l\">\r\n        \r\n    </div>\r\n    <!--//footer-->\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
