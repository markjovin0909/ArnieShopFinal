namespace ArnieShopFinal
{
    partial class LogIn_Form
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn_Form));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Container = new Guna.UI2.WinForms.Guna2Panel();
            Unshow_Pass = new PictureBox();
            Show_Pass = new PictureBox();
            SignUp_LBL = new Label();
            label3 = new Label();
            LogIn_BTN = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            Password_TXT = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            Username_TXT = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Unshow_Pass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Show_Pass).BeginInit();
            SuspendLayout();
            // 
            // Container
            // 
            Container.BackColor = Color.FromArgb(52, 49, 49);
            Container.BorderColor = Color.Black;
            Container.BorderRadius = 10;
            Container.Controls.Add(Unshow_Pass);
            Container.Controls.Add(Show_Pass);
            Container.Controls.Add(SignUp_LBL);
            Container.Controls.Add(label3);
            Container.Controls.Add(LogIn_BTN);
            Container.Controls.Add(label2);
            Container.Controls.Add(Password_TXT);
            Container.Controls.Add(label1);
            Container.Controls.Add(Username_TXT);
            Container.Controls.Add(guna2HtmlLabel1);
            Container.CustomizableEdges = customizableEdges7;
            Container.ForeColor = Color.FromArgb(216, 162, 94);
            Container.Location = new Point(138, 34);
            Container.Name = "Container";
            Container.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Container.Size = new Size(381, 433);
            Container.TabIndex = 2;
            // 
            // Unshow_Pass
            // 
            Unshow_Pass.BackColor = Color.White;
            Unshow_Pass.Image = (Image)resources.GetObject("Unshow_Pass.Image");
            Unshow_Pass.Location = new Point(300, 250);
            Unshow_Pass.Name = "Unshow_Pass";
            Unshow_Pass.Size = new Size(37, 33);
            Unshow_Pass.TabIndex = 9;
            Unshow_Pass.TabStop = false;
            Unshow_Pass.Click += Unshow_Pass_Click;
            // 
            // Show_Pass
            // 
            Show_Pass.BackColor = Color.White;
            Show_Pass.Image = (Image)resources.GetObject("Show_Pass.Image");
            Show_Pass.Location = new Point(300, 250);
            Show_Pass.Name = "Show_Pass";
            Show_Pass.Size = new Size(37, 33);
            Show_Pass.TabIndex = 8;
            Show_Pass.TabStop = false;
            Show_Pass.Visible = false;
            Show_Pass.Click += Show_Pass_Click;
            // 
            // SignUp_LBL
            // 
            SignUp_LBL.AutoSize = true;
            SignUp_LBL.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            SignUp_LBL.ForeColor = Color.DodgerBlue;
            SignUp_LBL.Location = new Point(239, 387);
            SignUp_LBL.Name = "SignUp_LBL";
            SignUp_LBL.Size = new Size(54, 17);
            SignUp_LBL.TabIndex = 7;
            SignUp_LBL.Text = "Sign Up";
            SignUp_LBL.Click += SignUp_LBL_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(238, 223, 122);
            label3.Location = new Point(96, 389);
            label3.Name = "label3";
            label3.Size = new Size(146, 15);
            label3.TabIndex = 6;
            label3.Text = "Does'nt Have an Account?";
            // 
            // LogIn_BTN
            // 
            LogIn_BTN.BorderRadius = 5;
            LogIn_BTN.CustomizableEdges = customizableEdges1;
            LogIn_BTN.DisabledState.BorderColor = Color.DarkGray;
            LogIn_BTN.DisabledState.CustomBorderColor = Color.DarkGray;
            LogIn_BTN.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LogIn_BTN.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LogIn_BTN.FillColor = Color.FromArgb(160, 71, 71);
            LogIn_BTN.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogIn_BTN.ForeColor = Color.FromArgb(52, 49, 49);
            LogIn_BTN.Location = new Point(144, 323);
            LogIn_BTN.Name = "LogIn_BTN";
            LogIn_BTN.ShadowDecoration.CustomizableEdges = customizableEdges2;
            LogIn_BTN.Size = new Size(111, 35);
            LogIn_BTN.TabIndex = 5;
            LogIn_BTN.Text = "Log In";
            LogIn_BTN.Click += LogIn_BTN_Click;
            LogIn_BTN.Enter += LogIn_BTN_Enter;
            LogIn_BTN.Leave += LogIn_BTN_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(238, 223, 122);
            label2.Location = new Point(31, 209);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 4;
            label2.Text = "Password :";
            // 
            // Password_TXT
            // 
            Password_TXT.BorderRadius = 5;
            Password_TXT.BorderThickness = 0;
            Password_TXT.CustomizableEdges = customizableEdges3;
            Password_TXT.DefaultText = "";
            Password_TXT.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Password_TXT.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Password_TXT.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Password_TXT.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Password_TXT.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Password_TXT.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password_TXT.ForeColor = Color.FromArgb(52, 49, 49);
            Password_TXT.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Password_TXT.Location = new Point(31, 245);
            Password_TXT.Margin = new Padding(4);
            Password_TXT.Name = "Password_TXT";
            Password_TXT.PasswordChar = '*';
            Password_TXT.PlaceholderText = "";
            Password_TXT.SelectedText = "";
            Password_TXT.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Password_TXT.Size = new Size(313, 42);
            Password_TXT.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(238, 223, 122);
            label1.Location = new Point(31, 121);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 2;
            label1.Text = "Username :";
            // 
            // Username_TXT
            // 
            Username_TXT.BorderRadius = 5;
            Username_TXT.BorderThickness = 0;
            Username_TXT.CustomizableEdges = customizableEdges5;
            Username_TXT.DefaultText = "";
            Username_TXT.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Username_TXT.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Username_TXT.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Username_TXT.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Username_TXT.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Username_TXT.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username_TXT.ForeColor = Color.FromArgb(52, 49, 49);
            Username_TXT.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Username_TXT.Location = new Point(31, 157);
            Username_TXT.Margin = new Padding(4);
            Username_TXT.Name = "Username_TXT";
            Username_TXT.PasswordChar = '\0';
            Username_TXT.PlaceholderText = "";
            Username_TXT.SelectedText = "";
            Username_TXT.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Username_TXT.Size = new Size(313, 42);
            Username_TXT.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("High Tower Text", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(238, 223, 122);
            guna2HtmlLabel1.Location = new Point(134, 29);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(108, 46);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Log In";
            // 
            // LogIn_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(669, 494);
            Controls.Add(Container);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LogIn_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn_Form";
            Container.ResumeLayout(false);
            Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Unshow_Pass).EndInit();
            ((System.ComponentModel.ISupportInitialize)Show_Pass).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Container;
        private PictureBox Unshow_Pass;
        private PictureBox Show_Pass;
        private Label SignUp_LBL;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button LogIn_BTN;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox Password_TXT;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox Username_TXT;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}