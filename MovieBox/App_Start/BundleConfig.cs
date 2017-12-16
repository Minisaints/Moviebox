using System.Web.Optimization;

namespace MovieBox
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/bootbox.js",
                        "~/Scripts/respond.js",
                        "~/Scripts/datatables/jquery.datatables.js",
                        "~/Scripts/typeahead.bundle.js",
                        "~/Scripts/moment.js",
                        "~/Scripts/toastr.js",
                        "~/Scripts/datatables/datatables.bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/rentaljs").Include(
                        "~/Scripts/Rentals/rental.js"));

            bundles.Add(new ScriptBundle("~/bundles/slideshow").Include(
                        "~/Scripts/slideshow.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-lumen.css",
                      "~/Content/bootstrap-social.css",
                      "~/Content/typeahead.css",
                      "~/Content/site.css",
                      "~/Content/toastr.css",
                      "~/Content/datatables/css/datatables.bootstrap.css"));
        }
    }
}
