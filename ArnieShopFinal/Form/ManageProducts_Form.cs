using ArnieShopFinal.New_Models;
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
using System.Xml.Linq;

namespace ArnieShopFinal
{
    public partial class ManageProducts_Form : Form
    {
        ProductRepository productRepository = new ProductRepository();
        ViewUserProduts_Form viewUserProduts_Form = new ViewUserProduts_Form();
        bool pic_Changed { get; set; }
        productsInfo product { get; set; }
        public ManageProducts_Form()
        {
            InitializeComponent();
            Category_TXT.DataSource = productRepository.getAll_Categories();
            Category_TXT.DisplayMember = "Category_Name";
            Category_TXT.ValueMember = "Categories_Id";
        }

        private void Exit_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Browse_BTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg; *.png; *.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Product_Pic.Image = Image.FromFile(open.FileName);
                pic_Changed = true;
            }
        }

        private void AddSave_BTN_Click(object sender, EventArgs e)
        {
            if (Product_Pic.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    Product_Pic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] imgDescription = ms.ToArray();
                    productRepository.insert(new productsInfo()
                    {
                        P_Name = ProductName_TXT.Text,
                        P_Description = Description_TXT.Text,
                        P_Quantity = int.Parse(Quantity_TXT.Text),
                        P_Picture = imgDescription,
                        user_User_Id = UserRepository._user.User_Id,
                        Price = int.Parse(Price_TXT.Text),
                        Categories_Id = (int)Category_TXT.SelectedValue,
                        Category_Name = Category_TXT.Text,
                        Total_Sales = 0
                    });
                }
                MessageBox.Show("Save Successfully!!!!");
            }
            this.Hide();
            viewUserProduts_Form.Reload();        
        }

        public void EditSave_BTN_Click (object sender, EventArgs e)
        {
            if (Product_Pic.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    try
                    {
                        byte[] imgDescription = null;

                        if (pic_Changed == true)
                        {
                            Product_Pic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            imgDescription = ms.ToArray();
                        }
                        else
                        {
                            imgDescription = product.P_Picture;
                        }
                        productRepository.update(new productsInfo()
                        {
                            P_Id = product.P_Id,
                            P_Name = ProductName_TXT.Text,
                            P_Description = Description_TXT.Text,
                            P_Quantity = int.Parse(Quantity_TXT.Text),
                            P_Picture = imgDescription,
                            Price = int.Parse(Price_TXT.Text),
                            Categories_Id = (int)Category_TXT.SelectedValue
                        });
                        MessageBox.Show("Save Successfully!!!!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                   
                }
            }
            this.Hide();
            viewUserProduts_Form.Reload();
        }
        private void Delete_BTN_Click (object sender, EventArgs e)
        {
            productRepository.delete(product.P_Id);
            MessageBox.Show("Deleted Successfully!!!!");
        }

        public void getUserProduct (int id)
        {
            ProductRepository productRepository = new ProductRepository();
            product = productRepository.get(id);
            if (product != null)
            {
                using (MemoryStream ms = new MemoryStream(product.P_Picture))
                {
                    Image img = Image.FromStream(ms);
                    ProductName_TXT.Text = product.P_Name;
                    Description_TXT.Text = product.P_Description;
                    Quantity_TXT.Text = product.P_Quantity.ToString();
                    Price_TXT.Text = product.Price.ToString();
                    Product_Pic.Image = img;
                    Category_TXT.Text = product.Category_Name;
                }
            }
            EditSave_BTN.Visible = true;
            Delete_BTN.Visible = false;
            AddSave_BTN.Visible = false;
        }
    }
}
