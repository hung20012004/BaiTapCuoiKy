using BUS;
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
    public partial class AccGUI_menu : Form
    {
        private Staff user = new();
        private Order order = new();
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
                item.Customer = CustomerBUS.Instance.getCustomer(item.Customer);
                item.Seller = StaffBUS.Instance.getSeller(item.Seller);
                dataGridView2.Rows.Add(item.ID, item.Customer.Name, item.Seller.Name, item.Order_date);
            }
            DataGridViewRow row = dataGridView2.Rows[0];
            if (Convert.ToString(row.Cells["OrderID"].Value) != "")
            {
                tbID0.Text = Convert.ToString(row.Cells["OrderID"].Value);
                tbCus0.Text = Convert.ToString(row.Cells["CusName"].Value);
                tbSeller0.Text = Convert.ToString(row.Cells["SellerName"].Value);
                tbOrderDate0.Text = Convert.ToString(row.Cells["OrderTime"].Value);
            }
        }

        #endregion
        #region ClickEvent
        private void btnCho_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            loadTab0();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {

            order.StatusInt = 0;
            order.Accountant.ID = user.ID;
            OrderBUS.Instance.update(order);
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
                loadTab0();
            }
        }

        private void btXong_Click(object sender, EventArgs e)
        {
            order.StatusInt = 2;
            order.Accountant.ID = user.ID;
            OrderBUS.Instance.update(order);
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
                loadTab0();
            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView2.Rows[e.RowIndex];
            if (Convert.ToString(row.Cells["OrderID"].Value) != "")
            {
                tbID0.Text = Convert.ToString(row.Cells["OrderID"].Value);
                tbCus0.Text = Convert.ToString(row.Cells["CusName"].Value);
                tbSeller0.Text = Convert.ToString(row.Cells["SellerName"].Value);
                tbOrderDate0.Text = Convert.ToString(row.Cells["OrderTime"].Value);
            }
        }

        #endregion
        #region textChangeEvent

        private void cboPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            order.PaymentString = cboPayment0.Text;
        }

        #endregion
        #endregion
        #region tab1
        #region loadingEvent
        public void loadTab1()
        {
            tabControl1.SelectedIndex = 1;
            tbID1.Enabled = false;
            tbSeller1.Enabled = false;
            tbCustomer.Enabled = false;
            tbStatus.Enabled = false;
            tbOrderDate.Enabled = false;
            dataGridView3.Enabled = true;
            dataGridView3.Rows.Clear();
            foreach (Order item in OrderBUS.Instance.get())
            {
                if (item.Accountant.ID == user.ID)
                {
                    item.Customer = CustomerBUS.Instance.getCustomer(item.Customer);
                    item.Seller = StaffBUS.Instance.getSeller(item.Seller);
                    item.Accountant = StaffBUS.Instance.getAccountant(item.Accountant);
                    dataGridView3.Rows.Add(item.ID, item.Customer.Name, item.Accountant.Name, item.Seller.Name, item.Order_date, item.PaymentString, item.StatusString);
                }
            }
            DataGridViewRow row = dataGridView3.Rows[0];
            if (Convert.ToString(row.Cells["ID"].Value) != "")
            {
                tbID1.Text = Convert.ToString(row.Cells["ID"].Value);
                tbCustomer.Text = Convert.ToString(row.Cells["CusName1"].Value);
                tbSeller1.Text = Convert.ToString(row.Cells["SellName1"].Value);
                tbOrderDate.Text = Convert.ToString(row.Cells["OrderDate"].Value);
                tbStatus.Text = Convert.ToString(row.Cells["Status"].Value);
            }
        }
        #endregion
        #region clickEvent
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            loadTab1();
        }
        private void btnXuatExcel1_Click(object sender, EventArgs e)
        {
            ExportData.Instance.ToExcel(dataGridView3, "Thống kê hóa đơn khách hàng");
        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView3.Rows[e.RowIndex];
            if (Convert.ToString(row.Cells["ID"].Value) != "")
            {
                tbID1.Text = Convert.ToString(row.Cells["ID"].Value);
                tbCustomer.Text = Convert.ToString(row.Cells["CusName1"].Value);
                tbSeller1.Text = Convert.ToString(row.Cells["SellName1"].Value);
                tbOrderDate.Text = Convert.ToString(row.Cells["OrderDate"].Value);
                tbStatus.Text = Convert.ToString(row.Cells["Status"].Value);
            }
        }
        #endregion

        #endregion
        #region tab2
        #endregion
        #region tab3
        #region loadingEvent

        #endregion
        #region clickEvent
        #endregion
        #region textChangeEvent
        #endregion
        #endregion




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}