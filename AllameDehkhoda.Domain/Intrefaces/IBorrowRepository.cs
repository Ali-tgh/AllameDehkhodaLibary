using AllameDehkhoda.Domain.Entites;

namespace AllameDehkhoda.Domain.Intrefaces
{
    public interface IBorrowRepository : IRepository<Borrow>
    {
        Task<List<Borrow>> GetReportDataAsync(DateTime fromDate, DateTime toDate
            , string? ssn, string? booktitle, string? status);
    }
}
