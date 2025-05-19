using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Fractions Program");
        Fractions f1 = new();
        Fractions f2 = new(5);
        Fractions f3 = new(3, 4);
        Fractions f4 = new(1, 3);

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}