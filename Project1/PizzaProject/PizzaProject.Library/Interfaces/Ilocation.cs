using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject.Library.Interfaces
{
    // Every location has an order history inventory of ingredients
    public interface Ilocation
    {
        List<List<string>> OrderHistory { get; set; }
        Dictionary<string, int> IngredientsInventory { get; set; }
    }
}
