using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
using DTO;
using Microsoft.VisualBasic.ApplicationServices;

namespace GUI
{
    public partial class SellGUI_menu : Form
    {
        private Customer customer = new Customer();
        private Staff user = new();
        string state = null;
        private Order order = new Order();
        private Laptop choosenlaptop = new Laptop();
        private List<Laptop> laptops = new List<Laptop>();
        private List<Customer> customers = new List<Customer>();
        private List<Staff> staffs = new List<Staff>();
        decimal sum=0;
        public SellGUI_menu(Staff user)
        {
            this.user = user;
            InitializeComponent();
        }
        #region LoadingEvent
        private void LoadingCustomer()
        {
            foreach (Customer item in CustomerBUS.Instance.get())
            {

                dgvKhachHang.Rows.Add(item.ID, item.Name, item.Phone, item.Address);
            }
            DataGridViewRow row = dgvKhachHang.Rows[0];
            if (Convert.ToString(row.Cells["colID"].Value) != "")
            {
                txbCustomerID.Text = Convert.ToString(row.Cells["colID"].Value);
                txbCustomerName.Text = Convert.ToString(row.Cells["colName"].Value);
                txbCustomerPhone.Text = Convert.ToString(row.Cells["colPhone"].Value);
                txbCustomerAddress.Text = Convert.ToString(row.Cells["colAddress"].Value);
            }
        }
        private void LoadingOrder()
        {
            dgvOrder.Rows.Clear();
            foreach (Laptop items in order.Laptop)
            {
                dgvOrder.Rows.Add(items.ID, items.Name, items.Price, items.QuantityBought);
            }

            /*DataGridViewRow row = dgvKhachHang.Rows[0];
            if (Convert.ToString(row.Cells["colID"].Value) != "")
            {
                txbCustomerID.Text = Convert.ToString(row.Cells["colID"].Value);
                txbCustomerName.Text = Convert.ToString(row.Cells["colName"].Value);
                txbCustomerPhone.Text = Convert.ToString(row.Cells["colPhone"].Value);
                txbCustomerAddress.Text = Convert.ToString(row.Cells["colAddress"].Value);
            }*/
        }
        
