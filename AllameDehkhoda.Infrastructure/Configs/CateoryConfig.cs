using AllameDehkhoda.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AllameDehkhoda.Infrastructure.Configs
{
    public class CateoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(200);
            //seed data 
            builder.HasData(
                new Category {Id=1,Name="علمی",Description="کتاب های علمی"},
                new Category { Id =2, Name = "داستان", Description = "کتاب های داستان" },
                new Category { Id =3, Name = "رمان", Description = "کتاب های رمان" },
                new Category { Id =4, Name = "تاریخی", Description = "کتاب های تاریخی" },
                new Category { Id =5, Name = "تخیلی", Description = "کتاب های تخیلی" }
                );
        }
    }
}
