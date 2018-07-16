using System;
using System.Collections.Generic;

namespace PizzaProjectWebApp.Models
{
    public partial class Orders
    {
        public Orders()
        {
            Locations = new HashSet<Locations>();
            PizzaOrders = new HashSet<PizzaOrders>();
        }

        public int OrdersId { get; set; }
        public int UsersId { get; set; }
        public int LocationsId { get; set; }
        public DateTime OrderTime { get; set; }
        public int OrderCost { get; set; }

        public Locations LocationsNavigation { get; set; }
        public Users Users { get; set; }
        public ICollection<Locations> Locations { get; set; }
        public ICollection<PizzaOrders> PizzaOrders { get; set; }
    }
}
