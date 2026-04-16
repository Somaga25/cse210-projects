using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distance = (_laps * 50) / 1000.0;
        return distance;
    }

    public override double GetSpeed()
    {
        double speed = (GetDistance() / GetMinutes()) * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = GetMinutes() / GetDistance();
        return pace;
    }
}