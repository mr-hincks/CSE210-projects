public class Customer
{
    // Private fields
    private string _name;
    private Address _address;

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to check if customer is in USA
    public bool IsInUsa()
    {
        return _address.IsInUsa();
    }

    // Getter for name
    public string GetName()
    {
        return _name;
    }

    // Getter for address
    public Address GetAddress()
    {
        return _address;
    }
}