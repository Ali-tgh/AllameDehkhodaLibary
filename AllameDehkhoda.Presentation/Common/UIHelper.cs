using DocumentFormat.OpenXml.Office2010.CustomUI;
using System.Runtime.Intrinsics.X86;

namespace AllameDehkhoda.Presentation.Common
{
    public static class UIHelper
    {
        public static bool HasSelectedRow(DataGridView dgv, string itemName = "آیتم")
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show($"لطفا یک {itemName} را انتخاب کنید", "خطا",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public static bool ConfirmAction(string actionName, string itemName = "آیتم")
        {
            var result = MessageBox.Show($"آیا این {itemName} {actionName} شود؟",
                "تایید",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }
        public static void ShowResult(bool isSuccess, string Message)
        {
            if (isSuccess)
            {
                MessageBox.Show(Message, "موفق",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Message ?? "عملیات با خطا مواجه شد", "خطا",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static int GetSelectedCellValu(DataGridView dgv, string columnName)
        {
            if (dgv.SelectedRows.Count == 0)
                return 0;

            var value = dgv.SelectedRows[0].Cells[columnName].Value;


            if (value == null || value == DBNull.Value)
                return 0;

            return Convert.ToInt32(value);
        }
        public static bool MustBeNumber(TextBox textBox , string item)
        {
            if (!textBox.Text.Trim().All(char.IsDigit))
            {
                MessageBox.Show($"{item} باید فقط شامل عدد باشد", "خطا",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public static bool MaxLength(TextBox textBox, string item, int Length)
        {
            if (textBox.Text.Trim().Length != Length)
            {
                MessageBox.Show($"{item} باید {Length} رقم باشد", "خطا",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
