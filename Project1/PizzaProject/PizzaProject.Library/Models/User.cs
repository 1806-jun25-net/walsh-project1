using System;
using System.Collections.Generic;

public class User
{
    private string FirstName { set; get; }
    private string LastName { set; get; }
    private string PhoneNumber { set; get; }
    private string DefaultLocation { set; get; }
    private bool OrderAllowed = true;
    private DateTime OrderTime
    {
        set => value = DateTime.Now;

        get => OrderTime;
    }

    private List<List<string>> OrderHistory;

   
	

	
	



}

