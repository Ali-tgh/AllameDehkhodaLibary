using AllameDehkhoda.Application.Common;
using AllameDehkhoda.Application.DTO;

namespace AllameDehkhoda.Application.Interfaces
{
    public interface IBorrowService
    {
        Task<List<BorrowDTO>> GetAllBorrowAsync();
        Task<BorrowDTO> GetBorrowByIdAsync(int id);
        Task<ServiceResult> AddBorrowAsync(BorrowDTO borrowDTO);
        Task<ServiceResult> UpdateBorrowAsync(BorrowDTO borrowDTO);
        Task<ServiceResult> DeleteBorrowAsync(int id);
        Task<List<BorrowReportDTO>> GetBorrowReportAsync(DateTime fromDate, DateTime toDate
            , string? ssn, string? booktitle, string? status);

    }
}
