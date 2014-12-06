using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Classes;
using DataLayer.Interfacess;

namespace DataLayer.Classes
{
    public class Database : IDatabase
    {
        private  Dictionary<Guid, Customer> customerList = new Dictionary<Guid, Customer>();
        private  Dictionary<Guid, Genre> genreList = new Dictionary<Guid, Genre>();
        private  Dictionary<Guid, Video> videoList = new Dictionary<Guid, Video>();
        private  Dictionary<Guid, VideoBooking> bookingList = new Dictionary<Guid, VideoBooking>();

        #region Database Initilization

        public Database()
        {
            Guid genreId;
            genreList.Add(genreId = Guid.NewGuid(), new Genre() {Id = genreId, Name = "Action"});
            genreList.Add(genreId = Guid.NewGuid(), new Genre() {Id = genreId, Name = "Horror"});
            genreList.Add(genreId = Guid.NewGuid(), new Genre() {Id = genreId, Name = "Romantic"});
            genreList.Add(genreId = Guid.NewGuid(), new Genre() {Id = genreId, Name = "Comedy"});


            Guid videoId;
            videoList.Add(videoId = Guid.NewGuid(), new Video(){Id = videoId, GenreId = genreList[GetGenreByKey("Action")].Id, Name = "Terminator 2", DaysToBeRent = 3});
            videoList.Add(videoId = Guid.NewGuid(), new Video(){Id = videoId, GenreId = genreList[GetGenreByKey("Romantic")].Id, Name = "Titanic", DaysToBeRent = 2});
            videoList.Add(videoId = Guid.NewGuid(), new Video(){Id = videoId, GenreId = genreList[GetGenreByKey("Horror")].Id, Name = "Vampire", DaysToBeRent = 4});
            videoList.Add(videoId = Guid.NewGuid(), new Video(){Id = videoId, GenreId = genreList[GetGenreByKey("Comedy")].Id, Name = "Babies Day out", DaysToBeRent = 5});
            videoList.Add(videoId = Guid.NewGuid(), new Video(){Id = videoId, GenreId = genreList[GetGenreByKey("Action")].Id, Name = "Shaow of Worriors", DaysToBeRent = 3});
            

            Guid customerId;
            customerList.Add(customerId=Guid.NewGuid(), new Customer(){Id = customerId, FirstName = "Rahat", LastName = "Ahsan"});
            customerList.Add(customerId = Guid.NewGuid(), new Customer() { Id = customerId, FirstName = "Ferdous", LastName = "Alam" });
            customerList.Add(customerId = Guid.NewGuid(), new Customer() { Id = customerId, FirstName = "Christofer", LastName = "Simon" });
            customerList.Add(customerId = Guid.NewGuid(), new Customer() { Id = customerId, FirstName = "Marcelo", LastName = "Bustamante" });
            customerList.Add(customerId = Guid.NewGuid(), new Customer() { Id = customerId, FirstName = "Jawaad", LastName = "Rahman" });

        }

        #endregion


        #region Add Method

        //Add Method in Database Class
        public bool AddCustomer(string fName, string lName)
        {
            try
            {
                if (customerList.Any(kvp => kvp.Value.Name.Equals(fName + " " + lName)))
                {
                    return false;
                }
                else
                {
                    Guid customerId = Guid.NewGuid();
                    customerList.Add(customerId, new Customer() {Id = customerId, FirstName = fName, LastName = lName});
                    return true;
                }
            }
            catch
            {
                throw new VideoRentalException(new Customer() { Name = fName+" "+ lName });
            }
        }

        public bool AddGenre(string genreName)
        {
            try
            {
                if (genreList.Any(kvp => kvp.Value.Name.Equals(genreName)))
                {
                    return false;
                }
                else
                {
                    Guid genreId = Guid.NewGuid();
                    genreList.Add(genreId, new Genre() { Id = genreId, Name = genreName });
                    return true;
                }
            }
            catch 
            {
                throw new VideoRentalException(new Genre() { Name = genreName });
            }
            

        }

        public bool AddVideo(Guid genreId, string name, int daystobeRent)
        {
            try
            {
                if (videoList.Any(kvp => kvp.Value.Name.Equals(name)))
                {
                    return false;
                }
                else
                {
                    var videoId = Guid.NewGuid();
                    videoList.Add(videoId, new Video(){Id = videoId,GenreId = genreId,Name = name,IsRented = false, DaysToBeRent = daystobeRent});
                    return true;
                }
            }
            catch
            {
                throw new VideoRentalException(new Video(){ Name = name });
            }
        }

        #endregion


        #region Delete Method

        //Delete Method in Database Class
        public bool DeleteCustomer(Customer aCustomer)
        {
            try
            {
                foreach (KeyValuePair<Guid, Customer> customer in customerList)
                {
                    if (customer.Value.Equals(aCustomer))
                    {
                        return customerList.Remove(customer.Key);
                    }
                }
                return false;
            }
            catch 
            {
                throw new VideoRentalException(new Customer() { Name = aCustomer.Name });
            }
            
        }

