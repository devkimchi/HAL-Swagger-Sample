using System.Web.Mvc;
using System.Web.Routing;

using Autofac;
using Autofac.Integration.Mvc;

using Owin;

namespace HalSwaggerSample.WebApp
{
    /// <summary>
    /// This represents the config entity for MVC.
    /// </summary>
    public static class MvcConfig
    {
        /// <summary>
        /// Configures the MVC.
        /// </summary>
        /// <param name="builder">
        /// The <see cref="IAppBuilder" /> instance.
        /// </param>
        /// <param name="container">
        /// The <see cref="IContainer" /> instance.
        /// </param>
        public static void Configure(IAppBuilder builder, IContainer container)
        {
            RegisterDependencyResolver(container);
            RegisterAreas();
            RegisterRoutes(RouteTable.Routes);
            RegisterFilters(GlobalFilters.Filters);
        }

        private static void RegisterDependencyResolver(IContainer container)
        {
            var resolver = new AutofacDependencyResolver(container);
            DependencyResolver.SetResolver(resolver);
        }

        private static void RegisterAreas()
        {
            AreaRegistration.RegisterAllAreas();
        }

        private static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
        }

        private static void RegisterFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
