using ConnectionProvider.Core.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace ConnectionProvider.Container.Bootstrappers
{
    public static class HelperBootstrapper
    {
        public static IApplicationBuilder AddHelpers(this IApplicationBuilder app)
        {
            var service = app.ApplicationServices.GetRequiredService<IActionDescriptorCollectionProvider>();
            RouteInfoHelper.Configure(service);
            return app;
        }
    }
}
