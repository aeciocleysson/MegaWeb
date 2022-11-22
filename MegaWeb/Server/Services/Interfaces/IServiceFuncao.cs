using MegaWeb.Shared.Request;
using MegaWeb.Shared.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MegaWeb.Server.Services.Interfaces
{
    public interface IServiceFuncao
    {
        Task<FuncaoResponse> Add(FuncaoRequest entity);

        Task<List<FuncaoResponse>> GetAll();

        Task<FuncaoResponse> GetById(int id);

        Task<FuncaoResponse> Update(FuncaoResponse entity);

        Task<bool> Remove(int id);
    }
}