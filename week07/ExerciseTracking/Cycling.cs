using System;
namespace Exercise
{
    public class Cycling : Exercise
    {
        public Cycling() : base()
		{

		}
        protected override double SetDistance()
        {
            // Console.WriteLine("How many miles did you cycle?");
            // _distance = double.Parse(Console.ReadLine());
            _distance = 10;
            return _distance;
        }
        protected override int SetMinutes()
        {
            // Console.WriteLine("How many minutes did you cycle?");
            // _minutes = float.Parse(Console.ReadLine());
            _minutes = 30;
            return _minutes;
        }
        public override void GetSummary()
        {
            Console.WriteLine($"{GetDate()} ({GetMinutes()} min): Distance {GetDistance()}, Speed {GetSpeed()} mph, Pace {GetPace()} min per mile.");
        }
    }
}