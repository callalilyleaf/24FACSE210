using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(int i)
    {
        if (i == 0)
        {
            _streetAddress = "1101 Cantebury Drive";
            _city = "New York";
            _stateOrProvince = "NY";
            _country = "USA";
        }
        else if (i == 1)
        {
            _streetAddress = "Unit 35 Finglas Business Centre Jamestown Road";
            _city = "Dublin";
            _stateOrProvince = "County Dublin 11";
            _country = "Ireland";
        }
    }

    public string GetStreetAddress()
    {
        return _streetAddress;
    }

    public void SetStreetAddress(string streetAddress)
    {
        _streetAddress = streetAddress;
    }

    public string GetCity()
    {
        return _city;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetStateOrProvince()
    {
        return _stateOrProvince;
    }

    public void SetStateOrProvince(string stateOrProvince)
    {
        _stateOrProvince = stateOrProvince;
    }

    public string GetCountry()
    {
        return _country;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }

    public bool IsUSA()
    {
        return _country.ToUpper() == "USA";
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}, {_city}, {_stateOrProvince}, {_country}";
    }

}