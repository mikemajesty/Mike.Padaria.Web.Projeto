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
                 .Include("~/Scripts/jquery.validate.js")
                 .Include("~/Scripts/jquery.validate.unobtrusive.js")
                 .Include("~/Scripts/jquery-2.1.4.js"));
            bundles.Add(new ScriptBundle("~/Bundles/jqueryval")
                .Include("~/Scripts/modernizr-2.8.3.js"));
            bundles.Add(new StyleBundle("~/Content/bootstrap")
                .Include("~/Content/bootstrap.css")
                .Include("~/Content/bootstrap-theme.css"));
            bundles.Add(new ScriptBundle("~/Bundles/bootstrap")
                .Include("~/Scripts/bootstrap.js"));
            bundles.Add(new StyleBundle("~/Content/Custom")
                .Include("~/Content/Menu.css"));
            bundles.Add(new ScriptBundle("~/Bundles/Custom")
               .Include("~/Scripts/ProcurarItensNaComanda.js")
               .Include("~/Scripts/IserirItensNoCarrinho.js"));
        }
    }
}