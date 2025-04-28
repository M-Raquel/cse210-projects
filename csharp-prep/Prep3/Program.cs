using System;

class Program
{
    static void Main(string[] args)
    {
        // To see if the user wants to play again
        string playAgain = "no";
        do 
        {
            Random randomNumber = new Random();
            int m = randomNumber.Next(1,50);

            //A variable to increment while inside the loops
            int counter = 1;

            Console.Write("What is your guess? ");
            int g = int.Parse(Console.ReadLine());

            while (g != m)
            {
                if (g >= m)
                {
                    Console.WriteLine("Lower");
                    Console.Write("What is your guess? ");
                    g = int.Parse(Console.ReadLine());
                    counter ++;
                }
                else 
                {
                    Console.WriteLine("Higher");
                    Console.Write("What is your guess? ");
                    g = int.Parse(Console.ReadLine());
                    counter ++;
                }
            }
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"Your total number of guesses was {counter}");
            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();

        } while (playAgain == "yes");
    }
}