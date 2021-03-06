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

namespace RealSiteFinityFirst.ResourcePackages.Custom.MVC.Views.ImageGallery
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
    
    #line 8 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 10 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 12 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Models.ImageGallery;
    
    #line default
    #line hidden
    
    #line 9 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 11 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/ImageGallery/List.ImageGallery.cshtml")]
    public partial class List_ImageGallery : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_ImageGallery()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n<div");

WriteLiteral(" class=\"sf-Gallery-thumbs-container\"");

WriteLiteral(">\r\n  <ul");

WriteAttribute("class", Tuple.Create(" class=\"", 621), Tuple.Create("\"", 676)
, Tuple.Create(Tuple.Create("", 629), Tuple.Create("sf-Gallery-thumbs", 629), true)
, Tuple.Create(Tuple.Create(" ", 646), Tuple.Create("list-unstyled", 647), true)
            
            #line 15 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
, Tuple.Create(Tuple.Create(" ", 660), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 661), false)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 677), Tuple.Create("\"", 720)
            
            #line 15 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
, Tuple.Create(Tuple.Create("", 690), Tuple.Create<System.Object, System.Int32>(Html.Resource("ImageGallery")
            
            #line default
            #line hidden
, 690), false)
);

WriteLiteral(">\r\n\r\n");

            
            #line 17 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
    
            
            #line default
            #line hidden
            
            #line 17 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
     for (int i = 0; i < Model.Items.Count(); i++)
    {
        var item = Model.Items.ElementAt(i);
        var thumbnailViewModel = (ThumbnailViewModel)item;

        var itemIndex = (Model.CurrentPage - 1) * ViewBag.ItemsPerPage + i + 1;
        var detailPageUrl = ViewBag.OpenInSamePage ? HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix, itemIndex) :
            HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix);

            
            #line default
            #line hidden
WriteLiteral("        <li");

WriteLiteral(" class=\"d-inline-block\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" class=\"text-center\"");

WriteAttribute("href", Tuple.Create("\r\n               href=\"", 1340), Tuple.Create("\"", 1377)
            
            #line 27 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1363), Tuple.Create<System.Object, System.Int32>(detailPageUrl
            
            #line default
            #line hidden
, 1363), false)
);

WriteAttribute("title", Tuple.Create("\r\n               title=\"", 1378), Tuple.Create("\"", 1440)
, Tuple.Create(Tuple.Create("", 1402), Tuple.Create("Go", 1402), true)
, Tuple.Create(Tuple.Create(" ", 1404), Tuple.Create("to", 1405), true)
, Tuple.Create(Tuple.Create(" ", 1407), Tuple.Create("image", 1408), true)
            
            #line 28 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
, Tuple.Create(Tuple.Create(" ", 1413), Tuple.Create<System.Object, System.Int32>(item.Fields.Title
            
            #line default
            #line hidden
, 1414), false)
, Tuple.Create(Tuple.Create(" ", 1432), Tuple.Create("details", 1433), true)
);

WriteLiteral(">\r\n                <img");

WriteLiteral(" loading=\"lazy\"");

WriteAttribute("src", Tuple.Create(" src=\"", 1479), Tuple.Create("\"", 1519)
            
            #line 29 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1485), Tuple.Create<System.Object, System.Int32>(thumbnailViewModel.ThumbnailUrl
            
            #line default
            #line hidden
, 1485), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\'", 1520), Tuple.Create("\'", 1618)
            
            #line 29 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
  , Tuple.Create(Tuple.Create("", 1526), Tuple.Create<System.Object, System.Int32>(System.Text.RegularExpressions.Regex.Replace(item.Fields.AlternativeText, @"[^\w\d_-]", "")
            
            #line default
            #line hidden
, 1526), false)
);

WriteLiteral("\r\n                     ");

            
            #line 30 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
                Write(Html.GetWidthAttributeIfExists(thumbnailViewModel.Width));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                     ");

            
            #line 31 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
                Write(Html.GetHeightAttributeIfExists(thumbnailViewModel.Height));

            
            #line default
            #line hidden
WriteLiteral(" />\r\n            </a>\r\n        </li>\r\n");

            
            #line 34 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("  </ul>\r\n</div>\r\n\r\n");

            
            #line 38 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
 if (Model.ShowPager)
{
    
            
            #line default
            #line hidden
            
            #line 40 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
Write(Html.Action("Index", "ContentPager", new
       {
           currentPage = Model.CurrentPage,
           totalPagesCount = Model.TotalPagesCount.Value,
           redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
       }));

            
            #line default
            #line hidden
            
            #line 45 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
         
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
