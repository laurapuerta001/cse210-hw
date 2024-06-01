using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        GoalManager goalManager = new GoalManager(goals, 0);
        goalManager.Start();
    }
       
}