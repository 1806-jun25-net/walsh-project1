

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

                // get user input
                Console.WriteLine("Enter a command to choose menu or type 'exit' to quit...");
                input = int.Parse(Console.ReadLine());

                // validate input
                // ValidateCharInput()
                // call relevant logic
                Menu.UserInput(input);




            } while(input != 9);

        }

    }   
}
