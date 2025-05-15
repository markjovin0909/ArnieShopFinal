using ArnieShopFinal.Repositories;
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
    public partial class Payment_Transaction : Form
    {
        public Payment_Transaction()
        {
            InitializeComponent();
        }

        private void PN_BTN_CheckedChanged(object sender, EventArgs e)
        {
            if (PN_BTN.Checked)
            {
                Payment_TXT.Enabled = true;
                CON_BTN.Checked = false;
            }
        }

        private void CON_BTN_CheckedChanged(object sender, EventArgs e)
        {
            if (CON_BTN.Checked)
            {
                Payment_TXT.Enabled = false;
                PN_BTN.Checked = false;
            }
        }

        private void Cancel_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Confirm_BTN_Click(object sender, EventArgs e)
        {
            OrdersRepository ordersRepository = new OrdersRepository();
            if (CON_BTN.Checked)
            {
                MessageBox.Show("Ordered Successfully!!!");
                //ordersRepository.SetValidatePayment(true);
                this.Hide();    
            }
            if (PN_BTN.Checked) 
            {
                if (int.Parse(Payment_TXT.Text) >= int.Parse(Total_LBL.Text))
                {
                    MessageBox.Show("Ordered Successfully!!! Change: " + int.Parse(Total_LBL.Text));
                    //ordersRepository.SetValidatePayment(true);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Insufficient Payment!!!!");
                    Payment_TXT.Clear();
                }
            }

        }

        public void setTotal(int Total)
        {
            Total_LBL.Text = Total.ToString();
        }
    }
}
