using System;
using System.Transactions;

// Displays a menu and gives the user several options for making an exercise regime 
class Program
{
    static void Main(string[] args)
    {
        // Testing if Exercise object works and the Core class
        Console.WriteLine("Welcome to the Better Health Systems! We will help you create an exercise regime");

        List<Exercise> recordedExercises = new List<Exercise>();
        Thread.Sleep(2000);

        UserData newUser = new UserData("Raquel", 21, 118, recordedExercises);
        newUser.DisplayUserInfo();


        //Change this later to ask the user themselves
        // 

        bool userInput = true; //To start the do-while loop

        while (userInput)
        {
            Console.WriteLine("~~~~~~~ Better Health ~~~~~~~");

            //Menu Options
            Console.WriteLine("Menu Options: \n");
            Console.WriteLine("1. Start Exercises of the Day");
            Console.WriteLine("2. Create a Weekly Schedule");
            Console.WriteLine("3. Save to File");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. See Schedule");
            Console.WriteLine("6. Quit");

            //Call the method at the bottom to check input
            string userChoice = GetValidInput("Please choose an option (1-6): ", new List<string> {"1", "2", "3", "4", "5", "6"});
            Console.WriteLine();

            switch (userChoice)
            {
                case "1":
                    // Pull from WeekDay class to display the lists that are there for the day of the week on the user's system
                    //Delete following code later. 
                    newUser.DisplayExercises();
                    Thread.Sleep(3000);

                    break;
                case "2":
                    // To check if the there is valid input
                    string planType = GetValidInput("1. Personal Customization\n2. Randomly Generated", new List<string> { "1", "2" });
                    //If Personal, Have a day by day focus that is saved to a list.
                    // That list is saved to user data (user class), which is then saved to a specific week day (Date class).
                    // Make the user choose at least 2 exercises; check against list index of exercises?
                    // Set duration/set/weight of each individual exercise
                    // Display an option for the user to Save if they wish.

                    if (planType == "1")
                    {
                        Console.WriteLine("Perfect! Let's create something.\nPlease list what you would like to focus on for Monday: ");
                        // Change this later to call the Create Exercise method in User data to set everything up. 
                        Console.WriteLine("Write the name of an exercise you'd like to do. "); // Show a method to Display the list of exercises
                        string name = Console.ReadLine();

                        Thread.Sleep(2000);

                        Console.WriteLine("Give a short description of what this strengthens/improves");
                        string description = Console.ReadLine();

                        Thread.Sleep(2000);

                        string SR = GetValidInput("Do you want to do it based on time or sets/repetitions? [ t / r ]", new List<string> {"t", "r"});

                        if (SR.ToLower() == "t")
                        {
                            Core SetCore = new Core();
                            int time = SetCore.SetTime();

                            Core exercise1 = new Core(name, description, time);
                            newUser.AddExercise(exercise1);

                            exercise1.StringRepresentation();
                            Thread.Sleep(2000);
                        }
                        else
                        {
                            Core SetCore = new Core();
                            List<int> setAmount = SetCore.SetAmount();

                            Core exercise1 = new Core(name, description, setAmount);
                            newUser.AddExercise(exercise1);
                            exercise1.StringRepresentation();
                            Thread.Sleep(2000);
                        }
                    }
                    else
                    {
                        Exercise exercise1 = new Core();
                        exercise1.Random();
                        newUser.AddExercise(exercise1);
                        Thread.Sleep(2000);
                        //Put random Core, Cardio, Strength, and Flexibility generations into a list
                        break;
                    }

                    break;
                case "3":
                    // Call the user data class to manage saving the file.
                    break;
                case "4":
                    //Call the user data class to load from a file.
                    break;
                case "5":
                // Call the Date class to display the Lists for each day of the week
                case "6":
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

