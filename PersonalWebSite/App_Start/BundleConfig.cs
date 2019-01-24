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
                "https://code.jquery.com/jquery-1.10.2.min.js").Include(
                "~/Scripts/jquery-1.10.2.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap",
                "https://ajax.aspnetcdn.com/ajax/bootstrap/3.0.0/bootstrap.min.js").Include(
                "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/google-analytics").Include(
                "~/Scripts/google-analytics.js"));

            bundles.Add(new StyleBundle("~/Content/fontawesome",
                "https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css").Include(
                "~/Content/font-awesome.css"));

            bundles.Add(new StyleBundle("~/Content/css", "https://stackpath.bootstrapcdn.com/bootstrap/3.0.0/css/bootstrap.min.css")
                .Include("~/Content/bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/bundles/css")
                .Include("~/Content/Site.css")
                .Include("~/Content/messages.css")
                .Include("~/Content/errors.css"));
        }
    }
}