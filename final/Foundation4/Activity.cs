public abstract class Activity
{
    private string _date;
    private double _length;

    public Activity(double length, string date)
    {
        _date = date;
        _length = length;
    }

    public string GetSummary()
    {
        return $"{GetDate()} ({GetLength()} min) - Distance: {CalculateDistance()} km, Speed: {CalculateSpeed()} kph, Pace: {CalculatePace()} min per km"; 
    }

    public string GetDate()
    {
        return _date;
    }

    public double GetLength()
    {
        return _length;
    }

    public virtual double CalculateDistance()
    {
        return 0;
    }

    public virtual double CalculateSpeed()
    {
        return 0;
    }

    public virtual double CalculatePace()
    {
        return 0;
    }
}