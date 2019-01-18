using System.Web.Optimization;

namespace PersonalWebSite.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
#if !DEBUG
            BundleTable.EnableOptimizations = true;
            BundleTable.Bundles.UseCdn = true;
#endif

            bundles.Add(new ScriptBundle("~/bundles/jquery",
                "https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.0.0.min.js").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap",
                "https://ajax.aspnetcdn.com/ajax/bootstrap/3.0.0/bootstrap.min.js").Include(
                "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/fontawesome",
                "https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css").Include(
                "~/Content/font-awesome.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/site.css",
                "~/Content/messages.css"));
        }
    }
}