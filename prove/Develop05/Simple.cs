// Class for Simple Goals
public class Simple : Goal
{
    //No attributes needed; 

    //Constructor
    public Simple(string name, string description, int xp) : base(name, description, xp)
    {
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string checkbox = _isComplete ? "[X]" : "[ ]";
        return $"{checkbox} {_name} : {_description}";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal| {_name}| {_description}|{_xp}|{_isComplete}";
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Well done! You earned {_xp} points for finishing {_name}");
        }
        else
        {
            Console.WriteLine("This Goal is already completed.");
        }
    }
    
}