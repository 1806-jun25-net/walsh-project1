

using System;


namespace PizzaProject.UI
{
    public class Program
    {
        static void Main( string[ ] args )
        {

            int input;      // stores user menu choice 

            // do user choice until they want to exit 
            do
            {
                // display menu option 
                Menu.ShowMenu();


                // get user input and validate
                input = ValidateMenuChoice();

                // call relevant logic
                Menu.UserInput(input);

            } while(input != 9);

        }

        // Gets user input as a string and then checks that a proper integer from menu was inputted
        static int ValidateMenuChoice()
        {
           
            Console.WriteLine("Enter a command to choose menu or type 'exit' to quit...");
            string input = Console.ReadLine();

            bool integerInput = false;       // for tryParse to test if string can be converted to int
            int choice;                     // convert user input string to integer

            do
            {   

                // check if integer value
                integerInput = int.TryParse(input, out choice);

                // if non integer value, issue error message and prompt user to re-enter value. 
                // If integer is entered continues to while loop for range of values accepted
                if(!integerInput)
                {
                    Console.Write("That was not a number. Please enter integers only from 1 to 9: ");
                    input = Console.ReadLine();
                }
                else
                    integerInput = true;
                
            } while(!integerInput);
         
           
            // validate integer from  1 to 9
            while (choice != 1 && choice != 2 && choice != 3 && choice != 4 && choice != 5 && choice != 6 && choice != 7 && choice != 8 && choice != 9)
            {
                Console.Write("Error. You must enter an integer from 1 - 9: ");
                choice = int.Parse(Console.ReadLine());
            }

            return choice;
        }

    }   
}
