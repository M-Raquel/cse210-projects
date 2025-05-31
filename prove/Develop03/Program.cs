using System;

public class Program
{
    static void Main(string[] args)
    {
        Scripture scripture1; //Declare a scripture object 

        // Create a new Scripture object with a reference and a list of verses
        using (StreamReader reader = new StreamReader("proverbs_3_5-6.txt"))
        {
            scripture1 = new Scripture(reader);
        }

        // User input to start the scripture display
        Console.WriteLine("Welcome to the Scripture Memorization Tool!");
        Console.WriteLine("Press Enter to start displaying the scripture or type 'quit' to exit.");

        string startInput = Console.ReadLine();
        bool cont = true;

        // Create a loop to display the scripture and allow the user to hide words
        do
        {
            Console.Clear();
            //Display the scripture
            scripture1.Display();

            // Method to hide a word in the scripture
            for (int i=0; i < 3; i++)
            {
            cont = scripture1.HideRandomVerse();
            }
            if (!cont) break;

            Console.WriteLine("A word has been hidden. Press Enter to continue...");
            startInput = Console.ReadLine();

        } while (startInput != "quit");
    }
}