using System;
using System.IO;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Makes a list to store the Goal objects into
        ManageGoals manageGoals = new ManageGoals();

        string userInput = "0"; //To start the do-while loop

        do
        {
            // Display total points
            Console.WriteLine("~~~~~~~ Goal Quest ~~~~~~~");
            Console.WriteLine($"Total Points: {manageGoals.ShowScore}\n");

            //Menu Options
            Console.WriteLine("Menu Options: \n");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record an Event");
            Console.WriteLine("6. Quit");

            userInput = Console.ReadLine();
            Console.WriteLine();

            switch (userInput)
            {
                case "1": //Create a new goal
                    AddGoal(manageGoals);
                    break;

                case "2": //Display or List the goals
                    manageGoals.DisplayGoals();
                    break;

                case "3": //Save a Goal
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    manageGoals.SaveGoals(saveFile);
                    break;

                case "4": //Load Goals
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    manageGoals.LoadGoals(loadFile);
                    break;

                case "5": //Record accomplishing a goal
                    manageGoals.DisplayGoals();
                    Console.Write("Which goal did you accomplish? ");
                    if (int.TryParse(Console.ReadLine(), out int index))
                    {
                        manageGoals.RecordEvent(index - 1);
                    }
                    break;

                case "6":
                    Console.WriteLine("Thanks for playing!");
                    break;
                default:
                    Console.WriteLine("Invalid input. Try again.\n");
                    break;
            }
            

        } while (userInput != "6");
    }
    
    //Method to add create new goals 
    static void AddGoal(ManageGoals manageGoals)
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("     1. Simple ");
        Console.WriteLine("     2. Eternal ");
        Console.WriteLine("     3. Checklist \n");

        Console.Write("Which type of goal would you like to make? Please enter number or name: ");

        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal: ");
        string name = Console.ReadLine();

        Console.Write("Please give a short description of your goal: ");
        string description = Console.ReadLine();

        Console.Write("How many points is this worth: ");
        int xp = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (goalType)
        {
            case "1":
                newGoal = new Simple(name, description, xp);
                break;

            case "2":
                newGoal = new Eternal(name, description, xp);
                break;

            case "3":
                Console.Write("How many times does it need to be completed? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("How many bonus points for completing it? ");
                int bonus = int.Parse(Console.ReadLine());

                newGoal = new Checklist(name, description, xp, target, bonus);
                break;

            default:
                Console.WriteLine("❌ Invalid selection.");
                return;
        }
        manageGoals.AddGoal(newGoal);
    }
}