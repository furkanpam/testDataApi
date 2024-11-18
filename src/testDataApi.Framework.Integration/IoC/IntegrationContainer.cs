using Asis.Framework.Integration.Configurations;
using Asis.Framework.Integration.Factories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Headers;

namespace Asis.Framework.Integration.IoC
{
    public static class IntegrationContainer
    {
        public static void RegisterIntegration(this IServiceCollection services, Action<IntegrationConfiguration> configuration)
        {
            services.AddScoped<IHttpClientHelperFactory, HttpClientHelperFactory>();

            var integrationConfiguration = new IntegrationConfiguration();
            configuration(integrationConfiguration);

            foreach (var client in integrationConfiguration.Clients)
            {
                services.AddHttpClient<IHttpClientHelperFactory, HttpClientHelperFactory>(client.Name, options =>
                {
                    options.BaseAddress = new Uri(client.BaseUrl);
                    options.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                });
            }
        }


    }
}
