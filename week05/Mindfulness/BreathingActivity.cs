using System;

namespace Exercise
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
        {
            
        }

        public void Run()
        {
            Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
            Console.WriteLine("\n Please slowly breath in every 4-5 seconds. Then slowlybreath out every 4-5 seconds. \n If the timer runs out while you are breathing, finish your breath. \n");
            ShowCountDown(_duration);
            Console.WriteLine("Activity Complete");
        }
    }
}