using MegaWeb.Shared.Request;
using MegaWeb.Shared.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MegaWeb.Client.Services.Interfaces
{
    public interface IFuncaoService
    {
        Task<List<FuncaoResponse>> GetAll();

        Task Insert(FuncaoRequest funcao);

        Task<FuncaoResponse> GetById(int id);

        Task<FuncaoResponse> Update(FuncaoResponse funcao);

        Task Delete(int id);
    }
}