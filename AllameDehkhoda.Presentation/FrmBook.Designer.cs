namespace AllameDehkhoda.Presentation
{
    partial class FrmBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBook));
            menuStrip1 = new MenuStrip();
            مدیریتToolStripMenuItem = new ToolStripMenuItem();
            frmMember = new ToolStripMenuItem();
            frmBorrow = new ToolStripMenuItem();
            گزارشاتToolStripMenuItem = new ToolStripMenuItem();
            frmBorrowReport = new ToolStripMenuItem();
            frmBookReport = new ToolStripMenuItem();
            frmMemberReport = new ToolStripMenuItem();
            btnExitfrmBook = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            cmbCategory = new ComboBox();
            numTotalCount = new NumericUpDown();
            numPublishYear = new NumericUpDown();
            txtISBN = new TextBox();
            txtAutherName = new TextBox();
            txtBookTitle = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAddBook = new Button();
            btnUpdateBook = new Button();
            btnRestoreBook = new Button();
            btnDeleteBook = new Button();
            btnClear = new Button();
            dgvBooks = new DataGridView();
            chkShowDeletedBook = new CheckBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTotalCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPublishYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { مدیریتToolStripMenuItem, گزارشاتToolStripMenuItem, btnExitfrmBook });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(3, 1, 0, 1);
            menuStrip1.Size = new Size(829, 26);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // مدیریتToolStripMenuItem
            // 
            مدیریتToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { frmMember, frmBorrow });
            مدیریتToolStripMenuItem.Name = "مدیریتToolStripMenuItem";
            مدیریتToolStripMenuItem.Size = new Size(71, 24);
            مدیریتToolStripMenuItem.Text = "مدیریت";
            // 
            // frmMember
            // 
            frmMember.Name = "frmMember";
            frmMember.Size = new Size(184, 26);
            frmMember.Text = "مدیریت اعضا";
            frmMember.Click += frmMember_Click;
            // 
            // frmBorrow
            // 
            frmBorrow.Name = "frmBorrow";
            frmBorrow.Size = new Size(184, 26);
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
            // btnExitfrmBook
            // 
            btnExitfrmBook.Image = (Image)resources.GetObject("btnExitfrmBook.Image");
            btnExitfrmBook.Name = "btnExitfrmBook";
            btnExitfrmBook.Size = new Size(75, 24);
            btnExitfrmBook.Text = "خروج";
            btnExitfrmBook.Click += btnExitfrmBook_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(cmbCategory);
            groupBox1.Controls.Add(numTotalCount);
            groupBox1.Controls.Add(numPublishYear);
            groupBox1.Controls.Add(txtISBN);
            groupBox1.Controls.Add(txtAutherName);
            groupBox1.Controls.Add(txtBookTitle);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 55);
            groupBox1.Margin = new Padding(1, 2, 1, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(1, 2, 1, 2);
            groupBox1.Size = new Size(810, 295);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(22, 212);
            cmbCategory.Margin = new Padding(2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(161, 32);
            cmbCategory.TabIndex = 5;
            // 
            // numTotalCount
            // 
            numTotalCount.Location = new Point(22, 121);
            numTotalCount.Margin = new Padding(2);
            numTotalCount.Name = "numTotalCount";
            numTotalCount.Size = new Size(161, 30);
            numTotalCount.TabIndex = 4;
            // 
            // numPublishYear
            // 
            numPublishYear.Location = new Point(22, 30);
            numPublishYear.Margin = new Padding(2);
            numPublishYear.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            numPublishYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numPublishYear.Name = "numPublishYear";
            numPublishYear.Size = new Size(161, 30);
            numPublishYear.TabIndex = 3;
            numPublishYear.Value = new decimal(new int[] { 1900, 0, 0, 0 });
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(515, 214);
            txtISBN.Margin = new Padding(2);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(161, 30);
            txtISBN.TabIndex = 2;
            // 
            // txtAutherName
            // 
            txtAutherName.Location = new Point(515, 121);
            txtAutherName.Margin = new Padding(2);
            txtAutherName.Name = "txtAutherName";
            txtAutherName.Size = new Size(161, 30);
            txtAutherName.TabIndex = 1;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(515, 30);
            txtBookTitle.Margin = new Padding(2);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(161, 30);
            txtBookTitle.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            label6.Location = new Point(186, 217);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(110, 27);
            label6.TabIndex = 5;
            label6.Text = "دسته بندی : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            label5.Location = new Point(186, 124);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(130, 27);
            label5.TabIndex = 4;
            label5.Text = "نعداد نسخه ها :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            label4.Location = new Point(186, 33);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(106, 27);
            label4.TabIndex = 3;
            label4.Text = "سال انتشار :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            label3.Location = new Point(688, 217);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 27);
            label3.TabIndex = 2;
            label3.Text = "کد ISBN :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            label2.Location = new Point(688, 124);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 27);
            label2.TabIndex = 1;
            label2.Text = "نام نویسنده :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            label1.Location = new Point(688, 33);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 27);
            label1.TabIndex = 0;
            label1.Text = "عنوان کتاب :";
            // 
            // btnAddBook
            // 
            btnAddBook.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnAddBook.Image = (Image)resources.GetObject("btnAddBook.Image");
            btnAddBook.Location = new Point(10, 354);
            btnAddBook.Margin = new Padding(2);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(103, 44);
            btnAddBook.TabIndex = 6;
            btnAddBook.Text = "افزودن";
            btnAddBook.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnUpdateBook.Image = (Image)resources.GetObject("btnUpdateBook.Image");
            btnUpdateBook.Location = new Point(144, 354);
            btnUpdateBook.Margin = new Padding(2);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(103, 44);
            btnUpdateBook.TabIndex = 7;
            btnUpdateBook.Text = "ویرایش";
            btnUpdateBook.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnRestoreBook
            // 
            btnRestoreBook.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnRestoreBook.Image = (Image)resources.GetObject("btnRestoreBook.Image");
            btnRestoreBook.Location = new Point(273, 354);
            btnRestoreBook.Margin = new Padding(2);
            btnRestoreBook.Name = "btnRestoreBook";
            btnRestoreBook.Size = new Size(103, 44);
            btnRestoreBook.TabIndex = 8;
            btnRestoreBook.Text = "بازیابی";
            btnRestoreBook.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnRestoreBook.UseVisualStyleBackColor = true;
            btnRestoreBook.Click += btnRestoreBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnDeleteBook.Image = (Image)resources.GetObject("btnDeleteBook.Image");
            btnDeleteBook.Location = new Point(400, 354);
            btnDeleteBook.Margin = new Padding(2);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(103, 44);
            btnDeleteBook.TabIndex = 9;
            btnDeleteBook.Text = "حذف";
            btnDeleteBook.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnClear.Location = new Point(717, 355);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(103, 43);
            btnClear.TabIndex = 11;
            btnClear.Text = "پاک کردن";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(10, 448);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(807, 272);
            dgvBooks.TabIndex = 17;
            dgvBooks.CellClick += dgvBooks_CellClick;
            // 
            // chkShowDeletedBook
            // 
            chkShowDeletedBook.AutoSize = true;
            chkShowDeletedBook.ForeColor = Color.Red;
            chkShowDeletedBook.Location = new Point(10, 414);
            chkShowDeletedBook.Name = "chkShowDeletedBook";
            chkShowDeletedBook.Size = new Size(218, 28);
            chkShowDeletedBook.TabIndex = 10;
            chkShowDeletedBook.Text = " نمایش کتاب های حذف شده";
            chkShowDeletedBook.UseVisualStyleBackColor = true;
            chkShowDeletedBook.CheckedChanged += chkShowDeletedBook_CheckedChanged;
            // 
            // FrmBook
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 738);
            Controls.Add(chkShowDeletedBook);
            Controls.Add(dgvBooks);
            Controls.Add(btnClear);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnRestoreBook);
            Controls.Add(btnUpdateBook);
            Controls.Add(btnAddBook);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmBook";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "مدیریت کتاب ها";
            Load += FrmBook_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTotalCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPublishYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem مدیریتToolStripMenuItem;
        private ToolStripMenuItem گزارشاتToolStripMenuItem;
        private ToolStripMenuItem btnExitfrmBook;
        private ToolStripMenuItem frmMember;
        private ToolStripMenuItem frmBorrow;
        private ToolStripMenuItem frmBorrowReport;
        private ToolStripMenuItem frmBookReport;
        private ToolStripMenuItem frmMemberReport;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numPublishYear;
        private TextBox txtISBN;
        private TextBox txtAutherName;
        private TextBox txtBookTitle;
        private ComboBox cmbCategory;
        private NumericUpDown numTotalCount;
        private Button btnAddBook;
        private Button btnUpdateBook;
        private Button btnRestoreBook;
        private Button btnDeleteBook;
        private Button btnClear;
        private DataGridView dgvBooks;
        private CheckBox chkShowDeletedBook;
    }
}