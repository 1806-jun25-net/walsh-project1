﻿using System;
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
            LocationsId= user.DefaultLocation
        };

        public static Orders Map( Orders order ) => new Orders
        {


        };

        public static Pizzas Map( Pizzas pizza ) => new Pizzas
        {
            

        };
    }

  
}
