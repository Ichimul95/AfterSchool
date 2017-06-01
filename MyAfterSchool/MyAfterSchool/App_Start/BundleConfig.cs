using System.Web;
using System.Web.Optimization;

namespace MyAfterSchool
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/jquery-{version}.js")
                .Include("~/Scripts/jquery.validate*"));



            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap")
                 .Include("~/Scripts/bootstrap.js")
                 .Include("~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/Plugins")
                 .Include("~/Scripts/owl.carousel.js")
                 .Include("~/Scripts/custom.js")
                 .Include("~/Scripts/google-map.js")
                 .Include("~/Assets/banner/js/jquery.themepunch.tools.min.js")
                 .Include("~/Assets/banner/js/jquery.themepunch.revolution.js")
                 .Include("~/Assets/banner/js/jquery.themepunch.enablelog.js"));
            
            /*-------CSS SECTION--------*/

            bundles.Add(new StyleBundle("~/Plugins/css")
                .Include("~/Assets/css/color-option1.css")
                .Include("~/Assets/css/owl.carousel.css")
                .Include("~/Assets/banner/css/settings.css")
                .Include("~/Assets/css/style.css")
                .Include("~/Assets/fonts/font-awesome.min.css"));


            bundles.Add(new StyleBundle("~/Content/css")
                    .Include("~/Content/css/custom.css")
                    .Include("~/Content/bootstrap.css")
                    .Include("~/Content/site.css"));
        }
    }
}
