using System;
using Ocelot.Configuration.File;
using Ocelot.DependencyInjection;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class OcelotServiceCollectionExtensions
    {
        public static IServiceCollection AddOcelot(
            this IServiceCollection services, Action<FileConfiguration> configureBinder)
        {
            services.Configure(configureBinder);

            services.AddOcelot();

            return services;
        }
    }
}
