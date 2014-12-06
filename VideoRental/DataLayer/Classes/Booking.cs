using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Interfacess;

namespace DataLayer.Classes
{
    public class Booking : IDatalayer, IDatabase

    {
        public IDatabase Db { get; set; }

        public Booking(IDatabase db)
        {
            Db = db;
        }


        #region Add Method


        public bool AddGenre(string genreName)
        {

            try
            {
                return Db.AddGenre(genreName);
            }
            catch
            {
                throw ;
            }
            
        }

        public bool AddCustomer(string fName, string lName)
        {
            try
            {
                return Db.AddCustomer(fName,lName);
            }
            catch
            {
                throw;
            }
        }

        public bool AddVideo(Guid genreId, string name, int daystobeRent)
        {
            try
            {
                return Db.AddVideo(genreId, name, daystobeRent);
            }
            catch
            {
                throw;
            }
        }

        #endregion


        #region Delete Method

        public bool DeleteGenre(Genre aGenre)
        {
            try
            {
                var videoList = GetVideo();
                if (videoList != null)
                {
                    var result = !videoList.Any(v => v.GenreId.Equals(aGenre.Id));
                    if (result)
                    {
                        return Db.DeleteGenre(aGenre);
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return Db.DeleteGenre(aGenre);
                }
            }
            catch
            {
                throw;
            }
        }

        public bool DeleteCustomer(Customer aCustomer)
        {
            try
            {
                var bookingList = GetBookingList().ToList();
                if (bookingList != null)
                {
                    var result = !bookingList.Any(b => b.CustomerId.Equals(aCustomer.Id));
                    if (result)
                    {
                        return Db.DeleteCustomer(aCustomer);
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return Db.DeleteCustomer(aCustomer);
                }

            }
            catch
            {
                throw;
            }
        }

        public bool DeleteVideo(Video aVideo)
        {
            try
            {
                var bookingList = GetBookingList().ToList();
                    var result = !bookingList.Any(b => b.VideoId.Equals(aVideo.Id));
                    if (result)
                    {
                        if (aVideo.IsRented != true)
                            
                            return Db.DeleteVideo(aVideo);
                        else
                            return false;
                    }
                    else
                    {
                        return false;
                    }
                
            }
            
            catch
            {
                throw;
            }

        }


        #endregion


        #region Update Method


        public bool UpdateGenre(Guid key, string newGenre)
        {
            try
            {
                return Db.UpdateGenre(key, newGenre);
            }
            catch (VideoRentalException e)
            {
                throw;
            }
        }

        public bool UpdateCustomer(Guid key, string firsttName, string lastName)
        {
            return Db.UpdateCustomer(key, firsttName, lastName);
        }


        public bool UpdateVideo(Guid videoId,Guid genreId, string name, int daystobeRent)
        {
            return Db.UpdateVideo(videoId,genreId,name,daystobeRent);
        }

        #endregion


        #region Get Method

        public IEnumerable<Customer> GetCustomer()
        {
            return Db.GetCustomer();
        }

        public IEnumerable<Video> GetVideo()
        {
            return Db.GetVideo();
        }

        public IEnumerable<Genre> GetGenre()
        {
            return Db.GetGenre();
        }

        
        public IEnumerable<VideoBooking> GetBookingList()
        {
            return Db.GetBookingList();
        }

        
        #endregion


        #region Booking/Rental Method

        public bool RentVideo(Guid videoId, Guid customerId, DateTime rentDate)

        {
            try
            {
                return Db.RentVideo(videoId, customerId, DateTime.Now);
            }
            catch
            {
                throw;
            }

        }

        public bool ReturnVideo(VideoBooking videoBooking)
        {
            try
            {
                return Db.ReturnVideo(videoBooking);
            }
            catch
            {
                throw;
            } 
        }

        public bool ReturnVideo(Guid bookingId, DateTime returnDate)
        {
            var bookingList = Db.GetBookingList();
           VideoBooking selectedBooking = bookingList.FirstOrDefault(b => b.Id.Equals(bookingId));
            if (selectedBooking != null && selectedBooking.Cost > 0)
            {
                return false;
            }
            if (selectedBooking != null)
            {
                var dateCompare = DateTime.Compare(returnDate, selectedBooking.RentDate);
                if (dateCompare < 0)
                {
                    return false;
                }
                else
                {
                    selectedBooking.ReturnDate = returnDate;
                    selectedBooking.Cost = CalculateCost(selectedBooking);
                    return ReturnVideo(selectedBooking);
                }
            }
            return false;
        }

        private double CalculateCost(VideoBooking selectedBooking)
        {
            const double cost = 50;

            var selectedVideo = GetVideo().FirstOrDefault(v => v.Id.Equals(selectedBooking.VideoId));


            if (selectedVideo != null)
            {
                var daysToBeRent = selectedVideo.DaysToBeRent;
                
                var rentTillDate = selectedBooking.RentDate.AddDays(Convert.ToDouble(daysToBeRent));
                var dateCompare = DateTime.Compare(selectedBooking.ReturnDate, rentTillDate);

                if (dateCompare > 0)
                {
                    TimeSpan timeSpan = selectedBooking.ReturnDate - rentTillDate;
                    return (cost +
                            (Convert.ToDouble(timeSpan.Days * 20)));
                   
                }
                else
                {
                    return cost;
                }
            }
            return 0;
        }


    #endregion

   
    }
}
