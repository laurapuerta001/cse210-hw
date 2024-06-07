using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager(List<Goal> goals, int score)
    {
        _goals = goals;
        _score = score;
    }

    public void Start()
    {
        int choice = 0;

        while (choice != 7)
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Event");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Rewards");
            Console.WriteLine(" 7. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                CreateGoal();
            }
            else if (choice == 2)
            {
                ListGoalDetails();
            }
            else if (choice == 3)
            {
                SaveGoals();
            }
            else if (choice == 4)
            {
                LoadGoals();
            }
            else if (choice == 5)
            {
                RecordEvent();
            }
            else if (choice == 6)   
            {
                GetReward();
            }
            else if (choice == 7)
            {
                break;
            }
            else {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
        
        Console.WriteLine("Goodbye!");
        
    }

    //12. Shows creativity and exceeds core requirements
    public void GetReward()
    {
        List<Reward> rewards = new List<Reward>(); 
        rewards.Add(new Reward("Chocolate", 5));
        rewards.Add(new Reward("Candy", 10));
        rewards.Add(new Reward("Cupcake", 15));
        rewards.Add(new Reward("Treat", 20));
        rewards.Add(new Reward("Candy bar", 25));

        Console.WriteLine("Rewards: ");
        int id = 1;
        foreach (Reward reward in rewards)
        {
            Console.WriteLine($"{id}. {reward.GetName()} - {reward.GetPoints()} points");
            id += 1;
        }

        Console.WriteLine("Which reward would you like to earn? ");
        int rewardId = int.Parse(Console.ReadLine());
        int points = rewards[rewardId - 1].GetPoints();
        if (_score >= points)
        {
            _score -= points;
            Console.WriteLine($"Congratulations! You have earned {rewards[rewardId - 1].GetName()}!");
            Console.WriteLine($"You now have {_score} points.");
        }
        else
        {
            Console.WriteLine("You do not have enough points to earn this reward.");
        }
        
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");

    }

    public void ListGoalNames()
    {
        int id = 0;
        foreach (Goal goal in _goals)
        {
            id += 1;
            Console.WriteLine($"{id}. {goal.GetShortName()}");
        }

    }

    public void ListGoalDetails()
    {
        int id = 0;
        foreach (Goal goal in _goals)
        {
            id += 1;
            Console.WriteLine($"{id}. {goal.GetDetailsString()}");
        }
        
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int goalPoints = int.Parse(Console.ReadLine());

        if (goalType == 1)
        {
            _goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints));
        }
        else if (goalType == 2)
        {
            _goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
        }
        else if (goalType == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int goalTimes = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int goalBonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, goalTimes, goalBonus));

        }

    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish? ");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{_goals.IndexOf(goal) + 1}. {goal.GetShortName()}");
        }
        int goalId = int.Parse(Console.ReadLine());

        goalId -= 1;

        _goals[goalId].RecordEvent();

        
        if (_goals[goalId] is ChecklistGoal)
        {
            _score += _goals[goalId].GetPoints();
            if (_goals[goalId].IsComplete())
            {
                _score += int.Parse(_goals[goalId].GetStringRepresentation().Split("-")[4]);
            }
        }   
        else
        {
            _score += _goals[goalId].GetPoints();
        }

    }

    public void SaveGoals()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the filename? ");
        string filename = Console.ReadLine();

        _goals = new List<Goal>();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("-");

            if (parts.Length == 1)
            {
                _score = int.Parse(line);
            }
            else{
            
                string goalType = parts[0];
                string goalName = parts[1];
                string goalDescription = parts[2];
                string goalPoints = parts[3];

                if (goalType == "Simple Goal")
                {
                    _goals.Add(new SimpleGoal(goalName, goalDescription, int.Parse(goalPoints)));
                    string status = parts[4];

                    if (status == "True")
                    {
                        _goals[_goals.Count - 1].RecordEvent();
                    }
                }
                else if (goalType == "Eternal Goal")
                {
                    _goals.Add(new EternalGoal(goalName, goalDescription, int.Parse(goalPoints)));
                }
                else if (goalType == "Checklist Goal")
                {
                    int goalBonus = int.Parse(parts[4]);
                    int goalTarget = int.Parse(parts[5]);
                    int goalTimes = int.Parse(parts[6]);

                    _goals.Add(new ChecklistGoal(goalName, goalDescription, int.Parse(goalPoints), goalTarget, goalBonus));
                    
                    if (goalTimes > 0)
                    {
                        if (_goals[_goals.Count - 1] is ChecklistGoal derivedGoal)
                        {
                            derivedGoal.SetAmountCompleted(goalTimes);
                        }
                    }

                }
            }
            
            
        }
        Console.Clear();

    }
}