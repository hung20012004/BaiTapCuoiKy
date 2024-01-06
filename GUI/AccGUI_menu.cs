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
        #region LoadingEvent
        private void AccGUI_menu_Load(object sender, EventArgs e)
        {
            loadTab0();
        }
        public void loadTab0()
        {
            tabControl1.SelectedIndex = 0;
            tbID.Enabled = false;
            tbCus.Enabled = false;
            tbSeller.Enabled = false;
            tbOrder.Enabled = false;
            cboPayment.Enabled = true;
            dataGridView2.Enabled = true;
            dataGridView2.Rows.Clear();

            foreach (Order item in OrderBUS.Instance.get())
            {
                if (item.StatusInt == 1)
                {
                    item.Customer = CustomerBUS.Instance.getCustomer(item.Customer);
                    item.Seller = StaffBUS.Instance.getSeller(item.Seller);
                    dataGridView2.Rows.Add(item.ID, item.Customer.Name, item.Seller.Name, item.Order_date);
                }
            }
            DataGridViewRow row = dataGridView2.Rows[0];
            if (Convert.ToString(row.Cells["OrderID"].Value) != "")
            {
                tbID.Text = Convert.ToString(row.Cells["OrderID"].Value);
                tbCus.Text = Convert.ToString(row.Cells["CusName"].Value);
                tbSeller.Text = Convert.ToString(row.Cells["SellerName"].Value);
                tbOrder.Text = Convert.ToString(row.Cells["OrderTime"].Value);
            }
        }
        public void loadTab1()
        {
            tabControl1.SelectedIndex = 1;
            tbID1.Enabled = false;
            tbCustomer.Enabled = false;
            tbAcc.Enabled = false;
            tbSeller1.Enabled = false;
            tbPay.Enabled = false;
            tbOrderDate.Enabled = false;
            tbStatus_Date.Enabled = false;
            dataGridView3.Enabled = true;
            dataGridView3.Rows.Clear();

            foreach (Order item in OrderBUS.Instance.get())
            {
                if (item.StatusInt == 2)
                {
                    item.Customer = CustomerBUS.Instance.getCustomer(item.Customer);
                    item.Seller = StaffBUS.Instance.getSeller(item.Seller);
                    item.Accountant = StaffBUS.Instance.getAccountant(item.Accountant);
                    dataGridView3.Rows.Add(item.ID, item.Customer.Name, item.Accountant.Name, item.Seller.Name, item.Order_date, item.PaymentString, item.UpdateStatusTime);
                }
            }
            DataGridViewRow row = dataGridView3.Rows[0];
            if (Convert.ToString(row.Cells["ID"].Value) != "")
            {
                tbID1.Text = Convert.ToString(row.Cells["ID"].Value);
                tbCustomer.Text = Convert.ToString(row.Cells["CusName1"].Value);
                tbAcc.Text = Convert.ToString(row.Cells["AccName"].Value);
                tbSeller1.Text = Convert.ToString(row.Cells["SellerName1"].Value);
                tbOrderDate.Text = Convert.ToString(row.Cells["OrderDate"].Value);
                tbPay.Text = Convert.ToString(row.Cells["Pay"].Value);
                tbStatus_Date.Text = Convert.ToString(row.Cells["Status_Date"].Value);
            }
        }
        #endregion
        #region ClickEvent
        private void btnCho_Click(object sender, EventArgs e)
        {
            loadTab0();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            loadTab1();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận hủy đơn", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                order.StatusInt = 0;
                order.UpdateStatusTime = DateTime.Now;
                order.Accountant = new Staff();
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
            if (MessageBox.Show("Xác nhận hoàn thành", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                order.StatusInt = 2;
                order.UpdateStatusTime = DateTime.Now;
                order.Accountant = new Staff();
                order.Accountant.ID = user.ID;
                order.PaymentString = cboPayment.Text;
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
                tbID.Text = Convert.ToString(row.Cells["OrderID"].Value);
                tbCus.Text = Convert.ToString(row.Cells["CusName"].Value);
                tbSeller.Text = Convert.ToString(row.Cells["SellerName"].Value);
                tbOrder.Text = Convert.ToString(row.Cells["OrderTime"].Value);
                foreach (Order item in OrderBUS.Instance.getdetail(item))
                {
                    lbTong.Text = Convert.ToString(item.Laptop);
                }
                
            }
        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView3.Rows[e.RowIndex];
            if (Convert.ToString(row.Cells["ID"].Value) != "")
            {
                tbID1.Text = Convert.ToString(row.Cells["ID"].Value);
                tbCustomer.Text = Convert.ToString(row.Cells["CusName1"].Value);
                tbAcc.Text = Convert.ToString(row.Cells["AccName"].Value);
                tbSeller1.Text = Convert.ToString(row.Cells["SellerName1"].Value);
                tbOrderDate.Text = Convert.ToString(row.Cells["OrderDate"].Value);
                tbPay.Text = Convert.ToString(row.Cells["Pay"].Value);
                tbStatus_Date.Text = Convert.ToString(row.Cells["Status_Date"].Value);
                
            }
        }
        private void btnXuat_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region textChangeEvent
        private void tbID_TextChanged(object sender, EventArgs e)
        {
            if (tbID.Text.Length > 0)
            {
                order.ID = Convert.ToInt32(tbID.Text);
            }
        }
        private void cboPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            order.PaymentString = cboPayment.Text;
        }

        private void dtpOrder_ValueChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void lbTong_DataContextChanged(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
