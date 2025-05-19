/// <Summary>
/// Represents a fraction with a numerator and denominator
/// This is a more accurate than storing numbers in a double.
/// </Summary>

public class Fractions
{
    //Attributes
    private int _numerator;
    private int _denominator;
    //Behaviors

    public Fractions()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fractions(int whole)
    {
        _numerator = whole;
        _denominator = 1;
    }

    public Fractions(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }
    
    public string GetFractionString()
    {
        string representation = $"{_numerator} / {_denominator}";
        return representation;
    }
    public double GetDecimalValue()
    {
        //Known as a typecast. If you try to divide regular, the computer will 
        //do integer division, and cut off points. Need to convert one to double
        double value = (double)_numerator / _denominator;
        return value;
    }
}