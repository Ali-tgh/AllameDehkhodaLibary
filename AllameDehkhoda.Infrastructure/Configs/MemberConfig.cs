using AllameDehkhoda.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AllameDehkhoda.Infrastructure.Configs
{
    public class MemberConfig : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(m => m.FirstName).IsRequired().HasMaxLength(200);
            builder.Property(m =>m.LastName).IsRequired().HasMaxLength(200);
            builder.Property(m=>m.PhoneNumber).IsRequired().HasMaxLength(200);
            builder.Property(m=>m.Address).IsRequired().HasMaxLength(200);
            builder.HasMany(m => m.Borrows).WithOne(br => br.Member).HasForeignKey(m => m.MemberId);
        }
    }
}
