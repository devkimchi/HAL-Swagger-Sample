﻿using System.Reflection;
using Autofac;
using Autofac.Integration.WebApi;

namespace HalSwaggerSample.ApiApp
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

            RegisterControllers(builder);

            var container = builder.Build();
            return container;
        }

        private static void RegisterControllers(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired().InstancePerLifetimeScope();
        }
    }
}