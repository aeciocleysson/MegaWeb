using MegaWeb.Shared.DTO.FuncaoDtos;
using MegaWeb.Shared.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MegaWeb.Server.Services.Interfaces
{
    public interface IServiceFuncao
    {
        Task<FuncaoDto> Add(FuncaoDto entity);

        Task<List<FuncaoResponse>> GetAll();

        Task<FuncaoDto> GetById(int id);

        Task<FuncaoDtoUpdate> Update(FuncaoDtoUpdate entity);

        Task<bool> Remove(int id);
    }
}