using ArnieShopFinal.New_Models;
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

namespace ArnieShopFinal
{
    public partial class ViewUserProduts_Form : Form
    {
        public ViewUserProduts_Form()
        {
            InitializeComponent();
        }
        public void Reload()
        {
            ViewProduct_Form.ActiveForm.Close();
            this.Show();
        }
        private void ViewUserProduct_Form_Load(object sender, EventArgs e) 
        {
            ViewUserProducts_Load();
        }
        public void ViewUserProducts_Load()
        {
            ProductRepository productRepository = new ProductRepository();

            foreach (productsInfo products in productRepository.getUserProducts(UserRepository._user.User_Id))
            {
                if (products.P_Name != null)
                {
                    using (MemoryStream ms = new MemoryStream(products.P_Picture))
                    {
                        Image img = Image.FromStream(ms);
                        Guna2Panel productContainer = new Guna2Panel()
                        {
                            Size = new Size(905, 75),
                            BackColor = Color.Transparent,
                            BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid,
                            BorderColor = Color.Black,
                            BorderThickness = 1
                        };
                        PictureBox picture = new PictureBox
                        {
                            Image = img,
                            Size = new Size(65, 49),
                            BackColor = Color.Transparent,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Location = new Point(8, 13)
                        };
                        Label p_name = new Label()
                        {
                            Location = new Point(79, 30),
                            Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold),
                            Text = products.P_Name,
                            BackColor = Color.Transparent,
                            ForeColor = Color.Black,
                        };
                        RichTextBox p_descriptiom = new RichTextBox()
                        {
                            Location = new Point(188, 13),
                            Size = new Size(145, 49),
                            BorderStyle = BorderStyle.None,
                            Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold),
                            BackColor = Color.FromArgb(255, 255, 128),
                            Text = products.P_Description,
                            ForeColor = Color.Black,
                        };
                        Label p_quantity = new Label()
                        {
                            Location = new Point(382, 30),
                            Font = new Font("Segoe UI", 10, FontStyle.Bold),
                            Text = products.P_Quantity.ToString(),
                            BackColor = Color.Transparent,
                            ForeColor = Color.Black,
                        };
                        Label p_price = new Label()
                        {
                            Location = new Point(527, 30),
                            Font = new Font("Segoe UI", 10, FontStyle.Bold),
                            Text = products.Price.ToString(),
                            BackColor = Color.Transparent,
                            ForeColor = Color.Black,
                        };
                        Label p_category = new Label()
                        {
                            Location = new Point(629, 30),
                            Font = new Font("Segoe UI", 10, FontStyle.Bold),
                            Text = products.Category_Name,
                            BackColor = Color.Transparent,
                            ForeColor = Color.Black,
                        };
                        Label p_sales = new Label()
                        {
                            Location = new Point(747, 30),
                            Font = new Font("Segoe UI", 10, FontStyle.Bold),
                            Text = products.Total_Sales.ToString(),
                            BackColor = Color.Transparent,
                            ForeColor = Color.Black,
                        };

                        Guna2Button editButton = new Guna2Button()
                        {
                            Size = new Size(70, 28),
                            Location = new Point(820, 25),
                            Font = new Font("Segoe UI", 10, FontStyle.Bold),
                            Text = "edit",
                            BackColor = Color.Transparent,
                            FillColor = Color.FromArgb(64, 64, 64),
                            ForeColor = Color.FromArgb(255, 255, 128),
                            BorderRadius = 10,
                            Tag = products.P_Id
                        };
                        editButton.Click += Edit_BTN_Click;

                        productContainer.Controls.Add(editButton);
                        productContainer.Controls.Add(p_sales);
                        productContainer.Controls.Add(p_category);
                        productContainer.Controls.Add(p_price);
                        productContainer.Controls.Add(p_quantity);
                        productContainer.Controls.Add(p_descriptiom);
                        productContainer.Controls.Add(p_name);
                        productContainer.Controls.Add(picture);
                        Products_Display.Controls.Add(productContainer);
                    }
                }
            }
        }

        private void Exit_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_BTN_Click(object sender, EventArgs e)
        {
            ManageProducts_Form manageProducts_Form = new ManageProducts_Form();
            manageProducts_Form.Show();
        }

        private void Edit_BTN_Click (object sender, EventArgs e)
        {
            Guna2Button ClickedButton = sender as Guna2Button;
            if (ClickedButton != null)
            {
                int id = (int)ClickedButton.Tag;
                ManageProducts_Form manageProducts_Form = new ManageProducts_Form();
                manageProducts_Form.Show();
                manageProducts_Form.getUserProduct(id);
            }
        }
    }

}
