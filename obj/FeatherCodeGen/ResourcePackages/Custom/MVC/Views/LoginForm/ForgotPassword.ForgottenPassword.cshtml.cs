#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RealSiteFinityFirst.ResourcePackages.Custom.MVC.Views.LoginForm
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 9 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 10 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 8 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/LoginForm/ForgotPassword.ForgottenPassword.cshtml")]
    public partial class ForgotPassword_ForgottenPassword : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.LoginForm.ForgotPasswordViewModel>
    {
        public ForgotPassword_ForgottenPassword()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 478), Tuple.Create("\"", 501)
            
            #line 12 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
, Tuple.Create(Tuple.Create("", 486), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 486), false)
);

WriteLiteral(">\r\n\r\n    <h3>");

            
            #line 14 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
   Write(Html.Resource("ForgotPasswordHeader"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n\r\n");

            
            #line 16 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
    
            
            #line default
            #line hidden
            
            #line 16 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
     if (Model.EmailSent)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteAttribute("id", Tuple.Create(" id=\'", 606), Tuple.Create("\'", 658)
            
            #line 18 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
, Tuple.Create(Tuple.Create("", 611), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("ForgotPasswordRequestSentInfo")
            
            #line default
            #line hidden
, 611), false)
);

WriteLiteral(">");

            
            #line 18 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
                                                           Write(Html.Resource("ForgotPasswordRequestSent"));

            
            #line default
            #line hidden
WriteLiteral(" <i>");

            
            #line 18 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
                                                                                                          Write(Html.Encode(Model.Email));

            
            #line default
            #line hidden
WriteLiteral("</i></p>\r\n");

            
            #line 19 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteAttribute("id", Tuple.Create(" id=\'", 754), Tuple.Create("\'", 813)
            
            #line 20 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
, Tuple.Create(Tuple.Create("", 759), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("ForgotPasswordRequestSentUseLinkInfo")
            
            #line default
            #line hidden
, 759), false)
);

WriteLiteral(">");

            
            #line 20 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
                                                                  Write(Html.Resource("ForgotPasswordRequestSentUseLink"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 21 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"

        var forgottenPasswordDescription = Html.UniqueId("ForgotPasswordRequestSentInfo") + " " + Html.UniqueId("ForgotPasswordRequestSentUseLinkInfo");

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1037), Tuple.Create("\"", 1063)
            
            #line 23 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
, Tuple.Create(Tuple.Create("", 1044), Tuple.Create<System.Object, System.Int32>(Model.LoginPageUrl
            
            #line default
            #line hidden
, 1044), false)
);

WriteLiteral(" class=\"btn btn-secondary\"");

WriteAttribute("aria-describedby", Tuple.Create(" aria-describedby=\"", 1090), Tuple.Create("\"", 1138)
            
            #line 23 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
  , Tuple.Create(Tuple.Create("", 1109), Tuple.Create<System.Object, System.Int32>(forgottenPasswordDescription
            
            #line default
            #line hidden
, 1109), false)
);

WriteLiteral(">");

            
            #line 23 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
                                                                                                            Write(Html.Resource("ForgotPasswordBackToLogin"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 24 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
    }
    else
    {
        using (Html.BeginForm("SendPasswordResetEmail", "LoginForm"))
        {

            
            #line default
            #line hidden
WriteLiteral("            <p");

WriteAttribute("id", Tuple.Create(" id=\'", 1309), Tuple.Create("\'", 1358)
            
            #line 29 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
, Tuple.Create(Tuple.Create("", 1314), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("EnterLoginEmailAddressInfo")
            
            #line default
            #line hidden
, 1314), false)
);

WriteLiteral(">");

            
            #line 29 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
                                                            Write(Html.Resource("EnterLoginEmailAddress"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 30 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 32 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
           Write(Html.LabelFor(u => u.Email, Html.Resource("ForgotPasswordEmail")));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 33 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
           Write(Html.TextBoxFor(u => u.Email, new { @class = "form-control", aria_describedby = Html.UniqueId("EnterLoginEmailAddressInfo") }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 35 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" ");

            
            #line 36 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
                                                      Write(SystemManager.IsDesignMode ? "disabled" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 36 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
                                                                                                     Write(Html.Resource("ForgotPasswordSendButton"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n");

            
            #line 37 "..\..MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
        }
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
