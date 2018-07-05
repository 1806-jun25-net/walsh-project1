using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PizzaProject.Test
{
    public class Test
    {
        // Test blank constructor
        [Fact]
        public void CustomerInfoWithFirstnameLastnamePhonenumber( )
        {
            // arrange 
            string firstName = "Davy";
            string lastName = "Crocket";
            string phoneNumber = "999-336-6578";
            User customer = new User(firstName, lastName, phoneNumber);

            User expected = customer;


            // act
            User actual = new User();
            actual.FirstName = "Davy";
            actual.LastName = "Crocket";
            actual.PhoneNumber = "999-336-6578";

            // assert
            Assert.Equal(actual, customer);

        }
    }

}