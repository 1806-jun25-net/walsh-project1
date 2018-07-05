

using System;

using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
       
        
            // Test blank constructor
        [Fact]
        public void CustomerInfoWithFirstnameLastnamePhonenumber( )
        {
            // arrange 
            string name1 = "Davy";
            string name2 = "Crocket";
            string phone = "999-336-6578";
            User customer = new User(name1, name2, phone);

            string expected = customer.FirstName;


            // act
            string actual = "Davy";
            

            // assert
            Assert.Equal(actual, expected);

        }
    }
    
}
