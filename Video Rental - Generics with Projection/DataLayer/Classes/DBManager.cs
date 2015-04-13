using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;
using DataLayer.Interfacess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace DataLayer.Classes
{
    public class DBManager:IDatabase
    {
        private readonly string connectionString = 
            ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        #region GetConnection and Command 
        public SqlConnection GetConnection()
        {
            var conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        public SqlCommand GetCommand(string sql, SqlConnection conn, CommandType type = CommandType.StoredProcedure, IEnumerable<SqlParameter> parameters = null)
        {
            var cmd = new SqlCommand(sql, conn) { CommandType = type };
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters.ToArray());
            }
            return cmd;
        }

        private bool ExecuteSqlCommand(string sql, List<SqlParameter> parameters)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    using (SqlCommand cmd = GetCommand(sql, conn, CommandType.StoredProcedure,
                        parameters))
                    {
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                            return true;
                        else return false;

                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch
            {
                throw;
            }
        }

        #endregion

        #region Add Method

        public bool AddCustomer(Customer customer)
        {
            try
            {
                List<SqlParameter> parameters = GetInsertParameters<Customer>((Customer)customer);
                RemoveParameter(parameters, "Name");
                return ExecuteSqlCommand("spAddCustomer", parameters);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch
            {
                throw;
            }
        }

        public bool AddGenre(Genre genre)
        {
            try
            {
                List<SqlParameter> parameters = GetInsertParameters<Genre>((Genre) genre);
                return ExecuteSqlCommand("spAddGenre", parameters);
                
            }
            catch (SqlException ex)
            {
                throw ex;
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
                List<SqlParameter> parameters = GetInsertParameters<Video>((Video)video);
                return ExecuteSqlCommand("spAddVideo", parameters);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch
            {
                throw;
            }
        }

#endregion

        #region Get SQL Parameter

        private List<SqlParameter> GetInsertParameters<T>(T item)
        {
            List<SqlParameter> param = new List<SqlParameter>();
            foreach (var property in item.GetType().GetProperties())
            {
                if (property.CanRead)
                {
                    if (property.Name.Equals("Id"))
                    {
                        // skip Id property
                    }
                    else
                        // Create parameter for a property which is not the Id property
                        param.Add(new SqlParameter(property.Name, property.GetValue(item)));
                }
            }
            return param;
        }

        private List<SqlParameter> GetDeleteParameters<T>(T item)
        {
            List<SqlParameter> param = new List<SqlParameter>();
            foreach (var property in item.GetType().GetProperties())
            {
                if (property.CanRead)
                {
                    if (property.Name.Equals("Id"))
                    {
                         param.Add(new SqlParameter(property.Name, property.GetValue(item)));
                    }
                }

            }
            return param;
        }

        private List<SqlParameter> GetUpdateParameters<T>(Guid key, T item)
        {
            List<SqlParameter> param = new List<SqlParameter>();
            foreach (var property in item.GetType().GetProperties())
            {
                if (property.CanRead)
                {
                    if (property.Name.Equals("Id"))
                    {

                        param.Add(new SqlParameter(property.Name, key));
                    }
                    else
                        // Create parameter for a property which is not the Id property
                        param.Add(new SqlParameter(property.Name, property.GetValue(item)));
                }
            }
            return param;
        }

        private List<SqlParameter> GetBookingParameters(VideoBooking videoBooking, bool status = false)
        {
            List<SqlParameter> param = new List<SqlParameter>();

            if (!status)
            {
                param.Add(new SqlParameter("CustomerId", videoBooking.CustomerId));
                param.Add(new SqlParameter("VideoId", videoBooking.VideoId));
                param.Add(new SqlParameter("RentDate", videoBooking.RentDate));
            }
            else
            {
                // Create parameter for a property which is not the Id property
                param.Add(new SqlParameter("Id", videoBooking.Id));
                param.Add(new SqlParameter("ReturnDate", videoBooking.ReturnDate));
                param.Add(new SqlParameter("Cost", videoBooking.Cost));
            }

            return param;
        }

        private void RemoveParameter(List<SqlParameter> param, string parameterName)
        {
            SqlParameter p = param.Find(P => P.ParameterName.Equals(parameterName));
            param.Remove(p);
        }

#endregion
        

        #region Delete Method

        public bool DeleteCustomer(Customer aCustomer)
        {
            try
            {
                List<SqlParameter> parameters = GetDeleteParameters<Customer>((Customer)aCustomer);
                return ExecuteSqlCommand("spDeleteCustomer", parameters);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
             catch (VideoRentalException ex)
            {
                throw new VideoRentalException(new Customer() { Name = aCustomer.Name });
            }
            catch
            {
                throw;
            }
        }

        public bool DeleteGenre(Genre genre)
        {
            try
            {
                List<SqlParameter> parameters = GetDeleteParameters<Genre>((Genre)genre);
                return ExecuteSqlCommand("spDeleteGenre", parameters);

            }
            catch (SqlException ex)
            {
                throw ex;
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
                List<SqlParameter> parameters = GetDeleteParameters<Video>((Video)aVideo);
                return ExecuteSqlCommand("spDeleteVideo", parameters);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch
            {
                throw;
            }
        }

#endregion


        #region Update Method

        public bool UpdateCustomer(Guid key, Customer newCustomer)
        {
            try
            {
                List<SqlParameter> parameters = GetUpdateParameters<Customer>(key, (Customer)newCustomer);
                RemoveParameter(parameters, "Name");
                return ExecuteSqlCommand("spUpdateCustomer", parameters);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch
            {
                throw;
            }
        }

        public bool UpdateGenre(Guid key, Genre newGenre)
        {
            try
            {
                List<SqlParameter> parameters = GetUpdateParameters<Genre>(key, (Genre)newGenre);
                return ExecuteSqlCommand("spUpdateGenre", parameters);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch
            {
                throw;
            }
            
        }

        
        public bool UpdateVideo(Guid key, Video newVideo)
        {
            try
            {
                List<SqlParameter> parameters = GetUpdateParameters<Video>(key, (Video)newVideo);
                return ExecuteSqlCommand("spUpdateVideo", parameters);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch
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
                using (var conn = GetConnection())
                {
                    using (SqlCommand cmd = GetCommand("spGetCustomer", conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        var customerList = new List<Customer>();
                        while (reader.Read())
                        {
                            var customer = new Customer();
                            customer.Id = (Guid)reader["Id"];
                            customer.FirstName = reader["FirstName"].ToString();
                            customer.LastName = reader["LastName"].ToString();
                            customerList.Add(customer);
                        }
                        return (IEnumerable<Customer>)customerList;
                        
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Video> GetVideo()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    using (SqlCommand cmd = GetCommand("spGetVideo", conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        var videoList = new List<Video>();
                        while (reader.Read())
                        {
                            var video = new Video();
                            video.Id = (Guid)reader["Id"];
                            video.GenreId = (Guid)reader["GenreId"];
                            video.Name = reader["Name"].ToString();
                            video.DaysToBeRent = Convert.ToInt32(reader["DaysToBeRent"].ToString());
                            videoList.Add(video);
                        }
                        return (IEnumerable<Video>) videoList;
                        
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Genre> GetGenre()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    using (SqlCommand cmd = GetCommand("spGetGenre", conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        List<Genre> genreList = new List<Genre>();
                        while (reader.Read())
                        {
                            var genre = new Genre();
                            genre.Id = (Guid)reader["Id"];
                            genre.Name = reader["Name"].ToString();
                            genreList.Add(genre);
                        }

                        return ((IEnumerable<Genre>) genreList);
                    }
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<VideoBooking> GetBookingList()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    using (SqlCommand cmd = GetCommand("spGetBooking", conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        var bookingList = new List<VideoBooking>();
                        
                        while (reader.Read())
                        {
                            string dt = "";
                            var booking = new VideoBooking();
                            booking.Id= (Guid) (reader["Id"]);
                            booking.VideoId = (Guid)reader["VideoId"];
                            booking.CustomerId = (Guid) reader["CustomerId"];
                            //booking.RentDate = (DateTime) reader["RentDate"];
                            //booking.ReturnDate =  (DateTime)reader["ReturnDate"];
                            //booking.Cost= Convert.ToDouble(reader["Cost"].ToString());

                            //booking.ReturnDate = (reader["ReturnDate"] != DBNull) ? (DateTime)reader["ReturnDate"] : (DateTime)(dt).ToString();
                        }

                        return bookingList;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch
            {
                throw;
            }
        }

        public List<ListViewItem> GetAvailableVideo()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    using (SqlCommand cmd = GetCommand("spGetAvailableVideo", conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        var availableVideoList = new List<ListViewItem>();
                        while (reader.Read())
                        {
                            var availableVideo = new ListViewItem(((Guid)reader["Id"]).ToString());

                                 availableVideo.SubItems.Add(reader["Name"].ToString());
                                 availableVideo.SubItems.Add(reader["Genre"].ToString());
                                 availableVideo.SubItems.Add((reader["DaysToBeRent"]).ToString());
                                 
                               availableVideoList.Add(availableVideo);
                        }

                        return availableVideoList;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch
            {
                throw;
            }
        }

        


        public List<ListViewItem> GetBookingListView()
        {
            using (var conn = GetConnection())
            {
                using (SqlCommand cmd = GetCommand("spGetBookingView", conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    var bookingList = new List<ListViewItem>();
                    while (reader.Read())
                    {
                        var booking = new ListViewItem(((Guid)reader["Id"]).ToString());


                        booking.SubItems.Add(reader["FullName"].ToString());
                        booking.SubItems.Add(reader["Video"].ToString());
                        booking.SubItems.Add((reader["Genre"]).ToString());
                        booking.SubItems.Add((reader["RentDate"]).ToString());
                        booking.SubItems.Add((reader["ReturnDate"]).ToString());
                        booking.SubItems.Add((reader["Cost"]).ToString());

                        bookingList.Add(booking);
                    }

                    return bookingList;
                }
            }
        }

        public VideoBooking GetSelectedBooking(Guid bookingId)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    var param = new SqlParameter("Id", bookingId);
                    var parameters = new List<SqlParameter> { param };

                    using (SqlCommand cmd = GetCommand("spGetSelectedBooking", conn, CommandType.StoredProcedure, parameters))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        var booking = new VideoBooking();

                        while (reader.Read())
                        {
                            booking.Id = (Guid)(reader["Id"]);
                            booking.VideoId = (Guid)reader["VideoId"];
                            booking.CustomerId = (Guid)reader["CustomerId"];
                            booking.RentDate = (DateTime)reader["RentDate"];
                            //booking.ReturnDate = (reader["ReturnDate"] == DBNull.Value) ? reader["ReturnDate"].ToString() : Convert.ToDateTime(reader["ReturnDate"]);
                            //booking.Cost = (reader["Cost"] != DBNull.Value) ? Convert.ToDouble(string.Empty) : Convert.ToDouble(reader["Cost"]);
                        }

                        return booking;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch
            {
                throw;
            }
        }


        #endregion


        public bool RentVideo(VideoBooking videoBooking)
        {
            try
            {
                List<SqlParameter> parameters = GetBookingParameters(videoBooking);
                return ExecuteSqlCommand("spAddBooking", parameters);

            }
            catch (SqlException ex)
            {
                throw ex;
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
                List<SqlParameter> parameters = GetBookingParameters(videoBooking, true);
                return ExecuteSqlCommand("spUpdateBooking", parameters);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch
            {
                throw;
            }
        }

        
    }
}
