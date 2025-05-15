using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArnieShopFinal.Models
{
    public class cart
    {
        [Key]
        public int Cart_Id {  get; set; }
        public int Cart_Quantity { get; set; }
        public int Cart_Total { get; set; }
        public int customer_Customer_Id { get; set; }
        public int product_Product_Id{ get; set; }
    }
}
