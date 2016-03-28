namespace MVC_Template.Web.App_Start
{
    using System.Web.Optimization;

    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Styles/materialize/materialize.css",
                      "~/Content/Fonts/materialize/material-design-icons/Material-Design-Icons.svg",
                      "~/Content/Styles/site.css"));
        }
    }
}