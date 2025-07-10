using System;

// Displays a menu and gives the user several options for making an exercise regime 
class Program
{
    static void Main(string[] args)
    {
        // Testing if Exercise object works and the Core class
        Console.WriteLine("Welcome to the Better Health Systems! We will help you create an exercise regime");

        bool userInput = true; //To start the do-while loop

        while (userInput)
        {
            // Display total points
            Console.WriteLine("~~~~~~~ Better Health ~~~~~~~");

            //Menu Options
            Console.WriteLine("Menu Options: \n");
            Console.WriteLine("1. Start Exercises of the Day");
            Console.WriteLine("2. Create a Weekly Schedule");
            Console.WriteLine("3. Save to File");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. See Schedule");
            Console.WriteLine("6. Quit");

            string userChoice = Console.ReadLine();
            Console.WriteLine();

            switch (userChoice)
            {
                case "1":
                    // Pull from WeekDay class to display the lists that are there for the day of the week on the user's system
                    break;
                case "2":
                    // Present the option for randomly generated list or personal customization
                    Console.Write("1. Personal Customization \n2. Randomly Generated");
                    int randomOrCustom = int.Parse(Console.ReadLine());

                    if (randomOrCustom == '1')
                    {
                        Console.WriteLine("Perfect! Let's create something.\nPlease select what you would like to focus on for Monday: ");
                        


                        // Change this later to call the Create Exercise method in User data to set everything up. 
                    }
                    if (randomOrCustom == '2')
                    {
                        //Put random Core, Cardio, Strength, and Flexibility generations into a list
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input, Please enter 1 or 2 ");
                    }


                    //If Personal, Have a day by day focus that is saved to a list.
                    // That list is saved to user data (user class), which is then saved to a specific week day (Date class).
                    // Make the user choose at least 2 exercises; check against list index of exercises?
                    // Set duration/set/weight of each individual exercise
                    // Display an option for the user to Save if they wish.
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
                default:
                    Console.WriteLine("Invalid input, please enter a number between 1 - 6");
                    break;
            }
        }

    }
}