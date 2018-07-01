using PizzaProject.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject.Library.Models
{
    class Order : IAddress 
    {
        string IAddress.Street { get; set; }
        string IAddress.City { get; set; }
        string IAddress.State { get; set; }
        string IAddress.ZipCode { get; set; }
        private DateTime OrderTime { get; set; }
        private int Quantity { get; set; }          // can't be less than zero or more than 12
        private int Cost { get; set; }              // can't exceed $500

    }
}
