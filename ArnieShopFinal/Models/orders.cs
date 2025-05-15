using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArnieShopFinal.Models
{
    public class orders
    {
        [Key]
        public int Order_Id { get; set; }
        public int Order_Quantity { get; set; }
        public int Order_Total { get; set; }
        public int customer_Customer_Id { get; set; }
        public int product_Product_Id { get; set; }
    }
}
