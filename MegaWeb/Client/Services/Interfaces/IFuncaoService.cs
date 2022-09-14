using MegaWeb.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MegaWeb.Client.Services.Interfaces
{
    public interface IFuncaoService
    {
        Task<List<Funcao>> GetAll();

        Task Insert(Funcao funcao);
    }
}