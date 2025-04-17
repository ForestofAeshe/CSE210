using System;

namespace Exercise
{
	public abstract class Exercise
	{
		protected DateTime _date;
		protected int _minutes;
		protected double _distance;
		public Exercise(int minutes, double distance)
		{
			_date = DateTime.Now;
            SetMinutes(minutes);
            SetDistance(distance);



		}
		protected double GetSpeed()
		{
			//mph calulation
			double speed;
			float timeInHours;
			timeInHours = (float)_minutes / 60;
			speed = _distance / timeInHours;
			return speed;
		}
		protected double GetPace()
		{
			return (double)_minutes / _distance;
		}
		protected virtual void SetDistance(double distance)
        {
            _distance = distance;
        }
        protected virtual void SetMinutes(int minutes)
        {
            _minutes = minutes;
        }
        protected virtual double GetDistance()
        {
            return _distance;
        }

        protected float GetMinutes()
        {
            return _minutes;
        }
        protected DateTime GetDate()
        {
            return _date;
        }

        public abstract void GetSummary();
	}
}