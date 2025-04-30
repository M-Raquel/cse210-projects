using System;

class Program
{
    static void Main(string[] args)
    {
        int number = PromptUserNumber();
        Console.WriteLine($"Your number is: {number}");
    }

    static int PromptUserNumber() 
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
}