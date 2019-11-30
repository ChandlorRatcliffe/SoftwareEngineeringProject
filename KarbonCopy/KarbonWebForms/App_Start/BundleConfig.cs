using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.UI;

namespace KarbonWebForms
{
    public class BundleConfig
    {
        // For more information on Bundling, visit https://go.microsoft.com/fwlink/?LinkID=303951
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = false;

            bundles.Add(new StyleBundle("~/lib/css").Include(
                "~/lib/css/fontawesome.css",
                "~/lib/css/bootstrap.css",
                "~/lib/css/all.css",
                "~/lib/css/boomod.css"
                )
            );

            bundles.Add(new ScriptBundle("~/lib/js").Include(
                "~/lib/js/jquery-3.4.1.js",
                "~/lib/js/all.js",
                "~/lib/js/bootstrap.bundle.js",
                "~/lib/fullcalendar/moment/moment.js",
                 "~/lib/js/datatables.min.js"
                )
            );

            bundles.Add(new ScriptBundle("~/bundles/WebFormsJs").Include(
                            "~/Scripts/WebForms/WebForms.js",
                            "~/Scripts/WebForms/WebUIValidation.js",
                            "~/Scripts/WebForms/MenuStandards.js",
                            "~/Scripts/WebForms/Focus.js",
                            "~/Scripts/WebForms/GridView.js",
                            "~/Scripts/WebForms/DetailsView.js",
                            "~/Scripts/WebForms/TreeView.js",
                            "~/Scripts/WebForms/WebParts.js"));

            // Order is very important for these files to work, they have explicit dependencies
            bundles.Add(new ScriptBundle("~/bundles/MsAjaxJs").Include(
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjax.js",
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjaxApplicationServices.js",
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjaxTimer.js",
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjaxWebForms.js"));

            // Use the Development version of Modernizr to develop with and learn from. Then, when you’re
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                            "~/Scripts/modernizr-*"));

        }
    }
}
 