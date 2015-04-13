using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Classes;

namespace DataLayer.Interfacess
{
    public interface IDatabase
    {
        //Add Method
        bool AddCustomer(Customer customer);
        bool AddGenre(Genre genre);
        bool AddVideo(Video video);

        //Delete Method
        bool DeleteCustomer(Customer aCustomer);
        bool DeleteGenre(Genre genre);
        bool DeleteVideo(Video aVideo);

        //Update Method
        bool UpdateCustomer(Guid key, Customer aCustomer);
        bool UpdateGenre(Guid key, Genre newGenre);
        bool UpdateVideo(Guid key, Video newVideo);

        //Get Method
        IEnumerable<Customer> GetCustomer();
        IEnumerable<Video> GetVideo();
        IEnumerable<Genre> GetGenre();
        IEnumerable<VideoBooking> GetBookingList();
        List<ListViewItem> GetAvailableVideo();


        bool RentVideo(VideoBooking videoBooking);
        bool ReturnVideo(VideoBooking videoBooking);

        List<ListViewItem> GetBookingListView();

        VideoBooking GetSelectedBooking(Guid bookingId);
    }
}
