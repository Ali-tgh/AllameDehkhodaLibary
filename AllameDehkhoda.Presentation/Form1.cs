using Microsoft.Extensions.DependencyInjection;

namespace AllameDehkhoda.Presentation
{
    public partial class FrmMain : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public FrmMain(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmBook_Click(object sender, EventArgs e)
        {
            using var scope = _serviceProvider.CreateScope();
            var form = scope.ServiceProvider.GetRequiredService<FrmBook>();
            form.ShowDialog();
        }

        private async void frmMember_Click(object sender, EventArgs e)
        {
            using var scope = _serviceProvider.CreateScope();
            var form = scope.ServiceProvider.GetRequiredService<FrmMember>();
            form.ShowDialog();

        }

        private void frmBorrow_Click(object sender, EventArgs e)
        {
            using var scope = _serviceProvider.CreateScope();
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
    }
}
