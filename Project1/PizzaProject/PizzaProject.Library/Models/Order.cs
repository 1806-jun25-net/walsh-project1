using PizzaProject.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject.Library.Models
{
    public class Order : IAddress 
    {
        string IAddress.Street { get; set; }
        string IAddress.City { get; set; }
        string IAddress.State { get; set; }
        string IAddress.ZipCode { get; set; }
        public DateTime OrderTime { get; set; }
        public int Quantity { get; set; }          // can't be less than zero or more than 12
        public int Cost { get; set; }              // can't exceed $500

    }
}
