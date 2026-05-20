namespace AllameDehkhoda.Presentation
{
    partial class FrmBorrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBorrow));
            menu = new MenuStrip();
            managementMenu = new ToolStripMenuItem();
            frmBooks = new ToolStripMenuItem();
            frmMembers = new ToolStripMenuItem();
            reportMenu = new ToolStripMenuItem();
            reportBorrows = new ToolStripMenuItem();
            ExitFrm = new ToolStripMenuItem();
            groupBoxSearchBorrow = new GroupBox();
            btnReturnBorrow = new Button();
            btnClear = new Button();
            dtpBorrowDate = new DateTimePicker();
            btnAddBorrow = new Button();
            dtpReturnedDate = new DateTimePicker();
            txtSSNSearch = new TextBox();
            txtISBNSearch = new TextBox();
            lblBookSearchResult = new Label();
            lblMemberSearchResult = new Label();
            lblReturnDate = new Label();
            lblBorrowDate = new Label();
            lblISBNBook = new Label();
            lblSSNMember = new Label();
            chkActivBorrows = new CheckBox();
            dgvBorrows = new DataGridView();
            reportMembers = new ToolStripMenuItem();
            reportBooks = new ToolStripMenuItem();
            menu.SuspendLayout();
            groupBoxSearchBorrow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrows).BeginInit();
            SuspendLayout();
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { managementMenu, reportMenu, ExitFrm });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(7, 2, 0, 2);
            menu.Size = new Size(1212, 28);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // managementMenu
            // 
            managementMenu.DropDownItems.AddRange(new ToolStripItem[] { frmBooks, frmMembers });
            managementMenu.Name = "managementMenu";
            managementMenu.Size = new Size(71, 24);
            managementMenu.Text = "مدیریت";
            // 
            // frmBooks
            // 
            frmBooks.Name = "frmBooks";
            frmBooks.Size = new Size(193, 26);
            frmBooks.Text = "مدیریت کتاب ها";
            frmBooks.Click += frmBooks_Click;
            // 
            // frmMembers
            // 
            frmMembers.Name = "frmMembers";
            frmMembers.Size = new Size(193, 26);
            frmMembers.Text = "مدیریت اعضا";
            frmMembers.Click += frmMembers_Click;
            // 
            // reportMenu
            // 
            reportMenu.DropDownItems.AddRange(new ToolStripItem[] { reportBorrows, reportMembers, reportBooks });
            reportMenu.Name = "reportMenu";
            reportMenu.Size = new Size(76, 24);
            reportMenu.Text = "گزارشات";
            // 
            // reportBorrows
            // 
            reportBorrows.Name = "reportBorrows";
            reportBorrows.Size = new Size(224, 26);
            reportBorrows.Text = "گزارش امانات";
            reportBorrows.Click += reportBorrows_Click;
            // 
            // ExitFrm
            // 
            ExitFrm.Image = (Image)resources.GetObject("ExitFrm.Image");
            ExitFrm.Name = "ExitFrm";
            ExitFrm.Size = new Size(75, 24);
            ExitFrm.Text = "خروج";
            ExitFrm.Click += ExitFrm_Click;
            // 
            // groupBoxSearchBorrow
            // 
            groupBoxSearchBorrow.Controls.Add(btnReturnBorrow);
            groupBoxSearchBorrow.Controls.Add(btnClear);
            groupBoxSearchBorrow.Controls.Add(dtpBorrowDate);
            groupBoxSearchBorrow.Controls.Add(btnAddBorrow);
            groupBoxSearchBorrow.Controls.Add(dtpReturnedDate);
            groupBoxSearchBorrow.Controls.Add(txtSSNSearch);
            groupBoxSearchBorrow.Controls.Add(txtISBNSearch);
            groupBoxSearchBorrow.Controls.Add(lblBookSearchResult);
            groupBoxSearchBorrow.Controls.Add(lblMemberSearchResult);
            groupBoxSearchBorrow.Controls.Add(lblReturnDate);
            groupBoxSearchBorrow.Controls.Add(lblBorrowDate);
            groupBoxSearchBorrow.Controls.Add(lblISBNBook);
            groupBoxSearchBorrow.Controls.Add(lblSSNMember);
            groupBoxSearchBorrow.Location = new Point(12, 31);
            groupBoxSearchBorrow.Name = "groupBoxSearchBorrow";
            groupBoxSearchBorrow.Size = new Size(1182, 278);
            groupBoxSearchBorrow.TabIndex = 1;
            groupBoxSearchBorrow.TabStop = false;
            // 
            // btnReturnBorrow
            // 
            btnReturnBorrow.Image = (Image)resources.GetObject("btnReturnBorrow.Image");
            btnReturnBorrow.Location = new Point(885, 215);
            btnReturnBorrow.Name = "btnReturnBorrow";
            btnReturnBorrow.Size = new Size(130, 42);
            btnReturnBorrow.TabIndex = 15;
            btnReturnBorrow.Text = "ثبت بازگشت";
            btnReturnBorrow.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReturnBorrow.UseVisualStyleBackColor = true;
            btnReturnBorrow.Click += btnReturnBorrow_Click;
            // 
            // btnClear
            // 
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.Location = new Point(48, 215);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 42);
            btnClear.TabIndex = 7;
            btnClear.Text = "پاک کردن فرم";
            btnClear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dtpBorrowDate
            // 
            dtpBorrowDate.Location = new Point(668, 158);
            dtpBorrowDate.Name = "dtpBorrowDate";
            dtpBorrowDate.Size = new Size(281, 27);
            dtpBorrowDate.TabIndex = 4;
            // 
            // btnAddBorrow
            // 
            btnAddBorrow.Image = (Image)resources.GetObject("btnAddBorrow.Image");
            btnAddBorrow.Location = new Point(1046, 215);
            btnAddBorrow.Name = "btnAddBorrow";
            btnAddBorrow.Size = new Size(130, 42);
            btnAddBorrow.TabIndex = 6;
            btnAddBorrow.Text = "ثبت امانت";
            btnAddBorrow.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddBorrow.UseVisualStyleBackColor = true;
            btnAddBorrow.Click += btnAddBorrow_Click;
            // 
            // dtpReturnedDate
            // 
            dtpReturnedDate.Location = new Point(141, 158);
            dtpReturnedDate.Name = "dtpReturnedDate";
            dtpReturnedDate.Size = new Size(281, 27);
            dtpReturnedDate.TabIndex = 5;
            // 
            // txtSSNSearch
            // 
            txtSSNSearch.Location = new Point(668, 26);
            txtSSNSearch.Name = "txtSSNSearch";
            txtSSNSearch.Size = new Size(281, 27);
            txtSSNSearch.TabIndex = 0;
            txtSSNSearch.TextChanged += txtSSNSearch_TextChanged;
            // 
            // txtISBNSearch
            // 
            txtISBNSearch.Location = new Point(141, 16);
            txtISBNSearch.Name = "txtISBNSearch";
            txtISBNSearch.Size = new Size(281, 27);
            txtISBNSearch.TabIndex = 1;
            txtISBNSearch.TextChanged += txtISBNSearch_TextChanged;
            // 
            // lblBookSearchResult
            // 
            lblBookSearchResult.AutoSize = true;
            lblBookSearchResult.Location = new Point(213, 63);
            lblBookSearchResult.Name = "lblBookSearchResult";
            lblBookSearchResult.Size = new Size(50, 20);
            lblBookSearchResult.TabIndex = 5;
            lblBookSearchResult.Text = "label6";
            // 
            // lblMemberSearchResult
            // 
            lblMemberSearchResult.AutoSize = true;
            lblMemberSearchResult.Location = new Point(730, 63);
            lblMemberSearchResult.Name = "lblMemberSearchResult";
            lblMemberSearchResult.Size = new Size(50, 20);
            lblMemberSearchResult.TabIndex = 4;
            lblMemberSearchResult.Text = "label5";
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Location = new Point(428, 163);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(100, 20);
            lblReturnDate.TabIndex = 3;
            lblReturnDate.Text = "تاریخ بازگشت :";
            // 
            // lblBorrowDate
            // 
            lblBorrowDate.AutoSize = true;
            lblBorrowDate.Location = new Point(955, 163);
            lblBorrowDate.Name = "lblBorrowDate";
            lblBorrowDate.Size = new Size(91, 20);
            lblBorrowDate.TabIndex = 2;
            lblBorrowDate.Text = "تاریخ امانت : ";
            // 
            // lblISBNBook
            // 
            lblISBNBook.AutoSize = true;
            lblISBNBook.Location = new Point(428, 23);
            lblISBNBook.Name = "lblISBNBook";
            lblISBNBook.Size = new Size(112, 20);
            lblISBNBook.TabIndex = 1;
            lblISBNBook.Text = "کد شابک کتاب : ";
            // 
            // lblSSNMember
            // 
            lblSSNMember.AutoSize = true;
            lblSSNMember.Location = new Point(955, 23);
            lblSSNMember.Name = "lblSSNMember";
            lblSSNMember.Size = new Size(104, 20);
            lblSSNMember.TabIndex = 0;
            lblSSNMember.Text = "کد ملی عضو : ";
            // 
            // chkActivBorrows
            // 
            chkActivBorrows.AutoSize = true;
            chkActivBorrows.Location = new Point(14, 327);
            chkActivBorrows.Name = "chkActivBorrows";
            chkActivBorrows.Size = new Size(106, 24);
            chkActivBorrows.TabIndex = 6;
            chkActivBorrows.Text = "امانات فعال";
            chkActivBorrows.UseVisualStyleBackColor = true;
            chkActivBorrows.CheckedChanged += chkActivBorrows_CheckedChanged;
            // 
            // dgvBorrows
            // 
            dgvBorrows.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrows.Location = new Point(14, 357);
            dgvBorrows.Name = "dgvBorrows";
            dgvBorrows.RowHeadersWidth = 51;
            dgvBorrows.Size = new Size(1180, 321);
            dgvBorrows.TabIndex = 14;
            // 
            // reportMembers
            // 
            reportMembers.Name = "reportMembers";
            reportMembers.Size = new Size(224, 26);
            reportMembers.Text = "گزارش اعضا";
            reportMembers.Click += reportMembers_Click;
            // 
            // reportBooks
            // 
            reportBooks.Name = "reportBooks";
            reportBooks.Size = new Size(224, 26);
            reportBooks.Text = "گزارش کتاب ها";
            reportBooks.Click += reportBooks_Click;
            // 
            // FrmBorrow
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 690);
            Controls.Add(dgvBorrows);
            Controls.Add(chkActivBorrows);
            Controls.Add(groupBoxSearchBorrow);
            Controls.Add(menu);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menu;
            Name = "FrmBorrow";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmBorrow";
            Load += FrmBorrow_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            groupBoxSearchBorrow.ResumeLayout(false);
            groupBoxSearchBorrow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrows).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem managementMenu;
        private GroupBox groupBoxSearchBorrow;
        private CheckBox chkActivBorrows;
        private Button btnClear;
        private DateTimePicker dtpBorrowDate;
        private DateTimePicker dtpReturnedDate;
        private TextBox txtSSNSearch;
        private TextBox txtISBNSearch;
        private Label lblBookSearchResult;
        private Label lblMemberSearchResult;
        private Label lblReturnDate;
        private Label lblBorrowDate;
        private Label lblISBNBook;
        private Label lblSSNMember;
        private ToolStripMenuItem frmBooks;
        private ToolStripMenuItem frmMembers;
        private ToolStripMenuItem reportMenu;
        private ToolStripMenuItem reportBorrows;
        private ToolStripMenuItem ExitFrm;
        private DataGridView dgvBorrows;
        private Button btnAddBorrow;
        private Button btnReturnBorrow;
        private ToolStripMenuItem reportMembers;
        private ToolStripMenuItem reportBooks;
    }
}