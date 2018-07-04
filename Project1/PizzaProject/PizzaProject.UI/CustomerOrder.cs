using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject.UI
{
    public static class CustomerInfo
    {
        public static void CustomerOrder( )
        {
            Console.WriteLine("Are  you a new or returning customer? Press Y for yes, N for no...");

            // input validation. 
            var input = Menu.ValidateStringInput();

            // if user inputs y for new customer, 
            if(input == "y")
            {
                // ask user for information to make a new customer
                GetCustomerInformation();
            }

        }

        // prompt user for information needed to create a customer
        public static void GetCustomerInformation()
        {

            Console.WriteLine("Welcome new customer! Let's get some new info...");

            Console.Write("What is your first name:  ");
            var firstName = Console.ReadLine();

            Console.Write("What is your last name:  ");
            var lastName = Console.ReadLine();

            Console.Write("What is your phone number:  ");
            var phoneNumber = Console.ReadLine();

            Console.Write("What location do you want to choose location 1 or 2: Enter an integer ");
            var locationNumber = int.Parse(Console.ReadLine());

            string locationName;

            if(locationNumber == 1)
                locationName = "Location 1";
            else
                locationName = "Location 2";

            // create user object with customer info
            User customer = new User(firstName, lastName, phoneNumber, locationName);

            


        }
    }
}
