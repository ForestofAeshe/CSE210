using System;

class Program
{
    static void Main(string[] args)
    {
        string response;
        int timesPlayed = 0;
        
        do
        {
            int guessCount = 0;

            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,101);
            
            Console.WriteLine("What number do  you think is the magic number?");
            Console.WriteLine("Pick a number from 1 to 100");
            int guessedNumber = int.Parse(Console.ReadLine());
            
            while (magicNumber > 0)
            {
                if (guessedNumber > magicNumber)
                {
                    Console.WriteLine($"You guessed {guessedNumber}. Guess again, but lower.");
                    guessedNumber = int.Parse(Console.ReadLine());
                    guessCount++;
                }
                else if (guessedNumber < magicNumber)
                {
                    Console.WriteLine($"You guessed {guessedNumber}. Guess again, but higher.");
                    guessedNumber = int.Parse(Console.ReadLine());
                    guessCount++;
                }
                else
                {
                    Console.WriteLine($"Success, you got it!! You guessed {guessedNumber}. The number was {magicNumber}.");
                    guessCount++;
                    break;
                }
            }
            Console.WriteLine($"It took you {guessCount} guesses.");

            timesPlayed++;
            
            Console.WriteLine($"You have played {timesPlayed} times.");

            Console.WriteLine("Would you like to play again? yes/no: ");
            response = Console.ReadLine();
        } while (response == "yes");

    Console.WriteLine("Thank you for playing!");
    Console.WriteLine($"You played {timesPlayed} times.");
    }
}