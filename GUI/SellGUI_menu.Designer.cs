﻿namespace GUI
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox1 = new GroupBox();
            btnSanPham = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            btnOrder = new Button();
            btnCustomer = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox3 = new GroupBox();
            txbManufactory = new TextBox();
            txbPrice = new TextBox();
            txbWarranty = new TextBox();
            txbLaptopName = new TextBox();
            txbLaptopID = new TextBox();
            label31 = new Label();
            label30 = new Label();
            label14 = new Label();
            label13 = new Label();
            label10 = new Label();
            groupBox2 = new GroupBox();
            dgvListLaptop = new DataGridView();
            label4 = new Label();
            tabPage2 = new TabPage();
            cboTimKiem = new ComboBox();
            cbTimKiem = new CheckBox();
            txbTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnCustomerHuy = new Button();
            txbCustomerAddress = new TextBox();
            txbCustomerPhone = new TextBox();
            label9 = new Label();
            label8 = new Label();
            txbCustomerName = new TextBox();
            txbCustomerID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnCustomerGhi = new Button();
            btnCustomerXoa = new Button();
            btnCustomerThem = new Button();
            btnCustomerSua = new Button();
            dgvKhachHang = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            btnOrderXoa = new Button();
            cboOrderKhachHang = new ComboBox();
            label6 = new Label();
            txbSoLuongOrder = new TextBox();
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
            ColLaptopID = new DataGridViewTextBoxColumn();
            ColLapTopName = new DataGridViewTextBoxColumn();
            ColPrice = new DataGridViewTextBoxColumn();
            ColManufactory = new DataGridViewTextBoxColumn();
            ColWarrantyPeriod = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListLaptop).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSanPham);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(btnOrder);
            groupBox1.Controls.Add(btnCustomer);
            groupBox1.Location = new Point(-1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 943);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
            // 
            // btnSanPham
            // 
            btnSanPham.Location = new Point(0, 288);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(323, 83);
            btnSanPham.TabIndex = 4;
            btnSanPham.Text = "Sản phẩm";
            btnSanPham.UseVisualStyleBackColor = true;
            btnSanPham.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(323, 175);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(0, 867);
            button3.Name = "button3";
            button3.Size = new Size(323, 76);
            button3.TabIndex = 2;
            button3.Text = "Đăng xuất";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(0, 466);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(323, 83);
            btnOrder.TabIndex = 1;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(0, 377);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(323, 83);
            btnCustomer.TabIndex = 0;
            btnCustomer.Text = "Khách hàng";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(322, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1153, 943);
            tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(label4);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1145, 907);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txbManufactory);
            groupBox3.Controls.Add(txbPrice);
            groupBox3.Controls.Add(txbWarranty);
            groupBox3.Controls.Add(txbLaptopName);
            groupBox3.Controls.Add(txbLaptopID);
            groupBox3.Controls.Add(label31);
            groupBox3.Controls.Add(label30);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(18, 41);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(425, 858);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin chi tiết";
            // 
            // txbManufactory
            // 
            txbManufactory.Location = new Point(158, 267);
            txbManufactory.Name = "txbManufactory";
            txbManufactory.Size = new Size(175, 30);
            txbManufactory.TabIndex = 25;
            // 
            // txbPrice
            // 
            txbPrice.Location = new Point(158, 312);
            txbPrice.Name = "txbPrice";
            txbPrice.Size = new Size(175, 30);
            txbPrice.TabIndex = 24;
            // 
            // txbWarranty
            // 
            txbWarranty.Location = new Point(155, 361);
            txbWarranty.Name = "txbWarranty";
            txbWarranty.Size = new Size(175, 30);
            txbWarranty.TabIndex = 23;
            // 
            // txbLaptopName
            // 
            txbLaptopName.Location = new Point(157, 231);
            txbLaptopName.Name = "txbLaptopName";
            txbLaptopName.Size = new Size(175, 30);
            txbLaptopName.TabIndex = 22;
            // 
            // txbLaptopID
            // 
            txbLaptopID.Location = new Point(155, 180);
            txbLaptopID.Name = "txbLaptopID";
            txbLaptopID.Size = new Size(175, 30);
            txbLaptopID.TabIndex = 21;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(31, 215);
            label31.Name = "label31";
            label31.Size = new Size(90, 23);
            label31.TabIndex = 20;
            label31.Text = "Tên laptop";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(31, 267);
            label30.Name = "label30";
            label30.Size = new Size(107, 23);
            label30.TabIndex = 19;
            label30.Text = "Thương hiệu";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(31, 315);
            label14.Name = "label14";
            label14.Size = new Size(35, 23);
            label14.TabIndex = 3;
            label14.Text = "Giá";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(31, 364);
            label13.Name = "label13";
            label13.Size = new Size(83, 23);
            label13.TabIndex = 2;
            label13.Text = "Bảo hành";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(31, 175);
            label10.Name = "label10";
            label10.Size = new Size(34, 23);
            label10.TabIndex = 0;
            label10.Text = "Mã";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvListLaptop);
            groupBox2.Location = new Point(460, 40);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(666, 859);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách laptop";
            // 
            // dgvListLaptop
            // 
            dgvListLaptop.BackgroundColor = SystemColors.ButtonHighlight;
            dgvListLaptop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListLaptop.Columns.AddRange(new DataGridViewColumn[] { ColLaptopID, ColLapTopName, ColPrice, ColManufactory, ColWarrantyPeriod });
            dgvListLaptop.Location = new Point(15, 29);
            dgvListLaptop.Name = "dgvListLaptop";
            dgvListLaptop.RowHeadersWidth = 51;
            dgvListLaptop.RowTemplate.Height = 29;
            dgvListLaptop.Size = new Size(629, 814);
            dgvListLaptop.TabIndex = 0;
            dgvListLaptop.CellClick += dgvListLaptop_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(380, 15);
            label4.Name = "label4";
            label4.Size = new Size(192, 23);
            label4.TabIndex = 0;
            label4.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cboTimKiem);
            tabPage2.Controls.Add(cbTimKiem);
            tabPage2.Controls.Add(txbTimKiem);
            tabPage2.Controls.Add(btnTimKiem);
            tabPage2.Controls.Add(btnCustomerHuy);
            tabPage2.Controls.Add(txbCustomerAddress);
            tabPage2.Controls.Add(txbCustomerPhone);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(txbCustomerName);
            tabPage2.Controls.Add(txbCustomerID);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(btnCustomerGhi);
            tabPage2.Controls.Add(btnCustomerXoa);
            tabPage2.Controls.Add(btnCustomerThem);
            tabPage2.Controls.Add(btnCustomerSua);
            tabPage2.Controls.Add(dgvKhachHang);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1145, 910);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cboTimKiem
            // 
            cboTimKiem.FormattingEnabled = true;
            cboTimKiem.Items.AddRange(new object[] { "ID", "Tên", "SĐT" });
            cboTimKiem.Location = new Point(707, 117);
            cboTimKiem.Name = "cboTimKiem";
            cboTimKiem.Size = new Size(128, 31);
            cboTimKiem.TabIndex = 17;
            // 
            // cbTimKiem
            // 
            cbTimKiem.AutoSize = true;
            cbTimKiem.Location = new Point(596, 114);
            cbTimKiem.Name = "cbTimKiem";
            cbTimKiem.Size = new Size(101, 27);
            cbTimKiem.TabIndex = 16;
            cbTimKiem.Text = "Tìm kiếm";
            cbTimKiem.UseVisualStyleBackColor = true;
            cbTimKiem.CheckedChanged += cbTimKiem_CheckedChanged;
            // 
            // txbTimKiem
            // 
            txbTimKiem.Location = new Point(710, 158);
            txbTimKiem.Name = "txbTimKiem";
            txbTimKiem.Size = new Size(125, 30);
            txbTimKiem.TabIndex = 15;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(596, 158);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 14;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnCustomerHuy
            // 
            btnCustomerHuy.Location = new Point(598, 50);
            btnCustomerHuy.Name = "btnCustomerHuy";
            btnCustomerHuy.Size = new Size(94, 29);
            btnCustomerHuy.TabIndex = 13;
            btnCustomerHuy.Text = "Hủy";
            btnCustomerHuy.UseVisualStyleBackColor = true;
            btnCustomerHuy.Click += btnHuy_Click;
            // 
            // txbCustomerAddress
            // 
            txbCustomerAddress.Location = new Point(146, 226);
            txbCustomerAddress.Name = "txbCustomerAddress";
            txbCustomerAddress.Size = new Size(188, 30);
            txbCustomerAddress.TabIndex = 12;
            txbCustomerAddress.TextChanged += txbAddress_TextChanged;
            // 
            // txbCustomerPhone
            // 
            txbCustomerPhone.Location = new Point(148, 172);
            txbCustomerPhone.Name = "txbCustomerPhone";
            txbCustomerPhone.Size = new Size(186, 30);
            txbCustomerPhone.TabIndex = 11;
            txbCustomerPhone.TextChanged += txbPhone_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(40, 218);
            label9.Name = "label9";
            label9.Size = new Size(65, 23);
            label9.TabIndex = 10;
            label9.Text = "Địa Chỉ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 173);
            label8.Name = "label8";
            label8.Size = new Size(40, 23);
            label8.TabIndex = 9;
            label8.Text = "SĐT";
            // 
            // txbCustomerName
            // 
            txbCustomerName.Location = new Point(149, 110);
            txbCustomerName.Name = "txbCustomerName";
            txbCustomerName.Size = new Size(185, 30);
            txbCustomerName.TabIndex = 8;
            txbCustomerName.TextChanged += txbName_TextChanged;
            // 
            // txbCustomerID
            // 
            txbCustomerID.Location = new Point(149, 49);
            txbCustomerID.Name = "txbCustomerID";
            txbCustomerID.Size = new Size(185, 30);
            txbCustomerID.TabIndex = 7;
            txbCustomerID.TextChanged += txbID_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 110);
            label2.Name = "label2";
            label2.Size = new Size(36, 23);
            label2.TabIndex = 6;
            label2.Text = "Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 52);
            label1.Name = "label1";
            label1.Size = new Size(27, 23);
            label1.TabIndex = 5;
            label1.Text = "ID";
            // 
            // btnCustomerGhi
            // 
            btnCustomerGhi.ContextMenuStrip = contextMenuStrip1;
            btnCustomerGhi.DialogResult = DialogResult.Abort;
            btnCustomerGhi.Location = new Point(438, 222);
            btnCustomerGhi.Name = "btnCustomerGhi";
            btnCustomerGhi.Size = new Size(112, 34);
            btnCustomerGhi.TabIndex = 4;
            btnCustomerGhi.Text = "Ghi";
            btnCustomerGhi.UseVisualStyleBackColor = true;
            btnCustomerGhi.Click += btnGhi_Click;
            // 
            // btnCustomerXoa
            // 
            btnCustomerXoa.Location = new Point(438, 168);
            btnCustomerXoa.Name = "btnCustomerXoa";
            btnCustomerXoa.Size = new Size(112, 34);
            btnCustomerXoa.TabIndex = 3;
            btnCustomerXoa.Text = "Xóa";
            btnCustomerXoa.UseVisualStyleBackColor = true;
            btnCustomerXoa.Click += btnXoa_Click;
            // 
            // btnCustomerThem
            // 
            btnCustomerThem.Location = new Point(438, 45);
            btnCustomerThem.Name = "btnCustomerThem";
            btnCustomerThem.Size = new Size(112, 34);
            btnCustomerThem.TabIndex = 2;
            btnCustomerThem.Text = "Thêm";
            btnCustomerThem.UseVisualStyleBackColor = true;
            btnCustomerThem.Click += btnThem_Click;
            // 
            // btnCustomerSua
            // 
            btnCustomerSua.Location = new Point(438, 104);
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
            dgvKhachHang.Location = new Point(-1, 266);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 62;
            dgvKhachHang.RowTemplate.Height = 33;
            dgvKhachHang.Size = new Size(1140, 604);
            dgvKhachHang.TabIndex = 0;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            // 
            // colID
            // 
            colID.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colID.Frozen = true;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.Resizable = DataGridViewTriState.False;
            colID.Width = 56;
            // 
            // colName
            // 
            colName.HeaderText = "Tên";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.Width = 200;
            // 
            // colPhone
            // 
            colPhone.HeaderText = "SĐT";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "colPhone";
            colPhone.Width = 125;
            // 
            // colAddress
            // 
            colAddress.HeaderText = "Địa Chỉ";
            colAddress.MinimumWidth = 6;
            colAddress.Name = "colAddress";
            colAddress.Width = 125;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnOrderXoa);
            tabPage3.Controls.Add(cboOrderKhachHang);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(txbSoLuongOrder);
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
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1145, 910);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnOrderXoa
            // 
            btnOrderXoa.Location = new Point(698, 82);
            btnOrderXoa.Name = "btnOrderXoa";
            btnOrderXoa.Size = new Size(94, 29);
            btnOrderXoa.TabIndex = 25;
            btnOrderXoa.Text = "Xóa";
            btnOrderXoa.UseVisualStyleBackColor = true;
            btnOrderXoa.Click += btnOrderXoa_Click;
            // 
            // cboOrderKhachHang
            // 
            cboOrderKhachHang.FormattingEnabled = true;
            cboOrderKhachHang.Location = new Point(173, 47);
            cboOrderKhachHang.Name = "cboOrderKhachHang";
            cboOrderKhachHang.Size = new Size(285, 31);
            cboOrderKhachHang.TabIndex = 24;
            cboOrderKhachHang.SelectedIndexChanged += cboOrderKhachHang_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 47);
            label6.Name = "label6";
            label6.Size = new Size(101, 23);
            label6.TabIndex = 23;
            label6.Text = "Khách hàng";
            // 
            // txbSoLuongOrder
            // 
            txbSoLuongOrder.Location = new Point(173, 170);
            txbSoLuongOrder.Name = "txbSoLuongOrder";
            txbSoLuongOrder.Size = new Size(285, 30);
            txbSoLuongOrder.TabIndex = 22;
            txbSoLuongOrder.TextChanged += txbSoLuongOrder_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(533, 50);
            label11.Name = "label11";
            label11.Size = new Size(0, 23);
            label11.TabIndex = 21;
            // 
            // btnSuaOrder
            // 
            btnSuaOrder.Location = new Point(549, 114);
            btnSuaOrder.Name = "btnSuaOrder";
            btnSuaOrder.Size = new Size(112, 29);
            btnSuaOrder.TabIndex = 20;
            btnSuaOrder.Text = "Sửa";
            btnSuaOrder.UseVisualStyleBackColor = true;
            btnSuaOrder.Click += btnSuaOrder_Click;
            // 
            // btnThemOrder
            // 
            btnThemOrder.Location = new Point(549, 76);
            btnThemOrder.Name = "btnThemOrder";
            btnThemOrder.Size = new Size(112, 29);
            btnThemOrder.TabIndex = 19;
            btnThemOrder.Text = "Thêm";
            btnThemOrder.UseVisualStyleBackColor = true;
            btnThemOrder.Click += btnThemOrder_Click;
            // 
            // btnTaoOrder
            // 
            btnTaoOrder.Location = new Point(549, 162);
            btnTaoOrder.Name = "btnTaoOrder";
            btnTaoOrder.Size = new Size(112, 34);
            btnTaoOrder.TabIndex = 15;
            btnTaoOrder.Text = "Tạo order";
            btnTaoOrder.UseVisualStyleBackColor = true;
            btnTaoOrder.Click += button13_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(66, 173);
            label7.Name = "label7";
            label7.Size = new Size(78, 23);
            label7.TabIndex = 13;
            label7.Text = "Số lượng";
            // 
            // cboOrderLapTop
            // 
            cboOrderLapTop.FormattingEnabled = true;
            cboOrderLapTop.Location = new Point(172, 112);
            cboOrderLapTop.Name = "cboOrderLapTop";
            cboOrderLapTop.Size = new Size(285, 31);
            cboOrderLapTop.TabIndex = 11;
            cboOrderLapTop.SelectedIndexChanged += cboOrderLapTop_SelectedIndexChanged;
            // 
            // btnGhiOrder
            // 
            btnGhiOrder.Location = new Point(549, 212);
            btnGhiOrder.Name = "btnGhiOrder";
            btnGhiOrder.Size = new Size(112, 34);
            btnGhiOrder.TabIndex = 9;
            btnGhiOrder.Text = "Ghi";
            btnGhiOrder.UseVisualStyleBackColor = true;
            btnGhiOrder.Click += button11_Click;
            // 
            // btnHoanThanh
            // 
            btnHoanThanh.Location = new Point(896, 848);
            btnHoanThanh.Name = "btnHoanThanh";
            btnHoanThanh.Size = new Size(158, 34);
            btnHoanThanh.TabIndex = 6;
            btnHoanThanh.Text = "Hoàn thành";
            btnHoanThanh.UseVisualStyleBackColor = true;
            btnHoanThanh.Click += btnHoanThanh_Click;
            // 
            // btnHuyOrder
            // 
            btnHuyOrder.Location = new Point(748, 848);
            btnHuyOrder.Name = "btnHuyOrder";
            btnHuyOrder.Size = new Size(112, 34);
            btnHuyOrder.TabIndex = 5;
            btnHuyOrder.Text = "Hủy order";
            btnHuyOrder.UseVisualStyleBackColor = true;
            btnHuyOrder.Click += btnHuyOrder_Click;
            // 
            // lbTongDonGia
            // 
            lbTongDonGia.AutoSize = true;
            lbTongDonGia.Location = new Point(173, 854);
            lbTongDonGia.Name = "lbTongDonGia";
            lbTongDonGia.Size = new Size(0, 23);
            lbTongDonGia.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 854);
            label5.Name = "label5";
            label5.Size = new Size(92, 23);
            label5.TabIndex = 3;
            label5.Text = "Tổng cộng";
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Columns.AddRange(new DataGridViewColumn[] { Col1, Col2, Col3, Col4, Col5 });
            dgvOrder.Location = new Point(-4, 277);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.RowHeadersWidth = 62;
            dgvOrder.RowTemplate.Height = 33;
            dgvOrder.Size = new Size(1140, 522);
            dgvOrder.TabIndex = 2;
            dgvOrder.CellClick += dgvOrder_CellClick;
            // 
            // Col1
            // 
            Col1.HeaderText = "Mã sản phẩm";
            Col1.MinimumWidth = 6;
            Col1.Name = "Col1";
            Col1.ReadOnly = true;
            Col1.Width = 125;
            // 
            // Col2
            // 
            Col2.HeaderText = "Laptop";
            Col2.MinimumWidth = 6;
            Col2.Name = "Col2";
            Col2.ReadOnly = true;
            Col2.Width = 250;
            // 
            // Col3
            // 
            Col3.HeaderText = "Đơn giá";
            Col3.MinimumWidth = 6;
            Col3.Name = "Col3";
            Col3.ReadOnly = true;
            Col3.Width = 125;
            // 
            // Col4
            // 
            Col4.HeaderText = "Số lượng";
            Col4.MinimumWidth = 6;
            Col4.Name = "Col4";
            Col4.ReadOnly = true;
            Col4.Width = 125;
            // 
            // Col5
            // 
            Col5.HeaderText = "Tổng đơn giá";
            Col5.MinimumWidth = 6;
            Col5.Name = "Col5";
            Col5.ReadOnly = true;
            Col5.Width = 125;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 97);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 0;
            label3.Text = "Laptop";
            // 
            // ColLaptopID
            // 
            ColLaptopID.HeaderText = "Mã Laptop";
            ColLaptopID.MinimumWidth = 6;
            ColLaptopID.Name = "ColLaptopID";
            ColLaptopID.Width = 125;
            // 
            // ColLapTopName
            // 
            ColLapTopName.HeaderText = "Tên Laptop";
            ColLapTopName.MinimumWidth = 6;
            ColLapTopName.Name = "ColLapTopName";
            ColLapTopName.Width = 125;
            // 
            // ColPrice
            // 
            ColPrice.HeaderText = "Giá";
            ColPrice.MinimumWidth = 6;
            ColPrice.Name = "ColPrice";
            ColPrice.Width = 125;
            // 
            // ColManufactory
            // 
            ColManufactory.HeaderText = "Thương hiệu";
            ColManufactory.MinimumWidth = 6;
            ColManufactory.Name = "ColManufactory";
            ColManufactory.Width = 125;
            // 
            // ColWarrantyPeriod
            // 
            ColWarrantyPeriod.HeaderText = "Thời gian bảo hành";
            ColWarrantyPeriod.MinimumWidth = 6;
            ColWarrantyPeriod.Name = "ColWarrantyPeriod";
            ColWarrantyPeriod.Width = 125;
            // 
            // SellGUI_menu
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 944);
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            IsMdiContainer = true;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "SellGUI_menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý bán hàng";
            Load += SellGUI_menu_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListLaptop).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private GroupBox groupBox1;
        private Button button3;
        private Button btnOrder;
        private Button btnCustomer;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private Button btnSanPham;
        private Button btnCustomerGhi;
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
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colAddress;
        private TextBox txbTimKiem;
        private Button btnTimKiem;
        private ComboBox cboTimKiem;
        private CheckBox cbTimKiem;
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
        private GroupBox groupBox2;
        private DataGridView dgvListLaptop;
        private Label label4;
        private GroupBox groupBox3;
        private Label label31;
        private Label label30;
        private Label label14;
        private Label label13;
        private TextBox txbManufactory;
        private TextBox txbPrice;
        private TextBox txbWarranty;
        private TextBox txbLaptopName;
        private TextBox txbLaptopID;
        private DataGridViewTextBoxColumn Col1;
        private DataGridViewTextBoxColumn Col2;
        private DataGridViewTextBoxColumn Col3;
        private DataGridViewTextBoxColumn Col4;
        private DataGridViewTextBoxColumn Col5;
        private DataGridViewTextBoxColumn ColLaptopID;
        private DataGridViewTextBoxColumn ColLapTopName;
        private DataGridViewTextBoxColumn ColPrice;
        private DataGridViewTextBoxColumn ColManufactory;
        private DataGridViewTextBoxColumn ColWarrantyPeriod;
    }
}