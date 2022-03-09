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

namespace RealSiteFinityFirst.ResourcePackages.Bootstrap4.MVC.Views.CheckboxesField
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
    
    #line 4 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
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
            
            #line 7 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 8 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
  
    var fieldName = Model.MetaField.FieldName;
    var requiredAttributes = MvcHtmlString.Create(Model.ValidationAttributes);
    var isRequired = Model.IsRequired ? "true" : "false";
    var hasDescription = !string.IsNullOrEmpty(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n<fieldset");

WriteAttribute("class", Tuple.Create(" class=\"", 611), Tuple.Create("\"", 645)
            
            #line 14 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 619), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 619), false)
, Tuple.Create(Tuple.Create(" ", 634), Tuple.Create("form-group", 635), true)
);

WriteLiteral(" data-sf-role=\"checkboxes-field-container\"");

WriteLiteral(">\r\n    <legend");

WriteLiteral(" class=\"h6\"");

WriteAttribute("id", Tuple.Create(" id=\'", 713), Tuple.Create("\'", 754)
            
            #line 15 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 718), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("CheckboxGroupLabel")
            
            #line default
            #line hidden
, 718), false)
);

WriteLiteral(">");

            
            #line 15 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                            Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral("</legend>\r\n\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteAttribute("value", Tuple.Create(" value=\'", 849), Tuple.Create("\'", 905)
, Tuple.Create(Tuple.Create("", 857), Tuple.Create("{", 857), true)
, Tuple.Create(Tuple.Create(" ", 858), Tuple.Create("\"required\":", 859), true)
, Tuple.Create(Tuple.Create(" ", 870), Tuple.Create("\"", 871), true)
            
            #line 17 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
  , Tuple.Create(Tuple.Create("", 872), Tuple.Create<System.Object, System.Int32>(Model.RequiredViolationMessage
            
            #line default
            #line hidden
, 872), false)
, Tuple.Create(Tuple.Create("", 903), Tuple.Create("\"}", 903), true)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"required-validator\"");

WriteAttribute("value", Tuple.Create(" value=\'", 969), Tuple.Create("\'", 1005)
            
            #line 18 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 977), Tuple.Create<System.Object, System.Int32>(Model.IsRequired.ToString()
            
            #line default
            #line hidden
, 977), false)
);

WriteLiteral(" />\r\n\r\n    <ul");

WriteLiteral(" class=\"list-unstyled\"");

WriteAttribute("aria-labelledby", Tuple.Create(" aria-labelledby=\'", 1042), Tuple.Create("\'", 1096)
            
            #line 20 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1060), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("CheckboxGroupLabel")
            
            #line default
            #line hidden
, 1060), false)
);

WriteLiteral(" ");

            
            #line 20 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                                       if (hasDescription) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" aria-describedby=\'");

            
            #line 20 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                                                                                 Write(Html.UniqueId("CheckboxGroupInfo"));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 20 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                                                                                                                     Write(Html.UniqueId("CheckboxGroupErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\' ");

WriteLiteral("  ");

            
            #line 20 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                                                                                                                                                                                } else {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" aria-describedby=\'");

            
            #line 20 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                                                                                                                                                                                                             Write(Html.UniqueId("CheckboxGroupErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\' ");

WriteLiteral("  ");

            
            #line 20 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                                                                                                                                                                                                                                                                        } 
            
            #line default
            #line hidden
WriteLiteral(">\r\n");

            
            #line 21 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
        
            
            #line default
            #line hidden
            
            #line 21 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
         foreach (var choice in Model.Choices)
        {
            string value = !string.IsNullOrEmpty(Model.Value as string) ? Model.Value as string : string.Empty;
            string selectedValue = !string.IsNullOrEmpty(value) ? value : Model.MetaField.DefaultValue;
            var selctedAttributes = !string.IsNullOrEmpty(selectedValue) && selectedValue.Contains(choice as string) ? "checked" : string.Empty;

            
            #line default
            #line hidden
WriteLiteral("            <li>\r\n                <label>\r\n                    <input");

WriteLiteral(" type=\"checkbox\"");

WriteAttribute("name", Tuple.Create(" name=\"", 1839), Tuple.Create("\"", 1856)
            
            #line 28 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1846), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 1846), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 1857), Tuple.Create("\"", 1872)
            
            #line 28 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1865), Tuple.Create<System.Object, System.Int32>(choice
            
            #line default
            #line hidden
, 1865), false)
);

WriteLiteral(" data-sf-role=\"checkboxes-field-input\"");

WriteLiteral(" ");

            
            #line 28 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                                                              Write(selctedAttributes);

            
            #line default
            #line hidden
WriteLiteral(" role=\"checkbox\" aria-required=\"");

            
            #line 28 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                                                                                                                Write(isRequired);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n");

WriteLiteral("                    ");

            
            #line 29 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
               Write(choice);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </label>\r\n            </li>\r\n");

            
            #line 32 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 33 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
         if (Model.HasOtherChoice)
        {

            
            #line default
            #line hidden
WriteLiteral("            <li>\r\n                <label>\r\n                    <input");

WriteLiteral(" type=\"checkbox\"");

WriteAttribute("name", Tuple.Create(" name=\"", 2196), Tuple.Create("\"", 2213)
            
            #line 37 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2203), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 2203), false)
);

WriteLiteral(" data-sf-checkboxes-role=\"other-choice-checkbox\"");

WriteLiteral(" data-sf-role=\"checkboxes-field-input\"");

WriteLiteral(" role=\"checkbox\"");

WriteAttribute("aria-required", Tuple.Create(" aria-required=\"", 2316), Tuple.Create("\"", 2343)
            
            #line 37 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                                                  , Tuple.Create(Tuple.Create("", 2332), Tuple.Create<System.Object, System.Int32>(isRequired
            
            #line default
            #line hidden
, 2332), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("                    ");

            
            #line 38 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
               Write(Html.Resource("Other"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 39 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                     Write(Html.Resource("ThisChoiceWillExpandTextbox"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                </label>\r\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-checkboxes-role=\"other-choice-text\"");

WriteAttribute("aria-required", Tuple.Create(" aria-required=\"", 2596), Tuple.Create("\"", 2623)
            
            #line 41 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                , Tuple.Create(Tuple.Create("", 2612), Tuple.Create<System.Object, System.Int32>(isRequired
            
            #line default
            #line hidden
, 2612), false)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 2624), Tuple.Create("\"", 2666)
            
            #line 41 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                         , Tuple.Create(Tuple.Create("", 2637), Tuple.Create<System.Object, System.Int32>(Html.Resource("OtherOption")
            
            #line default
            #line hidden
, 2637), false)
);

WriteLiteral(" />\r\n            </li>\r\n");

            
            #line 43 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n");

            
            #line 45 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 45 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
     if (hasDescription)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteLiteral(" class=\"text-muted\"");

WriteAttribute("id", Tuple.Create(" id=\'", 2775), Tuple.Create("\'", 2815)
            
            #line 47 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2780), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("CheckboxGroupInfo")
            
            #line default
            #line hidden
, 2780), false)
);

WriteLiteral(">");

            
            #line 47 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                  Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 48 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteAttribute("id", Tuple.Create(" id=\'", 2866), Tuple.Create("\'", 2914)
            
            #line 49 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2871), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("CheckboxGroupErrorMessage")
            
            #line default
            #line hidden
, 2871), false)
);

WriteLiteral(" data-sf-role=\"error-message\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral("></div>\r\n</fieldset>\r\n\r\n");

            
            #line 52 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Form/form.all.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
