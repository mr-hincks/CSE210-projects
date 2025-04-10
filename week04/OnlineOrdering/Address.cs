using System.Security.Authentication;

public class Address
{
    //private fields
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

     //Constructor
    public  Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country ;
    }
    //a method to return if the addrss is in USA or not
    public bool IsInUsa()
    {
        return _country.ToLower() =="usa";
    }
    //method to return full address string
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n {_city}, {_stateProvince}/n {_country}";
    }
}