using System;
namespace Goal
{
    public abstract class Goal
    {
        public string _shortName;
        public string _description;
        public int _points;
        public bool _isComplete;
        public Goal(string name, string description, int points = 0)
        {
            _shortName = name;
            _description = description;
            _points = points;
            _isComplete=false;
        }

        public virtual int RecordEvent()
        {
            return CompleteGoal();
        }
        public string TextComplete()
        {
            if (_isComplete)
            {
            return "[X]";
            }
            else return "[ ]";
        }
        public bool IsComplete()
        {
            return _isComplete;
        }
        protected virtual int CompleteGoal()
        {
            _isComplete = true;
            return _points;
        }
        public virtual string GetFullDetails()
        {
            return $"{TextComplete()} {_shortName}: {_description}";
        }
        public abstract string GetStringRepresentation();
        public abstract string ReturnType();
        public virtual string GetName()
        {
            return _shortName;
        }
        public virtual string GetDescription()
        {
            return _description;
        }
        public virtual int GetPoints()
        {
            return _points;
        }

    }
}