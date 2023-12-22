using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using Microsoft.VisualBasic.ApplicationServices;

namespace GUI
{
    public partial class SellGUI_menu : Form
    {
        private Customer customer = new Customer();
        private Staff user = new();
        string state = null;

        public SellGUI_menu(Staff user)
        {
            this.user = user;
            InitializeComponent();
        }
        private void Loading()
        {

            foreach (Customer item in CustomerBUS.Instance.get())
            {

                dgvKhachHang.Rows.Add(item.ID, item.Name, item.Phone, item.Address);
            }
            DataGridViewRow row = dgvKhachHang.Rows[0];
            /*if (Convert.ToString(row.Cells["colID"].Value) != "")
            {
                txbID.Text = Convert.ToString(row.Cells["colID"].Value);
                txbName.Text = Convert.ToString(row.Cells["colName"].Value);
                txbPhone.Text = Convert.ToString(row.Cells["colPhone"].Value);
                txbAddress.Text = Convert.ToString(row.Cells["colAddress"].Value);
            }*/
        }
        private void SellGUI_menu_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            Loading();
            state = "Start";
            ManageInterface(state);
        }

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
                txbID.Text = Convert.ToString(row.Cells["colID"].Value);
                txbName.Text = Convert.ToString(row.Cells["colName"].Value);
                txbPhone.Text = Convert.ToString(row.Cells["colPhone"].Value);
                txbAddress.Text = Convert.ToString(row.Cells["colAddress"].Value);
            }

        }
        public void ManageInterface(string state)
        {
            switch (state)
            {
                case "Start":
                    txbID.Enabled = false;
                    txbName.Enabled = false;
                    txbPhone.Enabled = false;
                    txbAddress.Enabled = false;
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnHuy.Enabled = false;
                    btnGhi.Enabled = false;
                    break;
                case "Add":
                    txbID.Enabled = false;
                    txbName.Enabled = true;
                    txbPhone.Enabled = true;
                    txbAddress.Enabled = true;
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnHuy.Enabled = true;
                    btnGhi.Enabled = true;
                    break;
                case "Update":
                    txbID.Enabled = false;
                    txbName.Enabled = true;
                    txbPhone.Enabled = true;
                    txbAddress.Enabled = true;
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnHuy.Enabled = true;
                    btnGhi.Enabled = true;
                    break;
                case "Delete":
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnHuy.Enabled = true;
                    btnGhi.Enabled = true;
                    break;
            }
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            state = "Add";
            ManageInterface(state);
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (state == "Add")
            {
                CustomerBUS.Instance.insert(customer);
                this.dgvKhachHang.DataSource = null;
                this.dgvKhachHang.Rows.Clear();
                Loading();
                MessageBox.Show("Thêm thông tin thành công", "Thông báo");
                ManageInterface("Start");
            }
            if (state == "Update")
            {
                CustomerBUS.Instance.update(customer);
                this.dgvKhachHang.DataSource = null;
                this.dgvKhachHang.Rows.Clear();
                Loading();
                MessageBox.Show("Sửa thông tin thành công", "Thông báo");
                ManageInterface("Start");
            }
            if (state == "Delete")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CustomerBUS.Instance.delete(customer);
                    this.dgvKhachHang.DataSource = null;
                    this.dgvKhachHang.Rows.Clear();
                    Loading();
                    ManageInterface("Start");
                }
            }
        }

        private void txbID_TextChanged(object sender, EventArgs e)
        {
            if (txbID.Text.Length > 0)
            {
                customer.ID = Convert.ToInt32(txbID.Text);
            }
        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {
            customer.Name = txbName.Text;
        }

        private void txbPhone_TextChanged(object sender, EventArgs e)
        {
            customer.Phone = txbPhone.Text;
        }

        private void txbAddress_TextChanged(object sender, EventArgs e)
        {
            customer.Address = txbAddress.Text;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            state = "Update";
            ManageInterface(state);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            state = "Delete";
            ManageInterface(state);
        }
    }
}
