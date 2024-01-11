namespace GUI
{
    partial class SellGUI_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellGUI_menu));
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            btnOrder = new Button();
            btnCustomer = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            tbTimKiem1 = new TextBox();
            btnExportExcel = new Button();
            btnGhi1 = new Button();
            btnCustomerHuy = new Button();
            txbCustomerAddress = new TextBox();
            txbCustomerPhone = new TextBox();
            label9 = new Label();
            label8 = new Label();
            txbCustomerName = new TextBox();
            txbCustomerID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnCustomerXoa = new Button();
            btnCustomerThem = new Button();
            btnCustomerSua = new Button();
            dgvKhachHang = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            label4 = new Label();
            tbSoLuong2 = new TextBox();
            btnHuy2 = new Button();
            SUM = new Label();
            btnOrderXoa = new Button();
            cboOrderKhachHang = new ComboBox();
            label6 = new Label();
            label11 = new Label();
            btnSuaOrder = new Button();
            btnThemOrder = new Button();
            btnTaoOrder = new Button();
            label7 = new Label();
            cboOrderLapTop = new ComboBox();
            btnGhiOrder = new Button();
            btnHoanThanh = new Button();
            btnHuyOrder = new Button();
            lbTongDonGia = new Label();
            label5 = new Label();
            dgvOrder = new DataGridView();
            Col1 = new DataGridViewTextBoxColumn();
            Col2 = new DataGridViewTextBoxColumn();
            Col3 = new DataGridViewTextBoxColumn();
            Col4 = new DataGridViewTextBoxColumn();
            Col5 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGoldenrodYellow;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(btnOrder);
            groupBox1.Controls.Add(btnCustomer);
            groupBox1.Location = new Point(-1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(327, 943);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(323, 175);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Cornsilk;
            button3.FlatAppearance.BorderColor = Color.Gainsboro;
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(0, 863);
            button3.Name = "button3";
            button3.Size = new Size(323, 76);
            button3.TabIndex = 2;
            button3.Text = "Đăng xuất";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.Cornsilk;
            btnOrder.FlatAppearance.BorderColor = Color.Gainsboro;
            btnOrder.FlatAppearance.BorderSize = 3;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Location = new Point(0, 401);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(321, 83);
            btnOrder.TabIndex = 1;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.Cornsilk;
            btnCustomer.FlatAppearance.BorderColor = Color.Gainsboro;
            btnCustomer.FlatAppearance.BorderSize = 3;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Location = new Point(2, 312);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(321, 83);
            btnCustomer.TabIndex = 0;
            btnCustomer.Text = "Khách hàng";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(322, -35);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1153, 979);
            tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 37);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1145, 938);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(btnExportExcel);
            tabPage2.Controls.Add(btnGhi1);
            tabPage2.Controls.Add(btnCustomerHuy);
            tabPage2.Controls.Add(txbCustomerAddress);
            tabPage2.Controls.Add(txbCustomerPhone);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(txbCustomerName);
            tabPage2.Controls.Add(txbCustomerID);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(btnCustomerXoa);
            tabPage2.Controls.Add(btnCustomerThem);
            tabPage2.Controls.Add(btnCustomerSua);
            tabPage2.Controls.Add(dgvKhachHang);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1145, 941);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbTimKiem1);
            groupBox2.Location = new Point(6, 184);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1133, 76);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // tbTimKiem1
            // 
            tbTimKiem1.Location = new Point(107, 33);
            tbTimKiem1.Name = "tbTimKiem1";
            tbTimKiem1.Size = new Size(226, 34);
            tbTimKiem1.TabIndex = 17;
            tbTimKiem1.TextChanged += tbTimKiem1_TextChanged;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Location = new Point(919, 22);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(112, 34);
            btnExportExcel.TabIndex = 15;
            btnExportExcel.Text = "Xuất Excel";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnGhi1
            // 
            btnGhi1.Location = new Point(582, 142);
            btnGhi1.Name = "btnGhi1";
            btnGhi1.Size = new Size(112, 34);
            btnGhi1.TabIndex = 14;
            btnGhi1.Text = "Ghi";
            btnGhi1.UseVisualStyleBackColor = true;
            btnGhi1.Click += btnGhi1_Click;
            // 
            // btnCustomerHuy
            // 
            btnCustomerHuy.Location = new Point(429, 142);
            btnCustomerHuy.Name = "btnCustomerHuy";
            btnCustomerHuy.Size = new Size(112, 34);
            btnCustomerHuy.TabIndex = 13;
            btnCustomerHuy.Text = "Hủy";
            btnCustomerHuy.UseVisualStyleBackColor = true;
            btnCustomerHuy.Click += btnHuy_Click;
            // 
            // txbCustomerAddress
            // 
            txbCustomerAddress.Location = new Point(460, 73);
            txbCustomerAddress.Name = "txbCustomerAddress";
            txbCustomerAddress.Size = new Size(188, 34);
            txbCustomerAddress.TabIndex = 12;
            txbCustomerAddress.TextChanged += txbAddress_TextChanged;
            // 
            // txbCustomerPhone
            // 
            txbCustomerPhone.Location = new Point(462, 16);
            txbCustomerPhone.MaxLength = 10;
            txbCustomerPhone.Name = "txbCustomerPhone";
            txbCustomerPhone.Size = new Size(186, 34);
            txbCustomerPhone.TabIndex = 11;
            txbCustomerPhone.TextChanged += txbPhone_TextChanged;
            txbCustomerPhone.KeyPress += txbCustomerPhone_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(354, 76);
            label9.Name = "label9";
            label9.Size = new Size(74, 28);
            label9.TabIndex = 10;
            label9.Text = "Địa Chỉ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(354, 19);
            label8.Name = "label8";
            label8.Size = new Size(47, 28);
            label8.TabIndex = 9;
            label8.Text = "SĐT";
            // 
            // txbCustomerName
            // 
            txbCustomerName.Location = new Point(140, 77);
            txbCustomerName.Name = "txbCustomerName";
            txbCustomerName.Size = new Size(185, 34);
            txbCustomerName.TabIndex = 8;
            txbCustomerName.TextChanged += txbName_TextChanged;
            // 
            // txbCustomerID
            // 
            txbCustomerID.Location = new Point(138, 22);
            txbCustomerID.Name = "txbCustomerID";
            txbCustomerID.Size = new Size(188, 34);
            txbCustomerID.TabIndex = 7;
            txbCustomerID.TextChanged += txbID_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 80);
            label2.Name = "label2";
            label2.Size = new Size(41, 28);
            label2.TabIndex = 6;
            label2.Text = "Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 25);
            label1.Name = "label1";
            label1.Size = new Size(31, 28);
            label1.TabIndex = 5;
            label1.Text = "ID";
            // 
            // btnCustomerXoa
            // 
            btnCustomerXoa.Location = new Point(737, 142);
            btnCustomerXoa.Name = "btnCustomerXoa";
            btnCustomerXoa.Size = new Size(112, 34);
            btnCustomerXoa.TabIndex = 3;
            btnCustomerXoa.Text = "Xóa";
            btnCustomerXoa.UseVisualStyleBackColor = true;
            btnCustomerXoa.Click += btnXoa_Click;
            // 
            // btnCustomerThem
            // 
            btnCustomerThem.Location = new Point(737, 19);
            btnCustomerThem.Name = "btnCustomerThem";
            btnCustomerThem.Size = new Size(112, 34);
            btnCustomerThem.TabIndex = 2;
            btnCustomerThem.Text = "Thêm";
            btnCustomerThem.UseVisualStyleBackColor = true;
            btnCustomerThem.Click += btnThem_Click;
            // 
            // btnCustomerSua
            // 
            btnCustomerSua.Location = new Point(737, 78);
            btnCustomerSua.Name = "btnCustomerSua";
            btnCustomerSua.Size = new Size(112, 34);
            btnCustomerSua.TabIndex = 1;
            btnCustomerSua.Text = "Sửa";
            btnCustomerSua.UseVisualStyleBackColor = true;
            btnCustomerSua.Click += btnSua_Click;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colPhone, colAddress });
            dgvKhachHang.Location = new Point(6, 266);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 62;
            dgvKhachHang.RowTemplate.Height = 33;
            dgvKhachHang.Size = new Size(1133, 628);
            dgvKhachHang.TabIndex = 0;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            // 
            // colID
            // 
            colID.Frozen = true;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.Resizable = DataGridViewTriState.False;
            colID.Width = 150;
            // 
            // colName
            // 
            colName.HeaderText = "Tên";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.Width = 300;
            // 
            // colPhone
            // 
            colPhone.HeaderText = "SĐT";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "colPhone";
            colPhone.Width = 250;
            // 
            // colAddress
            // 
            colAddress.HeaderText = "Địa Chỉ";
            colAddress.MinimumWidth = 6;
            colAddress.Name = "colAddress";
            colAddress.Width = 300;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(tbSoLuong2);
            tabPage3.Controls.Add(btnHuy2);
            tabPage3.Controls.Add(SUM);
            tabPage3.Controls.Add(btnOrderXoa);
            tabPage3.Controls.Add(cboOrderKhachHang);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(btnSuaOrder);
            tabPage3.Controls.Add(btnThemOrder);
            tabPage3.Controls.Add(btnTaoOrder);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(cboOrderLapTop);
            tabPage3.Controls.Add(btnGhiOrder);
            tabPage3.Controls.Add(btnHoanThanh);
            tabPage3.Controls.Add(btnHuyOrder);
            tabPage3.Controls.Add(lbTongDonGia);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(dgvOrder);
            tabPage3.Controls.Add(label3);
            tabPage3.Location = new Point(4, 37);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1145, 938);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 875);
            label4.Name = "label4";
            label4.Size = new Size(53, 28);
            label4.TabIndex = 29;
            label4.Text = "VND";
            // 
            // tbSoLuong2
            // 
            tbSoLuong2.Location = new Point(173, 148);
            tbSoLuong2.Name = "tbSoLuong2";
            tbSoLuong2.Size = new Size(229, 34);
            tbSoLuong2.TabIndex = 28;
            tbSoLuong2.TextChanged += tbSoLuong2_TextChanged;
            tbSoLuong2.KeyPress += tbSoLuong2_KeyPress;
            // 
            // btnHuy2
            // 
            btnHuy2.BackColor = Color.SeaShell;
            btnHuy2.Location = new Point(871, 221);
            btnHuy2.Name = "btnHuy2";
            btnHuy2.Size = new Size(112, 34);
            btnHuy2.TabIndex = 27;
            btnHuy2.Text = "Hủy";
            btnHuy2.UseVisualStyleBackColor = false;
            btnHuy2.Click += btnHuy2_Click;
            // 
            // SUM
            // 
            SUM.AutoSize = true;
            SUM.Location = new Point(173, 875);
            SUM.Name = "SUM";
            SUM.Size = new Size(23, 28);
            SUM.TabIndex = 26;
            SUM.Text = "0";
            // 
            // btnOrderXoa
            // 
            btnOrderXoa.Location = new Point(871, 145);
            btnOrderXoa.Name = "btnOrderXoa";
            btnOrderXoa.Size = new Size(112, 34);
            btnOrderXoa.TabIndex = 25;
            btnOrderXoa.Text = "Xóa";
            btnOrderXoa.UseVisualStyleBackColor = true;
            btnOrderXoa.Click += btnOrderXoa_Click;
            // 
            // cboOrderKhachHang
            // 
            cboOrderKhachHang.FormattingEnabled = true;
            cboOrderKhachHang.Location = new Point(173, 24);
            cboOrderKhachHang.Name = "cboOrderKhachHang";
            cboOrderKhachHang.Size = new Size(496, 36);
            cboOrderKhachHang.TabIndex = 24;
            cboOrderKhachHang.SelectedIndexChanged += cboOrderKhachHang_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 27);
            label6.Name = "label6";
            label6.Size = new Size(114, 28);
            label6.TabIndex = 23;
            label6.Text = "Khách hàng";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(533, 50);
            label11.Name = "label11";
            label11.Size = new Size(0, 28);
            label11.TabIndex = 21;
            // 
            // btnSuaOrder
            // 
            btnSuaOrder.Location = new Point(871, 85);
            btnSuaOrder.Name = "btnSuaOrder";
            btnSuaOrder.Size = new Size(112, 37);
            btnSuaOrder.TabIndex = 20;
            btnSuaOrder.Text = "Sửa";
            btnSuaOrder.UseVisualStyleBackColor = true;
            btnSuaOrder.Click += btnSuaOrder_Click;
            // 
            // btnThemOrder
            // 
            btnThemOrder.Location = new Point(871, 24);
            btnThemOrder.Name = "btnThemOrder";
            btnThemOrder.Size = new Size(112, 39);
            btnThemOrder.TabIndex = 19;
            btnThemOrder.Text = "Thêm";
            btnThemOrder.UseVisualStyleBackColor = true;
            btnThemOrder.Click += btnThemOrder_Click;
            // 
            // btnTaoOrder
            // 
            btnTaoOrder.Location = new Point(726, 24);
            btnTaoOrder.Name = "btnTaoOrder";
            btnTaoOrder.Size = new Size(112, 39);
            btnTaoOrder.TabIndex = 15;
            btnTaoOrder.Text = "Tạo order";
            btnTaoOrder.UseVisualStyleBackColor = true;
            btnTaoOrder.Click += button13_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 151);
            label7.Name = "label7";
            label7.Size = new Size(92, 28);
            label7.TabIndex = 13;
            label7.Text = "Số lượng";
            // 
            // cboOrderLapTop
            // 
            cboOrderLapTop.FormattingEnabled = true;
            cboOrderLapTop.Location = new Point(173, 82);
            cboOrderLapTop.Name = "cboOrderLapTop";
            cboOrderLapTop.Size = new Size(496, 36);
            cboOrderLapTop.TabIndex = 11;
            cboOrderLapTop.SelectedIndexChanged += cboOrderLapTop_SelectedIndexChanged;
            // 
            // btnGhiOrder
            // 
            btnGhiOrder.BackColor = Color.SeaShell;
            btnGhiOrder.Location = new Point(726, 221);
            btnGhiOrder.Name = "btnGhiOrder";
            btnGhiOrder.Size = new Size(112, 34);
            btnGhiOrder.TabIndex = 9;
            btnGhiOrder.Text = "Ghi";
            btnGhiOrder.UseVisualStyleBackColor = false;
            btnGhiOrder.Click += btnGhiOrder_Click;
            // 
            // btnHoanThanh
            // 
            btnHoanThanh.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnHoanThanh.Location = new Point(950, 872);
            btnHoanThanh.Name = "btnHoanThanh";
            btnHoanThanh.Size = new Size(168, 34);
            btnHoanThanh.TabIndex = 6;
            btnHoanThanh.Text = "Hoàn thành";
            btnHoanThanh.UseVisualStyleBackColor = true;
            btnHoanThanh.Click += btnHoanThanh_Click;
            // 
            // btnHuyOrder
            // 
            btnHuyOrder.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuyOrder.Location = new Point(743, 875);
            btnHuyOrder.Name = "btnHuyOrder";
            btnHuyOrder.Size = new Size(168, 34);
            btnHuyOrder.TabIndex = 5;
            btnHuyOrder.Text = "Hủy order";
            btnHuyOrder.UseVisualStyleBackColor = true;
            btnHuyOrder.Click += btnHuyOrder_Click;
            // 
            // lbTongDonGia
            // 
            lbTongDonGia.AutoSize = true;
            lbTongDonGia.Location = new Point(173, 885);
            lbTongDonGia.Name = "lbTongDonGia";
            lbTongDonGia.Size = new Size(0, 28);
            lbTongDonGia.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 875);
            label5.Name = "label5";
            label5.Size = new Size(106, 28);
            label5.TabIndex = 3;
            label5.Text = "Tổng cộng";
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Columns.AddRange(new DataGridViewColumn[] { Col1, Col2, Col3, Col4, Col5 });
            dgvOrder.Location = new Point(6, 277);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.RowHeadersWidth = 62;
            dgvOrder.RowTemplate.Height = 33;
            dgvOrder.Size = new Size(1130, 563);
            dgvOrder.TabIndex = 2;
            dgvOrder.CellClick += dgvOrder_CellClick;
            // 
            // Col1
            // 
            Col1.HeaderText = "ID";
            Col1.MinimumWidth = 6;
            Col1.Name = "Col1";
            Col1.ReadOnly = true;
            Col1.Width = 150;
            // 
            // Col2
            // 
            Col2.HeaderText = "Laptop";
            Col2.MinimumWidth = 6;
            Col2.Name = "Col2";
            Col2.ReadOnly = true;
            Col2.Width = 300;
            // 
            // Col3
            // 
            Col3.HeaderText = "Đơn giá";
            Col3.MinimumWidth = 6;
            Col3.Name = "Col3";
            Col3.ReadOnly = true;
            Col3.Width = 200;
            // 
            // Col4
            // 
            Col4.HeaderText = "Số lượng";
            Col4.MinimumWidth = 6;
            Col4.Name = "Col4";
            Col4.ReadOnly = true;
            Col4.Width = 150;
            // 
            // Col5
            // 
            Col5.HeaderText = "Tổng đơn giá";
            Col5.MinimumWidth = 6;
            Col5.Name = "Col5";
            Col5.ReadOnly = true;
            Col5.Width = 200;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 85);
            label3.Name = "label3";
            label3.Size = new Size(74, 28);
            label3.TabIndex = 0;
            label3.Text = "Laptop";
            // 
            // SellGUI_menu
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 944);
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "SellGUI_menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý bán hàng";
            Load += SellGUI_menu_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button button3;
        private Button btnOrder;
        private Button btnCustomer;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private Button btnCustomerXoa;
        private Button btnCustomerThem;
        private Button btnCustomerSua;
        private DataGridView dgvKhachHang;
        private TextBox txbCustomerName;
        private TextBox txbCustomerID;
        private Label label2;
        private Label label1;
        private TextBox txbCustomerAddress;
        private TextBox txbCustomerPhone;
        private Label label9;
        private Label label8;
        private Button btnCustomerHuy;
        private TabPage tabPage3;
        private Label label11;
        private Button btnSuaOrder;
        private Button btnThemOrder;
        private TextBox txbSoLuong;
        private Label label10;
        private Button btnTaoOrder;
        private Label label7;
        private ComboBox cboOrderLapTop;
        private Button btnGhiOrder;
        private Button btnHoanThanh;
        private Button btnHuyOrder;
        private Label lbTongDonGia;
        private Label label5;
        private Label label3;
        private DataGridView dgvOrder;
        private ComboBox cboOrderKhachHang;
        private Label label6;
        private TextBox txbSoLuongOrder;
        private Button btnOrderXoa;
        private Label SUM;
        private Button btnHuy2;
        private TextBox tbSoLuong2;
        private Button btnGhi1;
        private Button btnExportExcel;
        private TextBox tbTimKiem1;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colAddress;
        private Label label4;
        private DataGridViewTextBoxColumn Col1;
        private DataGridViewTextBoxColumn Col2;
        private DataGridViewTextBoxColumn Col3;
        private DataGridViewTextBoxColumn Col4;
        private DataGridViewTextBoxColumn Col5;
    }
}