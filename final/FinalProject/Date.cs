// Class to keep track of which exercises are in which days of the week
public class Date
{
    //Attributes
    //Get the day of the week
    private string _today = DateTime.Now.DayOfWeek.ToString();

    //Stores the week day, and set of exercises for that day
    private Dictionary<string, List<Exercise>> _weeklySchedule;

    //Constructor
    public Date()
    {
        _weeklySchedule = new Dictionary<string, List<Exercise>>()
        {
            { "Monday", new List<Exercise>() },
            { "Tuesday", new List<Exercise>() },
            { "Wednesday", new List<Exercise>() },
            { "Thursday", new List<Exercise>() },
            { "Friday", new List<Exercise>() },
            { "Saturday", new List<Exercise>() },
            { "Sunday", new List<Exercise>() }
        };
    }

    //Methods

    //Method to add exercise to a specific day
    public void AddExerciseToDay(string day, Exercise exercise)
    {
        if (_weeklySchedule.ContainsKey(day))
        {
            _weeklySchedule[day].Add(exercise);
        }
    }

    // Method to get all exercises for today based on system date
    public List<Exercise> GetTodaySchedule()
    {
        string today = DateTime.Now.DayOfWeek.ToString();
        return _weeklySchedule.ContainsKey(today) ? _weeklySchedule[today] : new List<Exercise>();
    }

    //Displays Exercises for a specific day
    public void DisplayDaySchedule(string day)
    {
        if (_weeklySchedule.ContainsKey(day))
        {
            Console.WriteLine($"\n{day}'s Exercise Plan:");
            foreach (Exercise e in _weeklySchedule[day])
            {
                Console.WriteLine($"• {e.StringRepresentation()}");
            }
        }
        else
        {
            Console.WriteLine($"No schedule found for {day}");
        }
    }


}