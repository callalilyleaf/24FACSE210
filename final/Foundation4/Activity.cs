using System;

public abstract class Activity
{   
    protected double _distance;
    protected double _speed;
    protected double _pace;
    protected int _time;
    protected string _date;
    protected string _activityName;

    public abstract void Calculate(); //(double distance, double speed, double pace, double time)

    public void PrintSummary()
    {
        Console.WriteLine($"{_date} {_activityName} ({_time}min) - Distance: {_distance} miles, Speed: {_speed} mph, Pace: {Math.Round(_pace, 2)} min/mile\n");
        //03 Nov 2022 Running (30 min)- Distance: 3.0 miles, Speed: 6.0 mph, Pace: 10.0 min per mile
    }
}