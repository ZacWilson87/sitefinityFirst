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

namespace RealSiteFinityFirst.ResourcePackages.Custom.MVC.Views.Form
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
    
    #line 9 "..\..\ResourcePackages\Custom\MVC\Views\Form\Index.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 10 "..\..\ResourcePackages\Custom\MVC\Views\Form\Index.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 11 "..\..\ResourcePackages\Custom\MVC\Views\Form\Index.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 12 "..\..\ResourcePackages\Custom\MVC\Views\Form\Index.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 8 "..\..\ResourcePackages\Custom\MVC\Views\Form\Index.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Custom/MVC/Views/Form/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.FormViewModel>
    {
        public Index()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n<div");

WriteLiteral(" data-sf-role=\"form-container\"");

WriteAttribute("class", Tuple.Create(" class=\"", 600), Tuple.Create("\"", 623)
            
            #line 14 "..\..\ResourcePackages\Custom\MVC\Views\Form\Index.cshtml"
, Tuple.Create(Tuple.Create("", 608), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 608), false)
);

WriteLiteral(">\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"form-id\"");

WriteAttribute("value", Tuple.Create(" value=\"", 674), Tuple.Create("\"", 695)
            
            #line 15 "..\..\ResourcePackages\Custom\MVC\Views\Form\Index.cshtml"
, Tuple.Create(Tuple.Create("", 682), Tuple.Create<System.Object, System.Int32>(Model.FormId
            
            #line default
            #line hidden
, 682), false)
);

WriteLiteral(" name=\"FormId\"");

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"marketo-settings\"");

WriteAttribute("value", Tuple.Create(" value=\"", 771), Tuple.Create("\"", 801)
            
            #line 16 "..\..\ResourcePackages\Custom\MVC\Views\Form\Index.cshtml"
, Tuple.Create(Tuple.Create("", 779), Tuple.Create<System.Object, System.Int32>(Model.MarketoSettings
            
            #line default
            #line hidden
, 779), false)
);

WriteLiteral(" name=\"MarketoSettings\"");

WriteLiteral(" />\r\n\r\n");

            
            #line 18 "..\..\ResourcePackages\Custom\MVC\Views\Form\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 18 "..\..\ResourcePackages\Custom\MVC\Views\Form\Index.cshtml"
      
        if (!string.IsNullOrEmpty(@ViewBag.ErrorMessage))
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">");

            
            #line 21 "..\..\ResourcePackages\Custom\MVC\Views\Form\Index.cshtml"
                                                                          Write(ViewBag.ErrorMessage);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 22 "..\..\ResourcePackages\Custom\MVC\Views\Form\Index.cshtml"
        }

        if (Model.UseAjaxSubmit)
        {

            
            #line default
            #line hidden
WriteLiteral("            <span");

WriteLiteral(" data-sf-role=\"success-message\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">");

            
            #line 26 "..\..\ResourcePackages\Custom\MVC\Views\Form\Index.cshtml"
                                                                   Write(Model.SuccessMessage);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

WriteLiteral("            <span");

WriteLiteral(" data-sf-role=\"error-message\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral("></span>\r\n");

WriteLiteral("            <img");

WriteLiteral(" data-sf-role=\"loading-img\"");

WriteAttribute("src", Tuple.Create(" src=\'", 1300), Tuple.Create("\'", 1448)
            
            #line 28 "..\..\ResourcePackages\Custom\MVC\Views\Form\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1306), Tuple.Create<System.Object, System.Int32>(Url.EmbeddedResource("Telerik.Sitefinity.Resources.Reference", "Telerik.Sitefinity.Resources.Themes.Light.Images.Loadings.sfLoadingData.gif")
            
            #line default
            #line hidden
, 1306), false)
);

WriteLiteral(" alt=\"Loading animation\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral(" />\r\n");

WriteLiteral("            <div");

WriteLiteral(" data-sf-role=\"fields-container\"");

WriteLiteral(">\r\n                ");

WriteLiteral("\r\n            </div>\r\n");

            
            #line 32 "..\..\ResourcePackages\Custom\MVC\Views\Form\Index.cshtml"
        }
        else
        {
            using (Html.BeginFormSitefinity("", null, (System.Web.Routing.RouteValueDictionary)null, FormMethod.Post, new Dictionary<string, object> { { "enctype", "multipart/form-data" }, { "role", "form" } }, true))
            {
                
            
            #line default
            #line hidden
            
            #line 37 "..\..\ResourcePackages\Custom\MVC\Views\Form\Index.cshtml"
                                   
            }
        }

        if (Model.UseAjaxSubmit)
        {

            
            #line default
            #line hidden
WriteLiteral("            <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"ajax-submit-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2051), Tuple.Create("\"", 2079)
            
            #line 43 "..\..\ResourcePackages\Custom\MVC\Views\Form\Index.cshtml"
, Tuple.Create(Tuple.Create("", 2059), Tuple.Create<System.Object, System.Int32>(Model.AjaxSubmitUrl
            
            #line default
            #line hidden
, 2059), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("            <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"redirect-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2145), Tuple.Create("\"", 2171)
            
            #line 44 "..\..\ResourcePackages\Custom\MVC\Views\Form\Index.cshtml"
, Tuple.Create(Tuple.Create("", 2153), Tuple.Create<System.Object, System.Int32>(Model.RedirectUrl
            
            #line default
            #line hidden
, 2153), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("            <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"widget-id\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2234), Tuple.Create("\"", 2259)
            
            #line 45 "..\..\ResourcePackages\Custom\MVC\Views\Form\Index.cshtml"
, Tuple.Create(Tuple.Create("", 2242), Tuple.Create<System.Object, System.Int32>(ViewBag.WidgetId
            
            #line default
            #line hidden
, 2242), false)
);

WriteLiteral(" name=\"WidgetId\"");

WriteLiteral(" />\r\n");

            
            #line 46 "..\..\ResourcePackages\Custom\MVC\Views\Form\Index.cshtml"
            
            
            #line default
            #line hidden
            
            #line 46 "..\..\ResourcePackages\Custom\MVC\Views\Form\Index.cshtml"
       Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
            
            #line 46 "..\..\ResourcePackages\Custom\MVC\Views\Form\Index.cshtml"
                                                        
            
            
            #line default
            #line hidden
            
            #line 47 "..\..\ResourcePackages\Custom\MVC\Views\Form\Index.cshtml"
       Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Form/form.all.js"), "bottom", false));

            
            #line default
            #line hidden
            
            #line 47 "..\..\ResourcePackages\Custom\MVC\Views\Form\Index.cshtml"
                                                                                            
        }
    
            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
