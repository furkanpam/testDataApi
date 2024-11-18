using ConnectionProvider.Abstraction.Data.Context;
using ConnectionProvider.Abstraction.Enums;
using ConnectionProvider.Core.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ConnectionProvider.Core.Extensions
{
    public static class DbContextExtensions
    {
        public static void AddBackendDataEF<TContext>(this IServiceCollection services, ContextConfiguration config) where TContext : DbContextBase
        {
            services.AddDbContext<TContext>(optionsBuilder =>
            {
                Console.WriteLine("DbType : " + config.DatabaseType.ToString());
                var databaseType = config.DatabaseType;
                switch (databaseType)
                {
                    case DatabaseType.SqlServer:
                        optionsBuilder.UseSqlServer(config.ConnectionString);
                        break;
                    case DatabaseType.SqlLite:
                        optionsBuilder.UseSqlite(config.ConnectionString);
                        break;
                    case DatabaseType.Postgre:
                        optionsBuilder.UseNpgsql(config.ConnectionString);
                        break;
                    case DatabaseType.Oracle:
                        optionsBuilder.UseOracle(config.ConnectionString);
                        break;
                    default:
                        throw new NotSupportedException($"Name {config.DatabaseType.ToString()}:is not supported");
                }
            }).AddScoped<DbContextBase, TContext>();
        }
    }
}
