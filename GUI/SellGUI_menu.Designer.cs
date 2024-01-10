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
            groupBox3 = new GroupBox();
            textBox1 = new TextBox();
            label4 = new Label();
            dgvKhachHang = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            groupBox5 = new GroupBox();
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
            tabPage3 = new TabPage();
            groupBox4 = new GroupBox();
            tbSoLuong2 = new TextBox();
            btnHuy2 = new Button();
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
            label3 = new Label();
            groupBox2 = new GroupBox();
            SUM = new Label();
            btnHoanThanh = new Button();
            btnHuyOrder = new Button();
            label5 = new Label();
            dgvOrder = new DataGridView();
            Col1 = new DataGridViewTextBoxColumn();
            Col2 = new DataGridViewTextBoxColumn();
            Col3 = new DataGridViewTextBoxColumn();
            Col4 = new DataGridViewTextBoxColumn();
            Col5 = new DataGridViewTextBoxColumn();
            lbTongDonGia = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            groupBox5.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.AliceBlue;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(btnOrder);
            groupBox1.Controls.Add(btnCustomer);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(0, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(326, 774);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(9, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 218);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightCyan;
            button3.FlatAppearance.BorderColor = Color.MediumTurquoise;
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(13, 692);
            button3.Name = "button3";
            button3.Size = new Size(293, 76);
            button3.TabIndex = 2;
            button3.Text = "Đăng xuất";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.White;
            btnOrder.FlatAppearance.BorderColor = Color.MediumTurquoise;
            btnOrder.FlatAppearance.BorderSize = 3;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrder.Location = new Point(13, 387);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(293, 83);
            btnOrder.TabIndex = 1;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.White;
            btnCustomer.FlatAppearance.BorderColor = Color.MediumTurquoise;
            btnCustomer.FlatAppearance.BorderSize = 2;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCustomer.Location = new Point(13, 298);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(293, 83);
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
            tabControl1.Location = new Point(322, -30);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(899, 805);
            tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(891, 769);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox5);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(891, 727);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(dgvKhachHang);
            groupBox3.Location = new Point(3, 252);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(885, 489);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Khách hàng";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 30);
            textBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 36);
            label4.Name = "label4";
            label4.Size = new Size(79, 23);
            label4.TabIndex = 2;
            label4.Text = "Tìm kiếm";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colPhone, colAddress });
            dgvKhachHang.Location = new Point(3, 69);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 62;
            dgvKhachHang.RowTemplate.Height = 33;
            dgvKhachHang.Size = new Size(876, 401);
            dgvKhachHang.TabIndex = 1;
            // 
            // colID
            // 
            colID.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colID.Frozen = true;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Resizable = DataGridViewTriState.True;
            colID.Width = 56;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colName.HeaderText = "Tên";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 250;
            // 
            // colPhone
            // 
            colPhone.HeaderText = "SĐT";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            colPhone.Width = 190;
            // 
            // colAddress
            // 
            colAddress.HeaderText = "Địa Chỉ";
            colAddress.MinimumWidth = 6;
            colAddress.Name = "colAddress";
            colAddress.ReadOnly = true;
            colAddress.Width = 330;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnCustomerHuy);
            groupBox5.Controls.Add(txbCustomerAddress);
            groupBox5.Controls.Add(txbCustomerPhone);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(txbCustomerName);
            groupBox5.Controls.Add(txbCustomerID);
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(label1);
            groupBox5.Controls.Add(btnCustomerGhi);
            groupBox5.Controls.Add(btnCustomerXoa);
            groupBox5.Controls.Add(btnCustomerThem);
            groupBox5.Controls.Add(btnCustomerSua);
            groupBox5.Location = new Point(3, 6);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(882, 240);
            groupBox5.TabIndex = 15;
            groupBox5.TabStop = false;
            groupBox5.Text = "Thông tin khách hàng";
            // 
            // btnCustomerHuy
            // 
            btnCustomerHuy.BackColor = Color.FloralWhite;
            btnCustomerHuy.FlatAppearance.BorderColor = Color.MediumTurquoise;
            btnCustomerHuy.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomerHuy.Location = new Point(667, 86);
            btnCustomerHuy.Name = "btnCustomerHuy";
            btnCustomerHuy.Size = new Size(112, 34);
            btnCustomerHuy.TabIndex = 26;
            btnCustomerHuy.Text = "Hủy";
            btnCustomerHuy.UseVisualStyleBackColor = false;
            // 
            // txbCustomerAddress
            // 
            txbCustomerAddress.Location = new Point(127, 188);
            txbCustomerAddress.Name = "txbCustomerAddress";
            txbCustomerAddress.Size = new Size(188, 30);
            txbCustomerAddress.TabIndex = 25;
            // 
            // txbCustomerPhone
            // 
            txbCustomerPhone.Location = new Point(127, 138);
            txbCustomerPhone.Name = "txbCustomerPhone";
            txbCustomerPhone.Size = new Size(188, 30);
            txbCustomerPhone.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 191);
            label9.Name = "label9";
            label9.Size = new Size(84, 23);
            label9.TabIndex = 23;
            label9.Text = "Địa chỉ (*)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 142);
            label8.Name = "label8";
            label8.Size = new Size(62, 23);
            label8.TabIndex = 22;
            label8.Text = "SĐT (*)";
            // 
            // txbCustomerName
            // 
            txbCustomerName.Location = new Point(127, 90);
            txbCustomerName.Name = "txbCustomerName";
            txbCustomerName.Size = new Size(185, 30);
            txbCustomerName.TabIndex = 21;
            // 
            // txbCustomerID
            // 
            txbCustomerID.Location = new Point(127, 37);
            txbCustomerID.Name = "txbCustomerID";
            txbCustomerID.Size = new Size(185, 30);
            txbCustomerID.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 93);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 19;
            label2.Text = "Họ tên (*)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 40);
            label1.Name = "label1";
            label1.Size = new Size(49, 23);
            label1.TabIndex = 18;
            label1.Text = "ID (*)";
            // 
            // btnCustomerGhi
            // 
            btnCustomerGhi.BackColor = Color.FloralWhite;
            btnCustomerGhi.DialogResult = DialogResult.Abort;
            btnCustomerGhi.FlatAppearance.BorderColor = Color.MediumTurquoise;
            btnCustomerGhi.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomerGhi.Location = new Point(667, 33);
            btnCustomerGhi.Name = "btnCustomerGhi";
            btnCustomerGhi.Size = new Size(112, 34);
            btnCustomerGhi.TabIndex = 17;
            btnCustomerGhi.Text = "Ghi";
            btnCustomerGhi.UseVisualStyleBackColor = false;
            // 
            // btnCustomerXoa
            // 
            btnCustomerXoa.BackColor = SystemColors.ButtonHighlight;
            btnCustomerXoa.FlatAppearance.BorderColor = Color.MediumTurquoise;
            btnCustomerXoa.Location = new Point(494, 138);
            btnCustomerXoa.Name = "btnCustomerXoa";
            btnCustomerXoa.Size = new Size(112, 34);
            btnCustomerXoa.TabIndex = 16;
            btnCustomerXoa.Text = "Xóa";
            btnCustomerXoa.UseVisualStyleBackColor = false;
            // 
            // btnCustomerThem
            // 
            btnCustomerThem.BackColor = SystemColors.ButtonHighlight;
            btnCustomerThem.FlatAppearance.BorderColor = Color.MediumTurquoise;
            btnCustomerThem.Location = new Point(494, 34);
            btnCustomerThem.Name = "btnCustomerThem";
            btnCustomerThem.Size = new Size(112, 34);
            btnCustomerThem.TabIndex = 15;
            btnCustomerThem.Text = "Thêm";
            btnCustomerThem.UseVisualStyleBackColor = false;
            // 
            // btnCustomerSua
            // 
            btnCustomerSua.BackColor = SystemColors.ButtonHighlight;
            btnCustomerSua.FlatAppearance.BorderColor = Color.MediumTurquoise;
            btnCustomerSua.Location = new Point(494, 87);
            btnCustomerSua.Name = "btnCustomerSua";
            btnCustomerSua.Size = new Size(112, 34);
            btnCustomerSua.TabIndex = 14;
            btnCustomerSua.Text = "Sửa";
            btnCustomerSua.UseVisualStyleBackColor = false;
            // 
            // tabPage3
            // 
            tabPage3.BorderStyle = BorderStyle.FixedSingle;
            tabPage3.Controls.Add(groupBox4);
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Controls.Add(lbTongDonGia);
            tabPage3.Location = new Point(4, 32);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(891, 727);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tbSoLuong2);
            groupBox4.Controls.Add(btnHuy2);
            groupBox4.Controls.Add(btnOrderXoa);
            groupBox4.Controls.Add(cboOrderKhachHang);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(btnSuaOrder);
            groupBox4.Controls.Add(btnThemOrder);
            groupBox4.Controls.Add(btnTaoOrder);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(cboOrderLapTop);
            groupBox4.Controls.Add(btnGhiOrder);
            groupBox4.Controls.Add(label3);
            groupBox4.Location = new Point(3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(883, 224);
            groupBox4.TabIndex = 30;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin";
            // 
            // tbSoLuong2
            // 
            tbSoLuong2.Location = new Point(190, 166);
            tbSoLuong2.Name = "tbSoLuong2";
            tbSoLuong2.Size = new Size(94, 30);
            tbSoLuong2.TabIndex = 41;
            // 
            // btnHuy2
            // 
            btnHuy2.BackColor = Color.FloralWhite;
            btnHuy2.FlatAppearance.BorderColor = Color.MediumAquamarine;
            btnHuy2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuy2.Location = new Point(711, 161);
            btnHuy2.Name = "btnHuy2";
            btnHuy2.Size = new Size(112, 34);
            btnHuy2.TabIndex = 40;
            btnHuy2.Text = "Hủy";
            btnHuy2.UseVisualStyleBackColor = false;
            // 
            // btnOrderXoa
            // 
            btnOrderXoa.BackColor = SystemColors.ButtonHighlight;
            btnOrderXoa.FlatAppearance.BorderColor = Color.MediumAquamarine;
            btnOrderXoa.Location = new Point(572, 161);
            btnOrderXoa.Name = "btnOrderXoa";
            btnOrderXoa.Size = new Size(112, 34);
            btnOrderXoa.TabIndex = 39;
            btnOrderXoa.Text = "Xóa";
            btnOrderXoa.UseVisualStyleBackColor = false;
            // 
            // cboOrderKhachHang
            // 
            cboOrderKhachHang.FormattingEnabled = true;
            cboOrderKhachHang.Location = new Point(190, 40);
            cboOrderKhachHang.Name = "cboOrderKhachHang";
            cboOrderKhachHang.Size = new Size(285, 31);
            cboOrderKhachHang.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 43);
            label6.Name = "label6";
            label6.Size = new Size(123, 23);
            label6.TabIndex = 37;
            label6.Text = "Khách hàng (*)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ButtonFace;
            label11.Location = new Point(587, 37);
            label11.Name = "label11";
            label11.Size = new Size(0, 23);
            label11.TabIndex = 36;
            // 
            // btnSuaOrder
            // 
            btnSuaOrder.BackColor = SystemColors.ButtonHighlight;
            btnSuaOrder.FlatAppearance.BorderColor = Color.MediumTurquoise;
            btnSuaOrder.Location = new Point(572, 100);
            btnSuaOrder.Name = "btnSuaOrder";
            btnSuaOrder.Size = new Size(112, 34);
            btnSuaOrder.TabIndex = 35;
            btnSuaOrder.Text = "Sửa";
            btnSuaOrder.UseVisualStyleBackColor = false;
            // 
            // btnThemOrder
            // 
            btnThemOrder.BackColor = SystemColors.ButtonHighlight;
            btnThemOrder.FlatAppearance.BorderColor = Color.MediumAquamarine;
            btnThemOrder.Location = new Point(572, 37);
            btnThemOrder.Name = "btnThemOrder";
            btnThemOrder.Size = new Size(112, 34);
            btnThemOrder.TabIndex = 34;
            btnThemOrder.Text = "Thêm";
            btnThemOrder.UseVisualStyleBackColor = false;
            // 
            // btnTaoOrder
            // 
            btnTaoOrder.BackColor = Color.FloralWhite;
            btnTaoOrder.FlatAppearance.BorderColor = Color.MediumAquamarine;
            btnTaoOrder.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnTaoOrder.Location = new Point(711, 37);
            btnTaoOrder.Name = "btnTaoOrder";
            btnTaoOrder.Size = new Size(112, 34);
            btnTaoOrder.TabIndex = 33;
            btnTaoOrder.Text = "Tạo order";
            btnTaoOrder.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 169);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 32;
            label7.Text = "Số lượng (*)";
            // 
            // cboOrderLapTop
            // 
            cboOrderLapTop.FormattingEnabled = true;
            cboOrderLapTop.Location = new Point(190, 100);
            cboOrderLapTop.Name = "cboOrderLapTop";
            cboOrderLapTop.Size = new Size(285, 31);
            cboOrderLapTop.TabIndex = 31;
            // 
            // btnGhiOrder
            // 
            btnGhiOrder.BackColor = Color.FloralWhite;
            btnGhiOrder.FlatAppearance.BorderColor = Color.MediumAquamarine;
            btnGhiOrder.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGhiOrder.Location = new Point(711, 100);
            btnGhiOrder.Name = "btnGhiOrder";
            btnGhiOrder.Size = new Size(112, 34);
            btnGhiOrder.TabIndex = 30;
            btnGhiOrder.Text = "Ghi";
            btnGhiOrder.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 103);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 29;
            label3.Text = "Laptop (*)";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(SUM);
            groupBox2.Controls.Add(btnHoanThanh);
            groupBox2.Controls.Add(btnHuyOrder);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(dgvOrder);
            groupBox2.Location = new Point(2, 226);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(884, 538);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa đơn";
            // 
            // SUM
            // 
            SUM.AutoSize = true;
            SUM.Location = new Point(142, 502);
            SUM.Name = "SUM";
            SUM.Size = new Size(42, 23);
            SUM.TabIndex = 30;
            SUM.Text = "sum";
            // 
            // btnHoanThanh
            // 
            btnHoanThanh.BackColor = SystemColors.ButtonHighlight;
            btnHoanThanh.FlatAppearance.BorderColor = Color.MediumAquamarine;
            btnHoanThanh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnHoanThanh.Location = new Point(745, 496);
            btnHoanThanh.Name = "btnHoanThanh";
            btnHoanThanh.Size = new Size(112, 34);
            btnHoanThanh.TabIndex = 29;
            btnHoanThanh.Text = "Hoàn thành";
            btnHoanThanh.UseVisualStyleBackColor = false;
            // 
            // btnHuyOrder
            // 
            btnHuyOrder.BackColor = SystemColors.ButtonHighlight;
            btnHuyOrder.FlatAppearance.BorderColor = Color.MediumAquamarine;
            btnHuyOrder.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuyOrder.Location = new Point(611, 496);
            btnHuyOrder.Name = "btnHuyOrder";
            btnHuyOrder.Size = new Size(112, 34);
            btnHuyOrder.TabIndex = 28;
            btnHuyOrder.Text = "Hủy order";
            btnHuyOrder.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(24, 497);
            label5.Name = "label5";
            label5.Size = new Size(112, 28);
            label5.TabIndex = 27;
            label5.Text = "Tổng cộng";
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Columns.AddRange(new DataGridViewColumn[] { Col1, Col2, Col3, Col4, Col5 });
            dgvOrder.Location = new Point(6, 27);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.RowHeadersWidth = 62;
            dgvOrder.RowTemplate.Height = 33;
            dgvOrder.Size = new Size(874, 457);
            dgvOrder.TabIndex = 3;
            // 
            // Col1
            // 
            Col1.HeaderText = "ID";
            Col1.MinimumWidth = 6;
            Col1.Name = "Col1";
            Col1.ReadOnly = true;
            Col1.Width = 60;
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
            Col3.Width = 170;
            // 
            // Col4
            // 
            Col4.HeaderText = "Số lượng";
            Col4.MinimumWidth = 6;
            Col4.Name = "Col4";
            Col4.ReadOnly = true;
            Col4.Width = 110;
            // 
            // Col5
            // 
            Col5.HeaderText = "Tổng đơn giá";
            Col5.MinimumWidth = 6;
            Col5.Name = "Col5";
            Col5.ReadOnly = true;
            Col5.Width = 170;
            // 
            // lbTongDonGia
            // 
            lbTongDonGia.AutoSize = true;
            lbTongDonGia.Location = new Point(173, 854);
            lbTongDonGia.Name = "lbTongDonGia";
            lbTongDonGia.Size = new Size(0, 23);
            lbTongDonGia.TabIndex = 4;
            // 
            // SellGUI_menu
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 778);
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
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button button3;
        private Button btnOrder;
        private Button btnCustomer;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private TextBox txbSoLuong;
        private Label label10;
        private Label lbTongDonGia;
        private TextBox txbSoLuongOrder;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private DataGridView dgvOrder;
        private GroupBox groupBox3;
        private DataGridView dgvKhachHang;
        private Label SUM;
        private Button btnHoanThanh;
        private Button btnHuyOrder;
        private Label label5;
        private DataGridViewTextBoxColumn Col1;
        private DataGridViewTextBoxColumn Col2;
        private DataGridViewTextBoxColumn Col3;
        private DataGridViewTextBoxColumn Col4;
        private DataGridViewTextBoxColumn Col5;
        private GroupBox groupBox4;
        private TextBox tbSoLuong2;
        private Button btnHuy2;
        private Button btnOrderXoa;
        private ComboBox cboOrderKhachHang;
        private Label label6;
        private Label label11;
        private Button btnSuaOrder;
        private Button btnThemOrder;
        private Button btnTaoOrder;
        private Label label7;
        private ComboBox cboOrderLapTop;
        private Button btnGhiOrder;
        private Label label3;
        private GroupBox groupBox5;
        private Button btnCustomerHuy;
        private TextBox txbCustomerAddress;
        private TextBox txbCustomerPhone;
        private Label label9;
        private Label label8;
        private TextBox txbCustomerName;
        private TextBox txbCustomerID;
        private Label label2;
        private Label label1;
        private Button btnCustomerGhi;
        private Button btnCustomerXoa;
        private Button btnCustomerThem;
        private Button btnCustomerSua;
        private TextBox textBox1;
        private Label label4;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colAddress;
    }
}
