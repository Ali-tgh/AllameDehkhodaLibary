using AllameDehkhoda.Domain.Entites;
using AllameDehkhoda.Domain.Intrefaces;
using AllameDehkhoda.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AllameDehkhoda.Infrastructure.Repository
{
    public class MemberRepository : BaseRepository<Member>, IMemberRepository
    {
        private readonly IDbContextFactory<AppDbContext> _contextfactory;

        public MemberRepository(IDbContextFactory<AppDbContext> contextFactory) : base(contextFactory)
        {
            _contextfactory = contextFactory;
        }

        public async Task<Member> GetBySSNAsync(string ssn)
        {
            using var context = await _contextfactory.CreateDbContextAsync();
            return await context.Members.FirstOrDefaultAsync(m => m.SocialSecurityNumber == ssn);
        }

        public async Task<List<Member>> GetReportDataAsync(string ssn, string? firstName, string? lastName, string status)
        {
            using var context = await _contextfactory.CreateDbContextAsync();
            var query = context.Members.Include(m => m.Borrows).AsQueryable();
            if (!string.IsNullOrEmpty(ssn))
                query = query.Where(m => m.SocialSecurityNumber == ssn);
            if (!string.IsNullOrEmpty(firstName))
                query = query.Where(m => m.FirstName.Contains(firstName));
            if (!string.IsNullOrEmpty(lastName))
                query = query.Where(m => m.LastName.Contains(lastName));
            if (!string.IsNullOrEmpty(status) && status != "همه")
            {
                if (status == "فعال")
                    query = query.Where(m => m.Borrows.Any(b => b.ReturnDate == null));
                if (status == "غیر فعال")
                    query = query.Where(m => m.Borrows.Any(b => b.ReturnDate != null));
            }
            return await query.OrderBy(m => m.LastName).ThenBy(m => m.FirstName).ToListAsync();
        }


    }
}