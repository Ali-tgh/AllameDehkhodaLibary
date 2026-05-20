using AllameDehkhoda.Domain.Entites;
using AllameDehkhoda.Domain.Intrefaces;
using AllameDehkhoda.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AllameDehkhoda.Infrastructure.Repository
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        private readonly IDbContextFactory<AppDbContext> _contextfactory;
        public BookRepository(IDbContextFactory<AppDbContext> contextFactory) : base(contextFactory)
        {
            _contextfactory = contextFactory;
        }

        public async Task<int> GetAvailbleCountByISBNAsync(string isbn)
        {
            using var context = await _contextfactory.CreateDbContextAsync();
            var availble = await context.Books.Where(b => b.ISBN == isbn)
                 .Select(b => b.TotalCount - context.Borrows
                 .Count(br => br.BookId == b.Id && br.ReturnDate == null)).FirstOrDefaultAsync();
            return Math.Max(0, availble);
        }

        public async Task<Book> GetByISBNAsync(string isbn)
        {
            using var context = await _contextfactory.CreateDbContextAsync();
            return await context.Books.FirstOrDefaultAsync(b => b.ISBN == isbn);
        }

        public async Task<List<Book>> GetReportDataAsync(string isbn, string title)
        {
            using var context = await _contextfactory.CreateDbContextAsync();
            var query = context.Books.Include(b => b.Borrows).Where(b => !b.IsDeleted);
            if (!string.IsNullOrEmpty(isbn))
                query = query.Where(b => b.ISBN == isbn);
            if (!string.IsNullOrEmpty(title))
                query = query.Where(b => b.Title.Contains(title));
            return await query.ToListAsync();
        }
    }

}