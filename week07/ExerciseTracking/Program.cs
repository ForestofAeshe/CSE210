using System;
using Exercise;
class Program
{
    static void Main(string[] args)
    {
        Exercise.Cycling myCycling = new Exercise.Cycling(30, 10);
        myCycling.GetSummary();
        Console.WriteLine();
        Exercise.Running myRunning = new Exercise.Running(60,10);
        myRunning.GetSummary();
        Console.WriteLine();
        Exercise.Swimming mySwimming = new Exercise.Swimming(30,0,60);
        mySwimming.GetSummary();

    }
}