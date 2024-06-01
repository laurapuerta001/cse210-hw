public class Product
{
    private string _name;
    private double _price;
    private int _id;
    private int _quantity;

    public Product(string name, double price, int id, int quantity)
    {
        _name = name;
        _price = price;
        _id = id;
        _quantity = quantity;
    }

    public double CalculateTotal()
    {
        double total = _price * _quantity;
        //Console.WriteLine($"The total cost of {_quantity} {_name}(s) is ${total}.");
        return total;
    }

    public string GetLabelInfo()
    {
        return $"{_name} | ID: {_id}";
    }

}