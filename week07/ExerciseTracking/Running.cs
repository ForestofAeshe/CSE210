using System;
namespace Exercise
{
    public class Running : Exercise
    {
        public Running() : base()
		{

		}
        protected override double SetDistance()
        {
            // Console.WriteLine("How many miles did you run?");
            // _distance = float.Parse(Console.ReadLine());
            _distance = 10;
            return _distance;
        }
        protected override int SetMinutes()
        {
            // Console.WriteLine("How many minutes did you run?");
            // _minutes = float.Parse(Console.ReadLine());
            _minutes = 60;
            return _minutes;
        }
        public override void GetSummary()
        {
            Console.WriteLine($"{GetDate()} ({GetMinutes()} min): Distance {GetDistance()}, Pace {GetPace()} min per mile.");
        }
    }
}