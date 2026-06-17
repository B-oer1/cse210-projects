using System;

public class Customer
{
    private readonly string _name;
    private readonly Address _address;

    public Customer(string name, Address address)
    {
        _name = name ?? string.Empty;
        _address = address ?? new Address(string.Empty, string.Empty, string.Empty, string.Empty);
    }

    public bool LivesInUsa()
    {
        return _address.LivesInUsa();
    }

    public string GetName()
    {
        return _name;
    }

    // Return the full address as a single string (matching existing callers)
    public string GetAddress()
    {
        return _address.GetFullAddressString();
    }
}