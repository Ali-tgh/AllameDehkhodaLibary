using AllameDehkhoda.Domain.Entites;
using AllameDehkhoda.Domain.Intrefaces;
using AllameDehkhoda.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AllameDehkhoda.Infrastructure.Repository
{
    public class BorrowRepository : BaseRepository<Borrow>, IBorrowRepository
    {
        private readonly IDbContextFactory<AppDbContext> _contextfactory;

        public BorrowRepository(IDbContextFactory<AppDbContext> contextFactory) : base(contextFactory)
        {
            _contextfactory = contextFactory;
        }

        public async Task<List<Borrow>> GetReportDataAsync(DateTime fromDate, DateTime toDate, string? ssn, string? booktitle, string? status)
        {
            using var context = await _contextfactory.CreateDbContextAsync();
            var query = context.Borrows.Include(b => b.Book).Include(b => b.Member)
                .Where(b => b.BorrowDate >= fromDate && b.BorrowDate <= toDate).AsQueryable();
            if (!string.IsNullOrEmpty(ssn))
                query = query.Where(b => b.Member.SocialSecurityNumber.Contains(ssn));
            if (!string.IsNullOrEmpty(booktitle))
                query = query.Where(b => b.Book.Title.Contains(booktitle));
            if (!string.IsNullOrEmpty(status) && status != "همه")
            {
                if (status == "بازگشت داده شده")
                    query = query.Where(b => b.ReturnDate != null);
                if (status == "در امانت")
                    query = query.Where(b => b.ReturnDate == null && b.DueDate >= DateTime.Now);
                if (status == "موعد گذشته")
                    query = query.Where(b => b.ReturnDate == null && b.DueDate <= DateTime.Now);
            }
            return await query.OrderByDescending(b => b.BorrowDate).ToListAsync();

        }
    }
}