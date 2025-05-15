namespace ArnieShopfinal
{
    partial class Shop_Form
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            displayProduct_Panel = new FlowLayoutPanel();
            Category_TXT = new Guna.UI2.WinForms.Guna2ComboBox();
            label5 = new Label();
            Search_TXT = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // displayProduct_Panel
            // 
            displayProduct_Panel.AutoScroll = true;
            displayProduct_Panel.BackColor = Color.FromArgb(255, 255, 192);
            displayProduct_Panel.Location = new Point(15, 77);
            displayProduct_Panel.Name = "displayProduct_Panel";
            displayProduct_Panel.Size = new Size(770, 429);
            displayProduct_Panel.TabIndex = 0;
            // 
            // Category_TXT
            // 
            Category_TXT.BackColor = Color.Transparent;
            Category_TXT.BorderRadius = 5;
            Category_TXT.CustomizableEdges = customizableEdges1;
            Category_TXT.DisplayMember = "1";
            Category_TXT.DrawMode = DrawMode.OwnerDrawFixed;
            Category_TXT.DropDownStyle = ComboBoxStyle.DropDownList;
            Category_TXT.FocusedColor = Color.FromArgb(94, 148, 255);
            Category_TXT.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Category_TXT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Category_TXT.ForeColor = Color.FromArgb(68, 88, 112);
            Category_TXT.ItemHeight = 30;
            Category_TXT.Location = new Point(513, 35);
            Category_TXT.Name = "Category_TXT";
            Category_TXT.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Category_TXT.Size = new Size(272, 36);
            Category_TXT.TabIndex = 16;
            Category_TXT.SelectionChangeCommitted += Category_TXT_SelectedIndexChangedCommitted;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(513, 12);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 15;
            label5.Text = "Category";
            // 
            // Search_TXT
            // 
            Search_TXT.BorderRadius = 5;
            Search_TXT.CustomizableEdges = customizableEdges3;
            Search_TXT.DefaultText = "";
            Search_TXT.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Search_TXT.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Search_TXT.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Search_TXT.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Search_TXT.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Search_TXT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Search_TXT.ForeColor = Color.Black;
            Search_TXT.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Search_TXT.Location = new Point(15, 35);
            Search_TXT.Margin = new Padding(4);
            Search_TXT.Name = "Search_TXT";
            Search_TXT.PasswordChar = '\0';
            Search_TXT.PlaceholderForeColor = Color.Gray;
            Search_TXT.PlaceholderText = "Search";
            Search_TXT.SelectedText = "";
            Search_TXT.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Search_TXT.Size = new Size(245, 31);
            Search_TXT.TabIndex = 17;
            Search_TXT.TextChanged += Search_TXT_TextChanged;
            // 
            // Shop_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 223, 122);
            Controls.Add(Search_TXT);
            Controls.Add(Category_TXT);
            Controls.Add(label5);
            Controls.Add(displayProduct_Panel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Shop_Form";
            Size = new Size(800, 520);
            Load += Shop_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel displayProduct_Panel;
        private Guna.UI2.WinForms.Guna2ComboBox Category_TXT;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox Search_TXT;
    }
}
