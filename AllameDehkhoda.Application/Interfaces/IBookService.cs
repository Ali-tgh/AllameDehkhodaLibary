using AllameDehkhoda.Application.Common;
using AllameDehkhoda.Application.DTO;

namespace AllameDehkhoda.Application.Interfaces
{
    public interface IBookService
    {
        Task<List<BookDTO>> GetAllBookAsync(bool includeIsDeleted = false);
        Task<BookDTO> GetBookByIdAsync(int id);
        Task<ServiceResult> AddbookAsync(BookDTO bookdto);
        Task<ServiceResult> DeleteBookAsync(int id);
        Task<ServiceResult> UpdateBookAsync(BookDTO bookdto);
        Task<ServiceResult> RestoreBookAsync(int id);
        Task<BookDTO> GetByISBNAsync(string isbn);
        Task<List<BookReportDTO>> GetBookReportAsync(string? isbn , string? title = null);


    }
}
