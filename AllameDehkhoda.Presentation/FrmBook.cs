using AllameDehkhoda.Application.Common;
using AllameDehkhoda.Application.DTO;
using AllameDehkhoda.Application.Interfaces;
using AllameDehkhoda.Presentation.Common;
using Microsoft.Extensions.DependencyInjection;

namespace AllameDehkhoda.Presentation
{
    public partial class FrmBook : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IBookService _bookService;
        private readonly ICategoryService _categoryService;

        public FrmBook(IBookService bookService, ICategoryService categoryService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _bookService = bookService;
            _categoryService = categoryService;
            _serviceProvider = serviceProvider;
        }

        private async Task LoadBookAsync()
        {
            bool includDeleted = chkShowDeletedBook.Checked;
            var books = await _bookService.GetAllBookAsync(includDeleted);
            var filteredBooks = books.Select(b => new
            {
                شناسه = b.Id,
                عنوان_کتاب = b.Title,
                نام_نویسنده = b.AuthorName,
                کد_ISBN = b.ISBN,
                سال_انتشار = b.PublishYear,
                مجموع_نسخه = b.TotalCount
            }).ToList();
            dgvBooks.DataSource = null;
            dgvBooks.AutoGenerateColumns = true;
            dgvBooks.DataSource = filteredBooks;
            dgvBooks.ClearSelection();
            btnRestoreBook.Enabled = includDeleted;

        }
        private async Task LoadCategoryAsync()
        {
            var Categories = await _categoryService.GetAllCategoryAsync();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
            cmbCategory.DataSource = Categories;
        }
        private void ClearForm()
        {
            txtBookTitle.Text = string.Empty;
            txtAutherName.Text = string.Empty;
            txtISBN.Text = string.Empty;
            numPublishYear.Value = 2000;
            numTotalCount.Value = 1;
            cmbCategory.SelectedIndex = 0;
            txtBookTitle.Focus();
        }
        private async void FrmBook_Load(object sender, EventArgs e)
        {
            await LoadBookAsync();
            await LoadCategoryAsync();
            ClearForm();

        }

        private void btnExitfrmBook_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private async void btnAddBook_Click(object sender, EventArgs e)

        {
            if (string.IsNullOrWhiteSpace(txtBookTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAutherName.Text) ||
                string.IsNullOrEmpty(txtISBN.Text))
            {
                MessageBox.Show("!لطفا تمام فیلد های اجباری را پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UIHelper.MaxLength(txtISBN, "کد شابک", 5);
            var book = new BookDTO
            {
                Title = txtBookTitle.Text.Trim(),
                AuthorName = txtAutherName.Text.Trim(),
                ISBN = txtISBN.Text.ToString().Trim(),
                PublishYear = numPublishYear.Value.ToString(),
                TotalCount = (int)numTotalCount.Value,
                CategoryId = (int)cmbCategory.SelectedValue
            };
            var result = await _bookService.AddbookAsync(book);
            if (!UIHelper.MaxLength(txtISBN, "کد شابک", 13))
                return;
            if (result.IsSucces)
            {
                ClearForm();
                await LoadBookAsync();
            }

        }

        private async void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvBooks.SelectedRows.Count == 0)
                return;

            var selectedrow = dgvBooks.SelectedRows[0];
            int bookId = Convert.ToInt32(selectedrow.Cells["شناسه"].Value);
            var book = await _bookService.GetBookByIdAsync(bookId);
            if (book != null)
            {
                txtBookTitle.Text = book.Title;
                txtAutherName.Text = book.AuthorName;
                txtISBN.Text = book.ISBN;
                numPublishYear.Value = Convert.ToUInt32(book.PublishYear);
                numTotalCount.Value = Convert.ToUInt32(book.TotalCount);
                cmbCategory.SelectedValue = book.CategoryId;
            }
            return;



        }

        private async void btnDeleteBook_Click(object sender, EventArgs e)
        {

            if (!UIHelper.HasSelectedRow(dgvBooks, "کتاب")) return;
            var bookId = UIHelper.GetSelectedCellValu(dgvBooks, "شناسه");
            if (UIHelper.ConfirmAction("حذف", "کتاب"))
            {
                var result = await _bookService.DeleteBookAsync(bookId);
                UIHelper.ShowResult(result.IsSucces, result.Message);
                if (result.IsSucces)
                {
                    ClearForm();
                    await LoadBookAsync();
                }
            }


        }

