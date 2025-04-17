using System;
namespace Goal
{
    public class SimpleGoal : Goal
    {
        public SimpleGoal(string name, string description, int points) : base(name, description, points)
        {
        
        }

        public override string GetStringRepresentation()
        {
            return $"{_shortName}::{_description}::{_points}::{TextComplete()}";
        }
        public override string ReturnType()
        {
            return "simple";
        }
    }
}