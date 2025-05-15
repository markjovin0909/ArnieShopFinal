using ArnieShopFinal.Data;
using ArnieShopFinal.Join_Models;
using ArnieShopFinal.Models;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArnieShopFinal.Repositories
{
    public class OrdersRepository : IBaseRepository<orders>
    {
        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public orders get(int id)
        {
            try
            {
                using (MySqlContext db = new MySqlContext())
                {
                    var order = db.orders.FirstOrDefault(o => o.Order_Id == id);
                    return order;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IEnumerable<orders> getAll()
        {
            throw new NotImplementedException();
        }

        public void insert(orders entity)
        {
            try
            {
                using (MySqlContext db = new MySqlContext())
                {
                    db.Add(new orders()
                    {
                        Order_Quantity = entity.Order_Quantity,
                        Order_Total = entity.Order_Total,
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

        public void update(orders entity)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<ProductsInOrders> get_Orders()
        {
            try
            {
                using (MySqlContext db = new MySqlContext())
                {
                    var order = (from orders in db.orders
                                 join products in db.product
                                 on orders.product_Product_Id equals products.Product_Id
                                 join prices in db.price
                                 on products.Product_Id equals prices.product_Product_Id
                                 join customer in db.customer
                                 on orders.customer_Customer_Id equals customer.Customer_Id
                                 where orders.customer_Customer_Id == Customer_Repository._customer.Customer_Id
                                 select new ProductsInOrders
                                 {
                                     Order_Id = orders.Order_Id,
                                     P_Picture = products.P_Picture,
                                     P_Name = products.P_Name,
                                     P_Price = prices.Price,
                                     O_Quantity = orders.Order_Quantity,
                                     O_Total = orders.Order_Total,
                                 }).ToList();
                    return order;
                }
            }
            catch
            {
                return null;
            }
            
        }

    }
}
