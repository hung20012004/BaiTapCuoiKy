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
    public partial class ManagerGUI_menu : Form
    {
        public ManagerGUI_menu()
        {
            InitializeComponent();
        }

        private void btnQuanLyNhanSu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            
        }
        private void tab0Reset()
        {
            tabControl1.SelectedIndex = 0;

        }
        private void tab1Reset()
        {
            tabControl1.SelectedIndex = 1;
        }
    }
}
