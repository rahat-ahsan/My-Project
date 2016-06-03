using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenArbeteEC.Models
{
    public class Category
    {
        public int Id { get; set; }

       
        public string Name { get; set; }

        public string ImageUrl { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}