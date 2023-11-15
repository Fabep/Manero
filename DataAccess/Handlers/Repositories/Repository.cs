using DataAccess.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Handlers.Repositories
{
    public abstract class Repository<TEntity, TContext> where TEntity : class where TContext : DbContext
    {
        private readonly TContext _context;
        public Repository(TContext context)
        {

            _context = context;

        }

        public async Task<StatusMessage> CreateAsync(TEntity entity)
        {
            try
            {
                await _context.Set<TEntity>().AddAsync(entity);
                await _context.SaveChangesAsync();
                return StatusMessage.Success;
            }
            catch
            {
                return StatusMessage.Error;
            }
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
        {
            TEntity entity;
            try
            {
                var res = await _context.Set<TEntity>().FirstOrDefaultAsync(expression);


                if (res != null)
                {
                    entity = res;
                    return entity;
                }
                entity = null!;
                return entity;
            }
            catch
            {
                entity = null!;
                return entity;
            }
        }
        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> expression)
        {
            IQueryable<TEntity> entity;

            try
            {
                var res = _context.Set<TEntity>().Where(expression);

                if (res != null)
                {
                    entity = res;
                    return entity;
                }
                entity = null!;
                return entity;
            }
            catch
            {
                entity = null!;
                return entity;
            }
        }

        public async Task<TEntity?> UpdateAsync(TEntity entityToUpdate)
        {
            TEntity entity;

            try
            {
                var res = _context.Set<TEntity>().Update(entityToUpdate);
                await _context.SaveChangesAsync();


                if (res != null)
                {
                    entity = entityToUpdate;
                    return entity;
                }
                entity = null!;
                return entity;
            }
            catch
            {
                entity = null!;
                return entity;
            };
        }
        public async Task<StatusMessage> DeleteAsync(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Remove(entity);
                await _context.SaveChangesAsync();

                return StatusMessage.Success;
            }
            catch { return StatusMessage.Error; }
        }
    }
}
