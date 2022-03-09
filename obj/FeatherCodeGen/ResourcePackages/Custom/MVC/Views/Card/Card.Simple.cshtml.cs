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

namespace RealSiteFinityFirst.ResourcePackages.Custom.MVC.Views.Card
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
    
    #line 8 "..\..MVC\Views\Card\Card.Simple.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Card/Card.Simple.cshtml")]
    public partial class Card_Simple : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Card.Mvc.Models.Card.CardViewModel>
    {
        public Card_Simple()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 388), Tuple.Create("\"", 411)
            
            #line 10 "..\..MVC\Views\Card\Card.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 396), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 396), false)
);

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n");

            
            #line 12 "..\..MVC\Views\Card\Card.Simple.cshtml"
        
            
            #line default
            #line hidden
            
            #line 12 "..\..MVC\Views\Card\Card.Simple.cshtml"
         if (!string.IsNullOrEmpty(Model.SelectedSizeUrl))
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"col-lg-6\"");

WriteLiteral(">\r\n                <img");

WriteLiteral(" class=\"img-fluid\"");

WriteAttribute("src", Tuple.Create(" src=\"", 583), Tuple.Create("\"", 611)
            
            #line 15 "..\..MVC\Views\Card\Card.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 589), Tuple.Create<System.Object, System.Int32>(Model.SelectedSizeUrl
            
            #line default
            #line hidden
, 589), false)
);

WriteAttribute("title", Tuple.Create("  title=\"", 612), Tuple.Create("\"", 638)
            
            #line 15 "..\..MVC\Views\Card\Card.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 621), Tuple.Create<System.Object, System.Int32>(Model.ImageTitle
            
            #line default
            #line hidden
, 621), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 639), Tuple.Create("\"", 672)
            
            #line 15 "..\..MVC\Views\Card\Card.Simple.cshtml"
                     , Tuple.Create(Tuple.Create("", 645), Tuple.Create<System.Object, System.Int32>(Model.ImageAlternativeText
            
            #line default
            #line hidden
, 645), false)
);

WriteLiteral("/>\r\n            </div>\r\n");

            
            #line 17 "..\..MVC\Views\Card\Card.Simple.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"col-lg-6\"");

WriteLiteral(">\r\n");

            
            #line 19 "..\..MVC\Views\Card\Card.Simple.cshtml"
            
            
            #line default
            #line hidden
            
            #line 19 "..\..MVC\Views\Card\Card.Simple.cshtml"
             if (!string.IsNullOrEmpty(Model.Heading))
            {   

            
            #line default
            #line hidden
WriteLiteral("                <h5>");

            
            #line 21 "..\..MVC\Views\Card\Card.Simple.cshtml"
               Write(Html.HtmlSanitize(Model.Heading));

            
            #line default
            #line hidden
WriteLiteral("</h5>\r\n");

            
            #line 22 "..\..MVC\Views\Card\Card.Simple.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 23 "..\..MVC\Views\Card\Card.Simple.cshtml"
             if (!string.IsNullOrEmpty(Model.Description))
            {

            
            #line default
            #line hidden
WriteLiteral("                <p>");

            
            #line 25 "..\..MVC\Views\Card\Card.Simple.cshtml"
              Write(Html.HtmlSanitize(Model.Description));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 26 "..\..MVC\Views\Card\Card.Simple.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 27 "..\..MVC\Views\Card\Card.Simple.cshtml"
             if (!string.IsNullOrEmpty(Model.ActionName))
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteLiteral(" class=\"btn btn-primary\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1157), Tuple.Create("\"", 1198)
            
            #line 29 "..\..MVC\Views\Card\Card.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 1164), Tuple.Create<System.Object, System.Int32>(Html.UrlSanitize(Model.ActionUrl)
            
            #line default
            #line hidden
, 1164), false)
);

WriteLiteral(">");

            
            #line 29 "..\..MVC\Views\Card\Card.Simple.cshtml"
                                                                                Write(Model.ActionName);

            
            #line default
            #line hidden
WriteLiteral(" </a>\r\n");

            
            #line 30 "..\..MVC\Views\Card\Card.Simple.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
