public class SimpleGoal : Goal
{
    private bool _isCompleted;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        _isCompleted = true;
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
    }

    public override bool IsComplete()
    {
        if (_isCompleted == true)
        {
            return true;
        }
        return false;
    }

    public override string GetStringRepresentation()
    {
        return  $"Simple Goal-{_shortName}-{_description}-{_points}-{_isCompleted}";
    }

}