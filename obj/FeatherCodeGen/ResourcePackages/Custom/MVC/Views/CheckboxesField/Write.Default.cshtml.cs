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

namespace RealSiteFinityFirst.ResourcePackages.Custom.MVC.Views.CheckboxesField
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
    
    #line 9 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 10 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 11 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 8 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/CheckboxesField/Write.Default.cshtml")]
    public partial class Write_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.CheckboxesField.CheckboxesFieldViewModel>
    {
        public Write_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 12 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 13 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
  
    var fieldName = Model.MetaField.FieldName;
    var requiredAttributes = MvcHtmlString.Create(Model.ValidationAttributes);
    var isRequired = Model.IsRequired ? "true" : "false";
    var hasDescription = !string.IsNullOrEmpty(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n<fieldset");

WriteAttribute("class", Tuple.Create(" class=\"", 871), Tuple.Create("\"", 905)
            
            #line 19 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 879), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 879), false)
, Tuple.Create(Tuple.Create(" ", 894), Tuple.Create("form-group", 895), true)
);

WriteLiteral(" data-sf-role=\"checkboxes-field-container\"");

WriteLiteral(">\r\n    <legend");

WriteLiteral(" class=\"h6\"");

WriteAttribute("id", Tuple.Create(" id=\'", 973), Tuple.Create("\'", 1014)
            
            #line 20 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 978), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("CheckboxGroupLabel")
            
            #line default
            #line hidden
, 978), false)
);

WriteLiteral(">");

            
            #line 20 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                            Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral("</legend>\r\n\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1109), Tuple.Create("\'", 1165)
, Tuple.Create(Tuple.Create("", 1117), Tuple.Create("{", 1117), true)
, Tuple.Create(Tuple.Create(" ", 1118), Tuple.Create("\"required\":", 1119), true)
, Tuple.Create(Tuple.Create(" ", 1130), Tuple.Create("\"", 1131), true)
            
            #line 22 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
 , Tuple.Create(Tuple.Create("", 1132), Tuple.Create<System.Object, System.Int32>(Model.RequiredViolationMessage
            
            #line default
            #line hidden
, 1132), false)
, Tuple.Create(Tuple.Create("", 1163), Tuple.Create("\"}", 1163), true)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"required-validator\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1229), Tuple.Create("\'", 1265)
            
            #line 23 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1237), Tuple.Create<System.Object, System.Int32>(Model.IsRequired.ToString()
            
            #line default
            #line hidden
, 1237), false)
);

WriteLiteral(" />\r\n\r\n    <ul");

WriteLiteral(" class=\"list-unstyled\"");

WriteAttribute("aria-labelledby", Tuple.Create(" aria-labelledby=\'", 1302), Tuple.Create("\'", 1356)
            
            #line 25 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1320), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("CheckboxGroupLabel")
            
            #line default
            #line hidden
, 1320), false)
);

WriteLiteral(" ");

            
            #line 25 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                                       if (hasDescription) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" aria-describedby=\'");

            
            #line 25 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                                                                                 Write(Html.UniqueId("CheckboxGroupInfo"));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 25 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                                                                                                                     Write(Html.UniqueId("CheckboxGroupErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\' ");

WriteLiteral("  ");

            
            #line 25 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                                                                                                                                                                                } else {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" aria-describedby=\'");

            
            #line 25 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                                                                                                                                                                                                             Write(Html.UniqueId("CheckboxGroupErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\' ");

WriteLiteral("  ");

            
            #line 25 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                                                                                                                                                                                                                                                                        } 
            
            #line default
            #line hidden
