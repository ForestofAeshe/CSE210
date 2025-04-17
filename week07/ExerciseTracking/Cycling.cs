using System;
namespace Exercise
{
    public class Cycling : Exercise
    {
        public Cycling(int minutes, double distance) : base(minutes, distance)
		{
            
		}
        public override void GetSummary()
        {
            Console.WriteLine($"{GetDate()} ({GetMinutes()} min): Distance {GetDistance()}, Speed {GetSpeed()} mph, Pace {GetPace()} min per mile.");
        }
    }
}