        #endregion
        private void SellGUI_menu_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            LoadingCustomer();
            state = "Start";
            ManageInterface(state);
            ManageInterface("StartOrder");
            cbTimKiem_CheckedChanged(sender, e);
            tab2Loading1();

        }
        #region ClickEvent
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvKhachHang.Rows[e.RowIndex];
            if (Convert.ToString(row.Cells["colID"]) != null)
            {
                txbCustomerID.Text = Convert.ToString(row.Cells["colID"].Value);
                txbCustomerName.Text = Convert.ToString(row.Cells["colName"].Value);
                txbCustomerPhone.Text = Convert.ToString(row.Cells["colPhone"].Value);
                txbCustomerAddress.Text = Convert.ToString(row.Cells["colAddress"].Value);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            state = "Add";
            ManageInterface(state);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            state = "Update";
            ManageInterface(state);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CustomerBUS.Instance.delete(customer);
                this.dgvKhachHang.DataSource = null;
                this.dgvKhachHang.Rows.Clear();
                LoadingCustomer();
                ManageInterface("Start");
            }
        }
        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (state == "Add")
            {
                char[] PhoneArr = customer.Phone.ToCharArray();
                if (txbCustomerName.Text != "" && txbCustomerPhone.Text != "" && txbCustomerAddress.Text != "")
                {
                    if (CustomerBUS.Instance.CheckPhone(customer) == true)
                    {
                        MessageBox.Show("Số điện thoại đã tồn tại");
                    }
                    else if (PhoneArr.Length != 10)
                    {
                        MessageBox.Show("Số điện thoại phải đúng đủ 10 số!");
                    }
                    else
                    {
                        CustomerBUS.Instance.insert(customer);
                        this.dgvKhachHang.DataSource = null;
                        this.dgvKhachHang.Rows.Clear();
                        LoadingCustomer();
                        MessageBox.Show("Thêm thông tin thành công", "Thông báo");
                        ManageInterface("Start");
                    }
                }
                else
                {
                    MessageBox.Show("Yêu cầu nhập đầy đủ thông tin!", "Thông báo");
                    txbCustomerName.Focus();
                }
            }
            if (state == "Update")
            {
                if (txbCustomerName.Text != "" && txbCustomerPhone.Text != "" && txbCustomerAddress.Text != "")
                {
                    CustomerBUS.Instance.update(customer);
                    this.dgvKhachHang.DataSource = null;
                    this.dgvKhachHang.Rows.Clear();
                    LoadingCustomer();
                    MessageBox.Show("Sửa thông tin thành công", "Thông báo");
                    ManageInterface("Start");
                }
                else
                {
                    MessageBox.Show("Yêu cầu nhập đầy đủ thông tin!", "Thông báo");
                    txbCustomerName.Focus();
                }
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txbCustomerID.Text = "";
            txbCustomerName.Text = "";
            txbCustomerPhone.Text = "";
            txbCustomerAddress.Text = "";
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboTimKiem.Text == "ID")
            {
                this.dgvKhachHang.DataSource = null;
                this.dgvKhachHang.Rows.Clear();

                foreach (Customer item in CustomerBUS.Instance.get())
                {
                    if (item.ID == Convert.ToInt32(txbTimKiem.Text))
                    {
                        dgvKhachHang.Rows.Add(item.ID, item.Name, item.Phone, item.Address);
                    }
                }
            }
            else if (cboTimKiem.Text == "Tên")
            {
                this.dgvKhachHang.DataSource = null;
                this.dgvKhachHang.Rows.Clear();

                foreach (Customer item in CustomerBUS.Instance.get())
                {
                    if (item.Name == txbTimKiem.Text)
                    {
                        dgvKhachHang.Rows.Add(item.ID, item.Name, item.Phone, item.Address);
                    }
                }
            }
            else
            {
                this.dgvKhachHang.DataSource = null;
                this.dgvKhachHang.Rows.Clear();

                foreach (Customer item in CustomerBUS.Instance.get())
                {
                    if (item.Phone == txbTimKiem.Text)
                    {
                        dgvKhachHang.Rows.Add(item.ID, item.Name, item.Phone, item.Address);
                    }
                }
            }
        }

        private void cbTimKiem_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTimKiem.Checked == true)
            {
                btnTimKiem.Visible = true;
                txbTimKiem.Visible = true;
                cboTimKiem.Visible = true;
            }
            else
            {
                LoadingCustomer();
                btnTimKiem.Visible = false;
                txbTimKiem.Visible = false;
                cboTimKiem.Visible = false;
            }
        }
        #endregion
        public void ManageInterface(string state)
        {
            switch (state)
            {
                case "Start":
                    txbCustomerID.Enabled = false;
                    txbCustomerName.Enabled = false;
                    txbCustomerPhone.Enabled = false;
                    txbCustomerAddress.Enabled = false;
                    btnCustomerThem.Enabled = true;
                    btnCustomerSua.Enabled = true;
                    btnCustomerXoa.Enabled = true;
                    btnCustomerHuy.Enabled = false;
                    btnCustomerGhi.Enabled = false;
                    break;
                case "Add":
                    txbCustomerID.Enabled = false;
                    txbCustomerName.Enabled = true;
                    txbCustomerPhone.Enabled = true;
                    txbCustomerAddress.Enabled = true;
                    btnCustomerThem.Enabled = false;
                    btnCustomerSua.Enabled = false;
                    btnCustomerXoa.Enabled = false;
                    btnCustomerHuy.Enabled = true;
                    btnCustomerGhi.Enabled = true;
                    break;
                case "Update":
                    txbCustomerID.Enabled = false;
                    txbCustomerName.Enabled = true;
                    txbCustomerPhone.Enabled = true;
                    txbCustomerAddress.Enabled = true;
                    btnCustomerThem.Enabled = false;
                    btnCustomerSua.Enabled = false;
                    btnCustomerXoa.Enabled = false;
                    btnCustomerHuy.Enabled = true;
                    btnCustomerGhi.Enabled = true;
                    break;
                case "Delete":
                    btnCustomerThem.Enabled = false;
                    btnCustomerSua.Enabled = false;
                    btnCustomerXoa.Enabled = false;
                    btnCustomerHuy.Enabled = true;
                    btnCustomerGhi.Enabled = true;
                    break;


            }
        }
        void tab2Loading1()
        {
            cboOrderKhachHang.Enabled = true;
            cboOrderLapTop.Enabled = false;
            txbSoLuongOrder.Enabled = false;
            btnThemOrder.Enabled = false;
            btnSuaOrder.Enabled = false;
            btnTaoOrder.Enabled = true;
            btnGhiOrder.Enabled = false;
            cboOrderKhachHang.Items.Clear();
            cboOrderLapTop.Items.Clear();
            dgvOrder.Rows.Clear();
            order.Seller = user;
            customers = CustomerBUS.Instance.get();
            foreach (Customer item in customers)
            {
                cboOrderKhachHang.Items.Add(item.Name);
            }
            laptops.Clear();
            laptops = LaptopBUS.Instance.get();
            cboOrderLapTop.Items.Clear();
            foreach (Laptop item in laptops)
            {
                cboOrderLapTop.Items.Add(item.Name);
            }
        }
        void tab2loading2()
        {
            cboOrderKhachHang.Enabled = false;
            cboOrderLapTop.Enabled = false;
            txbSoLuongOrder.Enabled = false;
            btnThemOrder.Enabled = true;
            btnSuaOrder.Enabled = true;
            btnOrderXoa.Enabled = true;
            btnTaoOrder.Enabled = false;
            btnGhiOrder.Enabled = false;
        }
        #region TextChangeEvent
        private void txbID_TextChanged(object sender, EventArgs e)
        {
            if (txbCustomerID.Text.Length > 0)
            {
                customer.ID = Convert.ToInt32(txbCustomerID.Text);
            }
        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {
            customer.Name = txbCustomerName.Text;
        }

        private void txbPhone_TextChanged(object sender, EventArgs e)
        {

            customer.Phone = txbCustomerPhone.Text;
        }

        private void txbAddress_TextChanged(object sender, EventArgs e)
        {
            customer.Address = txbCustomerAddress.Text;
        }
        #endregion

        private void btnThemOrder_Click(object sender, EventArgs e)
        {
            btnSuaOrder.Enabled = false;
            btnOrderXoa.Enabled = false;
            cboOrderLapTop.Enabled = true;
            txbSoLuongOrder.Enabled = true;
            btnGhiOrder.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (cboOrderLapTop.Text != "" && txbSoLuongOrder.Text != "")
            {
                if (btnThemOrder.Enabled)
                {
                    decimal payment = choosenlaptop.Price * choosenlaptop.QuantityBought;
                    dgvOrder.Rows.Add(choosenlaptop.ID, choosenlaptop.Name, choosenlaptop.Price, choosenlaptop.QuantityBought, payment);
                    sum += choosenlaptop.Price * choosenlaptop.QuantityBought;
                    lbTongDonGia.Text = sum.ToString();
                }

                if (btnSuaOrder.Enabled)
                {
                    foreach (DataGridViewRow row in dgvOrder.Rows)
                    {
                        if (Convert.ToString(row.Cells["Col2"].Value) == cboOrderLapTop.Text)
                        {
                            dgvOrder.Rows.Remove(row);
                            dgvOrder.Rows.Add(choosenlaptop.ID, choosenlaptop.Name, choosenlaptop.Price, choosenlaptop.QuantityBought);
                        }
                    }
                }
                tab2loading2();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
        }

        private void txbSoLuongOrder_TextChanged(object sender, EventArgs e)
        {
            if (txbSoLuongOrder.Text.Length > 0)
            {
                choosenlaptop.QuantityBought = Convert.ToInt32(txbSoLuongOrder.Text);
            }
        }

        private void cboOrderLapTop_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Laptop item in laptops)
            {
                if (item.Name == cboOrderLapTop.Text)
                {
                    choosenlaptop = item;
                    break;
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (cboOrderKhachHang.Text != "")
            {
                tab2loading2();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn khách hàng!");
            }
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            sum = 0;
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                Laptop LapTop = new();
                order.Seller = user;
                LapTop.ID = Convert.ToInt32(row.Cells["Col1"].Value);
                LapTop.Name = Convert.ToString(row.Cells["Col2"].Value);
                LapTop.Price = Convert.ToDecimal(row.Cells["Col3"].Value);
                LapTop.QuantityBought = Convert.ToInt32(row.Cells["Col4"].Value);
                order.Laptop.Add(LapTop);
            }
            if (OrderBUS.Instance.insert(order) == true)
            {
                tab2Loading1();
                MessageBox.Show("Ghi thành công!");
            }
            else
            {
                MessageBox.Show("Ghi không thành công!");
            }
        }

        private void cboOrderKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in customers)
            {
                if (item.Name == cboOrderKhachHang.Text)
                {
                    order.Customer = item;
                    break;
                }
            }
        }

        private void btnOrderXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvOrder.Rows)
                {
                    if (Convert.ToString(row.Cells["Col2"].Value) == cboOrderLapTop.Text)
                    {
                        dgvOrder.Rows.Remove(row);
                    }
                    tab2loading2();
                }
            }
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvOrder.Rows[e.RowIndex];
                if (Convert.ToString(row.Cells["Col1"].Value) != "")
                {
                    cboOrderLapTop.Text = Convert.ToString(row.Cells["Col2"].Value);
                    txbSoLuongOrder.Text = Convert.ToString(row.Cells["Col4"].Value);
                }
            }
            catch
            {

            }
        }

        private void btnSuaOrder_Click(object sender, EventArgs e)
        {
            btnSuaOrder.Enabled = true;
            btnThemOrder.Enabled = false;
            btnOrderXoa.Enabled = false;
            cboOrderLapTop.Enabled = true;
            txbSoLuongOrder.Enabled = true;
            btnGhiOrder.Enabled = true;
        }
    }
}