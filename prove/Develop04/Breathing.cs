// Class for the Breathing Activity

public class Breathing : Activity
{
    //Constructor
    public Breathing(string name, string description, int duration) : base(name, description, duration)
    {
    }

    //Methods

    //Display alternating messages between breathes
    public void AlternateBreath(int duration)
    {
        //Put in loop that last the time of the duration.
        int i = 0;
        int count = 0;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breath in  ");
            Countdown();

            Console.WriteLine("Breath out  ");
            Countdown();

            i++;
            count++;
        }
        End("Breathing", duration);
    }
}
