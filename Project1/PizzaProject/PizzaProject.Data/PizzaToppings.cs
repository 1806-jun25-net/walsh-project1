using System;
using System.Collections.Generic;

namespace PizzaProject.Data
{
    public partial class PizzaToppings
    {
        public int PizzasId { get; set; }
        public int ToppingsId { get; set; }

        public Pizzas Pizzas { get; set; }
        public Toppings Toppings { get; set; }
    }
}
