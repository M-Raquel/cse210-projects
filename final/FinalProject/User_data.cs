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

    // Displays the User Information
    public void DisplayUserInfo()
    {
        Console.WriteLine($"{_userName} -- Age: {_userAge} Weight: {_userWeight}");
    }

    //Methods to Create Exercises

    // Used to get the sets and reps for each other create method
    public static List<int> CoreAmountInput()
    {
        Console.Write("Enter number of sets: ");
        int sets = int.Parse(Console.ReadLine());
        Console.Write("Enter number of reps: ");
        int reps = int.Parse(Console.ReadLine());
        return new List<int> { sets, reps };
    }


    // Creates a new Core Exercise
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

    // Creates a new Cardio Exercise
    public static Exercise CreateCardioExercise()
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
            return new Cardio(name, description, time);
        }
        else
        {
            List<int> amount = CoreAmountInput();
            return new Cardio(name, description, amount);
        }
    } 

    // Creates a new Stretch Exercise
    public static Exercise CreateStretchExercise()
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
            return new Stretch(name, description, time);
        }
        else
        {
            List<int> amount = CoreAmountInput();
            return new Stretch(name, description, amount);
        }
    }

    // Creates a new Strength Exercise
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

}