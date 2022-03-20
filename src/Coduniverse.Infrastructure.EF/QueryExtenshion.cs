using Coduniverse.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Coduniverse.Infrastructure.EF
{
    public static class QueryExtenshion
    {
        public static IQueryable<T> GetQuery<T>(this DbSet<T> dbset,
                                                Expression<Func<T, bool>> predicate,
                                                Expression<Func<T, object>>[] includes) where T : BaseEntity
        {
            var query = dbset.AsNoTracking();

            if(includes is not null)
                query = includes.Aggregate(query, (cur, prop) => cur.Include(prop));

            if(predicate is not null)
                query = query.Where(predicate);

            return query;
        }
    }
}