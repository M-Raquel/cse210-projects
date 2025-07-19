//Child class of Exercise
public class Cardio : Exercise
{
    //Attributes
    private List<string> _cardioExercises = ["Running", "Biking", "Swimming", "Jumping Jacks", "High Knees",
    "Burpees", "Mountain Climbers", "Jump Rope", "Jump Squats"];

    // In the future, I want to add specifics for Distance and Speed
    // private int _distance;
    // private int _speed;

    //Constructor for SetAmount only
    public Cardio(string name, string description, List<int> setAmount) : base(name, description, setAmount)
    {

    }

    //Constructor for SetTime
    public Cardio(string name, string description, int time) : base(name, description, time)
    {
        //Leave blank
    }

    //A blank constructor to call the list in Date method
    public Cardio()
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
            format = $"CardioA| {_name}| {_description}| {_time}";
        }
        else
        {
            if (_setAmount != null && _setAmount.Count >= 2)
            {
                format = $"CardioB| {_name}| {_description}| {_setAmount[0]}|{_setAmount[1]}";
            }
            else
            {
                format = $"CardioB| {_name}| {_description}| (Missing set/repetition data)";
            }
        }
        return format;
    }

    // Choose two random exercises to add to list - then add some repetitions and sets
    public override string Random()
    {
        Random randomCardio = new();
        int cardioIndex1 = randomCardio.Next(_cardioExercises.Count);
        int cardioIndex2;

        do
        {
            cardioIndex2 = randomCardio.Next(_cardioExercises.Count);
        } while (cardioIndex1 == cardioIndex2);

        // Set the repetition and set
        int set = 3;
        int repetition = 10;
        _setOrTime = false; //To get correct String representation later

        _setAmount = new List<int> { set, repetition };
        string exercise1 = _cardioExercises[cardioIndex1];
        string exercise2 = _cardioExercises[cardioIndex2];
        _name = $"{exercise1} & {exercise2}";
        _description = "Cardio duo selected randomly.";
        
        return StringRepresentation();
    }
}