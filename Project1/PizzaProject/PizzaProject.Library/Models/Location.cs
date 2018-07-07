using PizzaProject.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject.Library.Models
{
    // Location base class; every location has an address
    public class Location : IAddress
    {
        // IAddress implementation
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

       
    }
}
