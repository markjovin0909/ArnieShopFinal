using ArnieShopFinal.Data;
using ArnieShopFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArnieShopFinal.Repositories
{
    public class UserRepository : IBaseRepository<user>
    {
        public static user _user { get; set; }
        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public user get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<user> getAll()
        {
            throw new NotImplementedException();
        }

        public void insert(user entity)
        {
            try
            {
                using (MySqlContext db = new MySqlContext())
                {
                    var user = db.user.FirstOrDefault(u => u.Username == entity.Username);
                    if (user == null)
                    {
                        db.Add(new user()
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

        public void update(user entity)
        {
            throw new NotImplementedException();
        }
        public void CheckUser(string user, string pass)
        {
            try
            {
                using (MySqlContext db = new MySqlContext())
                {
                    _user = db.user.FirstOrDefault(u => u.Username == user && u.Password == pass);
                }
            }
            catch
            {
                _user = null;
            }
           
        }
    }
}
