using System;
using System.Collections.Generic;

namespace PizzaProject.Library
{
    public partial class Locations
    {
        public Locations()
        {
            OrdersNavigation = new HashSet<Orders>();
        }

        public int LocationsId { get; set; }
        public int UsersId { get; set; }
        public int OrdersId { get; set; }
        public int Small { get; set; }
        public int Medium { get; set; }
        public int Large { get; set; }
        public int Sauce { get; set; }
        public int Cheese { get; set; }
        public int Pepperoni { get; set; }
        public int Sausage { get; set; }

        public Orders Orders { get; set; }
        public Users Users { get; set; }
        public ICollection<Orders> OrdersNavigation { get; set; }
    }
}
