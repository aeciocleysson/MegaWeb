using MegaWeb.Server.Context;
using MegaWeb.Server.Repository.Interfaces;
using MegaWeb.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MegaWeb.Server.Repository.Implementations
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : BaseModel
    {
        private readonly MegaContext _context;

        public RepositoryBase(MegaContext context)
        {
            _context = context;
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Add(entity);
                await _context.SaveChangesAsync();

                return entity;
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<bool> Remove(int id)
        {
            try
            {
                var result = await _context.Set<TEntity>().SingleOrDefaultAsync(w => w.Id == id);

                if (result == null)
                    return false;

                _context.Set<TEntity>().Remove(result);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            try
            {
                var result = await _context.Set<TEntity>().SingleOrDefaultAsync(w => w.Id == entity.Id);

                if (result == null)
                    return null;

                _context.Entry(result).CurrentValues.SetValues(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
            return entity;
        }
    }
}