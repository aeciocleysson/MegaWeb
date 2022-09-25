using MegaWeb.Server.Repository.Interfaces;
using MegaWeb.Server.Services.Interfaces;
using MegaWeb.Shared.Models;

namespace MegaWeb.Server.Services.Implementations
{
    public class ServiceFuncionario : ServiceBase<Funcionario>, IServiceFuncionario
    {
        private readonly IFuncionarioRepository _repository;

        public ServiceFuncionario(IFuncionarioRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}