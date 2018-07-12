using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject.Data
{
    class PizzaRepository
    {
        private readonly PizzaRepository _db;

        public PizzaRepository(PizzaRepository db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public void AddUser( string first, string last, string number)
        {
            var user = new Users
            {
                FirstName = first,
                LastName = last,
                Phone = number
            };

            _db.Add(user);
        }

        private void Add( Users user )
        {
            throw new NotImplementedException();
        }
    }
}
