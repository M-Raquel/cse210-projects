// Class to keep track of which exercises are in which days of the week
public class Date
{
    //Attributes

    //Stores the week day, and set of exercises for that day
    private Dictionary<string, List<Exercise>> _weeklySchedule;

    //Constructor - Empty lists
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


    // Method to Display the Schedule for the specific day
    public void DisplayTodaySchedule()
    {
        string today = DateTime.Now.DayOfWeek.ToString();
        
        if (_weeklySchedule.Count == 0)
        {
            Console.WriteLine("No exercises added yet. Go create some!");
        }
        else
        {
            DisplayDaySchedule(today);
        }
    }
    
    //Displays Exercises for a specific day of user choice
    public void DisplayDaySchedule(string day)
    {
        if (_weeklySchedule.ContainsKey(day))
        {
            List<Exercise> exercises = _weeklySchedule[day];

            if (exercises.Count == 0)
            {
                Console.WriteLine($"\nNo exercises scheduled for {day}.");
            }
            else
            {
                Console.WriteLine($"\n{day}'s Exercise Plan:");
                foreach (Exercise e in exercises)
                {
                    Console.WriteLine($"• {e.StringRepresentation()}");
                }
            }
        }
        else
        {
            Console.WriteLine($"Day '{day}' is not recognized in the schedule.");
        }
    }

    //Method to save the weekly schedule to a file
    public void SaveWeekSchedule(string filename)
    {
        using (StreamWriter output = new StreamWriter(filename))
        {
            foreach (var dayEntry in _weeklySchedule)
            {
                string day = dayEntry.Key;
                foreach (Exercise exercise in dayEntry.Value)
                {
                    output.WriteLine($"{day}|{exercise.SetFileFormat()}");
                }
            }
        }

        Console.WriteLine($"Weekly schedule successfully saved to {filename}");
    }

    // Method to Load weekly schedule from a file
    public void LoadWeekSchedule(string filename)
    {
        _weeklySchedule.Clear(); // Reset schedule

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string day = parts[0];
            string type = parts[1];

            if (!_weeklySchedule.ContainsKey(day))
            {
                _weeklySchedule[day] = new List<Exercise>();
            }

            if (type == "CoreA")
            {
                string name = parts[2];
                string description = parts[3];
                int time = int.Parse(parts[4]);

                Core exercise = new Core(name, description, time);
                _weeklySchedule[day].Add(exercise);
            }
            else if (type == "CoreB")
            {
                string name = parts[2];
                string description = parts[3];
                int sets = int.Parse(parts[4]);
                int reps = int.Parse(parts[5]);

                List<int> amount = new List<int> { sets, reps };
                Core exercise = new Core(name, description, amount);
                _weeklySchedule[day].Add(exercise);
            }

            // Add logic for other exercise types like Cardio or Strength if needed
        }

        Console.WriteLine($"Weekly schedule loaded from {filename}");
    }

    // Method to randomly generate a weekly exercise regime
    public void GenerateRandomWeek()
    {
        foreach (string day in _weeklySchedule.Keys)
        {
            Exercise e1 = new Core(); e1.Random();
            // Add Flexibility and other stuff

            _weeklySchedule[day].Add(e1);
        }
    }

}   