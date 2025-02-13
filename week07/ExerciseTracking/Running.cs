using System;
public class Running : Activity
{
    private double _distance = 0.0;

    public Running(string date, int lengthInMinute, double distance) : base (date, lengthInMinute)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
     return _distance;
    }

    public override double GetSpeed()
    {
        // speed is 60 / pace
        double pace = GetPace();
        double speed = 60 / pace;
        return speed;
   
    }
    public override double GetPace()
    {
        
        //pace is time/ distance
        double pace = GetLengthInMinute() / _distance;
        return pace;
    }
    public override string GetSummary()
    {
        // use :F2 to format after two decimal
        return $"{GetDate()} Running ({GetLengthInMinute()} min) - Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}