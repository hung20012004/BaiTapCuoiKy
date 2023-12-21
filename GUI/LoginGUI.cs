namespace GUI
{
    public partial class LoginGUI : Form
    {
        public LoginGUI()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            SellGUI_menu getcustomer = new();
            this.Hide();
            getcustomer.ShowDialog();
            this.Show();
        }
    }
}