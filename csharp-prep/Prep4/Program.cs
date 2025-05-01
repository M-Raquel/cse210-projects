using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Create a list to add numbers to
        List<int> numbersList = new List<int>();

        // Create a while loop to add numbers to the list
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;
        int sum = 0;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            numbersList.Add(number);
            sum += number;
        }
        Console.WriteLine($"Your sum is: {sum}");

        //To calculate the average
        int average = sum - numbersList.Count;
        Console.WriteLine($"The average is: {average}");

        //to calculate the max number
        int max = numbersList[0];
        foreach ( int num in numbersList)
        {
            if (num > max)
                max = num;
        }
        Console.WriteLine($"The max is: {max}");
    }
}