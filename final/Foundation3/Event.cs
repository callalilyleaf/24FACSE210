using System;

public abstract class Event
{   
    protected string _title; 
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _eventType;
    protected string _address;

    public Event(string title, string description, string date, string time, Address address)
    {   
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address.GetAddress();
    }

    public void PrintStandardDetails()
    {
        Console.WriteLine($"Standard Details:\nTitle: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}\n");
    }

    public void PrintShortDescription()
    {
        Console.WriteLine($"Short Description: {_eventType}\nTitle: {_title}\nDate: {_date}\n");
    }

    public abstract void PrintFullDetails();
    // Depend on the event, put different attributes in it.




}