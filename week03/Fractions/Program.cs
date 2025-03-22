using System;
using Fraction;

class Program
{
    static void Main(string[] args)
    {
        Fraction.Fraction Fraction1 = new Fraction.Fraction();
        
        Console.WriteLine("Input the top number.");
        Fraction1.SetTop(float.Parse(Console.ReadLine()));

        Console.WriteLine("Input the bottom number.");
        Fraction1.SetBottom(float.Parse(Console.ReadLine()));

        Console.WriteLine($"Fraction: {Fraction1.GetFractionString()}");
        Console.WriteLine($"Decimal: {Fraction1.GetDecimal()}");

        Console.WriteLine("--------");

        Fraction.Fraction Fraction2 = new Fraction.Fraction();
        Console.WriteLine($"Fraction: {Fraction2.GetFractionString()}");
        Console.WriteLine($"Decimal: {Fraction2.GetDecimal()}");

        Console.WriteLine("--------");

        Fraction.Fraction Fraction3 = new Fraction.Fraction(6);
        Console.WriteLine($"Fraction: {Fraction3.GetFractionString()}");
        Console.WriteLine($"Decimal: {Fraction3.GetDecimal()}");

        Console.WriteLine("--------");

        Fraction.Fraction Fraction4 = new Fraction.Fraction(6,7);
        Console.WriteLine($"Fraction: {Fraction4.GetFractionString()}");
        Console.WriteLine($"Decimal: {Fraction4.GetDecimal()}");

    }
}