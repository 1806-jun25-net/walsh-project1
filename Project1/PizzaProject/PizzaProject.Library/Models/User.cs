using PizzaProject.Library.Models;
using System;
using System.Collections.Generic;

public class User
{
    public string FirstName { set; get; }
    public string LastName { set; get; }
    public string PhoneNumber { set; get; }
    public string DefaultLocation { set; get; }
    public DateTime OrderTime {set; get; }

    // public bool AllowOrder
    

    public SortedSet<DateTime> OrderTimes { set; get; }
    public List<List<string>> OrderHistory { get; set; }

    public User(string firstName, string lastName, string phoneNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
    }

    public void SetLocation(string location)
    {
        DefaultLocation = location;
       
    }


     

}

