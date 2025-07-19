// Child class of Exercise
//Child class of Exercise
public class Strength : Exercise
{
    //Attributes
    private List<string> _upperBodyStrengthExercises = new List<string>
    {
        "Push-Ups",
        "Incline Push-Ups",
        "Tricep Dips",
        "Plank Shoulder Taps",
        "Pike Push-Ups",
        "Pull-Ups",
        "Chin-Ups",
        "Inverted Rows",
        "Bicep Curls (Dumbbells)",
        "Overhead Shoulder Press (Dumbbells)",
        "Lateral Raises",
        "Front Raises",
        "Bent-Over Rows",
        "Renegade Rows",
        "Chest Press (Dumbbells)",
        "Chest Flys",
        "Arnold Press",
        "Resistance Band Rows",
        "Diamond Push-Ups",
        "Handstand Hold"
    };
    private List<string> _lowerBodyStrengthExercises = new List<string>
    {
        "Bodyweight Squats",
        "Jump Squats",
        "Lunges",
        "Reverse Lunges",
        "Walking Lunges",
        "Bulgarian Split Squats",
        "Step-Ups",
        "Wall Sit",
        "Glute Bridges",
        "Hip Thrusts",
        "Donkey Kicks",
        "Fire Hydrants",
        "Calf Raises",
        "Single-Leg Deadlifts",
        "Sumo Squats",
        "Side Lunges",
        "Resistance Band Lateral Walks",
        "Goblet Squats",
        "Romanian Deadlifts (Dumbbells)",
        "Heel Elevated Squats"
    };

    //For setting the weight of some exercises
    private int _weight;


    //Constructor for SetAmount only
    public Strength(string name, string description, List<int> setAmount, int weight) : base(name, description, setAmount)
    {
        _weight = weight;
    }

    //Constructor for SetTime
    public Strength(string name, string description, int time) : base(name, description, time)
    {
        //Leave blank
    }

    //A blank constructor to call the list
    public Strength()
    {
        // Leave empty
    }

    //Methods

    //Method to Display Upper Body List
    public void DisplayUpperStrength()
    {
        Console.WriteLine("UpperBody exercises");
        foreach (string i in _upperBodyStrengthExercises)
        {
            Console.WriteLine(i);
        }
    }

    //Method to display Lower Body List
    public void DisplayLowerStrength() {
        Console.WriteLine("Upper Body Strength exercises");
        foreach (string i in _lowerBodyStrengthExercises) {
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

        Console.WriteLine("Enter how much weight you would like to do for this exercise");
        int weight = int.Parse(Console.ReadLine());

        List<int> amount = [set, repetition, weight];
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
                representation = $"{_name} : {_description}; {_weight} weight for {_setAmount[0]} sets of {_setAmount[1]} repetitions.";
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
            format = $"StrengthA| {_name}| {_description}| {_time}";
        }
        else
        {
            if (_setAmount != null && _setAmount.Count >= 2)
            {
                format = $"StrengthB| {_name}| {_description}| {_weight}| {_setAmount[0]}|{_setAmount[1]}";
            }
            else
            {
                format = $"StrengthB| {_name}| {_description}| (Missing set/repetition data)";
            }
        }
        return format;
    }

    // Choose two random exercises to add to list - then add repetitions, sets, weight
    public override string Random()
    {
        Random randomStrength = new();
        int upperStrengthIndex1 = randomStrength.Next(_upperBodyStrengthExercises.Count);
        int upperStrengthIndex2 = randomStrength.Next(_upperBodyStrengthExercises.Count);

        int lowerStrengthIndex1 = randomStrength.Next(_lowerBodyStrengthExercises.Count);
        int lowerStrengthIndex2 = randomStrength.Next(_lowerBodyStrengthExercises.Count);


        do
        {
            upperStrengthIndex2 = randomStrength.Next(_upperBodyStrengthExercises.Count);
        } while (upperStrengthIndex1 == upperStrengthIndex2);

        do
        {
            lowerStrengthIndex2 = randomStrength.Next(_lowerBodyStrengthExercises.Count);
        } while (lowerStrengthIndex1 == lowerStrengthIndex2);


        // Set the repetition and set
        int set = 3;
        int repetition = 10;
        int weight = 12;
        _setOrTime = false; //To get correct String representation later

        _setAmount = new List<int> { set, repetition, weight };

        string upper1 = _upperBodyStrengthExercises[upperStrengthIndex1];
        string upper2 = _upperBodyStrengthExercises[upperStrengthIndex2];
        string lower1 = _lowerBodyStrengthExercises[lowerStrengthIndex1];
        string lower2 = _lowerBodyStrengthExercises[lowerStrengthIndex2];

        _name = $"{upper1} & {upper2} || {lower1} & {lower2}";
        _description = "Strength exercises selected randomly.";
        
        return StringRepresentation();
    }
}