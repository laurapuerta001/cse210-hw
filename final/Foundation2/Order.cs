public class Order 
{
    private List<Product> _products = new List<Product>();
    private Customer _costumer;

    public Order(Customer costumer, List<Product> products)
    {
        _products = products;
        _costumer = costumer;
    }

    public double CalculateTotal(Customer customer)
    {
        double total = 0;
        int shippmentCost = 5;
        foreach (Product product in _products)
        {
            total += product.CalculateTotal();
        }
        if (customer.IsUSA())
        {
            total += shippmentCost;
        }
        else 
        {
            total += 33;
        }
        return total;
    }

    public string PackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += product.GetLabelInfo() + "\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return _costumer.GetCustomerInfo();
    }

}