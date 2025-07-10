//Class to keep track of user data - Saving and Loading to a file
using System.Runtime.InteropServices;

public class UserData
{
    //attributes
    private List<Exercise> _userExercises = new List<Exercise>(); //List to keep track of chosen user exercises

    //Constructor


    //Methods

    //Method to add Goals to a list
    public void AddExercise(Exercise exercise)
    {
        _userExercises.Add(exercise);
        Console.WriteLine("Exercise added successfully;\n");
    }

    //Method to Display Goals
    public void DisplayExercises()
    {
        Console.WriteLine("\n Your Regime:\n");
        if (_userExercises.Count == 0)
        {
            Console.WriteLine("     (No Exercises yet. Create a set!\n)");
            return;
        }

        for (int i = 0; i < _userExercises.Count; i++)
        {
            Exercise exercise = _userExercises[i];
            Console.WriteLine($"    {i + 1}; {exercise.StringRepresentation()}");
        }
        Console.WriteLine();
    }

    //Method to save list to a file
    public void SaveGoals(string filename)
    {
        using (StreamWriter output = new StreamWriter(filename))
        {
            foreach (Exercise exercise in _userExercises)
            {
                output.WriteLine(exercise.SetFileFormat());
            }
        }
        Console.WriteLine($"Goals successfully saved to {filename}");
    }

    //Method to Load Exercises from list
    public void LoadExercise(string filename)
    {
        _userExercises.Clear(); //Clear a list to remove previous data
        
        string[] lines = File.ReadAllLines(filename);

        for (int i = 0; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");
            string type = parts[0];

            if (type == "Core")
            {
                // $"Core| {_name}| {_description}| {_setAmount}"
                string name = parts[1];
                string description = parts[2];
                List<int> setAmount = parts[3];

                Core c = new Core(name, description, setAmount);
                _userExercises.Add(c);
            }
            //Add for Cardio and Everything else
        }
    }
}