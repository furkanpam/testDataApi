using ConnectionProvider.Abstraction.Settings;
using ConnectionProvider.Core.Helpers;
using Consul;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using Winton.Extensions.Configuration.Consul;

namespace ConnectionProvider.Core.IoC
{
    public static class ConfigurationContainer
    {
        public static void RegisterConsul(this IConfigurationManager configuration)
        {

            string settingsFileName = "appsettings.json";
            string localSettingsFileName = "appsettings.json";
            string enviroment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            if (!string.IsNullOrEmpty(enviroment))
                localSettingsFileName = string.Format("appsettings.{0}.json", enviroment);

            configuration.AddJsonFile(localSettingsFileName, optional: true, reloadOnChange: true);
            AppSettingsHelper.AppSettingsHelperConfigure(configuration);

            ConsulSettings consulSettings = AppSettingsHelper.GetData<ConsulSettings>();
            string consulPath = @"ConnectionProvider/appsettings.json";
            string consulUrl = @"https://consul.asiselektronik.com.tr";
            if (consulSettings is not null)
            {
                consulPath = string.Format(@"{0}/{1}", consulSettings.ApplicationName, settingsFileName);
                consulUrl = consulSettings.Url;
            }
            
            configuration.AddConsul(consulPath, config =>
            {
                config.ConsulConfigurationOptions = cco => { cco.Address = new Uri(consulUrl); };
                config.Optional = true;
                config.PollWaitTime = TimeSpan.FromMinutes(1);
                config.ReloadOnChange = true;
                config.OnLoadException = ctx =>
                {
                    ctx.Ignore = true;
                    configuration
                    .AddJsonFile("appsettings.default.json", optional: true, reloadOnChange: true);
                };
                config.OnWatchException = cxt =>
                {
                    var exp = cxt.Exception;
                    return config.PollWaitTime;
                };
            });
        }
    }
}
