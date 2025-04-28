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
            string guess = Console.ReadLine();
            int g = int.Parse(guess);

            while (g != m)
            {
                if (g >= m)
                {
                    Console.WriteLine("Lower");
                    Console.Write("What is your guess? ");
                    string newGuess = Console.ReadLine();
                    g = int.Parse(newGuess);
                    counter ++;

                }
                else 
                {
                    Console.WriteLine("Higher");
                    Console.Write("What is your guess? ");
                    string newGuess = Console.ReadLine();
                    g = int.Parse(newGuess);
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