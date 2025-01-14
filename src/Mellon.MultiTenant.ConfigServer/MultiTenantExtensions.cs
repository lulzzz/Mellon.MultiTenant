﻿using Mellon.MultiTenant.Base.Interfaces;
using Mellon.MultiTenant.ConfigServer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Mellon.MultiTenant.Extensions
{
    public static class MultiTenantExtensions
    {
        public static IServiceCollection AddMultiTenantSpringCloudConfig(
            this IServiceCollection services)
        {
            services.RemoveAll<ITenantConfigurationSource>();

            services.AddSingleton<ITenantConfigurationSource, ConfigServerTenantSource>();

            return services;
        }
    }
}
