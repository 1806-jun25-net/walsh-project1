using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject.Library.Models
{
    public class Pizza
    {
        /*
         * Toppings: Pepperoni, Sauce, Cheese, Sausage
         *           
         * Crust: Small, Medium Large
         */
        public List<string> Toppings { get; set; } = new List<string>();
        public string Size { get; set; }
        public double TotalCost { get; set; }
       


        // set toppings and crust
        public Pizza( List<string> tops, string crust )
        {
            Size = crust;
            Toppings = tops;

        }

        public 
    }
}
  