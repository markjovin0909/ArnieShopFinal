namespace ArnieShopfinal
{
    partial class Main_Form
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            pictureBox1 = new PictureBox();
            Close_BTN = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            Order_BTN = new Button();
            Account_BTN = new Button();
            Cart_BTN = new Button();
            Shop_BTN = new Button();
            Hover = new System.Windows.Forms.Timer(components);
            Display_Panel = new Panel();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(52, 49, 49);
            guna2Panel1.Controls.Add(pictureBox1);
            guna2Panel1.Controls.Add(Close_BTN);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Margin = new Padding(4, 3, 4, 3);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(1030, 46);
            guna2Panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Close_BTN
            // 
            Close_BTN.BackgroundImage = (Image)resources.GetObject("Close_BTN.BackgroundImage");
            Close_BTN.BackgroundImageLayout = ImageLayout.Stretch;
            Close_BTN.BorderColor = Color.Transparent;
            Close_BTN.BorderThickness = 1;
            Close_BTN.CustomizableEdges = customizableEdges1;
            Close_BTN.DisabledState.BorderColor = Color.DarkGray;
            Close_BTN.DisabledState.CustomBorderColor = Color.DarkGray;
            Close_BTN.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Close_BTN.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Close_BTN.FillColor = Color.Transparent;
            Close_BTN.Font = new Font("Segoe UI", 9F);
            Close_BTN.ForeColor = Color.White;
            Close_BTN.Location = new Point(982, 3);
            Close_BTN.Margin = new Padding(4, 3, 4, 3);
            Close_BTN.Name = "Close_BTN";
            Close_BTN.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Close_BTN.Size = new Size(44, 39);
            Close_BTN.TabIndex = 0;
            Close_BTN.Click += Close_BTN_Click;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.FromArgb(216, 162, 94);
            guna2Panel2.Controls.Add(Order_BTN);
            guna2Panel2.Controls.Add(Account_BTN);
            guna2Panel2.Controls.Add(Cart_BTN);
            guna2Panel2.Controls.Add(Shop_BTN);
            guna2Panel2.CustomizableEdges = customizableEdges5;
            guna2Panel2.Dock = DockStyle.Left;
            guna2Panel2.ForeColor = SystemColors.ActiveCaptionText;
            guna2Panel2.Location = new Point(0, 46);
            guna2Panel2.Margin = new Padding(4, 3, 4, 3);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel2.Size = new Size(230, 520);
            guna2Panel2.TabIndex = 1;
            // 
            // Order_BTN
            // 
            Order_BTN.BackColor = Color.Transparent;
            Order_BTN.FlatAppearance.BorderSize = 0;
            Order_BTN.FlatStyle = FlatStyle.Flat;
            Order_BTN.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Order_BTN.ForeColor = Color.FromArgb(52, 49, 49);
            Order_BTN.Image = (Image)resources.GetObject("Order_BTN.Image");
            Order_BTN.ImageAlign = ContentAlignment.MiddleLeft;
            Order_BTN.Location = new Point(0, 116);
            Order_BTN.Margin = new Padding(4, 3, 4, 3);
            Order_BTN.Name = "Order_BTN";
            Order_BTN.Size = new Size(230, 55);
            Order_BTN.TabIndex = 6;
            Order_BTN.Text = "Orders";
            Order_BTN.TextImageRelation = TextImageRelation.ImageBeforeText;
            Order_BTN.UseVisualStyleBackColor = false;
            Order_BTN.Click += Order_BTN_Click;
            Order_BTN.Enter += Order_BTN_Enter;
            Order_BTN.Leave += Order_BTN_Leave;
            // 
            // Account_BTN
            // 
            Account_BTN.BackColor = Color.Transparent;
            Account_BTN.FlatAppearance.BorderSize = 0;
            Account_BTN.FlatStyle = FlatStyle.Flat;
            Account_BTN.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Account_BTN.ForeColor = Color.FromArgb(52, 49, 49);
            Account_BTN.Image = (Image)resources.GetObject("Account_BTN.Image");
            Account_BTN.ImageAlign = ContentAlignment.MiddleLeft;
            Account_BTN.Location = new Point(0, 226);
            Account_BTN.Margin = new Padding(4, 3, 4, 3);
            Account_BTN.Name = "Account_BTN";
            Account_BTN.Size = new Size(230, 55);
            Account_BTN.TabIndex = 4;
            Account_BTN.Text = "Account";
            Account_BTN.TextImageRelation = TextImageRelation.ImageBeforeText;
            Account_BTN.UseVisualStyleBackColor = false;
            Account_BTN.Click += Account_BTN_Click;
            Account_BTN.Enter += Account_BTN_Enter;
            Account_BTN.Leave += Account_BTN_Leave;
            // 
            // Cart_BTN
            // 
            Cart_BTN.BackColor = Color.Transparent;
            Cart_BTN.FlatAppearance.BorderSize = 0;
            Cart_BTN.FlatStyle = FlatStyle.Flat;
            Cart_BTN.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cart_BTN.ForeColor = Color.FromArgb(52, 49, 49);
            Cart_BTN.Image = (Image)resources.GetObject("Cart_BTN.Image");
            Cart_BTN.ImageAlign = ContentAlignment.MiddleLeft;
            Cart_BTN.Location = new Point(0, 171);
            Cart_BTN.Margin = new Padding(4, 3, 4, 3);
            Cart_BTN.Name = "Cart_BTN";
            Cart_BTN.Size = new Size(230, 55);
            Cart_BTN.TabIndex = 3;
            Cart_BTN.Text = "Cart";
            Cart_BTN.TextImageRelation = TextImageRelation.ImageBeforeText;
            Cart_BTN.UseVisualStyleBackColor = false;
            Cart_BTN.Click += Cart_BTN_Click;
            Cart_BTN.Enter += Cart_BTN_Enter;
            Cart_BTN.Leave += Cart_BTN_Leave;
            // 
            // Shop_BTN
            // 
            Shop_BTN.BackColor = Color.Transparent;
            Shop_BTN.FlatAppearance.BorderSize = 0;
            Shop_BTN.FlatStyle = FlatStyle.Flat;
            Shop_BTN.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Shop_BTN.ForeColor = Color.FromArgb(52, 49, 49);
            Shop_BTN.Image = (Image)resources.GetObject("Shop_BTN.Image");
            Shop_BTN.ImageAlign = ContentAlignment.MiddleLeft;
            Shop_BTN.Location = new Point(0, 61);
            Shop_BTN.Margin = new Padding(4, 3, 4, 3);
            Shop_BTN.Name = "Shop_BTN";
            Shop_BTN.Size = new Size(230, 55);
            Shop_BTN.TabIndex = 2;
            Shop_BTN.Text = "Shop";
            Shop_BTN.TextImageRelation = TextImageRelation.ImageBeforeText;
            Shop_BTN.UseVisualStyleBackColor = false;
            Shop_BTN.Click += Shop_BTN_Click;
            Shop_BTN.Enter += Shop_BTN_Enter;
            Shop_BTN.Leave += Shop_BTN_Leave;
            // 
            // Hover
            // 
            Hover.Interval = 10;
            // 
            // Display_Panel
            // 
            Display_Panel.Dock = DockStyle.Left;
            Display_Panel.Location = new Point(230, 46);
            Display_Panel.Margin = new Padding(4, 3, 4, 3);
            Display_Panel.Name = "Display_Panel";
            Display_Panel.Size = new Size(800, 520);
            Display_Panel.TabIndex = 3;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 566);
            Controls.Add(Display_Panel);
            Controls.Add(guna2Panel2);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Main_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main_Form";
            guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2Panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button Close_BTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Button Shop_BTN;
        private System.Windows.Forms.Button Account_BTN;
        private System.Windows.Forms.Button Cart_BTN;
        private System.Windows.Forms.Timer Hover;
        private System.Windows.Forms.Panel Display_Panel;
        private Button Order_BTN;
    }
}