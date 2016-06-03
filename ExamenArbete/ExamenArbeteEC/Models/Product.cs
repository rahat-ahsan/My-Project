using System;
using System.Collections.Generic;

namespace ExamenArbeteEC.Models
{
    public class Product
    {
        public int Id { get; set; }

       
        public string Name { get; set; }

       
        public Decimal Price { get; set; }

        public string imageURL { get; set; }
        public string Description { get; set; }

        
        public DateTime LastUpdated { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<OrderDetails> OrderedDetails { get; set; }
    }
}