using System;

public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        string summary = $"{_date} ({_minutes} min) - ";
        summary += $"Distance {GetDistance():0.0} km, ";
        summary += $"Speed {GetSpeed():0.0} kph, ";
        summary += $"Pace: {GetPace():0.0} min per km";

        return summary;
    }
}