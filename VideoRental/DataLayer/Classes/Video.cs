using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Interfacess;

namespace DataLayer.Classes
{
    public class Video: IItem
    {
        public Guid Id { get; set; }
        public Guid GenreId { get; set; }
        public string Name { get; set; }
        public bool IsRented { get; set; }
        public int DaysToBeRent { get; set; }
        
    }
}
