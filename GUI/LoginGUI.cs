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
        #region clickEvent
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
        #endregion
        #region loadEvent
        private void staffRole()
        {
            switch (staff.RoleInt)
            {
                case 0:
                    ManagerGUI_menu menu0 = new(staff);
                    menu0.ShowDialog();
                    break;
                case 1:
                    SellGUI_menu menu1 = new();
                    menu1.ShowDialog();
                    break;
                case 2:
                    SellGUI_menu menu2 = new();
                    menu2.ShowDialog();
                    break;
                case 3:
                    SellGUI_menu menu3 = new();
                    menu3.ShowDialog();
                    break;
                case 4:
                    SellGUI_menu menu4 = new();
                    menu4.ShowDialog();
                    break;
            }
        }
        #endregion
        #region textChangeEnvent
        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {
            staff.Username = usernameTextbox.Text;
        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {
            staff.Password = passwordTextbox.Text;
        }

        private void LoginGUI_Load(object sender, EventArgs e)
        {
            passwordTextbox.UseSystemPasswordChar = true;
            
        }
        #endregion
    }
}