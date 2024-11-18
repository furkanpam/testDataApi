using ConnectionProvider.Application.Mapper;
using ConnectionProvider.Core.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace ConnectionProvider.Container.Bootstrappers
{
    public static class MapperBootstrapper
    {
        public static void RegisterMapper(this IServiceCollection services)
        {

            services.RegisterMapper<MapperProfile>();
        }
    }
}
