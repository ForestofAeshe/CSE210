using System;
namespace Exercise
{
    public class Swimming : Exercise
    {
        float _laps;
        public Swimming(int minutes, double distance, float laps) : base(minutes, distance)
		{
            SetLaps(laps);
            SetDistance((double)_laps * .031);
		}
        protected void SetLaps(float laps)
        {
            // Console.WriteLine("How many laps did you swim?");
            // _laps = float.Parse(Console.ReadLine());
            _laps = laps;
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