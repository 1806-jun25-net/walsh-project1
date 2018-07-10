using System;
using System.Collections.Generic;

namespace PizzaProject.Data
{
    public partial class Toppings
    {
        public Toppings()
        {
            PizzaToppings = new HashSet<PizzaToppings>();
        }

        public int ToppingsId { get; set; }
        public int Small { get; set; }
        public int Medium { get; set; }
        public int Large { get; set; }
        public int Sauce { get; set; }
        public int Cheese { get; set; }
        public int Pepperoni { get; set; }
        public int Sausage { get; set; }

        public ICollection<PizzaToppings> PizzaToppings { get; set; }
    }
}
