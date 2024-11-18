using ConnectionProvider.Abstraction.Exceptions;
using ConnectionProvider.Abstraction.Settings;
using ConnectionProvider.Abstraction.StatusCodes;
using ConnectionProvider.Core.Configurations;
using ConnectionProvider.Core.Extensions;
using ConnectionProvider.Core.Helpers;
using ConnectionProvider.Core.Utilties.Encryption;
using ConnectionProvider.Domain.Contexts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionProvider.Container.Bootstrappers
{
    public static class DbBootstrapper
    {
        public static void AddDbContext(this IServiceCollection services)
        {
            DatabaseSettings dbSettings = AppSettingsHelper.GetData<DatabaseSettings>();
            string key = ResourceHelper.GetString("TripleDesKey");
            Console.WriteLine(key);
            if (string.IsNullOrEmpty(key))
                throw new BusinessException(CPStatusCodes.Status111DataNotFound, "Triple Des Key Not Found!");

            string decryptStr = TripleDesEncryption.Decrypt(dbSettings.ConnectionString, key);
            Console.WriteLine(decryptStr);
            services.AddBackendDataEF<ConnectionProviderDbContext>(new ContextConfiguration
            {
                ConnectionString = decryptStr,
                DatabaseType = dbSettings.DatabaseType
            });
        }
    }
}
