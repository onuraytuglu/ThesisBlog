using Project.ThesisBlog.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.ThesisBog.DataAccess.Interface
{
    public interface IGenericBranch<T> where T : class, ITablo, new()
    {
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetAllAsync<TKey>(Expression<Func<T, TKey>> 
            keySelector);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter);
        Task<List<T>> GetAllAsync<TKey>(Expression<Func<T, bool>> filter,
            Expression<Func<T, TKey>> keySelector);
        Task<T> GetAsync(Expression<Func<T, bool>> filter);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
    }
}
