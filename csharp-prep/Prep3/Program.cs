using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        string userResponse = "yes";
        while (userResponse == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guessNumber = -1;
            int guessCounter = 0;

            while (guessNumber != magicNumber)
            {
                Console.Write("What is your guess? ");

                guessNumber = int.Parse(Console.ReadLine());

                if (guessNumber > magicNumber) 
                {
                    Console.WriteLine("Lower");
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else 
                {
                    Console.WriteLine("You guessed it!");
                }
                guessCounter++;
            }
            Console.WriteLine($"You guessed {guessCounter} time(s).");
            Console.Write("Do you want to play again (yes/no)? ");
            userResponse = Console.ReadLine().ToLower();
        }
    }
}