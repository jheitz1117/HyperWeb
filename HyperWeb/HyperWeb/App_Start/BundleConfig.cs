using System.Web.Optimization;

namespace HyperWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Enable bundling optimizations, even when the site is in debug mode or local.
            BundleTable.EnableOptimizations = true;

            // We never bundle javascript (require.js makes this a non-issue)

            // Bundle our icons separate from our other stylesheets, since icons are large files and change rarely
            // If our regular styles change, don't want to force the user to re-download all the large files too.
            bundles.Add(
                new StyleBundle("~/bundles/icons")
                    .Include("~/Content/Styles/Components/font-awesome.css")
            );
            bundles.Add(
                new StyleBundle("~/bundles/styles")
                    .Include("~/Content/Styles/site.css")
            );
        }
    }
}
