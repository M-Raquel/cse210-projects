// A class containing a collection of Verse objects, representing a scripture reference and its verses.
using System;
using System.Collections.Generic;
using System.IO;
public class Scripture
{
    private string _reference;
    private List<Verse> _verses;

    public Scripture(string reference, List<Verse> verses) //Constructor for Written
    {
        _reference = reference;
        _verses = [.. verses];
    }
    public Scripture(StreamReader reader) //Constructor for reading from a file
    {
        // Read the reference from the first line
        _reference = reader.ReadLine().Trim();
        _verses = new List<Verse>();

        while (reader.EndOfStream == false)
        {
            string text = reader.ReadLine().Trim();
            _verses.Add(new Verse(text));
        }
    }
    public bool HideRandomVerse()
    {
        if (_verses.All((verse) => verse.AllInvisible())) return false;
        Random random = new Random();
        int index = random.Next(0, _verses.Count);
        Verse randomVerse = _verses[index];

        while (randomVerse.AllInvisible())
        {
            randomVerse = _verses[random.Next(0, _verses.Count)];
        }
        randomVerse.HideRandomWord();
        return true;
        // _verses.ForEach((verse) => verse.HideRandomWord());
    }
    public void Display()
    {
        Console.WriteLine($"Scripture: {_reference}");
        foreach (Verse verse in _verses)
        {
            verse.Display();
        }
    }
}