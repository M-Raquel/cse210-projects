//Class to keep track of user data - Creating new exercises
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

    //Methods to Create Exercises

    public static Exercise CreateCoreExercise()
    {
    Console.Write("Enter name: ");
    string name = Console.ReadLine();
    Console.Write("Enter description: ");
    string description = Console.ReadLine();

    Console.Write("Use time-based format? (yes/no): ");
    string useTime = Console.ReadLine().ToLower();

        if (useTime.StartsWith("y"))
        {
            Console.Write("Enter time in minutes: ");
            int time = int.Parse(Console.ReadLine());
            return new Core(name, description, time);
        }
        else
        {
            return new Core(name, description, CoreAmountInput());
        }
    }

    public static Exercise CreateCardioExercise() => CreateCoreExercise(); 

    public static Exercise CreateFlexibilityExercise() => CreateCoreExercise();

    public static Exercise CreateStrengthExercise()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();

        Console.Write("Use time-based format? (yes/no): ");
        string useTime = Console.ReadLine().ToLower();

        if (useTime.StartsWith("y"))
        {
            Console.Write("Enter time in minutes: ");
            int time = int.Parse(Console.ReadLine());
            return new Strength(name, description, time);
        }
        else
        {
            Console.Write("Enter weight: ");
            int weight = int.Parse(Console.ReadLine());
            var amount = CoreAmountInput();
            return new Strength(name, description, amount, weight);
        }
    }

    public static List<int> CoreAmountInput()
    {
        Console.Write("Enter number of sets: ");
        int sets = int.Parse(Console.ReadLine());
        Console.Write("Enter number of reps: ");
        int reps = int.Parse(Console.ReadLine());
        return new List<int> { sets, reps };
    }
}