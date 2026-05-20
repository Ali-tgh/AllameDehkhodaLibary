using AllameDehkhoda.Application.Interfaces;
using AllameDehkhoda.Presentation.Common;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AllameDehkhoda.Presentation
{
    public partial class FrmReport : Form
    {

        private readonly IBorrowService _borrowService;
        private readonly IMemberService _memberService;
        private readonly IBookService _bookService;
        public FrmReport(IBorrowService borrowService, IMemberService memberService, IBookService bookService)
        {
            InitializeComponent();
            _borrowService = borrowService;
            _memberService = memberService;
            _bookService = bookService;
        }
        public void SelectTab(string tabName)
        {
            var tab = tabReport.TabPages[tabName];
            if (tab != null)
                tabReport.SelectTab(tab);
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = DateTime.Now.AddMonths(-6);
            dtpToDate.Value = DateTime.Now.AddDays(+14);
            cmbBorrowStatus.Items.AddRange(new string[] { "بازگشت داده شده", "موعد گذشته", "در امانت", "همه" });
            cmbBorrowStatus.SelectedIndex = 0;

            cmbMemberStatus.Items.Clear();
            cmbMemberStatus.Items.AddRange(new string[] { "فعال", "غیر فعال", "همه" });
            cmbMemberStatus.SelectedIndex = 0;
        }

        private async void btnBorrowReport_Click(object sender, EventArgs e)
        {
            var fromDate = dtpFromDate.Value;
            var toDate = dtpToDate.Value;
            string ssn = txtSSNSearch.Text;
            string bookTitle = txtBookTitleSearch.Text;
            string status = cmbBorrowStatus.SelectedItem.ToString();
            var report = await _borrowService.GetBorrowReportAsync(fromDate, toDate, ssn, bookTitle, status);
            var reportdata = report.Select(r => new
            {
                شناسه = r.Id,
                کد_ملی = r.SSN,
                نام_عضو = r.MemberName,
                نام_کتاب = r.BookTitle,
                شابک = r.ISBN,
                تاریخ_امانت = DateTimeFuncs.ToShamsi(r.BorrowDate),
                وضعیت = r.Status
            }).ToList();
            dgvBorrowreport.DataSource = null;
            dgvBorrowreport.AutoGenerateColumns = true;
            dgvBorrowreport.DataSource = reportdata;
            dgvBorrowreport.ClearSelection();

        }


        private async void btnMemberSearch_Click(object sender, EventArgs e)
        {
            string ssn = txtMemberSSN.Text;
            string firstName = txtMemberFirstName.Text;
            string lastName = txtMemberLastName.Text;
            string status = cmbMemberStatus.SelectedItem.ToString() ?? "همه";
            var report = await _memberService.GetmemberReportAsync(ssn, firstName, lastName, status);
            dgvmemberReport.DataSource = report.Select(m => new
            {
                نام = m.FullName,
                شماره_تلفن = m.Phone,
                ادرس = m.Address,
                تاریخ_عضویت = DateTimeFuncs.ToShamsi(m.RegisterDate),
                تعداد_امانات = m.TotalBorrowCount,
                امانات_فعال = m.ActiveBorrowCount,
                وضعیت = m.Status

            }).ToList();
        }

        private async void btnBookSearch_Click(object sender, EventArgs e)
        {
            string isbn = txtBookISBN.Text;
            string title = txtBookTitle.Text;
            var result = await _bookService.GetBookReportAsync(isbn, title);
            dgvBookReport.DataSource = result.Select(b => new
            {
                کد_شابک = b.ISBN,
                نام_نویسنده = b.AurtherName,
                مجموع_امانات = b.TotalBorrow,
                تعداد_بازگشت = b.ReturnCount,
                امانات_فعال = b.ActiveCount,
                موعد_گذشته = b.OverDueCount
            }).ToList();
        }

        private void btnSaveBorrowsToExcel_Click_1(object sender, EventArgs e)
        {
            SaveAsXML.SaveToExcel(dgvBorrowreport);
        }

        private void btnSaveMembersToExcel_Click(object sender, EventArgs e)
        {
            SaveAsXML.SaveToExcel(dgvmemberReport);
        }

        private void btnSaveBooksToExcel_Click(object sender, EventArgs e)
        {
            SaveAsXML.SaveToExcel(dgvBookReport);
        }
    }
}
