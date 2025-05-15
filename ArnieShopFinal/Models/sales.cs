using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArnieShopFinal.Models
{
    public class sales
    {
        [Key]
        public int Sales_Id { get; set;}
        public int Total_Sales { get; set; }
        public int product_Product_Id { get; set; }
    }
}
