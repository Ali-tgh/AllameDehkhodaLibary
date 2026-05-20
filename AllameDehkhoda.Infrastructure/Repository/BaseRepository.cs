using AllameDehkhoda.Domain.Intrefaces;
using AllameDehkhoda.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AllameDehkhoda.Infrastructure.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly IDbContextFactory<AppDbContext> _contextfactory;
        public BaseRepository(IDbContextFactory<AppDbContext> contextFactory)
        { 
            _contextfactory = contextFactory; 
        }
        public async Task AddAsync(T entity)
        {
            await using var context =await _contextfactory.CreateDbContextAsync();
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await using var context = await _contextfactory.CreateDbContextAsync();
            var entity =await context.Set<T>().FindAsync(id);
            if(entity != null)
            {
                context.Remove(entity);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            await using var context = await _contextfactory.CreateDbContextAsync();
            return await context.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            await using var context = await _contextfactory.CreateDbContextAsync();
            return await context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            await using var context =await _contextfactory.CreateDbContextAsync();
            return await context.Set<T>().FindAsync(id);
            
        }
        public async Task UpdateAsync(T entity)
        {
            await using var context =await _contextfactory.CreateDbContextAsync();
            context.Set<T>().Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
