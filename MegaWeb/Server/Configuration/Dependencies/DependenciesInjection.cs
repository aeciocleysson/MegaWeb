using FluentValidation;
using FluentValidation.AspNetCore;
using MegaWeb.Server.Repository.Implementations;
using MegaWeb.Server.Repository.Interfaces;
using MegaWeb.Server.Services.Implementations;
using MegaWeb.Server.Services.Interfaces;
using MegaWeb.Server.Validators;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MegaWeb.Server.Configuration.Dependencies
{
    public static class DependenciesInjection
    {
        public static IServiceCollection AddDependenciesInjection(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddFluentValidationAutoValidation();
            service.AddValidatorsFromAssemblyContaining<FuncaoValidator>();

            service.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            service.AddScoped<IFuncaoRepository, FuncaoRepository>();
            service.AddScoped<IServiceFuncao, ServiceFuncao>();

            service.AddScoped<IFuncionarioRepository, FuncionarioRepository>();
            service.AddScoped<IServiceFuncionario, ServiceFuncionario>();

            return service;
        }
    }
}