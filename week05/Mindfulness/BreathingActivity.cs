using System;
public class BreathingActivity : Activity
{

public BreathingActivity(string name, int duration) : base (name,  duration)
{
 _startingMessage = "This activity will help you relax by walking your through breathing in and out slowly. Clear you mind and focus on your breathing";
}

public void Run()
{
         
          Console.Write("Breathe in...");
          ShowCountDown(6);
          Console.WriteLine();
          Thread.Sleep(1000);
          Console.Write("Now Breathe out...");
          ShowCountDown(6);
          Thread.Sleep(1000);
          Console.WriteLine();
          Console.WriteLine();

}
}