public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsUSA()
    {
        if (_address.FromUSA() == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetCustomerInfo()
    {
        return $"{_name}, {_address.GetFullAddress()}";
    }
}