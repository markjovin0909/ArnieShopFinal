using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArnieShopFinal.Models
{
    public class product
    {
        [Key]
        public int Product_Id { get; set; } 
        public string P_Name { get; set; } 
        public string P_Description { get; set; } 
        public int P_Quantity {  get; set; } 
        public byte [] P_Picture { get; set; }
        public int user_User_Id { get; set; }
        public int categories_Categories_Id { get; set; }
    }
}
