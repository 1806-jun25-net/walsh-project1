using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject.Library
{
    public class PizzaRepo
    {
        private readonly PizzaPizzaDBContext _db;

        public PizzaRepo( PizzaPizzaDBContext db )
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public void AddUser( User user )
        {
            _db.Add(Mapper.Map(user));
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
