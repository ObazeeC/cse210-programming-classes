using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercise Tracking! This is the ExerciseTracking Project.");
        Console.WriteLine("--------------------------------------------------------");
        
        // Create three instances for each activities

        // Running Activities
        Running r = new("03 Nov 2022", 30, 4.8 );
        Running r1 = new("17 June 2023", 45, 5.0 );
        Running r2 = new("9 August 2002", 60, 6.0 );
       
        // Cycling Acvities
        StationaryBicycles s = new("21 March 2025", 30, 45);
        StationaryBicycles s1 = new("6 April 2024", 120, 55);
        StationaryBicycles s2 = new("3 Dec 2001", 130, 65);
       
        // Swimming Activities
        Swimming swimming = new("25 May, 1996", 30, 77); 
        Swimming swimming01 = new("13 May, 2000", 40, 87); 
        Swimming swimming02 = new("1 Oct, 2002", 60, 97); 
         
        // Add the three different Activities to a List of Activity
        // Call the base GetSummary method that will be overridden in the individual Activities class
            List<Activity>_activities = new();
            _activities.Add(r);
            _activities.Add(r1);
            _activities.Add(r2);
            _activities.Add(s);
            _activities.Add(s1);
            _activities.Add(s2);
            _activities.Add(swimming);
            _activities.Add(swimming01);
            _activities.Add(swimming02);
            foreach(Activity x in _activities)
            {
                Console.WriteLine(x.GetSummary());
                Console.WriteLine();
            }
            



    }
}