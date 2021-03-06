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

namespace RealSiteFinityFirst.ResourcePackages.Custom.MVC.Views.MultipleChoiceField
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
    
    #line 9 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 10 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 11 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 8 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/MultipleChoiceField/Write.Default.cshtml")]
    public partial class Write_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.MultipleChoiceField.MultipleChoiceFieldViewModel>
    {
        public Write_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 12 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 13 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
  
    var fieldName = string.IsNullOrEmpty(Model.MetaField.FieldName) ? "multiple-choice-field-name" : Model.MetaField.FieldName;
    var requiredAttributes = MvcHtmlString.Create(Model.ValidationAttributes);
    var isRequired = Model.IsRequired ? "true" : "false";
    var hasDescription = !string.IsNullOrEmpty(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n<fieldset");

WriteAttribute("class", Tuple.Create(" class=\"", 960), Tuple.Create("\"", 994)
            
            #line 19 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 968), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 968), false)
, Tuple.Create(Tuple.Create(" ", 983), Tuple.Create("form-group", 984), true)
);

WriteLiteral(" data-sf-role=\"multiple-choice-field-container\"");

WriteLiteral(">\r\n    <legend");

WriteLiteral(" class=\"h6\"");

WriteAttribute("id", Tuple.Create(" id=\'", 1067), Tuple.Create("\'", 1105)
            
            #line 20 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1072), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RadioGroupLabel")
            
            #line default
            #line hidden
, 1072), false)
);

WriteLiteral(">");

            
            #line 20 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                         Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral("</legend>\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1198), Tuple.Create("\'", 1302)
, Tuple.Create(Tuple.Create("", 1206), Tuple.Create("{", 1206), true)
, Tuple.Create(Tuple.Create(" ", 1207), Tuple.Create("\"required\":", 1208), true)
, Tuple.Create(Tuple.Create(" ", 1219), Tuple.Create("\"", 1220), true)
            
            #line 21 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
 , Tuple.Create(Tuple.Create("", 1221), Tuple.Create<System.Object, System.Int32>(Model.RequiredViolationMessage
            
            #line default
            #line hidden
, 1221), false)
, Tuple.Create(Tuple.Create("", 1252), Tuple.Create("\",", 1252), true)
, Tuple.Create(Tuple.Create(" ", 1254), Tuple.Create("\"maxLength\":\"", 1255), true)
            
            #line 21 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                , Tuple.Create(Tuple.Create("", 1268), Tuple.Create<System.Object, System.Int32>(Model.MaxLengthViolationMessage
            
            #line default
            #line hidden
, 1268), false)
, Tuple.Create(Tuple.Create("", 1300), Tuple.Create("\"}", 1300), true)
);

WriteLiteral(" />\r\n    <ul");

WriteLiteral(" class=\"list-unstyled\"");

WriteAttribute("aria-labelledby", Tuple.Create(" aria-labelledby=\'", 1337), Tuple.Create("\'", 1388)
            
            #line 22 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1355), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RadioGroupLabel")
            
            #line default
            #line hidden
, 1355), false)
);

WriteLiteral(" ");

            
            #line 22 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                                    if (hasDescription) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" aria-describedby=\'");

            
            #line 22 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                                                                              Write(Html.UniqueId("RadioGroupInfo"));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 22 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                                                                                                               Write(Html.UniqueId("RadioGroupErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\' ");

WriteLiteral("  ");

            
            #line 22 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                                                                                                                                                                       } else {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" aria-describedby=\'");

            
            #line 22 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                                                                                                                                                                                                    Write(Html.UniqueId("RadioGroupErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\' ");

WriteLiteral("  ");

            
            #line 22 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                                                                                                                                                                                                                                                            } 
            
            #line default
            #line hidden
