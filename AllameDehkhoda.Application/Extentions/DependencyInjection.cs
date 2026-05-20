using AllameDehkhoda.Application.Interfaces;
using AllameDehkhoda.Application.Services;
using Microsoft.Extensions.DependencyInjection;
namespace AllameDehkhoda.Application.Extentions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IMemberService, MemberService>();
            services.AddScoped<IBorrowService,BorrowService>();
            return services;
        }
    }
}
