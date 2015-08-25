using System.Web.Optimization;

namespace HyperWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // We never bundle javascript

            // Always bundle CSS
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Styles/bootstrap.css",
                      "~/Content/Styles/site.css"));

            // force CSS to be compiled into a single CSS file. Set to false to allow each individual CSS file to be loaded separately to make debugging easier.
            BundleTable.EnableOptimizations = true;
        }
    }
}
