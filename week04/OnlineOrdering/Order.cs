public class Order
{
    // Private fields
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // Method to add product
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Method to calculate total cost
    public double CalculateTotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.TotalCost();
        }

        // Add shipping cost
        total += _customer.IsInUsa() ? 5 : 35;
        return total;
    }

    // Method to get packing label
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    // Method to get shipping label
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}