using MegaWeb.Shared.Map;
using MegaWeb.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MegaWeb.Client.Services.Interfaces
{
    public interface IFuncaoService
    {
        Task<List<FuncaoDto>> GetAll();

        Task Insert(FuncaoDto funcao);
    }
}