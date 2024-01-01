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
using DAL;
using DTO;

namespace GUI
{
    public partial class WarehouseUI_menu : Form
    {
        private Staff user = new();
        private ImportInvoice ImportInvoice = new ImportInvoice();
        private List<Laptop> laptops = new List<Laptop>();

        public WarehouseUI_menu(Staff user)
        {
            this.user = user;
            InitializeComponent();
        }
        #region LoadingEvent
        private void WarehouseUI_menu_Load(object sender, EventArgs e)
        {
            tab0loading();
        }
        private void btTaoHoaDonNhap_Click(object sender, EventArgs e)
        {
            tab2Loading();
        }
        void tab0loading()
        {
            btGhi.Enabled = false;
            btHuy.Enabled = false;
            btThem.Enabled = true;
            btSua.Enabled = true;
            btXoa.Enabled = true;
            tabControl1.SelectedIndex = 0;
            dataGridView1.Enabled = true;
            dataGridView1.Rows.Clear();
            foreach (Provider item in ProviderBUS.Instance.get())
            {
                dataGridView1.Rows.Add(item.ID, item.Name, item.Address, item.Phone);
            }
            DataGridViewRow row = dataGridView1.Rows[0];

            if (Convert.ToString(row.Cells["Column1"].Value) != "")
            {
                tbID.Text = Convert.ToString(row.Cells["Column1"].Value);
                tbName.Text = Convert.ToString(row.Cells["Column2"].Value);
                tbAddress.Text = Convert.ToString(row.Cells["Column3"].Value);
                tbPhone.Text = Convert.ToString(row.Cells["Column4"].Value);
            }
        }
        void tab2Loading()
        {
            tabControl1.SelectedIndex = 2;
            btnGhi2.Enabled = false;
            btnHoanThanh.Enabled = false;
            btnHuy2.Enabled = false;
            btnHuyHoaDon.Enabled = false;
            btnSua2.Enabled = false;
            btnThem2.Enabled = false;
            tbSoluong2.Enabled = false;
            cbLaptop2.Enabled = false;
            btnXoa2.Enabled = false;
            btnTaoHoaDon.Enabled = true;
            cbNhaCungCap.Enabled = true;

            cbNhaCungCap.Items.Clear();
            foreach (Provider item in ProviderDAL.Instance.get())
            {
                cbNhaCungCap.Items.Add(item.Name);
            }
            laptops.Clear();
            laptops = LaptopDAL.Instance.get();
            cbLaptop2.Items.Clear();
            foreach (Laptop item in laptops)
            {
                cbLaptop2.Items.Add(item.Name);
            }
        }
        #endregion
        #region ClickEvent
        private void btNhaCungCap_Click(object sender, EventArgs e)
        {
            tab0loading();
        }
        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            if (cbNhaCungCap.Text != "")
            {
                btnXoa2.Enabled = true;
                btnHoanThanh.Enabled = true;
                btnHuyHoaDon.Enabled = true;
                btnSua2.Enabled = true;
                btnThem2.Enabled = true;
                btnTaoHoaDon.Enabled = false;
                cbNhaCungCap.Enabled = false;
                cbLaptop2.Enabled = true;
                tbSoluong2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp!");
            }
        }
        #endregion
        #region textChangeEvent
        #endregion

        private void btThem_Click(object sender, EventArgs e)
        {
            btGhi.Enabled = true;
            btHuy.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            btGhi.Enabled = true;
            btHuy.Enabled = true;
            btThem.Enabled = false;
            btXoa.Enabled = false;

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            btSua.Enabled = false;
            btThem.Enabled = false;
            if (tbID.Text != "")
            {
            }

        }
        private void btSanPham_Click(object sender, EventArgs e)
        {
            //   tab1loading();
        }

        private void btnThem2_Click(object sender, EventArgs e)
        {
            if (cbLaptop2.Text != "" && tbSoluong2.Text != "")
            {

                dataGridView2.Rows.Add(tbLaptopID2, tbLaptop_Name, tbSoluong2);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
        }

        private void cbLaptop2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}