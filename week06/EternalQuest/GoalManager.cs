using System;
using System.Linq.Expressions;
using Goal;
namespace GoalManager
{
    public class GoalManager
    {
        List<Goal.Goal> _goals = new List<Goal.Goal>();
        int _score = 0;
        public GoalManager()
        {
            
        }
        public void Start()
        {

            string _menuOption = "";
            while (_menuOption != "6" || _menuOption.ToLower() != "quit")
            {
                DisplayPlayerInfo();
                Console.WriteLine("\nMenu Options:");
                Console.WriteLine("    1. Create New Goal");
                Console.WriteLine("    2. List Goals");
                Console.WriteLine("    3. Save Goals");
                Console.WriteLine("    4. Load Goals");
                Console.WriteLine("    5. Record Event");
                Console.WriteLine("    6. Quit");
                Console.Write("\nSelect a choice from the menu: ");
                _menuOption = Console.ReadLine();
                switch (_menuOption)
                {
                    case "1":
                    {
                        //Create new goal
                        CreateGoal();
                        break;
                    }
                    case "2":
                    {
                        ListGoalDetails();
                        break;
                    }
                    case "3":
                    {
                        //Save goals
                        break;
                    }
                    case "4":
                    {
                        //Load goals
                        break;
                    }
                    case "5":
                    {
                        //Record event

                        ListGoalNames();
                        int i = int.Parse(Console.ReadLine())-1;
                        _score += _goals[i].RecordEvent();
                        break;
                    }

                }
            }  

        }
        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"You have {_score} points");
        }
        public void ListGoalNames()
        {
            //List goals
            int i = 0;
            Console.WriteLine("Goals List");
            foreach(Goal.Goal goal in _goals)
            {
                Console.WriteLine($"{i+1}. {goal.GetFullDetails()}");
                i++;
            }               
        }
        public void ListGoalDetails()
        {
            Console.WriteLine("Goals List");
            for (int i = 0;i < _goals.Count();i++)
            {
                Console.WriteLine(_goals[i].GetFullDetails());
            }
        }
        
        public void CreateGoal()
        {
            string _menuOption2 = "";
            Console.WriteLine("\nThe Types of Goals are:");
            Console.WriteLine("    1. Simple Goal");
            Console.WriteLine("    2. Eternal Goal");
            Console.WriteLine("    3. Checklist Goal");
            Console.WriteLine("\nWhich type of goal would you like to create? ");
            _menuOption2 = Console.ReadLine();
            string name = "";
            string description = "";
            int points = 0;
            int target = 0;
            int bonus = 0;
            switch (_menuOption2)
            {
                case "1":
                {   
                    Console.WriteLine("What is the Goal name? ");
                    name = Console.ReadLine();
                    Console.WriteLine("What is a short description of the goal? ");
                    description = Console.ReadLine();
                    Console.WriteLine("How many points is it worth? ");
                    points = int.Parse(Console.ReadLine());
                    SimpleGoal goal = new SimpleGoal(name, description,points);
                    _goals.Add(goal);
                    break;
                }
                case "2":
                {
                    Console.WriteLine("What is the Goal name?");
                    name = Console.ReadLine();
                    Console.WriteLine("What is a short description of the goal?");
                    description = Console.ReadLine();
                    Console.WriteLine("How many points is it worth?");
                    points = int.Parse(Console.ReadLine());
                    EternalGoal goal = new EternalGoal(name, description, points);
                    _goals.Add(goal);
                    break;
                }
                case "3":
                {
                    Console.WriteLine("What is the Goal name?");
                    name = Console.ReadLine();
                    Console.WriteLine("What is a short description of the goal?");
                    description = Console.ReadLine();
                    Console.WriteLine("How many points is each repetition worth?");
                    points = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the target amount of repetitions required to mark complete?");
                    target = int.Parse(Console.ReadLine());
                    Console.WriteLine("How many bonus points upon reaching the target number of repetitions?  (max of 6 digits)");
                    bonus = int.Parse(Console.ReadLine());
                    ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                    _goals.Add(goal);
                    break;
                }
            }


        }
        public void RecordEvent()
        {

        }
        public void SaveGoals()
        {

        }
        public void LoadGoals()
        {
            
        }
    }
}