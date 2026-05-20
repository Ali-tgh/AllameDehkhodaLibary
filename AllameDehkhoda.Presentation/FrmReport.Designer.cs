namespace AllameDehkhoda.Presentation
{
    partial class FrmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReport));
            tabReport = new TabControl();
            TrustReportTab = new TabPage();
            dgvBorrowreport = new DataGridView();
            btnBorrowReport = new Button();
            btnSaveBorrowsToExcel = new Button();
            cmbBorrowStatus = new ComboBox();
            dtpFromDate = new DateTimePicker();
            dtpToDate = new DateTimePicker();
            txtSSNSearch = new TextBox();
            txtBookTitleSearch = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            MemberReportTab = new TabPage();
            btnSaveMembersToExcel = new Button();
            btnMemberSearch = new Button();
            dgvmemberReport = new DataGridView();
            label9 = new Label();
            cmbMemberStatus = new ComboBox();
            txtMemberLastName = new TextBox();
            txtMemberFirstName = new TextBox();
            txtMemberSSN = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            BookReportTab = new TabPage();
            btnSaveBooksToExcel = new Button();
            dgvBookReport = new DataGridView();
            btnBookSearch = new Button();
            txtBookISBN = new TextBox();
            txtBookTitle = new TextBox();
            label11 = new Label();
            label10 = new Label();
            tabReport.SuspendLayout();
            TrustReportTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowreport).BeginInit();
            MemberReportTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvmemberReport).BeginInit();
            BookReportTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookReport).BeginInit();
            SuspendLayout();
            // 
            // tabReport
            // 
            tabReport.Controls.Add(TrustReportTab);
            tabReport.Controls.Add(MemberReportTab);
            tabReport.Controls.Add(BookReportTab);
            tabReport.Location = new Point(0, -1);
            tabReport.Margin = new Padding(4, 3, 4, 3);
            tabReport.Name = "tabReport";
            tabReport.RightToLeftLayout = true;
            tabReport.SelectedIndex = 0;
            tabReport.Size = new Size(1019, 809);
            tabReport.TabIndex = 0;
            // 
            // TrustReportTab
            // 
            TrustReportTab.Controls.Add(dgvBorrowreport);
            TrustReportTab.Controls.Add(btnBorrowReport);
            TrustReportTab.Controls.Add(btnSaveBorrowsToExcel);
            TrustReportTab.Controls.Add(cmbBorrowStatus);
            TrustReportTab.Controls.Add(dtpFromDate);
            TrustReportTab.Controls.Add(dtpToDate);
            TrustReportTab.Controls.Add(txtSSNSearch);
            TrustReportTab.Controls.Add(txtBookTitleSearch);
            TrustReportTab.Controls.Add(label5);
            TrustReportTab.Controls.Add(label4);
            TrustReportTab.Controls.Add(label3);
            TrustReportTab.Controls.Add(label2);
            TrustReportTab.Controls.Add(label1);
            TrustReportTab.Location = new Point(4, 32);
            TrustReportTab.Margin = new Padding(4, 3, 4, 3);
            TrustReportTab.Name = "TrustReportTab";
            TrustReportTab.Padding = new Padding(4, 3, 4, 3);
            TrustReportTab.Size = new Size(1011, 773);
            TrustReportTab.TabIndex = 0;
            TrustReportTab.Text = "گزارش امانات";
            TrustReportTab.UseVisualStyleBackColor = true;
            // 
            // dgvBorrowreport
            // 
            dgvBorrowreport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowreport.Location = new Point(8, 334);
            dgvBorrowreport.Margin = new Padding(4, 3, 4, 3);
            dgvBorrowreport.Name = "dgvBorrowreport";
            dgvBorrowreport.RowHeadersWidth = 51;
            dgvBorrowreport.Size = new Size(995, 433);
            dgvBorrowreport.TabIndex = 7;
            // 
            // btnBorrowReport
            // 
            btnBorrowReport.Image = (Image)resources.GetObject("btnBorrowReport.Image");
            btnBorrowReport.Location = new Point(215, 276);
            btnBorrowReport.Margin = new Padding(4, 3, 4, 3);
            btnBorrowReport.Name = "btnBorrowReport";
            btnBorrowReport.Size = new Size(149, 43);
            btnBorrowReport.TabIndex = 6;
            btnBorrowReport.Text = "جست و جو";
            btnBorrowReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrowReport.UseVisualStyleBackColor = true;
            btnBorrowReport.Click += btnBorrowReport_Click;
            // 
            // btnSaveBorrowsToExcel
            // 
            btnSaveBorrowsToExcel.Image = (Image)resources.GetObject("btnSaveBorrowsToExcel.Image");
            btnSaveBorrowsToExcel.Location = new Point(704, 276);
            btnSaveBorrowsToExcel.Margin = new Padding(4, 3, 4, 3);
            btnSaveBorrowsToExcel.Name = "btnSaveBorrowsToExcel";
            btnSaveBorrowsToExcel.Size = new Size(149, 43);
            btnSaveBorrowsToExcel.TabIndex = 5;
            btnSaveBorrowsToExcel.Text = "ذخیره در اکسل";
            btnSaveBorrowsToExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSaveBorrowsToExcel.UseVisualStyleBackColor = true;
            btnSaveBorrowsToExcel.Click += btnSaveBorrowsToExcel_Click_1;
            // 
            // cmbBorrowStatus
            // 
            cmbBorrowStatus.FormattingEnabled = true;
            cmbBorrowStatus.Location = new Point(52, 198);
            cmbBorrowStatus.Margin = new Padding(4, 3, 4, 3);
            cmbBorrowStatus.Name = "cmbBorrowStatus";
            cmbBorrowStatus.Size = new Size(312, 31);
            cmbBorrowStatus.TabIndex = 4;
            // 
            // dtpFromDate
            // 
            dtpFromDate.Location = new Point(52, 23);
            dtpFromDate.Margin = new Padding(4, 3, 4, 3);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(312, 30);
            dtpFromDate.TabIndex = 2;
            // 
            // dtpToDate
            // 
            dtpToDate.Location = new Point(52, 117);
            dtpToDate.Margin = new Padding(4, 3, 4, 3);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(312, 30);
            dtpToDate.TabIndex = 3;
            // 
            // txtSSNSearch
            // 
            txtSSNSearch.Location = new Point(541, 23);
            txtSSNSearch.Margin = new Padding(4, 3, 4, 3);
            txtSSNSearch.Name = "txtSSNSearch";
            txtSSNSearch.Size = new Size(312, 30);
            txtSSNSearch.TabIndex = 0;
            // 
            // txtBookTitleSearch
            // 
            txtBookTitleSearch.Location = new Point(541, 117);
            txtBookTitleSearch.Margin = new Padding(4, 3, 4, 3);
            txtBookTitleSearch.Name = "txtBookTitleSearch";
            txtBookTitleSearch.Size = new Size(312, 30);
            txtBookTitleSearch.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(372, 206);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 4;
            label5.Text = "وضعیت :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(372, 120);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 23);
            label4.TabIndex = 3;
            label4.Text = "تا تاریخ :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(366, 26);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 23);
            label3.TabIndex = 2;
            label3.Text = "از تاریخ : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(867, 119);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 23);
            label2.TabIndex = 1;
            label2.Text = "عنوان کتاب :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(861, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 23);
            label1.TabIndex = 0;
            label1.Text = "کد ملی عضو : ";
            // 
            // MemberReportTab
            // 
            MemberReportTab.Controls.Add(btnSaveMembersToExcel);
            MemberReportTab.Controls.Add(btnMemberSearch);
            MemberReportTab.Controls.Add(dgvmemberReport);
            MemberReportTab.Controls.Add(label9);
            MemberReportTab.Controls.Add(cmbMemberStatus);
            MemberReportTab.Controls.Add(txtMemberLastName);
            MemberReportTab.Controls.Add(txtMemberFirstName);
            MemberReportTab.Controls.Add(txtMemberSSN);
            MemberReportTab.Controls.Add(label8);
            MemberReportTab.Controls.Add(label7);
            MemberReportTab.Controls.Add(label6);
            MemberReportTab.Location = new Point(4, 32);
            MemberReportTab.Margin = new Padding(4, 3, 4, 3);
            MemberReportTab.Name = "MemberReportTab";
            MemberReportTab.Padding = new Padding(4, 3, 4, 3);
            MemberReportTab.Size = new Size(1011, 773);
            MemberReportTab.TabIndex = 1;
            MemberReportTab.Text = "گزارش اعضا";
            MemberReportTab.UseVisualStyleBackColor = true;
            // 
            // btnSaveMembersToExcel
            // 
            btnSaveMembersToExcel.Image = (Image)resources.GetObject("btnSaveMembersToExcel.Image");
            btnSaveMembersToExcel.Location = new Point(639, 203);
            btnSaveMembersToExcel.Margin = new Padding(4, 3, 4, 3);
            btnSaveMembersToExcel.Name = "btnSaveMembersToExcel";
            btnSaveMembersToExcel.Size = new Size(149, 43);
            btnSaveMembersToExcel.TabIndex = 10;
            btnSaveMembersToExcel.Text = "ذخیره در اکسل";
            btnSaveMembersToExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSaveMembersToExcel.UseVisualStyleBackColor = true;
            btnSaveMembersToExcel.Click += btnSaveMembersToExcel_Click;
            // 
            // btnMemberSearch
            // 
            btnMemberSearch.Image = (Image)resources.GetObject("btnMemberSearch.Image");
            btnMemberSearch.Location = new Point(438, 203);
            btnMemberSearch.Name = "btnMemberSearch";
            btnMemberSearch.Size = new Size(149, 43);
            btnMemberSearch.TabIndex = 9;
            btnMemberSearch.Text = "جست و جو";
            btnMemberSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMemberSearch.UseVisualStyleBackColor = true;
            btnMemberSearch.Click += btnMemberSearch_Click;
            // 
            // dgvmemberReport
            // 
            dgvmemberReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvmemberReport.Location = new Point(43, 301);
            dgvmemberReport.Name = "dgvmemberReport";
            dgvmemberReport.RowHeadersWidth = 51;
            dgvmemberReport.Size = new Size(928, 468);
            dgvmemberReport.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(403, 116);
            label9.Name = "label9";
            label9.Size = new Size(77, 23);
            label9.TabIndex = 7;
            label9.Text = "وضعیت :";
            // 
            // cmbMemberStatus
            // 
            cmbMemberStatus.FormattingEnabled = true;
            cmbMemberStatus.Location = new Point(84, 113);
            cmbMemberStatus.Margin = new Padding(4, 3, 4, 3);
            cmbMemberStatus.Name = "cmbMemberStatus";
            cmbMemberStatus.Size = new Size(312, 31);
            cmbMemberStatus.TabIndex = 6;
            // 
            // txtMemberLastName
            // 
            txtMemberLastName.Location = new Point(84, 32);
            txtMemberLastName.Margin = new Padding(4, 3, 4, 3);
            txtMemberLastName.Name = "txtMemberLastName";
            txtMemberLastName.Size = new Size(312, 30);
            txtMemberLastName.TabIndex = 5;
            // 
            // txtMemberFirstName
            // 
            txtMemberFirstName.Location = new Point(555, 39);
            txtMemberFirstName.Margin = new Padding(4, 3, 4, 3);
            txtMemberFirstName.Name = "txtMemberFirstName";
            txtMemberFirstName.Size = new Size(312, 30);
            txtMemberFirstName.TabIndex = 4;
            // 
            // txtMemberSSN
            // 
            txtMemberSSN.Location = new Point(555, 113);
            txtMemberSSN.Margin = new Padding(4, 3, 4, 3);
            txtMemberSSN.Name = "txtMemberSSN";
            txtMemberSSN.Size = new Size(312, 30);
            txtMemberSSN.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(403, 35);
            label8.Name = "label8";
            label8.Size = new Size(114, 23);
            label8.TabIndex = 2;
            label8.Text = "نام خانوادگی : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(874, 42);
            label7.Name = "label7";
            label7.Size = new Size(85, 23);
            label7.TabIndex = 1;
            label7.Text = "نام عضو : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(874, 116);
            label6.Name = "label6";
            label6.Size = new Size(118, 23);
            label6.TabIndex = 0;
            label6.Text = "کد ملی عضو : ";
            // 
            // BookReportTab
            // 
            BookReportTab.Controls.Add(btnSaveBooksToExcel);
            BookReportTab.Controls.Add(dgvBookReport);
            BookReportTab.Controls.Add(btnBookSearch);
            BookReportTab.Controls.Add(txtBookISBN);
            BookReportTab.Controls.Add(txtBookTitle);
            BookReportTab.Controls.Add(label11);
            BookReportTab.Controls.Add(label10);
            BookReportTab.Location = new Point(4, 32);
            BookReportTab.Margin = new Padding(4, 3, 4, 3);
            BookReportTab.Name = "BookReportTab";
            BookReportTab.Padding = new Padding(4, 3, 4, 3);
            BookReportTab.Size = new Size(1011, 773);
            BookReportTab.TabIndex = 2;
            BookReportTab.Text = "گزارش کتاب ها";
            BookReportTab.UseVisualStyleBackColor = true;
            // 
            // btnSaveBooksToExcel
            // 
            btnSaveBooksToExcel.Image = (Image)resources.GetObject("btnSaveBooksToExcel.Image");
            btnSaveBooksToExcel.Location = new Point(114, 103);
            btnSaveBooksToExcel.Margin = new Padding(4, 3, 4, 3);
            btnSaveBooksToExcel.Name = "btnSaveBooksToExcel";
            btnSaveBooksToExcel.Size = new Size(149, 43);
            btnSaveBooksToExcel.TabIndex = 11;
            btnSaveBooksToExcel.Text = "ذخیره در اکسل";
            btnSaveBooksToExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSaveBooksToExcel.UseVisualStyleBackColor = true;
            btnSaveBooksToExcel.Click += btnSaveBooksToExcel_Click;
            // 
            // dgvBookReport
            // 
            dgvBookReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookReport.Location = new Point(114, 235);
            dgvBookReport.Name = "dgvBookReport";
            dgvBookReport.RowHeadersWidth = 51;
            dgvBookReport.Size = new Size(803, 532);
            dgvBookReport.TabIndex = 8;
            // 
            // btnBookSearch
            // 
            btnBookSearch.Image = (Image)resources.GetObject("btnBookSearch.Image");
            btnBookSearch.Location = new Point(114, 21);
            btnBookSearch.Name = "btnBookSearch";
            btnBookSearch.Size = new Size(149, 43);
            btnBookSearch.TabIndex = 6;
            btnBookSearch.Text = "جست و جو";
            btnBookSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBookSearch.UseVisualStyleBackColor = true;
            btnBookSearch.Click += btnBookSearch_Click;
            // 
            // txtBookISBN
            // 
            txtBookISBN.Location = new Point(562, 21);
            txtBookISBN.Margin = new Padding(4, 3, 4, 3);
            txtBookISBN.Name = "txtBookISBN";
            txtBookISBN.Size = new Size(312, 30);
            txtBookISBN.TabIndex = 5;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(562, 116);
            txtBookTitle.Margin = new Padding(4, 3, 4, 3);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(312, 30);
            txtBookTitle.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(881, 21);
            label11.Name = "label11";
            label11.Size = new Size(122, 23);
            label11.TabIndex = 1;
            label11.Text = "کد شابک کتاب :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(896, 119);
            label10.Name = "label10";
            label10.Size = new Size(99, 23);
            label10.TabIndex = 0;
            label10.Text = "عنوان کتاب :";
            // 
            // FrmReport
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 812);
            Controls.Add(tabReport);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmReport";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "گزارشات";
            Load += FrmReport_Load;
            tabReport.ResumeLayout(false);
            TrustReportTab.ResumeLayout(false);
            TrustReportTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowreport).EndInit();
            MemberReportTab.ResumeLayout(false);
            MemberReportTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvmemberReport).EndInit();
            BookReportTab.ResumeLayout(false);
            BookReportTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabReport;
        private TabPage TrustReportTab;
        private TabPage MemberReportTab;
        private DataGridView dgvBorrowreport;
        private Button btnBorrowReport;
        private Button btnSaveBorrowsToExcel;
        private ComboBox cmbBorrowStatus;
        private DateTimePicker dtpFromDate;
        private DateTimePicker dtpToDate;
        private TextBox txtSSNSearch;
        private TextBox txtBookTitleSearch;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage BookReportTab;
        private Button btnMemberSearch;
        private DataGridView dgvmemberReport;
        private Label label9;
        private ComboBox cmbMemberStatus;
        private TextBox txtMemberLastName;
        private TextBox txtMemberFirstName;
        private TextBox txtMemberSSN;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label11;
        private Label label10;
        private Button btnBookSearch;
        private TextBox txtBookISBN;
        private TextBox txtBookTitle;
        private DataGridView dgvBookReport;
        private Button btnSaveMembersToExcel;
        private Button btnSaveBooksToExcel;
    }
}