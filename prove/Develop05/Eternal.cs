//Eternal Goal child class

public class Eternal : Goal
{
    //no specific attributes

    //Constructor
    public Eternal(string name, string description, int xp) : base(name, description, xp)
    {
        //Leave empty
    }

    //Method to record when the event is complete.
    public override void RecordEvent()
    {
        Console.WriteLine($"Well done! You earned {_xp} points for progressing on your eternal goal: '{_name}'");

    }

    //To check the 
    public override string GetDetailsString()
    {
        return $"[8] {_name} : {_description}";
    }

    //Get the string representation of how it looks in the file
    public override string GetStringRepresentation()
    {
        return $"EternalGoal| {_name}| {_description}|{_xp}";
    }

    //Method to mark complete, Except eternal never is, so make false.
    public override bool IsComplete()
    {
        return false;
    }
}