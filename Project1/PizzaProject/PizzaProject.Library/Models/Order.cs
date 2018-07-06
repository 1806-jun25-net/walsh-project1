using PizzaProject.Library.Interfaces;
using PizzaProject.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject.Library.Models
{
    public class Order 
    {  
        public string LocationName { get; set; }
        public User Customer { get; set; } = new User();
        public DateTime OrderTime { get; set; }
        public int NumberOfPizzas { get; set; }          // can't be less than zero or more than 12
        public int Cost { get; set; }                   // can't exceed $500

       

    }
}
