using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Classes
{
    public class VideoBooking
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid GenreId { get; set; }
        public Guid VideoId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public double Cost { get; set; }

        public string[] ToArray()
        {
            return new string[] { Id.ToString(), RentDate.ToString(("dd/MM/yyyy")),
                ReturnDate == DateTime.MinValue ? String.Empty : ReturnDate.ToString(("dd/MM/yyyy")), Cost.ToString() };
            //return "";
        }

        
    }
}
