using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of positive integers, type 0 when finished.");
            
        int dataEntry;

        do
        {
            dataEntry = int.Parse(Console.ReadLine());
            numbers.Add(dataEntry);
            if (numbers.Contains(0))
            {
                numbers.Remove(0);
                break;
            }
        } while (dataEntry != 0);

        Console.Write($"List of numbers: ");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.Write($"{numbers[i]} ");
        }
        Console.WriteLine();

        //total sum of list and largest number
        int total = 0;
        int max = numbers[0];
        int smallestPositive = numbers[0];
        
        for (int i = 0; i < numbers.Count; i++)
        {
            total += numbers[i];

            if (numbers[i] > max)
            {
                max = numbers[i];
            }
            
            if (numbers[i] < smallestPositive && numbers[i] > 0)
            {
                smallestPositive = numbers[i];
            }
        }

        Console.WriteLine($"Sum of everything is: {total}");

        //average of list
        float average = total / numbers.Count;

        Console.WriteLine($"Average: {average.ToString("F3")}");

        //largest number
        Console.WriteLine($"Max number: {max}");

        //smallest positive number
        if (smallestPositive == 0)
        {
            Console.WriteLine("No positive numbers!");
        }
        else
        {
            Console.WriteLine($"Smallest positive number: {smallestPositive}");
        }

        numbers.Sort();
                Console.Write($"List of numbers: ");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.Write($"{numbers[i]} ");
        }
        Console.WriteLine();

        numbers.Reverse();
                Console.Write($"List of numbers: ");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.Write($"{numbers[i]} ");
        }
        Console.WriteLine();

    }
}