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

        public async Task<Tuple<TEntity?, StatusMessage>> GetAsync(Expression<Func<TEntity, bool>> expression)
        {
            Tuple<TEntity?, StatusMessage> retmsg;

            try
            {
                var res = await _context.Set<TEntity>().FirstOrDefaultAsync(expression);


                if (res != null)
                {
                    retmsg = new Tuple<TEntity?, StatusMessage>(res, StatusMessage.Success);
                    return retmsg;
                }
                retmsg = new Tuple<TEntity?, StatusMessage>(null, StatusMessage.NotFound);
                return retmsg;
            }
            catch
            {
                retmsg = new Tuple<TEntity?, StatusMessage>(null, StatusMessage.Error);
                return retmsg;
            }
        }
        public async Task<Tuple<TEntity[]?, StatusMessage>> GetAllAsync(Expression<Func<TEntity, bool>> expression)
        {
            Tuple<TEntity[]?, StatusMessage> retmsg;

            try
            {
                var res = await _context.Set<TEntity>().Where(expression).ToArrayAsync();

                if (res != null)
                {
                    retmsg = new Tuple<TEntity[]?, StatusMessage>(res, StatusMessage.Success);
                    return retmsg;
                }
                retmsg = new Tuple<TEntity[]?, StatusMessage>(null, StatusMessage.NotFound);
                return retmsg;
            }
            catch
            {
                retmsg = new Tuple<TEntity[]?, StatusMessage>(null, StatusMessage.Error);
                return retmsg;
            }
        }

        public async Task<Tuple<TEntity?, StatusMessage>> UpdateAsync(TEntity entity)
        {
            Tuple<TEntity?, StatusMessage> retmsg;

            try
            {
                var res = _context.Set<TEntity>().Update(entity);
                await _context.SaveChangesAsync();


                if (res != null)
                {
                    retmsg = new Tuple<TEntity?, StatusMessage>(entity, StatusMessage.Success);
                    return retmsg;
                }
                retmsg = new Tuple<TEntity?, StatusMessage>(null, StatusMessage.Error);
                return retmsg;
            }
            catch
            {
                retmsg = new Tuple<TEntity?, StatusMessage>(null, StatusMessage.Error);
                return retmsg;
            };
        }
        public async Task<StatusMessage> HardDeleteAsync(TEntity entity)
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
