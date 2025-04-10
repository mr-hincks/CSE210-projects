using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32.SafeHandles;

public class Product
{
    //Private fields
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // constructor
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

        //return the total cost
    public double TotalCost()
    {
        return _price * _quantity;
    }

        //getter for name
    public string GetName()
    {
        return _name;
    }

        //getter for product ID
     public string GetProductId()
     {
         return _productId;
     }
}
