namespace ArnieShopFinal
{
    partial class ViewUserProduts_Form
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUserProduts_Form));
            Products_Display = new FlowLayoutPanel();
            panel2 = new Panel();
            Add_BTN = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            Exit_BTN = new PictureBox();
            Products_Display.SuspendLayout();
            panel2.SuspendLayout();
            guna2Panel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Exit_BTN).BeginInit();
            SuspendLayout();
            // 
            // Products_Display
            // 
            Products_Display.AutoScroll = true;
            Products_Display.BackColor = Color.FromArgb(255, 255, 128);
            Products_Display.Controls.Add(panel2);
            Products_Display.Controls.Add(guna2Panel1);
            Products_Display.Location = new Point(23, 59);
            Products_Display.Name = "Products_Display";
            Products_Display.Padding = new Padding(9);
            Products_Display.Size = new Size(945, 432);
            Products_Display.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 255, 128);
            panel2.Controls.Add(Add_BTN);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(905, 37);
            panel2.TabIndex = 2;
            // 
            // Add_BTN
            // 
            Add_BTN.BorderRadius = 5;
            Add_BTN.BorderThickness = 1;
            Add_BTN.CustomizableEdges = customizableEdges1;
            Add_BTN.DisabledState.BorderColor = Color.DarkGray;
            Add_BTN.DisabledState.CustomBorderColor = Color.DarkGray;
            Add_BTN.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Add_BTN.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Add_BTN.FillColor = Color.FromArgb(255, 255, 128);
            Add_BTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_BTN.ForeColor = Color.FromArgb(64, 64, 64);
            Add_BTN.Location = new Point(800, 3);
            Add_BTN.Name = "Add_BTN";
            Add_BTN.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Add_BTN.Size = new Size(102, 31);
            Add_BTN.TabIndex = 9;
            Add_BTN.Text = "New ";
            Add_BTN.Click += Add_BTN_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderColor = Color.Black;
            guna2Panel1.BorderThickness = 1;
            guna2Panel1.Controls.Add(label4);
            guna2Panel1.Controls.Add(label6);
            guna2Panel1.Controls.Add(label5);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Location = new Point(12, 55);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(905, 31);
            guna2Panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(527, 7);
            label4.Name = "label4";
            label4.Size = new Size(37, 17);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(747, 7);
            label6.Name = "label6";
            label6.Size = new Size(38, 17);
            label6.TabIndex = 2;
            label6.Text = "Sales";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(629, 7);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 2;
            label5.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(382, 7);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 2;
            label3.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(219, 7);
            label2.Name = "label2";
            label2.Size = new Size(76, 17);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 7);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 0;
            label1.Text = "Product";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(Exit_BTN);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(990, 36);
            panel1.TabIndex = 1;
            // 
            // Exit_BTN
            // 
            Exit_BTN.Image = (Image)resources.GetObject("Exit_BTN.Image");
            Exit_BTN.Location = new Point(950, 3);
            Exit_BTN.Name = "Exit_BTN";
            Exit_BTN.Size = new Size(37, 30);
            Exit_BTN.SizeMode = PictureBoxSizeMode.StretchImage;
            Exit_BTN.TabIndex = 0;
            Exit_BTN.TabStop = false;
            Exit_BTN.Click += Exit_BTN_Click;
            // 
            // ViewUserProduts_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(990, 514);
            Controls.Add(panel1);
            Controls.Add(Products_Display);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewUserProduts_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageProducts_Form";
            Load += ViewUserProduct_Form_Load;
            Products_Display.ResumeLayout(false);
            panel2.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Exit_BTN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel Products_Display;
        private Panel panel1;
        private PictureBox Exit_BTN;
        private Guna.UI2.WinForms.Guna2Button Add_BTN;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
    }
}