using System;
using System.Collections.Generic;

namespace PizzaProject.Data
{
    public partial class Users
    {
        public int UsersId { get; set; }
        public int DefaultLocation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
    }
}
