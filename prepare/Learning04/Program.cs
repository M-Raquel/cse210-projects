using System;

class Program
{
    static void Main(string[] args)
    {
        //Create a new Assignment object
        Assignment assignment1 = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        //Create a new MathAssignment object
        MathAssignment mathAssignment1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");

        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        //Create a Writing Assignment object
        WritingAssignment writingAssignment1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}

// public class MathAssignment : Assignment
// {
//     //2 strings of textbook section and problems
//     //Method returns a string
// }

// public class WritingAssignment : Assignment
// {
//     //Attribute of title
//     //Method that returns writing information
// }