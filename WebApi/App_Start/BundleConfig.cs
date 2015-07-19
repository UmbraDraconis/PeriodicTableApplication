using System.Web.Optimization;

namespace WebApi
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/elementsStyleSheet.css"));
        }
    }
}