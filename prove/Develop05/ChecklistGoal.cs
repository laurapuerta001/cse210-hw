public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        if (IsComplete() == false)
        {
            _amountCompleted++;
            if (_amountCompleted == _target)
            {
                IsComplete();
            }
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist Goal-{_shortName}-{_description}-{_points}-{_bonus}-{_target}-{_amountCompleted}";
    }

    public override string GetDetailsString()
    {
        string mark = "[ ]";
        if (IsComplete() == true){
            mark = "[X]";
        }
        return $"{mark} {_shortName} ({_description}) -- Current Progress: {_amountCompleted}/{_target}";
    }

    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

}