using MegaWeb.Server.Context;
using MegaWeb.Server.Repository.Interfaces;
using MegaWeb.Shared.Models;

namespace MegaWeb.Server.Repository.Implementations
{
    public class SituacaoFuncionarioRepository : RepositoryBase<SituacaoFuncionario>, ISituacaoFuncionarioRepository
    {
        private readonly MegaContext _context;
        public SituacaoFuncionarioRepository(MegaContext context) : base(context)
        {
            _context = context;
        }
    }
}
