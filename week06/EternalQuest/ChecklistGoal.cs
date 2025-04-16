using System;
namespace Goal
{
    public class ChecklistGoal : Goal
    {
        public int _amountCompleted = new int();
        public int _target;
        public int _bonus;
        public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points) //issues setting up constructor
        {
            _target = target;
            _bonus = bonus;

        }
        public override void RecordEvent()
        {
            
        }
        public override bool IsComplete()
        {
            if (_amountCompleted % _target == 0)
            {
                return IsComplete();
            }
            else return false;
        }
        public override string GetDetailsString()
        {
            return "checklist test";
        }
        public override string GetStringRepresentation()
        {
            string _event = string.Empty;
            _event = $"{_shortName}::{_description}::{_amountCompleted}::{_target}::{_points}::{_bonus}";
            return _event;
        }
        public override string ReturnType()
        {
            return "simple";
        }
                public string GetName()
        {
            return _shortName;
        }
        public string GetDescription()
        {
            return _description;
        }
        public string GetPoints()
        {
            return _points;
        }
        public int GetTarget()
        {
            return _target;
        }
        public int GetBonus()
        {
            return _bonus;
        }

    }
}