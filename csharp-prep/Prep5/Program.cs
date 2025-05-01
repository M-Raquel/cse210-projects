using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int newNumber = PromptUserNumber();
        int squared = SquareNumber(newNumber);
        DisplayResult(name, squared);
    }
    //Display a welcome message
    static void DisplayWelcome() 
    {
        Console.WriteLine("Welcome to the Program!");
    }
    //Asks for and returns the user's name as a string
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    //Function asking user for a number
    static int PromptUserNumber() 
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    //Accepts an interger as a parameter and returns taht number squared
    static int SquareNumber(int number)
        {
            int squared = number * number;
            return squared;
        }
    //Calls all the functions and displays the result
    static void DisplayResult(string name, int squared)
    {
        Console.Write($"{name} the square root of your number is {squared}");
    }
}