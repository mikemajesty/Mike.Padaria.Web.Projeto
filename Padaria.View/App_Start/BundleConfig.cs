using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Padaria.View.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Bundles/jquery")
                .Include("~/Scripts/jquery.validate.min.js")
                .Include("~/Scripts/jquery.validate.unobtrusive.min.js")
                .Include("~/Scripts/jquery-2.1.4.min.js"));
            bundles.Add(new ScriptBundle("~/Bundles/jqueryval")
                .Include("~/Scripts/modernizr-2.8.3.js"));
            bundles.Add(new StyleBundle("~/Content/bootstrap")
                .Include("~/Content/bootstrap.min.css")
                .Include("~/Content/bootstrap-theme.min.css"));
            bundles.Add(new ScriptBundle("~/Bundles/bootstrap")
                .Include("~/Scripts/bootstrap.min.js"));
            bundles.Add(new StyleBundle("~/Content/Custom")
                .Include("~/Content/Menu.css"));
        }
    }
}