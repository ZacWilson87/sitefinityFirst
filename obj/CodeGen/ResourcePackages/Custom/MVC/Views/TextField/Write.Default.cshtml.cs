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

namespace RealSiteFinityFirst.ResourcePackages.Custom.MVC.Views.TextField
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
    
    #line 9 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 12 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.TextField;
    
    #line default
    #line hidden
    
    #line 10 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 11 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 8 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Custom/MVC/Views/TextField/Write.Default.cshtml")]
    public partial class Write_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.TextField.TextFieldViewModel>
    {
        public Write_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 14 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n<!-- InputCssClass class variable -->\r\n\r\n");

            
            #line 17 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
   var inputCssClass = "";
                HashSet<TextType> availableOptions = new HashSet<TextType>() { TextType.Text, TextType.Password, TextType.Date, TextType.DateTimeLocal, TextType.Month, TextType.Time,
    TextType.Week, TextType.Number, TextType.Email, TextType.Url, TextType.Tel, TextType.Color };

                if (availableOptions.Contains(Model.InputType))
                {
                    inputCssClass = "form-control";
                }

                var isRequired = Model.ValidatorDefinition.Required.HasValue && Model.ValidatorDefinition.Required.Value ? "true" : "false";
                var hasDescription = !string.IsNullOrEmpty(Model.MetaField.Description); 
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 1403), Tuple.Create("\"", 1437)
            
            #line 29 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1411), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 1411), false)
, Tuple.Create(Tuple.Create(" ", 1426), Tuple.Create("form-group", 1427), true)
);

WriteLiteral(" data-sf-role=\"text-field-container\"");

WriteLiteral(">\r\n    <input");

WriteLiteral(" data-sf-role=\"violation-restrictions\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1539), Tuple.Create("\'", 1652)
, Tuple.Create(Tuple.Create("", 1547), Tuple.Create("{\"maxLength\":\"", 1547), true)
            
            #line 30 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
    , Tuple.Create(Tuple.Create("", 1561), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.MaxLength
            
            #line default
            #line hidden
, 1561), false)
, Tuple.Create(Tuple.Create("", 1597), Tuple.Create("\",", 1597), true)
, Tuple.Create(Tuple.Create(" ", 1599), Tuple.Create("\"minLength\":", 1600), true)
, Tuple.Create(Tuple.Create(" ", 1612), Tuple.Create("\"", 1613), true)
            
            #line 30 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
                                                         , Tuple.Create(Tuple.Create("", 1614), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.MinLength
            
            #line default
            #line hidden
, 1614), false)
, Tuple.Create(Tuple.Create("", 1650), Tuple.Create("\"}", 1650), true)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1716), Tuple.Create("\'", 1996)
, Tuple.Create(Tuple.Create("", 1724), Tuple.Create("{\"maxLength\":\"", 1724), true)
            
            #line 31 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1738), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.MaxLengthViolationMessage
            
            #line default
            #line hidden
, 1738), false)
, Tuple.Create(Tuple.Create("", 1790), Tuple.Create("\",", 1790), true)
, Tuple.Create(Tuple.Create(" ", 1792), Tuple.Create("\"required\":", 1793), true)
, Tuple.Create(Tuple.Create(" ", 1804), Tuple.Create("\"", 1805), true)
            
            #line 31 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
                                                                    , Tuple.Create(Tuple.Create("", 1806), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.RequiredViolationMessage
            
            #line default
            #line hidden
, 1806), false)
, Tuple.Create(Tuple.Create("", 1857), Tuple.Create("\",", 1857), true)
, Tuple.Create(Tuple.Create(" ", 1859), Tuple.Create("\"invalid\":", 1860), true)
, Tuple.Create(Tuple.Create(" ", 1870), Tuple.Create("\"", 1871), true)
            
            #line 31 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
                                                                                                                                      , Tuple.Create(Tuple.Create("", 1872), Tuple.Create<System.Object, System.Int32>(Html.Resource("InvalidEntryMessage")
            
            #line default
            #line hidden
, 1872), false)
, Tuple.Create(Tuple.Create("", 1909), Tuple.Create("\",", 1909), true)
, Tuple.Create(Tuple.Create(" ", 1911), Tuple.Create("\"regularExpression\":", 1912), true)
, Tuple.Create(Tuple.Create(" ", 1932), Tuple.Create("\"", 1933), true)
            
            #line 31 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 1934), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.RegularExpressionViolationMessage
            
            #line default
            #line hidden
