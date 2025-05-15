namespace ArnieShopFinal
{
    partial class Payment_Transaction
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            Cancel_BTN = new Guna.UI2.WinForms.Guna2Button();
            Confirm_BTN = new Guna.UI2.WinForms.Guna2Button();
            Total_LBL = new Label();
            total_tag_LBL = new Label();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            Payment_TXT = new Guna.UI2.WinForms.Guna2TextBox();
            CON_BTN = new RadioButton();
            PN_BTN = new RadioButton();
            label1 = new Label();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(255, 255, 128);
            guna2Panel1.BorderColor = Color.Black;
            guna2Panel1.BorderThickness = 1;
            guna2Panel1.Controls.Add(Cancel_BTN);
            guna2Panel1.Controls.Add(Confirm_BTN);
            guna2Panel1.Controls.Add(Total_LBL);
            guna2Panel1.Controls.Add(total_tag_LBL);
            guna2Panel1.Controls.Add(guna2Panel2);
            guna2Panel1.CustomizableEdges = customizableEdges9;
            guna2Panel1.Location = new Point(40, 46);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Panel1.Size = new Size(424, 394);
            guna2Panel1.TabIndex = 0;
            // 
            // Cancel_BTN
            // 
            Cancel_BTN.BorderRadius = 10;
            Cancel_BTN.CustomizableEdges = customizableEdges1;
            Cancel_BTN.DisabledState.BorderColor = Color.DarkGray;
            Cancel_BTN.DisabledState.CustomBorderColor = Color.DarkGray;
            Cancel_BTN.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Cancel_BTN.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Cancel_BTN.FillColor = Color.FromArgb(64, 64, 64);
            Cancel_BTN.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancel_BTN.ForeColor = Color.White;
            Cancel_BTN.Location = new Point(41, 337);
            Cancel_BTN.Name = "Cancel_BTN";
            Cancel_BTN.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Cancel_BTN.Size = new Size(102, 32);
            Cancel_BTN.TabIndex = 28;
            Cancel_BTN.Text = "Cancel";
            Cancel_BTN.Click += Cancel_BTN_Click;
            // 
            // Confirm_BTN
            // 
            Confirm_BTN.BorderRadius = 10;
            Confirm_BTN.CustomizableEdges = customizableEdges3;
            Confirm_BTN.DisabledState.BorderColor = Color.DarkGray;
            Confirm_BTN.DisabledState.CustomBorderColor = Color.DarkGray;
            Confirm_BTN.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Confirm_BTN.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Confirm_BTN.FillColor = Color.FromArgb(64, 64, 64);
            Confirm_BTN.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Confirm_BTN.ForeColor = Color.White;
            Confirm_BTN.Location = new Point(281, 337);
            Confirm_BTN.Name = "Confirm_BTN";
            Confirm_BTN.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Confirm_BTN.Size = new Size(102, 32);
            Confirm_BTN.TabIndex = 14;
            Confirm_BTN.Text = "Confirm";
            Confirm_BTN.Click += Confirm_BTN_Click;
            // 
            // Total_LBL
            // 
            Total_LBL.AutoSize = true;
            Total_LBL.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Total_LBL.Location = new Point(68, 71);
            Total_LBL.Name = "Total_LBL";
            Total_LBL.Size = new Size(81, 37);
            Total_LBL.TabIndex = 22;
            Total_LBL.Text = "Price";
            Total_LBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // total_tag_LBL
            // 
            total_tag_LBL.AutoSize = true;
            total_tag_LBL.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total_tag_LBL.ForeColor = Color.FromArgb(64, 64, 64);
            total_tag_LBL.Location = new Point(68, 46);
            total_tag_LBL.Name = "total_tag_LBL";
            total_tag_LBL.Size = new Size(58, 25);
            total_tag_LBL.TabIndex = 21;
            total_tag_LBL.Text = "Total ";
            total_tag_LBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.FromArgb(255, 255, 128);
            guna2Panel2.BorderColor = Color.Black;
            guna2Panel2.BorderThickness = 1;
            guna2Panel2.Controls.Add(Payment_TXT);
            guna2Panel2.Controls.Add(CON_BTN);
            guna2Panel2.Controls.Add(PN_BTN);
            guna2Panel2.Controls.Add(label1);
            guna2Panel2.CustomizableEdges = customizableEdges7;
            guna2Panel2.Location = new Point(41, 148);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel2.Size = new Size(342, 168);
            guna2Panel2.TabIndex = 27;
            // 
            // Payment_TXT
            // 
            Payment_TXT.BorderColor = Color.Transparent;
            Payment_TXT.BorderRadius = 5;
            Payment_TXT.CustomizableEdges = customizableEdges5;
            Payment_TXT.DefaultText = "";
            Payment_TXT.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Payment_TXT.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Payment_TXT.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Payment_TXT.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Payment_TXT.Enabled = false;
            Payment_TXT.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Payment_TXT.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Payment_TXT.ForeColor = Color.Black;
            Payment_TXT.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Payment_TXT.Location = new Point(73, 126);
            Payment_TXT.Name = "Payment_TXT";
            Payment_TXT.PasswordChar = '\0';
            Payment_TXT.PlaceholderForeColor = Color.Gray;
            Payment_TXT.PlaceholderText = "Enter Payment";
            Payment_TXT.SelectedText = "";
            Payment_TXT.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Payment_TXT.Size = new Size(183, 29);
            Payment_TXT.TabIndex = 28;
            // 
            // CON_BTN
            // 
            CON_BTN.AutoSize = true;
            CON_BTN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CON_BTN.Location = new Point(53, 51);
            CON_BTN.Name = "CON_BTN";
            CON_BTN.Size = new Size(145, 25);
            CON_BTN.TabIndex = 26;
            CON_BTN.TabStop = true;
            CON_BTN.Text = "Cash on Delivery";
            CON_BTN.UseVisualStyleBackColor = true;
            CON_BTN.CheckedChanged += CON_BTN_CheckedChanged;
            // 
            // PN_BTN
            // 
            PN_BTN.AutoSize = true;
            PN_BTN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PN_BTN.Location = new Point(53, 88);
            PN_BTN.Name = "PN_BTN";
            PN_BTN.Size = new Size(89, 25);
            PN_BTN.TabIndex = 25;
            PN_BTN.TabStop = true;
            PN_BTN.Text = "Pay Now";
            PN_BTN.UseVisualStyleBackColor = true;
            PN_BTN.CheckedChanged += PN_BTN_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 12);
            label1.Name = "label1";
            label1.Size = new Size(193, 21);
            label1.TabIndex = 3;
            label1.Text = "Select Payment Method :\r\n";
            // 
            // Payment_Transaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(507, 480);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Payment_Transaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment_Transaction";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label1;
        private Label Total_LBL;
        private Label total_tag_LBL;
        private RadioButton PN_BTN;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private RadioButton CON_BTN;
        private Guna.UI2.WinForms.Guna2TextBox Payment_TXT;
        private Guna.UI2.WinForms.Guna2Button Cancel_BTN;
        private Guna.UI2.WinForms.Guna2Button Confirm_BTN;
    }
}