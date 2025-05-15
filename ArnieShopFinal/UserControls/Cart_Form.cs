using ArnieShopFinal;
using ArnieShopFinal.Models;
using ArnieShopFinal.New_Models;
using ArnieShopFinal.Repositories;
using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ArnieShopfinal
{
    public partial class Cart_Form : UserControl
    {
        CartRepository cart_Repository = new CartRepository();
        OrdersRepository ordersRepository = new OrdersRepository();
        ProductRepository productRepository = new ProductRepository();
        Main_Form main_Form = new Main_Form();
        public Cart_Form()
        {
            InitializeComponent();
        }

        private void Cart_Form_Load(object sender, EventArgs e)
        {
            int _total = 0;
            if (cart_Repository.getAll_CustomerCart() != null)
            {
                LoggedIn();
                foreach (ProductsInCart cart in cart_Repository.getAll_CustomerCart())
                {
                    using (MemoryStream ms = new MemoryStream(cart.P_Picture))
                    {
                        Image img = Image.FromStream(ms);
                        Panel cartContainer = new Panel()
                        {
                            Width = 700,
                            Height = 190,
                            BackColor = Color.FromArgb(238, 223, 122),
                            Padding = new Padding(10, 10, 10, 10),
                            Margin = new Padding(0, 0, 10, 20),
                         
                        };
                        PictureBox picture = new PictureBox
                        {
                            Image = img,
                            Width = 125,
                            Height = 100,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Location = new Point(10, 60),
                        };
                        Label product = new Label()
                        {
                            Location = new Point(10, 10),
                            Text = "Product",
                            Font = new Font("Segoe UI", 11, FontStyle.Bold),
                        };
                        Label p_name = new Label()
                        {
                            Location = new Point(170, 90),
                            Text = cart.P_Name,
                            Font = new Font("Segoe UI", 11, FontStyle.Bold),
                        };

                        Label price = new Label()
                        {
                            Location = new Point(380, 10),
                            Text = "Price",
                            Font = new Font("Segoe UI", 11, FontStyle.Bold),
                        };
                        Label p_price = new Label()
                        {
                            Location = new Point(380, 90),
                            Text = cart.P_Price.ToString(),
                            Font = new Font("Segoe UI", 11, FontStyle.Bold),
                        };

                        Label quantity = new Label()
                        {
                            Location = new Point(500, 10),
                            Text = "Quantity",
                            Font = new Font("Segoe UI", 11, FontStyle.Bold),
                        };
                        Label c_quantity = new Label()
                        {
                            Location = new Point(500, 90),
                            Text = cart.C_Quantity.ToString(),
                            Font = new Font("Segoe UI", 11, FontStyle.Bold),
                        };

                        Label total = new Label()
                        {
                            Location = new Point(620, 10),
                            Text = "Total",
                            Font = new Font("Segoe UI", 11, FontStyle.Bold),
                        };
                        Label c_total = new Label()
                        {
                            Location = new Point(620, 90),
                            Text = cart.C_Total.ToString(),
                            Font = new Font("Segoe UI", 11, FontStyle.Bold),
                        };
                        _total += cart.C_Total;

                        Guna2Button buy_BTN = new Guna2Button()
                        {
                            Size = new Size(111, 35),
                            Location = new Point(575, 145),
                            Font = new Font("Segoe UI", 12, FontStyle.Bold),
                            Text = "Buy",
                            ForeColor = Color.Black,
                            FillColor = Color.FromArgb(238, 223, 122),
                            BorderColor = Color.Black,
                            BorderThickness = 1,
                            BorderRadius = 5,
                            Tag = cart.Cart_Id
                        };
                        buy_BTN.Click += Buy_BTN_Clicked;

                        cartContainer.Controls.Add(picture);
                        cartContainer.Controls.Add(product);
                        cartContainer.Controls.Add(p_name);
                        cartContainer.Controls.Add(price);
                        cartContainer.Controls.Add(p_price);
                        cartContainer.Controls.Add(quantity);
                        cartContainer.Controls.Add(c_quantity);
                        cartContainer.Controls.Add(total);
                        cartContainer.Controls.Add(c_total);
                        cartContainer.Controls.Add(buy_BTN);

                        Cart_Container.Controls.Add(cartContainer);
                    }
                }
            }
            else
            {
                NotLoggedIn();
            }
            Total_LBL.Text = _total.ToString();
        }

        public void LoggedIn()
        {
            Cart_LBL.Visible = true;
            Cart_Container.Visible = true;
            BuyAll_BTN.Visible = true;
            total_tag_LBL.Visible = true;
            Total_LBL.Visible = true;
        }
        public void NotLoggedIn()
        {
            Cart_LBL.Visible = false;
            Cart_Container.Visible = false;
            BuyAll_BTN.Visible = false;
            total_tag_LBL.Visible = false;
            Total_LBL.Visible = false;
        }
        
        private void BuyAll_BTN_Click(object sender, EventArgs e)
        {
            foreach (ProductsInCart cart in cart_Repository.getAll_CustomerCart())
            {
                ordersRepository.insert(new orders 
                {
                    Order_Quantity = cart.C_Quantity,
                    Order_Total = cart.C_Total,
                    customer_Customer_Id = cart.Customer_Id,
                    product_Product_Id = cart.P_Id,
                });

                productsInfo products = productRepository.get(cart.P_Id);
                productRepository.UpdateP_QantitySales(new productsInfo()
                {
                    P_Id = products.P_Id,
                    P_Name = products.P_Name,
                    Price = products.Price,
                    P_Description = products.P_Description,
                    P_Picture = products.P_Picture,
                    Categories_Id = products.Categories_Id,
                    Category_Name = products.Category_Name,
                    user_User_Id = products.user_User_Id,
                    P_Quantity = products.P_Quantity - cart.C_Quantity,
                    Total_Sales = products.Total_Sales + cart.C_Quantity,
                });
                cart_Repository.delete(cart.Cart_Id);
            }
            MessageBox.Show("Successfully Buy All Products!!!!");
            main_Form.CartReload();
        }

        private void Buy_BTN_Clicked(object sender, EventArgs e) 
        {
            Guna2Button ClickedButton = sender as Guna2Button;
            if (ClickedButton != null)
            {
                int id = (int)ClickedButton.Tag;
                ProductsInCart cart = cart_Repository.get_CustomerCart(id);
                ordersRepository.insert(new orders
                {
                    Order_Quantity = cart.C_Quantity,
                    Order_Total = cart.C_Total,
                    customer_Customer_Id = cart.Customer_Id,
                    product_Product_Id = cart.P_Id,
                });

                productsInfo products = productRepository.get(cart.P_Id);
                productRepository.UpdateP_QantitySales(new productsInfo()
                {
                    P_Id = products.P_Id,
                    P_Name = products.P_Name,
                    Price = products.Price,
                    P_Description = products.P_Description,
                    P_Picture = products.P_Picture,
                    Categories_Id = products.Categories_Id,
                    Category_Name = products.Category_Name,
                    user_User_Id = products.user_User_Id,
                    P_Quantity = products.P_Quantity - cart.C_Quantity,
                    Total_Sales = products.Total_Sales + cart.C_Quantity,
                });
                cart_Repository.delete(id);
            }
            MessageBox.Show("Successfully Buy Product!!!!");
            main_Form.CartReload();
        }
    }
}
