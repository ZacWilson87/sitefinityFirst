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

namespace RealSiteFinityFirst.ResourcePackages.Custom.MVC.Views.SearchBox
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
    
    #line 10 "..\..\ResourcePackages\Custom\MVC\Views\SearchBox\SearchBox.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 9 "..\..\ResourcePackages\Custom\MVC\Views\SearchBox\SearchBox.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 8 "..\..\ResourcePackages\Custom\MVC\Views\SearchBox\SearchBox.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Custom/MVC/Views/SearchBox/SearchBox.cshtml")]
    public partial class SearchBox : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Search.Mvc.Models.ISearchBoxModel>
    {
        public SearchBox()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 11 "..\..\ResourcePackages\Custom\MVC\Views\SearchBox\SearchBox.cshtml"
  
    var searchTextBoxId = Guid.NewGuid();
    var searchButtonId = Guid.NewGuid();

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 15 "..\..\ResourcePackages\Custom\MVC\Views\SearchBox\SearchBox.cshtml"
Write(!String.IsNullOrEmpty(Model.CssClass) ?
        Html.Raw(String.Format("<div class=\"{0} form-inline\">", HttpUtility.HtmlAttributeEncode(Model.CssClass))) :
        Html.Raw("<div class=\"form-inline\">"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"form-group sf-search-input-wrapper\"");

WriteLiteral(" role=\"search\"");

WriteLiteral(">\r\n    <input");

WriteLiteral(" type=\"search\"");

WriteAttribute("title", Tuple.Create(" title=\"", 852), Tuple.Create("\"", 889)
            
            #line 19 "..\..\ResourcePackages\Custom\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 860), Tuple.Create<System.Object, System.Int32>(Html.Resource("SearchInput")
            
            #line default
            #line hidden
, 860), false)
);

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 890), Tuple.Create("\"", 925)
            
            #line 19 "..\..\ResourcePackages\Custom\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 904), Tuple.Create<System.Object, System.Int32>(Model.BackgroundHint
            
            #line default
            #line hidden
, 904), false)
);

WriteAttribute("id", Tuple.Create(" id=\"", 926), Tuple.Create("\"", 947)
            
            #line 19 "..\..\ResourcePackages\Custom\MVC\Views\SearchBox\SearchBox.cshtml"
                        , Tuple.Create(Tuple.Create("", 931), Tuple.Create<System.Object, System.Int32>(searchTextBoxId
            
            #line default
            #line hidden
, 931), false)
);

WriteLiteral(" class=\"form-control\"");

WriteAttribute("value", Tuple.Create(" value=\"", 969), Tuple.Create("\"", 999)
            
            #line 19 "..\..\ResourcePackages\Custom\MVC\Views\SearchBox\SearchBox.cshtml"
                                                                       , Tuple.Create(Tuple.Create("", 977), Tuple.Create<System.Object, System.Int32>(ViewBag.SearchQuery
            
            #line default
            #line hidden
, 977), false)
);

WriteLiteral(" aria-autocomplete=\"both\"");

WriteAttribute("aria-describedby", Tuple.Create(" aria-describedby=\'", 1025), Tuple.Create("\'", 1072)
            
            #line 19 "..\..\ResourcePackages\Custom\MVC\Views\SearchBox\SearchBox.cshtml"
                                                                                                                                        , Tuple.Create(Tuple.Create("", 1044), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("SearchInfo")
            
            #line default
            #line hidden
, 1044), false)
);

WriteLiteral(" />\r\n    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-primary ml-2\"");

WriteAttribute("id", Tuple.Create(" id=\"", 1132), Tuple.Create("\"", 1154)
            
            #line 20 "..\..\ResourcePackages\Custom\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1137), Tuple.Create<System.Object, System.Int32>(searchButtonId
            
            #line default
            #line hidden
, 1137), false)
);

