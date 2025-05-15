using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ArnieShopFinal.Models
{
    public class user
    {
        [Key]
        public int User_Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname {  get; set; }
        public string Contact_no { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
