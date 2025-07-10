// Child class of Exercise - Contains list of core exercises. 
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Core : Exercise
{
    //Attributes
    private List<string> _coreExercises = ["Mountain Climbers", "Russian Twist", "Side Plank", "Abdominal Crunch",
    "Plank", "Leg Raises", "Bicycle Crunch", "V-Ups", "Lying Windshield Wipers", "Ab Rollouts", "Hollow Body Hold"];


    //Constructor
    public Core(string name, string description, int time, List<int> setAmount) : base(name, description, time, setAmount)
    {
        // Leave empty
    }

    //Methods

    //Method to Display the coreExercises
    public void DisplayCore()
    {
        foreach (string i in _coreExercises)
        {
            Console.WriteLine(i);
        }
    }

    public override int SetTime() //Give the option to switch between a set time or set amount in the menu, give the different options
    {
        _setOrTime = true;
        Console.Write("Enter how long, in minutes, you would like to do this exercise: ");
        int minutes = int.Parse(Console.ReadLine());
        _time = minutes;

        return minutes;
    }

    public override List<int> SetAmount() 
    {
        _setOrTime = false;
        Console.Write("Enter how many repetitions you would like to do for this exercise: ");
        int repetition = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter how many sets of the exercise you would like to do");
        int set = int.Parse(Console.ReadLine());

        List<int> amount = [set, repetition];

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
            representation = $"{_name} : {_description}; {_setAmount[0]} sets of {_setAmount[1]} repetitions. ";
        }

        return representation;
    }


    public override string SetFileFormat()
    {
        string format;
        if (_setOrTime)
        {
            format = $"Core| {_name}| {_description}| {_time} minutes";
        }
        else
        {
            format = $"Core| {_name}| {_description}| {_setAmount}";
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

        List<int> amount = [set, repetition];
        _setOrTime = false; //To get correct String representation later

        return $"";
    }
}