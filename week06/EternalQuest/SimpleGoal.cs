using System;
namespace Goal
{
    public class SimpleGoal : Goal
    {
        bool _isComplete;
        public SimpleGoal(string name, string description, string points) : base(name, description, points)
        {
            _isComplete = false;

        }
        public override bool IsComplete()
        {
            _isComplete = true;
            return _isComplete;
        }
        public override void RecordEvent()
        {

        }
        public override string GetDetailsString()
        {
            return "simple test";
        }
        public override string GetStringRepresentation()
        {
            string _event = "";
            _event = $"{_shortName}::{_description}::{_points}::{IsComplete()}";
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
    }
}