using PizzaProject.Library.Interfaces;
using PizzaProject.Library.Models;
using System;
using System.Collections;
using System.Collections.Generic;

// class Location holds a pizza chain location
// with order history and inventory. Rejects order
// if inventory is not sufficient. Decrements inventory
// when orders are accepted. 
public class Location
{
    public string LocationName { get; set; }

    /* Inventory:
     * Ingredients: Pepperoni, Cheese, Chicken, Sausage
          
       Crust: Small, Medium Large
    */
    public static int Pepperoni { get; set; } 
    public static int Cheese { get; set; } 
    public static int Chicken { get; set; } 
    public static int Sausage { get; set; }  
    public static int SmallCrust { get; set; } 
    public static int MediumCrust { get; set; } 
    public static int LargeCrust { get; set; } 

    public static List<Order> OrderHistory { get; set; }
    
    // sets location name and inventory amount
    public Location(string name)
    {
        if (name == "Location 1")
        {
            LocationName = name;
            Pepperoni = 5000;
            Cheese = 5000;
            Chicken = 5000;
            Sausage = 5000;
            SmallCrust = 5000;
            MediumCrust = 5000;
            LargeCrust = 5000;
        }

        if (name == "Location 2")
        {
            LocationName = name;
            Pepperoni = 2500;
            Cheese = 2500;
            Chicken = 2500;
            Sausage = 2500;
            SmallCrust = 2500;
            MediumCrust = 2500;
            LargeCrust = 2500;
        }
    }

    public void AddOrder(Order order )
    {
        OrderHistory.Add(order);
    }

    public bool CheckInventory( Order order )
    {

        return true;
    }

     public void UseInventory(Order order) { }



}
