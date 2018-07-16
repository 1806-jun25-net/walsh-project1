using System;
using System.Collections.Generic;

namespace PizzaProjectWebApp.Models
{
    public partial class Users
    {
        public Users()
        {
            Locations = new HashSet<Locations>();
            Orders = new HashSet<Orders>();
        }

        public int UsersId { get; set; }
        public int? LocationsId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public ICollection<Locations> Locations { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
