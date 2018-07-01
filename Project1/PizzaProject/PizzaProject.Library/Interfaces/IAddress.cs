using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject.Library.Interfaces
{
    public interface IAddress
    {
        string Street { get; set; }
        string City { get; set; }
        string State { get; set; }
        string ZipCode { get; set; }
    }
}
