using ArnieShopFinal.Repositories;
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
using ArnieShopFinal.Models;

namespace ArnieShopFinal
{
    public partial class LogIn_Form : Form
    {
        Main_Form main_Form = new Main_Form();
        CartRepository cartRepository = new CartRepository();
        OrdersRepository ordersRepository = new OrdersRepository();
        public LogIn_Form()
        {
            InitializeComponent();
        }

        private void LogIn_BTN_Click(object sender, EventArgs e)
        {
            UserRepository userRepository = new UserRepository();
            userRepository.CheckUser(Username_TXT.Text, Password_TXT.Text);
            Customer_Repository customer_Repository = new Customer_Repository();
            customer_Repository.CheckUser(Username_TXT.Text, Password_TXT.Text);

            if (UserRepository._user != null)
            {
                MessageBox.Show("Log In Successfully!!!!!");
                this.Hide();
                main_Form.AccountReload();
            }
            else if (Customer_Repository._customer != null)
            {
                MessageBox.Show("Log In Successfully!!!!!");
                this.Hide();
                main_Form.AccountReload();
            }
            else
            {
                MessageBox.Show("Account Not Found!!!!!");
                Username_TXT.Text = null;
                Password_TXT.Text = null;
            }
        }

        private void SignUp_LBL_Click(object sender, EventArgs e)
        {
            SignUp_From signUp_From = new SignUp_From();
            signUp_From.Show();
        }

        private void Unshow_Pass_Click(object sender, EventArgs e)
        {
            Show_Pass.Visible = true;
            Unshow_Pass.Visible = false;
            Password_TXT.PasswordChar = '\0';
        }

        private void Show_Pass_Click(object sender, EventArgs e)
        {
            Unshow_Pass.Visible = true;
            Show_Pass.Visible = true;
            Password_TXT.PasswordChar = '*';
        }

        private void LogIn_BTN_Enter(object sender, EventArgs e)
        {

            Button button = sender as Button;
            if (button != null)
            {
                button.BackColor = Color.CornflowerBlue; 
                button.ForeColor = Color.White;         
                button.Font = new Font(button.Font, FontStyle.Bold); 
            }
        }

      
        

        private void LogIn_BTN_Leave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.BackColor = Color.LightGray;   
                button.ForeColor = Color.Black;       
                button.Font = new Font(button.Font, FontStyle.Regular); 
            }
        }
    }
}
