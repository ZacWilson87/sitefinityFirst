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

namespace RealSiteFinityFirst.ResourcePackages.Bootstrap4.MVC.Views.SiteSelector
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
    
    #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
    using Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.SiteSelector;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/SiteSelector/SiteSelector.SiteLinks.cshtm" +
        "l")]
    public partial class SiteSelector_SiteLinks : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.SiteSelector.SiteSelectorViewModel>
    {
        public SiteSelector_SiteLinks()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 258), Tuple.Create("\"", 298)
            
            #line 7 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
, Tuple.Create(Tuple.Create("", 266), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 266), false)
, Tuple.Create(Tuple.Create(" ", 281), Tuple.Create("sf-site-selector", 282), true)
);

WriteLiteral(">\r\n\r\n    <h3>");

            
            #line 9 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
   Write(Html.Resource("Sites"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n   \r\n    <ul");

WriteLiteral(" class=\"list-unstyled\"");

WriteLiteral(">\r\n");

            
            #line 12 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
    
            
            #line default
            #line hidden
            
            #line 12 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
      
        string currentSite = string.Empty;
    
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 16 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
    
            
            #line default
            #line hidden
            
            #line 16 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
     foreach (var site in Model.Sites)
    {
        if (!Model.EachLanguageAsSeparateSite)
        {
            if (site.IsCurrent)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li><span");

WriteLiteral(" class=\"selected\"");

WriteLiteral(">");

            
            #line 22 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                      Write(site.Name);

            
            #line default
            #line hidden
WriteLiteral("</span></li>\r\n");

            
            #line 23 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
            }
            else if (SystemManager.IsDesignMode)
            {
            
            #line default
            #line hidden
WriteLiteral("   <li><a>");

            
            #line 25 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                  Write(site.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 26 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 840), Tuple.Create("\"", 856)
            
            #line 29 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
, Tuple.Create(Tuple.Create("", 847), Tuple.Create<System.Object, System.Int32>(site.Url
            
            #line default
            #line hidden
, 847), false)
);

WriteLiteral(">");

            
            #line 29 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                   Write(site.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 30 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
            }
        }
        else if (Model.SiteLanguagesDisplayMode == SiteLanguagesDisplayMode.SiteNamesAndLanguages)
        {
            if (site.IsCurrent)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li><span");

WriteLiteral(" class=\"selected\"");

WriteLiteral(">");

            
            #line 36 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                      Write(site.Name);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 36 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                                   Write(site.Language);

            
            #line default
            #line hidden
WriteLiteral("</span></li>\r\n");

            
            #line 37 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
            }
            else if (SystemManager.IsDesignMode && !SystemManager.IsInlineEditingMode && !SystemManager.IsPreviewMode)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li><a>");

            
            #line 40 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                  Write(site.Name);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 40 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                               Write(site.Language);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 41 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1429), Tuple.Create("\"", 1445)
            
            #line 44 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
, Tuple.Create(Tuple.Create("", 1436), Tuple.Create<System.Object, System.Int32>(site.Url
            
            #line default
            #line hidden
, 1436), false)
);

WriteLiteral(">");

            
            #line 44 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                   Write(site.Name);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 44 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                                Write(site.Language);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 45 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
            }
        }
        else
        {
            if(currentSite != site.Name)
            {                                   

            
            #line default
            #line hidden
WriteLiteral("                <li><strong>");

            
            #line 51 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                       Write(site.Name);

            
            #line default
            #line hidden
WriteLiteral("</strong></li>\r\n");

            
            #line 52 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                currentSite = site.Name;
            }

            if (site.IsCurrent)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li><span");

WriteLiteral(" class=\"selected\"");

WriteLiteral(">");

            
            #line 57 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                      Write(site.Language);

            
            #line default
            #line hidden
WriteLiteral("</span></li>\r\n");

            
            #line 58 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
            }
            else if (SystemManager.IsDesignMode && !SystemManager.IsInlineEditingMode && !SystemManager.IsPreviewMode)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li><a>");

            
            #line 61 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                  Write(site.Language);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 62 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
            }
            else
            {


            
            #line default
            #line hidden
WriteLiteral("                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2130), Tuple.Create("\"", 2146)
            
            #line 66 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
, Tuple.Create(Tuple.Create("", 2137), Tuple.Create<System.Object, System.Int32>(site.Url
            
            #line default
            #line hidden
, 2137), false)
);

WriteLiteral(">");

            
            #line 66 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                   Write(site.Language);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 67 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
            }
        }
    }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
