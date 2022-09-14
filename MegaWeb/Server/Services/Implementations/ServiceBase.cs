using MegaWeb.Server.Repository.Interfaces;
using MegaWeb.Server.Services.Interfaces;
using MegaWeb.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MegaWeb.Server.Services.Implementations
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : BaseModel
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            return await _repository.Add(entity);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task<bool> Remove(TEntity entity)
        {
            return await _repository.Remove(entity);
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            return await _repository.Update(entity);
        }
    }
}