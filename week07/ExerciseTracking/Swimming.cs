using System;
public class Swimming : Activity
{
    private double _numberOfLaps;

    public Swimming(string date, int lengInMinutes, double laps) : base (date, lengInMinutes)
    {
        _numberOfLaps = laps;
    }

     public override double GetDistance()
    {
        return (_numberOfLaps * 50) / (1000 * 0.62);
    }

    public override double GetSpeed()
    {
        // speed is 60 / pace
        double distance = GetDistance();
        double minutes = GetLengthInMinute();
        double speed = (distance / minutes ) * 60;
        return speed;

    }
    public override double GetPace()
    {
        
        double speed = GetSpeed();
        double pace = 60 / speed;
        return pace;
    }
    public override string GetSummary()
    { 
        // use :F2 to format after two decimal
        return $"{GetDate()} Swimming ({GetLengthInMinute()} min) - Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}