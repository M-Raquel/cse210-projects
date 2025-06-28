// Base Class for a Goal Object
using System.IO;
using System.Diagnostics.Tracing;

public abstract class Goal
{
    //Attributes
    protected string _name; //The name of the specific goal
    protected string _description; //The description of a goal

    protected int _xp; //total xp that a point is given

    protected bool _isComplete; //Yes or No if goal is complete

    // Constructor
    public Goal(string name, string description, int xp)
    {
        _name = name;
        _description = description;
        _xp = xp;
        _isComplete = false;
    }

    //Methods
    // Methods to Get the attributes
    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _xp;
    }

    //Method to record when a goal is completed, different for each child class
    public abstract void RecordEvent();

    //To check the 
    public abstract string GetDetailsString();

    //Get the string representation of how it looks in the file
    public abstract string GetStringRepresentation();

    //Method to check if a goal is complete
    public abstract bool IsComplete();
}