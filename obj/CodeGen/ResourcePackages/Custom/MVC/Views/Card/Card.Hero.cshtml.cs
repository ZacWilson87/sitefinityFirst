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
    
    #line 7 "..\..\ResourcePackages\Custom\MVC\Views\Card\Card.Hero.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Custom/MVC/Views/Card/Card.Hero.cshtml")]
    public partial class Card_Hero : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Card.Mvc.Models.Card.CardViewModel>
    {
        public Card_Hero()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteAttribute("class", Tuple.Create(" class=\"", 383), Tuple.Create("\"", 416)
            
            #line 8 "..\..\ResourcePackages\Custom\MVC\Views\Card\Card.Hero.cshtml"
, Tuple.Create(Tuple.Create("", 391), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 391), false)
, Tuple.Create(Tuple.Create(" ", 406), Tuple.Create("container", 407), true)
);

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"jumbotron\"");

WriteAttribute("style", Tuple.Create(" style=\"", 446), Tuple.Create("\"", 544)
, Tuple.Create(Tuple.Create("", 454), Tuple.Create("background:", 454), true)
, Tuple.Create(Tuple.Create(" ", 465), Tuple.Create("url(&quot;", 466), true)
            
            #line 9 "..\..\ResourcePackages\Custom\MVC\Views\Card\Card.Hero.cshtml"
, Tuple.Create(Tuple.Create("", 476), Tuple.Create<System.Object, System.Int32>(Model.SelectedSizeUrl
            
            #line default
            #line hidden
, 476), false)
, Tuple.Create(Tuple.Create("", 498), Tuple.Create("&quot;)", 498), true)
, Tuple.Create(Tuple.Create(" ", 505), Tuple.Create("center", 506), true)
, Tuple.Create(Tuple.Create(" ", 512), Tuple.Create("center;", 513), true)
, Tuple.Create(Tuple.Create(" ", 520), Tuple.Create("background-size:", 521), true)
, Tuple.Create(Tuple.Create(" ", 537), Tuple.Create("cover;", 538), true)
);

WriteLiteral(">\r\n        <h1");

WriteLiteral(" class=\"display-4\"");

WriteLiteral(">");

            
            #line 10 "..\..\ResourcePackages\Custom\MVC\Views\Card\Card.Hero.cshtml"
                         Write(Html.HtmlSanitize(Model.Heading));

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n        <p");

WriteLiteral(" class=\"lead\"");

WriteLiteral(">");

            
            #line 11 "..\..\ResourcePackages\Custom\MVC\Views\Card\Card.Hero.cshtml"
                   Write(Html.HtmlSanitize(Model.Description));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 12 "..\..\ResourcePackages\Custom\MVC\Views\Card\Card.Hero.cshtml"
        
            
            #line default
            #line hidden
            
            #line 12 "..\..\ResourcePackages\Custom\MVC\Views\Card\Card.Hero.cshtml"
         if (!string.IsNullOrEmpty(Model.ActionName))
        {

            
            #line default
            #line hidden
WriteLiteral("            <a");

WriteLiteral(" class=\"btn btn-primary btn-lg\"");

WriteAttribute("href", Tuple.Create(" href=\"", 796), Tuple.Create("\"", 837)
            
            #line 14 "..\..\ResourcePackages\Custom\MVC\Views\Card\Card.Hero.cshtml"
, Tuple.Create(Tuple.Create("", 803), Tuple.Create<System.Object, System.Int32>(Html.UrlSanitize(Model.ActionUrl)
            
            #line default
            #line hidden
, 803), false)
);

WriteLiteral(" class=\"btn btn-primary btn-lg\"");

WriteLiteral(" role=\"button\"");

WriteLiteral(" >");

            
            #line 14 "..\..\ResourcePackages\Custom\MVC\Views\Card\Card.Hero.cshtml"
                                                                                                                                 Write(Model.ActionName);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 15 "..\..\ResourcePackages\Custom\MVC\Views\Card\Card.Hero.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
