using MegaWeb.Shared.DTO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MegaWeb.Shared
{
    public static class ConfigureAutoMapper
    {
        public static IServiceCollection AddDependencieAutoMapper(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddAutoMapper(typeof(FuncaoProfile));

            return service;
        }
    }
}