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

namespace RealSiteFinityFirst.ResourcePackages.Custom.MVC.Views.HierarchicalTaxonomy
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
    
    #line 8 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/HierarchicalTaxonomy/HierarchicalTaxonomy.CategoriesList.cshtml")]
    public partial class HierarchicalTaxonomy_CategoriesList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Taxonomies.Mvc.Models.TaxonomyViewModel>
    {
        public HierarchicalTaxonomy_CategoriesList()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n<ul");

WriteAttribute("class", Tuple.Create(" class=\"", 392), Tuple.Create("\"", 429)
            
            #line 10 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
, Tuple.Create(Tuple.Create("", 400), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 400), false)
, Tuple.Create(Tuple.Create(" ", 415), Tuple.Create("list-unstyled", 416), true)
);

WriteLiteral(">\r\n");

            
            #line 11 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 11 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
     foreach (var taxon in Model.Taxa)
    {

            
            #line default
            #line hidden
WriteLiteral("        <li>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 508), Tuple.Create("\"", 525)
            
            #line 14 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
, Tuple.Create(Tuple.Create("", 515), Tuple.Create<System.Object, System.Int32>(taxon.Url
            
            #line default
            #line hidden
, 515), false)
);

WriteLiteral(">");

            
            #line 14 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
                            Write(taxon.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n\r\n");

            
            #line 16 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
            
            
            #line default
            #line hidden
            
            #line 16 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
             if (Model.ShowItemCount)
            {

            
            #line default
            #line hidden
WriteLiteral("                <span");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 18 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
                                    Write(Html.HtmlSanitize(string.Format("({0})", taxon.Count)));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 19 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </li>\r\n");

            
            #line 21 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</ul>\r\n");

        }
    }
}
#pragma warning restore 1591
