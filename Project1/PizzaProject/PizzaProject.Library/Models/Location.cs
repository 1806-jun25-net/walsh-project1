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
     * Ingredients: Pepperoni, Cheese, Sauce, Sausage
          
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
    public Location(string name, int size)
    {
        if (name == "Location 1")
        {
            LocationName = name;
            Pepperoni = size;
            Cheese = size;
            Sauce = size;
            Sausage = size;
            SmallCrust = size;
            MediumCrust = size;
            LargeCrust = size;
        }

        if (name == "Location 2")
        {
            LocationName = name;
            Pepperoni = size / 2;
            Cheese = size / 2;
            Sauce = size / 2;
            Sausage = size / 2;
            SmallCrust = size / 2;
            MediumCrust = size / 2;
            LargeCrust = size / 2; 
        }
    }

    public void AddOrderHistory(Order order )
    {
        OrderHistory.Add(order);
    }

    // checks if there is enough inventory for order by adding all the ingredients on each pizza in the order
    // and then checking the inventory contents. Returns true if there are enough items in inventory, false if otherwise
    public bool EnoughInventory(List<Pizza> Pizzas)
    {
        bool enough = true;


        int pepperoni = 0;
        int cheese = 0;
        int sauce = 0;
        int sausage = 0;
        int smallDough = 0;
        int mediumDough = 0;
        int largeDough = 0;

        // count all the ingredients in all the pizzas
        foreach(Pizza pizza in Pizzas)
        {
            CountPizzaIngredients(pizza, ref pepperoni, ref cheese, ref sauce, ref sausage, ref smallDough, 
                                  ref mediumDough, ref largeDough);
        }

        // compare toppings to the inventory. Each pepperoni and sausage order uses 10 of each. 
        // All other ingredients only use 1 item in inventory
        // 
        if((10 * pepperoni) > Pepperoni)
            enough = false;
        else if((10 * sausage) > Sausage)
            enough = false;
        else if(cheese > Cheese)
            enough = false;
        else if(sauce > Sauce)
            enough = false;
        else if(smallDough > SmallCrust)
            enough = false;
        else if(mediumDough > MediumCrust)
            enough = false;
        else if(largeDough > LargeCrust)
            enough = false;

        return enough;
    }

    // iterates through each topping on pizza and returns as reference the total number of 
    // ingredients it will take to make that pizza
    public void CountPizzaIngredients(Pizza pizza, ref int pepperoni, ref int cheese, ref int sauce, ref int sausage,
                                        ref int smallCrust, ref int mediumCrust, ref int largeCrust )
    {
        // count crust
        if (pizza.CrustSize == "small")
            smallCrust++;
        else if (pizza.CrustSize == "medium")
            mediumCrust++;
        else
            largeCrust++;

        // count ingredients
        foreach(string topping in pizza.ToppingsList)
        {
            if(topping == "pepperoni")
                pepperoni++;
            else if(topping == "cheese")
                cheese++;
            else if(topping == "sauce")
                sauce++;
            else
                sausage++;

        }
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
