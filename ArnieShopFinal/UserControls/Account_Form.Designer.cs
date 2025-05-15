namespace ArnieShopfinal
{
    partial class Account_Form
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account_Form));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ManageProducts_BTN = new Label();
            NotlogIn_Pic = new PictureBox();
            LogOut_BTN = new Guna.UI2.WinForms.Guna2Button();
            BasicInfo_LBL = new Label();
            Name_LBL = new Label();
            LoggedIn_Pic = new PictureBox();
            NotlogINWarning_LBL = new Label();
            LogIn_LBL = new Label();
            BasicInfo_Panel = new Panel();
            Role_LBL = new Label();
            label1 = new Label();
            Adress_LBL = new Label();
            Email_LBL = new Label();
            Contact_LBL = new Label();
            Fullname_LBL = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NotlogIn_Pic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LoggedIn_Pic).BeginInit();
            BasicInfo_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(238, 223, 122);
            guna2Panel1.Controls.Add(ManageProducts_BTN);
            guna2Panel1.Controls.Add(NotlogIn_Pic);
            guna2Panel1.Controls.Add(LogOut_BTN);
            guna2Panel1.Controls.Add(BasicInfo_LBL);
            guna2Panel1.Controls.Add(Name_LBL);
            guna2Panel1.Controls.Add(LoggedIn_Pic);
            guna2Panel1.Controls.Add(NotlogINWarning_LBL);
            guna2Panel1.Controls.Add(LogIn_LBL);
            guna2Panel1.Controls.Add(BasicInfo_Panel);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Location = new Point(86, 26);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(620, 468);
            guna2Panel1.TabIndex = 0;
            // 
            // ManageProducts_BTN
            // 
            ManageProducts_BTN.AutoSize = true;
            ManageProducts_BTN.Font = new Font("Segoe UI", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            ManageProducts_BTN.ForeColor = Color.Blue;
            ManageProducts_BTN.Location = new Point(49, 415);
            ManageProducts_BTN.Name = "ManageProducts_BTN";
            ManageProducts_BTN.Size = new Size(200, 32);
            ManageProducts_BTN.TabIndex = 7;
            ManageProducts_BTN.Text = "Manage Products";
            ManageProducts_BTN.Visible = false;
            ManageProducts_BTN.Click += ManageProducts_BTN_Click;
            // 
            // NotlogIn_Pic
            // 
            NotlogIn_Pic.BackColor = Color.Transparent;
            NotlogIn_Pic.Image = (Image)resources.GetObject("NotlogIn_Pic.Image");
            NotlogIn_Pic.Location = new Point(202, 70);
            NotlogIn_Pic.Name = "NotlogIn_Pic";
            NotlogIn_Pic.Size = new Size(220, 200);
            NotlogIn_Pic.SizeMode = PictureBoxSizeMode.StretchImage;
            NotlogIn_Pic.TabIndex = 5;
            NotlogIn_Pic.TabStop = false;
            // 
            // LogOut_BTN
            // 
            LogOut_BTN.BorderColor = Color.FromArgb(192, 0, 0);
            LogOut_BTN.BorderRadius = 5;
            LogOut_BTN.BorderThickness = 1;
            LogOut_BTN.CustomizableEdges = customizableEdges1;
            LogOut_BTN.DisabledState.BorderColor = Color.DarkGray;
            LogOut_BTN.DisabledState.CustomBorderColor = Color.DarkGray;
            LogOut_BTN.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LogOut_BTN.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LogOut_BTN.FillColor = Color.Transparent;
            LogOut_BTN.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOut_BTN.ForeColor = Color.Black;
            LogOut_BTN.Location = new Point(459, 413);
            LogOut_BTN.Name = "LogOut_BTN";
            LogOut_BTN.ShadowDecoration.CustomizableEdges = customizableEdges2;
            LogOut_BTN.Size = new Size(119, 34);
            LogOut_BTN.TabIndex = 6;
            LogOut_BTN.Text = "Log Out";
            LogOut_BTN.Click += LogOut_BTN_Click;
            // 
            // BasicInfo_LBL
            // 
            BasicInfo_LBL.AutoSize = true;
            BasicInfo_LBL.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BasicInfo_LBL.Location = new Point(49, 159);
            BasicInfo_LBL.Name = "BasicInfo_LBL";
            BasicInfo_LBL.Size = new Size(169, 25);
            BasicInfo_LBL.TabIndex = 3;
            BasicInfo_LBL.Text = "Basic Information";
            BasicInfo_LBL.Visible = false;
            // 
            // Name_LBL
            // 
            Name_LBL.AutoSize = true;
            Name_LBL.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name_LBL.Location = new Point(237, 70);
            Name_LBL.Name = "Name_LBL";
            Name_LBL.Size = new Size(81, 32);
            Name_LBL.TabIndex = 2;
            Name_LBL.Text = "Name";
            Name_LBL.Visible = false;
            // 
            // LoggedIn_Pic
            // 
            LoggedIn_Pic.BackColor = Color.Transparent;
            LoggedIn_Pic.Image = (Image)resources.GetObject("LoggedIn_Pic.Image");
            LoggedIn_Pic.Location = new Point(111, 34);
            LoggedIn_Pic.Name = "LoggedIn_Pic";
            LoggedIn_Pic.Size = new Size(120, 100);
            LoggedIn_Pic.SizeMode = PictureBoxSizeMode.StretchImage;
            LoggedIn_Pic.TabIndex = 1;
            LoggedIn_Pic.TabStop = false;
            LoggedIn_Pic.Visible = false;
            // 
            // NotlogINWarning_LBL
            // 
            NotlogINWarning_LBL.AutoSize = true;
            NotlogINWarning_LBL.BackColor = Color.Transparent;
            NotlogINWarning_LBL.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NotlogINWarning_LBL.ForeColor = Color.Red;
            NotlogINWarning_LBL.Location = new Point(180, 292);
            NotlogINWarning_LBL.Name = "NotlogINWarning_LBL";
            NotlogINWarning_LBL.Size = new Size(257, 32);
            NotlogINWarning_LBL.TabIndex = 4;
            NotlogINWarning_LBL.Text = "You Are Not Logged In";
            // 
            // LogIn_LBL
            // 
            LogIn_LBL.AutoSize = true;
            LogIn_LBL.Font = new Font("Segoe UI", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            LogIn_LBL.ForeColor = Color.Blue;
            LogIn_LBL.Location = new Point(241, 342);
            LogIn_LBL.Name = "LogIn_LBL";
            LogIn_LBL.Size = new Size(138, 32);
            LogIn_LBL.TabIndex = 5;
            LogIn_LBL.Text = "Log In Here";
            LogIn_LBL.Click += LogIn_LBL_Click;
            // 
            // BasicInfo_Panel
            // 
            BasicInfo_Panel.BorderStyle = BorderStyle.FixedSingle;
            BasicInfo_Panel.Controls.Add(Role_LBL);
            BasicInfo_Panel.Controls.Add(label1);
            BasicInfo_Panel.Controls.Add(Adress_LBL);
            BasicInfo_Panel.Controls.Add(Email_LBL);
            BasicInfo_Panel.Controls.Add(Contact_LBL);
            BasicInfo_Panel.Controls.Add(Fullname_LBL);
            BasicInfo_Panel.Controls.Add(label5);
            BasicInfo_Panel.Controls.Add(label4);
            BasicInfo_Panel.Controls.Add(label3);
            BasicInfo_Panel.Controls.Add(label2);
            BasicInfo_Panel.Location = new Point(49, 187);
            BasicInfo_Panel.Name = "BasicInfo_Panel";
            BasicInfo_Panel.Size = new Size(529, 199);
            BasicInfo_Panel.TabIndex = 0;
            BasicInfo_Panel.Visible = false;
            // 
            // Role_LBL
            // 
            Role_LBL.AutoSize = true;
            Role_LBL.Font = new Font("Segoe UI", 9.75F);
            Role_LBL.Location = new Point(103, 166);
            Role_LBL.Name = "Role_LBL";
            Role_LBL.Size = new Size(34, 17);
            Role_LBL.TabIndex = 13;
            Role_LBL.Text = "Role";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 166);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 12;
            label1.Text = "Role :";
            // 
            // Adress_LBL
            // 
            Adress_LBL.AutoSize = true;
            Adress_LBL.Font = new Font("Segoe UI", 9.75F);
            Adress_LBL.Location = new Point(103, 128);
            Adress_LBL.Name = "Adress_LBL";
            Adress_LBL.Size = new Size(56, 17);
            Adress_LBL.TabIndex = 11;
            Adress_LBL.Text = "Address";
            // 
            // Email_LBL
            // 
            Email_LBL.AutoSize = true;
            Email_LBL.Font = new Font("Segoe UI", 9.75F);
            Email_LBL.Location = new Point(103, 90);
            Email_LBL.Name = "Email_LBL";
            Email_LBL.Size = new Size(39, 17);
            Email_LBL.TabIndex = 10;
            Email_LBL.Text = "Email";
            // 
            // Contact_LBL
            // 
            Contact_LBL.AutoSize = true;
            Contact_LBL.Font = new Font("Segoe UI", 9.75F);
            Contact_LBL.Location = new Point(103, 54);
            Contact_LBL.Name = "Contact_LBL";
            Contact_LBL.Size = new Size(71, 17);
            Contact_LBL.TabIndex = 9;
            Contact_LBL.Text = "Contact no";
            // 
            // Fullname_LBL
            // 
            Fullname_LBL.AutoSize = true;
            Fullname_LBL.Font = new Font("Segoe UI", 9.75F);
            Fullname_LBL.Location = new Point(103, 15);
            Fullname_LBL.Name = "Fullname_LBL";
            Fullname_LBL.Size = new Size(66, 17);
            Fullname_LBL.TabIndex = 8;
            Fullname_LBL.Text = "Full Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 128);
            label5.Name = "label5";
            label5.Size = new Size(65, 17);
            label5.TabIndex = 7;
            label5.Text = "Address :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 90);
            label4.Name = "label4";
            label4.Size = new Size(50, 17);
            label4.TabIndex = 6;
            label4.Text = "Email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 54);
            label3.Name = "label3";
            label3.Size = new Size(83, 17);
            label3.TabIndex = 5;
            label3.Text = "Contact no :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 15);
            label2.Name = "label2";
            label2.Size = new Size(79, 17);
            label2.TabIndex = 4;
            label2.Text = "Full Name :";
            // 
            // Account_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(guna2Panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Account_Form";
            Size = new Size(800, 520);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NotlogIn_Pic).EndInit();
            ((System.ComponentModel.ISupportInitialize)LoggedIn_Pic).EndInit();
            BasicInfo_Panel.ResumeLayout(false);
            BasicInfo_Panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Panel BasicInfo_Panel;
        private PictureBox LoggedIn_Pic;
        private Label BasicInfo_LBL;
        private Label Name_LBL;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label Adress_LBL;
        private Label Email_LBL;
        private Label Contact_LBL;
        private Label Fullname_LBL;
        private Label NotlogINWarning_LBL;
        private Label LogIn_LBL;
        private PictureBox NotlogIn_Pic;
        private Guna.UI2.WinForms.Guna2Button LogOut_BTN;
        private Label Role_LBL;
        private Label label1;
        private Label ManageProducts_BTN;
    }
}
