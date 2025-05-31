using System;
// A Word class contains a string and whether or not the string is visible. 
public class Word
{
    private string _text;
    private bool _visible;

    public Word(string text)
    {
        _text = text;
        _visible = true;
    }
    // method that changes sets of visibility to false
    public void SetInvisible()
    {
        _visible = false;
    }
    public bool IsVisible()
    {
        return _visible;
    }
    //method that returns the underscores of the text if not visible
    public string GetText()
    {
        if (_visible == false)
        {
            string hiddenWord = new string('_', _text.Length);
            return hiddenWord;
        }
        return _text;
    }
}