using System;
using System.Collections.Generic;

public class User
{
    public string FirstName { set; get; }
    public string LastName { set; get; }
    public string PhoneNumber { set; get; }
    public string DefaultLocation { set; get; }

    public SortedSet<DateTime> OrderTimes { set; get; }
    public List<List<string>> OrderHistory { get; set; }
}

