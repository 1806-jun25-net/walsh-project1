using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject.Library.Models
{
    public class Pizza
    {
        /*
         * Toppings: Pepperoni, Sauce, Cheese, Chicken, Sausage, Peppers, Onions
         *           Jalapenos.
         *           
         * Crust: Small, Medium Large
         */

        public List<string> Toppings { get; set; }
        public string Size { get; set; }

    }
}
  