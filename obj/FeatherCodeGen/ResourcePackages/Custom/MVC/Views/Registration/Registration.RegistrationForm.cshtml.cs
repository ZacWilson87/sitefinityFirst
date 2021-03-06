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

namespace RealSiteFinityFirst.ResourcePackages.Custom.MVC.Views.Registration
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    
    #line 8 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    using System.Linq.Expressions;
    
    #line default
    #line hidden
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
    
    #line 14 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    using Telerik.Sitefinity.Frontend.Identity.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 15 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    using Telerik.Sitefinity.Frontend.Identity.Mvc.Models.Registration;
    
    #line default
    #line hidden
    
    #line 9 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 10 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 13 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 11 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    #line 12 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    using Telerik.Sitefinity.Utilities;
    
    #line default
    #line hidden
    
    #line 16 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    using Telerik.Sitefinity.Web;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Registration/Registration.RegistrationForm.cshtml")]
    public partial class Registration_RegistrationForm : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.Registration.RegistrationViewModel>
    {

#line 140 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
public System.Web.WebPages.HelperResult FormGroupPanel(string label, Expression<Func<RegistrationViewModel, string>> expression, string descId, string inputType = "text", string classValue = null, IDictionary<string, object> additionalAttributes = null)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 141 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
 
    var hasValidationMessage = Html.ValidationMessageFor(expression) != null;
    var attributes = new Dictionary<string, object>();
    var cls = "form-control";

    if (classValue != null)
    {
        cls += " " + classValue;
    }

    attributes.Add("class", cls);

    if (hasValidationMessage)
    {
        attributes.Add("aria-describedby", Html.UniqueId(descId));
    }
    if (additionalAttributes != null)
    {
        attributes = attributes.Concat(additionalAttributes).ToDictionary(x => x.Key, x => x.Value);
    }



#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <div");

WriteLiteralTo(__razor_helper_writer, " class=\"form-group\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 164 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
WriteTo(__razor_helper_writer, Html.LabelFor(expression, Html.Resource(label)));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n\r\n");


#line 166 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
        

#line default
#line hidden

#line 166 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
         switch (inputType)
        {
            case "text":
                

#line default
#line hidden

#line 169 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
WriteTo(__razor_helper_writer, Html.TextBoxFor(expression, attributes));


#line default
#line hidden

#line 169 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                        ;
                break;

            case "textarea":
                

#line default
#line hidden

#line 173 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
WriteTo(__razor_helper_writer, Html.TextAreaFor(expression, attributes));


#line default
#line hidden

#line 173 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                         ;
                break;

            case "password":
                

#line default
#line hidden

#line 177 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
WriteTo(__razor_helper_writer, Html.PasswordFor(expression, attributes));


#line default
#line hidden

#line 177 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                         ;
                break;

            default:
                break;
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 184 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
        

#line default
#line hidden

#line 184 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
         if (hasValidationMessage)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <div");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\'", 7688), Tuple.Create("\'", 7715)

#line 186 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
, Tuple.Create(Tuple.Create("", 7693), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(descId)

#line default
#line hidden
, 7693), false)
);

WriteLiteralTo(__razor_helper_writer, " class=\"text-danger\"");

WriteLiteralTo(__razor_helper_writer, " role=\"alert\"");

WriteLiteralTo(__razor_helper_writer, " aria-live=\"assertive\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                <span");

WriteLiteralTo(__razor_helper_writer, " class=\"form-text\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 187 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
          WriteTo(__razor_helper_writer, Html.ValidationMessageFor(expression));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\r\n            </div>\r\n");


#line 189 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </div>\r\n");


#line 191 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"


#line default
#line hidden
});

