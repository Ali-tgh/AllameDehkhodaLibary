using AllameDehkhoda.Domain.Entites;
using AllameDehkhoda.Domain.Intrefaces;
using AllameDehkhoda.Infrastructure.Data;
using AllameDehkhoda.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace AllameDehkhoda.Infrastructure.Extentions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDependencyInjection(this IServiceCollection services)
        {
            services.AddDbContextFactory<AppDbContext>();
            services.AddScoped(typeof(IRepository<>) , typeof(BaseRepository<>));
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IBorrowRepository, BorrowRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IMemberRepository, MemberRepository>();
            return services;
        }
    }
}
