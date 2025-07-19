using System;
using System.Transactions;

// Displays a menu and gives the user several options for making an exercise regime 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Better Health Systems! We will help you create an exercise regime");

        Thread.Sleep(2000);

        // In the future, I want to add a seperate file that keeps track of user information or even have different users
        // that the data is saved to. For now I'll just fill in the information myself.

        UserData newUser = new UserData("Raquel", 21, 118);

        // Create a new Date class to save the exercises to and call those methods.
        Date weekSchedule = new Date();

        newUser.DisplayUserInfo();
        Thread.Sleep(2000);

        bool userInput = true; //To start the do-while loop

        while (userInput)
        {
            Console.Clear();
            Console.WriteLine("~~~~~~~ Better Health ~~~~~~~");

            //Menu Options
            Console.WriteLine("Menu Options: \n");

            Console.WriteLine("1. Display Exercises of the day");
            Console.WriteLine("2. Display Schedule for a specific day");
            Console.WriteLine("3. Add Core Exercise");
            Console.WriteLine("4. Add Cardio Exercise");
            Console.WriteLine("5. Add Stretch Exercise");
            Console.WriteLine("6. Add Strength Exercise");
            Console.WriteLine("7. Generate Random Weekly Schedule");
            Console.WriteLine("8. Save Schedule to File");
            Console.WriteLine("9. Load Schedule from File");
            Console.WriteLine("0. Quit");
            Console.Write("Choose an option - ");

            string userChoice = Console.ReadLine();
            Console.WriteLine();

            switch (userChoice)
            {
                //If Personal, ask user to save a day by day focus to a list.
                // That list is saved to a week list (Date class)
                // Set duration/set/weight of each individual exercise
                // If they choose to display a specific day, if there's nothing in there, prompt them to add an exercise.
                case "1":
                    // Display Exercises for the day
                    // Call the Week class and pull from the key tied to a specific day
                    weekSchedule.DisplayTodaySchedule();
                    Thread.Sleep(3000);
                    break;

                case "2":
                    // Display the Schedule for a Specific Day
                    Console.Write("Enter day to view (Monday, Tuesday, etc. ): ");
                    string day = Console.ReadLine();

                    weekSchedule.DisplayDaySchedule(day);
                    Thread.Sleep(3000);

                    break;

                case "3":
                    // Add A Core Exercise - Call Date method ChooseDay to get a specific day inside the AddExerciseToDay method.
                    // Then call the UserData-Create Core Exercise method. Rinse and repeat for the following exercises
                    weekSchedule.AddExerciseToDay(Date.ChooseDay(), UserData.CreateCoreExercise());
                    Console.WriteLine("Exercise successfully added");
                    Thread.Sleep(2000);

                    break;

                case "4":
                    // Add A Cardio Exercise
                    weekSchedule.AddExerciseToDay(Date.ChooseDay(), UserData.CreateCardioExercise());
                    Console.WriteLine("Exercise successfully added");
                    Thread.Sleep(2000);
                    break;

                case "5":
                    // Add a Stretch Exercise
                    weekSchedule.AddExerciseToDay(Date.ChooseDay(), UserData.CreateStretchExercise());
                    Console.WriteLine("Exercise successfully added");
                    Thread.Sleep(2000);
                    break;

                case "6":
                    // Add a Strength Exercise
                    weekSchedule.AddExerciseToDay(Date.ChooseDay(), UserData.CreateStrengthExercise());
                    Console.WriteLine("Exercise successfully added");
                    Thread.Sleep(2000);
                    break;

                case "7":
                    // Generate Random Weekly Schedule
                    weekSchedule.GenerateRandomWeek();
                    Console.WriteLine("Exercise Regime successfully created");
                    Thread.Sleep(2000);
                    break;

                case "8":
                    // Save Schedule to file
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    weekSchedule.SaveWeekSchedule(saveFile);
                    Console.WriteLine("File saved");
                    Thread.Sleep(2000);
                    break;

                case "9":
                    // Load Schedule from file
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    weekSchedule.LoadWeekSchedule(loadFile);
                    break;

                case "0":
                    // End the program
                    // Switch to false to break the loop
                    userInput = false;
                    break;
                default:
                    Console.WriteLine("Please enter a valid option.");
                    break;
            }
            if (userInput) // Waits for the user to enter before continuing the program
            {
                Console.WriteLine("\nPress Enter to continue ");
                Console.ReadLine();
            }
        }
    }
    
    // No longer validating inputs this way. In the future I'll see if it can be used to make it more dynamic or add stricter options.
    // public static string GetValidInput(string prompt, List<string> validOptions)
    // {
    //     string input;

    //     do
    //     {
    //         Console.WriteLine(prompt);
    //         input = Console.ReadLine();

    //         if (!validOptions.Contains(input))
    //         {
    //             Console.WriteLine("Invalid input. Please try again.");
    //         }

    //     } while (!validOptions.Contains(input));

    //     return input;
    // }

}

