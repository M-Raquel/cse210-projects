// Class for Listing activity
public class Listing : Activity
{
    //attributes
    private List<string> listPrompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        };

    //Constructor
    public Listing(string name, string description, int duration) : base(name, description, duration)
    {
    }

    //Methods

    //Return a random prompt from the list.
    public string RandomList()
    {
        Random random = new Random();
        string list = listPrompts[random.Next(listPrompts.Count)];
        return list;
    }

    //Displays the prompts and has user list items
    public void List(int duration)
    {
        int count = 0;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        Console.WriteLine(RandomList());
        Countdown();
        Console.WriteLine(" Start wrtiting!");

        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            count++;
        }
        Console.WriteLine($"You listed {count} things.");
        End("Listing", duration);
    }
}