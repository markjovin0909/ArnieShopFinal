using ArnieShopFinal;
using ArnieShopFinal.Repositories;
using ArnieShopFinal.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArnieShopfinal
{
    public partial class Account_Form : UserControl
    {
        public Account_Form()
        {
            InitializeComponent();
            Account_Load();
        }

        public void Account_Load()
        {
            if (UserRepository._user != null)
            {
                LogIn();
                Name_LBL.Text = UserRepository._user.Firstname + " " + UserRepository._user.Lastname;
                Fullname_LBL.Text = UserRepository._user.Firstname + " " + UserRepository._user.Lastname;
                Contact_LBL.Text = UserRepository._user.Contact_no;
                Email_LBL.Text = UserRepository._user.Email;
                Adress_LBL.Text = UserRepository._user.Address;
                Role_LBL.Text = "User";
                ManageProducts_BTN.Visible = true;
            }
            else if (Customer_Repository._customer != null)
            {
                LogIn();
                Name_LBL.Text = Customer_Repository._customer.Firstname + " " + Customer_Repository._customer.Lastname;
                Fullname_LBL.Text = Customer_Repository._customer.Firstname + " " + Customer_Repository._customer.Lastname;
                Contact_LBL.Text = Customer_Repository._customer.Contact_no;
                Email_LBL.Text = Customer_Repository._customer.Email;
                Adress_LBL.Text = Customer_Repository._customer.Address;
                Role_LBL.Text = "Customer";
            }
            else
            {
                Not_LogIn();
            }
        }
        private void LogIn_LBL_Click(object sender, EventArgs e)
        {
            LogIn_Form logIn_Form = new LogIn_Form();
            logIn_Form.Show();
        }

        public void Not_LogIn()
        {
            LoggedIn_Pic.Visible = false;
            Name_LBL.Visible = false;
            BasicInfo_LBL.Visible = false;
            BasicInfo_Panel.Visible = false;
            LogOut_BTN.Visible = false;
            NotlogIn_Pic.Visible = true;
            NotlogINWarning_LBL.Visible = true;
            LogIn_LBL.Visible = true;
            ManageProducts_BTN.Visible = false;
        }
        public void LogIn()
        {
            LoggedIn_Pic.Visible = true;
            Name_LBL.Visible = true;
            BasicInfo_LBL.Visible = true;
            BasicInfo_Panel.Visible = true;
            LogOut_BTN.Visible = true;
            NotlogIn_Pic.Visible = false;
            NotlogINWarning_LBL.Visible = false;
            LogIn_LBL.Visible = false;
        }

        private void LogOut_BTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Log Out Successfully");
            Not_LogIn();
            UserRepository._user = null;
        }

        private void ManageProducts_BTN_Click(object sender, EventArgs e)
        {
            ViewUserProduts_Form viewUserProduts = new ViewUserProduts_Form();
            viewUserProduts.Show();
        }
    }
}
