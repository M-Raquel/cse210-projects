//Abstract Class for Exercise Objects
using System.Data;

public abstract class Exercise
{
    //Attributes
    protected string _name;
    protected string _description;
    protected int _time;
    protected List<int> _setAmount; // Contains list of set and repetitions

    protected bool _setOrTime;

    //Constructor
    public Exercise(string name, string description, int time, List<int> setAmount)
    {
        _name = name;
        _description = description;
        _time = time;
        _setAmount = setAmount;
    }

    //Methods

    //Method to return the length of an activity in minutes.
    public abstract int SetTime();

    //Method to return the amount of a particular exercise - how many repetitions and sets?
    public abstract List<int> SetAmount();

    //Method to return how a specific exercise will look in string format when printed. 
    //The setOrTime is used to seperate if the use chose to go by time duration or a set amount of an exercise.
    //If time/duration, then the bool is true.
    public abstract string StringRepresentation();

    //Method to return how the exercise will be sent to a file. 
    public abstract string SetFileFormat();

    //Method to randomly choose an exercise from a list. 
    public abstract string Random();
}