namespace NurseCallMvc.Web.Global
{
    using System.Reflection;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;

    using NurseCallMvc.Common.Mapping;
    using NurseCallMvc.Web.ViewModels.Account;

    public class NurseCallApp : HttpApplication
    {
        protected void Application_Start()
        {
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());
            DatabaseConfig.Config();
            AutofacConfig.RegisterAutofac();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AutoMapperConfig.RegisterMappings(typeof(LoginViewModel).GetTypeInfo().Assembly);
        }
    }
}
