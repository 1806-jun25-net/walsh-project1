using PizzaProject.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject.Library
{
    class Mapper
    {
        public static Pizzas Map(Pizza pie ) => new Pizzas
        {
            Small = pie.Small,
            Medium = pie.Medium,
            Large = pie.Large,
            Pepperoni = pie.Pepperoni,
            Sausage = pie.Sausage,
            Cheese = pie.Cheese,
            Sauce = pie.Sauce,
            PizzaCost = pie.Cost,
        };
    }
}
