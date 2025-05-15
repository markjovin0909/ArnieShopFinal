using ArnieShopFinal.Data;
using ArnieShopFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArnieShopFinal.Repositories
{
    public class Customer_Repository: IBaseRepository<customer>
    {
        public static customer _customer { get; set; }
        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public customer get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<customer> getAll()
        {
            throw new NotImplementedException();
        }

        public void insert(customer entity)
        {
            try
            {
                using (MySqlContext db = new MySqlContext())
                {
                    var customer = db.customer.FirstOrDefault(c => c.Username == entity.Username);
                    if (customer == null)
                    {
                        db.Add(new customer()
                        {
                            Username = entity.Username,
                            Password = entity.Password,
                            Firstname = entity.Firstname,
                            Lastname = entity.Lastname,
                            Contact_no = entity.Contact_no,
                            Email = entity.Email,
                            Address = entity.Address,
                        });
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Username Already Exist");
                    }
                }
            }
            catch
            {

            }
        }

        public void update(customer entity)
        {
            throw new NotImplementedException();
        }
        public void CheckUser(string user, string pass)
        {
            try
            {
                using (MySqlContext db = new MySqlContext())
                {
                    _customer = db.customer.FirstOrDefault(c => c.Username == user && c.Password == pass);
                }
            }
            catch
            {
                _customer = null;
            }

        }
    }
}
