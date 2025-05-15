using ArnieShopfinal;
using ArnieShopFinal.Models;
using ArnieShopFinal.New_Models;
using ArnieShopFinal.Repositories;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ViewProduct_Form : Form
    {
        ProductRepository productRepository = new ProductRepository();
        CartRepository cartRepository = new CartRepository();
        Main_Form main_Form = new Main_Form();
        productsInfo product { get; set; }
        public ViewProduct_Form()
        {
            InitializeComponent();
            IsLoggedIn();
        }

        private void Close_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void getProduct(int id)
        {
            product = productRepository.get(id);
            if (product != null)
            {
                using (MemoryStream ms = new MemoryStream(product.P_Picture))
                {
                    Image img = Image.FromStream(ms);
                    Product_Container.Image = img;
                    Product_LBL.Text = product.P_Name;
                    Price_LBL.Text = "₱ " + product.Price.ToString();
                    Total_LBL.Text = "₱ " + product.Price.ToString();
                    Description_TXT.Text = product.P_Description;
                    Category_LBL.Text = product.Category_Name;
                    Product_Quantity_LBL.Text = product.P_Quantity.ToString();
                }
            }
        }

        private void AddToCart_BTN_Click(object sender, EventArgs e)
        {
            cartRepository.insert(new cart()
            {
                Cart_Quantity = int.Parse(Quantity_LBL.Text),
                Cart_Total = int.Parse(Quantity_LBL.Text) * product.Price,
                customer_Customer_Id = Customer_Repository._customer.Customer_Id,
                product_Product_Id = product.P_Id
            });

            MessageBox.Show("Product Successfully Added to Cart!!!!!");
            this.Hide();
        }
        private void Order_BTN_Click(object sender, EventArgs e)
        {
            OrdersRepository ordersRepository = new OrdersRepository();
            ordersRepository.insert(new orders()
            {
                Order_Quantity = int.Parse(Quantity_LBL.Text),
                Order_Total = int.Parse(Quantity_LBL.Text) * product.Price,
                customer_Customer_Id = Customer_Repository._customer.Customer_Id,
                product_Product_Id = product.P_Id
            });

            productRepository.UpdateP_QantitySales(new productsInfo()
            {
                P_Id = product.P_Id,
                P_Name = product.P_Name,
                Price = product.Price,
                P_Description = product.P_Description,
                P_Picture = product.P_Picture,
                Categories_Id = product.Categories_Id,
                Category_Name = product.Category_Name,
                user_User_Id = product.user_User_Id,
                P_Quantity = product.P_Quantity - int.Parse(Quantity_LBL.Text),
                Total_Sales = product.Total_Sales + int.Parse(Quantity_LBL.Text),
            });
            MessageBox.Show("Product Successfull Ordered!!!!!");
            this.Hide();
            main_Form.ShopReload();
        }

        private void Add_BTN_Click(object sender, EventArgs e)
        {
            if ((int.Parse(Quantity_LBL.Text) < product.P_Quantity))
            {
                Quantity_LBL.Text = (int.Parse(Quantity_LBL.Text) + 1).ToString();
                Total_LBL.Text = "₱ " + (int.Parse(Quantity_LBL.Text) * product.Price).ToString();
            }
        }

        private void Minus_BTN_Click(object sender, EventArgs e)
        {
            if (int.Parse(Quantity_LBL.Text) != 1)
            {
                Quantity_LBL.Text = (int.Parse(Quantity_LBL.Text) - 1).ToString();
                Total_LBL.Text = "₱ " + (int.Parse(Quantity_LBL.Text) * product.Price).ToString();
            }
        }

        public void IsLoggedIn()
        {
            if (Customer_Repository._customer != null)
            {
                Order_BTN.Visible = true;
                AddToCart_BTN.Visible = true;
                NotlogINWarning_LBL.Visible = false;
            }
            if (UserRepository._user != null)
            {
                NotlogINWarning_LBL.Text = "Log In as a Customer to Order";
            }
        }

        private void NotlogINWarning_LBL_Click(object sender, EventArgs e)
        {
            Main_Form form = new Main_Form();
                form.AccountReload();
        }
    }
}
