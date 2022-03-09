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

namespace RealSiteFinityFirst.ResourcePackages.Custom.MVC.Views.ContentPager
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
    
    #line 8 "..\..MVC\Views\ContentPager\Pager.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/ContentPager/Pager.cshtml")]
    public partial class Pager : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Helpers.ViewModels.PagerViewModel>
    {
        public Pager()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n<nav");

WriteLiteral(" role=\"navigation\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 409), Tuple.Create("\"", 450)
            
            #line 10 "..\..MVC\Views\ContentPager\Pager.cshtml"
, Tuple.Create(Tuple.Create("", 422), Tuple.Create<System.Object, System.Int32>(Html.Resource("Pagination")
            
            #line default
            #line hidden
, 422), false)
);

WriteLiteral(">\r\n    <ul");

WriteLiteral(" class=\"pagination\"");

WriteLiteral(">\r\n");

            
            #line 12 "..\..MVC\Views\ContentPager\Pager.cshtml"
        
            
            #line default
            #line hidden
            
            #line 12 "..\..MVC\Views\ContentPager\Pager.cshtml"
         if (Model.PreviousNode != null)
        {

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"page-item\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" class=\"page-link\"");

WriteAttribute("href", Tuple.Create(" href=\"", 608), Tuple.Create("\"", 687)
            
            #line 15 "..\..MVC\Views\ContentPager\Pager.cshtml"
, Tuple.Create(Tuple.Create("", 615), Tuple.Create<System.Object, System.Int32>(String.Format(Model.RedirectUrlTemplate, Model.PreviousNode.PageNumber)
            
            #line default
            #line hidden
, 615), false)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 688), Tuple.Create("\"", 735)
            
            #line 15 "..\..MVC\Views\ContentPager\Pager.cshtml"
                                                  , Tuple.Create(Tuple.Create("", 701), Tuple.Create<System.Object, System.Int32>(Html.Resource("GoToPreviousPage")
            
            #line default
            #line hidden
, 701), false)
);

WriteLiteral(">\r\n                    <span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">&laquo;</span>\r\n                </a>\r\n            </li>\r\n");

            
            #line 19 "..\..MVC\Views\ContentPager\Pager.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 20 "..\..MVC\Views\ContentPager\Pager.cshtml"
         foreach (var page in Model.PagerNodes.OrderBy(x => x.PageNumber))
        {
            if (Model.CurrentPage == page.PageNumber)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" class=\"active page-item\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" class=\"page-link\"");

WriteLiteral(" aria-current=\"true\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1116), Tuple.Create("\"", 1181)
            
            #line 25 "..\..MVC\Views\ContentPager\Pager.cshtml"
, Tuple.Create(Tuple.Create("", 1123), Tuple.Create<System.Object, System.Int32>(String.Format(Model.RedirectUrlTemplate, page.PageNumber)
            
            #line default
            #line hidden
, 1123), false)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 1182), Tuple.Create("\"", 1234)
            
            #line 25 "..\..MVC\Views\ContentPager\Pager.cshtml"
                                                           , Tuple.Create(Tuple.Create("", 1195), Tuple.Create<System.Object, System.Int32>(Html.Resource("Page")
            
            #line default
            #line hidden
, 1195), false)
            
            #line 25 "..\..MVC\Views\ContentPager\Pager.cshtml"
                                                                                 , Tuple.Create(Tuple.Create(" ", 1217), Tuple.Create<System.Object, System.Int32>(page.PageNumber
            
            #line default
            #line hidden
, 1218), false)
);

WriteLiteral(">");

            
            #line 25 "..\..MVC\Views\ContentPager\Pager.cshtml"
                                                                                                                                                                               Write(page.PageNumber);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </li>\r\n");

            
            #line 27 "..\..MVC\Views\ContentPager\Pager.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" class=\"page-item\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" class=\"page-link\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1409), Tuple.Create("\"", 1474)
            
            #line 31 "..\..MVC\Views\ContentPager\Pager.cshtml"
, Tuple.Create(Tuple.Create("", 1416), Tuple.Create<System.Object, System.Int32>(String.Format(Model.RedirectUrlTemplate, page.PageNumber)
            
            #line default
            #line hidden
, 1416), false)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 1475), Tuple.Create("\"", 1531)
            
            #line 31 "..\..MVC\Views\ContentPager\Pager.cshtml"
                                       , Tuple.Create(Tuple.Create("", 1488), Tuple.Create<System.Object, System.Int32>(Html.Resource("GoToPage")
            
            #line default
            #line hidden
, 1488), false)
            
            #line 31 "..\..MVC\Views\ContentPager\Pager.cshtml"
                                                                 , Tuple.Create(Tuple.Create(" ", 1514), Tuple.Create<System.Object, System.Int32>(page.PageNumber
            
            #line default
            #line hidden
, 1515), false)
);

WriteLiteral(">");

            
            #line 31 "..\..MVC\Views\ContentPager\Pager.cshtml"
                                                                                                                                                               Write(page.PageNumber);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </li>\r\n");

            
            #line 33 "..\..MVC\Views\ContentPager\Pager.cshtml"
            }
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 35 "..\..MVC\Views\ContentPager\Pager.cshtml"
         if (Model.NextNode != null)
        {

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"page-item\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" class=\"page-link\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1725), Tuple.Create("\"", 1800)
            
            #line 38 "..\..MVC\Views\ContentPager\Pager.cshtml"
, Tuple.Create(Tuple.Create("", 1732), Tuple.Create<System.Object, System.Int32>(String.Format(Model.RedirectUrlTemplate, Model.NextNode.PageNumber)
            
            #line default
            #line hidden
, 1732), false)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 1801), Tuple.Create("\"", 1844)
            
            #line 38 "..\..MVC\Views\ContentPager\Pager.cshtml"
                                             , Tuple.Create(Tuple.Create("", 1814), Tuple.Create<System.Object, System.Int32>(Html.Resource("GoToNextPage")
            
            #line default
            #line hidden
, 1814), false)
);

WriteLiteral(">\r\n                    <span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">&raquo;</span>\r\n                </a>\r\n            </li>\r\n");

            
            #line 42 "..\..MVC\Views\ContentPager\Pager.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n</nav>");

        }
    }
}
#pragma warning restore 1591