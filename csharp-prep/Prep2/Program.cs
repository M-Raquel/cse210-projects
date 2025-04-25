using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your current grade percentage? ");
        string userGrade = Console.ReadLine();

        int x = int.Parse(userGrade);
        string letterGrade = "";

        if (x >= 90 )
        {
            letterGrade = "A";
        }
        else if (x >= 80 )
        { 
            letterGrade = "B";
        }
        else if (x >= 70 )
        {
            letterGrade = "C";
        }
        else if (x >= 60 )
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.Write($"Your grade is {letterGrade}. ");

        if ( x >= 70 )
        {
            Console.WriteLine("Congragulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("We're sorry, you did not pass the course. Please contact you professor.");
        }
    }
}