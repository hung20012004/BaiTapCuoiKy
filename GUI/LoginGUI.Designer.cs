﻿namespace GUI
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
            username = new Label();
            password = new Label();
            usernameTextbox = new TextBox();
            passwordTextbox = new TextBox();
            loginBtn = new Button();
            SuspendLayout();
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(210, 245);
            username.Name = "username";
            username.Size = new Size(94, 28);
            username.TabIndex = 0;
            username.Text = "Tài khoản";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(210, 288);
            password.Name = "password";
            password.Size = new Size(94, 28);
            password.TabIndex = 1;
            password.Text = "Mật khẩu";
            // 
            // usernameTextbox
            // 
            usernameTextbox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextbox.Location = new Point(331, 245);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.Size = new Size(246, 34);
            usernameTextbox.TabIndex = 2;
            usernameTextbox.TextChanged += usernameTextbox_TextChanged;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextbox.Location = new Point(331, 285);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.Size = new Size(246, 34);
            passwordTextbox.TabIndex = 3;
            passwordTextbox.TextChanged += passwordTextbox_TextChanged;
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.Location = new Point(331, 322);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(246, 35);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Đăng nhập";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // LoginGUI
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(904, 568);
            Controls.Add(loginBtn);
            Controls.Add(passwordTextbox);
            Controls.Add(usernameTextbox);
            Controls.Add(password);
            Controls.Add(username);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += LoginGUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label username;
        private Label password;
        private TextBox usernameTextbox;
        private TextBox passwordTextbox;
        private Button loginBtn;
    }
}