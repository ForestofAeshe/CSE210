using System;

namespace Exercise
{
	public abstract class Exercise
	{
		protected DateTime _date;
		protected int _minutes;
		protected double _distance;
		public Exercise()
		{
			_date = DateTime.Now;
			_minutes = SetMinutes();
			_distance = SetDistance();
		}
		protected double GetSpeed()
		{
			//mph calulation
			double speed;
			float timeInHours;
			timeInHours = _minutes / 60;
			speed = _distance / timeInHours;
			return speed;
		}
		protected double GetPace()
		{
			return _minutes / _distance;
		}
		protected abstract double SetDistance();
        protected abstract int SetMinutes();
        protected double GetDistance()
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