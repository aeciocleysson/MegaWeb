using MegaWeb.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MegaWeb.Server.Services.Interfaces
{
    public interface IServiceBase<TEntity> where TEntity : BaseModel
    {
        Task<TEntity> Add(TEntity entity);

        Task<TEntity> GetById(int id);

        Task<List<TEntity>> GetAll();

        Task<TEntity> Update(TEntity entity);

        Task<bool> Remove(int id);
    }
}