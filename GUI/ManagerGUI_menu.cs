using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace GUI
{
    public partial class ManagerGUI_menu : Form
    {
        private Staff staff = new();
        private Staff user = new();

        public ManagerGUI_menu(Staff user)
        {
            this.user = user;
            InitializeComponent();
        }
        #region LoadingEvent
        //Xu ly loading
        private void ManagerGUI_menu_Load(object sender, EventArgs e)
        {
            tab0Reset();
        }
        private void tab0Reset()
        {
            tbMatKhau.UseSystemPasswordChar = true;
            tbTaiKhoan.UseSystemPasswordChar = true;
            tabControl1.SelectedIndex = 0;
            foreach (Staff item in StaffDAL.Instance.get())
            {
                dataGridView1.Rows.Add(item.ID, item.Name, item.Username, item.Password, item.RoleString);
            }
            DataGridViewRow row = dataGridView1.Rows[0];
            if (Convert.ToString(row.Cells["Column1"].Value) != "")
            {
                tbID.Text = Convert.ToString(row.Cells["Column1"].Value);
                tbHoTen.Text = Convert.ToString(row.Cells["Column2"].Value);
                tbTaiKhoan.Text = Convert.ToString(row.Cells["Column3"].Value);
                tbMatKhau.Text = Convert.ToString(row.Cells["Column4"].Value);
                cbRole.Text = Convert.ToString(row.Cells["Column5"].Value);
            }
        }
        private void tab1Reset()
        {
            tabControl1.SelectedIndex = 1;
        }
        #endregion

        #region ClickEvent
        //Xu ly cac event click
        private void btnQuanLyNhanSu_Click(object sender, EventArgs e)
        {
            tab0Reset();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            tab1Reset();
        }
        private void btnShowLogInfo_Click(object sender, EventArgs e)
        {
            tbMatKhau.UseSystemPasswordChar = false;
            tbTaiKhoan.UseSystemPasswordChar = false;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMatKhau.UseSystemPasswordChar = true;
            tbTaiKhoan.UseSystemPasswordChar = true;
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            if (Convert.ToString(row.Cells["Column1"].Value) != "")
            {
                tbID.Text = Convert.ToString(row.Cells["Column1"].Value);
                tbHoTen.Text = Convert.ToString(row.Cells["Column2"].Value);
                tbTaiKhoan.Text = Convert.ToString(row.Cells["Column3"].Value);
                tbMatKhau.Text = Convert.ToString(row.Cells["Column4"].Value);
                cbRole.Text = Convert.ToString(row.Cells["Column5"].Value);
            }

        }
        #endregion

        #region textChangeEvent
        //Hung du lieu cho staff
        private void tbID_TextChanged(object sender, EventArgs e)
        {
            if (tbID.Text.Length > 0)
            {
                staff.ID = Convert.ToInt32(tbID.Text);
            }
        }

        private void tbHoTen_TextChanged(object sender, EventArgs e)
        {
            staff.Name = tbHoTen.Text;
        }

        private void tbTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            staff.Username = tbTaiKhoan.Text;
        }

        private void tbMatKhau_TextChanged(object sender, EventArgs e)
        {
            staff.Password = tbMatKhau.Text;
        }
        #endregion
    }
}
