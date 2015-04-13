using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Classes
{
    public class ListViewAvailableVideo
    {
        public string  VideoName { get; set; }
        public string GenreName { get; set; }
        public int DaysToBeRent { get; set; }

        public string[] ToArray()
        {
            return new string[] { VideoName.ToString(), GenreName.ToString(),DaysToBeRent.ToString() };
            //return "";
        }
    }
}
