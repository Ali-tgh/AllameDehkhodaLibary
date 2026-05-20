using AllameDehkhoda.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AllameDehkhoda.Infrastructure.Configs
{
    public class BorrowConfig : IEntityTypeConfiguration<Borrow>
    {
        public void Configure(EntityTypeBuilder<Borrow> builder)
        {
            builder.Property(br => br.BorrowDate).IsRequired();
            builder.Property(br => br.IsReturned).IsRequired();
            builder.Property(br => br.DueDate).IsRequired();

        }
    }
}
