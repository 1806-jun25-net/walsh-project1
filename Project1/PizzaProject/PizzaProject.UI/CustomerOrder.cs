﻿using System;
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
            GetPizzaInfo(customer);
        }

        // prompt user for pizza crust and topping information
        public static void GetPizzaInfo(User user)
        {
            // integer validation
            int number = ValidateNumberOfPizzas();

            


            Console.WriteLine(number);

            for(int i = 1; i <= number; i++)
            {
                // Get pizza crust size
                var size = ValidateCrustSize(i);
                Console.WriteLine();            // skip line

                // store toppings. all pizzas have sauce and cheese
                List<string> toppings = new List<string>() { "sauce", "cheese" };

                // Get toppings. Add pepperoni and sausage to toppings list if user requests
                Console.WriteLine($"For pizza #{i} Tell me which toppings you would like.");
                Console.WriteLine("Our toppings include Pepperoni, Sauce, Cheese and Sausage.");
                Console.WriteLine("All pizzas come with sauce and cheese. Would you like to add pepperoni? (Y or N) ");

                var input = Menu.ValidateStringInput();     // validate "y" or "n" input 
                if(input == "y")
                    toppings.Add("pepperoni");

                Console.WriteLine("Would you like to add sausage? ( Y or N) ");
                input = Menu.ValidateStringInput();
                if(input == "y")
                    toppings.Add("sausage");

                // show order to customer with crust size and thier choice of toppings 
                Console.Write("Great! Let me repeat your order: We have a " + size + " pizza");
                Console.Write(" with ");
                foreach(string value in toppings)
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine(".\n");
            }
        }

        public static string ValidateCrustSize(int i)
        {
            Console.Write($"For pizza #{i}, What size pizza crust do you want? (small, medium, or large): ");
            var size = Console.ReadLine();
            size = size.ToLower();
            

            while (size != "small" && size != "medium" && size != "large")
            {
                Console.WriteLine("You did not enter small medium or large...");
               
                Console.Write("What size pizza crust do you want: ");
                size = Console.ReadLine();
                size = size.ToLower();

            }

            return size; 
        }

        public static int ValidateNumberOfPizzas()
        {
            int number;

            // Ask how many pizzas
            Console.Write("How many pizzas would you like today?  (1 to 12): ");
            number = int.Parse(Console.ReadLine());

            while (number < 1 || number > 12)
            {
                Console.Write("That number is not allowed. Please enter an integer from 1 to 12: ");
                number = int.Parse(Console.ReadLine());
            }

            return number; 
        }
    }
}
