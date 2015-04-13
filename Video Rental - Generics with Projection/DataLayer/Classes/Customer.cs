using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Interfacess;

namespace DataLayer.Classes
{
    public class Customer : IItem

    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name
        {
            get { return FirstName + " " + LastName; }
            set { } // TODO: Don't add a set-block unless it should be possible to add a value with the property
        }
        
        //TODO: Generally you add a constructor to a class to be able to set property values
    }
}
