using PizzaProject.Library.Interfaces;
using PizzaProject.Library.Models;

using System;
using System.Collections.Generic;

public class User 
{
    
    public string FirstName { set; get; }
    public string LastName { set; get; }
    public string PhoneNumber { set; get; }
    public string DefaultLocation { set; get; }
    public DateTime OrderTime { set; get; } 
    public bool AlreadyOrdered { set; get; } = false;
    public List<Pizza> PizzasOrdered { set; get; } = new List<Pizza>();


    public SortedSet<DateTime> OrderTimes { set; get; }
    public List<List<string>> OrderHistory { get; set; }

    // default empty constructer
    public User()
    {

    }

    // enter user first name last name and phone number
    public User( string firstName, string lastName, string phoneNumber )
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;

    }

    // enter user first name last name phone number and default location 
    public User( string firstName, string lastName, string phoneNumber, string location )
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        DefaultLocation = location;

    }
    public void SetLocation( string location )
    {
        DefaultLocation = location;

    }

    // set order time
    public void SetOrderTime( DateTime time )
    {
        OrderTime = time;
    }

    // check if user has already ordered
    public bool CheckIfPreviousOrdered( )
    {
        return AlreadyOrdered;
    }

    public void PlaceOrder()
    {
        Console.WriteLine("Are  you a new or returning customer? Press Y for yes, N for no...");

        // input validation
       
            var input = Console.ReadLine();
            input = input.ToLower();

            while(input != "y" || input != "n")
            {
                Console.WriteLine("Error: You didn't enter a valid value.");
                Console.WriteLine("Please enter a 'y', 'Y', 'n', 'N'");

                input = Console.ReadLine();
                input = input.ToLower();
            }
            
            // input is valid create new user and get address
            if (input == "y")
            {
                
                Console.WriteLine("Thank you for choosing Pizza Pizza!");
                Console.Write("What is your first name: ");
                Console.ReadLine();







            }
    }

}

