using ArnieShopfinal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArnieShopFinal
{
    public partial class Loading_Form : Form
    {
        public Loading_Form()
        {
            InitializeComponent();
        }

        private void Loading_Tick(object sender, EventArgs e)
        {
            loadingStatus.Width += 3;
            if (loadingStatus.Width > 348)
            {
                Loading.Stop();
                Main_Form main_Form = new Main_Form();
                main_Form.Show();

                this.Hide();
            }
        }
    }
}
