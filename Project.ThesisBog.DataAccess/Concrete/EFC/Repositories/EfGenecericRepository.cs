using Microsoft.EntityFrameworkCore;
using Project.ThesisBlog.Entities.Interface;
using Project.ThesisBog.DataAccess.Concrete.EFC.Context;
using Project.ThesisBog.DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.ThesisBog.DataAccess.Concrete.EFC.Repositories
{
    public class EfGenecericRepository<T> : IGenericBranch<T> where T : class, ITablo, new()
    {
        public async Task AddAsync(T entity)
        {
            using var context = new ThesisBlogContext();
            await context.AddAsync(entity);
            await context.SaveChangesAsync();

        }

        public async Task<List<T>> GetAllAsync()
        {
            using var context = new ThesisBlogContext();
            return await context.Set<T>().ToListAsync();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter)
        {
            using var context = new ThesisBlogContext();
            return await context.Set<T>().Where(filter).ToListAsync();
        }
        public async Task<List<T>> GetAllAsync<TKey>(Expression<Func<T, bool>> filter, Expression<Func<T,TKey>> keySelector)
        {
            using var context = new ThesisBlogContext();
            return await context.Set<T>().Where(filter).OrderByDescending
                (keySelector).ToListAsync();
        }
        public async Task<List<T>> GetAllAsync<TKey>(Expression<Func<T, TKey>> keySelector)
        {
            using var context = new ThesisBlogContext();
            return await context.Set<T>().OrderByDescending
                (keySelector).ToListAsync();
        }

        public async Task<List<T>> GetAsync(Expression<Func<T, bool>> filter)
        {
            using var context = new ThesisBlogContext();
            return await context.Set<T>().FirstOrDefaultAsync(filter);
        }

        public Task RemoveAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        Task<T> IGenericBranch<T>.GetAsync(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
