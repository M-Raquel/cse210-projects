using System;

class Program
{
    static void Main(string[] args)
    {
        // This is a program to compute the area of a circle

        //Get radius from the user
        Console.Write("Please enter the radius: ");
        string text = Console.ReadLine()
        double radius = double.Parse(text);

        //Compute area of the circle.
        double area = Math.PI * radius * radius;
        
        //Display the area for the user to see.
        Console.WriteLine($"Area of the circle: {area}");

        /* First way to do comments, multi-line comment
        */
        //second way to do comments. Single line comment
        Console.WriteLine($"Hello, {s} World! I'm trying to see if this will push. {f} {n} {x}");
    }
}