WriteLiteral(">\r\n");

            
            #line 26 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
        
            
            #line default
            #line hidden
            
            #line 26 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
         foreach (var choice in Model.Choices)
        {
            string value = !string.IsNullOrEmpty(Model.Value as string) ? Model.Value as string : string.Empty;
            string selectedValue = !string.IsNullOrEmpty(value) ? value : Model.MetaField.DefaultValue;
            var selctedAttributes = !string.IsNullOrEmpty(selectedValue) && selectedValue.Contains(choice as string) ? "checked" : string.Empty;

            
            #line default
            #line hidden
WriteLiteral("            <li>\r\n                <label>\r\n                    <input");

WriteLiteral(" type=\"checkbox\"");

WriteAttribute("name", Tuple.Create(" name=\"", 2099), Tuple.Create("\"", 2116)
            
            #line 33 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2106), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 2106), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 2117), Tuple.Create("\"", 2132)
            
            #line 33 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2125), Tuple.Create<System.Object, System.Int32>(choice
            
            #line default
            #line hidden
, 2125), false)
);

WriteLiteral(" data-sf-role=\"checkboxes-field-input\"");

WriteLiteral(" ");

            
            #line 33 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                                                              Write(selctedAttributes);

            
            #line default
            #line hidden
WriteLiteral(" role=\"checkbox\" aria-required=\"");

            
            #line 33 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                                                                                                                Write(isRequired);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n");

WriteLiteral("                    ");

            
            #line 34 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
               Write(choice);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </label>\r\n            </li>\r\n");

            
            #line 37 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 38 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
         if (Model.HasOtherChoice)
        {

            
            #line default
            #line hidden
WriteLiteral("            <li>\r\n                <label>\r\n                    <input");

WriteLiteral(" type=\"checkbox\"");

WriteAttribute("name", Tuple.Create(" name=\"", 2456), Tuple.Create("\"", 2473)
            
            #line 42 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2463), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 2463), false)
);

WriteLiteral(" data-sf-checkboxes-role=\"other-choice-checkbox\"");

WriteLiteral(" data-sf-role=\"checkboxes-field-input\"");

WriteLiteral(" role=\"checkbox\"");

WriteAttribute("aria-required", Tuple.Create(" aria-required=\"", 2576), Tuple.Create("\"", 2603)
            
            #line 42 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                                                  , Tuple.Create(Tuple.Create("", 2592), Tuple.Create<System.Object, System.Int32>(isRequired
            
            #line default
            #line hidden
, 2592), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("                    ");

            
            #line 43 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
               Write(Html.Resource("Other"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 44 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                     Write(Html.Resource("ThisChoiceWillExpandTextbox"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                </label>\r\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-checkboxes-role=\"other-choice-text\"");

WriteAttribute("aria-required", Tuple.Create(" aria-required=\"", 2856), Tuple.Create("\"", 2883)
            
            #line 46 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                , Tuple.Create(Tuple.Create("", 2872), Tuple.Create<System.Object, System.Int32>(isRequired
            
            #line default
            #line hidden
, 2872), false)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 2884), Tuple.Create("\"", 2926)
            
            #line 46 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                         , Tuple.Create(Tuple.Create("", 2897), Tuple.Create<System.Object, System.Int32>(Html.Resource("OtherOption")
            
            #line default
            #line hidden
, 2897), false)
);

WriteLiteral(" />\r\n            </li>\r\n");

            
            #line 48 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n");

            
            #line 50 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 50 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
     if (hasDescription)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteLiteral(" class=\"text-muted\"");

WriteAttribute("id", Tuple.Create(" id=\'", 3035), Tuple.Create("\'", 3075)
            
            #line 52 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 3040), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("CheckboxGroupInfo")
            
            #line default
            #line hidden
, 3040), false)
);

WriteLiteral(">");

            
            #line 52 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                  Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 53 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteAttribute("id", Tuple.Create(" id=\'", 3126), Tuple.Create("\'", 3174)
            
            #line 54 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 3131), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("CheckboxGroupErrorMessage")
            
            #line default
            #line hidden
, 3131), false)
);

WriteLiteral(" data-sf-role=\"error-message\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral("></div>\r\n</fieldset>\r\n\r\n");

            
            #line 57 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Form/form.all.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591