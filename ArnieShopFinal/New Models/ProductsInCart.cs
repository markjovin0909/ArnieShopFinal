using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArnieShopFinal.Models
{
    public class ProductsInCart
    {
        public int Cart_Id { get; set; }
        public int P_Id {  get; set; }
        public byte[] P_Picture { get; set; }
        public string P_Name { get; set; }
        public int P_Price { get; set; }
        public int Customer_Id {  get; set; }
        public int C_Quantity { get; set; }
        public int C_Total { get; set; }
    }
}