, 1934), false)
, Tuple.Create(Tuple.Create("", 1994), Tuple.Create("\"}", 1994), true)
);

WriteLiteral(" />\r\n\r\n    <label");

WriteLiteral(" class=\"h6\"");

WriteAttribute("for", Tuple.Create(" for=\'", 2025), Tuple.Create("\'", 2056)
            
            #line 33 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2031), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Textbox")
            
            #line default
            #line hidden
, 2031), false)
);

WriteLiteral(">");

            
            #line 33 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
                                                 Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n    <input");

WriteAttribute("id", Tuple.Create(" id=\'", 2100), Tuple.Create("\'", 2130)
            
            #line 34 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2105), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Textbox")
            
            #line default
            #line hidden
, 2105), false)
);

WriteAttribute("type", Tuple.Create("\r\n           type=\"", 2131), Tuple.Create("\"", 2184)
            
            #line 35 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2150), Tuple.Create<System.Object, System.Int32>(Model.InputType.ToHtmlInputType()
            
            #line default
            #line hidden
, 2150), false)
);

WriteAttribute("class", Tuple.Create("\r\n           class=\"", 2185), Tuple.Create("\"", 2219)
            
            #line 36 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2205), Tuple.Create<System.Object, System.Int32>(inputCssClass
            
            #line default
            #line hidden
, 2205), false)
);

WriteAttribute("name", Tuple.Create("\r\n           name=\"", 2220), Tuple.Create("\"", 2265)
            
            #line 37 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2239), Tuple.Create<System.Object, System.Int32>(Model.MetaField.FieldName
            
            #line default
            #line hidden
, 2239), false)
);

WriteAttribute("placeholder", Tuple.Create("\r\n           placeholder=\"", 2266), Tuple.Create("\"", 2314)
            
            #line 38 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2292), Tuple.Create<System.Object, System.Int32>(Model.PlaceholderText
            
            #line default
            #line hidden
, 2292), false)
);

WriteAttribute("value", Tuple.Create("\r\n           value=\"", 2315), Tuple.Create("\"", 2347)
            
            #line 39 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2335), Tuple.Create<System.Object, System.Int32>(Model.Value
            
            #line default
            #line hidden
, 2335), false)
);

WriteAttribute("aria-required", Tuple.Create("\r\n           aria-required=\"", 2348), Tuple.Create("\"", 2387)
            
            #line 40 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2376), Tuple.Create<System.Object, System.Int32>(isRequired
            
            #line default
            #line hidden
, 2376), false)
);

WriteLiteral("\r\n           data-sf-role=\"text-field-input\"");

WriteLiteral("\r\n           ");

            
            #line 42 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
      Write(Html.Raw(Model.ValidationAttributes));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 43 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
           
            
            #line default
            #line hidden
            
            #line 43 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
             if (hasDescription) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" aria-describedby=\'");

            
            #line 43 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
                                                       Write(Html.UniqueId("TextboxInfo"));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 43 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
                                                                                     Write(Html.UniqueId("TextboxErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\' ");

WriteLiteral("  ");

            
            #line 43 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
                                                                                                                                          } else {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" aria-describedby=\'");

            
            #line 43 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
                                                                                                                                                                       Write(Html.UniqueId("TextboxErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\' ");

WriteLiteral("  ");

            
            #line 43 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
                                                                                                                                                                                                                            } 
            
            #line default
            #line hidden
WriteLiteral(" />\r\n");

            
            #line 44 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 44 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
     if (hasDescription)
    {

            
            #line default
            #line hidden
WriteLiteral("<p");

WriteAttribute("id", Tuple.Create(" id=\'", 2747), Tuple.Create("\'", 2781)
            
            #line 46 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2752), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("TextboxInfo")
            
            #line default
            #line hidden
, 2752), false)
);

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 46 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
                                                    Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>");

            
            #line 46 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
                                                                                         }

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteAttribute("id", Tuple.Create(" id=\'", 2847), Tuple.Create("\'", 2889)
            
            #line 48 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2852), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("TextboxErrorMessage")
            
            #line default
            #line hidden
, 2852), false)
);

WriteLiteral(" data-sf-role=\"error-message\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral("></div>\r\n</div>\r\n\r\n");

            
            #line 51 "..\..\ResourcePackages\Custom\MVC\Views\TextField\Write.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Form/form.all.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
