using PizzaProject.Library.Models;
using System.Collections.Generic;

// class Location holds a pizza chain location
// with order history and inventory. Rejects order
// if inventory is not sufficient. Decrements inventory
// when orders are accepted. 
public class Location
{
    public int LocationName { get; set; }

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

    // order toppings count from pizza orders
    private int pepperoni;
    private int cheese;
    private int sauce;
    private int sausage;
    private int smallCrust;
    private int mediumCrust;
    private int largeCrust;

    public static List<Order> OrderHistory { get; set; }
    
    // sets location name and inventory amount
    public Location(int name, int size)
    {
        if (name == 1)
        {
            LocationName = name;
            Pepperoni = size * 10;
            Cheese = size;
            Sauce = size;
            Sausage = size * 10;
            SmallCrust = size;
            MediumCrust = size;
            LargeCrust = size;
        }

        if (name == 2)
        {
            LocationName = name;
            Pepperoni = (size * 10) / 2;
            Cheese = size / 2;
            Sauce = size / 2;
            Sausage = (size * 10) / 2;
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

        // initialize number of toppings in class
        pepperoni = 0;
        cheese = 0;
        sauce = 0;
        sausage = 0;
        smallCrust = 0;
        mediumCrust = 0;
        largeCrust = 0;

        // count all the ingredients in all the pizzas
        foreach(Pizza pizza in Pizzas)
        {
            CountPizzaIngredients(pizza);
        }

        // compare toppings to the inventory. Each pepperoni and sausage order uses 10 of each. 
        // All other ingredients only use 1 item in inventory
        
        if((10 * pepperoni) > Pepperoni)
            enough = false;
        else if((10 * sausage) > Sausage)
            enough = false;
        else if(cheese > Cheese)
            enough = false;
        else if(sauce > Sauce)
            enough = false;
        else if(smallCrust > SmallCrust)
            enough = false;
        else if(mediumCrust > MediumCrust)
            enough = false;
        else if(largeCrust > LargeCrust)
            enough = false;

        return enough;
    }

    // iterates through each topping on pizza and returns as reference the total number of 
    // ingredients it will take to make that pizza
    public void CountPizzaIngredients(Pizza pizza)
    {
        if(pizza.Small== 1)
            smallCrust ++;
        if(pizza.Medium == 1)
            mediumCrust++;
        if(pizza.Large == 1)
            largeCrust++;
        if(pizza.Cheese == 1)
            cheese++;
        if(pizza.Sauce == 1)
            sauce++;
        if(pizza.Pepperoni == 1)
            pepperoni++;
        if(pizza.Sausage == 1)
            sausage++;
    }

    /* Inventory:
     * Ingredients: Pepperoni, Cheese, Chicken, Sausage
          
       Crust: Small, Medium, Large
    */
    public void UseInventory()
    {
        SmallCrust -= smallCrust;
        MediumCrust -= mediumCrust;
        LargeCrust -= largeCrust;
        Pepperoni -= 10 * pepperoni;
        Sausage -= 10 * sausage;
        Cheese -= cheese;
        Sauce -= sauce;
    }

    public override string ToString( )
    {
        string str = $"Small: {SmallCrust}, Medium: {MediumCrust}, Large: {LargeCrust}, Cheese: {Cheese} " +
                     $"Sauce: {Sauce}, Pepperoni: {Pepperoni}, Sausage: {Sausage}\n";
        return str;
    }


}
