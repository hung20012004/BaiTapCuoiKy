using BUS;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        #region LoadingEvent
        private void WarehouseUI_menu_Load(object sender, EventArgs e)
        {
            tab0loading();
            tab1loading();
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
                tbWP.Text = Convert.ToString(row.Cells["ColWarrantyPeriod"].Value);
                tbPrice.Text = Convert.ToString(row.Cells["ColPrice"].Value);
                tbQuantity.Text = Convert.ToString(row.Cells["ColQuantity"].Value);
            }
        }
        #endregion
        #region ClickEvent
        private void btNhaCungCap_Click(object sender, EventArgs e)
        {
            tab0loading();
        }

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

        private void btSanPham_Click(object sender, EventArgs e)
        {
            tab1loading();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView3.Rows[e.RowIndex];
            if (Convert.ToString(row.Cells["Column1"].Value) != "")
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
                tbWP.Text = Convert.ToString(row.Cells["ColWarrantyPeriod"].Value);
                tbPrice.Text = Convert.ToString(row.Cells["ColPrice"].Value);
                tbQuantity.Text = Convert.ToString(row.Cells["ColQuantity"].Value);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btNhapKho_Click(object sender, EventArgs e)
        {

        }

        private void btGhi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận ghi", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (btThem.Enabled == true)
                {
                    if (tbLaptop_Name.Text != "" && tbAddress.Text != "")
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

        private void btHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận hủy", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tab0loading();
            }
        }

        private void btThem1_Click(object sender, EventArgs e)
        {
            btGhi1.Enabled = true;
            btHuy1.Enabled = true;
            btSua1.Enabled = false;
            btXoa1.Enabled = false;
        }

        private void btSua1_Click(object sender, EventArgs e)
        {
            btGhi1.Enabled = true;
            btHuy1.Enabled = true;
            btThem1.Enabled = false;
            btXoa1.Enabled = false;
        }

        private void btXoa1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (ProviderBUS.Instance.delete(provider))
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

        private void btGhi1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Xác nhận ghi", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (btThem1.Enabled == true)
                {
                    if (tbLaptop_Name.Text != "" && cbbCategory.Text != "")
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

        private void btHuy1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận hủy", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tab1loading();
            }
        }

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
            //   laptop.QuantityInStock = tbQuantity.Text;
        }
        #endregion
    }
}