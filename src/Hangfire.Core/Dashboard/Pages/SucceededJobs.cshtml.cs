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

namespace Hangfire.Dashboard.Pages
{
    
    #line 2 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
    using System;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    #line 3 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
    using Hangfire;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
    using Hangfire.Dashboard;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
    using Hangfire.Dashboard.Pages;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
    using Hangfire.Dashboard.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class SucceededJobs : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");








            
            #line 8 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
  
    Layout = new LayoutPage(Strings.SucceededJobsPage_Title);

    int from, perPage;

    int.TryParse(Query("from"), out from);
    int.TryParse(Query("count"), out perPage);

    var monitor = Storage.GetMonitoringApi();
    var pager = new Pager(from, perPage, DashboardOptions.DefaultRecordsPerPage, monitor.SucceededListCount());
    var succeededJobs = monitor.SucceededJobs(pager.FromRecord, pager.RecordsPerPage);


            
            #line default
            #line hidden
WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");


            
            #line 23 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
   Write(Html.JobsSidebar());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <h1 class=\"page-header\">");


            
            #line 26 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                           Write(Strings.SucceededJobsPage_Title);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n\r\n");


            
            #line 28 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
         if (pager.TotalPageCount == 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"alert alert-info\">\r\n                ");


            
            #line 31 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
           Write(Strings.SucceededJobsPage_NoJobs);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");


            
            #line 33 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"js-jobs-list\">\r\n                <div class=\"btn-toolbar b" +
"tn-toolbar-top\">\r\n");


            
            #line 38 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                     if (!IsReadOnly)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <button class=\"js-jobs-list-command btn btn-sm btn-primar" +
"y\"\r\n                                data-url=\"");


            
            #line 41 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                     Write(Url.To("/jobs/succeeded/requeue"));

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                                data-loading-text=\"");


            
            #line 42 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                              Write(Strings.Common_Enqueueing);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                                disabled=\"disabled\">\r\n                        " +
"    <span class=\"glyphicon glyphicon-repeat\"></span>\r\n                          " +
"  ");


            
            #line 45 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                       Write(Strings.Common_RequeueJobs);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </button>\r\n");


            
            #line 47 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    ");


            
            #line 48 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
               Write(Html.PerPageSelector(pager));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"table-responsive\">\r\n     " +
"               <table class=\"table\">\r\n                        <thead>\r\n         " +
"                   <tr>\r\n");


            
            #line 55 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                 if (!IsReadOnly)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <th class=\"min-width\">\r\n                     " +
"                   <input type=\"checkbox\" class=\"js-jobs-list-select-all\"/>\r\n   " +
"                                 </th>\r\n");


            
            #line 60 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                                <th class=\"min-width\">");


            
            #line 61 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                 Write(Strings.Common_Id);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th>");


            
            #line 62 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                               Write(Strings.Common_Job);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n");


            
            #line 63 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                 if (succeededJobs.Any(x => x.Value?.StateData != null))
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <th class=\"min-width\">");


            
            #line 65 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                     Write(Strings.SucceededJobsPage_Table_Duration);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n");



WriteLiteral("                                    <th class=\"min-width\">");


            
            #line 66 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                     Write(Strings.SucceededJobsPage_Table_Latency);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n");


            
            #line 67 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                }
                                else
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <th class=\"min-width\">");


            
            #line 70 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                     Write(Strings.SucceededJobsPage_Table_TotalDuration);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n");


            
            #line 71 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                                <th class=\"align-right\">");


            
            #line 72 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                   Write(Strings.SucceededJobsPage_Table_Succeeded);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                            </tr>\r\n                        </thead>\r\n     " +
"                   <tbody>\r\n");


            
            #line 76 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                             foreach (var job in succeededJobs)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <tr class=\"js-jobs-list-row ");


            
            #line 78 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                        Write(job.Value == null || !job.Value.InSucceededState ? "obsolete-data" : null);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 78 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                                                                                                     Write(job.Value != null && job.Value.InSucceededState ? "hover" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n");


            
            #line 79 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                     if (!IsReadOnly)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <td>\r\n");


            
            #line 82 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                             if (job.Value != null && job.Value.InSucceededState)
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <input type=\"checkbox\" class=\"js-" +
"jobs-list-checkbox\" name=\"jobs[]\" value=\"");


            
            #line 84 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                                                                                     Write(job.Key);

            
            #line default
            #line hidden
