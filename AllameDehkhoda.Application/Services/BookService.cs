using AllameDehkhoda.Application.Common;
using AllameDehkhoda.Application.DTO;
using AllameDehkhoda.Application.Interfaces;
using AllameDehkhoda.Domain.Entites;
using AllameDehkhoda.Domain.Intrefaces;

namespace AllameDehkhoda.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<ServiceResult> AddbookAsync(BookDTO bookdto)
        {
            try
            {
                var book = new Book
                {
                    Title = bookdto.Title,
                    AuthorName = bookdto.AuthorName,
                    ISBN = bookdto.ISBN,
                    TotalCount = bookdto.TotalCount,
                    PublishYear = bookdto.PublishYear,
                    CategoryId = bookdto.CategoryId,
                    IsDeleted = bookdto.IsDeleted,
                    AvailableCount = bookdto.AvailableCount

                };
                await _bookRepository.AddAsync(book);
                return ServiceResult.Succes(BookMessages.BookAdded);
            }
            catch
            {
                return ServiceResult.Failure(BookMessages.UnknownError);
            }
        }

        public async Task<ServiceResult> DeleteBookAsync(int id)
        {
            try
            {
                var book = await _bookRepository.GetByIdAsync(id);
                if (book == null)
                    return ServiceResult.Failure(BookMessages.BookNotFound);
                if (book.IsDeleted)
                    return ServiceResult.Failure(BookMessages.BookAlreadyDeleted);
                book.IsDeleted = true;
                await _bookRepository.UpdateAsync(book);

                return ServiceResult.Succes(BookMessages.BookDeleted);
            }
            catch
            {
                return ServiceResult.Failure(BookMessages.UnknownError);
            }
        }

        public async Task<List<BookDTO>> GetAllBookAsync(bool includeIsDeleted = false)
        {
            List<Book> books;
            if (includeIsDeleted)
            {
                books = await _bookRepository.FindAsync(b => b.IsDeleted);
            }
            else
                books = await _bookRepository.FindAsync(b => !b.IsDeleted);
            var result = books.Select(b => new BookDTO
            {
                Id = b.Id,
                Title = b.Title,
                AuthorName = b.AuthorName,
                CategoryId = b.CategoryId,
                PublishYear = b.PublishYear,
                ISBN = b.ISBN,
                IsDeleted = b.IsDeleted,
                TotalCount = b.TotalCount,
                AvailableCount = b.AvailableCount
            }).ToList();
            return result;
        }

        public async Task<BookDTO> GetBookByIdAsync(int id)
        {
            var book = await _bookRepository.GetByIdAsync(id);
            if (book == null)
                return null;
            return new BookDTO
            {
                Id = book.Id,
                Title = book.Title,
                AuthorName = book.AuthorName,
                CategoryId = book.CategoryId,
                PublishYear = book.PublishYear,
                ISBN = book.ISBN,
                IsDeleted = book.IsDeleted,
                TotalCount = book.TotalCount,
                AvailableCount = book.AvailableCount
            };
        }

        public async Task<List<BookReportDTO>> GetBookReportAsync(string? isbn, string? title = null)
        {
           var book = await _bookRepository.GetReportDataAsync(isbn, title);
            var result = book.Select(b => new BookReportDTO
            {
                ISBN = b.ISBN,
                Title = b.Title,
                AurtherName = b.AuthorName,
                TotalBorrow = b.Borrows.Count(),
                ReturnCount = b.Borrows.Count(b => b.ReturnDate != null),
                ActiveCount = b.Borrows.Count(b => b.ReturnDate == null && b.DueDate >= DateTime.Now),
                OverDueCount = b.Borrows.Count(b => b.ReturnDate == null && b.DueDate <= DateTime.Now),
            }).ToList();
            return result;
        }

        public async Task<BookDTO> GetByISBNAsync(string isbn)
        {
            var book = await _bookRepository.GetByISBNAsync(isbn);
            if (book == null)
                return null;
            var avialbleCount = await _bookRepository.GetAvailbleCountByISBNAsync(isbn);
            return new BookDTO
            {
                Id = book.Id,
                Title = book.Title,
                ISBN = book.ISBN,
                AuthorName = book.AuthorName,
                AvailableCount = avialbleCount,
                TotalCount = book.TotalCount
            };
        }

        public async Task<ServiceResult> RestoreBookAsync(int id)
        {
            try
            {
                var book = await _bookRepository.GetByIdAsync(id);
                if (book == null)
                    return ServiceResult.Failure(BookMessages.BookNotFound);
                book.IsDeleted = false;
                await _bookRepository.UpdateAsync(book);
                return ServiceResult.Succes(BookMessages.BookRestore);
            }
            catch
            {
                return ServiceResult.Failure(BookMessages.UnknownError);
            }
        }

        public async Task<ServiceResult> UpdateBookAsync(BookDTO bookdto)
        {
            try
            {
                var book = await _bookRepository.GetByIdAsync(bookdto.Id);
                if (book == null)
                    return ServiceResult.Failure(BookMessages.BookNotFound);
                book.Title = bookdto.Title;
                book.AuthorName = bookdto.AuthorName;
                book.ISBN = bookdto.ISBN;
                book.PublishYear = bookdto.PublishYear;
                book.CategoryId = bookdto.CategoryId;
                book.TotalCount = bookdto.TotalCount;
                await _bookRepository.UpdateAsync(book);
                return ServiceResult.Succes(BookMessages.BookUpdate);
            }
            catch
            {
                return ServiceResult.Failure(BookMessages.UnknownError);
            }
        }
    }
}
