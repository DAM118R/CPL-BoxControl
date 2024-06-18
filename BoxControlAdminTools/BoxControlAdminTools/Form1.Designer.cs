namespace BoxControlAdminTools
{
    partial class FormHub
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            lbl_Demo = new Label();
            btn_AdminTools = new Button();
            pictureBox1 = new PictureBox();
            btn_ProviderTool = new Button();
            btn_ClientTools = new Button();
            btn_EmployeeTools = new Button();
            btn_TaskTool = new Button();
            pan_left = new Panel();
            btn_Volver = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pan_left.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbl_Demo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 450);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(582, 201);
            dataGridView1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 50);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 8;
            label1.Text = "Tareas asignadas";
            // 
            // lbl_Demo
            // 
            lbl_Demo.AutoSize = true;
            lbl_Demo.BackColor = SystemColors.ActiveCaptionText;
            lbl_Demo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Demo.ForeColor = Color.Red;
            lbl_Demo.Location = new Point(3, 9);
            lbl_Demo.Name = "lbl_Demo";
            lbl_Demo.Size = new Size(262, 30);
            lbl_Demo.TabIndex = 7;
            lbl_Demo.Text = "---- DEMO ACTIVADA ----";
            lbl_Demo.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Demo.Visible = false;
            // 
            // btn_AdminTools
            // 
            btn_AdminTools.Anchor = AnchorStyles.None;
            btn_AdminTools.Location = new Point(12, 135);
            btn_AdminTools.Name = "btn_AdminTools";
            btn_AdminTools.Size = new Size(172, 29);
            btn_AdminTools.TabIndex = 0;
            btn_AdminTools.Text = "Admin";
            btn_AdminTools.UseVisualStyleBackColor = true;
            btn_AdminTools.Click += btn_AdminTools_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.FromArgb(57, 115, 225);
            pictureBox1.Image = Properties.Resources.OnlyAdmin;
            pictureBox1.Location = new Point(39, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 117);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btn_ProviderTool
            // 
            btn_ProviderTool.Anchor = AnchorStyles.None;
            btn_ProviderTool.Location = new Point(12, 240);
            btn_ProviderTool.Name = "btn_ProviderTool";
            btn_ProviderTool.Size = new Size(172, 29);
            btn_ProviderTool.TabIndex = 2;
            btn_ProviderTool.Text = "Logistica";
            btn_ProviderTool.UseVisualStyleBackColor = true;
            // 
            // btn_ClientTools
            // 
            btn_ClientTools.Anchor = AnchorStyles.None;
            btn_ClientTools.Location = new Point(12, 275);
            btn_ClientTools.Name = "btn_ClientTools";
            btn_ClientTools.Size = new Size(172, 29);
            btn_ClientTools.TabIndex = 3;
            btn_ClientTools.Text = "Cliente";
            btn_ClientTools.UseVisualStyleBackColor = true;
            btn_ClientTools.Click += btn_ClientTools_Click;
            // 
            // btn_EmployeeTools
            // 
            btn_EmployeeTools.Anchor = AnchorStyles.None;
            btn_EmployeeTools.Location = new Point(12, 170);
            btn_EmployeeTools.Name = "btn_EmployeeTools";
            btn_EmployeeTools.Size = new Size(172, 29);
            btn_EmployeeTools.TabIndex = 4;
            btn_EmployeeTools.Text = "Empleado";
            btn_EmployeeTools.UseVisualStyleBackColor = true;
            // 
            // btn_TaskTool
            // 
            btn_TaskTool.Anchor = AnchorStyles.None;
            btn_TaskTool.Location = new Point(12, 205);
            btn_TaskTool.Name = "btn_TaskTool";
            btn_TaskTool.Size = new Size(172, 29);
            btn_TaskTool.TabIndex = 5;
            btn_TaskTool.Text = "Tareas";
            btn_TaskTool.UseVisualStyleBackColor = true;
            // 
            // pan_left
            // 
            pan_left.BackColor = Color.FromArgb(57, 115, 225);
            pan_left.Controls.Add(btn_Volver);
            pan_left.Controls.Add(btn_TaskTool);
            pan_left.Controls.Add(btn_EmployeeTools);
            pan_left.Controls.Add(btn_ClientTools);
            pan_left.Controls.Add(btn_ProviderTool);
            pan_left.Controls.Add(pictureBox1);
            pan_left.Controls.Add(btn_AdminTools);
            pan_left.Dock = DockStyle.Left;
            pan_left.Location = new Point(0, 0);
            pan_left.Name = "pan_left";
            pan_left.Size = new Size(200, 450);
            pan_left.TabIndex = 0;
            pan_left.TabStop = true;
            pan_left.Paint += panel1_Paint;
            // 
            // btn_Volver
            // 
            btn_Volver.Location = new Point(12, 404);
            btn_Volver.Name = "btn_Volver";
            btn_Volver.Size = new Size(172, 34);
            btn_Volver.TabIndex = 6;
            btn_Volver.Text = "Cerrar sesion";
            btn_Volver.UseVisualStyleBackColor = true;
            btn_Volver.Click += btn_Volver_Click;
            // 
            // FormHub
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(pan_left);
            Name = "FormHub";
            Text = "Hub";
            Load += FormHub_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pan_left.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label lbl_Demo;
        private DataGridView dataGridView1;
        private Label label1;
        private Button btn_AdminTools;
        private PictureBox pictureBox1;
        private Button btn_ProviderTool;
        private Button btn_ClientTools;
        private Button btn_EmployeeTools;
        private Button btn_TaskTool;
        private Panel pan_left;
        private Button btn_Volver;
    }
}
