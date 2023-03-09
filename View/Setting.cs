using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace extrusion_item_packed_report
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            btnSave.ButtonText = "LƯU CÀI ĐẶT" + Environment.NewLine + "保存设置";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CheckEmp();
        }
        private void CheckEmp()
        {
            SqlHR sqlHR = new SqlHR();

            string EmpCode = sqlHR.sqlExecuteScalarString("select distinct Code from ZlEmployee where Code like '%-%' and CAST(SUBSTRING(Code, CHARINDEX('-', Code) + 1, LEN(Code)) AS int) = '" + txbEmpCode.Text.Trim() + "'");
            string EmpName = sqlHR.sqlExecuteScalarString("select distinct Name from ZlEmployee where Code = '" + EmpCode + "'");
            if (!String.IsNullOrEmpty(EmpCode) && !String.IsNullOrEmpty(EmpName))
            {
                Properties.Settings.Default.empCode = txbEmpCode.Text.Trim();
                Properties.Settings.Default.Save();
                this.Close();
            }
            else
            {
                MessageBox.Show("Mã nhân viên sai hoặc không còn trong hệ thống công ty!" + Environment.NewLine + "员工代码错误或已不在公司系统中！", "Cảnh báo / 警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbEmpCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default.empCode))
            {
                MessageBox.Show("Mã nhân viên không được để trống!" + Environment.NewLine + "工号不能为空！", "Cảnh báo / 警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void txbEmpCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckEmp();
            }
        }
    }
}
