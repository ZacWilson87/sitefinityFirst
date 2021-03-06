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

namespace RealSiteFinityFirst.ResourcePackages.Custom.MVC.Views.ParagraphTextField
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
    
    #line 9 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 10 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 11 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 8 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Custom/MVC/Views/ParagraphTextField/Write.Default.cshtml")]
    public partial class Write_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.ParagraphTextField.ParagraphTextFieldViewModel>
    {
        public Write_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 12 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 13 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
  
    var hasDescription = !string.IsNullOrEmpty(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 685), Tuple.Create("\"", 719)
, Tuple.Create(Tuple.Create("", 693), Tuple.Create("form-group", 693), true)
            
            #line 16 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create(" ", 703), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 704), false)
);

WriteLiteral(" data-sf-role=\"paragraph-text-field-container\"");

WriteLiteral(">\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteAttribute("value", Tuple.Create(" value=\'", 827), Tuple.Create("\'", 930)
, Tuple.Create(Tuple.Create("", 835), Tuple.Create("{\"maxLength\":\"", 835), true)
            
            #line 17 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
 , Tuple.Create(Tuple.Create("", 849), Tuple.Create<System.Object, System.Int32>(Model.MaxLengthViolationMessage
            
            #line default
            #line hidden
, 849), false)
, Tuple.Create(Tuple.Create("", 881), Tuple.Create("\",", 881), true)
, Tuple.Create(Tuple.Create(" ", 883), Tuple.Create("\"required\":", 884), true)
, Tuple.Create(Tuple.Create(" ", 895), Tuple.Create("\"", 896), true)
            
            #line 17 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
                                                 , Tuple.Create(Tuple.Create("", 897), Tuple.Create<System.Object, System.Int32>(Model.RequiredViolationMessage
            
            #line default
            #line hidden
, 897), false)
, Tuple.Create(Tuple.Create("", 928), Tuple.Create("\"}", 928), true)
);

WriteLiteral(" />\r\n    <label");

WriteLiteral(" class=\"h6\"");

WriteAttribute("for", Tuple.Create(" for=\'", 957), Tuple.Create("\'", 989)
            
            #line 18 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 963), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Textarea")
            
            #line default
            #line hidden
, 963), false)
);

WriteLiteral(">");

            
            #line 18 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
                                                  Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral(" </label>\r\n    <textarea");

WriteAttribute("id", Tuple.Create(" id=\'", 1037), Tuple.Create("\'", 1068)
            
            #line 19 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1042), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Textarea")
            
            #line default
            #line hidden
, 1042), false)
);

WriteLiteral("\r\n              class=\"form-control\"");

WriteLiteral("\r\n              rows=\"4\"");

WriteLiteral("\r\n              data-sf-role=\"paragraph-text-field-textarea\"");

WriteAttribute("name", Tuple.Create("\r\n              name=\"", 1189), Tuple.Create("\"", 1237)
            
            #line 23 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1211), Tuple.Create<System.Object, System.Int32>(Model.MetaField.FieldName
            
            #line default
            #line hidden
, 1211), false)
);

WriteAttribute("placeholder", Tuple.Create("\r\n              placeholder=\"", 1238), Tuple.Create("\"", 1289)
            
            #line 24 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1267), Tuple.Create<System.Object, System.Int32>(Model.PlaceholderText
            
            #line default
            #line hidden
, 1267), false)
);

WriteLiteral("\r\n              ");

            
            #line 25 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
         Write(MvcHtmlString.Create(Model.ValidationAttributes));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 26 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
              
            
            #line default
            #line hidden
            
            #line 26 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
                if (hasDescription) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" aria-describedby=\'");

            
            #line 26 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
                                                          Write(Html.UniqueId("ParagraphInfo"));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 26 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
                                                                                          Write(Html.UniqueId("ParagraphErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\' ");

WriteLiteral("  ");

            
            #line 26 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
                                                                                                                                                 } else {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" aria-describedby=\'");

            
            #line 26 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
                                                                                                                                                                              Write(Html.UniqueId("ParagraphErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\' ");

WriteLiteral("  ");

            
            #line 26 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
                                                                                                                                                                                                                                     } 
            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 26 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
                                                                                                                                                                                                                                    Write(Model.Value);

            
            #line default
            #line hidden
WriteLiteral("</textarea>\r\n\r\n");

            
            #line 28 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 28 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
     if (hasDescription)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteLiteral(" class=\"text-muted\"");

WriteAttribute("id", Tuple.Create(" id=\'", 1679), Tuple.Create("\'", 1715)
            
            #line 30 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1684), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("ParagraphInfo")
            
            #line default
            #line hidden
, 1684), false)
);

WriteLiteral(">");

            
            #line 30 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
                                                              Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 31 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteAttribute("id", Tuple.Create(" id=\'", 1766), Tuple.Create("\'", 1810)
            
            #line 32 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1771), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("ParagraphErrorMessage")
            
            #line default
            #line hidden
, 1771), false)
);

WriteLiteral(" data-sf-role=\"error-message\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral("></div>\r\n</div>\r\n\r\n");

            
            #line 35 "..\..\ResourcePackages\Custom\MVC\Views\ParagraphTextField\Write.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Form/form.all.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
