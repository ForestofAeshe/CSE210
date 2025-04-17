using System;
using System.Numerics;
namespace Goal
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points) : base(name, description, points)
        {
            
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
        protected override int CompleteGoal()
        {
            _isComplete = false;
            return _points;
        }
    }
}