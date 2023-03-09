using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace extrusion_item_packed_report
{
    public class ExportReport
    {
        public string PathPackedExtrusionReport = Environment.CurrentDirectory + @"\Resources\ExportPackedExtrusionForm.xlsx";

        public void ExportExcelExtrusionPackedReport(string PathSave, List<DetailInformation> details)
        {
            ToolSupport toolSupport = new ToolSupport();
            toolSupport.ExportData(details, PathSave, PathPackedExtrusionReport);
        }
    }
}
