public class Reward
{
    private string _name;
    private int _points;
    public Reward(string name, int points)
    {
        _name = name;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetPoints()
    {
        return _points;
    }
}