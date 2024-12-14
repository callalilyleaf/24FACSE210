using System;

public class Outdoor : Event
{
    public Outdoor(string title, string description, string date, string time, Address address, string weatherStatement) : base(title, description, date, time, address)
    {   
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address.GetAddress();
        _eventType = "Outdoor Gatherings";
        _weatherStatement = weatherStatement;
    }

    //protected string _title; 
    // protected string _description;
    // protected string _date;
    // protected string _time;
    // protected string _eventType;
    // protected string _address;
    private string _weatherStatement;

    public override void PrintFullDetails()
    {
        Console.WriteLine($"Full Details:\nTitle: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}\nWeather Statement: {_weatherStatement}\n");
    }




}