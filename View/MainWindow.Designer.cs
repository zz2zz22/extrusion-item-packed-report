namespace extrusion_item_packed_report
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConnectScale = new XanderUI.XUIButton();
            this.cbxComport = new System.Windows.Forms.ComboBox();
            this.btnReloadPort = new XanderUI.XUIButton();
            this.btnSetting = new XanderUI.XUIButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new XanderUI.XUIButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txbEmpCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCodeList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSearchCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSaveExcel = new XanderUI.XUIButton();
            this.dtpDateOut = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDateIn = new System.Windows.Forms.DateTimePicker();
            this.dtgvHistoryList = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistoryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnConnectScale);
            this.panel1.Controls.Add(this.cbxComport);
            this.panel1.Controls.Add(this.btnReloadPort);
            this.panel1.Controls.Add(this.btnSetting);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 156);
            this.panel1.TabIndex = 0;
            // 
            // btnConnectScale
            // 
            this.btnConnectScale.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnConnectScale.ButtonImage = global::extrusion_item_packed_report.Properties.Resources.control_panel;
            this.btnConnectScale.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnConnectScale.ButtonText = "setting";
            this.btnConnectScale.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnConnectScale.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnConnectScale.CornerRadius = 5;
            this.btnConnectScale.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectScale.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnConnectScale.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnConnectScale.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnConnectScale.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnConnectScale.Location = new System.Drawing.Point(232, 93);
            this.btnConnectScale.Name = "btnConnectScale";
            this.btnConnectScale.Size = new System.Drawing.Size(214, 57);
            this.btnConnectScale.TabIndex = 4;
            this.btnConnectScale.TextColor = System.Drawing.Color.Black;
            this.btnConnectScale.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnConnectScale.Click += new System.EventHandler(this.btnConnectScale_Click);
            // 
            // cbxComport
            // 
            this.cbxComport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxComport.FormattingEnabled = true;
            this.cbxComport.Location = new System.Drawing.Point(83, 105);
            this.cbxComport.Name = "cbxComport";
            this.cbxComport.Size = new System.Drawing.Size(143, 33);
            this.cbxComport.TabIndex = 3;
            // 
            // btnReloadPort
            // 
            this.btnReloadPort.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReloadPort.ButtonImage = global::extrusion_item_packed_report.Properties.Resources.search_flat;
            this.btnReloadPort.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnReloadPort.ButtonText = "Button";
            this.btnReloadPort.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnReloadPort.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnReloadPort.CornerRadius = 5;
            this.btnReloadPort.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnReloadPort.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnReloadPort.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnReloadPort.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnReloadPort.Location = new System.Drawing.Point(17, 93);
            this.btnReloadPort.Name = "btnReloadPort";
            this.btnReloadPort.Size = new System.Drawing.Size(60, 57);
            this.btnReloadPort.TabIndex = 2;
            this.btnReloadPort.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnReloadPort.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnReloadPort.Click += new System.EventHandler(this.btnReloadPort_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSetting.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnSetting.ButtonImage")));
            this.btnSetting.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSetting.ButtonText = "setting";
            this.btnSetting.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSetting.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSetting.CornerRadius = 5;
            this.btnSetting.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSetting.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSetting.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSetting.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSetting.Location = new System.Drawing.Point(896, 4);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(214, 69);
            this.btnSetting.TabIndex = 1;
            this.btnSetting.TextColor = System.Drawing.Color.Black;
            this.btnSetting.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txbEmpCode);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbWeight);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txbLength);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbxCodeList);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txbSearchCode);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(653, 505);
            this.panel2.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnSave.ButtonImage")));
            this.btnSave.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSave.ButtonText = "setting";
            this.btnSave.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSave.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.CornerRadius = 5;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSave.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSave.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSave.Location = new System.Drawing.Point(314, 410);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(277, 78);
            this.btnSave.TabIndex = 11;
            this.btnSave.TextColor = System.Drawing.Color.Black;
            this.btnSave.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(268, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "TL / TV -";
            // 
            // txbEmpCode
            // 
            this.txbEmpCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmpCode.Location = new System.Drawing.Point(359, 333);
            this.txbEmpCode.Name = "txbEmpCode";
            this.txbEmpCode.Size = new System.Drawing.Size(155, 30);
            this.txbEmpCode.TabIndex = 9;
            this.txbEmpCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEmpCode_KeyPress);
            this.txbEmpCode.Validating += new System.ComponentModel.CancelEventHandler(this.txbEmpCode_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 40);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nhập mã nhân viên đóng gói:\r\n输入包装人员代码:";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Font = new System.Drawing.Font("Bahnschrift SemiBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWeight.Location = new System.Drawing.Point(233, 205);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(142, 96);
            this.lbWeight.TabIndex = 7;
            this.lbWeight.Text = "0.0";
            this.lbWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 40);
            this.label4.TabIndex = 6;
            this.label4.Text = "Khối lượng (đơn vị kg):\r\n重量（公斤）：";
            // 
            // txbLength
            // 
            this.txbLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLength.Location = new System.Drawing.Point(249, 137);
            this.txbLength.Name = "txbLength";
            this.txbLength.Size = new System.Drawing.Size(145, 38);
            this.txbLength.TabIndex = 5;
            this.txbLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLength_KeyPress);
            this.txbLength.Validating += new System.ComponentModel.CancelEventHandler(this.txbLength_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập chiều dài (đơn vị m):\r\n输入长度（以米为单位）:";
            // 
            // cbxCodeList
            // 
            this.cbxCodeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCodeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCodeList.FormattingEnabled = true;
            this.cbxCodeList.Location = new System.Drawing.Point(325, 76);
            this.cbxCodeList.Name = "cbxCodeList";
            this.cbxCodeList.Size = new System.Drawing.Size(298, 33);
            this.cbxCodeList.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn mã hàng từ danh sách đã tìm:\r\n从搜索列表中选择项目编号:";
            // 
            // txbSearchCode
            // 
            this.txbSearchCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchCode.Location = new System.Drawing.Point(231, 19);
            this.txbSearchCode.Name = "txbSearchCode";
            this.txbSearchCode.Size = new System.Drawing.Size(371, 30);
            this.txbSearchCode.TabIndex = 1;
            this.txbSearchCode.TextChanged += new System.EventHandler(this.txbSearchCode_TextChanged);
            this.txbSearchCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSearchCode_KeyDown);
            this.txbSearchCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSearchCode_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã hàng cần tìm:\r\n输入您要查找的商品代码:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.btnSaveExcel);
            this.panel3.Controls.Add(this.dtpDateOut);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.dtpDateIn);
            this.panel3.Controls.Add(this.dtgvHistoryList);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(653, 156);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 505);
            this.panel3.TabIndex = 2;
            // 
            // btnSaveExcel
            // 
            this.btnSaveExcel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSaveExcel.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnSaveExcel.ButtonImage")));
            this.btnSaveExcel.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSaveExcel.ButtonText = "setting";
            this.btnSaveExcel.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSaveExcel.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveExcel.CornerRadius = 5;
            this.btnSaveExcel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveExcel.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSaveExcel.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSaveExcel.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveExcel.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSaveExcel.Location = new System.Drawing.Point(56, 411);
            this.btnSaveExcel.Name = "btnSaveExcel";
            this.btnSaveExcel.Size = new System.Drawing.Size(371, 78);
            this.btnSaveExcel.TabIndex = 12;
            this.btnSaveExcel.TextColor = System.Drawing.Color.Black;
            this.btnSaveExcel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSaveExcel.Click += new System.EventHandler(this.btnSaveExcel_Click);
            // 
            // dtpDateOut
            // 
            this.dtpDateOut.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpDateOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOut.Location = new System.Drawing.Point(136, 382);
            this.dtpDateOut.Name = "dtpDateOut";
            this.dtpDateOut.Size = new System.Drawing.Size(230, 27);
            this.dtpDateOut.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(239, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "|";
            // 
            // dtpDateIn
            // 
            this.dtpDateIn.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpDateIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateIn.Location = new System.Drawing.Point(136, 329);
            this.dtpDateIn.Name = "dtpDateIn";
            this.dtpDateIn.Size = new System.Drawing.Size(230, 27);
            this.dtpDateIn.TabIndex = 2;
            // 
            // dtgvHistoryList
            // 
            this.dtgvHistoryList.AllowUserToAddRows = false;
            this.dtgvHistoryList.AllowUserToDeleteRows = false;
            this.dtgvHistoryList.AllowUserToResizeColumns = false;
            this.dtgvHistoryList.AllowUserToResizeRows = false;
            this.dtgvHistoryList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvHistoryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHistoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHistoryList.Location = new System.Drawing.Point(10, 63);
            this.dtgvHistoryList.Name = "dtgvHistoryList";
            this.dtgvHistoryList.RowHeadersVisible = false;
            this.dtgvHistoryList.RowHeadersWidth = 51;
            this.dtgvHistoryList.RowTemplate.Height = 24;
            this.dtgvHistoryList.Size = new System.Drawing.Size(467, 258);
            this.dtgvHistoryList.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 40);
            this.label8.TabIndex = 0;
            this.label8.Text = "Dữ liệu vừa nhập:\r\n导入数据：";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(400, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "m";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(480, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 29);
            this.label10.TabIndex = 13;
            this.label10.Text = "kg";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(269, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(536, 64);
            this.label11.TabIndex = 5;
            this.label11.Text = "Phần mềm nhập liệu đóng gói bộ phận Đùn\r\n挤压件包装区数据录入软件";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data entry software for extrusion parts packing area";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistoryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private XanderUI.XUIButton btnSetting;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbSearchCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCodeList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbEmpCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtgvHistoryList;
        private System.Windows.Forms.Label label8;
        private XanderUI.XUIButton btnSave;
        private XanderUI.XUIButton btnSaveExcel;
        private System.Windows.Forms.DateTimePicker dtpDateOut;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDateIn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private XanderUI.XUIButton btnConnectScale;
        private System.Windows.Forms.ComboBox cbxComport;
        private XanderUI.XUIButton btnReloadPort;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
    }
}

