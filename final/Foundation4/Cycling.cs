public class Cycling : Activity
{
    private double _speed;
    
    public Cycling(double length, string date, double speed) : base(length, date)
    {
        _speed = speed;
    }
    public override double CalculateDistance()
    {
        double length = GetLength();
        return Math.Abs(((_speed / 60)) * length);
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override double CalculatePace()
    {
        double length = GetLength();
        double distance = CalculateDistance();
        return Math.Abs(length / distance);
    }

}