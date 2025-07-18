//Class to keep track of user data - Saving and Loading to a file
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class UserData
{
    //attributes
    private string _userName;
    private int _userAge;
    private int _userWeight;

    //Constructor
    public UserData(string userName, int userAge, int userWeight)
    {
        _userName = userName;
        _userAge = userAge;
        _userWeight = userWeight;
    }

    //Methods


    public void DisplayUserInfo()
    {
        Console.WriteLine($"{_userName} -- Age: {_userAge} Weight: {_userWeight}");
    }

}