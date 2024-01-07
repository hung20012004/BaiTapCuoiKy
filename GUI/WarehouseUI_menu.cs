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
        private Provider provider = new();
        private Laptop laptop = new();
        public WarehouseUI_menu(Staff user)
        {
            this.user = user;
            InitializeComponent();
        }
        private void WarehouseUI_menu_Load(object sender, EventArgs e)
        {
            tab0loading();
            tab1loading();
        }
        #region tab0

        #region loadingEvent
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

        #endregion
        #region clickEvent
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            if (Convert.ToString(row.Cells["Column1"].Value) != "")
            {
                tbID.Text = Convert.ToString(row.Cells["Column1"].Value);
                tbName.Text = Convert.ToString(row.Cells["Column2"].Value);
                tbAddress.Text = Convert.ToString(row.Cells["Column3"].Value);
                tbPhone.Text = Convert.ToString(row.Cells["Column4"].Value);
            }
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            btGhi.Enabled = true;
            btHuy.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            tbID.Text = "";
            tbName.Text = "";
            tbAddress.Text = "";
            tbPhone.Text = "";
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
        private void btGhi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận ghi", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (btThem.Enabled == true)
                {
                    if (tbName.Text != "" && tbPhone.Text != "")
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
        private void btHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận hủy", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tab0loading();
            }
        }

        private void btNhaCungCap_Click(object sender, EventArgs e)
        {
            tab0loading();
        }

        #endregion
        #region textChangeEvent
        private void tbID_TextChanged(object sender, EventArgs e)
        {
            if (tbID.Text.Length > 0)
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
            provider.Name = tbPhone.Text;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            provider.Name = tbName.Text;
        }
        #endregion
        #endregion
        #region tab1
        #region loadingEvent
        void tab1loading()
        {
            btGhi1.Enabled = false;
            btHuy1.Enabled = false;
            btThem1.Enabled = true;
            btSua1.Enabled = true;
            btXoa1.Enabled = true;
            tabControl1.SelectedIndex = 1;
            dataGridView3.Enabled = true;
            dataGridView3.Rows.Clear();
            foreach (Laptop item in LaptopBUS.Instance.get())
            {
                dataGridView3.Rows.Add(item.ID, item.Name, item.Category.ID, item.Manufactory.ID, item.CPU, item.Ram, item.HardDriver, item.VGA, item.Display, item.Battery, item.Weight, item.Material, item.Port, item.Connection, item.Security, item.Keyboard, item.Audio, item.Size, item.OS, item.WarrantyPeriod, item.Price, item.QuantityInStock);
            }
            DataGridViewRow row = dataGridView3.Rows[0];
            if (Convert.ToString(row.Cells["ColID"].Value) != "")
            {
                tbLaptop_ID.Text = Convert.ToString(row.Cells["ColID"].Value);
                tbLaptop_Name.Text = Convert.ToString(row.Cells["ColName"].Value);
                cbbCategory.Text = Convert.ToString(row.Cells["ColCategory"].Value);
                cbbManufactory.Text = Convert.ToString(row.Cells["ColManufactory"].Value);
                tbCPU.Text = Convert.ToString(row.Cells["ColCPU"].Value);
                tbRAM.Text = Convert.ToString(row.Cells["ColRam"].Value);
                tbHD.Text = Convert.ToString(row.Cells["ColHardDriver"].Value);
                tbVGA.Text = Convert.ToString(row.Cells["ColVGA"].Value);
                tbDisplay.Text = Convert.ToString(row.Cells["ColDisplay"].Value);
                tbBattery.Text = Convert.ToString(row.Cells["ColBattery"].Value);
                tbWeight.Text = Convert.ToString(row.Cells["ColWeight"].Value);
                tbMaterial.Text = Convert.ToString(row.Cells["ColMaterial"].Value);
                tbPort.Text = Convert.ToString(row.Cells["ColPort"].Value);
                tbConnection.Text = Convert.ToString(row.Cells["ColConnection"].Value);
                tbSecurity.Text = Convert.ToString(row.Cells["ColSecurity"].Value);
                tbKeyboard.Text = Convert.ToString(row.Cells["ColKeyboard"].Value);
                tbAudio.Text = Convert.ToString(row.Cells["ColAudio"].Value);
                tbSize.Text = Convert.ToString(row.Cells["ColSize"].Value);
                tbOS.Text = Convert.ToString(row.Cells["ColOS"].Value);
                tbWP.Text = Convert.ToString(row.Cells["ColWP"].Value);
                tbPrice.Text = Convert.ToString(row.Cells["ColPrice"].Value);
                tbQuantity.Text = Convert.ToString(row.Cells["ColQuantity"].Value);
            }
        }
        #endregion
        #region clickEvent
        private void btSanPham_Click(object sender, EventArgs e)
        {
            tab1loading();
        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView3.Rows[e.RowIndex];
            if (Convert.ToString(row.Cells["ColID"].Value) != "")
            {
                tbLaptop_ID.Text = Convert.ToString(row.Cells["ColID"].Value);
                tbLaptop_Name.Text = Convert.ToString(row.Cells["ColName"].Value);
                cbbCategory.Text = Convert.ToString(row.Cells["ColCategory"].Value);
                cbbManufactory.Text = Convert.ToString(row.Cells["ColManufactory"].Value);
                tbCPU.Text = Convert.ToString(row.Cells["ColCPU"].Value);
                tbRAM.Text = Convert.ToString(row.Cells["ColRam"].Value);
                tbHD.Text = Convert.ToString(row.Cells["ColHardDriver"].Value);
                tbVGA.Text = Convert.ToString(row.Cells["ColVGA"].Value);
                tbDisplay.Text = Convert.ToString(row.Cells["ColDisplay"].Value);
                tbBattery.Text = Convert.ToString(row.Cells["ColBattery"].Value);
                tbWeight.Text = Convert.ToString(row.Cells["ColWeight"].Value);
                tbMaterial.Text = Convert.ToString(row.Cells["ColMaterial"].Value);
                tbPort.Text = Convert.ToString(row.Cells["ColPort"].Value);
                tbConnection.Text = Convert.ToString(row.Cells["ColConnection"].Value);
                tbSecurity.Text = Convert.ToString(row.Cells["ColSecurity"].Value);
                tbKeyboard.Text = Convert.ToString(row.Cells["ColKeyboard"].Value);
                tbAudio.Text = Convert.ToString(row.Cells["ColAudio"].Value);
                tbSize.Text = Convert.ToString(row.Cells["ColSize"].Value);
                tbOS.Text = Convert.ToString(row.Cells["ColOS"].Value);
                tbWP.Text = Convert.ToString(row.Cells["ColWP"].Value);
                tbPrice.Text = Convert.ToString(row.Cells["ColPrice"].Value);
                tbQuantity.Text = Convert.ToString(row.Cells["ColQuantity"].Value);
            }
        }
        private void btThem1_Click_1(object sender, EventArgs e)
        {
            btGhi1.Enabled = true;
            btHuy1.Enabled = true;
            btSua1.Enabled = false;
            btXoa1.Enabled = false;
            tbLaptop_ID.Text = "";
            tbLaptop_Name.Text = "";
            cbbCategory.Text = "";
            cbbManufactory.Text = "";
            tbCPU.Text = "";
            tbRAM.Text = "";
            tbHD.Text = "";
            tbVGA.Text = "";
            tbDisplay.Text = "";
            tbBattery.Text = "";
            tbWeight.Text = "";
            tbMaterial.Text = "";
            tbPort.Text = "";
            tbConnection.Text = "";
            tbSecurity.Text = "";
            tbKeyboard.Text = "";
            tbAudio.Text = "";
            tbSize.Text = "";
            tbOS.Text = "";
            tbWP.Text = "";
            tbPrice.Text = "";
            tbQuantity.Text = "";
        }

        private void btSua1_Click_1(object sender, EventArgs e)
        {
            btGhi1.Enabled = true;
            btHuy1.Enabled = true;
            btThem1.Enabled = false;
            btXoa1.Enabled = false;
        }

        private void btXoa1_Click_1(object sender, EventArgs e)
        {
            btSua1.Enabled = false;
            btThem1.Enabled = false;
            if (MessageBox.Show("Xác nhận xóa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (LaptopBUS.Instance.delete(laptop))
                {
                    tab1loading();
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

        private void btGhi1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận ghi", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (btThem1.Enabled == true)
                {
                    if (tbLaptop_Name.Text != "" && cbbCategory.Text != "")
                    {
                        if (LaptopBUS.Instance.insert(laptop))
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
                    if (LaptopBUS.Instance.update(laptop))
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
                MessageBox.Show("Xóa không thành công!");
            }
        }

        private void btHuy1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận hủy", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tab1loading();
            }
        }
        #endregion
        #region textChangeEvent
        private void tbLaptop_ID_TextChanged(object sender, EventArgs e)
        {
            if (tbLaptop_ID.Text.Length > 0)
            {
                laptop.ID = Convert.ToInt32(tbLaptop_ID.Text);
            }
        }

        private void tbLaptop_Name_TextChanged(object sender, EventArgs e)
        {
            laptop.Name = tbLaptop_Name.Text;
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            laptop.Category.ID = cbbCategory.SelectedIndex;
        }

        private void cbbManufactory_SelectedIndexChanged(object sender, EventArgs e)
        {
            laptop.Manufactory.ID = cbbManufactory.SelectedIndex;
        }

        private void tbCPU_TextChanged(object sender, EventArgs e)
        {
            laptop.CPU = tbCPU.Text;
        }
        private void tbRAM_TextChanged(object sender, EventArgs e)
        {
            laptop.Ram = tbRAM.Text;
        }

        private void tbHD_TextChanged(object sender, EventArgs e)
        {
            laptop.HardDriver = tbHD.Text;
        }

        private void tbVGA_TextChanged(object sender, EventArgs e)
        {
            laptop.VGA = tbVGA.Text;
        }

        private void tbDisplay_TextChanged(object sender, EventArgs e)
        {
            laptop.Display = tbDisplay.Text;
        }

        private void tbBattery_TextChanged(object sender, EventArgs e)
        {
            laptop.Battery = tbBattery.Text;
        }

        private void tbWeight_TextChanged(object sender, EventArgs e)
        {
            // laptop.Weight = tbWeight.;
        }

        private void tbMaterial_TextChanged(object sender, EventArgs e)
        {
            laptop.Material = tbMaterial.Text;
        }

        private void tbPort_TextChanged(object sender, EventArgs e)
        {
            laptop.Port = tbPort.Text;
        }

        private void tbConnection_TextChanged(object sender, EventArgs e)
        {
            laptop.Connection = tbConnection.Text;
        }

        private void tbSecurity_TextChanged(object sender, EventArgs e)
        {
            laptop.Security = tbSecurity.Text;
        }

        private void tbKeyboard_TextChanged(object sender, EventArgs e)
        {
            laptop.Keyboard = tbKeyboard.Text;
        }

        private void tbAudio_TextChanged(object sender, EventArgs e)
        {
            laptop.Audio = tbAudio.Text;
        }

        private void tbSize_TextChanged(object sender, EventArgs e)
        {
            laptop.Size = tbSize.Text;
        }

        private void tbOS_TextChanged(object sender, EventArgs e)
        {
            laptop.OS = tbOS.Text;
        }

        private void tbWP_TextChanged(object sender, EventArgs e)
        {
            laptop.WarrantyPeriod = tbWP.Text;
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            laptop.Price = tbPrice.Text;
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            //laptop.QuantityInStock = tbQuantity.Text;
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
            tabControl1.SelectedIndex = 2;
            btGhi2.Enabled = false;
            btnHoanThanh.Enabled = false;
            btHuy2.Enabled = false;
            btnHuyHoaDon.Enabled = false;
            btSua2.Enabled = false;
            btThem2.Enabled = false;
            tbSoluong2.Enabled = false;
            cbbLaptop2.Enabled = false;
            btXoa2.Enabled = false;
            btTaoHoaDon.Enabled = true;
            cbbNhaCungCap.Enabled = true;
            cbbNhaCungCap.Items.Clear();
            cbbLaptop2.Items.Clear();
            dataGridView2.Rows.Clear();
            importInvoice.WarehouseKeeper = user;
            providers = ProviderDAL.Instance.get();
            foreach (Provider item in providers)
            {
                cbbNhaCungCap.Items.Add(item.Name);
            }
            laptops.Clear();
            laptops = LaptopDAL.Instance.get();
            cbbLaptop2.Items.Clear();
            foreach (Laptop item in laptops)
            {
                cbbLaptop2.Items.Add(item.Name);
            }
        }
        void tab2Loading2()
        {
            btXoa2.Enabled = true;
            btnHoanThanh.Enabled = true;
            btnHuyHoaDon.Enabled = true;
            btSua2.Enabled = true;
            btThem2.Enabled = true;
            btGhi2.Enabled = false;
            btHuy2.Enabled = false;
            btTaoHoaDon.Enabled = false;
            cbbNhaCungCap.Enabled = false;
            cbbLaptop2.Enabled = false;
            tbSoluong2.Enabled = false;

        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView2.Rows[e.RowIndex];
                if (Convert.ToString(row.Cells["Col1"].Value) != "")
                {
                    cbbLaptop2.Text = Convert.ToString(row.Cells["Col2"].Value);
                    tbSoluong2.Text = Convert.ToString(row.Cells["Col3"].Value);
                }
            }
            catch
            {

            }
        }
        #endregion
        #region clickEvent
        private void btTaoHoaDonNhap_Click(object sender, EventArgs e)
        {
            tab2Loading1();
        }
        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            if (cbbNhaCungCap.Text != "")
            {
                tab2Loading2();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp!");
            }
        }
        private void btThem2_Click(object sender, EventArgs e)
        {
            cbbLaptop2.Enabled = true;
            tbSoluong2.Enabled = true;
            btGhi2.Enabled = true;
            btHuy2.Enabled = true;
            btSua2.Enabled = false;
            btXoa2.Enabled = false;
            cbbLaptop2.Text = "";
            tbSoluong2.Text = "";
        }
        private void btSua2_Click(object sender, EventArgs e)
        {
            cbbLaptop2.Enabled = true;
            tbSoluong2.Enabled = true;
            btGhi2.Enabled = true;
            btHuy2.Enabled = true;
            btThem2.Enabled = false;
            btXoa2.Enabled = false;

        }

        private void btXoa2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (Convert.ToString(row.Cells["Col2"].Value) == cbbLaptop2.Text)
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
        private void btGhi2_Click(object sender, EventArgs e)
        {
            if (cbbLaptop2.Text != "" && tbSoluong2.Text != "")
            {
                if (btThem2.Enabled)
                {
                    dataGridView2.Rows.Add(choosenLaptop.ID, choosenLaptop.Name, choosenLaptop.QuantityBought, choosenLaptop.Price);
                }
                else
                {
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (Convert.ToString(row.Cells["Col2"].Value) == cbbLaptop2.Text)
                        {
                            dataGridView2.Rows.Remove(row);
                        }
                    }
                    dataGridView2.Rows.Add(choosenLaptop.ID, choosenLaptop.Name, choosenLaptop.QuantityBought, choosenLaptop.Price);
                }
                tab2Loading2();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
        }
        private void btHuy2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận hủy", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tab2Loading2();
            }
        }
        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                Laptop laptop = new();
                laptop.ID = Convert.ToInt32(row.Cells["Col1"].Value);
                laptop.Name = Convert.ToString(row.Cells["Col2"].Value);
                laptop.QuantityBought = Convert.ToInt32(row.Cells["Col3"].Value);
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
        #endregion
        #region textChangeEvent
        private void cbLaptop2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Laptop item in laptops)
            {
                if (item.Name == cbbLaptop2.Text)
                {
                    choosenLaptop = item;
                    break;
                }
            }
        }
        private void tbSoluong2_TextChanged(object sender, EventArgs e)
        {
            if (tbSoluong2.Text != "")
                choosenLaptop.QuantityBought = Convert.ToInt32(tbSoluong2.Text);
        }
        private void cbNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in providers)
            {
                if (item.Name == cbbNhaCungCap.Text)
                {
                    importInvoice.Provider = item;
                    break;
                }
            }

        }
        #endregion
        #endregion


    }
}