using System;
using Ocelot.Configuration.File;
using Ocelot.DependencyInjection;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class OcelotServiceCollectionExtensions
    {
        public static IOcelotBuilder AddOcelot(
            this IServiceCollection services, Action<FileConfiguration> configureBinder)
        {
            services.Configure(configureBinder);

            return services.AddOcelot();
        }
    }
}
