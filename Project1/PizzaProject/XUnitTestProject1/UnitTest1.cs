

using System;

using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
       
        
            // Test blank constructor
        [Fact]
        public void CustomerInfoWithFirstLastPhoneStreetCityStateZip( )
        {
            // arrange 
            string name1 = "Davy";
            string name2 = "Crocket";
            string phone = "999-336-6578";
            string street = "somewhere USA";
            string city = "Herndon";
            string state = "VA";
            string zipcode = "90210";
            User customer = new User(name1, name2, phone, street, city, state, zipcode);

            string expected = customer.FirstName;


            // act
            string actual = "Davy";
            

            // assert
            Assert.Equal(actual, expected);

        }
    }
    
}
