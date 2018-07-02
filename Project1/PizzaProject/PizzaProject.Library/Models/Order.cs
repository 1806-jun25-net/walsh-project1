using PizzaProject.Library.Interfaces;
using PizzaProject.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject.Library.Models
{
    public class Order 
    {
        public string StoreName { get; set; }
        public string Street { get; set; }
        public string City { get; set;  }
        public string State { get; set; }
        public string Zip { get; set; }
        public DateTime OrderTime { get; set; }
        public int Quantity { get; set; }          // can't be less than zero or more than 12
        public int Cost { get; set; }              // can't exceed $500

       

    }
}
