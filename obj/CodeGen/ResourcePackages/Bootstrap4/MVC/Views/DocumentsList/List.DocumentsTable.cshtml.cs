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

namespace RealSiteFinityFirst.ResourcePackages.Bootstrap4.MVC.Views.DocumentsList
{
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
    using System;
    
    #line default
    #line hidden
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
    
    #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Models.DocumentsList;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/DocumentsList/List.DocumentsTable.cshtml")]
    public partial class List_DocumentsTable : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Media.Mvc.Models.DocumentsList.DocumentsListViewModel>
    {
        public List_DocumentsTable()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 231), Tuple.Create("\"", 254)
            
            #line 7 "..\..\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
, Tuple.Create(Tuple.Create("", 239), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 239), false)
);

WriteLiteral(">\r\n\r\n    <div");

WriteLiteral(" class=\"sf-document-list sf-document-list--table\"");

WriteLiteral(">\r\n\r\n        <table");

WriteLiteral(" class=\"table\"");

WriteLiteral(">\r\n            <thead>\r\n                <tr>\r\n                    <td");

WriteLiteral(" scope=\"col\"");

WriteLiteral("><strong>");

            
            #line 14 "..\..\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
                                       Write(Html.Resource("Title"));

            
            #line default
            #line hidden
WriteLiteral("</strong></td>\r\n                    <td");

WriteLiteral(" scope=\"col\"");

WriteLiteral("><strong>");

            
            #line 15 "..\..\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
                                       Write(Html.Resource("Type"));

            
            #line default
            #line hidden
WriteLiteral("</strong></td>\r\n                    <td");

WriteLiteral(" scope=\"col\"");

WriteLiteral("><strong>");

            
            #line 16 "..\..\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
                                       Write(Html.Resource("Size"));

            
            #line default
            #line hidden
WriteLiteral("</strong></td>\r\n                    <td></td>\r\n                </tr>\r\n           " +
" </thead>\r\n");

            
            #line 20 "..\..\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
            
            
            #line default
            #line hidden
            
            #line 20 "..\..\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
             foreach (var item in Model.Items)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <th");

WriteLiteral(" scope=\"row\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"sf-icon-txt\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                            <svg");

WriteLiteral(" class=\"sf-icon-file sf-icon-sm\"");

WriteLiteral(">\r\n                                <use");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 1016), Tuple.Create("\"", 1093)
, Tuple.Create(Tuple.Create("", 1029), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap4/assets/dist/sprites/solid.svg#file")
, 1029), false)
);

WriteLiteral("></use>\r\n                            </svg>\r\n                            <span");

WriteAttribute("class", Tuple.Create(" class=\"", 1172), Tuple.Create("\"", 1249)
, Tuple.Create(Tuple.Create("", 1180), Tuple.Create("sf-icon-txt-sm", 1180), true)
, Tuple.Create(Tuple.Create(" ", 1194), Tuple.Create("sf-icon-txt-", 1195), true)
            
            #line 28 "..\..\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
, Tuple.Create(Tuple.Create("", 1207), Tuple.Create<System.Object, System.Int32>(((DocumentItemViewModel)item).Extension
            
            #line default
            #line hidden
, 1207), false)
);

WriteLiteral(">");

            
            #line 28 "..\..\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
                                                                                                            Write(((DocumentItemViewModel)item).Extension);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        </span>\r\n                        <a");

WriteLiteral(" class=\"sf-title\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1378), Tuple.Create("\"", 1492)
            
            #line 30 "..\..\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
, Tuple.Create(Tuple.Create("", 1385), Tuple.Create<System.Object, System.Int32>(HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix)
            
            #line default
            #line hidden
, 1385), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 31 "..\..\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
                       Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </a>\r\n                    </th>\r\n                    <t" +
"d>\r\n");

WriteLiteral("                        ");

            
            #line 35 "..\..\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
                    Write(((DocumentItemViewModel)item).Extension);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 38 "..\..\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
                    Write(Math.Ceiling((double)item.Fields.TotalSize / 1024) + " KB");

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a" +
"");

WriteAttribute("href", Tuple.Create(" href=\"", 1914), Tuple.Create("\"", 1942)
            
            #line 41 "..\..\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
, Tuple.Create(Tuple.Create("", 1921), Tuple.Create<System.Object, System.Int32>(item.Fields.MediaUrl
            
            #line default
            #line hidden
, 1921), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 41 "..\..\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
                                                                   Write(Html.Resource("Download"));

            
            #line default
            #line hidden
WriteLiteral("<span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 41 "..\..\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
                                                                                                                   Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</span></a>\r\n                    </td>\r\n                </tr>\r\n");

            
            #line 44 "..\..\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </table>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n");

            
            #line 51 "..\..\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
 if (Model.ShowPager)
{
    
            
            #line default
            #line hidden
            
            #line 53 "..\..\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
Write(Html.Action("Index", "ContentPager", new
       {
           currentPage = Model.CurrentPage,
           totalPagesCount = Model.TotalPagesCount.Value,
           redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
       }));

            
            #line default
            #line hidden
            
            #line 58 "..\..\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
         
}

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