WriteLiteral(">\r\n");

            
            #line 23 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
        
            
            #line default
            #line hidden
            
            #line 23 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
         foreach (var choice in Model.Choices)
        {
            string value = !string.IsNullOrEmpty(Model.Value as string) ? Model.Value as string : string.Empty;
            bool isSelected = (!string.IsNullOrEmpty(value) && choice == value) ||
                                (string.IsNullOrEmpty(value) && !Model.IsRequired && choice == Model.MetaField.DefaultValue as string);

            var selctedAttributes = isSelected ? "checked" : string.Empty;

            
            #line default
            #line hidden
WriteLiteral("            <li>\r\n                <label>\r\n");

            
            #line 32 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 32 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                       
                        var val = choice;
                        if (val.Length > 255)
                        {
                            val = val.Substring(0, 255);
                        }
                    
            
            #line default
            #line hidden
WriteLiteral("\r\n                    <input");

WriteLiteral(" type=\"radio\"");

WriteAttribute("name", Tuple.Create(" name=\"", 2417), Tuple.Create("\"", 2434)
            
            #line 39 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2424), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 2424), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 2435), Tuple.Create("\"", 2447)
            
            #line 39 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2443), Tuple.Create<System.Object, System.Int32>(val
            
            #line default
            #line hidden
, 2443), false)
);

WriteLiteral(" data-sf-role=\"multiple-choice-field-input\"");

WriteLiteral(" ");

            
            #line 39 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                                                             Write(selctedAttributes);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 39 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                                                                                Write(requiredAttributes);

            
            #line default
            #line hidden
WriteLiteral(" role=\"radio\" aria-required=\"");

            
            #line 39 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                                                                                                                                Write(isRequired);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n");

WriteLiteral("                    ");

            
            #line 40 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
               Write(choice);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </label>\r\n            </li>\r\n");

            
            #line 43 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 44 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
         if (Model.HasOtherChoice)
        {

            
            #line default
            #line hidden
WriteLiteral("            <li>\r\n                <label>\r\n                    <input");

WriteLiteral(" type=\"radio\"");

WriteAttribute("name", Tuple.Create(" name=\"", 2790), Tuple.Create("\"", 2807)
            
            #line 48 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2797), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 2797), false)
);

WriteLiteral(" data-sf-multiple-choice-role=\"other-choice-radio\"");

WriteLiteral(" data-sf-role=\"multiple-choice-field-input\"");

WriteLiteral(" role=\"radio\"");

WriteAttribute("aria-required", Tuple.Create(" aria-required=\"", 2914), Tuple.Create("\"", 2941)
            
            #line 48 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                                                   , Tuple.Create(Tuple.Create("", 2930), Tuple.Create<System.Object, System.Int32>(isRequired
            
            #line default
            #line hidden
, 2930), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("                    ");

            
            #line 49 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
               Write(Html.Resource("Other"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 50 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                     Write(Html.Resource("ThisChoiceWillExpandTextbox"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                </label>\r\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-multiple-choice-role=\"other-choice-text\"");

WriteAttribute("aria-required", Tuple.Create(" aria-required=\"", 3199), Tuple.Create("\"", 3226)
            
            #line 52 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                     , Tuple.Create(Tuple.Create("", 3215), Tuple.Create<System.Object, System.Int32>(isRequired
            
            #line default
            #line hidden
, 3215), false)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 3227), Tuple.Create("\"", 3269)
            
            #line 52 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                              , Tuple.Create(Tuple.Create("", 3240), Tuple.Create<System.Object, System.Int32>(Html.Resource("OtherOption")
            
            #line default
            #line hidden
, 3240), false)
);

WriteLiteral(" />\r\n            </li>\r\n");

            
            #line 54 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"

        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n");

            
            #line 57 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 57 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
     if (hasDescription)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteAttribute("id", Tuple.Create(" id=\'", 3361), Tuple.Create("\'", 3398)
            
            #line 59 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 3366), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RadioGroupInfo")
            
            #line default
            #line hidden
, 3366), false)
);

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 59 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                               Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 60 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteAttribute("id", Tuple.Create(" id=\'", 3468), Tuple.Create("\'", 3513)
            
            #line 61 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 3473), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RadioGroupErrorMessage")
            
            #line default
            #line hidden
, 3473), false)
);

WriteLiteral(" data-sf-role=\"error-message\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral("></div>\r\n</fieldset>\r\n\r\n");

            
            #line 64 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Form/form.all.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
