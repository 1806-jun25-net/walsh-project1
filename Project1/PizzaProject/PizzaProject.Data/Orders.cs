using System;
using System.Collections.Generic;

namespace PizzaProject.Data
{
    public partial class Orders
    {
        public int OrdersId { get; set; }
        public int UsersId { get; set; }
        public int LocationsId { get; set; }
        public int ToppingsId { get; set; }
        public int PizzasId { get; set; }
        public DateTime OrderTime { get; set; }

        public Locations Locations { get; set; }
        public Pizzas Pizzas { get; set; }
        public Toppings Toppings { get; set; }
        public Users Users { get; set; }
    }
}
