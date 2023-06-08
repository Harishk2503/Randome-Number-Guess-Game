using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var randomNumber = rand.Next(1, 100);
            var Tries = 6;
            var triesLeft = Tries;

            
            Console.WriteLine("A random number between 1 and 99 has been generated.");
            Console.WriteLine("You have 6 tries to guess the number ");

            while (triesLeft > 0)
            {
                Console.WriteLine("Enter your guess: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == randomNumber)
                {
                    Console.WriteLine("You guessed the correct number.");
                    return;
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("The number is higher than your guess.");
                }
                else
                {
                    Console.WriteLine("The number is lower than your guess.");
                }

                triesLeft--;
                Console.WriteLine($"Remaining tries: {triesLeft}\n");
            }

            Console.WriteLine(" You ran out of tries.");
            Console.WriteLine($"The correct number was: {randomNumber}");
            Console.ReadLine();
        }
    }
}
