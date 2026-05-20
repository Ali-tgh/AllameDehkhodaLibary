using AllameDehkhoda.Domain.Entites;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace AllameDehkhoda.Infrastructure.Configs
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(b => b.Title).IsRequired().HasMaxLength(200);
            builder.Property(b => b.AuthorName).IsRequired().HasMaxLength(100);
            builder.Property(b => b.ISBN).IsRequired().HasMaxLength(10);
            builder.Property(b => b.PublishYear).IsRequired();
            builder.Property(b => b.TotalCount).IsRequired();
            builder.Ignore(b => b.AvailableCount);
            builder.HasOne(b => b.Category).WithMany(c => c.Books).HasForeignKey(b => b.CategoryId);
            builder.HasMany(b => b.Borrows).WithOne(br => br.Book).HasForeignKey(b => b.BookId);
        }
    }
}
