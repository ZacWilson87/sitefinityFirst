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

namespace RealSiteFinityFirst.ResourcePackages.Custom.MVC.Views.Video
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
    
    #line 8 "..\..MVC\Views\Video\Video.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 9 "..\..MVC\Views\Video\Video.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Video/Video.Default.cshtml")]
    public partial class Video_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Media.Mvc.Models.Video.VideoViewModel>
    {
        public Video_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 11 "..\..MVC\Views\Video\Video.Default.cshtml"
  
    var videoUrl = Model.Item.Fields.MediaUrl;
    var videoWidth = Model.AspectRatio.ToLowerInvariant() == "auto" ? string.Empty : string.Format("width={0}", Model.Width);
    var videoHeight = Model.AspectRatio.ToLowerInvariant() == "auto" ? string.Empty : string.Format("height={0}", Model.Height);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<figure");

WriteAttribute("class", Tuple.Create(" class=\"", 750), Tuple.Create("\"", 773)
            
            #line 17 "..\..MVC\Views\Video\Video.Default.cshtml"
, Tuple.Create(Tuple.Create("", 758), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 758), false)
);

WriteAttribute("aria-labelledby", Tuple.Create(" aria-labelledby=\"", 774), Tuple.Create("\"", 820)
            
            #line 17 "..\..MVC\Views\Video\Video.Default.cshtml"
, Tuple.Create(Tuple.Create("", 792), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("VideoTitle")
            
            #line default
            #line hidden
, 792), false)
);

WriteLiteral(">\r\n");

            
            #line 18 "..\..MVC\Views\Video\Video.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 18 "..\..MVC\Views\Video\Video.Default.cshtml"
     if (!string.IsNullOrEmpty(videoUrl))
    {

            
            #line default
            #line hidden
WriteLiteral("        <video");

WriteAttribute("src", Tuple.Create(" src=\"", 888), Tuple.Create("\"", 903)
            
            #line 20 "..\..MVC\Views\Video\Video.Default.cshtml"
, Tuple.Create(Tuple.Create("", 894), Tuple.Create<System.Object, System.Int32>(videoUrl
            
            #line default
            #line hidden
, 894), false)
);

WriteLiteral(" ");

            
            #line 20 "..\..MVC\Views\Video\Video.Default.cshtml"
                          Write(videoWidth);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 20 "..\..MVC\Views\Video\Video.Default.cshtml"
                                      Write(videoHeight);

            
            #line default
            #line hidden
WriteLiteral(" class=\"");

            
            #line 20 "..\..MVC\Views\Video\Video.Default.cshtml"
                                                          Write(String.Concat("sf", Model.Item.Fields.Extension));

            
            #line default
            #line hidden
WriteLiteral("\" controls=\"controls\" data-sf-role=\"playVideo\" aria-labelledby=\'");

            
            #line 20 "..\..MVC\Views\Video\Video.Default.cshtml"
                                                                                                                                                                           Write(Html.UniqueId("VideoTitle"));

            
            #line default
            #line hidden
WriteLiteral("\' aria-describedby=\'");

            
            #line 20 "..\..MVC\Views\Video\Video.Default.cshtml"
                                                                                                                                                                                                                           Write(Html.UniqueId("VideoInfo"));

            
            #line default
            #line hidden
WriteLiteral("\'></video>\r\n");

            
            #line 21 "..\..MVC\Views\Video\Video.Default.cshtml"
        

            
            #line default
            #line hidden
WriteLiteral("        <figcaption");

WriteAttribute("id", Tuple.Create(" id=\'", 1166), Tuple.Create("\'", 1199)
            
            #line 22 "..\..MVC\Views\Video\Video.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1171), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("VideoTitle")
            
            #line default
            #line hidden
, 1171), false)
);

WriteLiteral(">");

            
            #line 22 "..\..MVC\Views\Video\Video.Default.cshtml"
                                                 Write(Model.Item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</figcaption>\r\n");

WriteLiteral("        <p");

WriteAttribute("id", Tuple.Create(" id=\'", 1250), Tuple.Create("\'", 1282)
            
            #line 23 "..\..MVC\Views\Video\Video.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1255), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("VideoInfo")
            
            #line default
            #line hidden
, 1255), false)
);

WriteLiteral(">");

            
            #line 23 "..\..MVC\Views\Video\Video.Default.cshtml"
                                       Write(Model.Item.Fields.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 24 "..\..MVC\Views\Video\Video.Default.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</figure>");

        }
    }
}
#pragma warning restore 1591
