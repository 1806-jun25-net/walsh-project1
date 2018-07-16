using System;
using System.Collections.Generic;

namespace PizzaProject.Library.Models
{
    public class Order 
    {  
        public Location Store { get; set; } 
        public User Customer { get; set; }
        public DateTime OrderTime { get; set; }
        public double TotalCost { get; set; }             // can't exceed $500
        public List<Pizza> PizzaOrder { get; set; } = new List<Pizza>();

        public Order( )
        {
            
        }

        public Order(Location store, User person, DateTime time, List<Pizza> orders)
        {
                Store = store;
                Customer = person;
                OrderTime = time;
                PizzaOrder = orders;
                CalculateCost();
           
        }

        public void CalculateCost()
        {
            double cost = 0;

            // get total cost from order
            foreach (Pizza pizza in PizzaOrder)
            {

                cost += pizza.Cost;
            }

            if(cost > 500)
            {
                throw new Exception("Cost can't be more than 500 dollars");
            }
            else
                TotalCost = cost; 
        }

        public void AddPizza( Pizza pizza ) => PizzaOrder.Add(pizza);

        /*
        public override string ToString( )
        {
            r
        }
        */
    }
}
