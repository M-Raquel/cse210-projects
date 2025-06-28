// Checklist Goal Child class; 
public class Checklist : Goal
{
    //Attributes
    private int _targetCount; //To check how many total rounds for each goal

    private int _currentCount; //To check current round of goal against target

    private int _bonusPoints; //How many bonus points the user can add.

    //Constructor
    public Checklist(string name, string description, int xp, int targetCount, int bonusPoints) : base(name, description, xp)
    {
        _targetCount = targetCount;
        _currentCount = 0; //Automatically start all current at 0 points
        _bonusPoints = bonusPoints;
    }

    //Methods

    //Methods to get attributes
    public int GetBonusPoints()
    {
        return _isComplete ? _bonusPoints : 0;
    }

    public int GetCurrentCount()
    {
        return _currentCount;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string checkbox = _isComplete ? "[X]" : "[ ]";
        return $"{checkbox} {_name}: {_description} - Completed {_currentCount}/{_targetCount} ";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal| {_name}| {_description}|{_xp}|{_bonusPoints}|{_targetCount}|{_currentCount}|{_isComplete}";
    }


    public override void RecordEvent()
    {
        if (_currentCount < _targetCount)
            _currentCount++;
        Console.WriteLine($"Good job! You earned {_xp} points for completing {_name}");
            if (_currentCount == _targetCount)
            {
                _isComplete = true;
                Console.WriteLine($"Congratulations! You completed {_name} goal and earned {_bonusPoints} bonus points!");
            }
        else
        {
            Console.WriteLine("You've already completed this checklist goal");
        }
    }
}