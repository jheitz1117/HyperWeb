using System.Web.Optimization;

namespace HyperWeb2.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Enable bundling optimizations, even when the site is in debug mode or local.
            BundleTable.EnableOptimizations = true;

            // Bundle our icons separate from our other stylesheets, since icons are large files and change rarely
            // If our regular styles change, don't want to force the user to re-download all the large files too.
            var icons = new StyleBundle("~/bundles/icons");
            icons.Include("~/Content/Styles/Components/font-awesome.css");

            var styles = new StyleBundle("~/bundles/styles");
            styles.Include("~/Content/Styles/site.css");

            bundles.Add(icons);
            bundles.Add(styles);
        }
    }
}