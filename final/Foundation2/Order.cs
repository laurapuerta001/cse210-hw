public class Order 
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _products = products;
        _customer = customer;
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
        return _customer.GetCustomerInfo();
    }

}