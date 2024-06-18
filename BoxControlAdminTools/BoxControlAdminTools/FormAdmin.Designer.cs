namespace BoxControlAdminTools
{
    partial class FormAdmin
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
            pan_left = new Panel();
            btn_Volver = new Button();
            pictureBox1 = new PictureBox();
            dgv_users = new DataGridView();
            lbl_Demo = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pan_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_users).BeginInit();
            SuspendLayout();
            // 
            // pan_left
            // 
            pan_left.BackColor = Color.FromArgb(57, 115, 225);
            pan_left.Controls.Add(button3);
            pan_left.Controls.Add(button2);
            pan_left.Controls.Add(button1);
            pan_left.Controls.Add(lbl_Demo);
            pan_left.Controls.Add(btn_Volver);
            pan_left.Controls.Add(pictureBox1);
            pan_left.Dock = DockStyle.Left;
            pan_left.Location = new Point(0, 0);
            pan_left.Name = "pan_left";
            pan_left.Size = new Size(200, 614);
            pan_left.TabIndex = 1;
            pan_left.TabStop = true;
            // 
            // btn_Volver
            // 
            btn_Volver.Location = new Point(30, 568);
            btn_Volver.Name = "btn_Volver";
            btn_Volver.Size = new Size(130, 34);
            btn_Volver.TabIndex = 2;
            btn_Volver.Text = "Volver";
            btn_Volver.UseVisualStyleBackColor = true;
            btn_Volver.Click += btn_Volver_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.FromArgb(57, 115, 225);
            pictureBox1.Image = Properties.Resources.OnlyAdmin;
            pictureBox1.Location = new Point(30, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 117);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dgv_users
            // 
            dgv_users.AllowUserToAddRows = false;
            dgv_users.AllowUserToDeleteRows = false;
            dgv_users.AllowUserToResizeColumns = false;
            dgv_users.AllowUserToResizeRows = false;
            dgv_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_users.Dock = DockStyle.Fill;
            dgv_users.Location = new Point(200, 0);
            dgv_users.MultiSelect = false;
            dgv_users.Name = "dgv_users";
            dgv_users.ReadOnly = true;
            dgv_users.Size = new Size(849, 614);
            dgv_users.TabIndex = 2;
            // 
            // lbl_Demo
            // 
            lbl_Demo.AutoSize = true;
            lbl_Demo.BackColor = SystemColors.ActiveCaptionText;
            lbl_Demo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Demo.ForeColor = Color.Red;
            lbl_Demo.Location = new Point(3, 146);
            lbl_Demo.Name = "lbl_Demo";
            lbl_Demo.Size = new Size(202, 30);
            lbl_Demo.TabIndex = 8;
            lbl_Demo.Text = "-DEMO ACTIVADA-";
            lbl_Demo.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Demo.Visible = false;
            lbl_Demo.Click += lbl_Demo_Click;
            // 
            // button1
            // 
            button1.Location = new Point(3, 194);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(3, 223);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(3, 252);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 11;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 614);
            Controls.Add(dgv_users);
            Controls.Add(pan_left);
            Name = "FormAdmin";
            Text = "AdminTool";
            Load += FormAdmin_Load;
            pan_left.ResumeLayout(false);
            pan_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_users).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pan_left;
        private PictureBox pictureBox1;
        private DataGridView dgv_users;
        private Label lbl_Demo;
        private Button btn_Volver;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}