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
        public double Cost { get; set; }
        public string CrustSize { get; set; }

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
            if(CrustSize == "small")
                total += 6;
            else if(CrustSize == "medium")
                total += 8;
            // large
            else
                total += 10;

            // cost from toppings. Sauce and cheese do not add more to the price
            foreach(string item in ToppingsList)
            {
                if(item == "Pepperoni")
                    total += 1;

                if(item == "Sausage")
                    total += 1;
            }

            Cost = total;
        }
    }
}
  