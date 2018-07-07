﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject.Library.Models
{
    public class Location2 
    {
        public string LocationName { get; set; } = "Location 2";

        // IAddress implementation
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }


        public List<Order> OrderHistory { get; set; }

        /* Inventory:
         * Ingredients: Pepperoni, Cheese, Chicken, Sausage, Onions

           Crust: Small, Medium Large
        */
        public static int Pepperoni { get; set; }
        public static int Cheesse { get; set; }
        public static int Chicken { get; set; }
        public static int Sausage { get; set; }
        public static int Onions { get; set; }
        public static int SmallCrust { get; set; }
        public static int MediumCrust { get; set; }
        public static int LargeCrust { get; set; }

        /*take order value and check if there are enough inventory items to make order. 
        public Location1( Order order )
        {
            // check all items if there are enough



        }
        */


        // public bool CheckInventory(Order order);
        // public void UseInventory(Order order); 

    }
}
