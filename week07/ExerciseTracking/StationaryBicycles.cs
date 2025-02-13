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
        // use :F2 to format after two decimal
        return $"{GetDate()} Cycling ({GetLengthInMinute()} min) - Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}