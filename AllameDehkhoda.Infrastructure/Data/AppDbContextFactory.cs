using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace AllameDehkhoda.Infrastructure.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionbuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionbuilder.UseSqlServer("Server=.;Initial Catalog=AllameDehkhodaDB;" +
                "Integrated Security=True;Trust Server Certificate=True");
            return new AppDbContext(optionbuilder.Options);
        }
    }
}
