using ArnieShopFinal.Join_Models;
using ArnieShopFinal.Models;
using ArnieShopFinal.Repositories;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArnieShopFinal.UserControls
{
    public partial class Orders_Form : UserControl
    {
        public Orders_Form()
        {
            InitializeComponent();
        }

        private void Orders_Form_Load(object sender, EventArgs e)
        {
            OrdersRepository ordersRepository = new OrdersRepository();
            if (ordersRepository.get_Orders() != null)
            {
                LoggedIn();
                foreach (ProductsInOrders orders in ordersRepository.get_Orders())
                {
                    using (MemoryStream ms = new MemoryStream(orders.P_Picture))
                    {
                        Image img = Image.FromStream(ms);
                        Panel cartContainer = new Panel()
                        {
                            Width = 700,
                            Height = 190,
                            BackColor = Color.White,
                            Padding = new Padding(10, 10, 10, 10),
                            Margin = new Padding(0, 0, 0, 20)

                        };
                        PictureBox picture = new PictureBox
                        {
                            Image = img,
                            Width = 125,
                            Height = 100,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Location = new Point(10, 60)
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
                            Text = orders.P_Name,
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
                            Text = orders.P_Price.ToString(),
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
                            Text = orders.O_Quantity.ToString(),
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
                            Text = orders.O_Total.ToString(),
                            Font = new Font("Segoe UI", 11, FontStyle.Bold),
                        };

                        cartContainer.Controls.Add(picture);
                        cartContainer.Controls.Add(product);
                        cartContainer.Controls.Add(p_name);
                        cartContainer.Controls.Add(price);
                        cartContainer.Controls.Add(p_price);
                        cartContainer.Controls.Add(quantity);
                        cartContainer.Controls.Add(c_quantity);
                        cartContainer.Controls.Add(total);
                        cartContainer.Controls.Add(c_total);

                        Orders_Container.Controls.Add(cartContainer);
                    }
                }
            }
            else
            {
                NotLoggedIn();
            }
        }
        public void LoggedIn()
        {
            Orders_LBL.Visible = true;
            Orders_Container.Visible = true;
        }
        public void NotLoggedIn()
        {
            Orders_LBL.Visible = false;
            Orders_Container.Visible = false;
        }
    }
}
