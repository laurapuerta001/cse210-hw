public class Running : Activity
{
    private double _distance;

    public Running(double length, string date, double distance) : base(length, date)
    {
        _distance = distance;
    }
    
    public override double CalculateDistance()
    {
        return _distance;
    }

    public override double CalculateSpeed()
    {
        double lenght = GetLength();
        return Math.Abs((_distance / lenght) * 60);
    }

    public override double CalculatePace()
    {
        double lenght = GetLength();
        return Math.Abs(lenght / _distance);
    }

    

}