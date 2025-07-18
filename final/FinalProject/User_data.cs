//Class to keep track of user data - Saving and Loading to a file
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class UserData
{
    //attributes
    private List<Exercise> _userExercises = new List<Exercise>(); //List to keep track of chosen user exercises
    private string _userName;
    private int _userAge;
    private int _userWeight;

    //Constructor
    public UserData(string userName, int userAge, int userWeight, List<Exercise> userExercises)
    {
        _userName = userName;
        _userAge = userAge;
        _userWeight = userWeight;
        _userExercises = userExercises;
    }

    //Methods

    //Method to add Exercises to a list
    public void AddExercise(Exercise exercise)
    {
        _userExercises.Add(exercise);
        Console.WriteLine("Exercise added successfully;\n");
    }


    public void DisplayUserInfo()
    {
        Console.WriteLine($"{_userName} -- Age: {_userAge} Weight: {_userWeight}");
    }

    //Method to Display Exercises
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
            Console.WriteLine($"    {i + 1}-- {exercise.StringRepresentation()}");
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
        Console.WriteLine($"Successfully saved to {filename}");
    }

    //Method to Load Exercises from list - Update to also read User Name/Information 
    public void LoadExercise(string filename)
    {
        _userExercises.Clear(); //Clear a list to remove previous data
        
        string[] lines = File.ReadAllLines(filename);

        for (int i = 0; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");
            string type = parts[0];

            if (type == "CoreB")
            {
                // $"Core| {_name}| {_description}| {_setAmount[0]}| {_setAmount[1]}"
                string name = parts[1];
                string description = parts[2];
                int sets = int.Parse(parts[3]);
                int repetitions = int.Parse(parts[4]);

                List<int> setAmount = [sets, repetitions];

                Core c = new Core(name, description, setAmount);
                _userExercises.Add(c);
            }
            if (type == "CoreA")
            {
                //$"CoreA| {_name}| {_description}| {_time} minutes";
                string name = parts[1];
                string description = parts[2];
                int time = int.Parse(parts[3]);

                Core c = new Core(name, description, time);
                _userExercises.Add(c);
            }
            //Add for Cardio and Everything else
        }
    }
}