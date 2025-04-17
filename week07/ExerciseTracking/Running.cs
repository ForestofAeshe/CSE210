using System;
namespace Exercise
{
    public class Running : Exercise
    {
        public Running(int minutes, double distance) : base(minutes, distance)
		{

		}
        public override void GetSummary()
        {
            Console.WriteLine($"{GetDate()} ({GetMinutes()} min): Distance {GetDistance()}, Pace {GetPace()} min per mile.");
        }
    }
}