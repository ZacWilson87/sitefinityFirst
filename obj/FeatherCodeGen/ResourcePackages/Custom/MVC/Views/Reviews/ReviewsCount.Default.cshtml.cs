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

namespace RealSiteFinityFirst.ResourcePackages.Custom.MVC.Views.Reviews
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
    
    #line 8 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 9 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Reviews/ReviewsCount.Default.cshtml")]
    public partial class ReviewsCount_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Comments.Mvc.Models.CommentsCountViewModel>
    {
        public ReviewsCount_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 11 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" data-sf-role=\"comments-count-wrapper\"");

WriteLiteral(" data-sf-thread-key=\"");

            
            #line 13 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
                                                          Write(Model.ThreadKey);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" class=\"sf-Review-count\"");

WriteLiteral(">\r\n\r\n    <span");

WriteLiteral(" data-sf-role=\"list-rating-wrapper\"");

WriteLiteral(" class=\"sf-Ratings\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" data-sf-role=\"list-rating-container\"");

WriteLiteral(" class=\"sf-Ratings-stars sf-Ratings-stars--ronly\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></span>\r\n        <span");

WriteLiteral(" class=\"text-muted sf-Ratings-average\"");

WriteLiteral(">\r\n            <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 18 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
                             Write(Html.Resource("Rating"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            <span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">(</span><span");

WriteLiteral(" data-sf-role=\"list-rating-value\"");

WriteLiteral("></span><span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">)</span>\r\n            <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(" data-sf-role=\"list-rating-sr-label\"");

WriteLiteral("></span>\r\n        </span>\r\n    </span>\r\n    <a");

WriteLiteral(" data-sf-role=\"comments-count-anchor\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1183), Tuple.Create("\"", 1208)
            
            #line 23 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1190), Tuple.Create<System.Object, System.Int32>(Model.NavigateUrl
            
            #line default
            #line hidden
, 1190), false)
);

WriteLiteral(" class=\"sf-Ratings-count\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" data-sf-role=\"comments-count-anchor-text\"");

WriteLiteral("></span>\r\n    </a>\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"service-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1363), Tuple.Create("\"", 1390)
            
            #line 26 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1371), Tuple.Create<System.Object, System.Int32>(ViewBag.ServiceUrl
            
            #line default
            #line hidden
, 1371), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"comments-count-resources\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1460), Tuple.Create("\'", 1659)
, Tuple.Create(Tuple.Create("", 1468), Tuple.Create("{\"commentsPlural\":", 1468), true)
, Tuple.Create(Tuple.Create(" ", 1486), Tuple.Create("\"", 1487), true)
            
            #line 27 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
            , Tuple.Create(Tuple.Create("", 1488), Tuple.Create<System.Object, System.Int32>(Html.Resource("ReviewsPlural")
            
            #line default
            #line hidden
, 1488), false)
, Tuple.Create(Tuple.Create("", 1519), Tuple.Create("\",", 1519), true)
, Tuple.Create(Tuple.Create(" ", 1521), Tuple.Create("\"leaveComment\":\"", 1522), true)
            
            #line 27 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
                                                              , Tuple.Create(Tuple.Create("", 1538), Tuple.Create<System.Object, System.Int32>(Html.Resource("WriteReview")
            
            #line default
            #line hidden
, 1538), false)
, Tuple.Create(Tuple.Create("", 1567), Tuple.Create("\",", 1567), true)
, Tuple.Create(Tuple.Create(" ", 1569), Tuple.Create("\"comment\":\"", 1570), true)
            
            #line 27 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
                                                                                                         , Tuple.Create(Tuple.Create("", 1581), Tuple.Create<System.Object, System.Int32>(Html.Resource("Review")
            
            #line default
            #line hidden
, 1581), false)
, Tuple.Create(Tuple.Create("", 1605), Tuple.Create("\",", 1605), true)
, Tuple.Create(Tuple.Create(" ", 1607), Tuple.Create("\"averageRating\":\"", 1608), true)
            
            #line 27 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
                                                                                                                                                     , Tuple.Create(Tuple.Create("", 1625), Tuple.Create<System.Object, System.Int32>(Html.Resource("AverageRating")
            
            #line default
            #line hidden
, 1625), false)
, Tuple.Create(Tuple.Create("", 1656), Tuple.Create("\"", 1656), true)
, Tuple.Create(Tuple.Create(" ", 1657), Tuple.Create("}", 1658), true)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"rating-of-resource\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1723), Tuple.Create("\"", 1751)
            
            #line 28 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1731), Tuple.Create<System.Object, System.Int32>(Html.Resource("Of")
            
            #line default
            #line hidden
, 1731), false)
);

WriteLiteral(" />\r\n</div>\r\n\r\n");

WriteLiteral("\r\n<div");

WriteLiteral(" data-sf-role=\"rating-template\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral("><span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">&#9733;</span></div>\r\n\r\n");

            
            #line 34 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Reviews/rating.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 35 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/comments-count.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591