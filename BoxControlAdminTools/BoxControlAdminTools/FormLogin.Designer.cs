namespace BoxControlAdminTools
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btn_demo = new Button();
            btn_login = new Button();
            label1 = new Label();
            Username = new Label();
            lbl_Demo = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(153, 429);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(181, 23);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(153, 473);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(181, 23);
            txtPassword.TabIndex = 1;
            // 
            // btn_demo
            // 
            btn_demo.Location = new Point(12, 12);
            btn_demo.Name = "btn_demo";
            btn_demo.Size = new Size(75, 23);
            btn_demo.TabIndex = 2;
            btn_demo.Text = "Demo";
            btn_demo.UseVisualStyleBackColor = true;
            btn_demo.Click += btn_demo_Click;
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.ControlLightLight;
            btn_login.ForeColor = SystemColors.ControlText;
            btn_login.Location = new Point(153, 502);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(181, 23);
            btn_login.TabIndex = 3;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(57, 115, 225);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(153, 455);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 4;
            label1.Text = "Password";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.BackColor = Color.FromArgb(57, 115, 225);
            Username.ForeColor = SystemColors.ButtonHighlight;
            Username.Location = new Point(153, 411);
            Username.Name = "Username";
            Username.Size = new Size(60, 15);
            Username.TabIndex = 5;
            Username.Text = "Username";
            // 
            // lbl_Demo
            // 
            lbl_Demo.AutoSize = true;
            lbl_Demo.BackColor = SystemColors.ActiveCaptionText;
            lbl_Demo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Demo.ForeColor = Color.Red;
            lbl_Demo.Location = new Point(123, 12);
            lbl_Demo.Name = "lbl_Demo";
            lbl_Demo.Size = new Size(262, 30);
            lbl_Demo.TabIndex = 6;
            lbl_Demo.Text = "---- DEMO ACTIVADA ----";
            lbl_Demo.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Demo.Visible = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.AdminTool;
            ClientSize = new Size(492, 604);
            Controls.Add(lbl_Demo);
            Controls.Add(Username);
            Controls.Add(label1);
            Controls.Add(btn_login);
            Controls.Add(btn_demo);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormLogin";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btn_demo;
        private Button btn_login;
        private Label label1;
        private Label Username;
        private Label lbl_Demo;
    }
}