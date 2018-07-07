using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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
            var phoneNumber = ValidatePhoneNUmber();

            Console.Write("What location do you want? Choose location 1 or 2: Enter an integer:  ");
            var locationNumber = ValidateStoreLocation();

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

        // uses regular expression replace to remove formatting from phone number input and compares to 10 digits
        // to ensure correct phone number
        public static string ValidatePhoneNUmber()
        {
            
            bool valid = false;

            // get phone number from user
            var phone = Console.ReadLine();

            do
            {
                // if empty string is  input 
                if (phone == "")
                {
                    Console.WriteLine("Error. Phone number cannot be empty.");
                    Console.Write("Please enter a phone number in xxx-xx-xxxx format: ");
                    phone = Console.ReadLine();
                }
                else
                {   // remove all characters from phone input and check if length of digits is 9 for valid input
                    var strippedPhoneNumber = Regex.Replace(phone, @"[^0-9]+", "");
                    if(strippedPhoneNumber.Length == 9)
                        valid = true;
                    else
                    {
                        Console.WriteLine("Error. Incorrect format for phone number...");
                        Console.Write("Please enter a phone number in xxx-xx-xxxx format: ");
                        phone = Console.ReadLine();

                    }
                }

            } while (!valid);

            return phone;
        }

        public static int ValidateStoreLocation()
        { 
            // get user input 
            string input = Console.ReadLine();

            bool integerInput = false;       // for tryParse to test if string can be converted to int
            int choice;                     // convert user input string to integer

            do
            {

                // check if integer string, if so so convert string input into int choice
                integerInput = int.TryParse(input, out choice);

                // if non integer value, issue error message and prompt user to re-enter value. 
                // If integer is entered continues to while loop for range of values accepted
                if(!integerInput)
                {
                    Console.Write("That was not a number. Please enter integers 1 or 2 only:  ");
                    input = Console.ReadLine();
                }
                else
                    integerInput = true;

            } while(!integerInput);


            // validate integer from  1 or 2
            while(choice != 1 && choice != 2)
            {
                Console.Write("Error. You must enter an integer 1 or 2:  ");
                choice = int.Parse(Console.ReadLine());
            }

            return choice;
        }
    

        public static string RemoveNonNumeric( string phone )
        {
            return Regex.Replace(phone, @"[^0-9]+", "");
        }
    }
}
