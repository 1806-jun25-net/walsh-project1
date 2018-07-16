using PizzaProjectWebApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject.Library
{
    public class Mapper
    {
        public static Users Map(  User user ) => new Users
        {
            
            FirstName = user.FirstName,
            LastName = user.LastName,
            Phone = user.PhoneNumber,
            LocationsId= int.Parse(user.DefaultLocation),
        };
    }
}
