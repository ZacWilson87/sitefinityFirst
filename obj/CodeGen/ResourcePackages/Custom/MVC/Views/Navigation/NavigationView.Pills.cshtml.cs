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

namespace RealSiteFinityFirst.ResourcePackages.Custom.MVC.Views.Navigation
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
    
    #line 8 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 9 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
    using Telerik.Sitefinity.Frontend.Navigation.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 10 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Custom/MVC/Views/Navigation/NavigationView.Pills.cshtml")]
    public partial class NavigationView_Pills : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.INavigationModel>
    {

#line 31 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
public System.Web.WebPages.HelperResult RenderRootLevelNode(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 32 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
 
    if (node.ChildNodes.Count > 0)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <li");

WriteLiteralTo(__razor_helper_writer, " class=\"nav-item dropdown\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <a");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 1304), Tuple.Create("\"", 1352)
, Tuple.Create(Tuple.Create("", 1312), Tuple.Create("nav-link", 1312), true)
, Tuple.Create(Tuple.Create(" ", 1320), Tuple.Create("dropdown-toggle", 1321), true)

#line 36 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create(" ", 1336), Tuple.Create<System.Object, System.Int32>(GetClass(node)

#line default
#line hidden
, 1337), false)
);

WriteLiteralTo(__razor_helper_writer, " data-toggle=\"dropdown\"");

WriteLiteralTo(__razor_helper_writer, " href=\"#\"");

WriteLiteralTo(__razor_helper_writer, " role=\"button\"");

WriteLiteralTo(__razor_helper_writer, " aria-haspopup=\"true\"");

WriteLiteralTo(__razor_helper_writer, " aria-expanded=\"false\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 36 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
                                                                                                                           WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n            <div");

WriteLiteralTo(__razor_helper_writer, " class=\"dropdown-menu\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                ");


#line 38 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(node));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n            </div>\r\n        </li>\r\n");


#line 41 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
    }
    else
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <li");

WriteLiteralTo(__razor_helper_writer, " class=\"nav-item\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <a");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 1654), Tuple.Create("\"", 1686)
, Tuple.Create(Tuple.Create("", 1662), Tuple.Create("nav-link", 1662), true)

#line 45 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create(" ", 1670), Tuple.Create<System.Object, System.Int32>(GetClass(node)

#line default
#line hidden
, 1671), false)
);

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 1687), Tuple.Create("\"", 1703)

#line 45 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 1694), Tuple.Create<System.Object, System.Int32>(node.Url

#line default
#line hidden
, 1694), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 1704), Tuple.Create("\"", 1729)

#line 45 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 1713), Tuple.Create<System.Object, System.Int32>(node.LinkTarget

#line default
#line hidden
, 1713), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 45 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
                                                             WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n        </li>\r\n");


#line 47 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
    }


#line default
#line hidden
});

#line 48 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
}
#line default
#line hidden

#line 51 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
public System.Web.WebPages.HelperResult RenderSubLevelsRecursive(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 52 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
 
    foreach (var childNode in node.ChildNodes)
    {
        if(childNode.ChildNodes.Count > 0)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <div");

WriteLiteralTo(__razor_helper_writer, " class=\"dropdown-submenu\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                <a");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 2062), Tuple.Create("\"", 2104)
, Tuple.Create(Tuple.Create("", 2070), Tuple.Create("dropdown-item", 2070), true)

#line 58 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create(" ", 2083), Tuple.Create<System.Object, System.Int32>(GetClass(childNode)

#line default
#line hidden
, 2084), false)
);

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 2105), Tuple.Create("\"", 2126)

#line 58 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 2112), Tuple.Create<System.Object, System.Int32>(childNode.Url

#line default
#line hidden
, 2112), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 2127), Tuple.Create("\"", 2157)

#line 58 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
            , Tuple.Create(Tuple.Create("", 2136), Tuple.Create<System.Object, System.Int32>(childNode.LinkTarget

#line default
#line hidden
, 2136), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                    ");


#line 59 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
WriteTo(__razor_helper_writer, childNode.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                    <span");

WriteLiteralTo(__razor_helper_writer, " class=\"right-caret\"");

WriteLiteralTo(__razor_helper_writer, "></span>\r\n                </a>\r\n                <div");

WriteLiteralTo(__razor_helper_writer, " class=\"dropdown-menu\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                    ");


#line 63 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(childNode));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                </div>\r\n            </div>\r\n");


#line 66 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
        }
        else
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <a");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 2473), Tuple.Create("\"", 2515)
, Tuple.Create(Tuple.Create("", 2481), Tuple.Create("dropdown-item", 2481), true)

#line 69 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create(" ", 2494), Tuple.Create<System.Object, System.Int32>(GetClass(childNode)

#line default
#line hidden
, 2495), false)
);

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 2516), Tuple.Create("\"", 2537)

#line 69 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 2523), Tuple.Create<System.Object, System.Int32>(childNode.Url

#line default
#line hidden
, 2523), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 2538), Tuple.Create("\"", 2568)

#line 69 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
        , Tuple.Create(Tuple.Create("", 2547), Tuple.Create<System.Object, System.Int32>(childNode.LinkTarget

#line default
#line hidden
, 2547), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 69 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
                                                                                 WriteTo(__razor_helper_writer, childNode.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n");


#line 70 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
        }
    }


#line default
#line hidden
});

#line 72 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
}
#line default
#line hidden

#line 75 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
public System.Web.WebPages.HelperResult GetClass(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 76 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
 

    if (node.IsCurrentlyOpened)
    {
        

#line default
#line hidden

#line 80 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
WriteTo(__razor_helper_writer, Html.Raw("active"));


#line default
#line hidden

#line 80 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
                           ;
    }
    else if (node.HasChildOpen)
    {
        

#line default
#line hidden

#line 84 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
WriteTo(__razor_helper_writer, Html.Raw("active"));


#line default
#line hidden

#line 84 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
                           ;
    }


#line default
#line hidden
});

#line 86 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
}
#line default
#line hidden

        public NavigationView_Pills()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 13 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 14 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
Write(Html.Script(Url.Content("~/ResourcePackages/Bootstrap4/assets/dist/js/popper.min.js"), "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 15 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
Write(Html.Script(Url.Content("~/ResourcePackages/Bootstrap4/assets/dist/js/bootstrap.min.js"), "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 780), Tuple.Create("\"", 803)
            
            #line 17 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 788), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 788), false)
);

WriteLiteral(">\r\n    <nav>\r\n        ");

WriteLiteral("\r\n\r\n        <ul");

WriteLiteral(" class=\"nav nav-pills\"");

WriteLiteral(">\r\n");

            
            #line 22 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
            
            
            #line default
            #line hidden
            
            #line 22 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
             foreach (var node in Model.Nodes)
            {
                
            
            #line default
            #line hidden
            
            #line 24 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
           Write(RenderRootLevelNode(node));

            
            #line default
            #line hidden
            
            #line 24 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
                                          ;
            }

            
            #line default
            #line hidden
WriteLiteral("        </ul>\r\n    </nav>\r\n</div>\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 88 "..\..\ResourcePackages\Custom\MVC\Views\Navigation\NavigationView.Pills.cshtml"
Write(Html.Script(Url.WidgetContent("MVC/Scripts/Navigation/pills.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
