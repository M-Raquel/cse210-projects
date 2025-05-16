using System;
using System.Collections.Generic;
using System.IO;
//Entry Class 
public class Entry
{
    //Attributes - Date, Prompt, Response
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }
    //I used Get/Set so I can retrieve and update the value of the properties.
    public Entry(string prompt, string response)
    {
        DateTime theCurrentTime = DateTime.Now;
        Date = theCurrentTime.ToShortDateString(); //The only pre-set value
        Prompt = prompt; //Grabbed from journal
        Response = response;
    }

    //Behaviors - Display, Save to file and Load and entry
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
    }
    public void FormatForSave(string filename) //To save the entries in a file
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine($"{Date}~|~{Prompt}~|~{Response}");
        }
        Console.WriteLine("Entry saved to file!");
    }
    //load an entry from a string
    public static Entry LoadEntry(string data)
    {
        var parts = data.Split("~|~");
        return new Entry(parts[1], parts[2]) { Date = parts [0] };
    }
}