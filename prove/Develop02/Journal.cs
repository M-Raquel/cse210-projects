using System;
using System.Collections.Generic; //Lists
using System.IO; //handles reading and writing to files
//Journal class
public class Journal
{
    //Attributes : Prompt List, List to store journal entries
    static List<string> prompts = new List<string> {
        "List five ways you saw the Lord's hand in your life today: ",
        "Who was the most interesting person I interacted with today? ",
        "What was the strongest emotion I felt today? ",
        "If I had one thing I could do over today, what would it be? ",
        "What was the best part of my day? ",
        "What was something new I learned today? ",
        "What are some goals I have for tomorrow? ",
        "Did I help someone today? Did someone help me today? ",
        "What made me smile or frown today?",
        "What are your biggest fears?",
        "What is your favorite memory?",
        "What is something that you are proud of? ",
        "Write about something you are passionate about: ",
        "Write about a dream you had: ",
        };
    public static List<Entry> entries = new List<Entry>();

    //Behaviors: Add Entry, Display Entry
    public void WriteEntry() //Method to write an entry and ask to save
    {
        Random random = new Random(); //Choose a random prompt
        string prompt = prompts[random.Next(prompts.Count)];

        Console.WriteLine(prompt);
        Console.Write("Write something: ");
        string response = Console.ReadLine();

        Entry newEntry = new Entry(prompt, response); //new entry object
        entries.Add(new Entry(prompt, response));

        //ask if user wants to save entry
        Console.Write("Do you want to save this entry to a file? (yes/no): ");
        string choice = Console.ReadLine();
        if (choice == "yes")
        {
            Console.Write("Enter filename to save the entry: ");
            string filename = Console.ReadLine();
            newEntry.FormatForSave(filename);
        }
    }
    public void DisplayJournal() //Display all journal entries
    {
        Console.WriteLine("Journal Entries: ");
        foreach (var entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    public void LoadtheJournal()
    {
        Console.Write("Enter filename to load the journal: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            entries.Clear();
            foreach (string line in File.ReadLines(filename))
            { //call the Entry Method to format correctly
                entries.Add(Entry.LoadEntry(line));
            }
            Console.WriteLine("Journal loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}