        public bool DeleteGenre(Genre aGenre)
        {
            try
            {
                foreach (KeyValuePair<Guid, Genre> genreItem in genreList)
                {
                    if (genreItem.Value.Equals(aGenre))
                    {
                        return genreList.Remove(genreItem.Key);
                    }
                  
                }
                return false;
            }
            catch 
            {
                throw new VideoRentalException(new Genre(){Name = aGenre.Name});
            }
            
        }

        public bool DeleteVideo(Video aVideo)
        {
            try
            {
                foreach (KeyValuePair<Guid, Video> video in videoList)
                {
                    if (video.Value.Equals(aVideo))
                    {
                        return videoList.Remove(video.Key);
                    }
                }
                return false;
            }
            catch
            {
                throw new VideoRentalException(new Video() { Name = aVideo.Name });
            }

        }

        #endregion


        #region Update Method

       
        public bool UpdateCustomer(Guid key, string firstName, string lastName)
        {
            try
            {
                if (customerList.Any(kvp => kvp.Value.Name.Equals(firstName + " " + lastName)))
                {
                    return false;
                }

                else
                {
                    customerList[key].FirstName = firstName;
                    customerList[key].LastName = lastName;
                    return true;
                }
            }
            catch
            {
                throw new VideoRentalException(new Customer() {Name = firstName + " " + lastName});
            }
        }

        public bool UpdateGenre(Guid key, string newGenre)
        {

            try
            {
                if (genreList.Any(kvp => kvp.Value.Name.Equals(newGenre)))
                {
                    return false;
                }
                else
                {
                    genreList[key].Name = newGenre;
                    return true;
                
                }
               
            }
            catch
            {
                throw new VideoRentalException(new Genre(){Name = newGenre});
            }
        }

        public bool UpdateVideo(Guid videoId, Guid genreId, string name, int daystobeRent)
        {
            try
            {

                videoList[videoId].GenreId = genreId;
                videoList[videoId].Name = name;
                videoList[videoId].DaysToBeRent = daystobeRent;
                return true;
                
            }
            catch
            {
                throw new VideoRentalException(new Video() { Name = name });
            }
        }

        #endregion


        #region Get Method
        
        public IEnumerable<Genre> GetGenre()
        {
            //var gnrlist = from genre in genreList
            //              select genre;
             
             return genreList.Values;

        }

        public Guid GetGenreByKey(string oldGenre)
        {
            var key = (from KeyValuePair<Guid, Genre> kvp in genreList
                       where kvp.Value.Name.Equals(oldGenre)
                       select kvp.Key).FirstOrDefault();
            return key;
        }

        public IEnumerable<Customer> GetCustomer()
        {
            return customerList.Values;
        }

        public IEnumerable<Video> GetVideo()
        {
            return videoList.Values;
        }

        public IEnumerable<VideoBooking> GetBookingList()
        {
            return bookingList.Values;
        }

        public bool IsExistsGenre(string name)
        {
            if (genreList.Any(kvp => kvp.Value.Name.Equals(name)))
            {
                return true;
            }
            return false;
        }

        
           #endregion


        #region Rent/Return Method

        public bool RentVideo(Guid videoId,  Guid customerId, DateTime rentDate)
        {
            try
            {
                var bookingId = Guid.NewGuid();
                var genreId = ((from vdo in videoList
                                where vdo.Value.Id.Equals(videoId)
                                select vdo).FirstOrDefault()).Value.GenreId;
            
              
                bookingList.Add(bookingId, 
                                new VideoBooking()
                                    {Id=bookingId,VideoId=videoId,GenreId = genreId,CustomerId=customerId,
                                        RentDate = rentDate});
                var videos = GetVideo();
                foreach (var video in videos.Where(video => video.Id == videoId))
                {
                    video.IsRented = true;
                }
            
                return true;
            }
            catch
            {
                throw new VideoRentalException(new Video() { Name = videoList[videoId].Name });
            }
        }

        public bool ReturnVideo(VideoBooking videoBooking)
        {
            try
            {
                var videos = GetVideo().ToList();
                
                if (!videos.Any(v=>v.Id.Equals(videoBooking.VideoId))) 
                 throw new VideoRentalException(new Video() { Name = videoList[videoBooking.VideoId].Name });

                if(!bookingList.Any(bk=>bk.Key.Equals(videoBooking.Id)))
                    throw new VideoRentalException(new Video() { Name = videoList[videoBooking.VideoId].Name });

                bookingList[videoBooking.Id].ReturnDate = videoBooking.ReturnDate;
                bookingList[videoBooking.Id].Cost = videoBooking.Cost;


                var selectedVideo = videos.First(v => v.Id.Equals(videoBooking.VideoId));
                if (selectedVideo != null)
                {
                    videoList[selectedVideo.Id].IsRented = false;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw new VideoRentalException(new Video() { Name = videoList[videoBooking.VideoId].Name });
            }
            
        }

        

        

        #endregion

    }
}