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

namespace RealSiteFinityFirst.ResourcePackages.Bootstrap4.MVC.Views.UsersList
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\UsersList\Detail.UserDetails.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 7 "..\..\ResourcePackages\Bootstrap4\MVC\Views\UsersList\Detail.UserDetails.cshtml"
    using Telerik.Sitefinity.Frontend.Identity.Mvc.Models.UsersList;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap4\MVC\Views\UsersList\Detail.UserDetails.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\UsersList\Detail.UserDetails.cshtml"
    using Telerik.Sitefinity.Security.Claims;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\UsersList\Detail.UserDetails.cshtml"
    using Telerik.Sitefinity.Security.Model;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/UsersList/Detail.UserDetails.cshtml")]
    public partial class Detail_UserDetails : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.UsersList.UserDetailsViewModel>
    {
        public Detail_UserDetails()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 9 "..\..\ResourcePackages\Bootstrap4\MVC\Views\UsersList\Detail.UserDetails.cshtml"
  
    bool isAuthenticated = false;

    var user = ClaimsManager.GetCurrentIdentity();
    if (user != null)
    {
        isAuthenticated = user.IsAuthenticated;
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 510), Tuple.Create("\"", 548)
            
            #line 19 "..\..\ResourcePackages\Bootstrap4\MVC\Views\UsersList\Detail.UserDetails.cshtml"
, Tuple.Create(Tuple.Create("", 518), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 518), false)
, Tuple.Create(Tuple.Create(" ", 533), Tuple.Create("media", 534), true)
, Tuple.Create(Tuple.Create(" ", 539), Tuple.Create("sf-media", 540), true)
);

WriteLiteral(">\r\n\r\n");

            
            #line 21 "..\..\ResourcePackages\Bootstrap4\MVC\Views\UsersList\Detail.UserDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 21 "..\..\ResourcePackages\Bootstrap4\MVC\Views\UsersList\Detail.UserDetails.cshtml"
     if (isAuthenticated)
    {


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"media-left pr-2 sf-img-thmb\"");

WriteLiteral(">\r\n            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 657), Tuple.Create("\"", 725)
            
            #line 25 "..\..\ResourcePackages\Bootstrap4\MVC\Views\UsersList\Detail.UserDetails.cshtml"
, Tuple.Create(Tuple.Create("", 663), Tuple.Create<System.Object, System.Int32>(((SitefinityProfileItemViewModel)Model.Item).AvatarImageUrl
            
            #line default
            #line hidden
, 663), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 726), Tuple.Create("\"", 760)
            
            #line 25 "..\..\ResourcePackages\Bootstrap4\MVC\Views\UsersList\Detail.UserDetails.cshtml"
            , Tuple.Create(Tuple.Create("", 732), Tuple.Create<System.Object, System.Int32>(Model.Item.Fields.FirstName
            
            #line default
            #line hidden
, 732), false)
);

WriteLiteral(" width=\"100\"");

WriteLiteral(" height=\"100\"");

WriteLiteral(" />\r\n        </div>\r\n");

            
            #line 27 "..\..\ResourcePackages\Bootstrap4\MVC\Views\UsersList\Detail.UserDetails.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"media-body sf-media-body\"");

WriteLiteral(">\r\n            <h3>");

            
            #line 29 "..\..\ResourcePackages\Bootstrap4\MVC\Views\UsersList\Detail.UserDetails.cshtml"
            Write((Model.Item.DataItem as SitefinityProfile).GetUserDisplayName());

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n            <p>");

            
            #line 30 "..\..\ResourcePackages\Bootstrap4\MVC\Views\UsersList\Detail.UserDetails.cshtml"
           Write((Model.Item.DataItem as SitefinityProfile).User.Email);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n            <p>");

            
            #line 31 "..\..\ResourcePackages\Bootstrap4\MVC\Views\UsersList\Detail.UserDetails.cshtml"
          Write(Html.HtmlSanitize((((SitefinityProfileItemViewModel)Model.Item).About)));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        </div>\r\n");

            
            #line 33 "..\..\ResourcePackages\Bootstrap4\MVC\Views\UsersList\Detail.UserDetails.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <p>");

            
            #line 36 "..\..\ResourcePackages\Bootstrap4\MVC\Views\UsersList\Detail.UserDetails.cshtml"
      Write(Html.Resource("NotLoggedInUser"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 37 "..\..\ResourcePackages\Bootstrap4\MVC\Views\UsersList\Detail.UserDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591