WriteLiteral("\"/>\r\n");


            
            #line 85 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                            }

            
            #line default
            #line hidden
WriteLiteral("                                        </td>\r\n");


            
            #line 87 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                    <td class=\"min-width\">\r\n                     " +
"                   ");


            
            #line 89 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                   Write(Html.JobIdLink(job.Key));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 90 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                         if (job.Value != null && !job.Value.InSucceededState)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <span title=\"");


            
            #line 92 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                    Write(Strings.Common_JobStateChanged_Text);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"glyphicon glyphicon-question-sign\"></span>\r\n");


            
            #line 93 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </td>\r\n\r\n");


            
            #line 96 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                     if (job.Value == null)
                                    {
                                        if (succeededJobs.Any(x => x.Value?.StateData != null))
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <td colspan=\"4\"><em>");


            
            #line 100 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                           Write(Strings.Common_JobExpired);

            
            #line default
            #line hidden
WriteLiteral("</em></td>\r\n");


            
            #line 101 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                        }
                                        else
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <td colspan=\"3\"><em>");


            
            #line 104 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                           Write(Strings.Common_JobExpired);

            
            #line default
            #line hidden
WriteLiteral("</em></td>\r\n");


            
            #line 105 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                        }
                                    }
                                    else
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <td class=\"word-break\">\r\n                " +
"                            ");


            
            #line 110 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                       Write(Html.JobNameLink(job.Key, job.Value.Job));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                        </td>\r\n");


            
            #line 112 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                        if (job.Value.StateData != null)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <td class=\"min-width align-right\">\r\n");


            
            #line 115 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                 if (job.Value.StateData.TryGetValue("PerformanceDuration", out var duration))
                                                {
                                                    
            
            #line default
            #line hidden
            
            #line 117 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                               Write(Html.ToHumanDuration(TimeSpan.FromMilliseconds(long.Parse(duration, System.Globalization.CultureInfo.InvariantCulture)), false));

            
            #line default
            #line hidden
            
            #line 117 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                                                                                                                                                    
                                                }

            
            #line default
            #line hidden
WriteLiteral("                                            </td>\r\n");



WriteLiteral("                                            <td class=\"min-width align-right\">\r\n");


            
            #line 121 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                 if (job.Value.StateData.TryGetValue("Latency", out var latency))
                                                {
                                                    
            
            #line default
            #line hidden
            
            #line 123 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                               Write(Html.ToHumanDuration(TimeSpan.FromMilliseconds(long.Parse(latency, System.Globalization.CultureInfo.InvariantCulture)), false));

            
            #line default
            #line hidden
            
            #line 123 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                                                                                                                                                   
                                                }

            
            #line default
            #line hidden
WriteLiteral("                                            </td>\r\n");


            
            #line 126 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                        }
                                        else
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <td class=\"min-width align-right\">\r\n");


            
            #line 130 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                 if (job.Value.TotalDuration.HasValue)
                                                {
                                                    
            
            #line default
            #line hidden
            
            #line 132 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                               Write(Html.ToHumanDuration(TimeSpan.FromMilliseconds(job.Value.TotalDuration.Value), false));

            
            #line default
            #line hidden
            
            #line 132 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                                                                                                          
                                                }

            
            #line default
            #line hidden
WriteLiteral("                                            </td>\r\n");


            
            #line 135 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                        <td class=\"min-width align-right\">\r\n");


            
            #line 137 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                             if (job.Value.SucceededAt.HasValue)
                                            {
                                                
            
            #line default
            #line hidden
            
            #line 139 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                           Write(Html.RelativeTime(job.Value.SucceededAt.Value));

            
            #line default
            #line hidden
            
            #line 139 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                                                               
                                            }

            
            #line default
            #line hidden
WriteLiteral("                                        </td>\r\n");


            
            #line 142 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </tr>\r\n");


            
            #line 144 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </tbody>\r\n                    </table>\r\n                <" +
"/div>\r\n\r\n                ");


            
            #line 149 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
           Write(Html.Paginator(pager));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");


            
            #line 151 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>");


        }
    }
}
#pragma warning restore 1591
