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
    internal class Repository<TEntity, TContext> where TEntity : class where TContext : DbContext
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
                _context.Set<TEntity>().Add(entity);
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
        public async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression)
        {
            IEnumerable<TEntity> entity;

            try
            {
                var res = await _context.Set<TEntity>().Where(expression).ToListAsync();

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
