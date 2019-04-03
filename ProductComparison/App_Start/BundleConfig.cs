using System.Web.Optimization;

namespace ProductComparison
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/vue").Include(
                        "~/Scripts/vendor/vue.min.js",
                        "~/Scripts/vendor/vue-resource.min.js",
                        "~/Scripts/vendor/vue-router.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/vendor/jquery-3.3.1.min.js",
                      "~/Scripts/vendor/bootstrap.min.js",
                      "~/Scripts/vendor/bootstrap.bundle.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/bootstrap-grid.min.css",
                      "~/Content/bootstrap-reboot.min.css",
                      "~/Content/site.css"));
        }
    }
}