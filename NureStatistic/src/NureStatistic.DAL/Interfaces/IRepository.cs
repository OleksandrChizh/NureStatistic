using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NureStatistic.DAL.Interfaces
{
    public interface IRepository<T, in TKey>
    {
        Task<T> GetAsync(TKey id);

        Task<IQueryable<T>> FindAsync(Expression<Func<T, bool>> expression = null);

        Task CreateAsync(T item);

        Task UpdateAsync(T item);

        Task DeleteAsync(TKey id);

        Task<int> GetCountAsync(Expression<Func<T, bool>> expression = null);
    }
}
