using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArnieShopFinal.Models
{
    public class price
    {
       [Key]
       public int Price_Id { get; set; }
       public int Price { get; set; }
       public int product_Product_Id { get; set; }
    }
}
