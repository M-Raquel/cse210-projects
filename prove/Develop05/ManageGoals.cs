// Class to keep track of goals, saving, loading, and total points
using System.IO;
public class ManageGoals
{
    //attributes
    private List<Goal> _goalList = new List<Goal>(); //Keep track of goals

    private int _score = 0; //Total user score

    //Constructor

    //Methods

    //Method to add Goals to a list
    public void AddGoal(Goal goal)
    {
        _goalList.Add(goal);
        Console.WriteLine("Goal added successfully;\n");
    }

    //Method to update and mark goals complete, update the score
    public void RecordEvent(int index)
    {
        if (index >= 0 && index < _goalList.Count)
        {
            Goal goal = _goalList[index];
            int prevScore = _score;

            goal.RecordEvent();
            _score += goal.GetPoints();

            if (goal is Checklist cg && cg.IsComplete())
            {
                _score += cg.GetBonusPoints();
            }

            Console.WriteLine($"Total Score: {_score} (Gained {_score - prevScore} points)");
        }
        else
        {
            Console.WriteLine("Invalid goal selection");
        }
    }

    //Method to Display Goals - print out list basically
    public void DisplayGoals()
    {
        Console.WriteLine("\n Your Goals:\n");
        if (_goalList.Count == 0)
        {
            Console.WriteLine("     (No goals yet. Create one!\n)");
            return;
        }

        for (int i = 0; i < _goalList.Count; i++)
        {
            Goal goal = _goalList[i];
            Console.WriteLine($"    {i + 1}; {goal.GetDetailsString()}");
        }
        Console.WriteLine();
    }

    // Show / prints the current score
    public void ShowScore()
    {
        Console.WriteLine($"\n Your current score is: {_score}");
    }

    //Method to save all the Goals from list to a file
    public void SaveGoals(string filename)
    {
        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(_score);

            foreach (Goal goal in _goalList)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine($"Goals successfully saved to {filename}");
    }

    //Reading and loading from a file to a list
    public void LoadGoals(string filename)
    {
        _goalList.Clear();

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]); //Read total xp in first line

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");
            string type = parts[0];

            if (type == "SimpleGoal")
            {
                // $"SimpleGoal| {_name}| {_description}|{_xp}|{_isComplete}"
                string name = parts[1];
                string description = parts[2];
                int xp = int.Parse(parts[3]);
                bool complete = bool.Parse(parts[4]);

                Simple sg = new Simple(name, description, xp);
                if (complete) sg.RecordEvent();
                _goalList.Add(sg);
            }
            else if (type == "ChecklistGoal")
            {
                // $"ChecklistGoal| {_name}| {_description}|{_xp}|{_bonusPoints}|{_targetCount}|{_currentCount}|{_isComplete}"
                string name = parts[1];
                string description = parts[2];
                int xp = int.Parse(parts[3]);
                int bonus = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int count = int.Parse(parts[6]);
                bool complete = bool.Parse(parts[7]);

                Checklist cg = new Checklist(name, description, xp, target, bonus);
                for (int j = 0; j < count; j++) cg.RecordEvent();
                _goalList.Add(cg);
            }
            else if (type == "EternalGoal")
            {
                // EternalGoal| {_name}| {_description}|{_xp}
                string name = parts[1];
                string description = parts[2];
                int xp = int.Parse(parts[3]);

                Eternal eg = new Eternal(name, description, xp);
                _goalList.Add(eg);
            }
        }
        Console.WriteLine($"Goals loaded from {filename}");
    }
}