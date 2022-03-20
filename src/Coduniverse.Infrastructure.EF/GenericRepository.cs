using Coduniverse.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Coduniverse.Infrastructure.EF
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private EfDbContext _context;
        private DbSet<T> _dbSet;

        public GenericRepository(EfDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync() => await _dbSet.ToListAsync();

        public async Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> predicate) => await _dbSet.GetQuery(predicate, null).ToListAsync();

        public async Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes) => await _dbSet.GetQuery(predicate, includes).ToListAsync();

        public async Task<T> GetAsync(Guid id) => await _dbSet.AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);

        public async Task<T> GetAsync(Guid id, params Expression<Func<T, object>>[] includes) => await _dbSet.GetQuery(null, includes).FirstOrDefaultAsync(e => e.Id == id);

        public async Task<T> InsertAsync(T entity)
        {
            _dbSet.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<int> InsertAsyncRange(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Remove(T entity)
        {
            _dbSet.Remove(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> RemoveRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
            return await _context.SaveChangesAsync();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<int> UpdateRange(IEnumerable<T> entities)
        {
            _dbSet.UpdateRange(entities);
            return await _context.SaveChangesAsync();
        }
    }
}