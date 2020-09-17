using System.Web;
using System.Web.Optimization;

namespace Projeto1
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            bundles.Add(new ScriptBundle("~/bundles/inputmask").Include(
                      "~/Scripts/inputmask/inputmask.js",
                      "~/Scripts/inputmask/inputmask.min.js",
                      "~/Scripts/inputmask/jquery.inputmask.js",
                      "~/Scripts/inputmask/jquery.inputmask.min.js",
                      "~/Scripts/inputmask/bindings/inputmask.binding.js"));
        }
    }
}
