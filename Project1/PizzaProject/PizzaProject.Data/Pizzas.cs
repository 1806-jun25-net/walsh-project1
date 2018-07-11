using System;
using System.Collections.Generic;

namespace PizzaProject.Data
{
    public partial class Pizzas
    {
        public Pizzas()
        {
            Orders = new HashSet<Orders>();
            PizzaToppings = new HashSet<PizzaToppings>();
        }

        public int PizzasId { get; set; }

        public ICollection<Orders> Orders { get; set; }
        public ICollection<PizzaToppings> PizzaToppings { get; set; }
    }
}
