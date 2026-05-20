using AllameDehkhoda.Application.DTO;
using AllameDehkhoda.Application.Interfaces;
using AllameDehkhoda.Presentation.Common;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AllameDehkhoda.Presentation
{
    public partial class FrmBorrow : Form
    {
        private MemberDTO? _selectMember;
        private BookDTO? _selectBook;
        //services
        private readonly IServiceProvider _serviceProvider;
        private readonly IBookService _bookService;
        private readonly IMemberService _memberService;
        private readonly IBorrowService _borrowService;
        public FrmBorrow(IServiceProvider serviceProvider, IBookService bookService,
            IMemberService memberService, IBorrowService borrowService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _bookService = bookService;
            _memberService = memberService;
            _borrowService = borrowService;
        }
        private async Task LoadBorrowsAsync(bool showReturn = true)
        {
            var borrows = await _borrowService.GetAllBorrowAsync();
            if (!showReturn)
                borrows = borrows.Where(b => !b.IsReturned).ToList();
            else
                borrows = borrows.Where(b => b.IsReturned).ToList();
            var members = await _memberService.GetAllMemberAsync();
            var books = await _bookService.GetAllBookAsync();
            var rows = borrows.Select(b => new
            {
                شناسه = b.Id,
                شناسه_عضو = b.MemberId,
                نام_عضو = GetMemberName(members, b.MemberId),
                شناسه_کتاب = b.BookId,
                اسم_کتاب = GetBookName(books, b.BookId),
                تاریخ_امانت = DateTimeFuncs.ToShamsi(b.BorrowDate),
                تاریخ_بازگشت = b.ReturnDate != null ? DateTimeFuncs.ToShamsi(b.ReturnDate.Value) : "در امانت",
                موعود_بازگشت = DateTimeFuncs.ToShamsi(b.DueDate),
                وضعیت = b.IsReturned ? "بازگشت داده شده" : (b.DueDate < DateTime.Now ? "موعود گذشته" : "در امانت")
            }).OrderByDescending(x => x.موعود_بازگشت).ToList();
            dgvBorrows.DataSource = null;
            dgvBorrows.AutoGenerateColumns = true;
            dgvBorrows.DataSource = rows;
            dgvBorrows.ClearSelection();

        }

        private object GetBookName(List<BookDTO> books, int bookId)
        {
            var book = books.FirstOrDefault(b => b.Id == bookId);
            return book == null ? "_" : book.Title;
        }


        private object GetMemberName(List<MemberDTO> members, int memberId)
        {
            var member = members.FirstOrDefault(m => m.Id == memberId);
            return member == null ? "_" : $"{member.FirstName} {member.LastName}";
        }

        private void ClearForm()
        {
            txtSSNSearch.Text = string.Empty;
            txtISBNSearch.Text = string.Empty;
            lblBookSearchResult.Text = string.Empty;
            lblMemberSearchResult.Text = string.Empty;
            dtpBorrowDate.Value = DateTime.Now;
            dtpReturnedDate.Value = DateTime.Now;
            txtSSNSearch.Focus();
            chkActivBorrows.Checked = false;

        }
        private async void FrmBorrow_Load(object sender, EventArgs e)
        {
            ClearForm();
            await LoadBorrowsAsync();
        }

        private void frmBooks_Click(object sender, EventArgs e)
        {
            using var scope = _serviceProvider.CreateAsyncScope();
            var form = scope.ServiceProvider.GetRequiredService<FrmBook>();
            form.ShowDialog();
        }

        private void frmMembers_Click(object sender, EventArgs e)
        {
            using var scope = _serviceProvider.CreateAsyncScope();
            var form = scope.ServiceProvider.GetRequiredService<FrmMember>();
            form.ShowDialog();
        }

        private void ExitFrm_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private async void btnAddBorrow_Click(object sender, EventArgs e)
        {
            if (_selectMember == null)
            {
                MessageBox.Show("لطفا کد ملی عضو را برای ثبت امانت وارد نمایید!", "خطا"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_selectBook == null)
            {
                MessageBox.Show("لطفا کد شابک کتاب را برای ثبت امانت وارد نمایید!", "خطا"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_selectBook.AvailableCount <= 0)
            {
                MessageBox.Show("!در حال حاضر نسخه ای از این کتاب موجود نمیباشد", "توجه"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var allowBorrow = await _borrowService.GetAllBorrowAsync();
            bool memberHasThisBook = allowBorrow.Any(x => x.MemberId == _selectMember.Id &&
            x.BookId == _selectBook.Id && !x.IsReturned);
            if (memberHasThisBook)
            {
                MessageBox.Show($"{_selectMember.FirstName} {_selectMember.LastName}" +
                    $" در حال حاضر کتاب {_selectBook.Title} را در امانت دارد", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var borrow = new BorrowDTO
            {
                MemberId = _selectMember.Id,
                BookId = _selectBook.Id,
                IsReturned = false,
                BorrowDate = dtpBorrowDate.Value,
                DueDate = dtpBorrowDate.Value.Date.AddDays(14),
                ReturnDate = null
            };
            var result = await _borrowService.AddBorrowAsync(borrow);
            UIHelper.ShowResult(result.IsSucces, result.Message);
            if (result.IsSucces)
            {
                ClearForm();
                await LoadBorrowsAsync();
            }
        }

        private async void chkActivBorrows_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActivBorrows.Checked)
                await LoadBorrowsAsync(false);
            else
                await LoadBorrowsAsync(true);
        }

        private async void btnReturnBorrow_Click(object sender, EventArgs e)
        {
            UIHelper.HasSelectedRow(dgvBorrows, "امانت");
            var borrowId = UIHelper.GetSelectedCellValu(dgvBorrows, "شناسه");
            var borrow = await _borrowService.GetBorrowByIdAsync(borrowId);
            if (borrow == null)
            {
                MessageBox.Show("!اطلاعات مورد نظر یافت نشد", "خطا"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (borrow.IsReturned)
            {
                MessageBox.Show("!این کتاب قبلا بازگشت داده شده است", "توجه"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            borrow.ReturnDate = dtpReturnedDate.Value;
            borrow.IsReturned = true;
            var result = await _borrowService.UpdateBorrowAsync(borrow);
            UIHelper.ShowResult(result.IsSucces, result.Message);
            chkActivBorrows.Checked = false;
            await LoadBorrowsAsync();


        }

        private async void txtSSNSearch_TextChanged(object sender, EventArgs e)
        {
            string ssn = txtSSNSearch.Text;
            if (string.IsNullOrEmpty(ssn))
            {
                lblMemberSearchResult.Text = string.Empty;
                return;
            }
            _selectMember = await _memberService.FindBySSNAsync(ssn);
            if (_selectMember == null)
            {
                lblMemberSearchResult.ForeColor = Color.Red;
                lblMemberSearchResult.Text = "عضوی با این کد ملی وجود ندارد!";
            }
            else
            {
                lblMemberSearchResult.ForeColor = Color.Black;
                lblMemberSearchResult.Text = $"نام و نام خانوادگی : {_selectMember.FirstName} {_selectMember.LastName}";
            }
        }

        private async void txtISBNSearch_TextChanged(object sender, EventArgs e)
        {
            string isbn = txtISBNSearch.Text;
            if (string.IsNullOrEmpty(isbn))
            {
                lblBookSearchResult.Text = string.Empty;
                return;
            }
            _selectBook = await _bookService.GetByISBNAsync(isbn);
            if (_selectBook == null)
            {
                lblBookSearchResult.ForeColor = Color.Red;
                lblBookSearchResult.Text = "کتابی با این کد شابک وجود ندارد!";
            }
            else
            {
                lblBookSearchResult.ForeColor = Color.Black;
                lblBookSearchResult.Text = $"نام کتاب : {_selectBook.Title}\n" +
                    $"نام نویسنده : {_selectBook.AuthorName}\n" +
                    $"موجودی کتاب : {_selectBook.AvailableCount} از {_selectBook.TotalCount}";
            }
        }

        private void reportBorrows_Click(object sender, EventArgs e)
        {
            var scope = _serviceProvider.CreateScope();
            var form = scope.ServiceProvider.GetRequiredService<FrmReport>();
            form.SelectTab("TrustReportTab");
            form.Show();
        }

        private void reportMembers_Click(object sender, EventArgs e)
        {
            var scope = _serviceProvider.CreateScope();
            var form = scope.ServiceProvider.GetRequiredService<FrmReport>();
            form.SelectTab("MemberReportTab");
            form.Show();
        }

        private void reportBooks_Click(object sender, EventArgs e)
        {
            var scope = _serviceProvider.CreateScope();
            var form = scope.ServiceProvider.GetRequiredService<FrmReport>();
            form.SelectTab("BookReportTab");
            form.Show();
        }
    }
}
