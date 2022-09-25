using MegaWeb.Server.Context;
using MegaWeb.Server.Repository.Interfaces;
using MegaWeb.Shared.Models;

namespace MegaWeb.Server.Repository.Implementations
{
    public class FuncionarioRepository : RepositoryBase<Funcionario>, IFuncionarioRepository
    {
        private readonly MegaContext _context;

        public FuncionarioRepository(MegaContext context) : base(context)
        {
            _context = context;
        }
    }
}