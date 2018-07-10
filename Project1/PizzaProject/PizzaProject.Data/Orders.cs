using System;
using System.Collections.Generic;

namespace PizzaProject.Data
{
    public partial class Orders
    {
        public int Orderid { get; set; }
        public DateTime OrderTime { get; set; }
        public int OrderCost { get; set; }
    }
}
