using MegaWeb.Server.Context;
using MegaWeb.Server.Repository.Interfaces;
using MegaWeb.Shared.Models;

namespace MegaWeb.Server.Repository.Implementations
{
    public class StatusLancamentoPontoRepository : RepositoryBase<StatusLancamentoPonto>, IStatusLancamentoPontoRepository
    {
        private readonly MegaContext _context;

        public StatusLancamentoPontoRepository(MegaContext context) : base(context)
        {
            _context = context;
        }
    }
}