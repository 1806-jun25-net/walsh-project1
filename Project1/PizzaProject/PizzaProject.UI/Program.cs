using System;


namespace PizzaProject.UI
{
    class Program
    {
        static void Main(string[] args)
        {

            int input;      // stores user menu choice 

            // create menu object and display menu options
            Menu menu = new Menu();
            menu.ShowMenu();
            
            // do user choice until they want to exit 
            do
            {
                
                Console.WriteLine("Enter a command to choose menu or type 'exit' to quit...");
                input = int.Parse(Console.ReadLine());

                menu.UserInput(input);


            } while(input != 8);

              








            
            

            
        }
    }
}
