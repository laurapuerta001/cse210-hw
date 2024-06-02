public class OutdoorGathering : Event 
{
    private string _weatherConditions;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weatherConditions = weather;
    }

    public string GetWeather()
    {
        return $" Wheather: {_weatherConditions}"; 
    }
}