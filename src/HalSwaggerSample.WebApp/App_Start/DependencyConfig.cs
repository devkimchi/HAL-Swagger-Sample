using System.Reflection;

using Autofac;
using Autofac.Integration.Mvc;

using HalSwaggerSample.WebApp.Proxies;

namespace HalSwaggerSample.WebApp
{
    /// <summary>
    /// This represents the configuration entity for dependency injection.
    /// </summary>
    public static class DependencyConfig
    {
        /// <summary>
        /// Configures <see cref="Autofac" /> dependency injection.
        /// </summary>
        /// <returns>Returns <see cref="IContainer" /> instance.</returns>
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            RegisterProxies(builder);
            RegisterControllers(builder);

            var container = builder.Build();
            return container;
        }

        private static void RegisterProxies(ContainerBuilder builder)
        {
            builder.RegisterType<HalSwaggerSampleHalApiApp>()
                   .As<IHalSwaggerSampleHalApiApp>()
                   .PropertiesAutowired()
                   .InstancePerLifetimeScope();
        }

        private static void RegisterControllers(ContainerBuilder builder)
        {
            builder.RegisterControllers(Assembly.GetExecutingAssembly())
                   .PropertiesAutowired()
                   .InstancePerLifetimeScope();
        }
    }
}
