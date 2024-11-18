using ConnectionProvider.Abstraction.Settings;
using ConnectionProvider.Core.Helpers;
using ConnectionProvider.Core.Utilties.Encryption;
using ConnectionProvider.Identity.IoC;
using ConnectionProvider.Identity.Options;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionProvider.Container.Bootstrappers
{
    public static class IdentityBootstrapper
    {
        public static void RegisterIdentity(this IServiceCollection services)
        {
            var dbSettings = AppSettingsHelper.GetData<IdentityDbSettings>();
            var tokenOptions = AppSettingsHelper.GetData<AsisTokenOptions>();
            var key = ResourceHelper.GetString("TripleDesKey");
            var decryptStr = TripleDesEncryption.Decrypt(dbSettings.ConnectionString, key);

            services.RegisterIdentityDll(config =>
            {
                config.DatabaseType = dbSettings.DatabaseType;
                config.ConnectionString = decryptStr;

                config.TokenOptions = new AsisTokenOptions
                {
                    AccessTokenExpiration = tokenOptions.AccessTokenExpiration,
                    Audience = tokenOptions.Audience,
                    Issuer = tokenOptions.Issuer,
                    RefreshTokenExpiration = tokenOptions.RefreshTokenExpiration,
                    SecurityKey = tokenOptions.SecurityKey
                };
            });
        }
    }
}
