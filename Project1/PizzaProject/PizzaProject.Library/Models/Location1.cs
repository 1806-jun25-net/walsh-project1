using PizzaProject.Library.Interfaces;
using PizzaProject.Library.Models;
using System;
using System.Collections;
using System.Collections.Generic;

// class Location holds a pizza chain location
// with order history and inventory. Rejects order
// if inventory is not sufficient. Decrements inventory
// when orders are accepted. 
public class Location1 : Location, IAddress
{
    public string LocationName { get; set; } = "Location 1";

    /* Inventory:
     * Ingredients: Pepperoni, Cheese, Chicken, Sausage
          
       Crust: Small, Medium Large
    */
    public static int Pepperoni { get; set; } = 5000;
    public static int Cheesse { get; set; } = 5000;
    public static int Chicken { get; set; } = 5000;
    public static int Sausage { get; set; } = 5000;
    public static int Onions { get; set; } = 5000;
    public static int SmallCrust { get; set; } = 5000;
    public static int MediumCrust { get; set; } = 5000;
    public static int LargeCrust { get; set; } = 5000;

    public static List<Order> OrderHistory { get; set; } 

    

    // default empty constructor
    public Location1()
    {

    }

    // take order value and check if there are enough inventory items to make order. 
    public Location1( Order order )
    {
       



    }


    public bool CheckInventory( Order order )
    {

        return true;
    }

     public void UseInventory(Order order) { }



}
