using System;
using System.Transactions;

// Displays a menu and gives the user several options for making an exercise regime 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Better Health Systems! We will help you create an exercise regime");

        Thread.Sleep(2000);

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
            Console.WriteLine("5. Add Flexibility Exercise");
            Console.WriteLine("6. Add Strength Exercise");
            Console.WriteLine("7. Generate Random Weekly Schedule");
            Console.WriteLine("8. Save Schedule to File");
            Console.WriteLine("9. Load Schedule from File");
            Console.WriteLine("0. Quit");
            Console.Write("Choose an option");


            //Call the method at the bottom to check input
            string userChoice = GetValidInput("Please choose an option (1-7): ", new List<string> {"1", "2", "3", "4", "5", "6", "7"});
            Console.WriteLine();

            switch (userChoice)
            {
                    //If Personal, ask user to save a day by day focus to a list.
                    // That list is saved to a week list (Date class)
                    // Make the user choose at least 2 exercises; check against list index of exercises?
                    // Set duration/set/weight of each individual exercise
                    // Display an option for the user to Save if they wish.
                case "1":
                    // Pull from WeekDay class to display the lists that are there for the day of the week on the user's system 
                    Console.WriteLine("Here are your exercises for today: ");
                    weekSchedule.GetTodaySchedule();
                    weekSchedule.DisplayTodaySchedule();
                    Thread.Sleep(3000);

                    break;
                case "2":
                    // To check if the there is valid input
                    string planType = GetValidInput("1. Personal Customization\n2. Randomly Generated", new List<string> { "1", "2" });

                    if (planType == "1")
                    {
                        break;
                    }

                    break;
                case "3":
                    // Call the date class to manage saving the file.
                    weekSchedule.SaveWeekSchedule("week_schedule.txt");
                    Console.WriteLine("Your current weekly plan is now saved.");
                    Thread.Sleep(2000);
                    break;
                case "4":
                    //Call the date class to load from a file.
                    weekSchedule.LoadWeekSchedule("week_schedule.txt");
                    Console.WriteLine("Your schedule has been loaded!");
                    Thread.Sleep(2000);
                    break;
                case "5":
                    // Call the date class to display the Lists for each day of the week
                    string viewDay = GetValidInput("Which day would you like to view? (e.g., Monday, Tuesday...)", new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });

                    weekSchedule.DisplayDaySchedule(viewDay);
                    Thread.Sleep(2000);
                    break;

                case "6":
                    // Calls the date class to randomly generate entire weekly schedule
                    weekSchedule.GenerateRandomWeek();
                    break;

                case "7":
                    userInput = false;
                    Console.WriteLine("Have a good rest of your day!");
                    break;       
            }
        }
    }

    public static string GetValidInput(string prompt, List<string> validOptions)
    {
        string input;

        do
        {
            Console.WriteLine(prompt);
            input = Console.ReadLine();

            if (!validOptions.Contains(input))
            {
                Console.WriteLine("Invalid input. Please try again.");
            }

        } while (!validOptions.Contains(input));

        return input;
    }

}

