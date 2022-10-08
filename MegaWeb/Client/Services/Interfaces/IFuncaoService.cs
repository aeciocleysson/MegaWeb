using MegaWeb.Shared.DTO.FuncaoDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MegaWeb.Client.Services.Interfaces
{
    public interface IFuncaoService
    {
        Task<List<FuncaoDto>> GetAll();

        Task Insert(FuncaoDto funcao);

        Task<FuncaoDto> GetById(int id);
        Task<FuncaoDto> Update(FuncaoDto funcao);
        Task Delete(int id);
    }
}