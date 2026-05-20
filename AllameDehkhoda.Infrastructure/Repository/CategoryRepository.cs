using AllameDehkhoda.Domain.Entites;
using AllameDehkhoda.Domain.Intrefaces;
using AllameDehkhoda.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AllameDehkhoda.Infrastructure.Repository
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        private readonly IDbContextFactory<AppDbContext> _contextfactory;
        public CategoryRepository(IDbContextFactory<AppDbContext> contextFactory) : base(contextFactory)
        {
            _contextfactory= contextFactory;
        }
    }
}