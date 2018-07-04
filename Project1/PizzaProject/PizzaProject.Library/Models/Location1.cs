using PizzaProject.Library.Models;
using System;
using System.Collections;
using System.Collections.Generic;

// class Location holds a pizza chain location
// with order history and inventory. Rejects order
// if inventory is not sufficient. Decrements inventory
// when orders are accepted. 
public class Location1 
{
    private readonly string locationName = "Location 1";

    public string LocationName { get;   }
    public List<Order> OrderHistory { get; set; }
   
    /* Inventory:
     * Ingredients: Pepperoni, Cheese, Chicken, Sausage, Onions
          
       Crust: Small, Medium Large
    */
    public static int Pepperoni { get; set; }
    public static int Cheesse { get; set; }
    public static int Chicken { get; set; }
    public static int Sausage { get; set; }
    public static int Onions { get; set;  }
    public static int SmallCrust { get; set; }
    public static int MediumCrust { get; set; }
    public static int LargeCrust { get; set; }

    // take order value and check if there are enough inventory items to make order. 
    public Location1(Order order )
    {
        // check all items if there are enough


    }



   // public bool CheckInventory(Order order);
    // public void UseInventory(Order order); 


    
}
