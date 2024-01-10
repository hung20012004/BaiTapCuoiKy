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
        public WarehouseUI_menu(Staff user)
        {
            this.user = user;
            InitializeComponent();
        }
        private void WarehouseUI_menu_Load(object sender, EventArgs e)
        {
            tab0loading();

        }
        #region tab0
        private Provider provider = new();

        #region loadingEvent
        private void btNhaCungCap_Click(object sender, EventArgs e)
        {
            tab0loading();
        }
        void tab0loading()
        {
            tbTimKiem0.Enabled = true;
            tbID.Enabled = false;
            tbName.Enabled = false;
            tbPhone.Enabled = false;
            tbAddress.Enabled = false;
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
                if (tbTimKiem0.Text == "" || Search.Instance.ContainsString(item.Name, tbTimKiem0.Text))
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
        #endregion
        #region clickEvent
        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            ExportData.Instance.ToExcel(dataGridView1, "Thống kê số lượng nhà cung cấp");
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            if (btSua.Enabled == true)
            {
                tbTimKiem0.Enabled = false;
                btGhi.Enabled = true;
                btHuy.Enabled = true;
                btSua.Enabled = false;
                tbID.Text = "";
                btXoa.Enabled = false;
                tbAddress.Enabled = true;
                tbPhone.Enabled = true;
                tbName.Enabled = true;
                tbAddress.Text = "";
                tbName.Text = "";
                tbPhone.Text = "";
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (btThem.Enabled == true)
            {
                tbTimKiem0.Enabled = false;
                btGhi.Enabled = true;
                btHuy.Enabled = true;
                btThem.Enabled = false;
                btXoa.Enabled = false;
                tbAddress.Enabled = true;
                tbPhone.Enabled = true;
                tbName.Enabled = true;
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (ProviderBUS.Instance.delete(provider))
                {
                    tab0loading();
                    MessageBox.Show("Đã xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Xóa không thành công!");
            }

        }
        private void btHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận hủy", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tab0loading();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[e.RowIndex];
                if (Convert.ToString(row.Cells["Column1"].Value) != "")
                {
                    tbID.Text = Convert.ToString(row.Cells["Column1"].Value);
                    tbName.Text = Convert.ToString(row.Cells["Column2"].Value);
                    tbPhone.Text = Convert.ToString(row.Cells["Column4"].Value);
                    tbAddress.Text = Convert.ToString(row.Cells["Column3"].Value);
                }
            }
            catch
            {

            }
        }
        private void btGhi_Click(object sender, EventArgs e)
        {
            if (tbAddress.Text != "" && tbPhone.Text != "" && tbName.Text != "")
            {
                if (MessageBox.Show("Xác nhận ghi", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (btThem.Enabled == true)
                    {
                        if (tbName.Text != "" && tbPhone.Text != "" && tbAddress.Text != "")
                        {

                            if (ProviderBUS.Instance.insert(provider))
                            {
                                tab0loading();
                                MessageBox.Show("Đã ghi thành công!");
                            }
                            else
                            {
                                MessageBox.Show("Ghi không thành công!");
                            }
                        }
                    }
                    else
                    {
                        if (ProviderBUS.Instance.update(provider))
                        {
                            tab0loading();
                            MessageBox.Show("Đã ghi thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Ghi không thành công!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ các trường");
            }
        }
        #endregion
        #region textChangeEvent
        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tbID_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbID.Text, "  ^ [0-9]"))
            {
                tbID.Text = null;
            }
            if (!string.IsNullOrEmpty(tbID.Text))
            {
                provider.ID = Convert.ToInt32(tbID.Text);
            }
        }
        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            provider.Address = tbAddress.Text;
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbID.Text, "  ^ [0-9]"))
            {
                tbPhone.Text = null;
            }
            provider.Phone = tbPhone.Text;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            provider.Name = tbName.Text;
        }
        private void tbTimKiem0_TextChanged(object sender, EventArgs e)
        {
            tab0loading();
        }
        #endregion
        #endregion
        #region tab1

        public Laptop newLaptop = new Laptop();
        #region loadingEvent
        private void tab1loading()
        {
            cbSearchC.Enabled = true;
            cbSearchM.Enabled = true;
            tbTimKiem1.Enabled = true;

            newLaptop = new Laptop();
            tabControl1.SelectedIndex = 1;
            tbLaptop_ID.Enabled = false;
            tbLaptop_Name.Enabled = false;
            cbbCategory_ID.Enabled = false;
            cbbManufactory_ID.Enabled = false;
            tbQuantity.Enabled = false;
            tbPrice.Enabled = false;

            tbLoai4.Enabled = false;
            tbGia4.Enabled = false;
            tbNhaSanXuat4.Enabled = false;
            tbTen4.Enabled = false;

            tbCPU.Enabled = false;
            tbRAM.Enabled = false;
            tbHD.Enabled = false;
            tbVGA.Enabled = false;
            tbSize.Enabled = false;
            tbWeight.Enabled = false;
            tbMaterials.Enabled = false;
            tbKeyboard.Enabled = false;
            tbPorts.Enabled = false;
            tbAudio.Enabled = false;
            tbBattery.Enabled = false;
            tbDisplay.Enabled = false;
            tbKetNoi.Enabled = false;
            tbWP.Enabled = false;
            tbOS.Enabled = false;
            tbSecurity.Enabled = false;

            btGhi.Enabled = false;
            btHuy.Enabled = false;
            btThem1.Enabled = true;
            btXoa1.Enabled = true;
            btSua1.Enabled = true;
            dataGridView3.Enabled = true;
            cbbCategory_ID.Items.Clear();
            cbbManufactory_ID.Items.Clear();
            dataGridView3.Rows.Clear();
            foreach (var item in LaptopBUS.Instance.getManufactory())
            {
                cbbManufactory_ID.Items.Add(item.Name);
                cbSearchM.Items.Add(item.Name);
            }
            foreach (var item in LaptopBUS.Instance.getCategory())
            {
                cbbCategory_ID.Items.Add(item.Name);
                cbSearchC.Items.Add(item.Name);
            }
            foreach (var item in LaptopBUS.Instance.get())
            {
                if (cbSearchC.Text == item.Category.Name || cbSearchC.Text == "")
                {
                    if (cbSearchM.Text == "" || cbSearchM.Text == item.Manufactory.Name)
                    {
                        if (tbTimKiem1.Text == "" || Search.Instance.ContainsString(item.Name, tbTimKiem1.Text))
                        {
                            dataGridView3.Rows.Add(item.ID, item.Name, item.Category.Name, item.Manufactory.Name, item.Price, item.QuantityInStock);
                        }
                    }
                }

            }
            DataGridViewRow row = dataGridView3.Rows[0];
            if (Convert.ToString(row.Cells["Column5"].Value) != "")
            {
                newLaptop = LaptopBUS.Instance.getLaptopByID(Convert.ToInt32(row.Cells["Column5"].Value));

                tbLaptop_Name.Text = newLaptop.Name;
                cbbCategory_ID.Text = newLaptop.Category.Name;
                cbbManufactory_ID.Text = newLaptop.Manufactory.Name;
                tbQuantity.Text = newLaptop.QuantityInStock.ToString();
                tbPrice.Text = newLaptop.Price.ToString();

                tbCPU.Text = newLaptop.CPU;
                tbRAM.Text = newLaptop.Ram;
                tbHD.Text = newLaptop.HardDriver;
                tbVGA.Text = newLaptop.VGA;
                tbSize.Text = newLaptop.Size;
                tbWeight.Text = newLaptop.Weight.ToString();
                tbMaterials.Text = newLaptop.Material;
                tbKeyboard.Text = newLaptop.Keyboard;
                tbPorts.Text = newLaptop.Port;
                tbAudio.Text = newLaptop.Audio;
                tbBattery.Text = newLaptop.Battery;
                tbDisplay.Text = newLaptop.Display;
                tbKetNoi.Text = newLaptop.Connection;
                tbWP.Text = newLaptop.WarrantyPeriod;
                tbOS.Text = newLaptop.OS;
                tbSecurity.Text = newLaptop.Security;

                tbLoai4.Text = newLaptop.Category.Name;
                tbGia4.Text = newLaptop.Price.ToString();
                tbNhaSanXuat4.Text = newLaptop.Manufactory.Name;
                tbTen4.Text = newLaptop.Name;
            }
        }
        #endregion
        #region clickEvent
        private void btGhi1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận ghi", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (btThem1.Enabled == true)
                {
                    if (tbLaptop_Name.Text != "" && cbbCategory_ID.Text != "" && cbbManufactory_ID.Text != "")
                    {

                        if (LaptopBUS.Instance.insert(newLaptop))
                        {
                            tab0loading();
                            MessageBox.Show("Đã ghi thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Ghi không thành công!");
                        }
                    }
                }
                else
                {
                    if (LaptopBUS.Instance.update(newLaptop))
                    {
                        tab1loading();
                        MessageBox.Show("Đã ghi thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Ghi không thành công!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Ghi không thành công!");
            }
        }
        private void btHuy1_Click(object sender, EventArgs e)
        {
            tab1loading();
        }
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView3.Rows[e.RowIndex];
                if (Convert.ToString(row.Cells["Column5"].Value) != "")
                {
                    newLaptop = LaptopBUS.Instance.getLaptopByID(Convert.ToInt32(row.Cells["Column5"].Value));

                    tbLaptop_Name.Text = newLaptop.Name;
                    cbbCategory_ID.Text = newLaptop.Category.Name;
                    cbbManufactory_ID.Text = newLaptop.Manufactory.Name;
                    tbQuantity.Text = newLaptop.QuantityInStock.ToString();
                    tbPrice.Text = newLaptop.Price.ToString();

                    tbCPU.Text = newLaptop.CPU;
                    tbRAM.Text = newLaptop.Ram;
                    tbHD.Text = newLaptop.HardDriver;
                    tbVGA.Text = newLaptop.VGA;
                    tbSize.Text = newLaptop.Size;
                    tbWeight.Text = newLaptop.Weight.ToString();
                    tbMaterials.Text = newLaptop.Material;
                    tbKeyboard.Text = newLaptop.Keyboard;
                    tbPorts.Text = newLaptop.Port;
                    tbAudio.Text = newLaptop.Audio;
                    tbBattery.Text = newLaptop.Battery;
                    tbDisplay.Text = newLaptop.Display;
                    tbKetNoi.Text = newLaptop.Connection;
                    tbWP.Text = newLaptop.WarrantyPeriod;
                    tbOS.Text = newLaptop.OS;
                    tbSecurity.Text = newLaptop.Security;
                    tbLoai4.Text = newLaptop.Category.Name;
                    tbGia4.Text = newLaptop.Price.ToString();
                    tbNhaSanXuat4.Text = newLaptop.Manufactory.Name;
                    tbTen4.Text = newLaptop.Name;
                }


            }
            catch
            {

            }
        }
        private void btSua1_Click(object sender, EventArgs e)
        {
            if (btThem1.Enabled)
            {
                cbSearchC.Enabled = false;
                cbSearchM.Enabled = false;
                tbTimKiem1.Enabled = false;
                tbLaptop_Name.Enabled = true;
                cbbCategory_ID.Enabled = true;
                cbbManufactory_ID.Enabled = true;
                tbQuantity.Enabled = true;
                tbPrice.Enabled = true;
                dataGridView1.Enabled = false;

                tbCPU.Enabled = true;
                tbRAM.Enabled = true;
                tbHD.Enabled = true;
                tbVGA.Enabled = true;
                tbSize.Enabled = true;
                tbWeight.Enabled = true;
                tbMaterials.Enabled = true;
                tbKeyboard.Enabled = true;
                tbPorts.Enabled = true;
                tbAudio.Enabled = true;
                tbBattery.Enabled = true;
                tbDisplay.Enabled = true;
                tbKetNoi.Enabled = true;
                tbWP.Enabled = true;
                tbOS.Enabled = true;
                tbSecurity.Enabled = true;

                btGhi.Enabled = true;
                btHuy.Enabled = true;
                btThem1.Enabled = false;
                btXoa1.Enabled = false;
                btSua1.Enabled = true;
                dataGridView3.Enabled = true;
            }
        }

        private void btXoa1_Click(object sender, EventArgs e)
        {

        }
        private void btThem1_Click(object sender, EventArgs e)
        {
            if (btSua1.Enabled)
            {
                cbSearchC.Enabled = false;
                cbSearchM.Enabled = false;
                tbTimKiem1.Enabled = false;
                tbLaptop_Name.Enabled = true;
                cbbCategory_ID.Enabled = true;
                cbbManufactory_ID.Enabled = true;
                tbQuantity.Enabled = true;
                tbPrice.Enabled = true;
                dataGridView1.Enabled = false;

                tbCPU.Enabled = true;
                tbRAM.Enabled = true;
                tbHD.Enabled = true;
                tbVGA.Enabled = true;
                tbSize.Enabled = true;
                tbWeight.Enabled = true;
                tbMaterials.Enabled = true;
                tbKeyboard.Enabled = true;
                tbPorts.Enabled = true;
                tbAudio.Enabled = true;
                tbBattery.Enabled = true;
                tbDisplay.Enabled = true;
                tbKetNoi.Enabled = true;
                tbWP.Enabled = true;
                tbOS.Enabled = true;
                tbSecurity.Enabled = true;

                btGhi.Enabled = true;
                btHuy.Enabled = true;
                btThem1.Enabled = true;
                btXoa1.Enabled = false;
                btSua1.Enabled = false;
                dataGridView3.Enabled = true;
            }
        }

        private void btSanPham_Click(object sender, EventArgs e)
        {
            tab1loading();
        }
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }
        private void btnQuayLai4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
        private void btnExport1_Click(object sender, EventArgs e)
        {
            ExportData.Instance.ToExcel(dataGridView3, "Danh sách laptop");
        }
        #endregion
        #region textChangeEvent
        private void tbLaptop_ID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                newLaptop.ID = Convert.ToInt32(tbLaptop_ID.Text);
            }
            catch (Exception ex)
            {

            }
        }

        private void tbLaptop_Name_TextChanged(object sender, EventArgs e)
        {
            newLaptop.Name = tbLaptop_Name.Text;
        }

        private void cbbCategory_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in LaptopBUS.Instance.getCategory())
            {
                if (cbbCategory_ID.Text == item.Name)
                {
                    newLaptop.Category = item;
                }

            }
        }

        private void cbbManufactory_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in LaptopBUS.Instance.getManufactory())
            {
                if (cbbManufactory_ID.Text == item.Name)
                {
                    newLaptop.Manufactory = item;
                }

            }
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                newLaptop.Price = Convert.ToDecimal(tbPrice.Text);
            }
            catch (Exception ex)
            {

            }
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                newLaptop.QuantityInStock = Convert.ToInt32(tbQuantity.Text);
            }
            catch (Exception ex)
            {

            }
        }

        private void tbTen4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbGia4_TextChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        private void tbLoai4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNhaSanXuat4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCPU_TextChanged(object sender, EventArgs e)
        {
            newLaptop.CPU = tbCPU.Text;
        }

        private void tbRAM_TextChanged(object sender, EventArgs e)
        {
            newLaptop.Ram = tbRAM.Text;
        }

        private void tbHD_TextChanged(object sender, EventArgs e)
        {
            newLaptop.HardDriver = tbHD.Text;
        }

        private void tbVGA_TextChanged(object sender, EventArgs e)
        {
            newLaptop.VGA = tbVGA.Text;
        }

        private void tbSize_TextChanged(object sender, EventArgs e)
        {
            newLaptop.Size = tbSize.Text;
        }

        private void tbWeight_TextChanged(object sender, EventArgs e)
        {
            newLaptop.Weight = Convert.ToDouble(tbWeight.Text);
        }

        private void tbMaterials_TextChanged(object sender, EventArgs e)
        {
            newLaptop.Material = tbMaterials.Text;
        }

        private void tbDisplay_TextChanged(object sender, EventArgs e)
        {
            newLaptop.Display = tbDisplay.Text;
        }

        private void tbBattery_TextChanged(object sender, EventArgs e)
        {
            newLaptop.Battery = tbBattery.Text;
        }

        private void tbKeyboard_TextChanged(object sender, EventArgs e)
        {
            newLaptop.Keyboard = tbKeyboard.Text;
        }

        private void tbAudio_TextChanged(object sender, EventArgs e)
        {
            newLaptop.Audio = tbAudio.Text;
        }

        private void tbPorts_TextChanged(object sender, EventArgs e)
        {
            newLaptop.Port = tbPorts.Text;
        }

        private void tbKetNoi_TextChanged(object sender, EventArgs e)
        {
            newLaptop.Connection = tbKetNoi.Text;
        }

        private void tbSecurity_TextChanged(object sender, EventArgs e)
        {
            newLaptop.Security = tbSecurity.Text;
        }

        private void tbOS_TextChanged(object sender, EventArgs e)
        {
            newLaptop.OS = tbOS.Text;
        }

        private void tbWP_TextChanged(object sender, EventArgs e)
        {
            newLaptop.WarrantyPeriod = tbWP.Text;
        }
        private void tbTimKiem1_TextChanged(object sender, EventArgs e)
        {
            tab1loading();
        }
        #endregion
        #endregion
        #region tab2

        private ImportInvoice importInvoice = new ImportInvoice();
        private List<Laptop> laptops = new List<Laptop>();
        private List<Provider> providers = new List<Provider>();
        private Laptop choosenLaptop = new Laptop();

        #region loadingEvent
        void tab2Loading1()
        {
            cbNhaCungCap.Text = "";
            cbLaptop2.Text = "";
            tbSoluong2.Text = "";
            SUM.Text = "0";
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
            tbGiaNhap.Enabled = false;
            btnTaoHoaDon.Enabled = true;
            cbNhaCungCap.Enabled = true;
            cbNhaCungCap.Items.Clear();
            cbLaptop2.Items.Clear();
            dataGridView2.Rows.Clear();
            importInvoice.WarehouseKeeper = user;
            providers = ProviderDAL.Instance.get();
            foreach (Provider item in providers)
            {
                cbNhaCungCap.Items.Add(item.toString);
            }
            laptops.Clear();
            laptops = LaptopDAL.Instance.get();
            cbLaptop2.Items.Clear();
            foreach (Laptop item in laptops)
            {
                cbLaptop2.Items.Add(item.Name);
            }
        }
        void tab2Loading2()
        {
            btnXoa2.Enabled = true;
            tbGiaNhap.Enabled = false;
            btnHoanThanh.Enabled = true;
            btnHuyHoaDon.Enabled = true;
            btnSua2.Enabled = true;
            btnThem2.Enabled = true;
            btnGhi2.Enabled = false;
            btnHuy2.Enabled = false;
            btnTaoHoaDon.Enabled = false;
            cbNhaCungCap.Enabled = false;
            cbLaptop2.Enabled = false;
            tbSoluong2.Enabled = false;

            decimal sum = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                sum += Convert.ToDecimal(row.Cells["Col5"].Value);
            }
            SUM.Text = Convert.ToString(sum);
        }

        #endregion
        #region clickEvent
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView2.Rows[e.RowIndex];
                if (Convert.ToString(row.Cells["Col1"].Value) != "")
                {
                    cbLaptop2.Text = Convert.ToString(row.Cells["Col2"].Value);
                    tbSoluong2.Text = Convert.ToString(row.Cells["Col3"].Value);
                }
            }
            catch
            {

            }
        }
        private void btTaoHoaDonNhap_Click(object sender, EventArgs e)
        {
            tab2Loading1();
        }
        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            if (cbNhaCungCap.Text != "")
            {
                tab2Loading2();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp!");
            }
        }
        private void btnThem2_Click(object sender, EventArgs e)
        {
            if (btnSua2.Enabled == true)
            {
                cbLaptop2.Enabled = true;
                tbSoluong2.Enabled = true;
                btnGhi2.Enabled = true;
                btnHuy2.Enabled = true;
                btnSua2.Enabled = false;
                btnXoa2.Enabled = false;
                tbGiaNhap.Enabled = true;
                cbLaptop2.Text = "";
                tbSoluong2.Text = "";
                tbGiaNhap.Text = "";
            }
        }
        private void btnSua2_Click(object sender, EventArgs e)
        {

            if (dataGridView2.Rows.Count == 1)
            {
                MessageBox.Show("Không có thông tin để sửa!");
            }
            else if (btnThem2.Enabled == true)
            {

                cbLaptop2.Enabled = false;
                tbSoluong2.Enabled = true;
                btnGhi2.Enabled = true;
                btnHuy2.Enabled = true;
                btnThem2.Enabled = false;
                btnXoa2.Enabled = false;
                tbGiaNhap.Enabled = true;
            }

        }
        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận hủy", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tab2Loading1();
            }
        }
        private void btnXoa2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 1)
            {
                MessageBox.Show("Không có thông tin để xóa!");
            }
            else if (MessageBox.Show("Xác nhận xóa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (Convert.ToString(row.Cells["Col2"].Value) == cbLaptop2.Text)
                    {
                        dataGridView2.Rows.Remove(row);
                    }
                    tab2Loading2();
                }
            }
            else
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }
        private void btnGhi2_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (cbLaptop2.Text != "" && tbSoluong2.Text != "" && tbGiaNhap.Text != "" && Convert.ToDecimal(tbSoluong2.Text) != 0 && Convert.ToDecimal(tbGiaNhap.Text) != 0)
            {

                if (btnThem2.Enabled)
                {
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["Col1"].Value) == choosenLaptop.ID)
                        {
                            choosenLaptop.QuantityBought += Convert.ToInt32(row.Cells["Col3"].Value);
                            dataGridView2.Rows.Remove(row);
                            dataGridView2.Rows.Add(choosenLaptop.ID, choosenLaptop.Name, choosenLaptop.QuantityBought, choosenLaptop.ImportPrice, (decimal)choosenLaptop.ImportPrice * (decimal)choosenLaptop.QuantityBought);
                            check = false;
                            break;
                        }
                    }
                    if (check)
                    {
                        dataGridView2.Rows.Add(choosenLaptop.ID, choosenLaptop.Name, choosenLaptop.QuantityBought, choosenLaptop.ImportPrice, (decimal)choosenLaptop.ImportPrice * (decimal)choosenLaptop.QuantityBought);
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (Convert.ToString(row.Cells["Col2"].Value) == cbLaptop2.Text)
                        {
                            dataGridView2.Rows.Remove(row);
                            dataGridView2.Rows.Add(choosenLaptop.ID, choosenLaptop.Name, choosenLaptop.QuantityBought, choosenLaptop.ImportPrice, (decimal)choosenLaptop.ImportPrice * (decimal)choosenLaptop.QuantityBought);
                            break;
                        }
                    }

                }

                tab2Loading2();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
        }
        private void btnHuy2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận hủy", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tab2Loading2();
            }
        }
        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 1)
            {
                MessageBox.Show("Vui lòng thêm sản phẩm vào danh sách!");
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    Laptop laptop = new();
                    laptop.ID = Convert.ToInt32(row.Cells["Col1"].Value);
                    laptop.Name = Convert.ToString(row.Cells["Col2"].Value);
                    laptop.QuantityImport = Convert.ToInt32(row.Cells["Col3"].Value);
                    laptop.ImportPrice = Convert.ToInt32(row.Cells["Col4"].Value);
                    importInvoice.Laptops.Add(laptop);
                }
                if (ImportInvoiceBUS.Instance.insert(importInvoice))
                {
                    tab2Loading1();
                    MessageBox.Show("Ghi thành công!");
                }
                else
                {
                    MessageBox.Show("Ghi không thành công!");
                }
            }
        }
        #endregion

        #region textChangeEvent
        private void tbGiaNhap_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbGiaNhap.Text, "  ^ [0-9]"))
            {
                tbGiaNhap.Text = null;
            }
            if (tbGiaNhap.Text != "")
                choosenLaptop.ImportPrice = Convert.ToDecimal(tbGiaNhap.Text);
        }
        private void cbLaptop2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Laptop item in laptops)
            {
                if (item.Name == cbLaptop2.Text)
                {
                    choosenLaptop = item;
                    break;
                }
            }
        }
        private void tbSoluong2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbSoluong2.Text, "  ^ [0-9]"))
            {
                tbSoluong2.Text = null;
            }
            try
            {
                if (tbSoluong2.Text != "")
                    choosenLaptop.QuantityBought = Convert.ToInt32(tbSoluong2.Text);
            }
            catch { }
        }
        private void cbNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in providers)
            {
                if (item.toString == cbNhaCungCap.Text)
                {
                    importInvoice.Provider = item;
                    break;
                }
            }

        }
        private void tbSoluong2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
        #endregion


        private void cbSearchM_SelectedIndexChanged(object sender, EventArgs e)
        {
            tab1loading();
        }

        private void cbSearchC_SelectedIndexChanged(object sender, EventArgs e)
        {
            tab1loading();
        }
    }
}