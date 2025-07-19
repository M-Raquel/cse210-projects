//Child class of Exercise
public class Stretch : Exercise
{
    //Attributes
    private List<string> _stretchExercises = ["Neck Stretch",
    "Shoulder Cross-Body Stretch",
    "Triceps Stretch",
    "Chest Opener",
    "Upper Back Stretch",
    "Hamstring Stretch",
    "Quad Stretch",
    "Calf Stretch",
    "Hip Flexor Stretch",
    "Glute Stretch",
    "Cat-Cow Stretch",
    "Downward Dog",
    "Seated Forward Fold",
    "Supine Spinal Twist",
    "Arm Circles",
    "Leg Swings",
    "Torso Twists",
    "Standing Side Stretch"];

    //Constructor for SetAmount only
    public Stretch(string name, string description, List<int> setAmount) : base(name, description, setAmount)
    {

    }

    //Constructor for SetTime
    public Stretch(string name, string description, int time) : base(name, description, time)
    {
        //Leave blank
    }

    //A blank constructor to call the list in Date method
    public Stretch()
    {
        // Leave empty
    }

    //Methods


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


    public override string SetFileFormat()
    {
        string format;
        if (_setOrTime)
        {
            format = $"StretchA| {_name}| {_description}| {_time}";
        }
        else
        {
            if (_setAmount != null && _setAmount.Count >= 2)
            {
                format = $"StretchB| {_name}| {_description}| {_setAmount[0]}|{_setAmount[1]}";
            }
            else
            {
                format = $"StretchB| {_name}| {_description}| (Missing set/repetition data)";
            }
        }
        return format;
    }

    // Choose two random exercises to add to list - then add some repetitions and sets
    public override string Random()
    {
        Random randomStretch = new();
        int stretchIndex1 = randomStretch.Next(_stretchExercises.Count);
        int stretchIndex2;

        do
        {
            stretchIndex2 = randomStretch.Next(_stretchExercises.Count);
        } while (stretchIndex1 == stretchIndex2);

        // Set the repetition and set
        int set = 3;
        int repetition = 10;
        _setOrTime = false; //To get correct String representation later

        _setAmount = new List<int> { set, repetition };
        string exercise1 = _stretchExercises[stretchIndex1];
        string exercise2 = _stretchExercises[stretchIndex2];
        _name = $"{exercise1} & {exercise2}";
        _description = "Stretches selected randomly.";
        
        return StringRepresentation();
    }
}