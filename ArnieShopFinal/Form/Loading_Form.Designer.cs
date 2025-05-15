namespace ArnieShopFinal
{
    partial class Loading_Form
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading_Form));
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            loadingStatus = new Guna.UI2.WinForms.Guna2Panel();
            Loading = new System.Windows.Forms.Timer(components);
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.Transparent;
            guna2Panel2.BorderColor = Color.Black;
            guna2Panel2.BorderRadius = 1;
            guna2Panel2.BorderThickness = 1;
            guna2Panel2.Controls.Add(loadingStatus);
            guna2Panel2.CustomizableEdges = customizableEdges3;
            guna2Panel2.Location = new Point(191, 425);
            guna2Panel2.Margin = new Padding(4, 3, 4, 3);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel2.Size = new Size(406, 18);
            guna2Panel2.TabIndex = 1;
            // 
            // loadingStatus
            // 
            loadingStatus.BackColor = Color.Maroon;
            loadingStatus.BorderColor = Color.Black;
            loadingStatus.BorderRadius = 1;
            loadingStatus.BorderThickness = 1;
            loadingStatus.CustomizableEdges = customizableEdges1;
            loadingStatus.Location = new Point(1, 0);
            loadingStatus.Margin = new Padding(4, 3, 4, 3);
            loadingStatus.Name = "loadingStatus";
            loadingStatus.ShadowDecoration.CustomizableEdges = customizableEdges2;
            loadingStatus.Size = new Size(102, 18);
            loadingStatus.TabIndex = 2;
            // 
            // Loading
            // 
            Loading.Enabled = true;
            Loading.Interval = 10;
            Loading.Tick += Loading_Tick;
            // 
            // Loading_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(755, 449);
            Controls.Add(guna2Panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Loading_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            guna2Panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel loadingStatus;
        private System.Windows.Forms.Timer Loading;
    }
}

