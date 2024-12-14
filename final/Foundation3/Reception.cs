using System;

public class Reception : Event
{
    public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {   
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address.GetAddress();
        _eventType = "Receptions";
        _email = email;
    }

    private string _email;

    public override void PrintFullDetails()
    {
        Console.WriteLine($"Full Details:\nTitle: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}\nRSVP: {_email}\n");
    }

}