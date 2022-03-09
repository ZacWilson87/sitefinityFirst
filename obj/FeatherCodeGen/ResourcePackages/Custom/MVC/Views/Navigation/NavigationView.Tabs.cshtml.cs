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
    
    #line 8 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 9 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
    using Telerik.Sitefinity.Frontend.Navigation.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 10 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Navigation/NavigationView.Tabs.cshtml")]
    public partial class NavigationView_Tabs : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.INavigationModel>
    {

#line 24 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
public System.Web.WebPages.HelperResult RenderRootLevelNode(IList<NodeViewModel> nodes)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 25 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"nav nav-tabs\"");

WriteLiteralTo(__razor_helper_writer, " role=\"tablist\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 27 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
        

#line default
#line hidden

#line 27 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
         foreach(var node in nodes)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <li");

WriteLiteralTo(__razor_helper_writer, " class=\"nav-item\"");

WriteLiteralTo(__razor_helper_writer, " role=\"tab\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                <a");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 1040), Tuple.Create("\"", 1072)
, Tuple.Create(Tuple.Create("", 1048), Tuple.Create("nav-link", 1048), true)

#line 30 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
, Tuple.Create(Tuple.Create(" ", 1056), Tuple.Create<System.Object, System.Int32>(GetClass(node)

#line default
#line hidden
, 1057), false)
);

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 1073), Tuple.Create("\"", 1089)

#line 30 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
, Tuple.Create(Tuple.Create("", 1080), Tuple.Create<System.Object, System.Int32>(node.Url

#line default
#line hidden
, 1080), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 1090), Tuple.Create("\"", 1115)

#line 30 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
, Tuple.Create(Tuple.Create("", 1099), Tuple.Create<System.Object, System.Int32>(node.LinkTarget

#line default
#line hidden
, 1099), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 30 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
                                                                 WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n            </li>\r\n");


#line 32 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </ul>\r\n");


#line 34 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"


#line default
#line hidden
});

#line 34 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
}
#line default
#line hidden

#line 37 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
public System.Web.WebPages.HelperResult RenderSubLevelsRecursive(IList<NodeViewModel> nodes)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 38 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
 
    var selectedNode = nodes.SingleOrDefault(node => node.IsCurrentlyOpened || node.HasChildOpen);

    if(selectedNode !=null)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "         <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"nav nav-pills\"");

WriteLiteralTo(__razor_helper_writer, " role=\"tablist\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 44 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
            

#line default
#line hidden

#line 44 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
             foreach (var node in selectedNode.ChildNodes)
            {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                <li");

WriteLiteralTo(__razor_helper_writer, " class=\"nav-item\"");

WriteLiteralTo(__razor_helper_writer, " role=\"tab\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                    <a");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 1640), Tuple.Create("\"", 1672)
, Tuple.Create(Tuple.Create("", 1648), Tuple.Create("nav-link", 1648), true)

#line 47 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
, Tuple.Create(Tuple.Create(" ", 1656), Tuple.Create<System.Object, System.Int32>(GetClass(node)

#line default
#line hidden
, 1657), false)
);

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 1673), Tuple.Create("\"", 1689)

#line 47 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
, Tuple.Create(Tuple.Create("", 1680), Tuple.Create<System.Object, System.Int32>(node.Url

#line default
#line hidden
, 1680), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 1690), Tuple.Create("\"", 1715)

#line 47 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
 , Tuple.Create(Tuple.Create("", 1699), Tuple.Create<System.Object, System.Int32>(node.LinkTarget

#line default
#line hidden
, 1699), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 47 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
                                                                     WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n                </li>\r\n");


#line 49 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
            }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        </ul>\r\n");


#line 51 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
        

#line default
#line hidden

#line 51 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(selectedNode.ChildNodes));


#line default
#line hidden

#line 51 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
                                                          ;
    }


#line default
#line hidden
});

#line 53 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
}
#line default
#line hidden

#line 56 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
public System.Web.WebPages.HelperResult GetClass(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 57 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
 
    if (node.IsCurrentlyOpened)
    {
        

#line default
#line hidden

#line 60 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("active"));


#line default
#line hidden

#line 60 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
                                    ;
    }
    else if (node.HasChildOpen)
    {
        

#line default
#line hidden

#line 64 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("active"));


#line default
#line hidden

#line 64 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
                                    ;
    }


#line default
#line hidden
});

#line 66 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
}
#line default
#line hidden

        public NavigationView_Tabs()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 528), Tuple.Create("\"", 551)
            
            #line 14 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
, Tuple.Create(Tuple.Create("", 536), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 536), false)
);

WriteLiteral(">\r\n    <nav>\r\n        ");

WriteLiteral("\r\n\r\n");

WriteLiteral("        ");

            
            #line 18 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
   Write(RenderRootLevelNode(@Model.Nodes));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 19 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
   Write(RenderSubLevelsRecursive(@Model.Nodes));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </nav>\r\n</div>\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591