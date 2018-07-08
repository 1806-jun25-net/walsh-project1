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
     * Ingredients: Pepperoni, Cheese, Chicken, Sauce, Sausage
          
       Crust: Small, Medium Large
    */
    public static int Pepperoni { get; set; } 
    public static int Cheese { get; set; } 
    public static int Sauce { get; set; }
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

    // checks if there is enough inventory for order 
    public bool CheckOrder( Order order )
    {
        bool enough = true;

        int smallCrust = 0;
        int mediumCrust = 0;
        int largeCrust = 0;
        int pepperoni = 0;
        int cheese = 0;
        int sausage = 0;

        foreach (Pizza pizza in order.PizzaOrder)
        {

        }
        return true;
    }

    /* Inventory:
     * Ingredients: Pepperoni, Cheese, Chicken, Sausage
          
       Crust: Small, Medium, Large
    */
    public void UsePepperoni()
    {
        Pepperoni -= 10;
    }

    public void UseCheese()
    {
        Cheese -= 1;
    }

    public void UseChicken()
    {
        Chicken -= 10;
    }

    public void UseSauce()
    {
        Sauce -= 1;
    }
    public void UseSausage()
    {
        Sausage -= 10;
    }

    public void UseSmallDough()
    {
        SmallCrust -= 1;
    }

    public void UseMediumDough()
    {
        MediumCrust -= 1;
    }

    public void UseLargeDough()
    {
        LargeCrust -= 1;
    }

}
