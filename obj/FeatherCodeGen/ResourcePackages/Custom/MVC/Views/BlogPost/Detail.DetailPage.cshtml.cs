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

namespace RealSiteFinityFirst.ResourcePackages.Custom.MVC.Views.BlogPost
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
    
    #line 8 "..\..MVC\Views\BlogPost\Detail.DetailPage.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 9 "..\..MVC\Views\BlogPost\Detail.DetailPage.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 10 "..\..MVC\Views\BlogPost\Detail.DetailPage.cshtml"
    using Telerik.Sitefinity.Web.DataResolving;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/BlogPost/Detail.DetailPage.cshtml")]
    public partial class Detail_DetailPage : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentDetailsViewModel>
    {
        public Detail_DetailPage()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 462), Tuple.Create("\"", 485)
            
            #line 12 "..\..MVC\Views\BlogPost\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 470), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 470), false)
);

WriteLiteral(" ");

            
            #line 12 "..\..MVC\Views\BlogPost\Detail.DetailPage.cshtml"
                        Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)Model.Item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\r\n    <h3>\r\n        <span ");

            
            #line 14 "..\..MVC\Views\BlogPost\Detail.DetailPage.cshtml"
         Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 14 "..\..MVC\Views\BlogPost\Detail.DetailPage.cshtml"
                                                                  Write(Model.Item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n    </h3>\r\n\r\n    <div>\r\n");

WriteLiteral("        ");

            
            #line 18 "..\..MVC\Views\BlogPost\Detail.DetailPage.cshtml"
   Write(Model.Item.GetDateTime("PublicationDate", "MMM d, yyyy, HH:mm tt"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 19 "..\..MVC\Views\BlogPost\Detail.DetailPage.cshtml"
   Write(Html.Resource("By"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 20 "..\..MVC\Views\BlogPost\Detail.DetailPage.cshtml"
   Write(DataResolver.Resolve(@Model.Item.DataItem, "Author", null));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 21 "..\..MVC\Views\BlogPost\Detail.DetailPage.cshtml"
   Write(Html.CommentsCount(string.Empty, @Model.Item.DataItem));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    \r\n    <div ");

            
            #line 24 "..\..MVC\Views\BlogPost\Detail.DetailPage.cshtml"
    Write(Html.InlineEditingFieldAttributes("Summary", "LongText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 24 "..\..MVC\Views\BlogPost\Detail.DetailPage.cshtml"
                                                              Write(Html.HtmlSanitize((string)Model.Item.Fields.Summary));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n    <div ");

            
            #line 26 "..\..MVC\Views\BlogPost\Detail.DetailPage.cshtml"
    Write(Html.InlineEditingFieldAttributes("Content", "LongText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 26 "..\..MVC\Views\BlogPost\Detail.DetailPage.cshtml"
                                                              Write(Html.HtmlSanitize((string)Model.Item.Fields.Content));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n");

WriteLiteral("    ");

            
            #line 28 "..\..MVC\Views\BlogPost\Detail.DetailPage.cshtml"
Write(Html.CommentsList(@Model.Item.DataItem));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>");

        }
    }
}
#pragma warning restore 1591
