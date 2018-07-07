using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject.Library.Interfaces
{
    // Every location has an order history inventory of ingredients
    public interface Ilocation
    {
        string LocationName { get; set; }

    }
}
