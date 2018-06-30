using System;


namespace PizzaProject.UI
{
    class Program
    {
        static void Main(string[] args)
        {


            // create menu object and display menu options
            Menu menu = new Menu();

            menu.ShowMenu();

            // get user input until exit is entered
            Console.WriteLine("Enter a command to choose menu or type 'exit' to quit...");
            Console.ReadLine("")
            

            
        }
    }
}
