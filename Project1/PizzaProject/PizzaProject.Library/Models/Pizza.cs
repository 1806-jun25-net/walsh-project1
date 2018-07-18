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
        public List<string> ToppingsList { get; set; }
        public int Cost { get; set; }
        public string CrustSize { get; set; }

        // different implementation 
        public int Small { get; set; }
        public int Medium { get; set; }
        public int Large { get; set;  }
        public int Cheese { get; set; }
        public int Sauce { get; set; }
        public int Pepperoni { get; set; }
        public int Sausage { get; set; }

        // empty constructor
        public Pizza()
        {
            Small = 0;
            Medium = 0;
            Large = 0;
            Cheese = 0;
            Sauce = 0;
            Pepperoni = 0;
            Sausage = 0;

        }
        // set toppings and crust
        public Pizza( string crust, List<string> tops )
        {
            CrustSize = crust;
            ToppingsList = tops;

        }

        // calculates total cost of pizza from crust size and types of toppings
        // sets class member TotalCost
        public void CalculateCost( )
        {
            int total = 0;

            // cost from crust
            if(Small == 1)
                total += 6;
            else if(Medium == 1)
                total += 8;
            // large
            else
                total += 10;

            if(Pepperoni == 1)
                total += 1;

            if(Sausage == 1)
                total += 1;

            Cost = total;
        }

       

    }
}
  