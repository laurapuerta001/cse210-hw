public class Swimming : Activity
{
    private double _laps;

    public Swimming(double length, string date, double laps) : base(length, date)
    {
        _laps = laps;
    }
    public override double CalculateDistance()
    {
        return Math.Abs(_laps * 50 / 1000);
    }

    public override double CalculateSpeed()
    {
        double distance = CalculateDistance();
        double lenght = GetLength();
        return Math.Abs((distance / lenght) * 60);
    }

    public override double CalculatePace()
    {
        double distance = CalculateDistance();
        double lenght = GetLength();
        return Math.Abs(lenght / distance);
    }

}