using System;

class Program
{
    static void Main(string[] args)

    {

        Random randomGenerator = new Random();
        
        
        int magicNumber = randomGenerator.Next(1, 101);
        int guessCount = 0;  
        
        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            guessCount++;

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {guessCount} guesses.");
            }
        }
    }
}