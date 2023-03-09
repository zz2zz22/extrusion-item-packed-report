using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace extrusion_item_packed_report
{
    public partial class MainWindow : Form
    {
        string dataIn;
        double weightRT;
        string dateStart = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ReloadComPort()
        {
            cbxComport.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            cbxComport.Items.AddRange(ports);
        }
        private void ConnectScale()
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                btnConnectScale.ButtonText = "KẾT NỐI CÂN" + Environment.NewLine + "连接电子秤";
            }
            else
            {
                try
                {
                    serialPort1.PortName = cbxComport.Text;
                    serialPort1.BaudRate = Convert.ToInt32("9600");
                    serialPort1.DataBits = Convert.ToInt32("8");
                    serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One");
                    serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
                    serialPort1.Open();
                    btnConnectScale.ButtonText = "NGẮT KẾT NỐI" + Environment.NewLine + "断开";
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            btnSetting.ButtonText = "CÀI ĐẶT" + Environment.NewLine + "环境";
            btnSave.ButtonText = "LƯU THÔNG TIN" + Environment.NewLine + "保存信息";
            btnSaveExcel.ButtonText = "XUẤT BÁO BIỂU EXCEL" + Environment.NewLine + "导出 EXCEL 报告";
            btnConnectScale.ButtonText = "KẾT NỐI CÂN" + Environment.NewLine + "连接电子秤";

            dateStart = DateTime.Now.ToString("yyyy-MMM-dd HH:mm:ss");

            ReloadComPort();
            if (!serialPort1.IsOpen)
            {
                btnConnectScale.ButtonText = "KẾT NỐI CÂN" + Environment.NewLine + "连接电子秤";
            }
            else
            {
                btnConnectScale.ButtonText = "NGẮT KẾT NỐI" + Environment.NewLine + "断开";
            }
            if (String.IsNullOrEmpty(Properties.Settings.Default.empCode))
            {
                Setting set = new Setting();
                set.ShowDialog();
            }
        }

        private void txbLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txbEmpCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void LoadCodeList2ComboBox(string keyWord)
        {
            if (String.IsNullOrEmpty(keyWord))
            {
                cbxCodeList.Items.Clear();
            }
            else
            {
                cbxCodeList.Items.Clear();
                sqlMESBaseDataCon sqlMES = new sqlMESBaseDataCon();
                StringBuilder sql = new StringBuilder();
                sql.Append("select distinct product_no from bom_info where product_no like '%" + keyWord.ToUpper() + "%' order by create_date desc");
                sqlMES.getComboBoxData(sql.ToString(), ref cbxCodeList);
                if (cbxCodeList.Items.Count <= 0)
                {
                    MessageBox.Show("Không tìm thấy mã hàng nào!" + Environment.NewLine + "未找到商品代码！", "Cảnh báo / 警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {
                    MessageBox.Show("Đã tìm thấy " + cbxCodeList.Items.Count + " mã hàng!" + Environment.NewLine + "找到 " + cbxCodeList.Items.Count + " 个项目代码！", "Cảnh báo / 警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbxCodeList.SelectedIndex = 0;
                }
            }
        }

        private void txbSearchCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadCodeList2ComboBox(txbSearchCode.Text.Trim());
            }
        }

        private void txbSearchCode_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbSearchCode.Text.Trim()))
            {
                LoadCodeList2ComboBox(txbSearchCode.Text.Trim());
                txbLength.Text = String.Empty;
                txbEmpCode.Text = String.Empty;
            }
        }

        private bool checkNull()
        {
            if (String.IsNullOrEmpty(cbxCodeList.Text.Trim()))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txbLength_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbLength.Text))
            {
                e.Cancel = true;
                txbLength.Focus();
                errorProvider.SetError(txbLength, "Chiều dài không được để trống!" + Environment.NewLine + "长度不能为空！");
            }
            else
            {

                e.Cancel = false;
                errorProvider.SetError(txbLength, null);
            }
        }

        private void txbEmpCode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbEmpCode.Text))
            {
                e.Cancel = true;
                txbEmpCode.Focus();
                errorProvider.SetError(txbEmpCode, "Mã số nhân viên đóng gói không được để trống!" + Environment.NewLine + "加壳号不能留空！");
            }
            else
            {

                e.Cancel = false;
                errorProvider.SetError(txbEmpCode, null);
            }
        }

        private void txbSearchCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Đăng xuất và thoát chương trình?" + Environment.NewLine + "注销并退出程序？", "Cảnh báo / 警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
                Properties.Settings.Default.empCode = String.Empty;
                Properties.Settings.Default.Save();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnConnectScale_Click(object sender, EventArgs e)
        {
            ConnectScale();
        }

        private void btnReloadPort_Click(object sender, EventArgs e)
        {
            ReloadComPort();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIn = serialPort1.ReadLine().Replace("\r\n", "").Replace("kg", "").Trim();
            this.Invoke(new EventHandler(showData));
        }
        private void showData(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(dataIn))
            {
                if (Double.TryParse(dataIn, out weightRT))
                {
                    lbWeight.Text = weightRT.ToString();
                }
            }
        }
        private void LoadData2DTGV()
        {
            DataTable dt = new DataTable();
            dtgvHistoryList.DataSource = null;
            SqlSoft sql = new SqlSoft();
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from extrusion_packed_realtime where create_date > '" + dateStart + "' order by create_date desc");
            sql.sqlDataAdapterFillDatatable(sb.ToString(), ref dt);

            dtgvHistoryList.DataSource = dt;

            dtgvHistoryList.Columns["uuid"].Visible = false;
            dtgvHistoryList.Columns["product_code"].HeaderText = "Mã thành phẩm" + Environment.NewLine + "成品代码";
            dtgvHistoryList.Columns["length"].HeaderText = "Chiều dài" + Environment.NewLine + "长度";
            dtgvHistoryList.Columns["weight"].HeaderText = "Trọng lượng" + Environment.NewLine + "重量";
            dtgvHistoryList.Columns["sender"].Visible = false;
            dtgvHistoryList.Columns["receiver"].Visible = false;
            dtgvHistoryList.Columns["create_date"].HeaderText = "Ngày tạo" + Environment.NewLine + "创建日期";
            dtgvHistoryList.Columns["create_date"].DefaultCellStyle.Format = "dd/MM HH:mm:ss";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkNull() && !String.IsNullOrEmpty(cbxCodeList.Text.Trim()))
                {
                    DialogResult dialogResult = MessageBox.Show("Xác nhận lưu dữ liệu bên trên ?" + Environment.NewLine + "确认保存上面的数据？", "Cảnh báo / 警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.OK)
                    {
                        DetailInformation d = new DetailInformation();
                        SqlHR sqlHR = new SqlHR();

                        string EmpCode = sqlHR.sqlExecuteScalarString("select distinct Code from ZlEmployee where Code like '%-%' and CAST(SUBSTRING(Code, CHARINDEX('-', Code) + 1, LEN(Code)) AS int) = '" + Properties.Settings.Default.empCode + "'");
                        string EmpName = sqlHR.sqlExecuteScalarString("select distinct Name from ZlEmployee where Code = '" + EmpCode + "'");
                        string reEmpCode = sqlHR.sqlExecuteScalarString("select distinct Code from ZlEmployee where Code like '%-%' and CAST(SUBSTRING(Code, CHARINDEX('-', Code) + 1, LEN(Code)) AS int) = '" + txbEmpCode.Text + "'");
                        string reEmpName = sqlHR.sqlExecuteScalarString("select distinct Name from ZlEmployee where Code = '" + reEmpCode + "'");
                        d.Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                       
                        if (!String.IsNullOrEmpty(reEmpCode) || !String.IsNullOrEmpty(reEmpName) || !String.IsNullOrEmpty(EmpCode) || !String.IsNullOrEmpty(EmpName))
                        {
                            d.MainCode = cbxCodeList.Text.Trim();
                            d.Weight = Convert.ToDouble(lbWeight.Text.Trim());
                            d.Length = Convert.ToDouble(txbLength.Text.Trim());
                            d.Receiver = reEmpCode + " - " + reEmpName.TrimEnd();
                            d.Sender = EmpCode + " - " + EmpName.TrimEnd();

                            SqlSoft sqlSoft = new SqlSoft();
                            StringBuilder queryInsertData = new StringBuilder();
                            queryInsertData.Append(@"insert into extrusion_packed_realtime ");
                            queryInsertData.Append(@"(uuid, product_code, length, weight, sender, receiver, create_date) ");
                            queryInsertData.Append("values ");
                            queryInsertData.Append("('" + UUIDGenerator.getAscId() + "', '" + d.MainCode + "', " + d.Length + ", " + d.Weight + ", N'" + d.Sender + "', N'" + d.Receiver + "', '" + d.Date + "')");
                            sqlSoft.sqlExecuteNonQuery(queryInsertData.ToString(), false);

                            MessageBox.Show("Lưu thành công \n\r 保存成功 !!");

                            txbSearchCode.Focus();
                            txbLength.Text = String.Empty;
                           
                            LoadData2DTGV();
                        }
                        else
                        {
                            MessageBox.Show("Kiểm tra lại mã nhân viên \n\r 再次检查员工代码!!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không đủ dữ liệu \n\r 数据不足!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống! Vui lòng chụp màn hình và báo cho bộ phận phần mềm!" + Environment.NewLine + "系统错误！请截图并反馈给软件部！" + "\r\n\r\n" + ex.Message, "Cảnh báo / 警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Setting set = new Setting();
            set.ShowDialog();
        }

        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlSoft sqlSoft = new SqlSoft();
                StringBuilder queryGetData = new StringBuilder();
                queryGetData.Append("select * from extrusion_packed_realtime where create_date >= '" + dtpDateIn.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and create_date <= '" + dtpDateOut.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'");
                sqlSoft.sqlDataAdapterFillDatatable(queryGetData.ToString(), ref dt);

                if (dt.Rows.Count > 0)
                {
                    List<DetailInformation> details = new List<DetailInformation>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DetailInformation d = new DetailInformation();
                        d.Date = Convert.ToDateTime(dt.Rows[i]["create_date"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
                        d.MainCode = dt.Rows[i]["product_code"].ToString();
                        d.Length = Convert.ToDouble(dt.Rows[i]["length"].ToString());
                        d.Weight = Convert.ToDouble(dt.Rows[i]["weight"].ToString());
                        d.Sender = dt.Rows[i]["sender"].ToString();
                        d.Receiver = dt.Rows[i]["receiver"].ToString();
                        details.Add(d);
                    }
                    ExcelSave.SaveExcel(details);
                }
                else
                {
                    MessageBox.Show("Không lấy được dữ liệu từ server! \n 无法从服务器获取数据！");
                }
                //ExcelSave.SaveExcel(); // false, false
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
