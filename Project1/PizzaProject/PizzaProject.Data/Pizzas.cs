using System;
using System.Collections.Generic;

namespace PizzaProject.Data
{
    public partial class Pizzas
    {
        public Pizzas()
        {
            PizzaToppings = new HashSet<PizzaToppings>();
        }

        public int PizzasId { get; set; }

        public ICollection<PizzaToppings> PizzaToppings { get; set; }
    }
}
