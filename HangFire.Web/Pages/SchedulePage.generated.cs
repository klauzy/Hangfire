﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HangFire.Web.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    #line 2 "..\..\Pages\SchedulePage.cshtml"
    using Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class SchedulePage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");



WriteLiteral("              \r\n");


            
            #line 5 "..\..\Pages\SchedulePage.cshtml"
  
    Layout = new LayoutPage { Title = "Schedule" };
    
    int from, perPage;

    int.TryParse(Request.QueryString["from"], out from);
    int.TryParse(Request.QueryString["count"], out perPage);

    var pager = new Pager(from, perPage, JobStorage.ScheduledCount())
    {
        BaseLink = Request.LinkTo("/schedule")
    };

    var scheduledJobs = JobStorage.ScheduledJobs(pager.From, pager.PerPage);


            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 21 "..\..\Pages\SchedulePage.cshtml"
 if (pager.TotalPages == 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <div class=\"alert alert-success\">\r\n        Нет ни одного запланированного зад" +
"ания.\r\n    </div>\r\n");


            
            #line 26 "..\..\Pages\SchedulePage.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <div class=\"btn-toolbar btn-toolbar-top\">\r\n        <div class=\"btn-group pull" +
"-right paginator\">\r\n");


            
            #line 31 "..\..\Pages\SchedulePage.cshtml"
             foreach (var count in new[] { 10, 20, 50, 100 })
            {

            
            #line default
            #line hidden
WriteLiteral("                <a class=\"btn btn-default ");


            
            #line 33 "..\..\Pages\SchedulePage.cshtml"
                                      Write(count == pager.PerPage ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\" \r\n                    href=\"");


            
            #line 34 "..\..\Pages\SchedulePage.cshtml"
                     Write(pager.PerPageLink(count));

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 34 "..\..\Pages\SchedulePage.cshtml"
                                                Write(count);

            
            #line default
            #line hidden
WriteLiteral("</a>    \r\n");


            
            #line 35 "..\..\Pages\SchedulePage.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n        <div class=\"btn-group pull-right\">\r\n            <span cla" +
"ss=\"btn\">Jobs per page:</span>\r\n        </div>\r\n    </div>\r\n");


            
            #line 41 "..\..\Pages\SchedulePage.cshtml"
    

            
            #line default
            #line hidden
WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Scheduled At</th>
                <th>Queue</th>
                <th>Type</th>
                <th>Args</th>
                <th></th>
            </tr>
        </thead>
");


            
            #line 53 "..\..\Pages\SchedulePage.cshtml"
         foreach (var job in scheduledJobs)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td>\r\n                    <a href=\"");


            
            #line 57 "..\..\Pages\SchedulePage.cshtml"
                        Write(Request.LinkTo("/job/" + job.Key));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                        ");


            
            #line 58 "..\..\Pages\SchedulePage.cshtml"
                   Write(HtmlHelper.JobId(job.Key));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </a>\r\n                </td>\r\n                <td>");


            
            #line 61 "..\..\Pages\SchedulePage.cshtml"
               Write(job.Value.ScheduledAt);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");


            
            #line 62 "..\..\Pages\SchedulePage.cshtml"
               Write(HtmlHelper.QueueLabel(job.Value.Queue));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");


            
            #line 63 "..\..\Pages\SchedulePage.cshtml"
               Write(HtmlHelper.JobType(job.Value.Type));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>\r\n                    <code>\r\n                        " +
"");


            
            #line 66 "..\..\Pages\SchedulePage.cshtml"
                   Write(HtmlHelper.FormatProperties(job.Value.Args));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </code>\r\n                </td>\r\n                <td>\r\n     " +
"               <button class=\"btn btn-default btn-sm\" data-ajax=\"");


            
            #line 70 "..\..\Pages\SchedulePage.cshtml"
                                                                 Write(Request.LinkTo("/schedule/enqueue/" + job.Key));

            
            #line default
            #line hidden
WriteLiteral("\" data-loading-text=\"Enqueueing...\">\r\n                        <span class=\"glyphi" +
"con glyphicon-play\"></span>\r\n                        Enqueue now\r\n              " +
"      </button>\r\n                </td>\r\n            </tr>\r\n");


            
            #line 76 "..\..\Pages\SchedulePage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </table>\r\n");


            
            #line 78 "..\..\Pages\SchedulePage.cshtml"
    

            
            #line default
            #line hidden
WriteLiteral("    <div class=\"btn-toolbar\">\r\n");


            
            #line 80 "..\..\Pages\SchedulePage.cshtml"
         if (pager.TotalPages > 1)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"btn-group paginator\">\r\n                <a href=\"");


            
            #line 83 "..\..\Pages\SchedulePage.cshtml"
                    Write(pager.PreviousPageLink);

            
            #line default
            #line hidden
WriteLiteral("\" \r\n                   class=\"btn btn-default ");


            
            #line 84 "..\..\Pages\SchedulePage.cshtml"
                                      Write(!pager.HasPreviousPage ? "disabled" : null);

            
            #line default
            #line hidden
WriteLiteral("\">&laquo;</a>\r\n\r\n");


            
            #line 86 "..\..\Pages\SchedulePage.cshtml"
                 for (var i = 1; i <= pager.TotalPages; i++)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <a class=\"btn btn-default ");


            
            #line 88 "..\..\Pages\SchedulePage.cshtml"
                                          Write(pager.CurrentPage == i ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\" \r\n                       href=\"");


            
            #line 89 "..\..\Pages\SchedulePage.cshtml"
                        Write(pager.PageLink(i));

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 89 "..\..\Pages\SchedulePage.cshtml"
                                            Write(i);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");


            
            #line 90 "..\..\Pages\SchedulePage.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n                <a href=\"");


            
            #line 92 "..\..\Pages\SchedulePage.cshtml"
                    Write(pager.NextPageLink);

            
            #line default
            #line hidden
WriteLiteral("\" \r\n                   class=\"btn btn-default ");


            
            #line 93 "..\..\Pages\SchedulePage.cshtml"
                                      Write(!pager.HasNextPage ? "disabled" : null);

            
            #line default
            #line hidden
WriteLiteral("\">&raquo;</a>\r\n            </div>\r\n");


            
            #line 95 "..\..\Pages\SchedulePage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div class=\"btn-group\">\r\n            <span class=\"btn\">Total jobs: ");


            
            #line 98 "..\..\Pages\SchedulePage.cshtml"
                                     Write(pager.Total);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n");


            
            #line 101 "..\..\Pages\SchedulePage.cshtml"
}
            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
