using System;
namespace Goal
{
    public class ChecklistGoal : Goal
    {
        public int _amountCompleted = new int();
        public int _target;
        public int _bonus;
        public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points) //issues setting up constructor
        {
            _target = target;
            _bonus = bonus;

        }
        public override int RecordEvent()
        {
            _amountCompleted++;
            if (_amountCompleted % _target == 0)
            {
                return CompleteGoal() + _bonus;
            }
            return _points;
        }
        public override string GetFullDetails()
        {
            return $"{TextComplete()} {_shortName}: {_description} (Target complete {_amountCompleted}/{_target})";
        }
        public override string GetStringRepresentation()
        {
            string _event = string.Empty;
            _event = $"{_shortName}::{_description}::{_amountCompleted}::{_target}::{_points}::{_bonus}";
            return _event;
        }
        public override string ReturnType()
        {
            return "checklist";
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