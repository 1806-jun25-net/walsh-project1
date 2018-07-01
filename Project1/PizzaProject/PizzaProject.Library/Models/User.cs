using System;
using System.Collections.Generic;

public class User
{
    private string FirstName { set; get; }
    private string LastName { set; get; }
    private string PhoneNumber { set; get; }
    private string DefaultLocation { set; get; }

    private SortedSet<DateTime> OrderTimes { set; get; }
    private List<List<string>> OrderHistory { get; set; }
}

