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

namespace RealSiteFinityFirst.ResourcePackages.Bootstrap4.MVC.Views.NavigationField
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
    using System.Linq;
    
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
    
    #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/NavigationField/Read.ProgressBar.cshtml")]
    public partial class Read_ProgressBar : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.NavigationField.NavigationFieldViewModel>
    {
        public Read_ProgressBar()
        {
        }
        public override void Execute()
        {
            
            #line 6 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 7 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
  
    var totalPages = Model.Pages.Count();

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 315), Tuple.Create("\"", 338)
            
            #line 10 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
, Tuple.Create(Tuple.Create("", 323), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 323), false)
);

WriteLiteral(" data-sf-role=\"navigation-field-container\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"progress\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"progress-bar\"");

WriteLiteral(" data-sf-role=\"progress-bar\"");

WriteLiteral("></div>\r\n    </div>\r\n\r\n    <span");

WriteLiteral(" class=\"sf-Progress-percent\"");

WriteLiteral(" data-sf-role=\"progress-percent\"");

WriteLiteral("> </span>\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"step-of-resources\"");

WriteAttribute("value", Tuple.Create(" value=\"", 633), Tuple.Create("\"", 665)
            
            #line 16 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
, Tuple.Create(Tuple.Create("", 641), Tuple.Create<System.Object, System.Int32>(Html.Resource("StepOf")
            
            #line default
            #line hidden
, 641), false)
);

WriteLiteral(" />\r\n    <ol");

WriteLiteral(" data-sf-role=\"sr-progressbar\"");

WriteLiteral(" class=\"sf-Progress-page-title\"");

WriteLiteral(" tabindex=\"0\"");

WriteLiteral(" role=\"progressbar\"");

WriteLiteral(" aria-valuemin=\"1\"");

WriteAttribute("aria-valuemax", Tuple.Create(" aria-valuemax=\"", 789), Tuple.Create("\"", 816)
            
            #line 17 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
                                                       , Tuple.Create(Tuple.Create("", 805), Tuple.Create<System.Object, System.Int32>(totalPages
            
            #line default
            #line hidden
, 805), false)
);

WriteLiteral(" aria-valuenow=\"1\"");

WriteAttribute("aria-valuetext", Tuple.Create(" aria-valuetext=\"", 835), Tuple.Create("\"", 873)
, Tuple.Create(Tuple.Create("", 852), Tuple.Create("Step", 852), true)
, Tuple.Create(Tuple.Create(" ", 856), Tuple.Create("1", 857), true)
, Tuple.Create(Tuple.Create(" ", 858), Tuple.Create("of", 859), true)
            
            #line 17 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
                                                                                                               , Tuple.Create(Tuple.Create(" ", 861), Tuple.Create<System.Object, System.Int32>(totalPages
            
            #line default
            #line hidden
, 862), false)
);

WriteLiteral(">\r\n");

            
            #line 18 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
        
            
            #line default
            #line hidden
            
            #line 18 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
         foreach (var page in Model.Pages)
        {

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" data-sf-navigation-index=\"");

            
            #line 20 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
                                     Write(page.Index);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" data-sf-page-title=\"");

            
            #line 21 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
                                     Write(page.Title);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">");

            
            #line 21 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
                                                  Write(Html.HtmlSanitize(page.Title));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            </li>\r\n");

            
            #line 23 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ol>\r\n</div>\r\n\r\n");

            
            #line 27 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Form/form.all.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591