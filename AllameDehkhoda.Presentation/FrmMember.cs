using AllameDehkhoda.Application.DTO;
using AllameDehkhoda.Application.Interfaces;
using AllameDehkhoda.Presentation.Common;
using Azure.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata;
using System.Text;
using System.Windows.Forms;

namespace AllameDehkhoda.Presentation
{
    public partial class FrmMember : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IMemberService _memberService;

        public FrmMember(IServiceProvider serviceProvider, IMemberService memberService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _memberService = memberService;
        }
        public async Task LoadMembersAsync()
        {
            var includeIsDeleted = chkDeletedMembers.Checked;
            var members = await _memberService.GetAllMemberAsync(includeIsDeleted);
            var filteredMembers = members.Select(m => new
            {
                شناسه = m.Id,
                کد_ملی = m.SSN,
                نام = m.FirstName,
                نام_خانوادگی = m.LastName,
                شماره_تماس = m.PhoneNumber,
                آدرس = m.Address,
                تاریخ_عضویت = DateTimeFuncs.ToShamsi(m.RegisterDate)
            }).ToList();
            dgvMembers.DataSource = null;
            dgvMembers.AutoGenerateColumns = true;
            dgvMembers.DataSource = filteredMembers;
            dgvMembers.ClearSelection();
            btnRestorMember.Enabled = includeIsDeleted;
        }


        private void ClearForm()
        {
            txtFirstNameMember.Text = string.Empty;
            txtLastNameMember.Text = string.Empty;
            txtPhoneNumberMember.Text = string.Empty;
            txtAddressMember.Text = string.Empty;
            txtSSNCodeMember.Text = string.Empty;
            dtpRegisterTimeMember.Value = DateTime.Now;
            txtFirstNameMember.Focus();
        }

        private async void FrmMember_Load(object sender, EventArgs e)
        {
            await LoadMembersAsync();
            ClearForm();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }


        private void ExitfrmMember_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private async void btnAddMember_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstNameMember.Text) || string.IsNullOrEmpty(txtLastNameMember.Text)
                || string.IsNullOrEmpty(txtSSNCodeMember.Text) || string.IsNullOrEmpty(txtPhoneNumberMember.Text)
                || string.IsNullOrEmpty(txtAddressMember.Text))
            {
                MessageBox.Show("!لطفا تمام فیلد هارا پر کنید", "اخطار",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!UIHelper.MustBeNumber(txtSSNCodeMember, "کد ملی")) return;
            if (!UIHelper.MaxLength(txtSSNCodeMember, "کد ملی", 10)) return;

            if (!UIHelper.MustBeNumber(txtPhoneNumberMember, "شماره تماس")) return;
            if (!UIHelper.MaxLength(txtPhoneNumberMember, "شماره تماس", 11)) return;
            string phoneNumber = txtPhoneNumberMember.Text.Trim();
            if (!phoneNumber.StartsWith("09"))
            {
                MessageBox.Show("شماره تماس باید با 09 شروع شود", "خطا",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var member = new MemberDTO
            {
                FirstName = txtFirstNameMember.Text,
                LastName = txtLastNameMember.Text,
                Address = txtAddressMember.Text,
                PhoneNumber = txtPhoneNumberMember.Text,
                SSN = txtSSNCodeMember.Text,
                RegisterDate = dtpRegisterTimeMember.Value,
                IsDeleted = false
            };
            var result = await _memberService.AddMemberAsync(member);
            UIHelper.ShowResult(result.IsSucces, result.Message);
            if (result.IsSucces)
            {
                ClearForm();
                await LoadMembersAsync();
            }
        }

        private async void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMembers.SelectedRows.Count == 0)
                return;
            var member = UIHelper.GetSelectedCellValu(dgvMembers, "شناسه");
            var result = await _memberService.GetMemberByIdAsync(member);
            if (result != null)
            {
                txtFirstNameMember.Text = result.FirstName;
                txtLastNameMember.Text = result.LastName;
                txtAddressMember.Text = result.Address;
                txtPhoneNumberMember.Text = result.PhoneNumber;
                txtSSNCodeMember.Text = result.SSN;
                dtpRegisterTimeMember.Value = result.RegisterDate;
            }
            return;
        }

        private async void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if (!UIHelper.HasSelectedRow(dgvMembers, "عضو")) return;
            var memberId = UIHelper.GetSelectedCellValu(dgvMembers, "شناسه");
            if (UIHelper.ConfirmAction("حذف", "عضو"))
            {
                var result = await _memberService.DeleteMemberAsync(memberId);
                UIHelper.ShowResult(result.IsSucces, result.Message);
                if (result.IsSucces)
                {
                    ClearForm();
                    await LoadMembersAsync();
                }

            }
            else
                return;
        }

        private async void chkDeletedMembers_CheckedChanged(object sender, EventArgs e)
        {
            await LoadMembersAsync();
        }

        private async void btnEditMember_Click(object sender, EventArgs e)
        {
            if (!UIHelper.HasSelectedRow(dgvMembers, "عضو")) return;
            var memberId = UIHelper.GetSelectedCellValu(dgvMembers, "شناسه");
            var member = await _memberService.GetMemberByIdAsync(memberId);
            bool isChanged = member.FirstName != txtFirstNameMember.Text || member.LastName != txtLastNameMember.Text
                || member.SSN != txtSSNCodeMember.Text || member.PhoneNumber != txtPhoneNumberMember.Text
                || member.RegisterDate != dtpRegisterTimeMember.Value;
            if (UIHelper.ConfirmAction("ویرایش", "عضو"))
            {
                if (isChanged)
                {
                    var newMember = new MemberDTO
                    {
                        Id = member.Id,
                        FirstName = txtFirstNameMember.Text,
                        LastName = txtLastNameMember.Text,
                        SSN = txtSSNCodeMember.Text,
                        PhoneNumber = txtPhoneNumberMember.Text,
                        Address = txtAddressMember.Text,
                        RegisterDate = dtpRegisterTimeMember.Value,
                    };
                    var result = await _memberService.UpdateMemberAsync(newMember);
                    UIHelper.ShowResult(result.IsSucces, result.Message);
                    if (result.IsSucces)
                    {
                        ClearForm();
                        await LoadMembersAsync();
                    }

                }
                else
                {
                    MessageBox.Show("!هیچ تغییری اعمال نشده است", "خطا",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                return;

        }

        private async void btnRestorMember_Click(object sender, EventArgs e)
        {
            if (!UIHelper.HasSelectedRow(dgvMembers, "عضو")) return;
            var memberId = UIHelper.GetSelectedCellValu(dgvMembers, "شناسه");
            if (UIHelper.ConfirmAction("بازیابی", "عضو") && memberId > 0)
            {
                var result = await _memberService.RestoreMemberAsync(memberId);
                UIHelper.ShowResult(result.IsSucces, result.Message);
                await LoadMembersAsync();
            }
            return;
        }

        private void frmBook_Click(object sender, EventArgs e)
        {
            using var scope = _serviceProvider.CreateAsyncScope();
            var form = scope.ServiceProvider.GetRequiredService<FrmBook>();
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