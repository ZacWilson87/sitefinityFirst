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

namespace RealSiteFinityFirst.ResourcePackages.Bootstrap4.MVC.Views.FileField
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/FileField/Write.Default.cshtml")]
    public partial class Write_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.FileField.FileFieldViewModel>
    {
        public Write_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 7 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
  
    var isRequired = Model.IsRequired ? "true" : "false";
    var hasDescription = !string.IsNullOrEmpty(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 369), Tuple.Create("\"", 416)
            
            #line 11 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 377), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 377), false)
, Tuple.Create(Tuple.Create(" ", 392), Tuple.Create("sf-FileField", 393), true)
, Tuple.Create(Tuple.Create(" ", 405), Tuple.Create("form-group", 406), true)
);

WriteLiteral(" data-sf-role=\"file-field-container\"");

WriteLiteral(" data-sf-config=\"");

            
            #line 11 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
                                                                                                     Write(Html.AttributeEncode(Model.Serialize()));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" class=\"h6\"");

WriteAttribute("for", Tuple.Create(" for=\'", 537), Tuple.Create("\'", 571)
            
            #line 12 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 543), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("FileUpload")
            
            #line default
            #line hidden
, 543), false)
);

WriteLiteral(">");

            
            #line 12 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
                                                    Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n    <div");

WriteLiteral(" data-sf-role=\"file-field-inputs\"");

WriteLiteral(">\r\n");

            
            #line 14 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
        
            
            #line default
            #line hidden
            
            #line 14 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
         if (!SystemManager.IsDesignMode || SystemManager.IsPreviewMode)
        {

            
            #line default
            #line hidden
WriteLiteral("            ");

WriteLiteral("<script type=\"text/template\" data-sf-role=\"file-input-template\">\r\n");

            
            #line 17 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" data-sf-role=\"single-file-input\"");

WriteLiteral(">\r\n            <input");

WriteAttribute("id", Tuple.Create(" id=\'", 895), Tuple.Create("\'", 928)
            
            #line 19 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 900), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("FileUpload")
            
            #line default
            #line hidden
, 900), false)
);

WriteLiteral("\r\n                   title=\"file\"");

WriteLiteral("\r\n                   type=\"file\"");

WriteAttribute("name", Tuple.Create("\r\n                   name=\"", 994), Tuple.Create("\"", 1049)
            
            #line 22 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1021), Tuple.Create<System.Object, System.Int32>(Model.MetaField.FieldName
            
            #line default
            #line hidden
, 1021), false)
);

WriteLiteral("\r\n                   ");

            
            #line 23 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
              Write(Html.Raw(Model.ValidationAttributes));

            
            #line default
            #line hidden
WriteLiteral("\r\n                   class=\"sf-FileField-input\"\r\n                   aria-required" +
"=\"");

            
            #line 25 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
                             Write(isRequired);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n");

            
            #line 26 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
                   
            
            #line default
            #line hidden
            
            #line 26 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
                     if (hasDescription) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" aria-describedby=\'");

            
            #line 26 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
                                                               Write(Html.UniqueId("FileUploadInfo"));

            
            #line default
            #line hidden
WriteLiteral("\' ");

WriteLiteral("  ");

            
            #line 26 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
                                                                                                               } 
            
            #line default
            #line hidden
WriteLiteral(">\r\n");

            
            #line 27 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
            
            
            #line default
            #line hidden
            
            #line 27 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
             if (Model.AllowMultipleFiles || SystemManager.IsPreviewMode)
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteLiteral(" href=\"javascript:void(0);\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(" data-sf-role=\"remove-input\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 1508), Tuple.Create("\"", 1545)
            
            #line 29 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
                             , Tuple.Create(Tuple.Create("", 1521), Tuple.Create<System.Object, System.Int32>(Html.Resource("Remove")
            
            #line default
            #line hidden
, 1521), false)
);

WriteLiteral(">\r\n                    <svg");

WriteLiteral(" class=\"sf-icon-xs sf-icon-remove\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                        <use");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 1680), Tuple.Create("\"", 1765)
, Tuple.Create(Tuple.Create("", 1693), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap4/assets/dist/sprites/solid.svg#times-circle")
, 1693), false)
);

WriteLiteral("></use>\r\n                    </svg>\r\n");

WriteLiteral("                    ");

            
            #line 33 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
               Write(Html.Resource("Remove"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </a>\r\n");

            
            #line 35 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 36 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
             if (Model.AcceptedFileTypes.Length > 0)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" data-sf-role=\"filetype-violation-message\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">");

            
            #line 38 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
                                                                                                                                        Write(Model.FileTypeViolationMessage);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 39 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 40 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
             if (Model.MinFileSizeInMb > 0 || Model.MaxFileSizeInMb > 0)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" data-sf-role=\"filesize-violation-message\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">");

            
            #line 42 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
                                                                                                                                        Write(Model.FileSizeViolationMessage);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 43 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n");

            
            #line 45 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
        
            
            #line default
            #line hidden
            
            #line 45 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
         if (!SystemManager.IsDesignMode)
        {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("</script>\r\n");

            
            #line 48 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
    }

    
            
            #line default
            #line hidden
            
            #line 50 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
                                            

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n");

            
            #line 52 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 52 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
     if (Model.AllowMultipleFiles)
    {

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteLiteral(" href=\"javascript:void(0);\"");

WriteLiteral(" data-sf-role=\"add-input\"");

WriteLiteral(">");

            
            #line 54 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
                                                          Write(Html.Resource("AddAnother"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 55 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" data-sf-role=\"required-violation-message\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">");

            
            #line 56 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
                                                                                                                            Write(Model.RequiredViolationMessage);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 57 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 57 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
     if (hasDescription)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteLiteral(" class=\"text-muted\"");

WriteAttribute("id", Tuple.Create(" id=\'", 2969), Tuple.Create("\'", 3006)
            
            #line 59 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2974), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("FileUploadInfo")
            
            #line default
            #line hidden
, 2974), false)
);

WriteLiteral(">");

            
            #line 59 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
                                                               Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 60 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 62 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
 if (!SystemManager.IsDesignMode || SystemManager.IsPreviewMode)
{
    
            
            #line default
            #line hidden
            
            #line 64 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
            
            #line 64 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
                                                
    
            
            #line default
            #line hidden
            
            #line 65 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Form/form.all.js"), "bottom", false));

            
            #line default
            #line hidden
            
            #line 65 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FileField\Write.Default.cshtml"
                                                                                    
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
