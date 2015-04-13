using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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


        public bool AddGenre(Genre genre)
        {

            try
            {
           
                var isExist= Db.GetGenre().Any(g => g.Name.Equals(genre.Name));
                if (isExist)
                    return false;
                else return Db.AddGenre(genre);
                
            }
            catch
            {
                throw ;
            }
            
        }

        public bool AddCustomer(Customer customer)
        {
            try
            {
                var isExist = Db.GetCustomer().Any(v => v.Name.Equals(customer.Name));
                if (isExist)
                    return false;
                else return Db.AddCustomer(customer);
            }
            catch
            {
                throw;
            }
        }

        public bool AddVideo(Video video)
        {
            try
            {
                var isExist = Db.GetVideo().Any(v => v.Name.Equals(video.Name));
                if (isExist)
                    return false;
                else return Db.AddVideo(video);
            }
            catch
            {
                throw;
            }
        }

        #endregion


        #region Delete Method

        public bool DeleteGenre(Genre genre)
        {
            try
            {
                var videoList = GetVideo();
                if (videoList != null)
                {
                    var result = !videoList.Any(v => v.GenreId.Equals(genre.Id));
                    if (result)
                    {
                        return Db.DeleteGenre(genre);
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return Db.DeleteGenre(genre);
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
                if (bookingList.Count > 0)
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
                if (bookingList.Count == 0)
                {
                    return Db.DeleteVideo(aVideo);
                }
                else
                {
                    //var result = !bookingList.Any(b => b.VideoId.Equals(aVideo.Id));
                    //if (result)
                    {
                        var videoBookinglist= bookingList.FindAll(v => v.VideoId.Equals(aVideo.Id));
                        //var result= videoBookinglist.Any(b=>b.ReturnDate.Equals(DBNull.Value) && b.Cost.Equals(DBNull))
                        //if (result)
                        {
                            return Db.DeleteVideo(aVideo);
                        }
                        ////else

                        //{
                        //    return false;
                        //}
                    }
                    
                }
            }
            
            catch
            {
                throw;
            }

        }


        #endregion


        #region Update Method

        //TODO: In the update methods you would want to check that the Id is not equal to an empty Guid
        public bool UpdateGenre(Guid key, Genre newGenre)
        {
            try
            {
                return Db.UpdateGenre(key, newGenre);
            }
            catch
            {
                throw;
            }
        }

        public bool UpdateCustomer(Guid key, Customer aCustomer)
        {
           
            try
            {
                return Db.UpdateCustomer(key, aCustomer);
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }


        public bool UpdateVideo(Guid key,Video aVideo)
        {
            
            try
            {
                return Db.UpdateVideo(key, aVideo);
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        #endregion


        #region Get Method

        public IEnumerable<Customer> GetCustomer()
        {
           
            try
            {
                return Db.GetCustomer();
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        public IEnumerable<Video> GetVideo()
        {
            
            try
            {
                return Db.GetVideo();
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        public IEnumerable<Genre> GetGenre()
        {
            
            try
            {
                return Db.GetGenre();
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }


        public IEnumerable<VideoBooking> GetBookingList()
        {
            
            try
            {
                return Db.GetBookingList();
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

        public List<ListViewItem> GetAvailableVideo()
        {
            try
            {
                return Db.GetAvailableVideo();
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        #endregion


        #region Booking/Rental Method

        public bool RentVideo(VideoBooking videoBooking)

        {
            try
            {
                return Db.RentVideo(videoBooking);
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
           // var bookingList = Db.GetBookingList();
           //VideoBooking selectedBooking = bookingList.FirstOrDefault(b => b.Id.Equals(bookingId));
           // if (selectedBooking != null && selectedBooking.Cost > 0)
           // {
           //     return false;
           // }
            var selectedBooking = Db.GetSelectedBooking(bookingId);
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

        IEnumerable<VideoBooking> IDatalayer.GetBookingList()
        {
            throw new NotImplementedException();
        }

        private double CalculateCost(VideoBooking selectedBooking)
        {
            const double cost = 50;
            const double penaltyPerDay = 20;

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
                            (Convert.ToDouble(timeSpan.Days * penaltyPerDay)));    //TODO: Since you declared the cost as a constant you should do the same with the penalty cost
                   
                }
                else
                {
                    return cost;
                }
            }
            return 0;
        }


    #endregion



        public List<ListViewItem> GetBookingListView()
        {
            return Db.GetBookingListView();
        }

        public VideoBooking GetSelectedBooking(Guid bookingId)
        {
            throw new NotImplementedException();
        }
    }
}
