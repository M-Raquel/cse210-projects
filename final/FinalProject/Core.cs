// Child class of Exercise - Contains list of core exercises. 
public class Core : Exercise
{
    //Attributes
    private List<string> _coreExercises = ["Mountain Climbers", "Russian Twist", "Side Plank", "Abdominal Crunch",
    "Plank", "Leg Raises", "Bicycle Crunch", "V-Ups", "Lying Windshield Wipers", "Ab Rollouts", "Hollow Body Hold"];


    //Constructor
    public Core(string name, string description, int time, int setAmount) : base(name, description, time, setAmount)
    {

    }

    //Methods

    public override int SetTime() //Give the option to switch between a set time or set amount in the menu, give the different options
    {
        _setOrTime = true;
        Console.Write("Enter how long, in minutes, you would like to do this exercise: ");
        int minutes = int.Parse(Console.ReadLine());

        return minutes;
    }

    public override int SetAmount() 
    {
        _setOrTime = false;
        Console.Write("Enter how many sets of times you would like to do this exercise: ");
        int set = int.Parse(Console.ReadLine());

        return set;
    }


    public override string StringRepresentation(bool setOrTime)
    {
        string representation;
        if (_setOrTime)
        {
            representation = $"{_name} : {_description}; {_time} minutes ";
        }
        else
        {
            representation = $"{_name} : {_description}; {_setAmount} times ";
        }

        return representation;
    }


    public override string SetFileFormat()
    {
        
    }


    public override string Random()
    {
        
    }


}