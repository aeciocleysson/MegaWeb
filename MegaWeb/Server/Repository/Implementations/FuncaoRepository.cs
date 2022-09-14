using MegaWeb.Server.Context;
using MegaWeb.Server.Repository.Interfaces;
using MegaWeb.Shared.Models;

namespace MegaWeb.Server.Repository.Implementations
{
    public class FuncaoRepository : RepositoryBase<Funcao>, IFuncaoRepository
    {
        private readonly MegaContext _context;

        public FuncaoRepository(MegaContext context) : base(context)
        {
            _context = context;
        }
    }
}