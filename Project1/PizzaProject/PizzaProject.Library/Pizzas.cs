using System;
using System.Collections.Generic;

namespace PizzaProject.Library
{
    public partial class Pizzas
    {
        public Pizzas()
        {
            PizzaOrders = new HashSet<PizzaOrders>();
        }

        public int PizzasId { get; set; }
        public int Small { get; set; }
        public int Medium { get; set; }
        public int Large { get; set; }
        public int Sauce { get; set; }
        public int Cheese { get; set; }
        public int Pepperoni { get; set; }
        public int Sausage { get; set; }
        public int PizzaCost { get; set; }

        public ICollection<PizzaOrders> PizzaOrders { get; set; }
    }
}
