using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        Console.WriteLine("I'm thinking of a number between 1 and 100.");
        int guess = -1;

        while (guess != number)
        {

            Console.Write("What is your guess?");
            guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Too high. Guess again.");
            }
            else if (guess < number)
            {
                Console.WriteLine("Too low. Guess again.");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}