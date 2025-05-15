namespace ArnieShopfinal
{
    partial class Cart_Form
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart_Form));
            Cart_Container = new FlowLayoutPanel();
            Cart_LBL = new Label();
            BuyAll_BTN = new Guna.UI2.WinForms.Guna2Button();
            NotlogIn_Pic = new PictureBox();
            Total_LBL = new Label();
            total_tag_LBL = new Label();
            ((System.ComponentModel.ISupportInitialize)NotlogIn_Pic).BeginInit();
            SuspendLayout();
            // 
            // Cart_Container
            // 
            Cart_Container.AutoScroll = true;
            Cart_Container.BackColor = Color.FromArgb(52, 49, 49);
            Cart_Container.Location = new Point(29, 67);
            Cart_Container.Name = "Cart_Container";
            Cart_Container.Padding = new Padding(10);
            Cart_Container.Size = new Size(741, 374);
            Cart_Container.TabIndex = 0;
            Cart_Container.Visible = false;
            // 
            // Cart_LBL
            // 
            Cart_LBL.AutoSize = true;
            Cart_LBL.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cart_LBL.ForeColor = Color.FromArgb(52, 49, 49);
            Cart_LBL.Location = new Point(34, 27);
            Cart_LBL.Margin = new Padding(4, 0, 4, 0);
            Cart_LBL.Name = "Cart_LBL";
            Cart_LBL.Size = new Size(137, 37);
            Cart_LBL.TabIndex = 3;
            Cart_LBL.Text = "Your Cart";
            Cart_LBL.Visible = false;
            // 
            // BuyAll_BTN
            // 
            BuyAll_BTN.BackColor = Color.Transparent;
            BuyAll_BTN.BorderRadius = 5;
            BuyAll_BTN.CustomizableEdges = customizableEdges1;
            BuyAll_BTN.DisabledState.BorderColor = Color.DarkGray;
            BuyAll_BTN.DisabledState.CustomBorderColor = Color.DarkGray;
            BuyAll_BTN.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BuyAll_BTN.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BuyAll_BTN.FillColor = Color.FromArgb(52, 49, 49);
            BuyAll_BTN.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BuyAll_BTN.ForeColor = Color.White;
            BuyAll_BTN.Location = new Point(659, 460);
            BuyAll_BTN.Name = "BuyAll_BTN";
            BuyAll_BTN.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BuyAll_BTN.Size = new Size(111, 35);
            BuyAll_BTN.TabIndex = 23;
            BuyAll_BTN.Text = "Buy All";
            BuyAll_BTN.Visible = false;
            BuyAll_BTN.Click += BuyAll_BTN_Click;
            // 
            // NotlogIn_Pic
            // 
            NotlogIn_Pic.BackColor = Color.Transparent;
            NotlogIn_Pic.Image = (Image)resources.GetObject("NotlogIn_Pic.Image");
            NotlogIn_Pic.Location = new Point(240, 110);
            NotlogIn_Pic.Name = "NotlogIn_Pic";
            NotlogIn_Pic.Size = new Size(320, 300);
            NotlogIn_Pic.SizeMode = PictureBoxSizeMode.StretchImage;
            NotlogIn_Pic.TabIndex = 28;
            NotlogIn_Pic.TabStop = false;
            // 
            // Total_LBL
            // 
            Total_LBL.AutoSize = true;
            Total_LBL.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Total_LBL.Location = new Point(516, 470);
            Total_LBL.Name = "Total_LBL";
            Total_LBL.Size = new Size(81, 37);
            Total_LBL.TabIndex = 20;
            Total_LBL.Text = "Price";
            Total_LBL.TextAlign = ContentAlignment.MiddleCenter;
            Total_LBL.Visible = false;
            // 
            // total_tag_LBL
            // 
            total_tag_LBL.AutoSize = true;
            total_tag_LBL.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total_tag_LBL.ForeColor = Color.FromArgb(64, 64, 64);
            total_tag_LBL.Location = new Point(516, 445);
            total_tag_LBL.Name = "total_tag_LBL";
            total_tag_LBL.Size = new Size(58, 25);
            total_tag_LBL.TabIndex = 19;
            total_tag_LBL.Text = "Total ";
            total_tag_LBL.TextAlign = ContentAlignment.MiddleCenter;
            total_tag_LBL.Visible = false;
            // 
            // Cart_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            Controls.Add(Total_LBL);
            Controls.Add(Cart_Container);
            Controls.Add(total_tag_LBL);
            Controls.Add(BuyAll_BTN);
            Controls.Add(Cart_LBL);
            Controls.Add(NotlogIn_Pic);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Cart_Form";
            Size = new Size(800, 520);
            Load += Cart_Form_Load;
            ((System.ComponentModel.ISupportInitialize)NotlogIn_Pic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel Cart_Container;
        private Label Cart_LBL;
        private Guna.UI2.WinForms.Guna2Button BuyAll_BTN;
        private PictureBox NotlogIn_Pic;
        private Label Total_LBL;
        private Label total_tag_LBL;
    }
}
