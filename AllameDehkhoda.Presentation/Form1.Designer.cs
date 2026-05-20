namespace AllameDehkhoda.Presentation
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            مدیریتToolStripMenuItem = new ToolStripMenuItem();
            frmBook = new ToolStripMenuItem();
            frmMember = new ToolStripMenuItem();
            frmBorrow = new ToolStripMenuItem();
            frmReports = new ToolStripMenuItem();
            frmBorrowReport = new ToolStripMenuItem();
            frmBookReport = new ToolStripMenuItem();
            frmMemberReport = new ToolStripMenuItem();
            ExitMenu = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(400, 154);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 215);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 35F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(217, 424);
            label1.Name = "label1";
            label1.Size = new Size(610, 78);
            label1.TabIndex = 1;
            label1.Text = "سیستم مدیریت کتابخانه";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { مدیریتToolStripMenuItem, frmReports, ExitMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1143, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // مدیریتToolStripMenuItem
            // 
            مدیریتToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { frmBook, frmMember, frmBorrow });
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
            // frmMember
            // 
            frmMember.Name = "frmMember";
            frmMember.Size = new Size(193, 26);
            frmMember.Text = "مدیریت اعضا";
            frmMember.Click += frmMember_Click;
            // 
            // frmBorrow
            // 
            frmBorrow.Name = "frmBorrow";
            frmBorrow.Size = new Size(193, 26);
            frmBorrow.Text = "مدیریت امانات";
            frmBorrow.Click += frmBorrow_Click;
            // 
            // frmReports
            // 
            frmReports.DropDownItems.AddRange(new ToolStripItem[] { frmBorrowReport, frmBookReport, frmMemberReport });
            frmReports.Name = "frmReports";
            frmReports.Size = new Size(76, 24);
            frmReports.Text = "گزارشات";
            // 
            // frmBorrowReport
            // 
            frmBorrowReport.Name = "frmBorrowReport";
            frmBorrowReport.Size = new Size(185, 26);
            frmBorrowReport.Text = "گزارش امانات";
            frmBorrowReport.Click += frmBorrowReport_Click;
            // 
            // frmBookReport
            // 
            frmBookReport.Name = "frmBookReport";
            frmBookReport.Size = new Size(185, 26);
            frmBookReport.Text = "گزارش کتاب ها";
            frmBookReport.Click += frmBookReport_Click;
            // 
            // frmMemberReport
            // 
            frmMemberReport.Name = "frmMemberReport";
            frmMemberReport.Size = new Size(185, 26);
            frmMemberReport.Text = "گزارشات اعضا";
            frmMemberReport.Click += frmMemberReport_Click;
            // 
            // ExitMenu
            // 
            ExitMenu.Image = (Image)resources.GetObject("ExitMenu.Image");
            ExitMenu.Name = "ExitMenu";
            ExitMenu.Size = new Size(75, 24);
            ExitMenu.Text = "خروج";
            ExitMenu.Click += ExitMenu_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1143, 591);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "سیستم مدیریت کتابخانه";
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem مدیریتToolStripMenuItem;
        private ToolStripMenuItem frmBook;
        private ToolStripMenuItem frmMember;
        private ToolStripMenuItem frmBorrow;
        private ToolStripMenuItem frmReports;
        private ToolStripMenuItem frmBorrowReport;
        private ToolStripMenuItem frmBookReport;
        private ToolStripMenuItem frmMemberReport;
        private ToolStripMenuItem ExitMenu;
    }
}
