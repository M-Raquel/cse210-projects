// Child class of Exercise - Contains list of core exercises. 
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Core : Exercise
{
    //Attributes
    private List<string> _coreExercises = ["Mountain Climbers", "Russian Twist", "Side Plank", "Abdominal Crunch",
    "Plank", "Leg Raises", "Bicycle Crunch", "V-Ups", "Lying Windshield Wipers", "Ab Rollouts", "Hollow Body Hold"];

    //Constructor for SetAmount only
    public Core(string name, string description, List<int> setAmount) : base(name, description, setAmount)
    {
        _setAmount = new List<int>();
    }

    //Constructor for SetTime
    public Core(string name, string description, int time) : base(name, description, time)
    {
        //Leave blank
    }

    //A blank constructor to call the list in Date method
    public Core()
    {
        // Leave empty
    }

    //Methods

    public override int SetTime() //Give the option to switch between a set time or set amount in the menu
    {
        _setOrTime = true;
        Console.Write("Enter how long, in minutes, you would like to do this exercise: ");
        int minutes = int.Parse(Console.ReadLine());
        _time = minutes;

        return minutes;
    }

    // Method to set the Amount
    public override List<int> SetAmount()
    {
        _setOrTime = false;
        Console.Write("Enter how many repetitions you would like to do for this exercise: ");
        int repetition = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter how many sets of the exercise you would like to do");
        int set = int.Parse(Console.ReadLine());

        List<int> amount = [set, repetition];
        _setAmount = amount;
        return amount;
    }

    //Runs if the user chooses to make the list themselves.
    public override string StringRepresentation()
    {
        string representation;
        
        if (_setOrTime)
        {
            representation = $"{_name} : {_description}; {_time} minutes ";
        }
        else
        {
            if (_setAmount != null && _setAmount.Count >= 2)
            {
                representation = $"{_name} : {_description}; {_setAmount[0]} sets of {_setAmount[1]} repetitions.";
            }
            else
            {
                representation = $"{_name} : {_description}; (Repetition data unavailable)";
            }
        }
        return representation;
    }

    // Method to set the file format correctly.
    public override string SetFileFormat()
    {
        string format;
        if (_setOrTime)
        {
            format = $"CoreA| {_name}| {_description}| {_time}";
        }
        else
        {
            if (_setAmount != null && _setAmount.Count >= 2)
            {
                format = $"CoreB| {_name}| {_description}| {_setAmount[0]}|{_setAmount[1]}";
            }
            else
            {
                format = $"CoreB| {_name}| {_description}| (Missing set/repetition data)";
            }
        }
        return format;
    }

    // Choose two random exercises to add to list - then add some repetitions and sets
    public override string Random()
    {
        Random randomCore = new();
        int coreIndex1 = randomCore.Next(_coreExercises.Count);
        int coreIndex2;

        do
        {
            coreIndex2 = randomCore.Next(_coreExercises.Count);
        } while (coreIndex1 == coreIndex2);

        // Set the repetition and set
        int set = 3;
        int repetition = 10;
        _setOrTime = false; //To get correct String representation later

        _setAmount = new List<int> { set, repetition };
        string exercise1 = _coreExercises[coreIndex1];
        string exercise2 = _coreExercises[coreIndex2];
        _name = $"{exercise1} & {exercise2}";
        _description = "Core-strengthening duo selected randomly.";
        
        return StringRepresentation();
    }
}