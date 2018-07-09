

using System;

using Xunit;

namespace XUnitTestProject1
{
    public class UserTest
    {
       
        
        // Test all fields return valid strings 
        [Fact]
        public void CustomerInfoWithFirstLastPhoneStreetCityStateZip( )
        {
            // arrange 
            string name1 = "Davy";
            string name2 = "Crocket";
            string phone = "999-336-6578";
          
            User customer = new User(name1, name2, phone);

            string expected = "Davy, Crocket, 999-336-6578";


            // act
            string actual = customer.ToString();
            

            // assert
            Assert.Equal(actual, expected);

        }
    }
    
}