WriteLiteral(" ");

            
            #line 20 "..\..\ResourcePackages\Custom\MVC\Views\SearchBox\SearchBox.cshtml"
                                                                          Write(SystemManager.IsDesignMode ? "disabled" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 20 "..\..\ResourcePackages\Custom\MVC\Views\SearchBox\SearchBox.cshtml"
                                                                                                                         Write(Html.Resource("SearchLabel"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n    <span");

WriteAttribute("id", Tuple.Create(" id=\'", 1253), Tuple.Create("\'", 1286)
            
            #line 21 "..\..\ResourcePackages\Custom\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1258), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("SearchInfo")
            
            #line default
            #line hidden
, 1258), false)
);

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(" hidden>When autocomplete results are available use up and down arrows to review " +
"and enter to select.</span>\r\n</div>\r\n\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"resultsUrl\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1472), Tuple.Create("\"", 1499)
            
            #line 24 "..\..\ResourcePackages\Custom\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1480), Tuple.Create<System.Object, System.Int32>(Model.ResultsUrl
            
            #line default
            #line hidden
, 1480), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"indexCatalogue\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1555), Tuple.Create("\"", 1586)
            
            #line 25 "..\..\ResourcePackages\Custom\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1563), Tuple.Create<System.Object, System.Int32>(Model.IndexCatalogue
            
            #line default
            #line hidden
, 1563), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"wordsMode\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1637), Tuple.Create("\"", 1674)
            
            #line 26 "..\..\ResourcePackages\Custom\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1645), Tuple.Create<System.Object, System.Int32>(Model.WordsMode.ToString()
            
            #line default
            #line hidden
, 1645), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"disableSuggestions\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1734), Tuple.Create("\'", 1792)
            
            #line 27 "..\..\ResourcePackages\Custom\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1742), Tuple.Create<System.Object, System.Int32>(Model.DisableSuggestions ? ("true") : ("false")
            
            #line default
            #line hidden
, 1742), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"minSuggestionLength\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1853), Tuple.Create("\"", 1889)
            
            #line 28 "..\..\ResourcePackages\Custom\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1861), Tuple.Create<System.Object, System.Int32>(Model.MinSuggestionLength
            
            #line default
            #line hidden
, 1861), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"suggestionFields\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1947), Tuple.Create("\"", 1980)
            
            #line 29 "..\..\ResourcePackages\Custom\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1955), Tuple.Create<System.Object, System.Int32>(Model.SuggestionFields
            
            #line default
            #line hidden
, 1955), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"language\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2030), Tuple.Create("\"", 2055)
            
            #line 30 "..\..\ResourcePackages\Custom\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 2038), Tuple.Create<System.Object, System.Int32>(Model.Language
            
            #line default
            #line hidden
, 2038), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"siteId\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2103), Tuple.Create("\"", 2157)
            
            #line 31 "..\..\ResourcePackages\Custom\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 2111), Tuple.Create<System.Object, System.Int32>(SystemManager.CurrentContext.CurrentSite.Id
            
            #line default
            #line hidden
, 2111), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"suggestionsRoute\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2215), Tuple.Create("\"", 2248)
            
            #line 32 "..\..\ResourcePackages\Custom\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 2223), Tuple.Create<System.Object, System.Int32>(Model.SuggestionsRoute
            
            #line default
            #line hidden
, 2223), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchTextBoxId\"");

WriteAttribute("value", Tuple.Create(" value=\'", 2305), Tuple.Create("\'", 2348)
            
            #line 33 "..\..\ResourcePackages\Custom\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 2313), Tuple.Create<System.Object, System.Int32>("#" + searchTextBoxId.ToString()
            
            #line default
            #line hidden
, 2313), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchButtonId\"");

WriteAttribute("value", Tuple.Create(" value=\'", 2404), Tuple.Create("\'", 2446)
            
            #line 34 "..\..\ResourcePackages\Custom\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 2412), Tuple.Create<System.Object, System.Int32>("#" + searchButtonId.ToString()
            
            #line default
            #line hidden
, 2412), false)
);

WriteLiteral(" />\r\n</div>\r\n\r\n");

WriteLiteral("\r\n");

            
            #line 38 "..\..\ResourcePackages\Custom\MVC\Views\SearchBox\SearchBox.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 39 "..\..\ResourcePackages\Custom\MVC\Views\SearchBox\SearchBox.cshtml"
Write(Html.Script(ScriptRef.JQueryUI, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 40 "..\..\ResourcePackages\Custom\MVC\Views\SearchBox\SearchBox.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/SearchBox/Search-box.js"), "bottom", true));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
