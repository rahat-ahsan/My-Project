using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExamenArbeteEC.Models
{
    public class ECStoreDbConcext :DbContext
    {
        
        public ECStoreDbConcext() : base("ECStoreDB")   {   }
        
        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<CustomerOrder> CustomerOrders { get; set; }

        public DbSet<OrderDetails> OrderDetails { get; set; }

        public DbSet<Cart> Carts { get; set; }

    }
}