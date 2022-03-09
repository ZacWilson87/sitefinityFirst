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

namespace RealSiteFinityFirst.ResourcePackages.Custom.MVC.Views.LanguageSelector
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
    
    #line 8 "..\..MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 10 "..\..MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 9 "..\..MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/LanguageSelector/LanguageSelector.DropDownMenu.cshtml")]
    public partial class LanguageSelector_DropDownMenu : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.LanguageSelector.LanguageSelectorViewModel>
    {
        public LanguageSelector_DropDownMenu()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 497), Tuple.Create("\"", 537)
            
            #line 12 "..\..MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
, Tuple.Create(Tuple.Create("", 505), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 505), false)
, Tuple.Create(Tuple.Create(" ", 520), Tuple.Create("sf-lang-selector", 521), true)
);

WriteLiteral(">\r\n    <label>\r\n");

WriteLiteral("        ");

            
            #line 14 "..\..MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
   Write(Html.Resource("Language"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 15 "..\..MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
        
            
            #line default
            #line hidden
            
            #line 15 "..\..MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
         if (SystemManager.IsDesignMode)
        {

            
            #line default
            #line hidden
WriteLiteral("            ");

WriteLiteral("<select>\r\n");

            
            #line 18 "..\..MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            ");

WriteLiteral("<select onChange=\"openLink(value)\">\r\n");

            
            #line 22 "..\..MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 24 "..\..MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
            
            
            #line default
            #line hidden
            
            #line 24 "..\..MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
             if (!Model.IncludeCurrentLanguage)
            {

            
            #line default
            #line hidden
WriteLiteral("                <option");

WriteLiteral(" value=\"\"");

WriteLiteral(" selected=\"selected\"");

WriteLiteral(">");

            
            #line 26 "..\..MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
                                                Write(Html.Resource("SelectLanguageDropDownOption"));

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 27 "..\..MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 29 "..\..MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
            
            
            #line default
            #line hidden
            
            #line 29 "..\..MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
             foreach (var language in Model.Languages)
            {

            
            #line default
            #line hidden
WriteLiteral("                <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1052), Tuple.Create("\"", 1077)
            
            #line 31 "..\..MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
, Tuple.Create(Tuple.Create("", 1060), Tuple.Create<System.Object, System.Int32>(language.Culture
            
            #line default
            #line hidden
, 1060), false)
);

WriteLiteral(" ");

            
            #line 31 "..\..MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
                                              Write(language.Culture == Model.CurrentLanguage ? "selected=selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 31 "..\..MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
                                                                                                                     Write(language.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 32 "..\..MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </select>\r\n    </label>\r\n</div>\r\n\r\n");

            
            #line 37 "..\..MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/LanguageSelector/language-selector.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
