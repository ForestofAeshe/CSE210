using System;
namespace Exercise
{
    public class Swimming : Exercise
    {
        float _laps;
        public Swimming() : base()
		{
            _laps = SetLaps();
		}
        protected override double SetDistance()
        {
            _distance = _laps * 50 / 1000 * .62;
            return _distance;
        }
        protected override int SetMinutes()
        {
            // Console.WriteLine("How many minutes did you swim?");
            // _minutes = float.Parse(Console.ReadLine());
            _minutes = 25;
            return _minutes;
        }
        protected float SetLaps()
        {
            // Console.WriteLine("How many laps did you swim?");
            // _laps = float.Parse(Console.ReadLine());
            _laps = 200;
            return _laps;
        }
        protected float GetLaps()
        {
            return _laps;
        }
        public override void GetSummary()
        {
            Console.WriteLine($"{GetDate()} ({GetMinutes()} min): Distance {GetDistance()}, Laps {GetLaps()}, Pace {GetPace()} min per mile.");
        }
    }
}