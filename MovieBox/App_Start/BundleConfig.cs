using System.Web.Optimization;

namespace MovieBox
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
<<<<<<< HEAD
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/bootbox.js",
                        "~/Scripts/respond.js",
                        "~/Scripts/datatables/jquery.datatables.js",
                        "~/Scripts/typeahead.bundle.js",
                        "~/Scripts/moment.js",
                        "~/Scripts/isotope.pkgd.min.js",
                        "~/Scripts/toastr.js",
                        "~/Scripts/datatables/datatables.bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/rentaljs").Include(
                        "~/Scripts/Rentals/rental.js"));
=======
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
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012

            bundles.Add(new ScriptBundle("~/bundles/homejs").Include(
                "~/Scripts/Home/home.js"));

            bundles.Add(new ScriptBundle("~/bundles/customerjs").Include(
                "~/Scripts/Customer/customerList.js"));

            bundles.Add(new ScriptBundle("~/bundles/slideshow").Include(
<<<<<<< HEAD
                        "~/Scripts/slideshow.js"));
=======
                "~/Scripts/slideshow.js"));
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
<<<<<<< HEAD
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
=======
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
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
