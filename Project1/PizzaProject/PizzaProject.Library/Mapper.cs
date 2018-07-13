using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject.Library
{
    public class Mapper
    {
        public static UserTest Map(  User user ) => new UserTest
        {
            
            FirstName = user.FirstName,
            LastName = user.LastName,
            Phone = user.PhoneNumber
        };
    }
}
