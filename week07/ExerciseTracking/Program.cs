using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercise Tracking! This is the ExerciseTracking Project.");
        Console.WriteLine("--------------------------------------------------------");

        Running r = new("03 Nov 2022", 30, 4.8 );
        Console.WriteLine(r.GetSummary());
       // Console.WriteLine($"Pace {r.GetPace()}");
       // Console.WriteLine($"Speed {r.GetSpeed()}");
        Console.WriteLine();
        Running r1 = new("04 Nov 2022", 30, 3.0 );
        Console.WriteLine(r1.GetSummary());
        
         Console.WriteLine("/////");
       // StationaryBicycles s = new("21 March 2024", 60, 45);
       // Console.WriteLine(s.GetSummary());

        StationaryBicycles s1 = new("21 March 2024", 30, 45);
       // Console.WriteLine(s1.GetSummary());
        Console.WriteLine(s1.GetDistance());
         Console.WriteLine(s1.GetSpeed());
         Console.WriteLine(s1.GetSummary());


    }
}