using MegaWeb.Shared.Map;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MegaWeb.Shared
{
    public static class ConfigureAutoMapper
    {
        public static IServiceCollection AddDependencieAutoMapper(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddAutoMapper(typeof(FuncaoDtoToFuncaoModel));
            service.AddAutoMapper(typeof(FuncaoModelToFuncaoDto));
            service.AddAutoMapper(typeof(FuncaoDtoToFuncaoModelUpdate));

            return service;
        }
    }
}