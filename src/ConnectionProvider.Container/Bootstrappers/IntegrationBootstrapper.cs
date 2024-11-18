using Asis.Framework.Integration.Factories;
using Asis.Framework.Integration.IoC;
using Microsoft.Extensions.DependencyInjection;
using Asis.Framework.Integration.Configurations;
using Asis.Framework.Integration.Helper;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;
using ConnectionProvider.Core.Helpers;
using ConnectionProvider.Abstraction.Settings;
namespace ConnectionProvider.Container.Bootstrappers
{
    public static class IntegrationBootstrapper
    {
        public static void RegisterCPIntegration(this IServiceCollection services)
        {
            var httpClientSettings = AppSettingsHelper.GetData<CPHttpClientConfiguration>();

            if (httpClientSettings is not null)
            { 
                services.AddScoped<IHttpClientHelperFactory, HttpClientHelperFactory>();
                services.Configure<CPHttpClientConfiguration>(options =>
                {
                    options = httpClientSettings;
                });

                services.RegisterIntegration(config =>
                {
                    config.Clients = httpClientSettings.HttpClients
                    .Select(s => new HttpClientSettings
                    {
                        BaseUrl = s.BaseUrl,
                        Name = s.Name,
                        EndPoints = s.EndPoints
                            .Select(ep => new EndPoint
                            {
                                Name = ep.Name,
                                Url = ep.Url,
                            }).ToList()
                    }).ToList();
                });
            }
        }

        public static IApplicationBuilder IntegrationHelperConfig(this IApplicationBuilder app)
        {
            var httpClientFactory = app.ApplicationServices.GetService<IHttpClientFactory>();
            IntegrationHelper.IntegrationHelperConfigure(httpClientFactory);
            return app;
        }
    }
}
