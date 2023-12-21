using BUS;
using DTO;

namespace GUI
{
    public partial class LoginGUI : Form
    {
        private Staff staff = new();
        public LoginGUI()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (StaffBUS.Instance.checkLogInfo(staff))
            {
                this.Hide();
                staffRole();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác");
            }
        }
        private void staffRole()
        {
            switch (staff.Role)
            {
                case 0:
                    ManagerGUI_menu menu0 = new();
                    menu0.ShowDialog();
                    break;
                case 1:
                    SellGUI_menu menu1 = new();
                    menu1.ShowDialog();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {
            staff.Username = usernameTextbox.Text;
        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {
            staff.Password = passwordTextbox.Text;
        }
    }
}