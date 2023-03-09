using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace extrusion_item_packed_report
{
    public class ToolSupport
    {
        private void reOject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Export to excel fail: " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                GC.Collect();
            }
        }
        public void ExportData(List<DetailInformation> details, string pathSave, string pathForm)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            xlApp = new Excel.Application();
            object misValue = System.Reflection.Missing.Value;
            xlWorkBook = xlApp.Workbooks.Open(pathForm, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            try
            {
                details = details.OrderByDescending(x => x.Date).ToList();
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                xlWorkSheet.Name = "MainReport";
                DateTime date = DateTime.Now;
                xlWorkSheet.Cells[1, "A"] = "挤出部包装面积报告" + Environment.NewLine + "Báo biểu khu vực đóng gói bộ phận Đùn" ; // Thêm ngày vào title
                for (int i = 0; i < details.Count; i++)
                {
                    xlWorkSheet.Cells[4 + i, "A"] = details[i].Date;
                    xlWorkSheet.Cells[4 + i, "B"] = details[i].MainCode;
                    xlWorkSheet.Cells[4 + i, "C"] = details[i].Length;
                    xlWorkSheet.Cells[4 + i, "D"] = details[i].Weight;
                    xlWorkSheet.Cells[4 + i, "E"] = details[i].Sender;
                    xlWorkSheet.Cells[4 + i, "F"] = details[i].Receiver;
                }

                xlWorkBook.SaveAs(pathSave, Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, misValue,
                    misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(0);

                xlApp.Quit();
                reOject(xlWorkSheet);
                reOject(xlWorkBook);
                reOject(xlApp);
            }
            catch (Exception)
            {
                xlWorkBook.Close(0);
                xlApp.Quit();        
                throw;
            }
        }
    }
}