        private async void btnUpdateBook_Click(object sender, EventArgs e)
        {

            if (!UIHelper.HasSelectedRow(dgvBooks, "کتاب")) return;
            var bookId = UIHelper.GetSelectedCellValu(dgvBooks, "شناسه");
            var book = await _bookService.GetBookByIdAsync(bookId);
            bool isChanged = book.Title != txtBookTitle.Text || book.AuthorName != txtAutherName.Text
                || book.ISBN != txtISBN.Text || book.PublishYear != numPublishYear.Value.ToString()
                || book.TotalCount != numTotalCount.Value || book.CategoryId != (int)cmbCategory.SelectedValue;
            if (!isChanged)
            {
                MessageBox.Show("!هیچ تغییری اعمال نشده است", "اخطار",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                UIHelper.ConfirmAction("ویرایش", "کتاب");
                var bookdto = new BookDTO()
                {
                    Id = bookId,
                    Title = txtBookTitle.Text,
                    AuthorName = txtAutherName.Text,
                    ISBN = txtISBN.Text,
                    PublishYear = numPublishYear.Value.ToString(),
                    TotalCount = (int)numTotalCount.Value,
                    CategoryId = (int)cmbCategory.SelectedValue,
                    IsDeleted = book.IsDeleted
                };
                var result = await _bookService.UpdateBookAsync(bookdto);
                UIHelper.ShowResult(result.IsSucces, result.Message);
                if (result.IsSucces)
                {
                    ClearForm();
                    await LoadBookAsync();
                }
            }
        }

        private async void chkShowDeletedBook_CheckedChanged(object sender, EventArgs e)
        {
            await LoadBookAsync();
        }

        private async void btnRestoreBook_Click(object sender, EventArgs e)
        {
            if (!UIHelper.HasSelectedRow(dgvBooks, "کتاب")) return;
            var bookId = UIHelper.GetSelectedCellValu(dgvBooks, "شناسه");

            if (UIHelper.ConfirmAction("بازیابی", "کتاب") && bookId > 0)
            {
                var result = await _bookService.RestoreBookAsync(bookId);
                UIHelper.ShowResult(result.IsSucces, result.Message);
                await LoadBookAsync();
            }
            return;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void frmMember_Click(object sender, EventArgs e)
        {
            using var scope = _serviceProvider.CreateAsyncScope();
            var form = scope.ServiceProvider.GetRequiredService<FrmMember>();
            form.ShowDialog();
        }

        private void frmBorrow_Click(object sender, EventArgs e)
        {
            using var scope = _serviceProvider.CreateAsyncScope();
            var form = scope.ServiceProvider.GetRequiredService<FrmBorrow>();
            form.ShowDialog();
        }
        private void frmBorrowReport_Click(object sender, EventArgs e)
        {
            var scope = _serviceProvider.CreateScope();
            var form = scope.ServiceProvider.GetRequiredService<FrmReport>();
            form.SelectTab("TrustReportTab");
            form.Show();

        }

        private void frmBookReport_Click(object sender, EventArgs e)
        {
            var scope = _serviceProvider.CreateScope();
            var form = scope.ServiceProvider.GetRequiredService<FrmReport>();
            form.SelectTab("BookReportTab");
            form.Show();
        }

        private void frmMemberReport_Click(object sender, EventArgs e)
        {
            var scope = _serviceProvider.CreateScope();
            var form = scope.ServiceProvider.GetRequiredService<FrmReport>();
            form.SelectTab("MemberReportTab");
            form.Show();
        }

        private void frmBorrowReport_Click_1(object sender, EventArgs e)
        {
            var scope = _serviceProvider.CreateScope();
            var form = scope.ServiceProvider.GetRequiredService<FrmReport>();
            form.SelectTab("TrustReportTab");
            form.Show();
        }

        private void frmBookReport_Click_1(object sender, EventArgs e)
        {
            var scope = _serviceProvider.CreateScope();
            var form = scope.ServiceProvider.GetRequiredService<FrmReport>();
            form.SelectTab("BookReportTab");
            form.Show();
        }

        private void frmMemberReport_Click_1(object sender, EventArgs e)
        {
            var scope = _serviceProvider.CreateScope();
            var form = scope.ServiceProvider.GetRequiredService<FrmReport>();
            form.SelectTab("MemberReportTab");
            form.Show();
        }
    }
}

