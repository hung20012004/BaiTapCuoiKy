using DAL;
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
        public WarehouseUI_menu()
        {
            InitializeComponent();
        }
        void loading()
        {
            btGhi.Enabled = false;
            btHuy.Enabled = false;
            btThem.Enabled = true;
            btSua.Enabled = true;
            btXoa.Enabled = true;
        }
        void reset()
        {

        }

        private void WarehouseUI_menu_Load(object sender, EventArgs e)
        {
            loading();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            btGhi.Enabled = true;
            btHuy.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            reset();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            btGhi.Enabled = true;
            btHuy.Enabled = true;
            btThem.Enabled = false;
            btXoa.Enabled = false;
            reset();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            btSua.Enabled = false;
            btThem.Enabled = false;
            if (tbNCC.Text != "")
            {
            }
            //Loading();
        }

    }
}
