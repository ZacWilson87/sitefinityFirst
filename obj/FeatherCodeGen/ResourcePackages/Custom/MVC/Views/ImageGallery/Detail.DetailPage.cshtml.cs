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
    
    #line 8 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 9 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 10 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 11 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
    using Telerik.Sitefinity.Web.DataResolving;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/ImageGallery/Detail.DetailPage.cshtml")]
    public partial class Detail_DetailPage : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Media.Mvc.Models.ImageGallery.ImageDetailsViewModel>
    {
        public Detail_DetailPage()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 533), Tuple.Create("\"", 556)
            
            #line 13 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 541), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 541), false)
);

WriteLiteral(" ");

            
            #line 13 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                        Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)Model.Item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\r\n    <figure");

WriteAttribute("aria-labelledby", Tuple.Create(" aria-labelledby=\"", 677), Tuple.Create("\"", 725)
            
            #line 14 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 695), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("ImageCaption")
            
            #line default
            #line hidden
, 695), false)
);

WriteLiteral(">    \r\n        <figcaption");

WriteLiteral(" class=\"h2\"");

WriteAttribute("id", Tuple.Create(" id=\"", 763), Tuple.Create("\"", 798)
            
            #line 15 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 768), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("ImageCaption")
            
            #line default
            #line hidden
, 768), false)
);

WriteLiteral(" ");

            
            #line 15 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                                              Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 15 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                                                                                                       Write(Model.Item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</figcaption>        \r\n        <div");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\r\n            <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 17 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                             Write(Html.Resource("ImageTakenOn"));

            
            #line default
            #line hidden
WriteLiteral(" </span>\r\n");

WriteLiteral("            ");

            
            #line 18 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
       Write(Model.Item.GetDateTime("PublicationDate", "MMM d, yyyy, HH:mm tt"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 19 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
       Write(Html.Resource("By"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 20 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
       Write(DataResolver.Resolve(@Model.Item.DataItem, "Author", null));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n");

WriteLiteral("        ");

            
            #line 23 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
   Write(Html.CommentsCount(string.Empty, @Model.Item.DataItem));

            
            #line default
            #line hidden
WriteLiteral("\r\n        \r\n        <p");

WriteAttribute("id", Tuple.Create(" id=\"", 1303), Tuple.Create("\"", 1342)
            
            #line 25 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 1308), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("ImageDescription")
            
            #line default
            #line hidden
, 1308), false)
);

WriteLiteral(" ");

            
            #line 25 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                              Write(Html.InlineEditingFieldAttributes("Description", "LongText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 25 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                                                                                            Write(Html.HtmlSanitize((string)Model.Item.Fields.Description));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        <img");

WriteLiteral(" loading=\"lazy\"");

WriteAttribute("aria-describedby", Tuple.Create(" aria-describedby=\"", 1496), Tuple.Create("\"", 1549)
            
            #line 26 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 1515), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("ImageDescription")
            
            #line default
            #line hidden
, 1515), false)
);

WriteAttribute("src", Tuple.Create(" src=\"", 1550), Tuple.Create("\"", 1581)
            
            #line 26 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
       , Tuple.Create(Tuple.Create("", 1556), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.MediaUrl)
            
            #line default
            #line hidden
, 1556), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\'", 1582), Tuple.Create("\'", 1686)
            
            #line 26 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                       , Tuple.Create(Tuple.Create("", 1588), Tuple.Create<System.Object, System.Int32>(System.Text.RegularExpressions.Regex.Replace(Model.Item.Fields.AlternativeText, @"[^\w\d_-]", "")
            
            #line default
            #line hidden
, 1588), false)
);

WriteLiteral("\r\n             ");

            
            #line 27 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
        Write(Html.GetWidthAttributeIfExists(Model.Width));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("             ");

            
            #line 28 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
        Write(Html.GetHeightAttributeIfExists(Model.Height));

            
            #line default
            #line hidden
WriteLiteral(" />\r\n    </figure>\r\n\r\n");

            
            #line 31 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
    
            
            #line default
            #line hidden
            
            #line 31 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
     if (ViewBag.ItemIndex != null)
    {

            
            #line default
            #line hidden
WriteLiteral("        <nav");

WriteLiteral(" role=\"navigation\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 1903), Tuple.Create("\"", 1951)
            
            #line 33 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 1916), Tuple.Create<System.Object, System.Int32>(Html.Resource("PreviousNextImage")
            
            #line default
            #line hidden
, 1916), false)
);

WriteLiteral(" class=\"text-center clearfix\"");

WriteLiteral(">\r\n");

            
            #line 34 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
            
            
            #line default
            #line hidden
            
            #line 34 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
              
                var previousItemIndex = ViewBag.ItemIndex == 1 ? Model.TotalItemsCount : ViewBag.ItemIndex - 1;
                var nextItemIndex = ViewBag.ItemIndex == Model.TotalItemsCount ? 1 : ViewBag.ItemIndex + 1;
            
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 39 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
            
            
            #line default
            #line hidden
            
            #line 39 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
             if (Model.PreviousItem != null)
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteLiteral(" class=\"sf-Gallery-prev--simple\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 2350), Tuple.Create("\"", 2398)
            
            #line 41 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 2363), Tuple.Create<System.Object, System.Int32>(Html.Resource("GoToPreviousImage")
            
            #line default
            #line hidden
, 2363), false)
);

WriteAttribute("href", Tuple.Create(" href=\"", 2399), Tuple.Create("\"", 2548)
            
            #line 41 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                          , Tuple.Create(Tuple.Create("", 2406), Tuple.Create<System.Object, System.Int32>(HyperLinkHelpers.GetDetailPageUrl(Model.PreviousItem, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, ViewBag.UrlKeyPrefix, previousItemIndex)
            
            #line default
            #line hidden
, 2406), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 42 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
               Write(Html.Resource("PreviousImage"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </a>\r\n");

            
            #line 44 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 46 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
            
            
            #line default
            #line hidden
            
            #line 46 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
             if (Model.PreviousItem != null || @Model.NextItem != null)
            {
                string.Format(@Html.Resource("IndexOfTotal"), @ViewBag.ItemIndex, @Model.TotalItemsCount);
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 51 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
            
            
            #line default
            #line hidden
            
            #line 51 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
             if (Model.NextItem != null) 
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteLiteral(" class=\"sf-Gallery-next--simple\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 2965), Tuple.Create("\"", 3009)
            
            #line 53 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 2978), Tuple.Create<System.Object, System.Int32>(Html.Resource("GoToNextImage")
            
            #line default
            #line hidden
, 2978), false)
);

WriteAttribute("href", Tuple.Create(" href=\"", 3010), Tuple.Create("\"", 3151)
            
            #line 53 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                      , Tuple.Create(Tuple.Create("", 3017), Tuple.Create<System.Object, System.Int32>(HyperLinkHelpers.GetDetailPageUrl(Model.NextItem, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, ViewBag.UrlKeyPrefix, nextItemIndex)
            
            #line default
            #line hidden
, 3017), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 54 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
               Write(Html.Resource("NextImage"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </a>\r\n");

            
            #line 56 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </nav>\r\n");

            
            #line 58 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"

        
            
            #line default
            #line hidden
            
            #line 59 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
   Write(Html.ActionLink(Html.Resource("BackToAllImages"), "Index"));

            
            #line default
            #line hidden
            
            #line 59 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                                                   
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 62 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
Write(Html.CommentsList(@Model.Item.DataItem));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n</div>");

        }
    }
}
#pragma warning restore 1591