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

namespace RealSiteFinityFirst.ResourcePackages.Custom.MVC.Views.Blog
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
    
    #line 8 "..\..MVC\Views\Blog\List.BlogList.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 9 "..\..MVC\Views\Blog\List.BlogList.cshtml"
    using Telerik.Sitefinity.Frontend.Blogs.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 10 "..\..MVC\Views\Blog\List.BlogList.cshtml"
    using Telerik.Sitefinity.Frontend.Blogs.Mvc.Models.Blog;
    
    #line default
    #line hidden
    
    #line 11 "..\..MVC\Views\Blog\List.BlogList.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 12 "..\..MVC\Views\Blog\List.BlogList.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Blog/List.BlogList.cshtml")]
    public partial class List_BlogList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_BlogList()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 569), Tuple.Create("\"", 592)
            
            #line 14 "..\..MVC\Views\Blog\List.BlogList.cshtml"
, Tuple.Create(Tuple.Create("", 577), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 577), false)
);

WriteLiteral(">\r\n    <ul");

WriteLiteral(" class=\"list-unstyled\"");

WriteLiteral(">\r\n");

            
            #line 16 "..\..MVC\Views\Blog\List.BlogList.cshtml"
        
            
            #line default
            #line hidden
            
            #line 16 "..\..MVC\Views\Blog\List.BlogList.cshtml"
          
            var lastPostDates = Model.GetLastPostDates();
        
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 20 "..\..MVC\Views\Blog\List.BlogList.cshtml"
        
            
            #line default
            #line hidden
            
            #line 20 "..\..MVC\Views\Blog\List.BlogList.cshtml"
         foreach (var item in Model.Items)
        {
            var detailPageUrl = BlogHelper.GetDetailPageUrl(item, (Guid)ViewBag.DetailsPageId, (BlogDetailLocationMode)ViewBag.DetailPageMode);

            
            #line default
            #line hidden
WriteLiteral("            <li ");

            
            #line 23 "..\..MVC\Views\Blog\List.BlogList.cshtml"
           Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\r\n                <h3>\r\n");

            
            #line 25 "..\..MVC\Views\Blog\List.BlogList.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 25 "..\..MVC\Views\Blog\List.BlogList.cshtml"
                     if (!string.IsNullOrEmpty(detailPageUrl))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <a ");

            
            #line 27 "..\..MVC\Views\Blog\List.BlogList.cshtml"
                      Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(" href=\"");

            
            #line 27 "..\..MVC\Views\Blog\List.BlogList.cshtml"
                                                                                     Write(detailPageUrl);

            
            #line default
            #line hidden
WriteLiteral("\">");

            
            #line 27 "..\..MVC\Views\Blog\List.BlogList.cshtml"
                                                                                                     Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 28 "..\..MVC\Views\Blog\List.BlogList.cshtml"
                    }
                    else{

            
            #line default
            #line hidden
WriteLiteral("                        <span ");

            
            #line 30 "..\..MVC\Views\Blog\List.BlogList.cshtml"
                         Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 30 "..\..MVC\Views\Blog\List.BlogList.cshtml"
                                                                                  Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 31 "..\..MVC\Views\Blog\List.BlogList.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </h3>\r\n                \r\n");

            
            #line 34 "..\..MVC\Views\Blog\List.BlogList.cshtml"
                
            
            #line default
            #line hidden
            
            #line 34 "..\..MVC\Views\Blog\List.BlogList.cshtml"
                  
                    var lastPostDate = item.GetLastPostDate(lastPostDates);
                    if (lastPostDate != null && lastPostDate.HasValue)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <p");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 38 "..\..MVC\Views\Blog\List.BlogList.cshtml"
                                         Write(Html.Resource("LastPost"));

            
            #line default
            #line hidden
WriteLiteral(" : ");

            
            #line 38 "..\..MVC\Views\Blog\List.BlogList.cshtml"
                                                                      Write(lastPostDate.Value.ToShortDateString());

            
            #line default
            #line hidden
WriteLiteral(" </p>\r\n");

            
            #line 39 "..\..MVC\Views\Blog\List.BlogList.cshtml"
                    }
                
            
            #line default
            #line hidden
WriteLiteral("\r\n               \r\n            </li>\r\n");

            
            #line 43 "..\..MVC\Views\Blog\List.BlogList.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n\r\n");

            
            #line 46 "..\..MVC\Views\Blog\List.BlogList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 46 "..\..MVC\Views\Blog\List.BlogList.cshtml"
     if (Model.ShowPager)
    {
        
            
            #line default
            #line hidden
            
            #line 48 "..\..MVC\Views\Blog\List.BlogList.cshtml"
   Write(Html.Action("Index", "ContentPager", new
   {
       currentPage = Model.CurrentPage,
       totalPagesCount = Model.TotalPagesCount.Value,
       redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
   }));

            
            #line default
            #line hidden
            
            #line 53 "..\..MVC\Views\Blog\List.BlogList.cshtml"
     
    }

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591