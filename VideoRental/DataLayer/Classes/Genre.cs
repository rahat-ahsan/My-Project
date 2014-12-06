using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Interfacess;

namespace DataLayer.Classes
{
    public class Genre: IItem

    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        
    }
}
