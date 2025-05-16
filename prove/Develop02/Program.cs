using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        //Behaviors: Main, -menu(runs all behaviors

        Journal userJournal = new Journal(); //new journal object
        int userChoice = 0;

        while (userChoice != 4)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Quit");
            Console.Write("What would you like to do? ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out userChoice)) //To check if input is an integer
            {
                switch (userChoice)
                {
                    case 1:
                        userJournal.WriteEntry();
                        break;
                    case 2:
                        userJournal.DisplayJournal();
                        break;
                    case 3:
                        userJournal.LoadtheJournal();
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please enter a number between 1 and 4.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a number.");
            }
        }
        Console.WriteLine("Have a good day :) ");
    }
}