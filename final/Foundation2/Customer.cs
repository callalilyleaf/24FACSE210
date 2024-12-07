using System;
using System.Dynamic;

public class Customer
{
    private string _name;
    Address _address;
    public Customer(int i)
    {
        if (i == 0)
        {
            _name = "Timothée Chalamet";
            _address = new Address(0);

        }
        else if (i == 1)
        {
            _name = "Saoirse Ronan";
            _address = new Address(1);
        }
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public bool IsUSA()
    {
        return _address.IsUSA();
    }

    public string GetFullAddress()
    {
        return _address.GetFullAddress();
    }

}