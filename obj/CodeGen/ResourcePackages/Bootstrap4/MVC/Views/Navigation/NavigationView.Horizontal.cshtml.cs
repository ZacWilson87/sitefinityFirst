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

namespace RealSiteFinityFirst.ResourcePackages.Bootstrap4.MVC.Views.Navigation
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
    using Telerik.Sitefinity.Frontend.Navigation.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/Navigation/NavigationView.Horizontal.csht" +
        "ml")]
    public partial class NavigationView_Horizontal : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.INavigationModel>
    {

#line 32 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
public System.Web.WebPages.HelperResult RenderRootLevelNode(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 33 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
 
    if (node.ChildNodes.Count > 0)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <li");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 1502), Tuple.Create("\"", 1543)
, Tuple.Create(Tuple.Create("", 1510), Tuple.Create("nav-item", 1510), true)
, Tuple.Create(Tuple.Create(" ", 1518), Tuple.Create("dropdown", 1519), true)

#line 36 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create(" ", 1527), Tuple.Create<System.Object, System.Int32>(GetClass(node)

#line default
#line hidden
, 1528), false)
);

WriteLiteralTo(__razor_helper_writer, ">\n            <a");

WriteLiteralTo(__razor_helper_writer, " class=\"nav-link dropdown-toggle\"");

WriteLiteralTo(__razor_helper_writer, " href=\"#\"");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\'", 1602), Tuple.Create("\'", 1647)

#line 37 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create("", 1607), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("navbarDropdownMenuLink")

#line default
#line hidden
, 1607), false)
);

WriteLiteralTo(__razor_helper_writer, " data-toggle=\"dropdown\"");

WriteLiteralTo(__razor_helper_writer, " aria-haspopup=\"true\"");

WriteLiteralTo(__razor_helper_writer, " aria-expanded=\"false\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 37 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                                                                                                                                           WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\n            <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"dropdown-menu\"");

WriteAttributeTo(__razor_helper_writer, "aria-labelledby", Tuple.Create(" aria-labelledby=\'", 1768), Tuple.Create("\'", 1826)

#line 38 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create("", 1786), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("navbarDropdownMenuLink")

#line default
#line hidden
, 1786), false)
);

WriteLiteralTo(__razor_helper_writer, ">\n");

WriteLiteralTo(__razor_helper_writer, "                ");


#line 39 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(node));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\n            </ul>\n        </li>\n");


#line 42 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
    }
    else
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <li");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 1941), Tuple.Create("\"", 1973)
, Tuple.Create(Tuple.Create("", 1949), Tuple.Create("nav-item", 1949), true)

#line 45 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create(" ", 1957), Tuple.Create<System.Object, System.Int32>(GetClass(node)

#line default
#line hidden
, 1958), false)
);

WriteLiteralTo(__razor_helper_writer, ">\n            <a");

WriteLiteralTo(__razor_helper_writer, " class=\"nav-link\"");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 2007), Tuple.Create("\"", 2023)

#line 46 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create("", 2014), Tuple.Create<System.Object, System.Int32>(node.Url

#line default
#line hidden
, 2014), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 2024), Tuple.Create("\"", 2049)

#line 46 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create("", 2033), Tuple.Create<System.Object, System.Int32>(node.LinkTarget

#line default
#line hidden
, 2033), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 46 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                                             WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\n        </li>\n");


#line 48 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
    }


#line default
#line hidden
});

#line 49 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
}
#line default
#line hidden

#line 52 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
public System.Web.WebPages.HelperResult RenderSubLevelsRecursive(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 53 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
 
    foreach (var childNode in node.ChildNodes)
    {
        if(childNode.ChildNodes.Count > 0)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <li");

WriteLiteralTo(__razor_helper_writer, " class=\"dropdown-submenu\"");

WriteLiteralTo(__razor_helper_writer, ">\n                <a");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 2368), Tuple.Create("\"", 2410)
, Tuple.Create(Tuple.Create("", 2376), Tuple.Create("dropdown-item", 2376), true)

#line 59 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create(" ", 2389), Tuple.Create<System.Object, System.Int32>(GetClass(childNode)

#line default
#line hidden
, 2390), false)
);

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 2411), Tuple.Create("\"", 2432)

#line 59 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create("", 2418), Tuple.Create<System.Object, System.Int32>(childNode.Url

#line default
#line hidden
, 2418), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 2433), Tuple.Create("\"", 2463)

#line 59 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
            , Tuple.Create(Tuple.Create("", 2442), Tuple.Create<System.Object, System.Int32>(childNode.LinkTarget

#line default
#line hidden
, 2442), false)
);

WriteLiteralTo(__razor_helper_writer, ">\n");

WriteLiteralTo(__razor_helper_writer, "                    ");


