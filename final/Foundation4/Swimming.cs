using System;
using System.Globalization;

public class Swimming : Activity
{
    public Swimming(string date, int time, int swimmingLaps) : base()
    {      
        _date = date;
        _activityName = "Swimming in the lap Pool";
        _time = time;
        _swimmingLaps = swimmingLaps;
    }
    private int _swimmingLaps;

    public override void Calculate() //(double distance, double speed, double pace, double time)
    {   
        double distance = _swimmingLaps * 50 * 0.62 / 1000 ;
        double speed = distance / _time * 60.0;
        double pace = 60 / speed;


        _distance = distance;
        _speed = speed;
        _pace = pace;
    }


}