using System;

public class Lecture : Event
{
    public Lecture(string title, string description, string date, string time, Address address, string speakerName, int capacity) : base(title, description, date, time, address)
    {   
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address.GetAddress();
        _eventType = "Lectures";
        _speakerName = speakerName;
        _capacity = capacity;
    }

    private string _speakerName;
    private int _capacity;

    public override void PrintFullDetails()
    {
        Console.WriteLine($"Full Details:\nTitle: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}\n Speaker: {_speakerName}\n Capacity: {_capacity} attendees\n");
    }



}