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
    
    #line 9 "..\..\ResourcePackages\Custom\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 10 "..\..\ResourcePackages\Custom\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 8 "..\..\ResourcePackages\Custom\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Custom/MVC/Views/LanguageSelector/LanguageSelector.LanguageLin" +
        "ks.cshtml")]
    public partial class LanguageSelector_LanguageLinks : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.LanguageSelector.LanguageSelectorViewModel>
    {

#line 31 "..\..\ResourcePackages\Custom\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
public System.Web.WebPages.HelperResult GetClass(string culture)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 32 "..\..\ResourcePackages\Custom\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
 
    if (Model.CurrentLanguage == culture)
    {
        

#line default
#line hidden

#line 35 "..\..\ResourcePackages\Custom\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
WriteTo(__razor_helper_writer, Html.Raw("selected"));


#line default
#line hidden

#line 35 "..\..\ResourcePackages\Custom\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
                             ;
    }


#line default
#line hidden
});

#line 37 "..\..\ResourcePackages\Custom\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
}
#line default
#line hidden

        public LanguageSelector_LanguageLinks()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 497), Tuple.Create("\"", 520)
            
            #line 12 "..\..\ResourcePackages\Custom\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
, Tuple.Create(Tuple.Create("", 505), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 505), false)
);

WriteLiteral(">\r\n    <ul");

WriteLiteral(" class=\"sf-lang-selector list-inline\"");

WriteLiteral(">\r\n");

            
            #line 14 "..\..\ResourcePackages\Custom\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
        
            
            #line default
            #line hidden
            
            #line 14 "..\..\ResourcePackages\Custom\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
         foreach (var language in Model.Languages)
        {

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"list-inline-item\"");

WriteLiteral(">\r\n");

            
            #line 17 "..\..\ResourcePackages\Custom\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
                
            
            #line default
            #line hidden
            
            #line 17 "..\..\ResourcePackages\Custom\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
                 if (SystemManager.IsDesignMode)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <a");

WriteLiteral(" href=\"\"");

WriteLiteral(" onclick=\"return false;\"");

WriteAttribute("class", Tuple.Create(" class=\"", 800), Tuple.Create("\"", 835)
            
            #line 19 "..\..\ResourcePackages\Custom\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
, Tuple.Create(Tuple.Create("", 808), Tuple.Create<System.Object, System.Int32>(GetClass(language.Culture)
            
            #line default
            #line hidden
, 808), false)
);

WriteLiteral(">");

            
            #line 19 "..\..\ResourcePackages\Custom\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
                                                                                      Write(language.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 20 "..\..\ResourcePackages\Custom\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("\t                <a");

WriteLiteral(" href=\"\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 951), Tuple.Create("\"", 1005)
, Tuple.Create(Tuple.Create("", 961), Tuple.Create("openLink(\'", 961), true)
            
            #line 23 "..\..\ResourcePackages\Custom\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
, Tuple.Create(Tuple.Create("", 971), Tuple.Create<System.Object, System.Int32>(language.Culture
            
            #line default
            #line hidden
, 971), false)
, Tuple.Create(Tuple.Create("", 988), Tuple.Create("\');", 988), true)
, Tuple.Create(Tuple.Create(" ", 991), Tuple.Create("return", 992), true)
, Tuple.Create(Tuple.Create(" ", 998), Tuple.Create("false;", 999), true)
);

WriteAttribute("class", Tuple.Create(" class=\"", 1006), Tuple.Create("\"", 1041)
            
            #line 23 "..\..\ResourcePackages\Custom\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
             , Tuple.Create(Tuple.Create("", 1014), Tuple.Create<System.Object, System.Int32>(GetClass(language.Culture)
            
            #line default
            #line hidden
, 1014), false)
);

WriteLiteral(">");

            
            #line 23 "..\..\ResourcePackages\Custom\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
                                                                                                                     Write(language.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 24 "..\..\ResourcePackages\Custom\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </li>\r\n");

            
            #line 26 "..\..\ResourcePackages\Custom\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n</div>\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 39 "..\..\ResourcePackages\Custom\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/LanguageSelector/language-selector.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
