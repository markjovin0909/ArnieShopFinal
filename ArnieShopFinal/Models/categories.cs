using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArnieShopFinal.Models
{
    public class categories
    {
        [Key]
        public int Categories_Id { get; set; }
        public string Category_Name { get; set; }
    }
}
