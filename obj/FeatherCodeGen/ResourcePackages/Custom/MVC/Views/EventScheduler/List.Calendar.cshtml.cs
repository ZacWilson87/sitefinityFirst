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

namespace RealSiteFinityFirst.ResourcePackages.Custom.MVC.Views.EventScheduler
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
    
    #line 7 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
    using ServiceStack.Text;
    
    #line default
    #line hidden
    
    #line 11 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
    using Telerik.Sitefinity.Frontend.Events.Mvc.Controllers;
    
    #line default
    #line hidden
    
    #line 8 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 9 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 12 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 10 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
    using Telerik.Sitefinity.Web.DataResolving;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/EventScheduler/List.Calendar.cshtml")]
    public partial class List_Calendar : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Events.Mvc.Models.EventScheduler.EventSchedulerModel>
    {
        public List_Calendar()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 14 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 15 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
Write(Html.Script(ScriptRef.KendoAll, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 16 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
Write(Html.Script(ScriptRef.KendoTimezones, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 17 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
Write(Html.StyleSheet(Url.EmbeddedResource("Telerik.Sitefinity.Resources.Reference", "Telerik.Sitefinity.Resources.Scripts.Kendo.styles.kendo_common_min.css"), "head", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 18 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
 if (Html.ShouldRenderInlineEditing() || SystemManager.IsDesignMode || SystemManager.IsPreviewMode)
{
    
            
            #line default
            #line hidden
            
            #line 20 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
Write(Html.StyleSheet(Url.EmbeddedResource("Telerik.Sitefinity.Resources.Reference", "Telerik.Sitefinity.Resources.Scripts.Kendo.styles.kendo_bootstrap-v4_min.css"), "bottom", false));

            
            #line default
            #line hidden
            
            #line 20 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                                                                                                                     

    if (ViewBag.IsRtl)
    {
        
            
            #line default
            #line hidden
            
            #line 24 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
   Write(Html.StyleSheet(Url.EmbeddedResource("Telerik.Sitefinity.Resources.Reference", "Telerik.Sitefinity.Resources.Scripts.Kendo.styles.kendo_rtl_min.css"), "bottom", false));

            
            #line default
            #line hidden
            
            #line 24 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                                                                                                                
    }
}
else
{
    
            
            #line default
            #line hidden
            
            #line 29 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
Write(Html.StyleSheet(Url.EmbeddedResource("Telerik.Sitefinity.Resources.Reference", "Telerik.Sitefinity.Resources.Scripts.Kendo.styles.kendo_bootstrap-v4_min.css"), "head", false));

            
            #line default
            #line hidden
            
            #line 29 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                                                                                                                   

    if (ViewBag.IsRtl)
    {
        
            
            #line default
            #line hidden
            
            #line 33 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
   Write(Html.StyleSheet(Url.EmbeddedResource("Telerik.Sitefinity.Resources.Reference", "Telerik.Sitefinity.Resources.Scripts.Kendo.styles.kendo_rtl_min.css"), "bottom", false));

            
            #line default
            #line hidden
            
            #line 33 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                                                                                                                
    }
}

            
            #line default
            #line hidden
WriteLiteral("<div");

WriteLiteral(" data-sf-current-page-id=\'");

            
            #line 36 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
                         Write(ViewBag.CurrentPageId);

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" data-sf-widget-id=\'");

            
            #line 36 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                    Write(ViewBag.WidgetId);

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" data-sf-role=\"scheduler-wrapper\"");

WriteLiteral(" data-sf-rtl=\"");

            
            #line 36 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                                                                     Write(ViewBag.IsRtl);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteAttribute("class", Tuple.Create(" class=\'", 2003), Tuple.Create("\'", 2030)
            
            #line 36 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                 , Tuple.Create(Tuple.Create("", 2011), Tuple.Create<System.Object, System.Int32>(Model.ListCssClass
            
            #line default
            #line hidden
, 2011), false)
);

WriteLiteral(" data-sf-controller-events=\'");

            
            #line 36 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                                                                                                                                            Write(Url.Content("~/web-interface/events"));

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" data-sf-controller-calendars=\'");

            
            #line 36 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                                                                                                                                                                                                                  Write(Url.Content("~/web-interface/calendars"));

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" data-sf-siteid=\"");

            
            #line 36 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                                                                                                                                                                                                                                                                             Write(SystemManager.CurrentContext.CurrentSite.Id);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("\r\n     data-sf-defaultview=\'");

            
            #line 37 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
                     Write(Model.EventSchedulerViewMode);

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" data-sf-allowchangecalendarview=\'");

            
            #line 37 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                     Write(Json.Encode(Model.AllowChangeCalendarView));

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" data-sf-allowcalendarfilter=\'");

            
            #line 37 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                                                                                               Write(Json.Encode(Model.AllowCalendarFilter));

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" data-sf-weekstartday=\'");

            
            #line 37 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                                                                                                                                                              Write(Model.WeekStartDay);

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" data-sf-loaded=\'false\'");

WriteLiteral("\r\n     data-sf-mincalendarlength=\'2\'");

