using AllameDehkhoda.Application.Common;
using AllameDehkhoda.Application.DTO;
using AllameDehkhoda.Application.Interfaces;
using AllameDehkhoda.Domain.Entites;
using AllameDehkhoda.Domain.Intrefaces;

namespace AllameDehkhoda.Application.Services
{
    public class BorrowService : IBorrowService
    {
        private readonly IBorrowRepository _borrowRepository;
        private readonly IBookRepository _bookRepository;

        public BorrowService(IBorrowRepository borrowRepository, IBookRepository bookRepository)
        {
            _borrowRepository = borrowRepository;
            _bookRepository = bookRepository;
        }

        public async Task<ServiceResult> AddBorrowAsync(BorrowDTO borrowDTO)
        {
            try
            {
                var book = await _bookRepository.GetByIdAsync(borrowDTO.BookId);
                if (book == null)
                    return ServiceResult.Failure(BookMessages.BookNotFound);
                var activBorrows = await _borrowRepository.FindAsync(b => b.BookId == book.Id && b.ReturnDate == null);
                int activ = activBorrows.Count;
                if (book.TotalCount - activ <= 0)
                    return ServiceResult.Failure(BorrowMessage.BookNotExistForBorrow);
                var borrow = new Borrow
                {
                    MemberId = borrowDTO.MemberId,
                    BookId = borrowDTO.BookId,
                    DueDate = borrowDTO.DueDate,
                    BorrowDate = borrowDTO.BorrowDate,
                    IsReturned = false

                };
                await _borrowRepository.AddAsync(borrow);
                return ServiceResult.Succes(BorrowMessage.BorrowAdded);

            }
            catch
            {
                return ServiceResult.Failure(BorrowMessage.UnknownError);
            }
        }

        public async Task<ServiceResult> DeleteBorrowAsync(int id)
        {
            try
            {
                await _borrowRepository.DeleteAsync(id);
                return ServiceResult.Succes(BorrowMessage.BorrowDeleted);
            }
            catch
            {
                return ServiceResult.Failure(BorrowMessage.UnknownError);
            }
        }

        public async Task<List<BorrowDTO>> GetAllBorrowAsync()
        {
            var borrows = await _borrowRepository.GetAllAsync();
            return borrows.Select(b => new BorrowDTO
            {
                Id = b.Id,
                BookId = b.BookId,
                DueDate = b.DueDate,
                BorrowDate = b.BorrowDate,
                IsReturned = b.IsReturned,
                MemberId = b.MemberId,
                ReturnDate = b.ReturnDate

            }).ToList();

        }

        public async Task<BorrowDTO> GetBorrowByIdAsync(int id)
        {
            var borrow = await _borrowRepository.GetByIdAsync(id);
            return new BorrowDTO
            {
                Id = borrow.Id,
                BookId = borrow.BookId,
                DueDate = borrow.DueDate,
                MemberId = borrow.MemberId,
                ReturnDate = borrow.ReturnDate,
                BorrowDate = borrow.BorrowDate,
                IsReturned = borrow.IsReturned,
            };
        }

        public async Task<List<BorrowReportDTO>> GetBorrowReportAsync(DateTime fromDate, DateTime toDate, string? ssn
            , string? booktitle, string? status)
        {
            var borrows = await _borrowRepository.GetReportDataAsync(fromDate, toDate, ssn, booktitle, status);
            return borrows.Select(b => new BorrowReportDTO
            {
                Id = b.Id,
                MemberName = b.Member.FirstName + " " + b.Member.LastName,
                SSN = b.Member.SocialSecurityNumber,
                BookTitle = b.Book.Title,
                ISBN = b.Book.ISBN,
                BorrowDate = b.BorrowDate,
                DueDate = b.DueDate,
                ReturnDate = b.ReturnDate,
                Status = b.ReturnDate != null ? "بازگشت داده شده" : (b.DueDate < DateTime.Now ? "موعد گذشته" : "در امانت")
            }).ToList();
        }

        public async Task<ServiceResult> UpdateBorrowAsync(BorrowDTO borrowDTO)
        {
            try
            {
                var borrow = await _borrowRepository.GetByIdAsync(borrowDTO.Id);
                if (borrow == null)
                    return ServiceResult.Failure(BorrowMessage.BorrowNotFound);
                borrow.Id = borrowDTO.Id;
                borrow.MemberId = borrowDTO.MemberId;
                borrow.BookId = borrowDTO.BookId;
                borrow.BorrowDate = borrowDTO.BorrowDate;
                borrow.DueDate = borrowDTO.DueDate;
                borrow.IsReturned = borrowDTO.IsReturned;
                borrow.ReturnDate = borrowDTO.ReturnDate;
                await _borrowRepository.UpdateAsync(borrow);
                return ServiceResult.Succes(BorrowMessage.BorrowUpdated);
            }
            catch
            {
                return ServiceResult.Failure(BorrowMessage.UnknownError);
            }
        }
    }
}
