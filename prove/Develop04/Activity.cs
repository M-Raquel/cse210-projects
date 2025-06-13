//Parent or Base class for Activities
using System.Reflection.Metadata;

public class Activity
{
    //Attributes
    protected string _name;
    protected string _description;
    protected int _duration;
    // protected string _startmessage; Turn these into methods instead.
    // protected string _endmessage;

    //Constructor
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }


    //Methods


    //Method to Display at start of the specific activity
    public void Start(string name, string description)
    {
        //Displays the name and description of activity
        Console.WriteLine($" Welcome to the {name} program.\n\n\n This activity will {description}.\n");
    }


    //Method to set the duration of an activity
    public int GetDuration(int duration)
    {
        //Sets the duration of the activity
        Console.Write("Enter how long, in seconds, you would like to do this activity: ");

        string input = Console.ReadLine();
        if (int.TryParse(input, out int number))
        {
            Console.WriteLine($"Okay, we'll do this activity for {number} seconds");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        Console.Write("We'll start shortly. \nPlease wait  ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write('.');
            Thread.Sleep(1000);
        }
        Console.WriteLine("\n");

        return number;
    }

    //Method to Display for the end of a specific activity
    public void End(string name, int duration)
    {
        Console.WriteLine("Well Done!\n");
        ShowAnimation();
        Console.WriteLine($"You completed {duration} seconds of the {name} activity.");
    }

    //Method that counts down from 5
    public void Countdown()
    {
        for (int i = 5; i > 0; i--)
        {

            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine(""); //For a new line in terminal
    }

    //Method for displaying the animation
    public void ShowAnimation()
    {
        List<string> animationStrings = new List<string>{"|", "/", "-", "\\"};

        int i = 0;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(8);

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
}