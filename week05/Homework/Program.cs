using System;
using Homework;
class Program
{
    static void Main(string[] args)
    {
        Assignment piece1 = new Assignment("Jon Folt", "PEMDAS");
        Console.WriteLine(piece1.GetSummary());

        MathAssignment piece2 = new MathAssignment("Josh Felt", "Geometry", "5.1", "1-30");
        Console.WriteLine(piece2.GetSummary());
        Console.WriteLine(piece2.GetHomeworkList());

        WritingAssignment piece3 = new WritingAssignment("Jim Fall", "300", "Chokepoint Strategy");
        Console.WriteLine(piece3.GetSummary());
        Console.WriteLine(piece3.GetWritingInformation());

    }
}