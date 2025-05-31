using System;
using System.Collections.Generic;
// A class that contains a list of Word objects, representing a verse in a scripture.
public class Verse
{
    // private Word[] _words;
    private List<Word> _words = [];
    private List<int> _visibleWords = [];
    public Verse(string text)
    {
        // Split the text of the verse into individual words
        string[] parts = text.Split();
        foreach (string part in parts)
        {
            Word word = new Word(part);
            _words.Add(word);
        }
        _visibleWords = [.. Enumerable.Range(0, _words.Count)];
    }
    public void Display()
    {
        foreach (Word word in _words)
        {
            Console.Write(word.GetText() + " ");
        }
    }

    public void HideRandomWord()
    {
        if (_visibleWords.Count == 0) return;
        Random random = new Random();
        int index = random.Next(0, _visibleWords.Count);
        int i2 = _visibleWords[index];
        Word randomWord = _words[i2];

        randomWord.SetInvisible();
        _visibleWords.RemoveAt(index);
    }
    public bool AllInvisible()
    {
        return _words.All((word) => !word.IsVisible());
    }

    public bool AllVisible()
    {
        return _words.All((word) => word.IsVisible());
        // foreach (Word word in _words)
        // {
        //     if (word.IsVisible() == false)
        //     {
        //         return false;
        //     }
        // }
        // return true;
    }
}
