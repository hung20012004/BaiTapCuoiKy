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
        public void load()
        {
            dataGridView1.Enabled = true;
            dataGridView1.Rows.Clear();
            foreach (Order item in OrderBUS.Instance.get())
            {
                dataGridView1.Rows.Add(item.ID, item.Customer.Name, item.Seller.Name, item.Order_date, item.PaymentString);
            }
            DataGridViewRow row = dataGridView1.Rows[0];
            if (Convert.ToString(row.Cells["ID"].Value) != "")
            {
                tbID.Text = Convert.ToString(row.Cells["ID"].Value);
                tbCus.Text = Convert.ToString(row.Cells["CustomerID"].Value);
                tbSeller.Text = Convert.ToString(row.Cells["SellerID"].Value);
                cboPayment.Text = Convert.ToString(row.Cells["Payment"].Value);
                dtpOrder.Text = Convert.ToString(row.Cells["OrderTime"].Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btHuy_Click(object sender, EventArgs e)
        {

            order.StatusInt = 0;
            order.Accountant.ID = user.ID;
            OrderBUS.Instance.update(order);
        }

        private void btXong_Click(object sender, EventArgs e)
        {
            order.StatusInt = 2;
            order.Accountant.ID = user.ID;
            OrderBUS.Instance.update(order);
        }
    }
}
