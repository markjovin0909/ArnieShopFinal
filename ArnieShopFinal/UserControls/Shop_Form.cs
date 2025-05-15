using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArnieShopFinal;
using ArnieShopFinal.Models;
using ArnieShopFinal.New_Models;
using ArnieShopFinal.Repositories;
using Google.Protobuf.WellKnownTypes;

namespace ArnieShopfinal
{
    public partial class Shop_Form : UserControl
    {
        ProductRepository productRepository = new ProductRepository();
        public Shop_Form()
        {
            InitializeComponent();
            Category_TXT.DataSource = productRepository.getAll_Categories();
            Category_TXT.DisplayMember = "Category_Name";
            Category_TXT.ValueMember = "Categories_Id";
            Category_TXT.SelectedIndex = -1;
        }

        private void Shop_Form_Load(object sender, EventArgs e)
        {
            displayProducts(productRepository.getAll());
        }

        private void product_pic_Click(object sender, EventArgs e)
        {
            PictureBox clickedProduct = sender as PictureBox;
            if (clickedProduct != null)
            {
                int id = (int)clickedProduct.Tag;
                ViewProduct_Form viewProduct = new ViewProduct_Form();
                viewProduct.Show();
                viewProduct.getProduct(id);
            }
        }

        private void Category_TXT_SelectedIndexChangedCommitted(object sender, EventArgs e)
        {
            if (Category_TXT.SelectedIndex != -1)
            {
                int Categories_Id = (int)Category_TXT.SelectedValue;
                displayProducts(productRepository.getProduct_InCategory(Categories_Id));
            }
        }
        private void Search_TXT_TextChanged(object sender, EventArgs e)
        {
            displayProducts(productRepository.Search_Product(Search_TXT.Text));
        }

        public void displayProducts(IEnumerable<productsInfo> _products)
        {
            displayProduct_Panel.Controls.Clear();
            foreach (productsInfo products in _products)
            {
                if (products != null)
                {
                    using (MemoryStream ms = new MemoryStream(products.P_Picture))
                    {
                        Image img = Image.FromStream(ms);
                        Panel productContainer = new Panel()
                        {
                            Size = new Size(220, 250),
                            BackColor = Color.FromArgb(52, 49, 49),
                            Margin = new Padding(15, 30, 15, 0)

                        };
                        PictureBox picture = new PictureBox
                        {
                            Image = img,
                            Size = new Size(220, 170),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Tag = products.P_Id
                        };
                        Label p_name = new Label()
                        {
                            Location = new Point(10, 180),
                            Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold),
                            Text = products.P_Name,
                            BackColor = Color.FromArgb(52, 49, 49),
                            ForeColor = Color.White,
                        };
                        Label p_price = new Label()
                        {
                            Location = new Point(10, 215),
                            Font = new Font("Segoe UI", 14, FontStyle.Bold),
                            Text = products.Price.ToString(),
                            BackColor = Color.FromArgb(52, 49, 49),
                            ForeColor = Color.White,
                        };

                        picture.Click += product_pic_Click;

                        productContainer.Controls.Add(p_price);
                        productContainer.Controls.Add(p_name);
                        productContainer.Controls.Add(picture);
                        displayProduct_Panel.Controls.Add(productContainer);
                    }
                }
            }
        }        
    }
}
