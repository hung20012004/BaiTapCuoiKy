namespace GUI
{
    partial class LoginGUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginGUI));
            usernameTextbox = new TextBox();
            passwordTextbox = new TextBox();
            loginBtn = new Button();
            lbSai = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // usernameTextbox
            // 
            usernameTextbox.Cursor = Cursors.IBeam;
            usernameTextbox.Font = new Font(".VnLucida sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextbox.Location = new Point(332, 260);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.Size = new Size(243, 29);
            usernameTextbox.TabIndex = 2;
            usernameTextbox.Text = "username";
            usernameTextbox.TextChanged += usernameTextbox_TextChanged;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Cursor = Cursors.IBeam;
            passwordTextbox.Font = new Font(".VnLucida sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextbox.Location = new Point(332, 297);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.Size = new Size(243, 29);
            passwordTextbox.TabIndex = 3;
            passwordTextbox.Text = "password";
            passwordTextbox.TextChanged += passwordTextbox_TextChanged;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.SeaShell;
            loginBtn.FlatAppearance.BorderColor = Color.Ivory;
            loginBtn.FlatAppearance.BorderSize = 3;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginBtn.Location = new Point(332, 332);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(243, 42);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // lbSai
            // 
            lbSai.AutoSize = true;
            lbSai.BackColor = Color.MintCream;
            lbSai.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbSai.ForeColor = Color.DarkGreen;
            lbSai.Location = new Point(332, 540);
            lbSai.Name = "lbSai";
            lbSai.Size = new Size(254, 22);
            lbSai.TabIndex = 7;
            lbSai.Text = "* Incorrect username or password";
            lbSai.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(874, 12);
            button1.Name = "button1";
            button1.Size = new Size(24, 27);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LoginGUI
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(910, 590);
            Controls.Add(button1);
            Controls.Add(lbSai);
            Controls.Add(loginBtn);
            Controls.Add(passwordTextbox);
            Controls.Add(usernameTextbox);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += LoginGUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox usernameTextbox;
        private TextBox passwordTextbox;
        private Button loginBtn;
        private Label lbSai;
        private Button button1;
    }
}