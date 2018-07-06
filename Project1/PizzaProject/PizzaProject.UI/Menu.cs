using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject.UI
{
    public static class Menu
    {
        
        // display menu
        public static void ShowMenu()
        {
            Console.WriteLine("Welcome to Pizza Pizza!\n");
            Console.WriteLine("1: Place Order");
            Console.WriteLine("2: Get Suggest Order");
            Console.WriteLine("3. Search Users");
            Console.WriteLine("4. Display order details");
            Console.WriteLine("5. Display location order history");

            // This menu will need a sub menu  
            Console.WriteLine("6. Display sorted history");

            Console.WriteLine("7. Save all data to XML");
            Console.WriteLine("8. Load data from disk");
            Console.WriteLine("9. Exit");
                
        }

        // get user input and call relevant logic
        public static void UserInput(int choice )
        {
            switch (choice)
            {
                case 1:
                    // call create user
                    CustomerInfo.CustomerOrder();
                    break;
                case 2:
                    Console.WriteLine("2\n");
                    break;
                case 3:
                    Console.WriteLine("3\n");
                    break;
                case 4:
                    Console.WriteLine("4\n");
                    break;
                case 5:
                    Console.WriteLine("5\n");
                    break;
                case 6:
                    Console.WriteLine("6\n");
                    break;
                case 7:
                    Console.WriteLine("7\n");
                    break;
                case 8:
                    Console.WriteLine("8\n");
                    break;
                case 9:
                    Console.WriteLine("9\n");
                    Console.WriteLine("Program will now exit!");
                    break;
            }
        }

       // used to validate y for yes or n for no
        public static string ValidateStringInput()
        {
            string input;
            
            do
            {
                input = Console.ReadLine().ToLower();
                
                if (input != "y" && input != "n")
                {
                    Console.WriteLine("You didn't enter a valid character...");
                    Console.WriteLine("Please enter y for for 'Yes', n for no: ");

                    input = Console.ReadLine().ToLower();

                }
            } while(input != "y" && input != "n");

           
            return input;
        }

       
        
    }   
}
