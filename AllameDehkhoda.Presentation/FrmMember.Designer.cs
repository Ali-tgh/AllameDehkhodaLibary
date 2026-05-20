namespace AllameDehkhoda.Presentation
{
    partial class FrmMember
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMember));
            menuStrip1 = new MenuStrip();
            مدیریتToolStripMenuItem = new ToolStripMenuItem();
            frmBook = new ToolStripMenuItem();
            frmBorrow = new ToolStripMenuItem();
            گزارشاتToolStripMenuItem = new ToolStripMenuItem();
            frmBorrowReport = new ToolStripMenuItem();
            frmBookReport = new ToolStripMenuItem();
            frmMemberReport = new ToolStripMenuItem();
            ExitfrmMember = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            chkShowDeletedBook = new CheckBox();
            dtpRegisterTimeMember = new DateTimePicker();
            btnDeleteBook = new Button();
            txtAddressMember = new TextBox();
            btnRestoreBook = new Button();
            txtPhoneNumberMember = new TextBox();
            btnUpdateBook = new Button();
            txtSSNCodeMember = new TextBox();
            btnAddBook = new Button();
            txtLastNameMember = new TextBox();
            txtFirstNameMember = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            chkDeletedMembers = new CheckBox();
            dgvMembers = new DataGridView();
            btnClear = new Button();
            btnDeleteMember = new Button();
            btnRestorMember = new Button();
            btnEditMember = new Button();
            btnAddMember = new Button();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { مدیریتToolStripMenuItem, گزارشاتToolStripMenuItem, ExitfrmMember });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 2, 0, 2);
            menuStrip1.Size = new Size(953, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // مدیریتToolStripMenuItem
            // 
            مدیریتToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { frmBook, frmBorrow });
            مدیریتToolStripMenuItem.Name = "مدیریتToolStripMenuItem";
            مدیریتToolStripMenuItem.Size = new Size(71, 24);
            مدیریتToolStripMenuItem.Text = "مدیریت";
            // 
            // frmBook
            // 
            frmBook.Name = "frmBook";
            frmBook.Size = new Size(193, 26);
            frmBook.Text = "مدیریت کتاب ها";
            frmBook.Click += frmBook_Click;
            // 
            // frmBorrow
            // 
            frmBorrow.Name = "frmBorrow";
            frmBorrow.Size = new Size(193, 26);
            frmBorrow.Text = "مدیریت امانات";
            frmBorrow.Click += frmBorrow_Click;
            // 
            // گزارشاتToolStripMenuItem
            // 
            گزارشاتToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { frmBorrowReport, frmBookReport, frmMemberReport });
            گزارشاتToolStripMenuItem.Name = "گزارشاتToolStripMenuItem";
            گزارشاتToolStripMenuItem.Size = new Size(76, 24);
            گزارشاتToolStripMenuItem.Text = "گزارشات";
            // 
            // frmBorrowReport
            // 
            frmBorrowReport.Name = "frmBorrowReport";
            frmBorrowReport.Size = new Size(224, 26);
            frmBorrowReport.Text = "گزارش امانات";
            frmBorrowReport.Click += frmBorrowReport_Click_1;
            // 
            // frmBookReport
            // 
            frmBookReport.Name = "frmBookReport";
            frmBookReport.Size = new Size(224, 26);
            frmBookReport.Text = "گزارش کتاب ها";
            frmBookReport.Click += frmBookReport_Click_1;
            // 
            // frmMemberReport
            // 
            frmMemberReport.Name = "frmMemberReport";
            frmMemberReport.Size = new Size(224, 26);
            frmMemberReport.Text = "گزارش اعضا";
            frmMemberReport.Click += frmMemberReport_Click_1;
            // 
            // ExitfrmMember
            // 
            ExitfrmMember.Image = (Image)resources.GetObject("ExitfrmMember.Image");
            ExitfrmMember.Name = "ExitfrmMember";
            ExitfrmMember.Size = new Size(75, 24);
            ExitfrmMember.Text = "خروج";
            ExitfrmMember.Click += ExitfrmMember_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(chkShowDeletedBook);
            groupBox1.Controls.Add(dtpRegisterTimeMember);
            groupBox1.Controls.Add(btnDeleteBook);
            groupBox1.Controls.Add(txtAddressMember);
            groupBox1.Controls.Add(btnRestoreBook);
            groupBox1.Controls.Add(txtPhoneNumberMember);
            groupBox1.Controls.Add(btnUpdateBook);
            groupBox1.Controls.Add(txtSSNCodeMember);
            groupBox1.Controls.Add(btnAddBook);
            groupBox1.Controls.Add(txtLastNameMember);
            groupBox1.Controls.Add(txtFirstNameMember);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 30);
            groupBox1.Margin = new Padding(1, 2, 1, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(1, 2, 1, 2);
            groupBox1.Size = new Size(941, 295);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // chkShowDeletedBook
            // 
            chkShowDeletedBook.AutoSize = true;
            chkShowDeletedBook.ForeColor = Color.Red;
            chkShowDeletedBook.Location = new Point(-702, 213);
            chkShowDeletedBook.Name = "chkShowDeletedBook";
            chkShowDeletedBook.Size = new Size(218, 28);
            chkShowDeletedBook.TabIndex = 23;
            chkShowDeletedBook.Text = " نمایش کتاب های حذف شده";
            chkShowDeletedBook.UseVisualStyleBackColor = true;
            // 
            // dtpRegisterTimeMember
            // 
            dtpRegisterTimeMember.Font = new Font("Arial", 9F, FontStyle.Bold);
            dtpRegisterTimeMember.Location = new Point(54, 219);
            dtpRegisterTimeMember.Name = "dtpRegisterTimeMember";
            dtpRegisterTimeMember.Size = new Size(272, 25);
            dtpRegisterTimeMember.TabIndex = 8;
            dtpRegisterTimeMember.TabStop = false;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnDeleteBook.Image = (Image)resources.GetObject("btnDeleteBook.Image");
            btnDeleteBook.Location = new Point(-312, 153);
            btnDeleteBook.Margin = new Padding(2);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(103, 44);
            btnDeleteBook.TabIndex = 22;
            btnDeleteBook.Text = "حذف";
            btnDeleteBook.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDeleteBook.UseVisualStyleBackColor = true;
            // 
            // txtAddressMember
            // 
            txtAddressMember.Location = new Point(54, 121);
            txtAddressMember.Margin = new Padding(2);
            txtAddressMember.Name = "txtAddressMember";
            txtAddressMember.Size = new Size(272, 30);
            txtAddressMember.TabIndex = 7;
            // 
            // btnRestoreBook
            // 
            btnRestoreBook.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnRestoreBook.Image = (Image)resources.GetObject("btnRestoreBook.Image");
            btnRestoreBook.Location = new Point(-439, 153);
            btnRestoreBook.Margin = new Padding(2);
            btnRestoreBook.Name = "btnRestoreBook";
            btnRestoreBook.Size = new Size(103, 44);
            btnRestoreBook.TabIndex = 21;
            btnRestoreBook.Text = "بازیابی";
            btnRestoreBook.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnRestoreBook.UseVisualStyleBackColor = true;
            // 
            // txtPhoneNumberMember
            // 
            txtPhoneNumberMember.Location = new Point(54, 31);
            txtPhoneNumberMember.Margin = new Padding(2);
            txtPhoneNumberMember.Name = "txtPhoneNumberMember";
            txtPhoneNumberMember.Size = new Size(272, 30);
            txtPhoneNumberMember.TabIndex = 6;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnUpdateBook.Image = (Image)resources.GetObject("btnUpdateBook.Image");
            btnUpdateBook.Location = new Point(-568, 153);
            btnUpdateBook.Margin = new Padding(2);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(103, 44);
            btnUpdateBook.TabIndex = 20;
            btnUpdateBook.Text = "ویرایش";
            btnUpdateBook.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnUpdateBook.UseVisualStyleBackColor = true;
            // 
            // txtSSNCodeMember
            // 
            txtSSNCodeMember.Location = new Point(548, 218);
            txtSSNCodeMember.Margin = new Padding(2);
            txtSSNCodeMember.Name = "txtSSNCodeMember";
            txtSSNCodeMember.Size = new Size(272, 30);
            txtSSNCodeMember.TabIndex = 2;
            // 
            // btnAddBook
            // 
            btnAddBook.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnAddBook.Image = (Image)resources.GetObject("btnAddBook.Image");
            btnAddBook.Location = new Point(-697, 311);
            btnAddBook.Margin = new Padding(2);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(103, 44);
            btnAddBook.TabIndex = 19;
            btnAddBook.Text = "افزودن";
            btnAddBook.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAddBook.UseVisualStyleBackColor = true;
            // 
            // txtLastNameMember
            // 
            txtLastNameMember.Location = new Point(548, 117);
            txtLastNameMember.Margin = new Padding(2);
            txtLastNameMember.Name = "txtLastNameMember";
            txtLastNameMember.Size = new Size(272, 30);
            txtLastNameMember.TabIndex = 1;
            // 
            // txtFirstNameMember
            // 
            txtFirstNameMember.Location = new Point(560, 30);
            txtFirstNameMember.Margin = new Padding(2);
            txtFirstNameMember.Name = "txtFirstNameMember";
            txtFirstNameMember.Size = new Size(272, 30);
            txtFirstNameMember.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11F, FontStyle.Bold);
            label6.Location = new Point(330, 219);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(98, 22);
            label6.TabIndex = 5;
            label6.Text = "تاریخ ورود : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11F, FontStyle.Bold);
            label5.Location = new Point(330, 126);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 22);
            label5.TabIndex = 4;
            label5.Text = "آدرس :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11F, FontStyle.Bold);
            label4.Location = new Point(330, 35);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 22);
            label4.TabIndex = 3;
            label4.Text = "شماره تماس : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11F, FontStyle.Bold);
            label3.Location = new Point(823, 220);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 22);
            label3.TabIndex = 2;
            label3.Text = " کد ملی : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11F, FontStyle.Bold);
            label2.Location = new Point(823, 120);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 22);
            label2.TabIndex = 1;
            label2.Text = "نام خانوادگی  :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11F, FontStyle.Bold);
            label1.Location = new Point(823, 35);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(43, 22);
            label1.TabIndex = 0;
            label1.Text = "نام  :";
            // 
            // chkDeletedMembers
            // 
            chkDeletedMembers.AutoSize = true;
            chkDeletedMembers.ForeColor = Color.Red;
            chkDeletedMembers.Location = new Point(13, 389);
            chkDeletedMembers.Name = "chkDeletedMembers";
            chkDeletedMembers.Size = new Size(223, 28);
            chkDeletedMembers.TabIndex = 22;
            chkDeletedMembers.Text = " نمایش عضو های حذف شده";
            chkDeletedMembers.UseVisualStyleBackColor = true;
            chkDeletedMembers.CheckedChanged += chkDeletedMembers_CheckedChanged;
            // 
            // dgvMembers
            // 
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Location = new Point(13, 423);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.Size = new Size(928, 335);
            dgvMembers.TabIndex = 24;
            dgvMembers.CellClick += dgvMembers_CellClick;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnClear.Location = new Point(838, 331);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(103, 43);
            btnClear.TabIndex = 23;
            btnClear.Text = "پاک کردن";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDeleteMember
            // 
            btnDeleteMember.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnDeleteMember.Image = (Image)resources.GetObject("btnDeleteMember.Image");
            btnDeleteMember.Location = new Point(506, 331);
            btnDeleteMember.Margin = new Padding(2);
            btnDeleteMember.Name = "btnDeleteMember";
            btnDeleteMember.Size = new Size(142, 44);
            btnDeleteMember.TabIndex = 21;
            btnDeleteMember.Text = "حذف عضو";
            btnDeleteMember.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDeleteMember.UseVisualStyleBackColor = true;
            btnDeleteMember.Click += btnDeleteMember_Click;
            // 
            // btnRestorMember
            // 
            btnRestorMember.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnRestorMember.Image = (Image)resources.GetObject("btnRestorMember.Image");
            btnRestorMember.Location = new Point(341, 330);
            btnRestorMember.Margin = new Padding(2);
            btnRestorMember.Name = "btnRestorMember";
            btnRestorMember.Size = new Size(142, 44);
            btnRestorMember.TabIndex = 20;
            btnRestorMember.Text = "بازیابی عضو";
            btnRestorMember.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnRestorMember.UseVisualStyleBackColor = true;
            btnRestorMember.Click += btnRestorMember_Click;
            // 
            // btnEditMember
            // 
            btnEditMember.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnEditMember.Image = (Image)resources.GetObject("btnEditMember.Image");
            btnEditMember.Location = new Point(177, 331);
            btnEditMember.Margin = new Padding(2);
            btnEditMember.Name = "btnEditMember";
            btnEditMember.Size = new Size(142, 44);
            btnEditMember.TabIndex = 19;
            btnEditMember.Text = "ویرایش عضو";
            btnEditMember.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnEditMember.UseVisualStyleBackColor = true;
            btnEditMember.Click += btnEditMember_Click;
            // 
            // btnAddMember
            // 
            btnAddMember.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnAddMember.Image = (Image)resources.GetObject("btnAddMember.Image");
            btnAddMember.Location = new Point(13, 331);
            btnAddMember.Margin = new Padding(2);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(142, 44);
            btnAddMember.TabIndex = 18;
            btnAddMember.Text = "ثبت عضو";
            btnAddMember.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAddMember.UseVisualStyleBackColor = true;
            btnAddMember.Click += btnAddMember_Click;
            // 
            // FrmMember
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 770);
            Controls.Add(chkDeletedMembers);
            Controls.Add(dgvMembers);
            Controls.Add(btnClear);
            Controls.Add(btnDeleteMember);
            Controls.Add(btnRestorMember);
            Controls.Add(btnEditMember);
            Controls.Add(btnAddMember);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Font = new Font("Arial", 12F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "FrmMember";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "FrmMember";
            Load += FrmMember_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem مدیریتToolStripMenuItem;
        private ToolStripMenuItem گزارشاتToolStripMenuItem;
        private ToolStripMenuItem ExitfrmMember;
        private ToolStripMenuItem frmBook;
        private ToolStripMenuItem frmBorrow;
        private ToolStripMenuItem frmBorrowReport;
        private ToolStripMenuItem frmBookReport;
        private ToolStripMenuItem frmMemberReport;
        private GroupBox groupBox1;
        private TextBox txtSSNCodeMember;
        private TextBox txtLastNameMember;
        private TextBox txtFirstNameMember;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPhoneNumberMember;
        private TextBox txtAddressMember;
        private DateTimePicker dtpRegisterTimeMember;
        private CheckBox chkShowDeletedBook;
        private Button btnDeleteBook;
        private Button btnRestoreBook;
        private Button btnUpdateBook;
        private Button btnAddBook;
        private CheckBox chkDeletedMembers;
        private DataGridView dgvMembers;
        private Button btnClear;
        private Button btnDeleteMember;
        private Button btnRestorMember;
        private Button btnEditMember;
        private Button btnAddMember;
    }
}