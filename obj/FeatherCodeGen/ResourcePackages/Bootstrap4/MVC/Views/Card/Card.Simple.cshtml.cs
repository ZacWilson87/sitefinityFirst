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

namespace RealSiteFinityFirst.ResourcePackages.Bootstrap4.MVC.Views.Card
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
    
    #line 3 "..\..MVC\Views\Card\Card.Simple.cshtml"
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
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 128), Tuple.Create("\"", 151)
            
            #line 5 "..\..MVC\Views\Card\Card.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 136), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 136), false)
);

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n");

            
            #line 7 "..\..MVC\Views\Card\Card.Simple.cshtml"
        
            
            #line default
            #line hidden
            
            #line 7 "..\..MVC\Views\Card\Card.Simple.cshtml"
         if (!string.IsNullOrEmpty(Model.SelectedSizeUrl))
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"col-lg-6\"");

WriteLiteral(">\r\n                <img");

WriteLiteral(" class=\"img-fluid\"");

WriteAttribute("src", Tuple.Create(" src=\"", 323), Tuple.Create("\"", 351)
            
            #line 10 "..\..MVC\Views\Card\Card.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 329), Tuple.Create<System.Object, System.Int32>(Model.SelectedSizeUrl
            
            #line default
            #line hidden
, 329), false)
);

WriteAttribute("title", Tuple.Create("  title=\"", 352), Tuple.Create("\"", 378)
            
            #line 10 "..\..MVC\Views\Card\Card.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 361), Tuple.Create<System.Object, System.Int32>(Model.ImageTitle
            
            #line default
            #line hidden
, 361), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 379), Tuple.Create("\"", 412)
            
            #line 10 "..\..MVC\Views\Card\Card.Simple.cshtml"
                     , Tuple.Create(Tuple.Create("", 385), Tuple.Create<System.Object, System.Int32>(Model.ImageAlternativeText
            
            #line default
            #line hidden
, 385), false)
);

WriteLiteral("/>\r\n            </div>\r\n");

            
            #line 12 "..\..MVC\Views\Card\Card.Simple.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"col-lg-6\"");

WriteLiteral(">\r\n");

            
            #line 14 "..\..MVC\Views\Card\Card.Simple.cshtml"
            
            
            #line default
            #line hidden
            
            #line 14 "..\..MVC\Views\Card\Card.Simple.cshtml"
             if (!string.IsNullOrEmpty(Model.Heading))
            {   

            
            #line default
            #line hidden
WriteLiteral("                <h5>");

            
            #line 16 "..\..MVC\Views\Card\Card.Simple.cshtml"
               Write(Html.HtmlSanitize(Model.Heading));

            
            #line default
            #line hidden
WriteLiteral("</h5>\r\n");

            
            #line 17 "..\..MVC\Views\Card\Card.Simple.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 18 "..\..MVC\Views\Card\Card.Simple.cshtml"
             if (!string.IsNullOrEmpty(Model.Description))
            {

            
            #line default
            #line hidden
WriteLiteral("                <p>");

            
            #line 20 "..\..MVC\Views\Card\Card.Simple.cshtml"
              Write(Html.HtmlSanitize(Model.Description));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 21 "..\..MVC\Views\Card\Card.Simple.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 22 "..\..MVC\Views\Card\Card.Simple.cshtml"
             if (!string.IsNullOrEmpty(Model.ActionName))
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteLiteral(" class=\"btn btn-primary\"");

WriteAttribute("href", Tuple.Create(" href=\"", 897), Tuple.Create("\"", 938)
            
            #line 24 "..\..MVC\Views\Card\Card.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 904), Tuple.Create<System.Object, System.Int32>(Html.UrlSanitize(Model.ActionUrl)
            
            #line default
            #line hidden
, 904), false)
);

WriteLiteral(">");

            
            #line 24 "..\..MVC\Views\Card\Card.Simple.cshtml"
                                                                                Write(Model.ActionName);

            
            #line default
            #line hidden
WriteLiteral(" </a>\r\n");

            
            #line 25 "..\..MVC\Views\Card\Card.Simple.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
