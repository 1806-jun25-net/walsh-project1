using System;
using System.Collections.Generic;

namespace PizzaProjectWebApp.Models
{
    public partial class PizzaOrders
    {
        public int OrdersId { get; set; }
        public int PizzasId { get; set; }

        public Orders Orders { get; set; }
        public Pizzas Pizzas { get; set; }
    }
}
