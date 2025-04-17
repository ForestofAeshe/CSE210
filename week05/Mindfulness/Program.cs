using System;
using Exercise;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        string name = "";
        string description = "";
        int duration = 0;
        int count = 0;

        string menuOption = "";
        do
        {
            Exercise.Activity menuList = new Exercise.Activity("place","holder",0);
            menuList.DisplayStartingMessage();
            Console.WriteLine($"1. Breathing Activity\n2. Listing Activity\n3. Reflecting Activity\n");
            Console.WriteLine("Please select an option by typing a number OR type 'quit' to exit.");
            menuOption = Console.ReadLine();

            switch (menuOption)
            {
                case "1":
                {
                    //breathing activity
                    name = "Breathing Activity";
                    description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
                    Console.Write("Input a duration, in seconds, that you would like to perform this activity.");
                    duration = Console.Read();
                    BreathingActivity MyActivity = new BreathingActivity(name,description,duration);
                    MyActivity.Run();
                    break;
                }
                case "2":
                {
                    //listing activity
                    name = "Listing Activity";
                    description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                    Console.Write("Input a duration, in seconds, that you would like to perform this activity.");
                    duration = Console.Read();
                    Console.WriteLine("Input a count, in seconds, that you would like to pause in the middle of this activity.");
                    count = Console.Read();
                    ListingActivity MyActivity = new ListingActivity(name,description,duration,count);
                    MyActivity.Run();
                    break;
                }
                case "3":
                {
                    //reflecting activity
                    name = "Reflecting Activity";
                    description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                    Console.Write("Input a duration, in seconds, that you would like to perform this activity.");
                    duration = Console.Read();
                    ReflectingActivity MyActivity = new ReflectingActivity(name,description,duration);
                    MyActivity.Run();
                    break;
                }
            }
        } while (menuOption != "quit");
    }
}