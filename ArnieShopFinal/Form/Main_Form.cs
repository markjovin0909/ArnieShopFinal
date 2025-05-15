using ArnieShopFinal;
using ArnieShopFinal.Repositories;
using ArnieShopFinal.UserControls;
using System.Windows.Forms;

namespace ArnieShopfinal
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }
        public void AccountReload()
        {
            Main_Form.ActiveForm.Close();
            Account_Form account_Form = new Account_Form();
            Display_User(account_Form);
            this.Show();
        }
        public void CartReload()
        {
            Main_Form.ActiveForm.Close();
            Cart_Form cart_Form = new Cart_Form();
            Display_User(cart_Form);
            this.Show();
        }
        public void ShopReload()
        {
            Main_Form.ActiveForm.Close();
            Shop_Form shop_Form = new Shop_Form();
            Display_User(shop_Form);
            this.Show();
        }

        public void Display_User(UserControl userControl)
        {
            Display_Panel.Controls.Clear();
            userControl.Invalidate();
            userControl.Refresh();
            Display_Panel.Controls.Add(userControl);
        }

        public void BTN_Active(Button button)
        {
            button.BackColor = Color.FromArgb(52, 49, 49);
            button.ForeColor = Color.FromArgb(216, 162, 94);
        }
        
        public void BTN_Inactive(Button button)
        {
            button.ForeColor = Color.FromArgb(52, 49, 49);
            button.BackColor = Color.FromArgb(216, 162, 94);
        }

        private void Close_BTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Button Click Events
        private void Shop_BTN_Click(object sender, EventArgs e)
        {
            Shop_Form shop_Form = new Shop_Form();
            Display_User(shop_Form);
        }

        private void Cart_BTN_Click(object sender, EventArgs e)
        {
            Cart_Form cart_Form = new Cart_Form();
            Display_User(cart_Form);
        }

        private void Account_BTN_Click(object sender, EventArgs e)
        {
            Account_Form account_Form = new Account_Form();
            Display_User(account_Form);
        }

        private void Order_BTN_Click(object sender, EventArgs e)
        {
            Orders_Form orders_Form = new Orders_Form();
            Display_User(orders_Form);
        }

        #endregion

        #region Mouse Clicked Design
        private void Shop_BTN_Enter(object sender, EventArgs e)
        {
            BTN_Active(Shop_BTN);
        }

        private void Shop_BTN_Leave(object sender, EventArgs e)
        {
            BTN_Inactive(Shop_BTN);
        }

        private void Cart_BTN_Enter(object sender, EventArgs e)
        {
            BTN_Active(Cart_BTN);
        }

        private void Cart_BTN_Leave(object sender, EventArgs e)
        {
            BTN_Inactive(Cart_BTN);
        }

        private void Account_BTN_Enter(object sender, EventArgs e)
        {
            BTN_Active(Account_BTN);
        }

        private void Account_BTN_Leave(object sender, EventArgs e)
        {
            BTN_Inactive(Account_BTN);
        }

        private void Order_BTN_Enter(object sender, EventArgs e)
        {
            BTN_Active(Order_BTN);
        }

        private void Order_BTN_Leave(object sender, EventArgs e)
        {
            BTN_Inactive(Order_BTN);
        }
        #endregion
    }
}
