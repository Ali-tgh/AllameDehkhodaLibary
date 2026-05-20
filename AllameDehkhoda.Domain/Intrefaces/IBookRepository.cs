using AllameDehkhoda.Domain.Entites;

namespace AllameDehkhoda.Domain.Intrefaces
{
    public interface IBookRepository:IRepository<Book>
    {
        Task<Book> GetByISBNAsync(string isbn);
        Task<int> GetAvailbleCountByISBNAsync(string isbn);
        Task<List<Book>> GetReportDataAsync(string isbn , string title);
    }
}
