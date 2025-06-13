// Class for the reflection activity
public class Reflection : Activity
{
    //Attributes
    private List<string> prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        };
    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    //Constructor
    public Reflection(string name, string description, int duration) : base(name, description, duration)
    {
    }

    //Methods

    //Method for choosing a random Prompt in the list
    public string RandomPrompt()
    {
        Random random = new Random(); //Choose a random prompt
        string prompt = prompts[random.Next(prompts.Count)];
        return prompt;
    }

    //Method for choosing a ranodm question in the list
    public string RandomQuestion()
    {
        Random random = new Random();
        string question = questions[random.Next(questions.Count)];
        return question;
    }

    //Method to show random questions/prompts
    public void Reflect(int duration)
    {
        int count = 0;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        Console.WriteLine(RandomPrompt());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(RandomQuestion());
            Countdown();
            Console.WriteLine(""); // Add a new line for the question
            count++;
        }
        End("Reflection", duration);
    }
}