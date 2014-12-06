using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Classes;

namespace DataLayer.Interfacess
{
    public interface IDatalayer
    {
       
        bool RentVideo(Guid videoId, Guid customerId, DateTime rentDate);
        bool ReturnVideo(Guid bookingId, DateTime returnDate);
        IEnumerable<VideoBooking> GetBookingList();


    }
}
