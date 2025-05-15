using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArnieShopFinal.Join_Models
{
    public class ProductsInOrders
    {
        public int Order_Id { get; set; }
        public byte[] P_Picture { get; set; }
        public string P_Name { get; set; }
        public int P_Price { get; set; }
        public int O_Quantity { get; set; }
        public int O_Total { get; set; }
    }
}
