using PizzaProject.Library.Interfaces;
using PizzaProject.Library.Models;

using System;
using System.Collections.Generic;

public class User : IAddress
{
    
    public string FirstName { set; get; }
    public string LastName { set; get; }
    public string PhoneNumber { set; get; }

    // IAddress implementation 
    public string Street { set; get; }
    public string City { set; get; }
    public string State { set; get; }
    public string ZipCode { set; get; }

    public string DefaultLocation { set; get; }
    public bool AlreadyOrdered { set; get; } = false;
    public List<Pizza> PizzasOrdered { set; get; } = new List<Pizza>();
    public DateTime OrderTime { set; get; }


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
}

