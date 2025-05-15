using ArnieShopFinal.Data;
using ArnieShopFinal.Join_Models;
using ArnieShopFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArnieShopFinal.Repositories
{
    public class CartRepository : IBaseRepository<cart>
    { 
        public void delete(int id)
        {
            using (MySqlContext db = new MySqlContext())
            {
                cart cart = db.cart.FirstOrDefault(c => c.Cart_Id == id);
                if (cart != null)
                {
                    db.Remove(cart);
                    db.SaveChanges();
                }
            }
        }

        public void deleteAll(int id)
        {
            throw new NotImplementedException();
        }
        public cart get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<cart> getAll()
        {
            throw new NotImplementedException();
        }

        public void insert(cart entity)
        {
            try
            {
                using (MySqlContext db = new MySqlContext())
                {
                    db.Add(new cart()
                    {
                        Cart_Quantity = entity.Cart_Quantity,
                        Cart_Total = entity.Cart_Total,
                        customer_Customer_Id = entity.customer_Customer_Id,
                        product_Product_Id = entity.product_Product_Id
                    });
                    db.SaveChanges();
                }
            }
            catch (Exception ex) 
            {
            
            }
           
        }

        public void update(cart entity)
        {
            throw new NotImplementedException();
        }
        public ProductsInCart get_CustomerCart(int id)
        {
            try
            {
                using (MySqlContext db = new MySqlContext())
                {
                    var cart = (from carts in db.cart
                                join products in db.product
                                on carts.product_Product_Id equals products.Product_Id
                                join prices in db.price
                                on products.Product_Id equals prices.product_Product_Id
                                join customer in db.customer
                                on carts.customer_Customer_Id equals customer.Customer_Id
                                where carts.Cart_Id == id
                                select new ProductsInCart ()
                                {
                                    Cart_Id = carts.Cart_Id,
                                    P_Id = products.Product_Id,
                                    Customer_Id = customer.Customer_Id,
                                    P_Picture = products.P_Picture,
                                    P_Name = products.P_Name,
                                    P_Price = prices.Price,
                                    C_Quantity = carts.Cart_Quantity,
                                    C_Total = carts.Cart_Total,
                                }).FirstOrDefault();
                    return cart;
                }
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<ProductsInCart> getAll_CustomerCart()
        {
            try
            {
                using (MySqlContext db = new MySqlContext())
                {
                    var cart = (from carts in db.cart
                                join products in db.product
                                on carts.product_Product_Id equals products.Product_Id
                                join prices in db.price
                                on products.Product_Id equals prices.product_Product_Id
                                join customer in db.customer
                                on carts.customer_Customer_Id equals customer.Customer_Id
                                where carts.customer_Customer_Id == Customer_Repository._customer.Customer_Id
                                where products.P_Quantity != 0
                                select new ProductsInCart ()
                                {
                                    Cart_Id = carts.Cart_Id,
                                    P_Id = products.Product_Id,
                                    Customer_Id = customer.Customer_Id,
                                    P_Picture = products.P_Picture,
                                    P_Name = products.P_Name,
                                    P_Price = prices.Price,
                                    C_Quantity = carts.Cart_Quantity,
                                    C_Total = carts.Cart_Total,
                                }).ToList();
                    return cart;
                }
            }
            catch 
            {
                return null;
            }
           
        }
    }
}