#line 191 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
}
#line default
#line hidden

        public Registration_RegistrationForm()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 19 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 20 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/jquery.validate/1.8.1/jquery.validate.js", "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 21 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/mvc/4.0/jquery.validate.unobtrusive.min.js", "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 23 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
  
    var hasExternalProviders = Model.ExternalProviders != null && Model.ExternalProviders.Count() > 0;
    var rowClass = hasExternalProviders ? "row" : "";
    var colClass = hasExternalProviders ? "col-lg-6" : "";

    if (!Model.Profile.ContainsKey("FirstName"))
    {
        Model.Profile["FirstName"] = "";
    }

    if (!Model.Profile.ContainsKey("LastName"))
    {
        Model.Profile["LastName"] = "";
    }

    HtmlHelper.ClientValidationEnabled = true;
    HtmlHelper.UnobtrusiveJavaScriptEnabled = true;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 1574), Tuple.Create("\"", 1597)
            
            #line 42 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
, Tuple.Create(Tuple.Create("", 1582), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 1582), false)
);

WriteLiteral(">\r\n");

            
            #line 43 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    
            
            #line default
            #line hidden
            
            #line 43 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
     if ((Request.QueryStringGet("ShowActivationMsg") == "true") ||
     (ViewBag.ShowActivationMsg is bool && ViewBag.ShowActivationMsg))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">\r\n            <h3>");

            
            #line 47 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
           Write(Html.Resource("VisitYourEmail"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n            <p>");

            
            #line 48 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
          Write(string.Format(Html.Resource("ActivationLinkHasBeenSent"), Model.Email));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        </div>\r\n");

            
            #line 50 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-sf-role=\"sendAgainLink\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 52 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
       Write(Html.Resource("SendAgain"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 53 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                             Write(Html.Resource("SendActivationLinkAgain"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </a>\r\n");

            
            #line 55 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" data-sf-role=\"confirmationResendInfo\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral(">\r\n            <p");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">");

            
            #line 57 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                             Write(string.Format(Html.Resource("ActivationLinkHasBeenSentAgain"), Model.Email));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        </div>\r\n");

            
            #line 59 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-resend-confirmation-endpoint-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2501), Tuple.Create("\"", 2575)
            
            #line 60 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
       , Tuple.Create(Tuple.Create("", 2509), Tuple.Create<System.Object, System.Int32>(Url.Action("ResendConfirmationEmail", new { email = Model.Email})
            
            #line default
            #line hidden
, 2509), false)
);

WriteLiteral(" />\r\n");

            
            #line 61 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"

        
            
            #line default
            #line hidden
            
            #line 62 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
   Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Registration/registration-form.js"), "bottom", throwException: false));

            
            #line default
            #line hidden
            
            #line 62 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                                                                                         
    }
    else if ((Request.QueryStringGet("ShowSuccessfulRegistrationMsg") == "true") ||
             (ViewBag.ShowSuccessfulRegistrationMsg is bool && ViewBag.ShowSuccessfulRegistrationMsg))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">\r\n            <h3>");

            
            #line 68 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
           Write(Html.Resource("ThankYou"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n            <p>");

            
            #line 69 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
          Write(Html.Resource("DefaultSuccessfulRegistrationMessage"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        </div>\r\n");

            
            #line 71 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    }
    else
    {
        using (Html.BeginFormSitefinity(true))
        {
            
            
            #line default
            #line hidden
            
            #line 76 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
       Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 76 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                         ;


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteAttribute("class", Tuple.Create(" class=\"", 3244), Tuple.Create("\"", 3265)
            
            #line 78 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
, Tuple.Create(Tuple.Create("", 3252), Tuple.Create<System.Object, System.Int32>(rowClass
            
            #line default
            #line hidden
, 3252), false)
, Tuple.Create(Tuple.Create(" ", 3261), Tuple.Create("m-0", 3262), true)
);

WriteLiteral(">\r\n                <div");

WriteAttribute("class", Tuple.Create(" class=\"", 3289), Tuple.Create("\"", 3306)
            
            #line 79 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
, Tuple.Create(Tuple.Create("", 3297), Tuple.Create<System.Object, System.Int32>(colClass
            
            #line default
            #line hidden
, 3297), false)
);

WriteLiteral(">\r\n                    <h3");

WriteLiteral(" class=\"mb-4\"");

WriteLiteral(">");

            
            #line 80 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                Write(Html.Resource("Registration"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n\r\n");

            
            #line 82 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 82 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                     if (!string.IsNullOrEmpty(ViewBag.Error))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">");

            
            #line 84 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                                                      Write(ViewBag.Error);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 85 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 87 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
               Write(Html.HiddenFor(m => m.RequiresQuestionAndAnswer));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("                    ");

            
            #line 89 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
               Write(FormGroupPanel("FirstName", m => m.Profile["FirstName"], "RegistrationFirstName", "text", null,  HtmlHelper.ClientValidationEnabled ? RegistrationHelper.GetProfileValidationAttributes("FirstName") : null));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("                    ");

            
            #line 91 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
               Write(FormGroupPanel("LastName", m => m.Profile["LastName"], "RegistrationLastName", "text", null, HtmlHelper.ClientValidationEnabled ? RegistrationHelper.GetProfileValidationAttributes("LastName") : null));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("                    ");

            
            #line 93 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
               Write(FormGroupPanel("Email", m => m.Email, "RegistrationEmail", "text", null, new Dictionary<string, object>() { { "type", "email" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("                    ");

            
            #line 95 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
               Write(FormGroupPanel("Password", m => m.Password, "RegistrationPassword", "password"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("                    ");

            
            #line 97 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
               Write(FormGroupPanel("ReTypePassword", m => m.ReTypePassword, "RegistrationReTypePassword", "password"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 99 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 99 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                     if (Model.RequiresQuestionAndAnswer)
                    {
                        
            
            #line default
            #line hidden
            
            #line 101 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                   Write(FormGroupPanel("Question", m => m.Question, "RegistrationQuestion"));

            
            #line default
            #line hidden
            
            #line 101 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                                                            

                        
            
            #line default
            #line hidden
            
            #line 103 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                   Write(FormGroupPanel("Answer", m => m.Answer, "RegistrationAnswer"));

            
            #line default
            #line hidden
            
            #line 103 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                                                      
                    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 106 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 106 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                     if (SystemManager.IsDesignMode && !SystemManager.IsPreviewMode)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" disabled>");

            
            #line 108 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                                          Write(Html.Resource("Register"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n");

            
            #line 109 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                    }
                    else
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" ");

            
            #line 112 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                                  Write(SystemManager.IsDesignMode ? "disabled" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 112 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                                                                                 Write(Html.Resource("Register"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n");

            
            #line 113 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"mt-3\"");

WriteLiteral(">\r\n                        <div>Already registered?</div>\r\n                      " +
"  <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5408), Tuple.Create("\"", 5434)
            
            #line 117 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
, Tuple.Create(Tuple.Create("", 5415), Tuple.Create<System.Object, System.Int32>(Model.LoginPageUrl
            
            #line default
            #line hidden
, 5415), false)
);

WriteLiteral(">");

            
            #line 117 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                 Write(Html.Resource("BackToLogin"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                    </div>\r\n                </div>\r\n\r\n");

            
            #line 121 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                
            
            #line default
            #line hidden
            
            #line 121 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                 if (Model.ExternalProviders != null && Model.ExternalProviders.Count() > 0)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"col-lg-6\"");

WriteLiteral(">\r\n                        <h3");

WriteLiteral(" class=\"mb-3\"");

WriteLiteral(">");

            
            #line 124 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                    Write(Html.Resource("ConnectWith"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n\r\n");

            
            #line 126 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 126 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                         foreach (var provider in Model.ExternalProviders)
                        {
                            var classToBeAdd = "btn btn-lg btn-block " + @provider.Value;
                            
            
            #line default
            #line hidden
WriteLiteral("<div");

WriteLiteral(" class=\"mb-1\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 130 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                           Write(Html.ActionLink(provider.Key, "LoginExternalProvider", new { model = provider.Key }, new { @class = classToBeAdd }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n");

            
            #line 132 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </div>\r\n");

            
            #line 134 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n");

            
            #line 136 "..\..MVC\Views\Registration\Registration.RegistrationForm.cshtml"
        }
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
