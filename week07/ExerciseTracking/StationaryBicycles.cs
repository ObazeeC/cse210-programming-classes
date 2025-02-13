using System;
using System.Transactions;
public class StationaryBicycles : Activity
{
    private double _speed ;

    public StationaryBicycles(string date, int lengthInMinute, double speed) : base(date, lengthInMinute)
    {
        _speed = speed;
    }


    public override double GetPace()
    {
        
        //pace is time/ distance
        double pace = 60/ _speed;
        return pace;
    }
    public override double GetDistance()
    {
        double distance = 0;
        double minutes = GetLengthInMinute();
        double pace = GetPace();
        distance = minutes/pace;
       return distance;
    }

    public override double GetSpeed()
    {
        // speed is 60 / pace
        
        return _speed;
   
    }
    
    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetLengthInMinute()} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}