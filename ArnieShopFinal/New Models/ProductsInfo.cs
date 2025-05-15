using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArnieShopFinal.New_Models
{
    public class productsInfo
    {
        public int P_Id { get; set; }
        public string P_Name { get; set; }
        public string P_Description { get; set; }
        public int P_Quantity { get; set; }
        public byte[] P_Picture { get; set; }
        public int user_User_Id { get; set; }
        public int Price { get; set; }
        public int Categories_Id { get; set; }
        public string Category_Name { get; set; }
        public int Total_Sales { get; set; }
    }
}
