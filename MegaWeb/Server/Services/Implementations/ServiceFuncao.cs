using MegaWeb.Server.Repository.Interfaces;
using MegaWeb.Server.Services.Interfaces;
using MegaWeb.Shared.Models;

namespace MegaWeb.Server.Services.Implementations
{
    public class ServiceFuncao : ServiceBase<Funcao>, IServiceFuncao
    {
        private readonly IFuncaoRepository _repository;

        public ServiceFuncao(IFuncaoRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}