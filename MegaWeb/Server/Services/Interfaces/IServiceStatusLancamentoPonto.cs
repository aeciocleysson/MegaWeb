using MegaWeb.Shared.DTO.StatusDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MegaWeb.Server.Services.Interfaces
{
    public interface IServiceStatusLancamentoPonto
    {
        Task<List<StatusLancamentoPontoDto>> GetAll();
        Task<StatusLancamentoPontoDto> Add(StatusLancamentoPontoDto entity);
    }
}