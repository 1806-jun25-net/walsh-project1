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
    public static bool AlreadyOrdered { set; get; } = false;
    
    // default empty constructer
    public User()
    {

    }

    // enter user first name last name and phone number
    public User( string firstName, string lastName, string phoneNumber)
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

    /* set order time
    public void SetOrderTime( DateTime time )
    {
        OrderTime = time;
    }
    */

    // check if user has already ordered
    public bool CheckIfPreviousOrdered( )
    {
        return AlreadyOrdered;
    }

    // return all fields
    public override string ToString( ) => ( $"{FirstName}, {LastName}, {PhoneNumber}" );



}

