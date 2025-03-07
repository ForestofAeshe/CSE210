using System;

class Program
{
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite whole number? ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int numberInput)
        {
            return numberInput * numberInput;
        }

        static void DisplayResult(int numberInput, string name)
        {
            Console.WriteLine($"{name}, the square of your favorite number is {numberInput}.");
            
        }
    
    static void Main(string[] args)
    {
        
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);
        DisplayResult(squaredNumber, name);

    }
    
}