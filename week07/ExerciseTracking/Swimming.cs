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
        return 0;
    }

    public override double GetSpeed()
    {
        // speed is 60 / pace
        
        return 0;
   
    }
    public override double GetPace()
    {
        
        //pace is time/ distance
       return 0;
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetLengthInMinute()} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}