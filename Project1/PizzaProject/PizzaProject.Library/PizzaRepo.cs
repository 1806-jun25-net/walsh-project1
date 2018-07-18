﻿using PizzaProject.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject.Library
{
    public class PizzaRepo
    {
        private readonly PizzaDBContext _db;

        public PizzaRepo( PizzaDBContext db )
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public void AddPizza( Pizza pizza )
        {
            _db.Add(Mapper.Map(pizza));
            _db.SaveChanges();
        }

        public void SaveChanges( )
        {
            _db.SaveChanges();
        }

        /*
        public void AddUser( string first, string second, string phone )
        {

            var dbUserTest = new Users
            {
                FirstName = first,
                LastName = second,
                Phone = phone
                
            };

            _db.Add(Mapper.Map(dbUserTest));
        }
        */

    }
}
