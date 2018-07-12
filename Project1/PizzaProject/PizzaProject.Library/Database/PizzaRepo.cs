using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject.Library.Database
{
    public class PizzaRepo
    {
        private readonly PizzaDBContext _db;

        public PizzaRepo( PizzaDBContext db )
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public void AddUser(string first, string last, string phone)
        {
            var user = new User
            {
                FirstName = first,
                LastName = last,
                PhoneNumber = phone
            };

            _db.Add(user);
        }
    }
}
