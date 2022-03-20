using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Coduniverse.Domain
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
        Task<T> GetAsync(Guid id);
        Task<T> GetAsync(Guid id, params Expression<Func<T, object>>[] includes);
        Task<T> InsertAsync(T entity);
        Task<int> InsertAsyncRange(IEnumerable<T> entities);
        Task<int> Remove(T entity);
        Task<int> RemoveRange(IEnumerable<T> entities);
        Task<T> UpdateAsync(T entity);
        Task<int> UpdateRange(IEnumerable<T> entities);
    }
}