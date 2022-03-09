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

namespace RealSiteFinityFirst.ResourcePackages.Bootstrap4.MVC.Views.Form
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
    
    #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Form\Index.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Form\Index.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Form\Index.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 7 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Form\Index.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Form\Index.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/Form/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.FormViewModel>
    {
        public Index()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteLiteral(" data-sf-role=\"form-container\"");

WriteAttribute("class", Tuple.Create(" class=\"", 332), Tuple.Create("\"", 355)
            
            #line 9 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Form\Index.cshtml"
, Tuple.Create(Tuple.Create("", 340), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 340), false)
);

WriteLiteral(">\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"form-id\"");

WriteAttribute("value", Tuple.Create(" value=\"", 406), Tuple.Create("\"", 427)
            
            #line 10 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Form\Index.cshtml"
, Tuple.Create(Tuple.Create("", 414), Tuple.Create<System.Object, System.Int32>(Model.FormId
            
            #line default
            #line hidden
, 414), false)
);

WriteLiteral(" name=\"FormId\"");

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"marketo-settings\"");

WriteAttribute("value", Tuple.Create(" value=\"", 503), Tuple.Create("\"", 533)
            
            #line 11 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Form\Index.cshtml"
, Tuple.Create(Tuple.Create("", 511), Tuple.Create<System.Object, System.Int32>(Model.MarketoSettings
            
            #line default
            #line hidden
, 511), false)
);

WriteLiteral(" name=\"MarketoSettings\"");

WriteLiteral(" />\r\n\r\n");

            
            #line 13 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Form\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 13 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Form\Index.cshtml"
      
        if (!string.IsNullOrEmpty(@ViewBag.ErrorMessage))
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">");

            
            #line 16 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Form\Index.cshtml"
                                                                          Write(ViewBag.ErrorMessage);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 17 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Form\Index.cshtml"
        }

        if (Model.UseAjaxSubmit)
        {

            
            #line default
            #line hidden
WriteLiteral("            <span");

WriteLiteral(" data-sf-role=\"success-message\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">");

            
            #line 21 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Form\Index.cshtml"
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

WriteAttribute("src", Tuple.Create(" src=\'", 1032), Tuple.Create("\'", 1180)
            
            #line 23 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Form\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1038), Tuple.Create<System.Object, System.Int32>(Url.EmbeddedResource("Telerik.Sitefinity.Resources.Reference", "Telerik.Sitefinity.Resources.Themes.Light.Images.Loadings.sfLoadingData.gif")
            
            #line default
            #line hidden
, 1038), false)
);

WriteLiteral(" alt=\"Loading animation\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral(" />\r\n");

WriteLiteral("            <div");

WriteLiteral(" data-sf-role=\"fields-container\"");

WriteLiteral(">\r\n                ");

WriteLiteral("\r\n            </div>\r\n");

            
            #line 27 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Form\Index.cshtml"
        }
        else
        {
            using (Html.BeginFormSitefinity("", null, (System.Web.Routing.RouteValueDictionary)null, FormMethod.Post, new Dictionary<string, object> { { "enctype", "multipart/form-data" }, { "role", "form" } }, true))
            {
                
            
            #line default
            #line hidden
            
            #line 32 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Form\Index.cshtml"
                                   
            }
        }

        if (Model.UseAjaxSubmit)
        {

            
            #line default
            #line hidden
WriteLiteral("            <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"ajax-submit-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1783), Tuple.Create("\"", 1811)
            
            #line 38 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Form\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1791), Tuple.Create<System.Object, System.Int32>(Model.AjaxSubmitUrl
            
            #line default
            #line hidden
, 1791), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("            <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"redirect-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1877), Tuple.Create("\"", 1903)
            
            #line 39 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Form\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1885), Tuple.Create<System.Object, System.Int32>(Model.RedirectUrl
            
            #line default
            #line hidden
, 1885), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("            <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"widget-id\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1966), Tuple.Create("\"", 1991)
            
            #line 40 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Form\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1974), Tuple.Create<System.Object, System.Int32>(ViewBag.WidgetId
            
            #line default
            #line hidden
, 1974), false)
);

WriteLiteral(" name=\"WidgetId\"");

WriteLiteral(" />\r\n");

            
            #line 41 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Form\Index.cshtml"
            
            
            #line default
            #line hidden
            
            #line 41 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Form\Index.cshtml"
       Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
            
            #line 41 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Form\Index.cshtml"
                                                        
            
            
            #line default
            #line hidden
            
            #line 42 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Form\Index.cshtml"
       Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Form/form.all.js"), "bottom", false));

            
            #line default
            #line hidden
            
            #line 42 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Form\Index.cshtml"
                                                                                            
        }
    
            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\n");

        }
    }
}
#pragma warning restore 1591
