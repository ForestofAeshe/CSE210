using System;
namespace Goal
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, string points) : base(name, description, points)
        {
            
        }
        public override void RecordEvent()
        {
        
        }
        public override bool IsComplete()
        {
            return false;
        }
        public override string GetDetailsString()
        {
            return "eternal test";
        }
        public override string GetStringRepresentation()
        {
            string _event = string.Empty;
            _event = $"{_shortName}::{_description}::{_points}";
            return _event;
        }
        public override string ReturnType()
        {
            return "eternal";
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