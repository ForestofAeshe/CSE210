using System;
using Exercise;
class Program
{
    static void Main(string[] args)
    {
        Exercise.Cycling myCycling = new Exercise.Cycling();
        myCycling.GetSummary();
        Console.WriteLine();
        Exercise.Running myRunning = new Exercise.Running();
        myRunning.GetSummary();
        Console.WriteLine();
        Exercise.Swimming mySwimming = new Exercise.Swimming();
        mySwimming.GetSummary();
        
    }
}