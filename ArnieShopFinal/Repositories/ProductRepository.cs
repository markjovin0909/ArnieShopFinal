using ArnieShopFinal.Data;
using ArnieShopFinal.Models;
using ArnieShopFinal.New_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArnieShopFinal.Repositories
{
    internal class ProductRepository : IBaseRepository<productsInfo>
    {

        public IEnumerable<productsInfo> getUserProducts (int Id)
        {
            try
            {
                using (MySqlContext db = new MySqlContext())
                {
                    var products = (from product in db.product
                                    join price in db.price
                                    on product.Product_Id equals price.product_Product_Id
                                    join category in db.categories
                                    on product.categories_Categories_Id equals category.Categories_Id
                                    join sale in db.sales
                                    on product.Product_Id equals sale.product_Product_Id
                                    where product.user_User_Id == Id
                                    select new productsInfo
                                    {
                                        P_Id = product.Product_Id,
                                        P_Name = product.P_Name,
                                        P_Description = product.P_Description,
                                        P_Quantity = product.P_Quantity,
                                        P_Picture = product.P_Picture,
                                        Price = price.Price,
                                        Categories_Id = category.Categories_Id,
                                        Category_Name = category.Category_Name,
                                        Total_Sales = sale.Total_Sales,
                                    }).ToList();
                    return products;
                }
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<productsInfo> getAll()
        {
            try
            {
                using (MySqlContext db = new MySqlContext())
                {
                    var products = (from product in db.product
                                    join price in db.price
                                    on product.Product_Id equals price.product_Product_Id
                                    join category in db.categories
                                    on product.categories_Categories_Id equals category.Categories_Id
                                    join sale in db.sales
                                    on product.Product_Id equals sale.product_Product_Id
                                    where product.P_Quantity != 0
                                    select new productsInfo 
                                    {
                                        P_Id = product.Product_Id,
                                        P_Name = product.P_Name,
                                        P_Description = product.P_Description,
                                        P_Quantity = product.P_Quantity,
                                        P_Picture = product.P_Picture,
                                        Price = price.Price,
                                        Categories_Id = category.Categories_Id,
                                        Category_Name = category.Category_Name,
                                        Total_Sales = sale.Total_Sales,
                                    }).ToList();
                    return products;
                }
            }
            catch
            {
                return null;
            }
        }

        public productsInfo get(int id)
        {
            try
            {
                using (MySqlContext db = new MySqlContext())
                {
                    var products = (from product in db.product
                                    join price in db.price
                                    on product.Product_Id equals price.product_Product_Id
                                    join category in db.categories
                                    on product.categories_Categories_Id equals category.Categories_Id
                                    join sale in db.sales
                                    on product.Product_Id equals sale.product_Product_Id
                                    where product.Product_Id == id
                                    select new productsInfo
                                    {
                                        P_Id = product.Product_Id,
                                        P_Name = product.P_Name,
                                        P_Description = product.P_Description,
                                        P_Quantity = product.P_Quantity,
                                        P_Picture = product.P_Picture,
                                        Price = price.Price,
                                        Categories_Id = category.Categories_Id,
                                        Category_Name = category.Category_Name,
                                        Total_Sales = sale.Total_Sales,
                                    }).FirstOrDefault();
                    return products;
                }
            }
            catch
            {
                return null;
            }
        }

        public void update(productsInfo entity)
        {
            try
            {
                using (MySqlContext db = new MySqlContext())
                {
                    var existingProduct = db.product.Find(entity.P_Id);

                    if (existingProduct != null)
                    {
                        db.Entry(existingProduct).CurrentValues.SetValues(new product()
                        {
                            Product_Id = existingProduct.Product_Id,
                            P_Name = entity.P_Name,
                            P_Description = entity.P_Description,
                            P_Quantity = entity.P_Quantity,
                            P_Picture = entity.P_Picture,
                            user_User_Id = existingProduct.user_User_Id,
                            categories_Categories_Id = entity.Categories_Id
                        });
                    }
                    var _price = db.price.FirstOrDefault(p => p.product_Product_Id == existingProduct.Product_Id);
                    var existingPrice = db.price.Find(_price.Price_Id);
                    if (existingPrice != null)
                    {
                        db.Entry(existingPrice).CurrentValues.SetValues(new price()
                        {
                            Price_Id = existingPrice.Price_Id,
                            Price = entity.Price,
                            product_Product_Id = existingPrice.product_Product_Id,
                        });
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
          
        }

        public void delete(int id)
        {
            try
            {
                using (MySqlContext db = new MySqlContext())
                {
                    var existingProduct = db.product.Find(id);

                    if (existingProduct != null)
                    {
                        db.Remove(existingProduct);
                    }
                    var _price = db.price.FirstOrDefault(p => p.product_Product_Id == existingProduct.Product_Id);
                    var existingPrice = db.price.Find(_price.Price_Id);
                    if (existingPrice != null)
                    {
                        db.Remove(existingPrice);
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void insert(productsInfo entity)
        {
            try
            {
                using (MySqlContext db = new MySqlContext())
                {
                    var product = new product()
                    {
                        P_Name = entity.P_Name,
                        P_Description = entity.P_Description,
                        P_Quantity = entity.P_Quantity,
                        P_Picture = entity.P_Picture,
                        user_User_Id = entity.user_User_Id,
                        categories_Categories_Id = entity.Categories_Id,
                    };
                    db.Add(product);
                    db.SaveChanges();

                    db.Add(new price()
                    {
                        Price = entity.Price,
                        product_Product_Id = product.Product_Id,
                    });
                    db.Add(new sales
                    {
                        Total_Sales = entity.Total_Sales,
                        product_Product_Id = product.Product_Id,
                    });
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public IEnumerable<productsInfo> Search_Product (string search)
        {
            var products = getAll().Where(p => p.P_Name.ToLower().Contains(search.ToLower())).ToList();
            return products;
        }
        public IEnumerable<categories> getAll_Categories ()
        {
            using (MySqlContext db = new MySqlContext())
            {
                List<categories> categories = db.categories.ToList();
                return categories;
            }
        }

        public IEnumerable<productsInfo> getProduct_InCategory(int id)
        {
            try
            {
                var products = getAll().Where(p => p.Categories_Id == id).ToList();
                return products;
                
            }
            catch
            {
                return null;
            }
        }
        public void UpdateP_QantitySales(productsInfo productsInfo)
        {
            try
            {
                using (MySqlContext db = new MySqlContext())
                {
                    var existingProduct = db.product.Find(productsInfo.P_Id);

                    if (existingProduct != null)
                    {
                        db.Entry(existingProduct).CurrentValues.SetValues(new product()
                        {
                            Product_Id = existingProduct.Product_Id,
                            P_Name = existingProduct.P_Name,
                            P_Description = existingProduct.P_Description,
                            P_Quantity = productsInfo.P_Quantity,
                            P_Picture = existingProduct.P_Picture,
                            user_User_Id = existingProduct.user_User_Id,
                            categories_Categories_Id = existingProduct.categories_Categories_Id
                        });
                    }
                    var _sales = db.sales.FirstOrDefault(s => s.product_Product_Id == existingProduct.Product_Id);
                    var existingSales = db.sales.Find(_sales.Sales_Id);
                    if (existingSales != null)
                    {
                        db.Entry(existingSales).CurrentValues.SetValues(new sales()
                        {
                            Sales_Id = existingSales.Sales_Id,
                            Total_Sales = productsInfo.Total_Sales,
                            product_Product_Id = existingSales.product_Product_Id,
                        });
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
