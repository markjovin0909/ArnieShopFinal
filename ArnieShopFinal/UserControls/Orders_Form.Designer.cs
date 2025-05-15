namespace ArnieShopFinal.UserControls
{
    partial class Orders_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders_Form));
            Orders_Container = new FlowLayoutPanel();
            Orders_LBL = new Label();
            NotlogIn_Pic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)NotlogIn_Pic).BeginInit();
            SuspendLayout();
            // 
            // Orders_Container
            // 
            Orders_Container.AutoScroll = true;
            Orders_Container.BackColor = Color.FromArgb(255, 255, 192);
            Orders_Container.Location = new Point(35, 68);
            Orders_Container.Name = "Orders_Container";
            Orders_Container.Padding = new Padding(10);
            Orders_Container.Size = new Size(730, 397);
            Orders_Container.TabIndex = 1;
            Orders_Container.Visible = false;
            // 
            // Orders_LBL
            // 
            Orders_LBL.AutoSize = true;
            Orders_LBL.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Orders_LBL.ForeColor = Color.FromArgb(52, 49, 49);
            Orders_LBL.Location = new Point(35, 28);
            Orders_LBL.Margin = new Padding(4, 0, 4, 0);
            Orders_LBL.Name = "Orders_LBL";
            Orders_LBL.Size = new Size(168, 37);
            Orders_LBL.TabIndex = 25;
            Orders_LBL.Text = "Your Orders";
            Orders_LBL.Visible = false;
            // 
            // NotlogIn_Pic
            // 
            NotlogIn_Pic.BackColor = Color.Transparent;
            NotlogIn_Pic.Image = (Image)resources.GetObject("NotlogIn_Pic.Image");
            NotlogIn_Pic.Location = new Point(240, 112);
            NotlogIn_Pic.Name = "NotlogIn_Pic";
            NotlogIn_Pic.Size = new Size(320, 300);
            NotlogIn_Pic.SizeMode = PictureBoxSizeMode.StretchImage;
            NotlogIn_Pic.TabIndex = 27;
            NotlogIn_Pic.TabStop = false;
            // 
            // Orders_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            Controls.Add(Orders_LBL);
            Controls.Add(Orders_Container);
            Controls.Add(NotlogIn_Pic);
            Name = "Orders_Form";
            Size = new Size(800, 520);
            Load += Orders_Form_Load;
            ((System.ComponentModel.ISupportInitialize)NotlogIn_Pic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel Orders_Container;
        private Label Orders_LBL;
        private PictureBox NotlogIn_Pic;
    }
}
