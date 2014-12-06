using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Classes;

namespace DataLayer.Interfacess
{
    public interface IDatabase
    {
        //Add Method
        bool AddCustomer(string fName, string lName);
        bool AddGenre(string genreName);
        bool AddVideo(Guid genreId, string name, int daysToBeRent);

        //Delete Method
        bool DeleteCustomer(Customer aCustomer);
        bool DeleteGenre(Genre aGenre);
        bool DeleteVideo(Video aVideo);

        //Update Method
        bool UpdateCustomer(Guid key, string firstName, string lastName);
        bool UpdateGenre(Guid key, string newGenre);
        bool UpdateVideo(Guid videoId, Guid genreId, string name, int daysToBeRent);

        //Get Method
        IEnumerable<Customer> GetCustomer();
        IEnumerable<Video> GetVideo();
        IEnumerable<Genre> GetGenre();
        IEnumerable<VideoBooking> GetBookingList(); 

        bool RentVideo(Guid videoId, Guid customerId, DateTime rentDate);
        bool ReturnVideo(VideoBooking videoBooking);
    }
}
