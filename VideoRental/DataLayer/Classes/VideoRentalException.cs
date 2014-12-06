using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Interfacess;

namespace DataLayer.Classes
{
    public class VideoRentalException: ApplicationException
    {
        
        public IItem Item { get; set; }

        public VideoRentalException(IItem item)
        {
            Item = item;
        }
    }
}
