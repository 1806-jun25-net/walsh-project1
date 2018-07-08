using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace PizzaProject.Test
{
    public class LocationTest
    {
        [Theory]
        [InlineData("Location 1")]
        [InlineData("Location 2")]
        public void TestLocationNameIsCorrect(string expected)
        {
            // Arrange 
            Location location = new Location(expected);

            // Act
            var actual = location.LocationName;


            // Assert 
            

        }
    }
}
