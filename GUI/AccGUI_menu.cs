using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GUI
{
    public partial class AccGUI_menu : Form
    {
        private Staff user = new();
        private Order order = new();
        private int index = 0;
        private ImportInvoice importInvoice = new();
        public AccGUI_menu(Staff user)
        {
            this.user = user;
            InitializeComponent();
        }
        #region tab0
        #region LoadingEvent
        private void AccGUI_menu_Load(object sender, EventArgs e)
        {
            loadTab0();
        }
        public void loadTab0()
        {
            index = 0;
            order = new Order();
            order.Accountant = user;
            tabControl1.SelectedIndex = 0;
            tbID0.Enabled = false;
            tbCus0.Enabled = false;
            tbSeller0.Enabled = false;
            tbOrderDate0.Enabled = false;
            cboPayment0.Enabled = true;
            dataGridView2.Enabled = true;
            dataGridView2.Rows.Clear();
            foreach (Order item in OrderBUS.Instance.get())
            {
                if (item.StatusInt == 1)
                {
                    item.Customer = CustomerBUS.Instance.getCustomer(item.Customer);
                    if (tbTimKiem1.Text == "" || Search.Instance.ContainsString(item.Customer.Name, tbTimKiem1.Text))
                    {

                        item.Seller = StaffBUS.Instance.getSeller(item.Seller);
                        dataGridView2.Rows.Add(item.ID, item.Customer.Name, item.Seller.Name, item.Order_date);
                    }
                }

            }
            DataGridViewRow row = dataGridView2.Rows[0];
            if (Convert.ToString(row.Cells["OrderID"].Value) != "")
            {
                tbID0.Text = Convert.ToString(row.Cells["OrderID"].Value);
                tbCus0.Text = Convert.ToString(row.Cells["CusName"].Value);
                tbSeller0.Text = Convert.ToString(row.Cells["SellerName"].Value);
                tbOrderDate0.Text = Convert.ToString(row.Cells["OrderTime"].Value);
                order = OrderBUS.Instance.getOrderByID(Convert.ToInt32(row.Cells["OrderID"].Value));
                lbSUM.Text = order.getSUM().ToString();
            }

        }

        #endregion
        #region ClickEvent
        private void btnExport0_Click(object sender, EventArgs e)
        {
            ExportData.Instance.ToExcel(dataGridView2, "Thống kê hóa đơn khách hàng");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 1)
            {
                tab2loading();
            }
            else
            {
                MessageBox.Show("Không có hóa đơn nào trong danh sách");
            }
        }
        private void btnCho_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            loadTab0();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Xác nhận hủy đơn", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                order.StatusInt = 0;
                order.Accountant.ID = user.ID;
                if (OrderBUS.Instance.update(order))
                {
                    loadTab0();
                    MessageBox.Show("Đã hủy!", "Thông báo");
                }
            }
            else
            {

            }
        }

        private void btXong_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Xác nhận hoàn thành", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                order.StatusInt = 2;
                order.Accountant.ID = user.ID;
                if (OrderBUS.Instance.update(order))
                {
                    loadTab0();
                    MessageBox.Show("Thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không thành công!", "Thông báo");
                }
            }
            else
            {

            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView2.Rows[e.RowIndex];
                if (Convert.ToString(row.Cells["OrderID"].Value) != "")
                {
                    order.ID = Convert.ToInt32(row.Cells["OrderID"].Value);
                    tbID0.Text = Convert.ToString(row.Cells["OrderID"].Value);
                    tbCus0.Text = Convert.ToString(row.Cells["CusName"].Value);
                    tbSeller0.Text = Convert.ToString(row.Cells["SellerName"].Value);
                    tbOrderDate0.Text = Convert.ToString(row.Cells["OrderTime"].Value);
                    order = OrderBUS.Instance.getOrderByID(Convert.ToInt32(row.Cells["OrderID"].Value));
                    lbSUM.Text = order.getSUM().ToString();
                }
            }
            catch { }
        }

        #endregion
        #region textChangeEvent

        private void cboPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            order.PaymentString = cboPayment0.Text;
        }
        private void tbID0_TextChanged(object sender, EventArgs e)
        {
            try
            {
                order.ID = Convert.ToInt32(tbID0.Text);
            }
            catch { }
        }


        #endregion
        #endregion
        #region tab1
        #region loadingEvent
        public void loadTab1()
        {
            index = 1;
            tabControl1.SelectedIndex = 1;
            tbID1.Enabled = false;
            tbSeller1.Enabled = false;
            tbCustomer.Enabled = false;

            tbOrderDate.Enabled = false;
            dataGridView3.Enabled = true;
            dataGridView3.Rows.Clear();
            foreach (Order item in OrderBUS.Instance.get())
            {
                if (item.Accountant.ID == user.ID && item.StatusString == cbTrangThai1.Text)
                {
                    item.Customer = CustomerBUS.Instance.getCustomer(item.Customer);
                    if (tbTimKiem2.Text == "" || Search.Instance.ContainsString(item.Customer.Name, tbTimKiem2.Text))
                    {

                        order = OrderBUS.Instance.getOrderByID(item.ID);
                        item.Seller = StaffBUS.Instance.getSeller(item.Seller);
                        item.Accountant = StaffBUS.Instance.getAccountant(item.Accountant);

                        dataGridView3.Rows.Add(item.ID, item.Customer.Name, item.Seller.Name, item.Order_date, item.getSUM());
                    }
                }
            }
            DataGridViewRow row = dataGridView3.Rows[0];
            if (Convert.ToString(row.Cells["ID"].Value) != "")
            {
                tbID1.Text = Convert.ToString(row.Cells["ID"].Value);
                tbCustomer.Text = Convert.ToString(row.Cells["CusName1"].Value);
                tbSeller1.Text = Convert.ToString(row.Cells["SellerName1"].Value);
                tbOrderDate.Text = Convert.ToString(row.Cells["OrderDate"].Value);
                order = OrderBUS.Instance.getOrderByID(Convert.ToInt32(row.Cells["ID"].Value));
            }
        }
        #endregion
        #region clickEvent
        private void btnChiTiet1_Click(object sender, EventArgs e)
        {
            if (dataGridView3.Rows.Count > 1)
            {
                tab2loading();
            }
            else
            {
                MessageBox.Show("Không có hóa đơn nào trong danh sách");
            }
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            cbTrangThai1.SelectedIndex = 0;
            loadTab1();
        }
        private void btnXuatExcel1_Click(object sender, EventArgs e)
        {
            ExportData.Instance.ToExcel(dataGridView3, "Thống kê hóa đơn khách hàng");
        }
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView3.Rows[e.RowIndex];
                if (Convert.ToString(row.Cells["ID"].Value) != "")
                {
                    tbID1.Text = Convert.ToString(row.Cells["ID"].Value);
                    tbCustomer.Text = Convert.ToString(row.Cells["CusName1"].Value);
                    tbOrderDate.Text = Convert.ToString(row.Cells["OrderDate"].Value);
                    order = OrderBUS.Instance.getOrderByID(Convert.ToInt32(row.Cells["ID"].Value));
                }
            }
            catch { }
        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion
        #region textChangeEvent
        private void cbTrangThai1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTab1();
        }
        #endregion
        #endregion
        #region tab2
        #region loadingEvent
        private void tab2loading()
        {
            tabControl1.SelectedIndex = 2;
            lbkiKH2.Text = order.Customer.Name;
            lbNgay2.Text = order.Order_date.ToString();
            lbSeller2.Text = order.Seller.Name;
            lbTrangThai2.Text = order.StatusString;
            lbTenKH2.Text = order.Customer.Name;
            if (order.StatusInt == 2)
            {
                btnExportW2.Enabled = true;
                lbThuNgan.Text = user.Name;
            }
            else
            {
                btnExportW2.Enabled = false;
                lbThuNgan.Text = "";
            }
            dgvOrder.Rows.Clear();
            foreach (Laptop item in order.Laptop)
            {

                dgvOrder.Rows.Add(item.ID, item.Name, item.QuantityBought, item.Price, (decimal)item.Price * (decimal)item.QuantityBought);
            }
        }
        #region clickEvent
        private void btnBack2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = index;
        }

        #endregion
        #endregion
        #endregion
        #region tab3
        #region loadingEvent    
        private void tab3loading()
        {
            tabControl1.SelectedIndex = 3;
            index = 3;
            btnChiTiet3.Enabled = true;
            tbMaHoaDon3.Enabled = false;
            tbNgayTao3.Enabled = false;
            tbNguoiTao3.Enabled = false;
            tbNhaCungCap3.Enabled = false;
            dataGridView1.Enabled = true;
            dataGridView1.Rows.Clear();
            foreach (ImportInvoice item in ImportInvoiceBUS.Instance.get())
            {
                if (item.StatusInt == 1)
                {
                    item.Provider = ProviderBUS.Instance.getProvider(item.Provider.ID);
                    if (tbTimKiem3.Text == "" || Search.Instance.ContainsString(item.Provider.Name, tbTimKiem3.Text))
                    {
                        importInvoice = ImportInvoiceBUS.Instance.getInvoiceByID(item.ID);

                        item.WarehouseKeeper = StaffBUS.Instance.getSeller(item.WarehouseKeeper);
                        dataGridView1.Rows.Add(item.ID, item.Provider.Name, item.WarehouseKeeper.Name, item.ImportDate, importInvoice.getSUM());
                    }
                }

            }
            DataGridViewRow row = dataGridView1.Rows[0];
            if (Convert.ToString(row.Cells["Column1"].Value) != "")
            {
                tbMaHoaDon3.Text = Convert.ToString(row.Cells["Column1"].Value);
                tbNhaCungCap3.Text = Convert.ToString(row.Cells["Column2"].Value);
                tbNguoiTao3.Text = Convert.ToString(row.Cells["Column3"].Value);
                tbNgayTao3.Text = Convert.ToString(row.Cells["Column4"].Value);
                importInvoice = ImportInvoiceBUS.Instance.getInvoiceByID(Convert.ToInt32(row.Cells["Column1"].Value));
                lbSUM3.Text = importInvoice.getSUM().ToString();
            }
        }
        #endregion
        #region clickEvent
        private void btnHoaDonNhapDangCho_Click(object sender, EventArgs e)
        {
            tab3loading();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[e.RowIndex];
                if (Convert.ToString(row.Cells["Column1"].Value) != "")
                {
                    tbMaHoaDon3.Text = Convert.ToString(row.Cells["Column1"].Value);
                    tbNhaCungCap3.Text = Convert.ToString(row.Cells["Column2"].Value);
                    tbNguoiTao3.Text = Convert.ToString(row.Cells["Column3"].Value);
                    tbNgayTao3.Text = Convert.ToString(row.Cells["Column4"].Value);
                    importInvoice = ImportInvoiceBUS.Instance.getInvoiceByID(Convert.ToInt32(row.Cells["Column1"].Value));
                    lbSUM3.Text = importInvoice.getSUM().ToString();
                }
            }
            catch { }

        }
        private void btnHoanThanh3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận hoàn thành", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                importInvoice.StatusInt = 2;
                importInvoice.Accountant.ID = user.ID;
                if (ImportInvoiceBUS.Instance.update(importInvoice))
                {

                    tab3loading();
                    MessageBox.Show("Thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không thành công!", "Thông báo");
                }
            }
            else
            {

            }
        }
        private void btnChiTiet3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                tab5loading();
            }
            else
            {
                MessageBox.Show("Không có hóa đơn nào trong danh sách");
            }
        }
        private void btnExport3_Click(object sender, EventArgs e)
        {
            ExportData.Instance.ToExcel(dataGridView1, "Thống kê hóa đơn nhập hàng");
        }
        #endregion
        #region textChangeEvent
        #endregion
        #endregion
        #region tab4
        #region loadingEvent
        public void tab4loading()
        {
            index = 4;
            tabControl1.SelectedIndex = 4;
            tbNguoiTao4.Enabled = false;
            tbNgayTao4.Enabled = false;
            tbMaHoaDon4.Enabled = false;
            tbNhaCungCap4.Enabled = false;

            dataGridView4.Rows.Clear();
            foreach (ImportInvoice item in ImportInvoiceBUS.Instance.get())
            {
                if (item.StatusInt == 2)
                {
                    importInvoice = ImportInvoiceBUS.Instance.getInvoiceByID(item.ID);
                    item.Provider = ProviderBUS.Instance.getProvider(item.Provider.ID);
                    if (tbTimKiem4.Text == "" || Search.Instance.ContainsString(item.Provider.Name, tbTimKiem4.Text))
                    {


                        item.WarehouseKeeper = StaffBUS.Instance.getSeller(item.WarehouseKeeper);
                        dataGridView4.Rows.Add(item.ID, item.Provider.Name, item.WarehouseKeeper.Name, item.ImportDate, importInvoice.getSUM());
                    }
                }
            }
            DataGridViewRow row = dataGridView4.Rows[0];
            if (Convert.ToString(row.Cells["dataGridViewTextBoxColumn1"].Value) != "")
            {
                tbMaHoaDon4.Text = Convert.ToString(row.Cells["dataGridViewTextBoxColumn1"].Value);
                tbNhaCungCap4.Text = Convert.ToString(row.Cells["dataGridViewTextBoxColumn2"].Value);
                tbNguoiTao4.Text = Convert.ToString(row.Cells["dataGridViewTextBoxColumn3"].Value);
                tbNgayTao4.Text = Convert.ToString(row.Cells["dataGridViewTextBoxColumn4"].Value);
                importInvoice = ImportInvoiceBUS.Instance.getInvoiceByID(Convert.ToInt32(row.Cells["dataGridViewTextBoxColumn1"].Value));
            }
        }
        #endregion
        #region clickEvent
        private void btnChiTiet4_Click(object sender, EventArgs e)
        {
            if (dataGridView4.Rows.Count > 1)
            {
                tab5loading();
            }
            else
            {
                MessageBox.Show("Không có hóa đơn nào trong danh sách");
            }

        }

        private void btnExportExcel4_Click(object sender, EventArgs e)
        {
            ExportData.Instance.ToExcel(dataGridView4, "Danh sách hóa đơn nhập hàng");
        }
        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[e.RowIndex];
                if (Convert.ToString(row.Cells["dataGridViewTextBoxColumn1"].Value) != "")
                {
                    tbMaHoaDon4.Text = Convert.ToString(row.Cells["dataGridViewTextBoxColumn1"].Value);
                    tbNhaCungCap4.Text = Convert.ToString(row.Cells["dataGridViewTextBoxColumn2"].Value);
                    tbNguoiTao4.Text = Convert.ToString(row.Cells["dataGridViewTextBoxColumn3"].Value);
                    tbNgayTao4.Text = Convert.ToString(row.Cells["dataGridViewTextBoxColumn4"].Value);
                    importInvoice = ImportInvoiceBUS.Instance.getInvoiceByID(Convert.ToInt32(row.Cells["dataGridViewTextBoxColumn1"].Value));
                }
            }
            catch { }
        }
        private void btnHoaDonNhapHang_Click(object sender, EventArgs e)
        {
            tab4loading();
        }
        #endregion
        #region textChangeEvent
        #endregion
        #endregion
        #region tab5
        #region loadingEvent

        private void tab5loading()
        {

            tabControl1.SelectedIndex = 5;
            lbNCC52.Text = importInvoice.Provider.Name;
            lbNCC5.Text = importInvoice.Provider.Name;
            lb5.Text = importInvoice.ImportDate.ToString();
            lbNguoiTaoHoaDon5.Text = importInvoice.WarehouseKeeper.Name;
            lbThuNgan5.Text = importInvoice.Accountant.Name;
            lbTrangThai5.Text = importInvoice.StatusString;
            dataGridView5.Rows.Clear();
            foreach (Laptop item in importInvoice.Laptops)
            {

                dataGridView5.Rows.Add(item.ID, item.Name, item.QuantityImport, item.ImportPrice, item.QuantityImport * item.ImportPrice);
            }
        }
        #endregion
        #region clickEvent
        private void btnBack5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = index;
        }
        #endregion
        #region textChangeEvent
        #endregion
        #endregion


        private void tbTimKiem1_TextChanged(object sender, EventArgs e)
        {
            loadTab0();
        }

        private void tbTimKiem2_TextChanged(object sender, EventArgs e)
        {
            loadTab1();
        }

        private void tbTimKiem3_TextChanged(object sender, EventArgs e)
        {
            tab3loading();
        }

        private void tbTimKiem4_TextChanged(object sender, EventArgs e)
        {
            tab4loading();
        }
    }
}