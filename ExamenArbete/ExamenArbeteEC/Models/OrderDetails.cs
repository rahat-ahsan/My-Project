using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenArbeteEC.Models
{
    public class OrderDetails
    {
        [Key]
        [Column(Order = 0)]
        public int ProductId { get; set; }

        [Key]
        [Column(Order = 1)]
        public int CustomerOrderId { get; set; }

        public int Quantity { get; set; }

        public virtual Product Product { get; set; }
        public virtual CustomerOrder CustomerOrder { get; set; }
    }
}