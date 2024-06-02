public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $" {_title}: {_description} \n Date: {_date} Time: {_time} \n Address: {_address.GetFullAddress()}";
    }

    public string GetShortDescription(string type)
    {
        return $"{type}: {_date} - {_title}";
    }


}