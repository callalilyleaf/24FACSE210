using System;
using System.Globalization;

public class Running : Activity
{
    public Running(string date, int time, double distance) : base()
    {   
        _date = date;
        _activityName = "Running";
        _time = time;
        _distance = distance;
    }

    public override void Calculate() //(double distance, double speed, double pace, double time)
    {
        double speed = _distance * 60.0 / _time;
        double pace = _time / _distance;

        _speed = speed;
        _pace = pace;
    }


}