using System;
public class BreathingActivity : Activity
{

public BreathingActivity(string name, string description, int duration) : base (name, description, duration)
{

}

public void Run()
{
    /*
         Console.WriteLine($"Welcome to the {GetActivityName} Activity. ");
         Console.WriteLine("");
         Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear you mind and focus on your breathing");
         Console.WriteLine(""); 
         */
         Console.WriteLine("Breath in...");
         // in between
         Console.WriteLine("Breath out...");

         // I want run this repeatedly until the time elapse.


}
}