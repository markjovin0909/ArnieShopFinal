using ArnieShopFinal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArnieShopFinal.Data
{
   public class MySqlContext : DbContext
    {
        public DbSet<product> product { get; set; }
        public DbSet<price> price { get; set; }
        public DbSet<categories> categories { get; set; }
        public DbSet<sales> sales { get; set; }
        public DbSet<cart> cart { get; set; }
        public DbSet<orders> orders { get; set; }
        public DbSet<user> user { get; set; }
        public DbSet<customer> customer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost; uid=root; password=root; database=arnieshop_final");
        }
    }
}
