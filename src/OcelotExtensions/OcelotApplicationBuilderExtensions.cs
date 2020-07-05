using Ocelot.Middleware;

namespace Microsoft.AspNetCore.Builder
{
    public static class OcelotApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseOcelot(this IApplicationBuilder builder)
        {
            OcelotMiddlewareExtensions.UseOcelot(builder).Wait();

            return builder;
        }
    }
}
