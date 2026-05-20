
namespace AllameDehkhoda.Presentation.Common
{
    public static class SaveAsXML
    {
        public static void SaveToExcel(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("رکوردی برای ذخیره در اکسل وجود ندارد.");
                return;
            }
            using (SaveFileDialog sdf = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sdf.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new ClosedXML.Excel.XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("گزارش امانات");
                        for (int i = 0; i < dgv.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dgv.Columns[i].HeaderText;
                        }
                        for (int i = 0; i < dgv.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgv.Columns.Count; j++)
                            {
                                worksheet.Cell(i + 2, j + 1).Value = dgv.Rows[i].Cells[j].Value?.ToString();
                            }
                        }
                        workbook.SaveAs(sdf.FileName);
                        MessageBox.Show("فایل با موفقیت ذخیره شد.");
                    }
                }
            }
        }
    }
}
