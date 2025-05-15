using ArnieShopFinal.Models;
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
    public partial class SignUp_From : Form
    {
        public SignUp_From()
        {
            InitializeComponent();
        }

        private void SignUp_BTN_Click(object sender, EventArgs e)
        {
            if (Role_TXT.Text == "User")
            {
                UserRepository userRepository = new UserRepository();
                userRepository.insert(new user()
                {
                    Username = Username_TXT.Text,
                    Password = Password_TXT.Text,
                    Firstname = Firstname_TXT.Text,
                    Lastname = Lastname_TXT.Text,
                    Contact_no = Contact_TXT.Text,
                    Email = Email_TXT.Text,
                    Address = Address_TXT.Text,
                });
                MessageBox.Show("Sign Up Successfully!!!!!");
                this.Hide();
            }
            else if (Role_TXT.Text == "Customer")
            {
                Customer_Repository customer_Repository = new Customer_Repository();
                customer_Repository.insert(new customer()
                {
                    Username = Username_TXT.Text,
                    Password = Password_TXT.Text,
                    Firstname = Firstname_TXT.Text,
                    Lastname = Lastname_TXT.Text,
                    Contact_no = Contact_TXT.Text,
                    Email = Email_TXT.Text,
                    Address = Address_TXT.Text,
                });
                MessageBox.Show("Sign Up Successfully!!!!!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Chooser Your Role!!!!!");
            }

            
        }

        private void LogIn_LBL_Click(object sender, EventArgs e)
        {
           this.Hide();
        }
    }
}
