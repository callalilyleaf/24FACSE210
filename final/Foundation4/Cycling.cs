using System;
using System.Globalization;
using System.Runtime.CompilerServices;

public class Cycling : Activity
{
    public Cycling(string date, int time, double speed) : base()
    {   
        _date = date;
        _activityName = "Stationary Bicycle";
        _time = time;
        _speed = speed;
    }

    public override void Calculate() //(double distance, double speed, double pace, double time)
    {
        double distance = _speed * _time / 60;
        double pace = 60 / _speed;

        _distance = distance;
        _pace = pace;
    }


}