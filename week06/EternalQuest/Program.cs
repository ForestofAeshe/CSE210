using System;
using Goal;
using GoalManager;
class Program
{
    static void Main(string[] args)
    {
        GoalManager.GoalManager GM = new GoalManager.GoalManager();
        GM.Start();
    }
}