WriteLiteral(" data-sf-calendarlist-class-active=\'active\'");

WriteLiteral(" data-sf-uiculture=\'");

            
            #line 38 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                            Write(ViewBag.UiCulture);

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" data-sf-timezoneoffset=\"");

            
            #line 38 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                                                                        Write(ViewBag.TimeZoneOffset);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-sf-timezoneid=\"");

            
            #line 38 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                                                                                                                     Write(ViewBag.TimeZoneId);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-sf-localtimezoneoffset=\"\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" data-sf-role=\"scheduler\"");

WriteLiteral("></div>\r\n        </div>\r\n");

            
            #line 43 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
        
            
            #line default
            #line hidden
            
            #line 43 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
         if (Model.AllowCalendarFilter) {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"col-md-2\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" data-sf-role=\"calendarlist\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">\r\n                <h4");

WriteLiteral(" class=\"sf-calendarList-title\"");

WriteLiteral(">");

            
            #line 46 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
                                             Write(Html.Resource("Calendars"));

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n            </div>\r\n        </div>\r\n");

            
            #line 49 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n    <script");

WriteLiteral(" data-sf-role=\"event-alldayeventtemplate\"");

WriteLiteral(" type=\"text/x-kendo-tmpl\"");

WriteLiteral(">\r\n        <div class=\"sf-event-item\" data-sf-eventid=\"#= taskId #\" data-sf-date-" +
"start=#=??JSON.stringify(start) # data-sf-date-end=#=??JSON.stringify(end) # data-" +
"sf-allday=\"#= isAllDay #\">\r\n            <a class=\"sf-event-link\" href=\"");

            
            #line 53 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
                                      Write(Html.Raw(Html.Encode(HyperLinkHelpers.GetFullPageUrl(ViewBag.DetailsPageId)).Replace("#", "\\#")));

            
            #line default
            #line hidden
WriteLiteral("#= eventUrl #\" title=\"#: title #\">#: title #</a>\r\n        </div>\r\n    </script>\r\n" +
"    <script");

WriteLiteral(" data-sf-role=\"event-eventtemplate\"");

WriteLiteral(" type=\"text/x-kendo-tmpl\"");

WriteLiteral(">\r\n        <div class=\"sf-event-item\" data-sf-eventid=\"#= taskId #\" data-sf-date-" +
"start=#=??JSON.stringify(start) # data-sf-date-end=#=??JSON.stringify(end) # data-" +
"sf-allday=\"#= isAllDay #\">\r\n            <a class=\"sf-event-link\" href=\"");

            
            #line 58 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
                                      Write(Html.Raw(Html.Encode(HyperLinkHelpers.GetFullPageUrl(ViewBag.DetailsPageId)).Replace("#", "\\#")));

            
            #line default
            #line hidden
WriteLiteral("#= eventUrl #\" title=\"#: title #\">#: title #</a>\r\n        </div>\r\n    </script>\r\n" +
"    <script");

WriteLiteral(" data-sf-role=\"event-calendarlist-template-wrapper\"");

WriteLiteral(" type=\"text/x-kendo-tmpl\"");

WriteLiteral(">\r\n        <div data-sf-role=\"calendarlist-wrapper\" class=\"list-unstyled nav nav-" +
"pills flex-column\">\r\n            <div data-sf-role=\"calendarlist-item\" class=\"sf" +
"-calendarList-item active\"><span class=\"sf-event-type sf-event-type--all\"></span" +
">");

            
            #line 63 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                                                                       Write(Html.Resource("AllEvents"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        </div>\r\n    </script>\r\n    <script");

WriteLiteral(" data-sf-role=\"event-calendarlist-template-item\"");

WriteLiteral(" type=\"text/x-kendo-tmpl\"");

WriteLiteral(">\r\n        <div data-sf-role=\"calendarlist-item\" class=\"sf-calendarList-item\" dat" +
"a-sf-id=\"#= calendarId #\"><span class=\"sf-event-type\" style=\"background-color: #" +
"= color #;\"></span>#: title #</div>\r\n    </script>\r\n</div>\r\n");

            
            #line 70 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
 if (SystemManager.IsDesignMode && !SystemManager.IsPreviewMode)
{
    var scriptUrl = Url.WidgetContent("Mvc/Scripts/EventScheduler/scheduler-events.js");
    var fullScriptUrl = scriptUrl + (scriptUrl.Contains("?") ? "&" : "?") + string.Format("_={0}", DateTime.UtcNow.Ticks.ToString());

            
            #line default
            #line hidden
WriteLiteral("    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\'", 5155), Tuple.Create("\'", 5175)
            
            #line 74 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
, Tuple.Create(Tuple.Create("", 5161), Tuple.Create<System.Object, System.Int32>(fullScriptUrl
            
            #line default
            #line hidden
, 5161), false)
);

WriteLiteral("></script>\r\n");

            
            #line 75 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
}
else
{
    
            
            #line default
            #line hidden
            
            #line 78 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/EventScheduler/scheduler-events.js"), "bottom", false));

            
            #line default
            #line hidden
            
            #line 78 "..\..MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                                      
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
