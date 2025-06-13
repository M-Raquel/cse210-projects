using System;
//Mindfullness Program
class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program.\nIt was designed to help someone relax.");

        string startInput;

        //Keep track of how many times it loops through an activity
        int breathCount = 0; 
        int reflectCount = 0;
        int listCount = 0;

        do
        {
            //Menu System to allow user to choose 1 of 4 options.
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Start breathing activity");
            Console.WriteLine("    2. Start reflecting activity");
            Console.WriteLine("    3. Start listing activity");
            Console.WriteLine("    4. Quit");
            Console.Write("Select a choice from the menu: ");

            startInput = Console.ReadLine();

            if (startInput == "1")
            {
                Breathing breathe1 = new Breathing("name", "description", 0);
                breathe1.ShowAnimation();

                breathe1.Start("Breathing", "help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing");

                //The duration in the intial parameter doesn't matter, as it will be changed by the user later.
                breathe1.AlternateBreath(breathe1.GetDuration(5));
                breathe1.ShowAnimation();
                Console.Clear();

                breathCount++;
            }
            if (startInput == "2")
            {
                Reflection reflect1 = new Reflection("name", "description", 0);

                reflect1.Start("Reflection", "help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

                reflect1.Reflect(reflect1.GetDuration(5));
                Thread.Sleep(2000); //Time to see the End message
                Console.Clear();

                reflectCount++;

            }
            if (startInput == "3")
            {
                Listing list1 = new Listing("name", "description", 0);

                list1.Start("Listing", "help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

                list1.List(list1.GetDuration(5));
                Thread.Sleep(2000);
                Console.Clear();
                listCount++;

            }
            else
            {
                Console.WriteLine("Invalid input, try again");
            }

        } while (startInput != "4");
        //A log of how many times activities were performed
        int total = breathCount + listCount + reflectCount;
        Console.WriteLine($"You did a total of {total} activities. \n{breathCount} going through breathing exercises, {reflectCount} times reflecting on life, and {listCount} going through listing items. \nHope you have a good rest of your day!");
    }
}