using System;
public abstract class Activity
{
    private string _date = "";
    private int _lengthInMinute = 0;

    public Activity(string date, int lengthInMinute)
    {
        _date = date;
        _lengthInMinute = lengthInMinute;
    }

public int GetLengthInMinute()
{
    return _lengthInMinute;
}
public string GetDate()
{
    return _date;
}
public abstract double GetDistance();
public abstract double GetSpeed();
public abstract double GetPace();

public virtual string GetSummary()
{
    return $"{_date} - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";

}
}