#line 60 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
WriteTo(__razor_helper_writer, childNode.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\n                    <span");

WriteLiteralTo(__razor_helper_writer, " class=\"right-caret\"");

WriteLiteralTo(__razor_helper_writer, "></span>\n                </a>\n                <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"dropdown-menu\"");

WriteLiteralTo(__razor_helper_writer, ">\n");

WriteLiteralTo(__razor_helper_writer, "                    ");


#line 64 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(childNode));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\n                </ul>\n            </li>\n");


#line 67 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
        }
        else
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <li>\n                <a");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 2786), Tuple.Create("\"", 2828)
, Tuple.Create(Tuple.Create("", 2794), Tuple.Create("dropdown-item", 2794), true)

#line 71 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create(" ", 2807), Tuple.Create<System.Object, System.Int32>(GetClass(childNode)

#line default
#line hidden
, 2808), false)
);

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 2829), Tuple.Create("\"", 2850)

#line 71 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create("", 2836), Tuple.Create<System.Object, System.Int32>(childNode.Url

#line default
#line hidden
, 2836), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 2851), Tuple.Create("\"", 2881)

#line 71 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
            , Tuple.Create(Tuple.Create("", 2860), Tuple.Create<System.Object, System.Int32>(childNode.LinkTarget

#line default
#line hidden
, 2860), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 71 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                                                                                     WriteTo(__razor_helper_writer, childNode.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\n            </li>\n");


#line 73 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
        }
    }


#line default
#line hidden
});

#line 75 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
}
#line default
#line hidden

#line 78 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
public System.Web.WebPages.HelperResult GetClass(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 79 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
 

    if (node.IsCurrentlyOpened)
    {
        

#line default
#line hidden

#line 83 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("active"));


#line default
#line hidden

#line 83 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                                    ;
    }
    else if (node.HasChildOpen)
    {
        

#line default
#line hidden

#line 87 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("active"));


#line default
#line hidden

#line 87 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                                    ;
    }


#line default
#line hidden
});

#line 89 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
}
#line default
#line hidden

        public NavigationView_Horizontal()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

WriteLiteral("\n");

            
            #line 8 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 9 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
Write(Html.Script(Url.Content("~/ResourcePackages/Bootstrap4/assets/dist/js/popper.min.js"), "top", true));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 10 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
Write(Html.Script(Url.Content("~/ResourcePackages/Bootstrap4/assets/dist/js/bootstrap.min.js"), "top", true));

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 509), Tuple.Create("\"", 532)
            
            #line 12 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create("", 517), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 517), false)
);

WriteLiteral(">\n    <nav");

WriteLiteral(" class=\"navbar navbar-expand-md navbar-light bg-light\"");

WriteLiteral(">\n        ");

WriteLiteral("\r\n\n        <a");

WriteLiteral(" class=\"navbar-brand\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">Navbar</a>\n        <button");

WriteLiteral(" class=\"navbar-toggler\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" data-toggle=\"collapse\"");

WriteLiteral(" data-target=\'#");

            
            #line 17 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                                                                                     Write(Html.UniqueId("navbar"));

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteAttribute("aria-controls", Tuple.Create(" aria-controls=\'", 850), Tuple.Create("\'", 890)
            
            #line 17 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                                                    , Tuple.Create(Tuple.Create("", 866), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("navbar")
            
            #line default
            #line hidden
, 866), false)
);

WriteLiteral(" aria-expanded=\"false\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 913), Tuple.Create("\"", 960)
            
            #line 17 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                                                                                                                , Tuple.Create(Tuple.Create("", 926), Tuple.Create<System.Object, System.Int32>(Html.Resource("ToggleNavigation")
            
            #line default
            #line hidden
, 926), false)
);

WriteLiteral(">\n            <span");

WriteLiteral(" class=\"navbar-toggler-icon\"");

WriteLiteral("></span>\n        </button>\n        <div");

WriteLiteral(" class=\"collapse navbar-collapse\"");

WriteAttribute("id", Tuple.Create(" id=\'", 1080), Tuple.Create("\'", 1109)
            
            #line 20 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create("", 1085), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("navbar")
            
            #line default
            #line hidden
, 1085), false)
);

WriteLiteral(">\n            <ul");

WriteLiteral(" class=\"navbar-nav flex-wrap\"");

WriteLiteral(">\n");

            
            #line 22 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                
            
            #line default
            #line hidden
            
            #line 22 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                 foreach (var node in Model.Nodes)
                {
                    
            
            #line default
            #line hidden
            
            #line 24 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
               Write(RenderRootLevelNode(node));

            
            #line default
            #line hidden
            
            #line 24 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                                              ;
                }

            
            #line default
            #line hidden
WriteLiteral("            </ul>\n        </div>\n    </nav>\n</div>\n\n");

WriteLiteral("\n");

WriteLiteral("\n");

WriteLiteral("\n");

WriteLiteral("\n");

WriteLiteral("\n");

        }
    }
}
#pragma warning restore 1591
