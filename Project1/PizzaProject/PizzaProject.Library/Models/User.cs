public class User 
{
    
    public string FirstName { set; get; }
    public string LastName { set; get; }
    public string PhoneNumber { set; get; }
    public int DefaultLocation { set; get;  }
    public int UserID { set; get;  }

    public static bool AlreadyOrdered { set; get; } = false;
    
    // default empty constructer
    public User()
    {

    }

    // enter user first name last name and phone number
    public User( string firstName, string lastName, string phoneNumber, int location)
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        DefaultLocation = location;
    }

    public User( string firstName, string lastName, string phone)
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phone;
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

